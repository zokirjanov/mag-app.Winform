namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    partial class Return_Check
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saleDetailsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleGlobalViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleGlobalViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 58);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "- Чеки с возвращенными товарами";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(9, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 20);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(247, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "оплаченные чеки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(759, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "check number";
            this.textBox1.Size = new System.Drawing.Size(174, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.storeIdDataGridViewTextBoxColumn,
            this.storeNameDataGridViewTextBoxColumn,
            this.cashIdDataGridViewTextBoxColumn,
            this.cashNameDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.cashAmountDataGridViewTextBoxColumn,
            this.cardAmountDataGridViewTextBoxColumn,
            this.totalSaleDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.IsReturned});
            this.dataGridView1.DataSource = this.saleDetailsViewModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(945, 485);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // saleDetailsViewModelBindingSource
            // 
            this.saleDetailsViewModelBindingSource.DataSource = typeof(mag_app.Service.ViewModels.Stores.SaleDetailsViewModel);
            // 
            // saleGlobalViewModelBindingSource
            // 
            this.saleGlobalViewModelBindingSource.DataSource = typeof(mag_app.Service.ViewModels.Stores.SaleGlobalViewModel);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "check";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // storeIdDataGridViewTextBoxColumn
            // 
            this.storeIdDataGridViewTextBoxColumn.DataPropertyName = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.HeaderText = "StoreId";
            this.storeIdDataGridViewTextBoxColumn.Name = "storeIdDataGridViewTextBoxColumn";
            this.storeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // storeNameDataGridViewTextBoxColumn
            // 
            this.storeNameDataGridViewTextBoxColumn.DataPropertyName = "StoreName";
            this.storeNameDataGridViewTextBoxColumn.HeaderText = "StoreName";
            this.storeNameDataGridViewTextBoxColumn.Name = "storeNameDataGridViewTextBoxColumn";
            this.storeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.storeNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // cashIdDataGridViewTextBoxColumn
            // 
            this.cashIdDataGridViewTextBoxColumn.DataPropertyName = "CashId";
            this.cashIdDataGridViewTextBoxColumn.HeaderText = "CashId";
            this.cashIdDataGridViewTextBoxColumn.Name = "cashIdDataGridViewTextBoxColumn";
            this.cashIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cashIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cashNameDataGridViewTextBoxColumn
            // 
            this.cashNameDataGridViewTextBoxColumn.DataPropertyName = "CashName";
            this.cashNameDataGridViewTextBoxColumn.HeaderText = "Кассир";
            this.cashNameDataGridViewTextBoxColumn.Name = "cashNameDataGridViewTextBoxColumn";
            this.cashNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "Способ оплаты";
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // cashAmountDataGridViewTextBoxColumn
            // 
            this.cashAmountDataGridViewTextBoxColumn.DataPropertyName = "CashAmount";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "### ### ### ###";
            this.cashAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cashAmountDataGridViewTextBoxColumn.HeaderText = "Наличные";
            this.cashAmountDataGridViewTextBoxColumn.Name = "cashAmountDataGridViewTextBoxColumn";
            this.cashAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardAmountDataGridViewTextBoxColumn
            // 
            this.cardAmountDataGridViewTextBoxColumn.DataPropertyName = "CardAmount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "### ### ### ###";
            this.cardAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cardAmountDataGridViewTextBoxColumn.HeaderText = "Терминал";
            this.cardAmountDataGridViewTextBoxColumn.Name = "cardAmountDataGridViewTextBoxColumn";
            this.cardAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalSaleDataGridViewTextBoxColumn
            // 
            this.totalSaleDataGridViewTextBoxColumn.DataPropertyName = "TotalSale";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "### ### ### ###";
            this.totalSaleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalSaleDataGridViewTextBoxColumn.HeaderText = "общая продажа";
            this.totalSaleDataGridViewTextBoxColumn.Name = "totalSaleDataGridViewTextBoxColumn";
            this.totalSaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSaleDataGridViewTextBoxColumn.Width = 130;
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "Change";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "### ### ### ###";
            this.changeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.changeDataGridViewTextBoxColumn.HeaderText = "сдача";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            this.changeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "### ### ### ###";
            this.discountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.discountDataGridViewTextBoxColumn.HeaderText = "скидка";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Дата сделки";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IsReturned
            // 
            this.IsReturned.DataPropertyName = "IsReturned";
            this.IsReturned.HeaderText = "IsReturned";
            this.IsReturned.Name = "IsReturned";
            this.IsReturned.ReadOnly = true;
            this.IsReturned.Visible = false;
            // 
            // Return_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Return_Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return_List";
            this.Load += new System.EventHandler(this.Return_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleGlobalViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private BindingSource saleGlobalViewModelBindingSource;
        private TextBox textBox1;
        private BindingSource saleDetailsViewModelBindingSource;
        private Label label1;
        public DataGridView dataGridView1;
        private Label label2;
        private Panel panel2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn storeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalSaleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IsReturned;
    }
}