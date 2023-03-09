using mag_app.DataAccess.DbContexts;
using mag_app.Service.Common.Helpers;
using mag_app.Service.Services.ProductService;
using mag_app.Service.Services.StoreService;
using mag_app.Winform.Windows;
using mag_app.Winform.Windows.Product_Forms;
using mag_app.Winform.Windows.ProductForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Components
{
    public partial class productControl : UserControl
    {
        private ProductService _service;
        public productControl(AppDbContext appDbContext)
        {
            InitializeComponent();
            _service = new ProductService(appDbContext);
        }

        public string ProductName { get => productNameLb.Text; set => productNameLb.Text = value; }


        //Border radius
        private int radius = 20;
        [DefaultValue(20)]
        public int Radius{get { return radius; }set{radius = value;this.RecreateRegion();}}

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

        private void productEditBtn_Click(object sender, EventArgs e)
        {
            ProductUpdateForm updateForm = new ProductUpdateForm(new AppDbContext());
            updateForm.productName = productNameLb.Text;
            updateForm.ShowDialog();
        }

        private void productDeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Do you want to delete product?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dlg == DialogResult.OK)
            {
                var res = _service.DeleteAsync(productNameLb.Text);
                AutoClosingMessageBox.Show("Succesfully deleted", "Delete", 300);
                StoreProductsForm.storeProductParent.openChildForm(new ProductManageForm());
            }
            if (dlg == DialogResult.Cancel)
            {
                this.Hide();
            }
        }
    }
}
