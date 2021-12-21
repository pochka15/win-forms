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
        this.upperMenuStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // tracksView
        // 
        this.tracksView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.indexColumnHeader, this.nameColumnHeader, this.authorColumnHeader, this.categoryColumnHeader, this.createdColumnHeader});
        this.tracksView.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tracksView.FullRowSelect = true;
        this.tracksView.Location = new System.Drawing.Point(0, 40);
        this.tracksView.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        this.tracksView.MultiSelect = false;
        this.tracksView.Name = "tracksView";
        this.tracksView.Size = new System.Drawing.Size(593, 581);
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
        this.authorColumnHeader.Width = 108;
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
        // MusicForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.AliceBlue;
        this.ClientSize = new System.Drawing.Size(593, 621);
        this.Controls.Add(this.tracksView);
        this.Controls.Add(this.upperMenuStrip);
        this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.MainMenuStrip = this.upperMenuStrip;
        this.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        this.Name = "MusicForm";
        this.ShowIcon = false;
        this.Load += new System.EventHandler(this.MusicForm_Load);
        this.upperMenuStrip.ResumeLayout(false);
        this.upperMenuStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

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