using BarcodeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.ProductForms
{
    public partial class Product_Info : Form
    {
        public Product_Info()
        {
            InitializeComponent();
        }
        string barcodetext = "123456789123";
        private void Product_Info_Load(object sender, EventArgs e)
        {
            Barcode barcode = new Barcode();
            Color forecolor = Color.Black;
            Color backcolor = Color.Transparent;
            Image img = barcode.Encode(TYPE.UPCA, barcodetext, forecolor, backcolor, (int)(barcodePictureBox.Width * 0.8), (int)(barcodePictureBox.Height * 0.8));
            barcodePictureBox.Image = img;
        }
    }
}
