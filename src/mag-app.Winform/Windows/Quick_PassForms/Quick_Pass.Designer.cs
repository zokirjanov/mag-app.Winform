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
            this.allProductViewModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.subCategoryLabel = new System.Windows.Forms.Label();
            this.categorylabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPPrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allProductViewModeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // allProductViewModeBindingSource
            // 
            this.allProductViewModeBindingSource.DataSource = typeof(mag_app.Service.Dtos.Products.AllProductViewModel);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barcodeLabel.Location = new System.Drawing.Point(60, 230);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(86, 19);
            this.barcodeLabel.TabIndex = 68;
            this.barcodeLabel.Text = "Штрих-код:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(136, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 26);
            this.label3.TabIndex = 67;
            this.label3.Text = "Быстрый прыход";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 66;
            this.label6.Text = "Цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cебестоимсть цена:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "Добавить количество:";
            // 
            // productQuantity
            // 
            this.productQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.allProductViewModeBindingSource, "Quantity", true));
            this.productQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantity.InterceptArrowKeys = false;
            this.productQuantity.Location = new System.Drawing.Point(273, 317);
            this.productQuantity.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(100, 29);
            this.productQuantity.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 60;
            this.label4.Text = "Название продукта:";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(60, 381);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(318, 39);
            this.updateBtn.TabIndex = 59;
            this.updateBtn.Text = "Добавить";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // subCategoryLabel
            // 
            this.subCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subCategoryLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.subCategoryLabel.Location = new System.Drawing.Point(206, 110);
            this.subCategoryLabel.Name = "subCategoryLabel";
            this.subCategoryLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subCategoryLabel.Size = new System.Drawing.Size(167, 19);
            this.subCategoryLabel.TabIndex = 78;
            this.subCategoryLabel.Text = "label";
            // 
            // categorylabel
            // 
            this.categorylabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categorylabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categorylabel.Location = new System.Drawing.Point(206, 80);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categorylabel.Size = new System.Drawing.Size(167, 19);
            this.categorylabel.TabIndex = 77;
            this.categorylabel.Text = "label";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(60, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Подкатегория:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(60, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 19);
            this.label9.TabIndex = 75;
            this.label9.Text = "Категория:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(60, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 79;
            this.label10.Text = "Количество:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quantityLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quantityLabel.Location = new System.Drawing.Point(206, 277);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quantityLabel.Size = new System.Drawing.Size(167, 26);
            this.quantityLabel.TabIndex = 80;
            this.quantityLabel.Text = "quantity";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(206, 140);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(167, 19);
            this.labelName.TabIndex = 81;
            this.labelName.Text = "label";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPPrice
            // 
            this.labelPPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPPrice.Location = new System.Drawing.Point(206, 170);
            this.labelPPrice.Name = "labelPPrice";
            this.labelPPrice.Size = new System.Drawing.Size(167, 19);
            this.labelPPrice.TabIndex = 82;
            this.labelPPrice.Text = "label";
            this.labelPPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(206, 200);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(167, 19);
            this.labelPrice.TabIndex = 83;
            this.labelPrice.Text = "label";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBarcode
            // 
            this.labelBarcode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBarcode.Location = new System.Drawing.Point(206, 230);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(167, 19);
            this.labelBarcode.TabIndex = 84;
            this.labelBarcode.Text = "label";
            this.labelBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Quick_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(444, 462);
            this.Controls.Add(this.labelBarcode);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPPrice);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subCategoryLabel);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.categorylabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Quick_Pass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Быстрый прыход";
            this.Load += new System.EventHandler(this.Quick_Pass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allProductViewModeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource allProductViewModeBindingSource;
        private Label barcodeLabel;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label1;
        private NumericUpDown productQuantity;
        private Label label4;
        private Button updateBtn;
        private Label subCategoryLabel;
        private Label categorylabel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label quantityLabel;
        private Label labelName;
        private Label labelPPrice;
        private Label labelPrice;
        private Label labelBarcode;
    }
}