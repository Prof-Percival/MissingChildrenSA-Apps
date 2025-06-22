namespace MissingChildrenSA
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BtnLogin = new Button();
            LblDateTime = new Label();
            LblSlogan = new Label();
            LblVersion = new Label();
            TabPanFooter = new TableLayoutPanel();
            TabPanFooter.SuspendLayout();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnLogin.BackColor = Color.FromArgb(237, 31, 39);
            BtnLogin.Cursor = Cursors.Hand;
            BtnLogin.FlatStyle = FlatStyle.Popup;
            BtnLogin.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = Color.White;
            BtnLogin.Location = new Point(763, -1);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(99, 28);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // LblDateTime
            // 
            LblDateTime.AutoSize = true;
            LblDateTime.BackColor = Color.Transparent;
            LblDateTime.Font = new Font("Arial", 10F, FontStyle.Bold);
            LblDateTime.ForeColor = Color.White;
            LblDateTime.Location = new Point(10, 10);
            LblDateTime.Name = "LblDateTime";
            LblDateTime.Size = new Size(109, 16);
            LblDateTime.TabIndex = 1;
            LblDateTime.Text = "Loading time...";
            // 
            // LblSlogan
            // 
            LblSlogan.BackColor = Color.Transparent;
            LblSlogan.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            LblSlogan.ForeColor = Color.White;
            LblSlogan.Location = new Point(0, 50);
            LblSlogan.Name = "LblSlogan";
            LblSlogan.Size = new Size(861, 30);
            LblSlogan.TabIndex = 3;
            LblSlogan.Text = "Bringing Families Together - One Child at a Time";
            LblSlogan.TextAlign = ContentAlignment.TopCenter;
            LblSlogan.Visible = false;
            // 
            // LblVersion
            // 
            LblVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblVersion.AutoSize = true;
            LblVersion.BackColor = Color.Transparent;
            LblVersion.Font = new Font("Arial", 9F, FontStyle.Italic);
            LblVersion.ForeColor = Color.WhiteSmoke;
            LblVersion.Location = new Point(764, 5);
            LblVersion.Name = "LblVersion";
            LblVersion.Size = new Size(85, 15);
            LblVersion.TabIndex = 2;
            LblVersion.Text = "Version v1.0.0";
            // 
            // TabPanFooter
            // 
            TabPanFooter.BackColor = Color.Transparent;
            TabPanFooter.ColumnCount = 2;
            TabPanFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99F));
            TabPanFooter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1F));
            TabPanFooter.Controls.Add(LblVersion, 0, 0);
            TabPanFooter.Dock = DockStyle.Bottom;
            TabPanFooter.Location = new Point(0, 448);
            TabPanFooter.Name = "TabPanFooter";
            TabPanFooter.RowCount = 1;
            TabPanFooter.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TabPanFooter.Size = new Size(861, 20);
            TabPanFooter.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            BackgroundImage = Properties.Resources._1220x650_Lost_Boy_MCSA;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(861, 468);
            Controls.Add(TabPanFooter);
            Controls.Add(BtnLogin);
            Controls.Add(LblDateTime);
            Controls.Add(LblSlogan);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Missing Children SA";
            Load += MainForm_Load;
            TabPanFooter.ResumeLayout(false);
            TabPanFooter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLogin;
        private Label LblDateTime;
        private Label LblSlogan;
        private Label LblVersion;
        private TableLayoutPanel TabPanFooter;
    }
}
