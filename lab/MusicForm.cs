#nullable enable
using System;
using System.Linq;
using System.Windows.Forms;
using lab.track;

namespace lab {
public partial class MusicForm : Form {
    public int Id { get; }

    public ToolStrip UpperMenuStrip => upperMenuStrip;

    private readonly MusicFormState _state;

    public MusicForm(TracksState tracksState, int id = 0) {
        Id = id;
        InitializeComponent();
        _state = new MusicFormState(tracksState);
        _state.TrackAdded += AddTrack;
        _state.TrackUpdated += UpdateTrack;
        _state.TrackDeleted += DeleteTrack;
    }

    private void DeleteTrack(TrackDto dto) {
        // Find item that matches previous one by name -> remove
        for (var i = 0; i < tracksView.Items.Count; i++) {
            var name = ((TrackDto) tracksView.Items[i].Tag).Name;
            if (name != dto.Name) continue;
            tracksView.Items.RemoveAt(i);
            RefreshIndexColumns(tracksView.Items);
        }
    }

    private static void RefreshIndexColumns(ListView.ListViewItemCollection items) {
        var i = 1;
        foreach (ListViewItem item in items) {
            item.SubItems[0].Text = i.ToString();
            i++;
        }
    }

    private void UpdateTrack(TrackDto prev, TrackDto next) {
        // Find item that matches previous one by name and replace with the next one
        for (var i = 0; i < tracksView.Items.Count; i++) {
            var name = ((TrackDto) tracksView.Items[i].Tag).Name;
            if (name != prev.Name) continue;

            var index = int.Parse(tracksView.Items[i].SubItems[0].Text);
            tracksView.Items[i] = next.ToListViewItem(index);
        }
    }

    private void AddTrack(TrackDto track) {
        var item = track.ToListViewItem(tracksView.Items.Count + 1);
        tracksView.Items.Add(item);
    }

    private void MusicForm_Load(object sender, EventArgs e) {
        var i = 1;
        var items = _state.Tracks
            .Select(it => it.ToListViewItem(i++))
            .ToArray();
        tracksView.Items.AddRange(items);
    }

    private void tracksView_SelectedIndexChanged(object sender, EventArgs e) {
        var isEmptySelection = tracksView.SelectedIndices.Count == 0;
        var track = isEmptySelection ? null : (TrackDto) tracksView.SelectedItems[0].Tag;
        _state.SelectedTrack = track;
        editTrackToolStripMenuItem.Enabled = !isEmptySelection;
        deleteTrackToolStripMenuItem.Enabled = !isEmptySelection;
    }

    private void ShowEditingDialog() {
        if (_state.SelectedTrack == null) return;
        var form = new TrackEditingForm(_state.SelectedTrack.ToDialogState());
        if (form.ShowDialog() == DialogResult.OK) {
            _state.UpdateTrack(_state.SelectedTrack, form.State.ToTrackDto());
        }
    }

    private void tracksView_MouseDoubleClick(object sender, MouseEventArgs e) {
        ShowEditingDialog();
    }

    private void editTrackToolStripMenuItem_Click(object sender, EventArgs e) {
        ShowEditingDialog();
    }

    private void deleteTrackToolStripMenuItem_Click(object sender, EventArgs e) {
        if (_state.SelectedTrack == null) return;
        _state.DeleteTrack(_state.SelectedTrack);
    }
}
}