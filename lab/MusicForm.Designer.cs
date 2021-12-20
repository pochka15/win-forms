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
        this.tracksView.Size = new System.Drawing.Size(593, 621);
        this.tracksView.TabIndex = 0;
        this.tracksView.UseCompatibleStateImageBehavior = false;
        this.tracksView.View = System.Windows.Forms.View.Details;
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
        // MusicForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.AliceBlue;
        this.ClientSize = new System.Drawing.Size(593, 621);
        this.Controls.Add(this.tracksView);
        this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        this.Name = "MusicForm";
        this.ShowIcon = false;
        this.Load += new System.EventHandler(this.MusicForm_Load);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.ColumnHeader categoryColumnHeader;

    private System.Windows.Forms.ListView tracksView;

    private System.Windows.Forms.ColumnHeader indexColumnHeader;
    private System.Windows.Forms.ColumnHeader nameColumnHeader;
    private System.Windows.Forms.ColumnHeader authorColumnHeader;
    private System.Windows.Forms.ColumnHeader createdColumnHeader;

    #endregion
}
}