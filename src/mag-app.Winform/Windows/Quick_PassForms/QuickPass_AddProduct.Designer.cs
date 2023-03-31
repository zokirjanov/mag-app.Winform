﻿namespace mag_app.Winform.Windows.Quick_PassForms
{
    partial class QuickPass_AddProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeQuestion = new System.Windows.Forms.Label();
            this.barcodeCheckbox = new System.Windows.Forms.Button();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.purchasedPriceChecker = new System.Windows.Forms.Label();
            this.productNameCheckLabel = new System.Windows.Forms.Label();
            this.purchasePriceTb = new System.Windows.Forms.TextBox();
            this.productPriceTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.categoryViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(186, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 62;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(174, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 15);
            this.label1.TabIndex = 61;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // barcodeQuestion
            // 
            this.barcodeQuestion.AutoSize = true;
            this.barcodeQuestion.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barcodeQuestion.Location = new System.Drawing.Point(40, 392);
            this.barcodeQuestion.Name = "barcodeQuestion";
            this.barcodeQuestion.Size = new System.Drawing.Size(272, 22);
            this.barcodeQuestion.TabIndex = 60;
            this.barcodeQuestion.Text = "Есть ли штрих-код на товаре?";
            // 
            // barcodeCheckbox
            // 
            this.barcodeCheckbox.Location = new System.Drawing.Point(318, 389);
            this.barcodeCheckbox.Name = "barcodeCheckbox";
            this.barcodeCheckbox.Size = new System.Drawing.Size(30, 30);
            this.barcodeCheckbox.TabIndex = 59;
            this.barcodeCheckbox.UseVisualStyleBackColor = true;
            this.barcodeCheckbox.Click += new System.EventHandler(this.barcodeCheckbox_Click);
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barcodeLabel.Location = new System.Drawing.Point(32, 367);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(90, 19);
            this.barcodeLabel.TabIndex = 58;
            this.barcodeLabel.Text = "Штрих-код";
            // 
            // barcodeTb
            // 
            this.barcodeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.barcodeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcodeTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barcodeTb.Location = new System.Drawing.Point(32, 389);
            this.barcodeTb.MaxLength = 13;
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.barcodeTb.Size = new System.Drawing.Size(284, 30);
            this.barcodeTb.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "добавить продукт";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 55;
            this.label8.Text = "Подкатегория:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 54;
            this.label7.Text = "Категория:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Cебестоимсть цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "Название продукта";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(11, 321);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(20, 25);
            this.price.TabIndex = 50;
            this.price.Text = "*";
            // 
            // purchasedPriceChecker
            // 
            this.purchasedPriceChecker.AutoSize = true;
            this.purchasedPriceChecker.BackColor = System.Drawing.Color.Transparent;
            this.purchasedPriceChecker.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasedPriceChecker.ForeColor = System.Drawing.Color.Red;
            this.purchasedPriceChecker.Location = new System.Drawing.Point(11, 249);
            this.purchasedPriceChecker.Name = "purchasedPriceChecker";
            this.purchasedPriceChecker.Size = new System.Drawing.Size(20, 25);
            this.purchasedPriceChecker.TabIndex = 49;
            this.purchasedPriceChecker.Text = "*";
            // 
            // productNameCheckLabel
            // 
            this.productNameCheckLabel.AutoSize = true;
            this.productNameCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameCheckLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.productNameCheckLabel.Location = new System.Drawing.Point(11, 176);
            this.productNameCheckLabel.Name = "productNameCheckLabel";
            this.productNameCheckLabel.Size = new System.Drawing.Size(20, 25);
            this.productNameCheckLabel.TabIndex = 48;
            this.productNameCheckLabel.Text = "*";
            // 
            // purchasePriceTb
            // 
            this.purchasePriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchasePriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchasePriceTb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceTb.Location = new System.Drawing.Point(34, 246);
            this.purchasePriceTb.MaxLength = 10;
            this.purchasePriceTb.Name = "purchasePriceTb";
            this.purchasePriceTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.purchasePriceTb.Size = new System.Drawing.Size(314, 34);
            this.purchasePriceTb.TabIndex = 47;
            // 
            // productPriceTb
            // 
            this.productPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productPriceTb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceTb.Location = new System.Drawing.Point(34, 317);
            this.productPriceTb.MaxLength = 10;
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productPriceTb.Size = new System.Drawing.Size(314, 34);
            this.productPriceTb.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(32, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 39);
            this.button1.TabIndex = 45;
            this.button1.Text = "добавлять";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productNameTb
            // 
            this.productNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameTb.Location = new System.Drawing.Point(34, 176);
            this.productNameTb.MaxLength = 30;
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(314, 30);
            this.productNameTb.TabIndex = 44;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(165, 60);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(183, 23);
            this.categoryComboBox.TabIndex = 63;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged_1);
            // 
            // categoryViewModelBindingSource
            // 
            this.categoryViewModelBindingSource.DataSource = typeof(mag_app.Service.Dtos.Categories.CategoryViewModel);
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(165, 105);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(183, 23);
            this.subCategoryComboBox.TabIndex = 64;
            this.subCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.subCategoryComboBox_SelectedIndexChanged_1);
            // 
            // QuickPass_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(385, 512);
            this.Controls.Add(this.subCategoryComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barcodeQuestion);
            this.Controls.Add(this.barcodeCheckbox);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.barcodeTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.purchasedPriceChecker);
            this.Controls.Add(this.productNameCheckLabel);
            this.Controls.Add(this.purchasePriceTb);
            this.Controls.Add(this.productPriceTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuickPass_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickPass_AddProduct";
            this.Load += new System.EventHandler(this.QuickPass_AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Label barcodeQuestion;
        private Button barcodeCheckbox;
        private Label barcodeLabel;
        private TextBox barcodeTb;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label price;
        private Label purchasedPriceChecker;
        private Label productNameCheckLabel;
        private TextBox purchasePriceTb;
        private TextBox productPriceTb;
        private Button button1;
        private TextBox productNameTb;
        private ComboBox categoryComboBox;
        private ComboBox subCategoryComboBox;
        private BindingSource categoryViewModelBindingSource;
    }
}