using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Product_Forms
{
    public partial class StoreProductsForm : Form
    {
        public static StoreProductsForm storeProductParent;
        public StoreProductsForm()
        {
            InitializeComponent();
            storeProductParent = this;
        }

        private void StoreProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
