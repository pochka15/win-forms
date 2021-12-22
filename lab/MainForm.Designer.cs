namespace lab {
partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        this.upperMenuStrip = new System.Windows.Forms.MenuStrip();
        this.addTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.addFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.bottomStatusStrip = new System.Windows.Forms.StatusStrip();
        this.upperMenuStrip.SuspendLayout();
        this.SuspendLayout();
        // 
        // upperMenuStrip
        // 
        this.upperMenuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.upperMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addTrackToolStripMenuItem, this.addFormToolStripMenuItem});
        this.upperMenuStrip.Location = new System.Drawing.Point(0, 0);
        this.upperMenuStrip.Name = "upperMenuStrip";
        this.upperMenuStrip.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
        this.upperMenuStrip.Size = new System.Drawing.Size(989, 32);
        this.upperMenuStrip.TabIndex = 7;
        this.upperMenuStrip.Text = "menuStrip1";
        // 
        // addTrackToolStripMenuItem
        // 
        this.addTrackToolStripMenuItem.Name = "addTrackToolStripMenuItem";
        this.addTrackToolStripMenuItem.Size = new System.Drawing.Size(111, 32);
        this.addTrackToolStripMenuItem.Text = "New track";
        this.addTrackToolStripMenuItem.Click += new System.EventHandler(this.addTrackToolStripMenuItem_Click);
        // 
        // addFormToolStripMenuItem
        // 
        this.addFormToolStripMenuItem.Name = "addFormToolStripMenuItem";
        this.addFormToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
        this.addFormToolStripMenuItem.Text = "Add tracks form";
        this.addFormToolStripMenuItem.Click += new System.EventHandler(this.addFormToolStripMenuItem_Click);
        // 
        // bottomStatusStrip
        // 
        this.bottomStatusStrip.Location = new System.Drawing.Point(0, 1012);
        this.bottomStatusStrip.Name = "bottomStatusStrip";
        this.bottomStatusStrip.Size = new System.Drawing.Size(989, 22);
        this.bottomStatusStrip.TabIndex = 9;
        this.bottomStatusStrip.Text = "statusStrip1";
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ControlLight;
        this.ClientSize = new System.Drawing.Size(989, 1034);
        this.Controls.Add(this.bottomStatusStrip);
        this.Controls.Add(this.upperMenuStrip);
        this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.IsMdiContainer = true;
        this.MainMenuStrip = this.upperMenuStrip;
        this.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        this.Name = "MainForm";
        this.ShowIcon = false;
        this.Text = "Music";
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.upperMenuStrip.ResumeLayout(false);
        this.upperMenuStrip.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.StatusStrip bottomStatusStrip;

    private System.Windows.Forms.StatusStrip statusStrip1;

    private System.Windows.Forms.ToolStripMenuItem addFormToolStripMenuItem;

    private System.Windows.Forms.MenuStrip upperMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem addTrackToolStripMenuItem;

    #endregion
}
}