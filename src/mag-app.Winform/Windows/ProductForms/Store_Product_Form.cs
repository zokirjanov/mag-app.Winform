using mag_app.DataAccess.DbContexts;
using mag_app.Winform.Windows.AuthorisationForms;
using mag_app.Winform.Windows.Cash_Register_Forms;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.ProductForms;
using mag_app.Winform.Windows.Quick_PassForms;

namespace mag_app.Winform.Windows.Product_Forms
{
    public partial class Store_Product_Form : Form
    {
        public static Store_Product_Form storeProductParent = default!;
        public Button btn;
        public Button backBtn;
        public Panel pnl;
        public FlowLayoutPanel title1;
        public FlowLayoutPanel title2;

        public Store_Product_Form()
        {
            InitializeComponent();
            storeProductParent = this;
            btn = productBtn;
            backBtn = backButton;
            pnl = productChildPanel;
            title1 = titleFlowPanel;
            title2 = subtitleFlowPanel;

        }


        private void StoreProductsForm_Load(object sender, EventArgs e)
        {
            AddTitle(Stores_Form.myStoreFormParent.StoreName, "›магазин");
        }



        private void StoreProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }




        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm.mainParent.Show();
            MainForm.mainParent.openChildForm(new Stores_Form());
        }





        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, MenuPanel.ClientRectangle,
            Color.White, 1, ButtonBorderStyle.Solid, // left
            Color.Transparent, 1, ButtonBorderStyle.Solid, // top
            Color.DimGray, 1, ButtonBorderStyle.Solid, // right
            Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }




        private Form activeForm = null!;
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





        public void AddTitle(string title, string subtitles)
        {
            var Title = new Label()
            {
                ForeColor = Color.Black,
                Text = title,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Padding = new Padding(0, 0, 0, 0),
                Width = 105
            };
            var subtitle = new Label()
            {
                ForeColor = Color.Black,
                Text = subtitles,
                Font = new Font("Arial", 10),
                Height = 15,
                Width = 105
            };
            titleFlowPanel.Controls.Add(Title);
            subtitleFlowPanel.Controls.Add(subtitle);
        }




        private void titleFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, titleFlowPanel.ClientRectangle,
              Color.Transparent, 1, ButtonBorderStyle.Solid, // left
              Color.Transparent, 1, ButtonBorderStyle.Solid, // top
              Color.Transparent, 1, ButtonBorderStyle.Solid, // right
              Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }




        public void productBtn_Click(object sender, EventArgs e)
        {
            storeProductParent.openChildForm(new Category_Form());
            storeProductParent.backBtn.Show();
            titleFlowPanel.Controls.Clear();
            subtitleFlowPanel.Controls.Clear();
            AddTitle(Stores_Form.myStoreFormParent.StoreName, "›магазин");
        }

        private void quick_PassBtn_Click(object sender, EventArgs e)
        {
            storeProductParent.openChildForm(new List_products());
            storeProductParent.backBtn.Show();
            titleFlowPanel.Controls.Clear();
            subtitleFlowPanel.Controls.Clear();
            AddTitle(Stores_Form.myStoreFormParent.StoreName, "›магазин");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            storeProductParent.openChildForm(new Cash_Register_List());
            storeProductParent.backBtn.Show();
            titleFlowPanel.Controls.Clear();
            subtitleFlowPanel.Controls.Clear();
            AddTitle(Stores_Form.myStoreFormParent.StoreName, "›магазин");
        }
    }
}
