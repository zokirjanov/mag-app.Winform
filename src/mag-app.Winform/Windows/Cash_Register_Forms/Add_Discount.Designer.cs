namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    partial class Add_Discount
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
            this.label1 = new System.Windows.Forms.Label();
            this.discountTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPriceWithDiscount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "скидка:";
            // 
            // discountTb
            // 
            this.discountTb.Location = new System.Drawing.Point(185, 219);
            this.discountTb.MaxLength = 3;
            this.discountTb.Name = "discountTb";
            this.discountTb.Size = new System.Drawing.Size(97, 23);
            this.discountTb.TabIndex = 1;
            this.discountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.discountTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountTb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "скидка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "цена:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "продукт:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.Location = new System.Drawing.Point(166, 135);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(116, 21);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCost
            // 
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCost.Location = new System.Drawing.Point(166, 65);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(116, 21);
            this.lblCost.TabIndex = 8;
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(166, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(116, 21);
            this.lblName.TabIndex = 10;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(281, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Итого со скидкой:";
            // 
            // lblPriceWithDiscount
            // 
            this.lblPriceWithDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceWithDiscount.Location = new System.Drawing.Point(176, 165);
            this.lblPriceWithDiscount.Name = "lblPriceWithDiscount";
            this.lblPriceWithDiscount.Size = new System.Drawing.Size(106, 21);
            this.lblPriceWithDiscount.TabIndex = 13;
            this.lblPriceWithDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(8, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 2);
            this.label4.TabIndex = 14;
            // 
            // Add_Discount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 360);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPriceWithDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.discountTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Discount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_Discount";
            this.Load += new System.EventHandler(this.Add_Discount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox discountTb;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private Label lblDiscount;
        private Label lblCost;
        private Label lblName;
        private Label label10;
        private Label label6;
        private Label lblPriceWithDiscount;
        private Label label4;
    }
}