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
        this.bottomStatusBar = new System.Windows.Forms.StatusBar();
        this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        this.addTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.addFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // bottomStatusBar
        // 
        this.bottomStatusBar.Location = new System.Drawing.Point(0, 991);
        this.bottomStatusBar.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        this.bottomStatusBar.Name = "bottomStatusBar";
        this.bottomStatusBar.Size = new System.Drawing.Size(989, 43);
        this.bottomStatusBar.TabIndex = 5;
        this.bottomStatusBar.Text = "Status";
        // 
        // menuStrip1
        // 
        this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.addTrackToolStripMenuItem, this.addFormToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
        this.menuStrip1.Size = new System.Drawing.Size(989, 32);
        this.menuStrip1.TabIndex = 7;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // addTrackToolStripMenuItem
        // 
        this.addTrackToolStripMenuItem.Name = "addTrackToolStripMenuItem";
        this.addTrackToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
        this.addTrackToolStripMenuItem.Text = "New track";
        this.addTrackToolStripMenuItem.Click += new System.EventHandler(this.addTrackToolStripMenuItem_Click);
        // 
        // addFormToolStripMenuItem
        // 
        this.addFormToolStripMenuItem.Name = "addFormToolStripMenuItem";
        this.addFormToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
        this.addFormToolStripMenuItem.Text = "Add tracks form";
        this.addFormToolStripMenuItem.Click += new System.EventHandler(this.addFormToolStripMenuItem_Click);
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ControlLight;
        this.ClientSize = new System.Drawing.Size(989, 1034);
        this.Controls.Add(this.bottomStatusBar);
        this.Controls.Add(this.menuStrip1);
        this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.IsMdiContainer = true;
        this.MainMenuStrip = this.menuStrip1;
        this.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
        this.Name = "MainForm";
        this.ShowIcon = false;
        this.Text = "Music";
        this.Load += new System.EventHandler(this.MainForm_Load);
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.ToolStripMenuItem addFormToolStripMenuItem;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem addTrackToolStripMenuItem;

    private System.Windows.Forms.StatusBar bottomStatusBar;

    #endregion
}
}