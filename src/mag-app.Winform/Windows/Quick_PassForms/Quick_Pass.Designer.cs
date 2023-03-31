namespace mag_app.Winform.Windows.Quick_PassForms
{
    partial class Quick_Pass
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
            this.productNameCheckLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.purchasedPriceChecker = new System.Windows.Forms.Label();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.allProductViewModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.purchasePriceTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.NumericUpDown();
            this.productPriceTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.subCategoryLabel = new System.Windows.Forms.Label();
            this.categorylabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allProductViewModeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameCheckLabel
            // 
            this.productNameCheckLabel.AutoSize = true;
            this.productNameCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameCheckLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.productNameCheckLabel.Location = new System.Drawing.Point(17, 199);
            this.productNameCheckLabel.Name = "productNameCheckLabel";
            this.productNameCheckLabel.Size = new System.Drawing.Size(20, 25);
            this.productNameCheckLabel.TabIndex = 74;
            this.productNameCheckLabel.Text = "*";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(192, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 73;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(180, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 15);
            this.label7.TabIndex = 72;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(17, 321);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(20, 25);
            this.price.TabIndex = 71;
            this.price.Text = "*";
            // 
            // purchasedPriceChecker
            // 
            this.purchasedPriceChecker.AutoSize = true;
            this.purchasedPriceChecker.BackColor = System.Drawing.Color.Transparent;
            this.purchasedPriceChecker.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasedPriceChecker.ForeColor = System.Drawing.Color.Red;
            this.purchasedPriceChecker.Location = new System.Drawing.Point(17, 261);
            this.purchasedPriceChecker.Name = "purchasedPriceChecker";
            this.purchasedPriceChecker.Size = new System.Drawing.Size(20, 25);
            this.purchasedPriceChecker.TabIndex = 70;
            this.purchasedPriceChecker.Text = "*";
            // 
            // barcodeTb
            // 
            this.barcodeTb.Cursor = System.Windows.Forms.Cursors.No;
            this.barcodeTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allProductViewModeBindingSource, "Barcode", true));
            this.barcodeTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barcodeTb.Location = new System.Drawing.Point(40, 381);
            this.barcodeTb.MaxLength = 13;
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.ReadOnly = true;
            this.barcodeTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barcodeTb.Size = new System.Drawing.Size(314, 30);
            this.barcodeTb.TabIndex = 69;
            // 
            // allProductViewModeBindingSource
            // 
            this.allProductViewModeBindingSource.DataSource = typeof(mag_app.Service.Dtos.Products.AllProductViewModel);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barcodeLabel.Location = new System.Drawing.Point(38, 359);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(90, 19);
            this.barcodeLabel.TabIndex = 68;
            this.barcodeLabel.Text = "Штрих-код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(84, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 26);
            this.label3.TabIndex = 67;
            this.label3.Text = "редактировать форму";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cебестоимсть цена";
            // 
            // purchasePriceTb
            // 
            this.purchasePriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchasePriceTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allProductViewModeBindingSource, "PurchasedPrice", true));
            this.purchasePriceTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceTb.Location = new System.Drawing.Point(40, 256);
            this.purchasePriceTb.MaxLength = 10;
            this.purchasePriceTb.Name = "purchasePriceTb";
            this.purchasePriceTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.purchasePriceTb.Size = new System.Drawing.Size(314, 30);
            this.purchasePriceTb.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 22);
            this.label1.TabIndex = 63;
            this.label1.Text = "добавить количество";
            // 
            // productQuantity
            // 
            this.productQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.allProductViewModeBindingSource, "Quantity", true));
            this.productQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantity.Location = new System.Drawing.Point(254, 435);
            this.productQuantity.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(100, 29);
            this.productQuantity.TabIndex = 62;
            // 
            // productPriceTb
            // 
            this.productPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productPriceTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allProductViewModeBindingSource, "Price", true));
            this.productPriceTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceTb.Location = new System.Drawing.Point(40, 316);
            this.productPriceTb.MaxLength = 10;
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productPriceTb.Size = new System.Drawing.Size(314, 30);
            this.productPriceTb.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Название продукта";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(40, 486);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(314, 39);
            this.updateBtn.TabIndex = 59;
            this.updateBtn.Text = "редактировать";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // productNameTb
            // 
            this.productNameTb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.allProductViewModeBindingSource, "ProdutName", true));
            this.productNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameTb.Location = new System.Drawing.Point(40, 195);
            this.productNameTb.MaxLength = 30;
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(314, 29);
            this.productNameTb.TabIndex = 58;
            // 
            // subCategoryLabel
            // 
            this.subCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subCategoryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subCategoryLabel.Location = new System.Drawing.Point(254, 120);
            this.subCategoryLabel.Name = "subCategoryLabel";
            this.subCategoryLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subCategoryLabel.Size = new System.Drawing.Size(100, 19);
            this.subCategoryLabel.TabIndex = 78;
            this.subCategoryLabel.Text = "subcategory";
            // 
            // categorylabel
            // 
            this.categorylabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categorylabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categorylabel.Location = new System.Drawing.Point(254, 75);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categorylabel.Size = new System.Drawing.Size(100, 19);
            this.categorylabel.TabIndex = 77;
            this.categorylabel.Text = "category";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(38, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Подкатегория:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(38, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 19);
            this.label9.TabIndex = 75;
            this.label9.Text = "Категория:";
            // 
            // Quick_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(395, 573);
            this.Controls.Add(this.subCategoryLabel);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.productNameCheckLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price);
            this.Controls.Add(this.purchasedPriceChecker);
            this.Controls.Add(this.barcodeTb);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.purchasePriceTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.productPriceTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.productNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Quick_Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "быстрый прыход";
            this.Load += new System.EventHandler(this.Quick_Pass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allProductViewModeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productNameCheckLabel;
        private Label label2;
        private Label label7;
        private Label price;
        private Label purchasedPriceChecker;
        private TextBox barcodeTb;
        private BindingSource allProductViewModeBindingSource;
        private Label barcodeLabel;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox purchasePriceTb;
        private Label label1;
        private NumericUpDown productQuantity;
        private TextBox productPriceTb;
        private Label label4;
        private Button updateBtn;
        private TextBox productNameTb;
        private Label subCategoryLabel;
        private Label categorylabel;
        private Label label8;
        private Label label9;
    }
}