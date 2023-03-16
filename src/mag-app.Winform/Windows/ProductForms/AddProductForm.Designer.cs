namespace mag_app.Winform.Windows.ProductForms
{
    partial class AddProductForm
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
            this.productNameTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.purchasePriceTb = new System.Windows.Forms.TextBox();
            this.productQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productNameCheckLabel = new System.Windows.Forms.Label();
            this.productPriceChecker = new System.Windows.Forms.Label();
            this.purchasedPriceChecker = new System.Windows.Forms.Label();
            this.productPriceTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameTb
            // 
            this.productNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameTb.Location = new System.Drawing.Point(34, 37);
            this.productNameTb.MaxLength = 30;
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(314, 30);
            this.productNameTb.TabIndex = 6;
            this.productNameTb.TextChanged += new System.EventHandler(this.productNameTb_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(34, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "добавлять";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchasePriceTb
            // 
            this.purchasePriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchasePriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchasePriceTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceTb.Location = new System.Drawing.Point(34, 99);
            this.purchasePriceTb.MaxLength = 50;
            this.purchasePriceTb.Name = "purchasePriceTb";
            this.purchasePriceTb.Size = new System.Drawing.Size(314, 30);
            this.purchasePriceTb.TabIndex = 9;
            this.purchasePriceTb.TextChanged += new System.EventHandler(this.productPriceTb_TextChanged);
            this.purchasePriceTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // productQuantity
            // 
            this.productQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantity.Location = new System.Drawing.Point(228, 211);
            this.productQuantity.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(120, 29);
            this.productQuantity.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "количество:";
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(34, 293);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(314, 77);
            this.productDescription.TabIndex = 12;
            this.productDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "описание:";
            // 
            // productNameCheckLabel
            // 
            this.productNameCheckLabel.AutoSize = true;
            this.productNameCheckLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameCheckLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameCheckLabel.ForeColor = System.Drawing.Color.Red;
            this.productNameCheckLabel.Location = new System.Drawing.Point(12, 42);
            this.productNameCheckLabel.Name = "productNameCheckLabel";
            this.productNameCheckLabel.Size = new System.Drawing.Size(20, 25);
            this.productNameCheckLabel.TabIndex = 14;
            this.productNameCheckLabel.Text = "*";
            // 
            // productPriceChecker
            // 
            this.productPriceChecker.AutoSize = true;
            this.productPriceChecker.BackColor = System.Drawing.Color.Transparent;
            this.productPriceChecker.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceChecker.ForeColor = System.Drawing.Color.Red;
            this.productPriceChecker.Location = new System.Drawing.Point(12, 104);
            this.productPriceChecker.Name = "productPriceChecker";
            this.productPriceChecker.Size = new System.Drawing.Size(20, 25);
            this.productPriceChecker.TabIndex = 15;
            this.productPriceChecker.Text = "*";
            // 
            // purchasedPriceChecker
            // 
            this.purchasedPriceChecker.AutoSize = true;
            this.purchasedPriceChecker.BackColor = System.Drawing.Color.Transparent;
            this.purchasedPriceChecker.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasedPriceChecker.ForeColor = System.Drawing.Color.Red;
            this.purchasedPriceChecker.Location = new System.Drawing.Point(12, 160);
            this.purchasedPriceChecker.Name = "purchasedPriceChecker";
            this.purchasedPriceChecker.Size = new System.Drawing.Size(20, 25);
            this.purchasedPriceChecker.TabIndex = 25;
            this.purchasedPriceChecker.Text = "*";
            // 
            // productPriceTb
            // 
            this.productPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productPriceTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceTb.Location = new System.Drawing.Point(34, 157);
            this.productPriceTb.MaxLength = 50;
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.Size = new System.Drawing.Size(314, 30);
            this.productPriceTb.TabIndex = 24;
            this.productPriceTb.TextChanged += new System.EventHandler(this.productPriceTb_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Название продукта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Cебестоимсть цена";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(34, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 28;
            this.label6.Text = "Цена";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(385, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchasedPriceChecker);
            this.Controls.Add(this.productPriceTb);
            this.Controls.Add(this.productPriceChecker);
            this.Controls.Add(this.productNameCheckLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.purchasePriceTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox productNameTb;
        private Button button1;
        private TextBox purchasePriceTb;
        private NumericUpDown productQuantity;
        private Label label1;
        private RichTextBox productDescription;
        private Label label2;
        private Label productNameCheckLabel;
        private Label productPriceChecker;
        private Label purchasedPriceChecker;
        private TextBox productPriceTb;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}