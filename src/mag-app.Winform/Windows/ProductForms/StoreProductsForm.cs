using mag_app.DataAccess.DbContexts;
using mag_app.Winform.Components;
using mag_app.Winform.Windows.MainWindowForms;
using mag_app.Winform.Windows.ProductForms;
using System.Security.Cryptography.X509Certificates;

namespace mag_app.Winform.Windows.Product_Forms
{
    public partial class StoreProductsForm : Form
    {
        public static StoreProductsForm storeProductParent;
        public Button btn;
        public Button backBtn;
        public Panel pnl;
        public FlowLayoutPanel title1;
        public FlowLayoutPanel title2;

        public StoreProductsForm()
        {
            InitializeComponent();
            storeProductParent = this;
            btn = productBtn;
            backBtn = backButton;
            pnl = productChildPanel;
            title1 = titleFlowPanel;
            title2 = subtitleFlowPanel;

        }
  //      public string  Title { get; set; }
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
            storeProductParent.backBtn.Show();
            titleFlowPanel.Controls.Clear();    
            subtitleFlowPanel.Controls.Clear();
            AddTitle(MyStoreForm.myStoreFormParent.StoreName, "›магазин");
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
        public void AddTitle(string title, string subtitles)
        {
            var Title = new Label()
            {
                ForeColor = Color.Black,
                Text = title,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Padding = new Padding(0,0,0,0),
                Width = 100
            };
            var subtitle = new Label()
            {
                ForeColor = Color.Black,
                Text = subtitles,
                Font = new Font("Arial", 10),
                Height = 15,
                Width= 100,
            };
            titleFlowPanel.Controls.Add(Title);
            subtitleFlowPanel.Controls.Add(subtitle);
        }

        private void StoreProductsForm_Load(object sender, EventArgs e)
        {
            AddTitle(MyStoreForm.myStoreFormParent.StoreName, "›магазин");
        }

        private void titleFlowPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, titleFlowPanel.ClientRectangle,
              Color.Transparent, 1, ButtonBorderStyle.Solid, // left
              Color.Transparent, 1, ButtonBorderStyle.Solid, // top
              Color.Transparent, 1, ButtonBorderStyle.Solid, // right
              Color.DimGray, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
