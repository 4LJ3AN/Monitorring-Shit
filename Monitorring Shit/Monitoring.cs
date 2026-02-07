namespace Monitorring_Shit
{
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
        }

        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();     // Remove old page
            uc.Dock = DockStyle.Fill;       // Fill main panel
            panelMain.Controls.Add(uc);     // Load new page
        }

        private void buttonTabTennis_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Table_Tennis());
        }

        private void buttonBilliards_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Billiards_Tables());
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {
            LoadUserControl(new Badminton());
        }

        private void buttonBadminton_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new Badminton());
        }

        private void buttonScooter_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Scooter());
        }
    }

}
