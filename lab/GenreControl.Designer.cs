using System.ComponentModel;

namespace lab {
partial class GenreControl {
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.label = new System.Windows.Forms.Label();
        this.pictureBox = new System.Windows.Forms.PictureBox();
        this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).BeginInit();
        this.flowLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // label
        // 
        this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label.Location = new System.Drawing.Point(3, 105);
        this.label.Name = "label";
        this.label.Size = new System.Drawing.Size(147, 43);
        this.label.TabIndex = 0;
        this.label.Text = "Label";
        this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox
        // 
        this.pictureBox.Location = new System.Drawing.Point(3, 3);
        this.pictureBox.MaximumSize = new System.Drawing.Size(150, 100);
        this.pictureBox.Name = "pictureBox";
        this.pictureBox.Size = new System.Drawing.Size(144, 99);
        this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox.TabIndex = 1;
        this.pictureBox.TabStop = false;
        this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
        // 
        // flowLayoutPanel1
        // 
        this.flowLayoutPanel1.Controls.Add(this.pictureBox);
        this.flowLayoutPanel1.Controls.Add(this.label);
        this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 150);
        this.flowLayoutPanel1.TabIndex = 2;
        // 
        // GenreControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.Controls.Add(this.flowLayoutPanel1);
        this.Name = "GenreControl";
        this.Load += new System.EventHandler(this.GenreControl_Load);
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
        this.flowLayoutPanel1.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    private System.Windows.Forms.Label label;

    private System.Windows.Forms.PictureBox pictureBox;

    #endregion
}
}