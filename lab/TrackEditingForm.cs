using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace lab {
public partial class TrackEditingForm : Form {
    public TrackEditingForm(DialogState state) {
        InitializeComponent();
        nameTextBox.Text = state.Name;
        authorTextBox.Text = state.Author;
        categoryTextBox.Text = state.Category;
        dateTimePicker.Value = state.CreatedAt;
    }

    public DialogState State =>
        new DialogState {
            Name = nameTextBox.Text,
            Author = authorTextBox.Text,
            Category = categoryTextBox.Text,
            CreatedAt = Convert.ToDateTime(dateTimePicker.Text)
        };

    private void nameTextBox_Validating(object sender, CancelEventArgs e) {
        if (nameTextBox.Text != string.Empty) return;
        HandleValidationFailed(nameTextBox, "Enter non-empty name", e);
    }

    private void TrackEditingForm_Load(object sender, EventArgs e) {
        submitButton.DialogResult = DialogResult.OK;
        validationLabel.Text = "";

        // categoryTextBox
        var source = new AutoCompleteStringCollection();
        source.AddRange(Globals.Genres);
        categoryTextBox.AutoCompleteCustomSource = source;
        categoryTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        categoryTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
    }

    private void HandleValidationFailed(Control control, string message, CancelEventArgs e) {
        e.Cancel = true;
        errorProvider.SetError(control, message);
        validationLabel.Text = message;
    }

    private void HandleValidationSucceeded(Control control) {
        errorProvider.SetError(control, "");
        validationLabel.Text = "";
    }

    private void nameTextBox_Validated(object sender, EventArgs e) {
        HandleValidationSucceeded(nameTextBox);
    }

    private void TrackEditingForm_Validating(object sender, CancelEventArgs e) {
        ValidateChildren();
    }
}
}