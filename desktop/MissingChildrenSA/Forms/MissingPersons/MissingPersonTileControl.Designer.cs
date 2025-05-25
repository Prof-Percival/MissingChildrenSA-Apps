namespace MissingChildrenSA.Forms.MissingPersons;

partial class MissingPersonTileControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        PicPerson = new PictureBox();
        LblName = new Label();
        LblMissingDate = new Label();
        LblReported = new Label();
        ((System.ComponentModel.ISupportInitialize)PicPerson).BeginInit();
        SuspendLayout();
        // 
        // PicPerson
        // 
        PicPerson.Dock = DockStyle.Top;
        PicPerson.Location = new Point(0, 0);
        PicPerson.Name = "PicPerson";
        PicPerson.Size = new Size(198, 120);
        PicPerson.SizeMode = PictureBoxSizeMode.Zoom;
        PicPerson.TabIndex = 3;
        PicPerson.TabStop = false;
        PicPerson.Click += Tile_Click;
        // 
        // LblName
        // 
        LblName.AutoEllipsis = true;
        LblName.Dock = DockStyle.Top;
        LblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        LblName.Location = new Point(0, 120);
        LblName.Name = "LblName";
        LblName.Size = new Size(198, 30);
        LblName.TabIndex = 2;
        LblName.TextAlign = ContentAlignment.MiddleCenter;
        LblName.Click += Tile_Click;
        // 
        // LblMissingDate
        // 
        LblMissingDate.Dock = DockStyle.Top;
        LblMissingDate.Location = new Point(0, 150);
        LblMissingDate.Name = "LblMissingDate";
        LblMissingDate.Size = new Size(198, 20);
        LblMissingDate.TabIndex = 1;
        LblMissingDate.TextAlign = ContentAlignment.MiddleCenter;
        LblMissingDate.Click += Tile_Click;
        // 
        // LblReported
        // 
        LblReported.Dock = DockStyle.Top;
        LblReported.Location = new Point(0, 170);
        LblReported.Name = "LblReported";
        LblReported.Size = new Size(198, 20);
        LblReported.TabIndex = 0;
        LblReported.TextAlign = ContentAlignment.MiddleCenter;
        LblReported.Click += Tile_Click;
        // 
        // MissingPersonTileControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        BorderStyle = BorderStyle.FixedSingle;
        Controls.Add(LblReported);
        Controls.Add(LblMissingDate);
        Controls.Add(LblName);
        Controls.Add(PicPerson);
        Cursor = Cursors.Hand;
        Margin = new Padding(10, 10, 10, 10);
        Name = "MissingPersonTileControl";
        Size = new Size(198, 198);
        ((System.ComponentModel.ISupportInitialize)PicPerson).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox PicPerson;
    private Label LblName;
    private Label LblMissingDate;
    private Label LblReported;
}
