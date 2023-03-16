namespace mag_app.Winform.Windows.ProductForms
{
    partial class Store_Add_ProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.NumericUpDown();
            this.productPriceTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.purchasePriceTb = new System.Windows.Forms.TextBox();
            this.purchasedPriceChecker = new System.Windows.Forms.Label();
            this.productNameCheckLabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.subCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "описание:";
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(35, 361);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(314, 77);
            this.productDescription.TabIndex = 19;
            this.productDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "количество:";
            // 
            // productQuantity
            // 
            this.productQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantity.Location = new System.Drawing.Point(229, 295);
            this.productQuantity.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(120, 29);
            this.productQuantity.TabIndex = 17;
            // 
            // productPriceTb
            // 
            this.productPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productPriceTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceTb.Location = new System.Drawing.Point(35, 182);
            this.productPriceTb.MaxLength = 50;
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.Size = new System.Drawing.Size(314, 30);
            this.productPriceTb.TabIndex = 16;
            this.productPriceTb.TextChanged += new System.EventHandler(this.productPriceTb_TextChanged);
            this.productPriceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPriceTb_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(35, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "добавлять";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productNameTb
            // 
            this.productNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameTb.Location = new System.Drawing.Point(35, 57);
            this.productNameTb.MaxLength = 30;
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(314, 30);
            this.productNameTb.TabIndex = 14;
            this.productNameTb.TextChanged += new System.EventHandler(this.productNameTb_TextChanged);
            // 
            // purchasePriceTb
            // 
            this.purchasePriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchasePriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchasePriceTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceTb.Location = new System.Drawing.Point(35, 119);
            this.purchasePriceTb.MaxLength = 50;
            this.purchasePriceTb.Name = "purchasePriceTb";
            this.purchasePriceTb.Size = new System.Drawing.Size(314, 30);
            this.purchasePriceTb.TabIndex = 21;
            this.purchasePriceTb.TextChanged += new System.EventHandler(this.purchasePriceTb_TextChanged);
            this.purchasePriceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purchasePriceTb_KeyPress);
            // 
            // purchasedPriceChecker
            // 
            this.purchasedPriceChecker.AutoSize = true;
            this.purchasedPriceChecker.BackColor = System.Drawing.Color.Transparent;
            this.purchasedPriceChecker.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasedPriceChecker.ForeColor = System.Drawing.Color.Red;
            this.purchasedPriceChecker.Location = new System.Drawing.Point(12, 122);
            this.purchasedPriceChecker.Name = "purchasedPriceChecker";
            this.purchasedPriceChecker.Size = new System.Drawing.Size(20, 25);
            this.purchasedPriceChecker.TabIndex = 23;
            this.purchasedPriceChecker.Text = "*";
            // 
            // productNameCheckLabel
            // 
            this.productNameCheckLabel.AutoSize = true;
            this.productNameCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameCheckLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.productNameCheckLabel.Location = new System.Drawing.Point(12, 57);
            this.productNameCheckLabel.Name = "productNameCheckLabel";
            this.productNameCheckLabel.Size = new System.Drawing.Size(20, 25);
            this.productNameCheckLabel.TabIndex = 22;
            this.productNameCheckLabel.Text = "*";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(12, 186);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(20, 25);
            this.price.TabIndex = 24;
            this.price.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(33, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Название продукта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(33, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cебестоимсть цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Цена";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(35, 244);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(146, 23);
            this.categoryComboBox.TabIndex = 28;
            // 
            // subCategoryComboBox
            // 
            this.subCategoryComboBox.FormattingEnabled = true;
            this.subCategoryComboBox.Location = new System.Drawing.Point(203, 244);
            this.subCategoryComboBox.Name = "subCategoryComboBox";
            this.subCategoryComboBox.Size = new System.Drawing.Size(146, 23);
            this.subCategoryComboBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Категория";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(210, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Подкатегория";
            // 
            // Store_Add_ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 547);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.subCategoryComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.purchasedPriceChecker);
            this.Controls.Add(this.productNameCheckLabel);
            this.Controls.Add(this.purchasePriceTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.productPriceTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productNameTb);
            this.Name = "Store_Add_ProductForm";
            this.Text = "Store_Add_ProductForm";
            this.Load += new System.EventHandler(this.Store_Add_ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private RichTextBox productDescription;
        private Label label1;
        private NumericUpDown productQuantity;
        private TextBox productPriceTb;
        private Button button1;
        private TextBox productNameTb;
        private TextBox purchasePriceTb;
        private Label purchasedPriceChecker;
        private Label productNameCheckLabel;
        private Label price;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox categoryComboBox;
        private ComboBox subCategoryComboBox;
        private Label label7;
        private Label label8;
    }
}