using System;
using System.Drawing;
using System.Windows.Forms;
using lab.track;

namespace lab {
public partial class MainForm : Form {
    private readonly TracksState _tracksState;

    // counter is used to enable and disable close buttons of forms
    private int _childCounter;

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

        AddMusicForm();
    }

    private void AddMusicForm() {
        _childCounter += 1;
        var form = new MusicForm(_tracksState, _childCounter) {MdiParent = this};
        form.Activated += (o, args) => HandleFormActivated(form);
        form.Deactivate += (o, args) => UnmergeMenus(form);
        form.Closed += (o, args) => HandleChildClosed();
        form.Show();
        UpdateChildControlBoxes();
    }

    private void HandleChildClosed() {
        _childCounter -= 1;
        UpdateChildControlBoxes();
    }

    private void UpdateChildControlBoxes() {
        var isEnabled = _childCounter != 1;
        foreach (var child in MdiChildren) child.ControlBox = isEnabled;
    }


    private void UnmergeMenus(MusicForm target) {
        ToolStripManager.RevertMerge(upperMenuStrip, target.UpperMenuStrip);
    }

    private void MergeMenus(MusicForm source) {
        ToolStripManager.Merge(source.UpperMenuStrip, upperMenuStrip);
    }

    private void HandleFormActivated(MusicForm form) {
        // ReSharper disable once LocalizableElement
        bottomStatusBar.Text = $"Form {form.Id}";
        MergeMenus(form);
        UpdateChildControlBoxes();
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