using System.ComponentModel;
using System.Windows.Forms;

namespace lab {
partial class MusicForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.tracksView = new System.Windows.Forms.ListView();
        this.indexColumnHeader = new System.Windows.Forms.ColumnHeader();
        this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
        this.authorColumnHeader = new System.Windows.Forms.ColumnHeader();
        this.categoryColumnHeader = new System.Windows.Forms.ColumnHeader();
        this.createdColumnHeader = new System.Windows.Forms.ColumnHeader();
        this.upperMenuStrip = new System.Windows.Forms.MenuStrip();
        this.editTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.deleteTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.upperToolStrip = new System.Windows.Forms.ToolStripContainer();
        this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
        this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        this.toolStrip1 = new System.Windows.Forms.ToolStrip();
        this.filteringComboBox = new System.Windows.Forms.ToolStripComboBox();
        this.toolStripDropDown1 = new System.Windows.Forms.ToolStripDropDown();
        this.upperMenuStrip.SuspendLayout();
        this.upperToolStrip.BottomToolStripPanel.SuspendLayout();
        this.upperToolStrip.ContentPanel.SuspendLayout();
        this.upperToolStrip.TopToolStripPanel.SuspendLayout();
        this.upperToolStrip.SuspendLayout();
        this.bottomStatusStrip.SuspendLayout();
        this.toolStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // tracksView
        // 
        this.tracksView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.indexColumnHeader, this.nameColumnHeader, this.authorColumnHeader, this.categoryColumnHeader, this.createdColumnHeader});
        this.tracksView.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tracksView.FullRowSelect = true;
        this.tracksView.Location = new System.Drawing.Point(0, 0);
        this.tracksView.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        this.tracksView.MultiSelect = false;
        this.tracksView.Name = "tracksView";
        this.tracksView.Size = new System.Drawing.Size(593, 528);
        this.tracksView.TabIndex = 0;
        this.tracksView.UseCompatibleStateImageBehavior = false;
        this.tracksView.View = System.Windows.Forms.View.Details;
        this.tracksView.SelectedIndexChanged += new System.EventHandler(this.tracksView_SelectedIndexChanged);
        this.tracksView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tracksView_MouseDoubleClick);
        // 
        // indexColumnHeader
        // 
        this.indexColumnHeader.Text = "Index";
        this.indexColumnHeader.Width = 83;
        // 
        // nameColumnHeader
        // 
        this.nameColumnHeader.Text = "Name";
        this.nameColumnHeader.Width = 97;
        // 
        // authorColumnHeader
        // 
        this.authorColumnHeader.Text = "Author";
        this.authorColumnHeader.Width = 106;
        // 
        // categoryColumnHeader
        // 
        this.categoryColumnHeader.Text = "Category";
        this.categoryColumnHeader.Width = 138;
        // 
        // createdColumnHeader
        // 
        this.createdColumnHeader.Text = "Created at";
        this.createdColumnHeader.Width = 163;
        // 
        // upperMenuStrip
        // 
        this.upperMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
        this.upperMenuStrip.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.upperMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.editTrackToolStripMenuItem, this.deleteTrackToolStripMenuItem});
        this.upperMenuStrip.Location = new System.Drawing.Point(0, 0);
        this.upperMenuStrip.Name = "upperMenuStrip";
        this.upperMenuStrip.Size = new System.Drawing.Size(593, 40);
        this.upperMenuStrip.TabIndex = 1;
        this.upperMenuStrip.Text = "menuStrip1";
        // 
        // editTrackToolStripMenuItem
        // 
        this.editTrackToolStripMenuItem.Enabled = false;
        this.editTrackToolStripMenuItem.Name = "editTrackToolStripMenuItem";
        this.editTrackToolStripMenuItem.Size = new System.Drawing.Size(125, 36);
        this.editTrackToolStripMenuItem.Text = "Edit track";
        this.editTrackToolStripMenuItem.Click += new System.EventHandler(this.editTrackToolStripMenuItem_Click);
        // 
        // deleteTrackToolStripMenuItem
        // 
        this.deleteTrackToolStripMenuItem.Enabled = false;
        this.deleteTrackToolStripMenuItem.Name = "deleteTrackToolStripMenuItem";
        this.deleteTrackToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
        this.deleteTrackToolStripMenuItem.Text = "Delete track";
        this.deleteTrackToolStripMenuItem.Click += new System.EventHandler(this.deleteTrackToolStripMenuItem_Click);
        // 
        // upperToolStrip
        // 
        // 
        // upperToolStrip.BottomToolStripPanel
        // 
        this.upperToolStrip.BottomToolStripPanel.Controls.Add(this.bottomStatusStrip);
        // 
        // upperToolStrip.ContentPanel
        // 
        this.upperToolStrip.ContentPanel.AutoScroll = true;
        this.upperToolStrip.ContentPanel.Controls.Add(this.tracksView);
        this.upperToolStrip.ContentPanel.Size = new System.Drawing.Size(593, 528);
        this.upperToolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
        this.upperToolStrip.Location = new System.Drawing.Point(0, 0);
        this.upperToolStrip.Name = "upperToolStrip";
        this.upperToolStrip.Size = new System.Drawing.Size(593, 621);
        this.upperToolStrip.TabIndex = 2;
        this.upperToolStrip.Text = "toolStripContainer1";
        // 
        // upperToolStrip.TopToolStripPanel
        // 
        this.upperToolStrip.TopToolStripPanel.Controls.Add(this.upperMenuStrip);
        this.upperToolStrip.TopToolStripPanel.Controls.Add(this.toolStrip1);
        // 
        // statusStrip1
        // 
        this.bottomStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
        this.bottomStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.statusLabel});
        this.bottomStatusStrip.Location = new System.Drawing.Point(0, 0);
        this.bottomStatusStrip.Name = "bottomStatusStrip";
        this.bottomStatusStrip.Size = new System.Drawing.Size(593, 25);
        this.bottomStatusStrip.TabIndex = 0;
        // 
        // statusLabel
        // 
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new System.Drawing.Size(49, 20);
        this.statusLabel.Text = "Status";
        // 
        // toolStrip1
        // 
        this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
        this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.filteringComboBox});
        this.toolStrip1.Location = new System.Drawing.Point(3, 40);
        this.toolStrip1.Name = "toolStrip1";
        this.toolStrip1.Size = new System.Drawing.Size(135, 28);
        this.toolStrip1.TabIndex = 2;
        // 
        // filteringComboBox
        // 
        this.filteringComboBox.Name = "filteringComboBox";
        this.filteringComboBox.Size = new System.Drawing.Size(121, 28);
        this.filteringComboBox.TextChanged += new System.EventHandler(this.filteringComboBox_TextChanged);
        // 
        // toolStripDropDown1
        // 
        this.toolStripDropDown1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
        this.toolStripDropDown1.Name = "toolStripDropDown1";
        this.toolStripDropDown1.Size = new System.Drawing.Size(2, 4);
        // 
        // MusicForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.AliceBlue;
        this.ClientSize = new System.Drawing.Size(593, 621);
        this.Controls.Add(this.upperToolStrip);
        this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.MainMenuStrip = this.upperMenuStrip;
        this.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        this.Name = "MusicForm";
        this.ShowIcon = false;
        this.Load += new System.EventHandler(this.MusicForm_Load);
        this.upperMenuStrip.ResumeLayout(false);
        this.upperMenuStrip.PerformLayout();
        this.upperToolStrip.BottomToolStripPanel.ResumeLayout(false);
        this.upperToolStrip.BottomToolStripPanel.PerformLayout();
        this.upperToolStrip.ContentPanel.ResumeLayout(false);
        this.upperToolStrip.TopToolStripPanel.ResumeLayout(false);
        this.upperToolStrip.TopToolStripPanel.PerformLayout();
        this.upperToolStrip.ResumeLayout(false);
        this.upperToolStrip.PerformLayout();
        this.bottomStatusStrip.ResumeLayout(false);
        this.bottomStatusStrip.PerformLayout();
        this.toolStrip1.ResumeLayout(false);
        this.toolStrip1.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.ToolStripStatusLabel statusLabel;

    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    private System.Windows.Forms.StatusStrip bottomStatusStrip;

    private System.Windows.Forms.ToolStripComboBox filteringComboBox;

    private System.Windows.Forms.ToolStripDropDown toolStripDropDown1;
    private System.Windows.Forms.ToolStrip toolStrip1;

    private System.Windows.Forms.ToolStripContainer upperToolStrip;

    private System.Windows.Forms.ToolStripMenuItem deleteTrackToolStripMenuItem;

    private System.Windows.Forms.ToolStripMenuItem editTrackToolStripMenuItem;

    private System.Windows.Forms.MenuStrip upperMenuStrip;

    private System.Windows.Forms.ColumnHeader categoryColumnHeader;

    private System.Windows.Forms.ListView tracksView;

    private System.Windows.Forms.ColumnHeader indexColumnHeader;
    private System.Windows.Forms.ColumnHeader nameColumnHeader;
    private System.Windows.Forms.ColumnHeader authorColumnHeader;
    private System.Windows.Forms.ColumnHeader createdColumnHeader;

    #endregion
}
}