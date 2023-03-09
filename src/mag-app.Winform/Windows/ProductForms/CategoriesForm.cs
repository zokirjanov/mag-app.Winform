using mag_app.DataAccess.DbContexts;
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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Tag = i;
                categoryFlowPanel.Controls.Add(button);
            }
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(new AppDbContext());
            addCategoryForm.ShowDialog();
        }
    }
}
