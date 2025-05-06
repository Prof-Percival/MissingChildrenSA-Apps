namespace MissingChildrenSA.Forms.Users;

partial class EditUserForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
        TxtFirstName = new TextBox();
        TxtLastName = new TextBox();
        TxtPassword = new TextBox();
        CmbUserRole = new ComboBox();
        BtnUpdateUser = new Button();
        SuspendLayout();
        // 
        // TxtFirstName
        // 
        TxtFirstName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtFirstName.Location = new Point(15, 16);
        TxtFirstName.Margin = new Padding(5, 3, 5, 3);
        TxtFirstName.Name = "TxtFirstName";
        TxtFirstName.PlaceholderText = "First Name";
        TxtFirstName.Size = new Size(161, 22);
        TxtFirstName.TabIndex = 1;
        // 
        // TxtLastName
        // 
        TxtLastName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtLastName.Location = new Point(201, 16);
        TxtLastName.Margin = new Padding(5, 3, 5, 3);
        TxtLastName.Name = "TxtLastName";
        TxtLastName.PlaceholderText = "Last Name";
        TxtLastName.Size = new Size(161, 22);
        TxtLastName.TabIndex = 2;
        // 
        // TxtPassword
        // 
        TxtPassword.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TxtPassword.Location = new Point(15, 51);
        TxtPassword.Margin = new Padding(5, 3, 5, 3);
        TxtPassword.Name = "TxtPassword";
        TxtPassword.PlaceholderText = "Password";
        TxtPassword.Size = new Size(161, 22);
        TxtPassword.TabIndex = 3;
        // 
        // CmbUserRole
        // 
        CmbUserRole.Cursor = Cursors.Hand;
        CmbUserRole.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        CmbUserRole.FormattingEnabled = true;
        CmbUserRole.Location = new Point(201, 51);
        CmbUserRole.Name = "CmbUserRole";
        CmbUserRole.Size = new Size(161, 24);
        CmbUserRole.TabIndex = 4;
        // 
        // BtnUpdateUser
        // 
        BtnUpdateUser.BackColor = Color.FromArgb(237, 31, 39);
        BtnUpdateUser.Cursor = Cursors.Hand;
        BtnUpdateUser.FlatAppearance.BorderSize = 0;
        BtnUpdateUser.FlatStyle = FlatStyle.Flat;
        BtnUpdateUser.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnUpdateUser.ForeColor = Color.White;
        BtnUpdateUser.Location = new Point(131, 101);
        BtnUpdateUser.Margin = new Padding(5, 3, 5, 3);
        BtnUpdateUser.Name = "BtnUpdateUser";
        BtnUpdateUser.Size = new Size(101, 31);
        BtnUpdateUser.TabIndex = 5;
        BtnUpdateUser.Text = "Update";
        BtnUpdateUser.UseVisualStyleBackColor = false;
        BtnUpdateUser.Click += BtnUpdateUser_Click;
        // 
        // EditUserForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(381, 149);
        Controls.Add(BtnUpdateUser);
        Controls.Add(CmbUserRole);
        Controls.Add(TxtPassword);
        Controls.Add(TxtLastName);
        Controls.Add(TxtFirstName);
        Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "EditUserForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Edit User";
        Load += CreateUserForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox TxtFirstName;
    private TextBox TxtLastName;
    private TextBox TxtPassword;
    private ComboBox CmbUserRole;
    private Button BtnUpdateUser;
}