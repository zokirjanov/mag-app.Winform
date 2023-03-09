using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Windows;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.ProductForms;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Drawing2D;

namespace mag_app.Winform.Components
{
    public partial class storeControl : UserControl
    {
        private StoreService _service;
        public storeControl(AppDbContext appDbContext)
        {
            InitializeComponent();
            _service = new StoreService(appDbContext);
        }

        public long _count;
        public string StoreName { get => storeNameLabel.Text; set => storeNameLabel.Text = value; }


        //Border radius
        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Do you want to delete store?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = _service.DeleteAsync(storeNameLabel.Text);
                AutoClosingMessageBox.Show("Succesfully deleted", "Delete", 300);
                MainForm.mainParent.pnl.Controls.Clear();
                MainForm.mainParent.marketbtn_Click(sender, e);
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(new AppDbContext());
            updateForm.storeName = storeNameLabel.Text;
            updateForm.ShowDialog();
        }

        private void storeControl_Click(object sender, EventArgs e)
        {
            MainForm.mainParent.Hide();
            StoreProductsForm storeProductsForm = new StoreProductsForm();
            storeProductsForm.Show();
        }

        private void storeControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
            storeNameLabel.BackColor = Color.Cyan;
        }

        private void storeControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            storeNameLabel.BackColor = Color.AliceBlue;
        }
    }
}

