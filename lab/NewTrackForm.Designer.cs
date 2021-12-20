using System.ComponentModel;

namespace lab {
partial class NewTrackForm {
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
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTrackForm));
        this.nameLabel = new System.Windows.Forms.Label();
        this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        this.authorTextBox = new System.Windows.Forms.TextBox();
        this.nameTextBox = new System.Windows.Forms.TextBox();
        this.categoryLabel = new System.Windows.Forms.Label();
        this.categoryTextBox = new System.Windows.Forms.TextBox();
        this.submitButton = new System.Windows.Forms.Button();
        this.authorLabel = new System.Windows.Forms.Label();
        this.createdAtLabel = new System.Windows.Forms.Label();
        this.validationLabel = new System.Windows.Forms.Label();
        this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
        this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
        this.tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).BeginInit();
        this.SuspendLayout();
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new System.Drawing.Point(99, 0);
        this.nameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new System.Drawing.Size(127, 46);
        this.nameLabel.TabIndex = 0;
        this.nameLabel.Text = "Name";
        this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.02631F));
        this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.93021F));
        this.tableLayoutPanel1.Controls.Add(this.authorTextBox, 2, 1);
        this.tableLayoutPanel1.Controls.Add(this.nameLabel, 1, 0);
        this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 2, 0);
        this.tableLayoutPanel1.Controls.Add(this.categoryLabel, 1, 2);
        this.tableLayoutPanel1.Controls.Add(this.categoryTextBox, 2, 2);
        this.tableLayoutPanel1.Controls.Add(this.submitButton, 2, 7);
        this.tableLayoutPanel1.Controls.Add(this.authorLabel, 1, 1);
        this.tableLayoutPanel1.Controls.Add(this.createdAtLabel, 1, 3);
        this.tableLayoutPanel1.Controls.Add(this.validationLabel, 1, 5);
        this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 2, 3);
        this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 8;
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.995204F));
        this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.06235F));
        this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 446);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // authorTextBox
        // 
        this.authorTextBox.Location = new System.Drawing.Point(264, 61);
        this.authorTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
        this.authorTextBox.Name = "authorTextBox";
        this.authorTextBox.Size = new System.Drawing.Size(381, 38);
        this.authorTextBox.TabIndex = 3;
        // 
        // nameTextBox
        // 
        this.nameTextBox.Location = new System.Drawing.Point(264, 8);
        this.nameTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
        this.nameTextBox.Name = "nameTextBox";
        this.nameTextBox.Size = new System.Drawing.Size(381, 38);
        this.nameTextBox.TabIndex = 1;
        this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
        this.nameTextBox.Validated += new System.EventHandler(this.nameTextBox_Validated);
        // 
        // categoryLabel
        // 
        this.categoryLabel.Location = new System.Drawing.Point(99, 106);
        this.categoryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        this.categoryLabel.Name = "categoryLabel";
        this.categoryLabel.Size = new System.Drawing.Size(127, 46);
        this.categoryLabel.TabIndex = 4;
        this.categoryLabel.Text = "Category";
        this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // categoryTextBox
        // 
        this.categoryTextBox.Location = new System.Drawing.Point(264, 114);
        this.categoryTextBox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
        this.categoryTextBox.Name = "categoryTextBox";
        this.categoryTextBox.Size = new System.Drawing.Size(381, 38);
        this.categoryTextBox.TabIndex = 5;
        // 
        // submitButton
        // 
        this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
        this.submitButton.Location = new System.Drawing.Point(264, 369);
        this.submitButton.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
        this.submitButton.Name = "submitButton";
        this.submitButton.Size = new System.Drawing.Size(447, 51);
        this.submitButton.TabIndex = 8;
        this.submitButton.Text = "Create";
        this.submitButton.UseVisualStyleBackColor = true;
        // 
        // authorLabel
        // 
        this.authorLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        this.authorLabel.Location = new System.Drawing.Point(99, 53);
        this.authorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        this.authorLabel.Name = "authorLabel";
        this.authorLabel.Size = new System.Drawing.Size(127, 46);
        this.authorLabel.TabIndex = 2;
        this.authorLabel.Text = "Author";
        this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // createdAtLabel
        // 
        this.createdAtLabel.Location = new System.Drawing.Point(99, 159);
        this.createdAtLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
        this.createdAtLabel.Name = "createdAtLabel";
        this.createdAtLabel.Size = new System.Drawing.Size(127, 46);
        this.createdAtLabel.TabIndex = 6;
        this.createdAtLabel.Text = "Created at";
        this.createdAtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // validationLabel
        // 
        this.tableLayoutPanel1.SetColumnSpan(this.validationLabel, 2);
        this.validationLabel.Location = new System.Drawing.Point(96, 265);
        this.validationLabel.Name = "validationLabel";
        this.validationLabel.Size = new System.Drawing.Size(523, 47);
        this.validationLabel.TabIndex = 9;
        this.validationLabel.Text = "Validation text";
        this.validationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // dateTimePicker
        // 
        this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.dateTimePicker.Location = new System.Drawing.Point(261, 162);
        this.dateTimePicker.Name = "dateTimePicker";
        this.dateTimePicker.Size = new System.Drawing.Size(384, 38);
        this.dateTimePicker.TabIndex = 10;
        // 
        // errorProvider
        // 
        this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        this.errorProvider.ContainerControl = this;
        this.errorProvider.Icon = ((System.Drawing.Icon) (resources.GetObject("errorProvider.Icon")));
        // 
        // NewTrackForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(717, 446);
        this.Controls.Add(this.tableLayoutPanel1);
        this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
        this.Name = "NewTrackForm";
        this.ShowIcon = false;
        this.Text = "New track";
        this.Load += new System.EventHandler(this.NewTrackForm_Load);
        this.Validating += new System.ComponentModel.CancelEventHandler(this.NewTrackForm_Validating);
        this.tableLayoutPanel1.ResumeLayout(false);
        this.tableLayoutPanel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) (this.errorProvider)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DateTimePicker dateTimePicker;

    private System.Windows.Forms.Label validationLabel;

    private System.Windows.Forms.ErrorProvider errorProvider;

    private System.Windows.Forms.Button submitButton;

    private System.Windows.Forms.Label createdAtLabel;

    private System.Windows.Forms.Label authorLabel;
    private System.Windows.Forms.TextBox authorTextBox;

    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.TextBox nameTextBox;
    
    private System.Windows.Forms.Label categoryLabel;
    private System.Windows.Forms.TextBox categoryTextBox;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    #endregion
}
}