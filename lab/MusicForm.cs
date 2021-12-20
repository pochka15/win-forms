using System;
using System.Linq;
using System.Windows.Forms;
using lab.track;

namespace lab {
public partial class MusicForm : Form {
    public int Id { get; }

    private readonly MusicFormState _state;

    public MusicForm(TracksState tracksState, int id = 0) {
        Id = id;
        InitializeComponent();                                   
        _state = new MusicFormState(tracksState);
        _state.TrackAdded += AddTrack;
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
}
}