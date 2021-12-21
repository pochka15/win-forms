using System;
using System.Drawing;
using System.Windows.Forms;
using lab.track;

namespace lab {
public partial class MainForm : Form {
    private readonly TracksState _tracksState;

    public MainForm() {
        InitializeComponent();
        _tracksState = new TracksState(TracksState.BuildDummyTracks(5));
    }

    private void MainForm_Load(object sender, EventArgs e) {
        CenterToScreen();
        BackColor = Color.AliceBlue;
        foreach (Control control in Controls) {
            if (!(control is MdiClient)) continue;
            control.BackColor = Color.AliceBlue;
            break;
        }
    }

    private void AddMusicForm() {
        var counter = 1 + MdiChildren.Length;
        var form = new MusicForm(_tracksState, counter) {MdiParent = this};
        form.Activated += (o, args) => UpdateActiveForm(form);
        form.Activated += (o, args) => MergeMenus(form);
        form.Deactivate += (o, args) => UnmergeMenus(form);
        form.Show();
    }

    private void UnmergeMenus(MusicForm target) {
        ToolStripManager.RevertMerge(upperMenuStrip, target.UpperMenuStrip);
    }

    private void MergeMenus(MusicForm source) {
        ToolStripManager.Merge(source.UpperMenuStrip, upperMenuStrip);
    }

    private void UpdateActiveForm(MusicForm form) {
        // ReSharper disable once LocalizableElement
        bottomStatusBar.Text = $"Form {form.Id}";
    }

    private void addTrackToolStripMenuItem_Click(object sender, EventArgs e) {
        var form = new NewTrackForm();
        if (form.ShowDialog() == DialogResult.OK) {
            _tracksState.AddTrack(form.State.ToTrackModel());
        }
    }

    private void addFormToolStripMenuItem_Click(object sender, EventArgs e) {
        AddMusicForm();
    }
}
}