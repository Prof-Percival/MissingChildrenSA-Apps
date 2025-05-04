namespace MissingChildrenSA.Forms.Auth;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        TxtUsername = new TextBox();
        TxtPassword = new TextBox();
        BtnLogin = new Button();
        LblError = new Label();
        SuspendLayout();
        // 
        // TxtUsername
        // 
        TxtUsername.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtUsername.Location = new Point(30, 16);
        TxtUsername.Margin = new Padding(5, 3, 5, 3);
        TxtUsername.Name = "TxtUsername";
        TxtUsername.PlaceholderText = "Username";
        TxtUsername.Size = new Size(244, 22);
        TxtUsername.TabIndex = 0;
        // 
        // TxtPassword
        // 
        TxtPassword.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtPassword.Location = new Point(30, 68);
        TxtPassword.Margin = new Padding(5, 3, 5, 3);
        TxtPassword.Name = "TxtPassword";
        TxtPassword.PlaceholderText = "Password";
        TxtPassword.Size = new Size(244, 22);
        TxtPassword.TabIndex = 1;
        TxtPassword.UseSystemPasswordChar = true;
        // 
        // BtnLogin
        // 
        BtnLogin.BackColor = Color.FromArgb(237, 31, 39);
        BtnLogin.Cursor = Cursors.Hand;
        BtnLogin.FlatAppearance.BorderSize = 0;
        BtnLogin.FlatStyle = FlatStyle.Flat;
        BtnLogin.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnLogin.ForeColor = Color.White;
        BtnLogin.Location = new Point(95, 114);
        BtnLogin.Margin = new Padding(5, 3, 5, 3);
        BtnLogin.Name = "BtnLogin";
        BtnLogin.Size = new Size(101, 31);
        BtnLogin.TabIndex = 2;
        BtnLogin.Text = "Login";
        BtnLogin.UseVisualStyleBackColor = false;
        BtnLogin.Click += BtnLogin_Click;
        BtnLogin.MouseLeave += BtnLogin_MouseLeave;
        BtnLogin.MouseHover += BtnLogin_MouseHover;
        // 
        // LblError
        // 
        LblError.AutoSize = true;
        LblError.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        LblError.ForeColor = Color.Red;
        LblError.Location = new Point(30, 160);
        LblError.Margin = new Padding(5, 0, 5, 0);
        LblError.Name = "LblError";
        LblError.Size = new Size(0, 15);
        LblError.TabIndex = 3;
        LblError.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(301, 191);
        Controls.Add(LblError);
        Controls.Add(BtnLogin);
        Controls.Add(TxtPassword);
        Controls.Add(TxtUsername);
        Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(6);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox TxtUsername;
    private System.Windows.Forms.TextBox TxtPassword;
    private System.Windows.Forms.Button BtnLogin;
    private System.Windows.Forms.Label LblError;

#endregion
}