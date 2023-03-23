using mag_app.DataAccess.DbContexts;
using mag_app.Winform.Windows;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.Quick_PassForms;

namespace mag_app.Winform
{
    public partial class MainForm : Form
    {
        private AddStoreForm _addStore;
        public static MainForm mainParent;
        public Button btn;
        public Panel pnl;



        public MainForm(AppDbContext appDbContext)
        {
            _addStore = new AddStoreForm(appDbContext);
            InitializeComponent();
            mainParent = this;
            btn = marketbtn;
            pnl = MainPanel;
        }



        public void marketbtn_Click(object sender, EventArgs e)
        {
            mainParent.openChildForm(new MyStoreForm(new AppDbContext()));            
        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, MenuPanel.ClientRectangle,
               Color.White, 1, ButtonBorderStyle.Solid, // left
               Color.Transparent, 1, ButtonBorderStyle.Solid, // top
               Color.DimGray, 1, ButtonBorderStyle.Solid, // right
               Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }




        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Do you want to Log out?", "Logging out", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                Application.Restart();
            }
            if (dlg == DialogResult.Cancel)
            {
                //do nothing
            }
        }

        private void quick_PassBtn_Click(object sender, EventArgs e)
        {
            mainParent.openChildForm(new List_products(new AppDbContext()));
        }
    }
}