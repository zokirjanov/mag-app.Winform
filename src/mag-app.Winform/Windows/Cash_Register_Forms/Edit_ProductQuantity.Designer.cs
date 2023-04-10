namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    partial class Edit_ProductQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_ProductQuantity));
            this.customPanel2 = new mag_app.Winform.Components.CustomPanel();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.nameLb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.decrementBtn = new System.Windows.Forms.Button();
            this.incrementBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaxQ = new System.Windows.Forms.Label();
            this.customPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.LightYellow;
            this.customPanel2.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 5;
            this.customPanel2.BorderSize = 1;
            this.customPanel2.Controls.Add(this.quantityTb);
            this.customPanel2.Location = new System.Drawing.Point(69, 50);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(185, 35);
            this.customPanel2.TabIndex = 1;
            this.customPanel2.UnderlinedStyle = false;
            // 
            // quantityTb
            // 
            this.quantityTb.BackColor = System.Drawing.Color.LightYellow;
            this.quantityTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTb.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTb.Location = new System.Drawing.Point(2, 5);
            this.quantityTb.MaxLength = 17;
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(162, 25);
            this.quantityTb.TabIndex = 11;
            this.quantityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityTb.TextChanged += new System.EventHandler(this.quantityTb_TextChanged);
            this.quantityTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTb_KeyPress);
            // 
            // nameLb
            // 
            this.nameLb.AutoSize = true;
            this.nameLb.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLb.Location = new System.Drawing.Point(16, 3);
            this.nameLb.Name = "nameLb";
            this.nameLb.Size = new System.Drawing.Size(57, 22);
            this.nameLb.TabIndex = 8;
            this.nameLb.Text = "name";
            this.nameLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(43, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "00";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComa
            // 
            this.btnComa.BackColor = System.Drawing.Color.White;
            this.btnComa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComa.Location = new System.Drawing.Point(210, 345);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(72, 56);
            this.btnComa.TabIndex = 10;
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = false;
            this.btnComa.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(43, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 56);
            this.button4.TabIndex = 12;
            this.button4.Text = "1";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(127, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 56);
            this.button5.TabIndex = 13;
            this.button5.Text = "2";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(210, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 56);
            this.button6.TabIndex = 14;
            this.button6.Text = "3";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(43, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 56);
            this.button7.TabIndex = 15;
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(127, 213);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 56);
            this.button8.TabIndex = 16;
            this.button8.Text = "5";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(210, 213);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 56);
            this.button9.TabIndex = 17;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(43, 147);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(72, 56);
            this.button10.TabIndex = 18;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(127, 147);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 56);
            this.button11.TabIndex = 19;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(210, 147);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(72, 56);
            this.button12.TabIndex = 20;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MistyRose;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(43, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 37);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button14.Location = new System.Drawing.Point(127, 345);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(72, 56);
            this.button14.TabIndex = 22;
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.LightGray;
            this.btnBackspace.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(181, 104);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(100, 37);
            this.btnBackspace.TabIndex = 23;
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.button15_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleGreen;
            this.button3.Location = new System.Drawing.Point(43, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(239, 40);
            this.button3.TabIndex = 24;
            this.button3.Text = "Enter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // decrementBtn
            // 
            this.decrementBtn.Image = ((System.Drawing.Image)(resources.GetObject("decrementBtn.Image")));
            this.decrementBtn.Location = new System.Drawing.Point(18, 44);
            this.decrementBtn.Name = "decrementBtn";
            this.decrementBtn.Size = new System.Drawing.Size(45, 45);
            this.decrementBtn.TabIndex = 25;
            this.decrementBtn.UseVisualStyleBackColor = true;
            this.decrementBtn.Click += new System.EventHandler(this.button16_Click);
            // 
            // incrementBtn
            // 
            this.incrementBtn.Image = ((System.Drawing.Image)(resources.GetObject("incrementBtn.Image")));
            this.incrementBtn.Location = new System.Drawing.Point(260, 44);
            this.incrementBtn.Name = "incrementBtn";
            this.incrementBtn.Size = new System.Drawing.Size(45, 45);
            this.incrementBtn.TabIndex = 26;
            this.incrementBtn.UseVisualStyleBackColor = true;
            this.incrementBtn.Click += new System.EventHandler(this.button17_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "максимальное количество на складе:";
            // 
            // lblMaxQ
            // 
            this.lblMaxQ.AutoSize = true;
            this.lblMaxQ.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaxQ.Location = new System.Drawing.Point(230, 21);
            this.lblMaxQ.Name = "lblMaxQ";
            this.lblMaxQ.Size = new System.Drawing.Size(57, 22);
            this.lblMaxQ.TabIndex = 28;
            this.lblMaxQ.Text = "name";
            this.lblMaxQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Edit_ProductQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(324, 454);
            this.Controls.Add(this.lblMaxQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.incrementBtn);
            this.Controls.Add(this.decrementBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnComa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameLb);
            this.Controls.Add(this.customPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit_ProductQuantity";
            this.Text = "отредактировать товар";
            this.Load += new System.EventHandler(this.Edit_ProductQuantity_Load);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Components.CustomPanel customPanel2;
        private Label nameLb;
        private TextBox quantityTb;
        private Button button1;
        private Button btnComa;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button btnClear;
        private Button button14;
        private Button btnBackspace;
        private Button button3;
        private Button decrementBtn;
        private Button incrementBtn;
        private ErrorProvider errorProvider1;
        private Label lblMaxQ;
        private Label label1;
    }
}