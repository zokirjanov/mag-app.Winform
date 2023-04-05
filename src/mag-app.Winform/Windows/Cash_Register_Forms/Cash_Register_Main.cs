using mag_app.Service.Services.StoreService;
using mag_app.Winform.Windows.Product_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    public partial class Cash_Register_Main : Form
    {

        public static Cash_Register_Main cashRegisterMainParent = default!;
        TabService _service;

        public Cash_Register_Main()
        {
            cashRegisterMainParent = this;
            _service = new TabService();
            InitializeComponent();
        }

        private void Cash_Register_Main_Load(object sender, EventArgs e)
        {
            FillTabs();
        }


        public long TabId { get; set; }
        public string TabName { get; set; } = string.Empty;


        /// <summary>
        /// Tab Controllers Dynamically
        /// </summary>
        public async void FillTabs()
        {
            tabFlowPanel.Controls.Clear();
            Panel firstpanel = new Panel()
            {
                Width = 80,
                Height = tabFlowPanel.Height,
            };
            Button settingtab = new Button()
            {
                Parent = firstpanel,
                Height = 40,
                Width = 40,
                BackColor= Color.Azure,
                Location = new Point(0, 3),
                Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/cogwheel.png"),
            };
            Button addTab = new Button()
            {
                Parent = firstpanel,
                Height = 40,
                Width = 40,
                BackColor = Color.Azure,
                Location = new Point(40, 3),
                Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/plus.png"),
            };
            addTab.Click += (s, e) =>
            {
                Add_TabControl add_TabControl = new Add_TabControl();
                add_TabControl.ShowDialog();
            };

            tabFlowPanel.Controls.Add(firstpanel);

            var items = await _service.GetAllAsync();
            if (items is null)
            {
                MessageBox.Show("Tabs not found");
            }
            else
            {
                foreach (var item in items)
                {
                    AddItem(item.TabName);
                }
            }

        }

        string buttonText = "";

        /// <summary>
        /// Add  TabControls dynamically
        /// </summary>
        /// <param name="tabname"></param>
        private void AddItem(string tabname)
        {
            var tabButton = new Button
            {
                Text = tabname,
                Width = 90,
                Height = 40,
                BackColor = Color.WhiteSmoke,
                Margin = new Padding(1,6,0,0),
                Font = new Font("Times New Roman", 14),
            };
            tabButton.Click += async (s, e) =>
            {   
             //   tabButton.Margin = new Padding(1,17,0,0);
                TabId = await _service.GetId(tabname);
                TabName = tabname;
                TabProductsFill();
            };

            tabFlowPanel.Controls.Add(tabButton);
        }



        /// <summary>
        /// Tab Products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabProductsFill()
        {
            tabProductFlowPanel.Controls.Clear();
            Panel firstpanel = new Panel()
            {
                Width = 120,
                Height = 60,
            };
            Button settingtab = new Button()
            {
                Parent = firstpanel,
                Height = firstpanel.Height,
                Width = firstpanel.Width/2,
                BackColor = Color.Azure,
                Location = new Point(0, 0),
                Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/cogwheel.png"),
            };
            Button addTab = new Button()
            {
                Parent = firstpanel,
                Height = firstpanel.Height,
                Width = firstpanel.Width / 2,
                BackColor = Color.Azure,
                Location = new Point(60, 0),
                Image = Image.FromFile("Data Source= ../../../../../Resources/Icons/plus.png"),
            };
            addTab.Click += (s, e) =>
            {
                Add_TabProduct add_TabProduct = new Add_TabProduct();
                add_TabProduct.ShowDialog();
            };

            tabProductFlowPanel.Controls.Add(firstpanel);
        }




        private void Cash_Register_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            StoreProductsForm.storeProductParent.Show();
            this.Close();
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
          //  ControlPaint.DrawBorder(e.Graphics, tabFlowPanel.ClientRectangle,
          //Color.Blue, 1, ButtonBorderStyle.Solid, // left
          //Color.Blue, 1, ButtonBorderStyle.Solid, // top
          //Color.Blue, 1, ButtonBorderStyle.Solid, // right
          //Color.Blue, 1, ButtonBorderStyle.Solid);// bottom
        }
    }
}
