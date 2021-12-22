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
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).BeginInit();
        this.SuspendLayout();
        // 
        // label
        // 
        this.label.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label.Location = new System.Drawing.Point(0, 304);
        this.label.Name = "label";
        this.label.Size = new System.Drawing.Size(237, 40);
        this.label.TabIndex = 0;
        this.label.Text = "Label";
        this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox
        // 
        this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.pictureBox.Location = new System.Drawing.Point(0, 0);
        this.pictureBox.Name = "pictureBox";
        this.pictureBox.Size = new System.Drawing.Size(237, 301);
        this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.pictureBox.TabIndex = 1;
        this.pictureBox.TabStop = false;
        this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
        // 
        // GenreControl
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.Controls.Add(this.label);
        this.Controls.Add(this.pictureBox);
        this.Name = "GenreControl";
        this.Size = new System.Drawing.Size(237, 344);
        this.Load += new System.EventHandler(this.GenreControl_Load);
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label label;

    private System.Windows.Forms.PictureBox pictureBox;

    #endregion
}
}