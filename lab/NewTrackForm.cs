using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace lab {
public partial class NewTrackForm : Form {
    public NewTrackForm() {
        InitializeComponent();
        CustomInitialize();
    }

    private void CustomInitialize() {
        submitButton.DialogResult = DialogResult.OK;
        validationLabel.Text = "";
    }

    public DialogState State =>
        new DialogState {
            Name = nameTextBox.Text,
            Author = authorTextBox.Text,
            Category = genreControl.Value,
            CreatedAt = Convert.ToDateTime(dateTimePicker.Text)
        };

    private void nameTextBox_Validating(object sender, CancelEventArgs e) {
        if (nameTextBox.Text != string.Empty) return;
        HandleValidationFailed(nameTextBox, "Enter non-empty name", e);
    }

    private void nameTextBox_Validated(object sender, EventArgs e) {
        HandleValidationSucceeded(nameTextBox);
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

    private void NewTrackForm_Validating(object sender, CancelEventArgs e) {
        ValidateChildren();
    }
}
}