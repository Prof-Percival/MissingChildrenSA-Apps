namespace MissingChildrenSA.Forms;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
    }

    private void DashboardForm_Load(object sender, EventArgs e)
    {
        MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        WindowState = FormWindowState.Maximized;
    }

    private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        //Shutdown Application when Dashboard closes
        Application.Exit();
    }
}