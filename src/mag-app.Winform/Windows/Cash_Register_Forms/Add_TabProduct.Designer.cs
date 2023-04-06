namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    partial class Add_TabProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subcategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allProductViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel1 = new mag_app.Winform.Components.CustomPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductViewModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.storenameDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.subcategoryNameDataGridViewTextBoxColumn,
            this.ProductId,
            this.produtNameDataGridViewTextBoxColumn,
            this.purchasedPriceDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.allProductViewModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.Lavender;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 546);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "штрих-код";
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.barcodeDataGridViewTextBoxColumn.Width = 130;
            // 
            // storenameDataGridViewTextBoxColumn
            // 
            this.storenameDataGridViewTextBoxColumn.DataPropertyName = "Storename";
            this.storenameDataGridViewTextBoxColumn.HeaderText = "магазин";
            this.storenameDataGridViewTextBoxColumn.Name = "storenameDataGridViewTextBoxColumn";
            this.storenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "категория";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subcategoryNameDataGridViewTextBoxColumn
            // 
            this.subcategoryNameDataGridViewTextBoxColumn.DataPropertyName = "SubcategoryName";
            this.subcategoryNameDataGridViewTextBoxColumn.HeaderText = "подкатегория";
            this.subcategoryNameDataGridViewTextBoxColumn.Name = "subcategoryNameDataGridViewTextBoxColumn";
            this.subcategoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            this.ProductId.Width = 50;
            // 
            // produtNameDataGridViewTextBoxColumn
            // 
            this.produtNameDataGridViewTextBoxColumn.DataPropertyName = "ProdutName";
            this.produtNameDataGridViewTextBoxColumn.HeaderText = "наименования";
            this.produtNameDataGridViewTextBoxColumn.Name = "produtNameDataGridViewTextBoxColumn";
            this.produtNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.produtNameDataGridViewTextBoxColumn.Width = 210;
            // 
            // purchasedPriceDataGridViewTextBoxColumn
            // 
            this.purchasedPriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasedPrice";
            this.purchasedPriceDataGridViewTextBoxColumn.HeaderText = "себестоимисть";
            this.purchasedPriceDataGridViewTextBoxColumn.Name = "purchasedPriceDataGridViewTextBoxColumn";
            this.purchasedPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allProductViewModelBindingSource
            // 
            this.allProductViewModelBindingSource.DataSource = typeof(mag_app.Service.Dtos.Products.AllProductViewModel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 55);
            this.panel1.TabIndex = 1;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Red;
            this.customPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderRadius = 6;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Location = new System.Drawing.Point(13, 32);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(20, 20);
            this.customPanel1.TabIndex = 6;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "- Уже добавлено";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дважды щелкните, чтобы добавить";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(410, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Мои продукты:";
            // 
            // Add_TabProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1000, 640);
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "Add_TabProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_TabProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_TabProduct_FormClosed);
            this.Load += new System.EventHandler(this.Add_TabProduct_Load);
            this.Shown += new System.EventHandler(this.Add_TabProduct_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allProductViewModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource allProductViewModelBindingSource;
        private Panel panel1;
        private Label label1;
        private DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storenameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subcategoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn produtNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchasedPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private Label label2;
        private Label label3;
        private Components.CustomPanel customPanel1;
    }
}