using mag_app.DataAccess.DbContexts;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.ProductForms;
using System.Text;

namespace mag_app.Winform.Windows.Product_Forms
{
    public partial class StoreProductsForm : Form
    {
        public static StoreProductsForm storeProductParent;
        public Button btn;
        public Button backBtn;
        public Panel pnl;
        public Label titleLabel;

        public StoreProductsForm()
        {
            InitializeComponent();
            storeProductParent = this;
            btn = productBtn;
            backBtn = backButton;
            pnl = productChildPanel;
        }
    
        private void StoreProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.mainParent.Show();
            MainForm.mainParent.openChildForm(new MyStoreForm(new AppDbContext()));
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, MenuPanel.ClientRectangle,
            Color.White, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.DimGray, 1, ButtonBorderStyle.Solid, // right
            Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }

        public void productBtn_Click(object sender, EventArgs e)
        {
            storeProductParent.openChildForm(new CategoriesForm(new AppDbContext()));
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
            productChildPanel.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void StoreProductsForm_Load(object sender, EventArgs e)
        {
        
        }
    }
}
