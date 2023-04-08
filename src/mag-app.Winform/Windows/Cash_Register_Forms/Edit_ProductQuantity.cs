using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Edit_ProductQuantity : Form
    {
        public Edit_ProductQuantity()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Cash_Register_Main.cashRegisterMainParent.Location.X + 545, Cash_Register_Main.cashRegisterMainParent.Location.Y + 97);
        }
    }
}
