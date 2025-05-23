namespace MissingChildrenSA.Forms.Shared;

public class InputDialog : IDisposable
{
    private Form Prompt { get; set; }
    public DialogResult DialogResult { get; private set; }
    public string Result { get; }

    public InputDialog(string text, string caption)
    {
        Result = ShowDialog(text, caption);
    }

    //use a using statement
    private string ShowDialog(string text, string caption)
    {
        Prompt = new Form()
        {
            Width = 500,
            Height = 200,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            Text = caption,
            StartPosition = FormStartPosition.CenterScreen,
            TopMost = true,
            MinimizeBox = false,
            MaximizeBox = false,
            BackColor = Color.White,
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0)
        };

        var textLabel = new Label
        {
            Left = 50,
            Top = 20,
            Text = text,
            Dock = DockStyle.Top,
            TextAlign = ContentAlignment.MiddleCenter,
        };

        var textBox = new TextBox
        {
            Left = 50,
            Top = 50,
            Width = 400
        };

        var confirmationButton = new Button
        {
            Text = "Ok",
            Left = 350,
            Width = 100,
            Height = 30,
            Top = 90,
            DialogResult = DialogResult.OK
        };

        confirmationButton.Click += (sender, e) => Prompt.Close();

        Prompt.Controls.Add(textBox);
        Prompt.Controls.Add(confirmationButton);
        Prompt.Controls.Add(textLabel);
        Prompt.AcceptButton = confirmationButton;

        DialogResult = Prompt.ShowDialog();

        return DialogResult == DialogResult.OK ? textBox.Text : "";
    }

    public void Dispose()
    {
        Prompt?.Dispose();
    }
}