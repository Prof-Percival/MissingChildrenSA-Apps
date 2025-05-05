namespace MissingChildrenSA.Forms.Users;

partial class CreateUserForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
        TxtFirstName = new TextBox();
        TxtLastName = new TextBox();
        TxtUsername = new TextBox();
        TxtPassword = new TextBox();
        CmbUserRole = new ComboBox();
        BtnAddUser = new Button();
        SuspendLayout();
        // 
        // TxtFirstName
        // 
        TxtFirstName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtFirstName.Location = new Point(14, 12);
        TxtFirstName.Margin = new Padding(5, 3, 5, 3);
        TxtFirstName.Name = "TxtFirstName";
        TxtFirstName.PlaceholderText = "First Name";
        TxtFirstName.Size = new Size(161, 22);
        TxtFirstName.TabIndex = 1;
        // 
        // TxtLastName
        // 
        TxtLastName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtLastName.Location = new Point(200, 12);
        TxtLastName.Margin = new Padding(5, 3, 5, 3);
        TxtLastName.Name = "TxtLastName";
        TxtLastName.PlaceholderText = "Last Name";
        TxtLastName.Size = new Size(161, 22);
        TxtLastName.TabIndex = 2;
        // 
        // TxtUsername
        // 
        TxtUsername.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtUsername.Location = new Point(14, 45);
        TxtUsername.Margin = new Padding(5, 3, 5, 3);
        TxtUsername.Name = "TxtUsername";
        TxtUsername.PlaceholderText = "Username";
        TxtUsername.Size = new Size(161, 22);
        TxtUsername.TabIndex = 3;
        // 
        // TxtPassword
        // 
        TxtPassword.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtPassword.Location = new Point(200, 45);
        TxtPassword.Margin = new Padding(5, 3, 5, 3);
        TxtPassword.Name = "TxtPassword";
        TxtPassword.PlaceholderText = "Password";
        TxtPassword.Size = new Size(161, 22);
        TxtPassword.TabIndex = 4;
        // 
        // CmbUserRole
        // 
        CmbUserRole.Cursor = Cursors.Hand;
        CmbUserRole.FormattingEnabled = true;
        CmbUserRole.Location = new Point(14, 78);
        CmbUserRole.Name = "CmbUserRole";
        CmbUserRole.Size = new Size(161, 25);
        CmbUserRole.TabIndex = 5;
        // 
        // BtnAddUser
        // 
        BtnAddUser.BackColor = Color.FromArgb(237, 31, 39);
        BtnAddUser.Cursor = Cursors.Hand;
        BtnAddUser.FlatAppearance.BorderSize = 0;
        BtnAddUser.FlatStyle = FlatStyle.Flat;
        BtnAddUser.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnAddUser.ForeColor = Color.White;
        BtnAddUser.Location = new Point(132, 118);
        BtnAddUser.Margin = new Padding(5, 3, 5, 3);
        BtnAddUser.Name = "BtnAddUser";
        BtnAddUser.Size = new Size(101, 31);
        BtnAddUser.TabIndex = 6;
        BtnAddUser.Text = "Add";
        BtnAddUser.UseVisualStyleBackColor = false;
        // 
        // CreateUserForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(381, 171);
        Controls.Add(BtnAddUser);
        Controls.Add(CmbUserRole);
        Controls.Add(TxtPassword);
        Controls.Add(TxtUsername);
        Controls.Add(TxtLastName);
        Controls.Add(TxtFirstName);
        Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "CreateUserForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Add User";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox TxtFirstName;
    private TextBox TxtLastName;
    private TextBox TxtUsername;
    private TextBox TxtPassword;
    private ComboBox CmbUserRole;
    private Button BtnAddUser;
}