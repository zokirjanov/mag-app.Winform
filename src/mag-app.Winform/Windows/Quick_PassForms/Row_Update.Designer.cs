﻿namespace mag_app.Winform.Windows.Quick_PassForms
{
    partial class Row_Update
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
            this.barcodeTb = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeTb
            // 
            this.barcodeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.barcodeTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barcodeTb.Location = new System.Drawing.Point(41, 311);
            this.barcodeTb.MaxLength = 13;
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.Size = new System.Drawing.Size(314, 30);
            this.barcodeTb.TabIndex = 52;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barcodeLabel.Location = new System.Drawing.Point(39, 289);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(90, 19);
            this.barcodeLabel.TabIndex = 51;
            this.barcodeLabel.Text = "Штрих-код";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 26);
            this.label3.TabIndex = 50;
            this.label3.Text = "редактировать форму";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cебестоимсть цена";
            // 
            // purchasePriceTb
            // 
            this.purchasePriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.purchasePriceTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchasePriceTb.Location = new System.Drawing.Point(41, 186);
            this.purchasePriceTb.MaxLength = 10;
            this.purchasePriceTb.Name = "purchasePriceTb";
            this.purchasePriceTb.Size = new System.Drawing.Size(314, 30);
            this.purchasePriceTb.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 46;
            this.label1.Text = "количество:";
            // 
            // productQuantity
            // 
            this.productQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productQuantity.Location = new System.Drawing.Point(235, 365);
            this.productQuantity.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(120, 29);
            this.productQuantity.TabIndex = 45;
            // 
            // productPriceTb
            // 
            this.productPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productPriceTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productPriceTb.Location = new System.Drawing.Point(41, 246);
            this.productPriceTb.MaxLength = 10;
            this.productPriceTb.Name = "productPriceTb";
            this.productPriceTb.Size = new System.Drawing.Size(314, 30);
            this.productPriceTb.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Название продукта";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(41, 416);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(314, 39);
            this.updateBtn.TabIndex = 42;
            this.updateBtn.Text = "редактировать";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click_1);
            // 
            // productNameTb
            // 
            this.productNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productNameTb.Location = new System.Drawing.Point(41, 125);
            this.productNameTb.MaxLength = 30;
            this.productNameTb.Name = "productNameTb";
            this.productNameTb.Size = new System.Drawing.Size(314, 29);
            this.productNameTb.TabIndex = 41;
            // 
            // Row_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 489);
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
            this.Name = "Row_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Row_Update";
            this.Load += new System.EventHandler(this.Row_Update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox barcodeTb;
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
    }
}