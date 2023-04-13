namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalDiscount = new System.Windows.Forms.Label();
            this.lblRepeater = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customPanel3 = new mag_app.Winform.Components.CustomPanel();
            this.lblCard = new System.Windows.Forms.Label();
            this.btnCard = new System.Windows.Forms.Button();
            this.customPanel1 = new mag_app.Winform.Components.CustomPanel();
            this.lblCash = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblActiveSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btnDoubleZero = new System.Windows.Forms.Button();
            this.customPanel2 = new mag_app.Winform.Components.CustomPanel();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.totalDiscount);
            this.panel1.Controls.Add(this.lblRepeater);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.totalSum);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customPanel3);
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblWarning);
            this.panel1.Controls.Add(this.lblActiveSum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.btnBackspace);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btnComa);
            this.panel1.Controls.Add(this.btnDoubleZero);
            this.panel1.Controls.Add(this.customPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 661);
            this.panel1.TabIndex = 0;
            // 
            // totalDiscount
            // 
            this.totalDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalDiscount.Location = new System.Drawing.Point(150, 48);
            this.totalDiscount.Name = "totalDiscount";
            this.totalDiscount.Size = new System.Drawing.Size(204, 26);
            this.totalDiscount.TabIndex = 61;
            this.totalDiscount.Text = "0";
            this.totalDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRepeater
            // 
            this.lblRepeater.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepeater.Location = new System.Drawing.Point(150, 161);
            this.lblRepeater.Name = "lblRepeater";
            this.lblRepeater.Size = new System.Drawing.Size(160, 21);
            this.lblRepeater.TabIndex = 60;
            this.lblRepeater.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Скидка:";
            // 
            // totalSum
            // 
            this.totalSum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalSum.Location = new System.Drawing.Point(161, 11);
            this.totalSum.Name = "totalSum";
            this.totalSum.Size = new System.Drawing.Size(193, 26);
            this.totalSum.TabIndex = 58;
            this.totalSum.Text = "0";
            this.totalSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "К оплате:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(360, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 21);
            this.label2.TabIndex = 56;
            this.label2.Text = "сум";
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.Transparent;
            this.customPanel3.BorderColor = System.Drawing.Color.Turquoise;
            this.customPanel3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel3.BorderRadius = 5;
            this.customPanel3.BorderSize = 1;
            this.customPanel3.Controls.Add(this.lblCard);
            this.customPanel3.Controls.Add(this.btnCard);
            this.customPanel3.Location = new System.Drawing.Point(31, 253);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(372, 43);
            this.customPanel3.TabIndex = 55;
            this.customPanel3.UnderlinedStyle = false;
            // 
            // lblCard
            // 
            this.lblCard.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCard.Location = new System.Drawing.Point(146, 7);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(221, 29);
            this.lblCard.TabIndex = 53;
            this.lblCard.Text = "0";
            this.lblCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.Turquoise;
            this.btnCard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCard.Image")));
            this.btnCard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCard.Location = new System.Drawing.Point(3, 2);
            this.btnCard.Name = "btnCard";
            this.btnCard.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnCard.Size = new System.Drawing.Size(137, 39);
            this.btnCard.TabIndex = 42;
            this.btnCard.Text = "терминал";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.Turquoise;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 5;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.lblCash);
            this.customPanel1.Controls.Add(this.btnCash);
            this.customPanel1.Location = new System.Drawing.Point(31, 204);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(372, 43);
            this.customPanel1.TabIndex = 54;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // lblCash
            // 
            this.lblCash.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCash.Location = new System.Drawing.Point(145, 7);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(221, 29);
            this.lblCash.TabIndex = 52;
            this.lblCash.Text = "0";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Turquoise;
            this.btnCash.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCash.Location = new System.Drawing.Point(3, 2);
            this.btnCash.Name = "btnCash";
            this.btnCash.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnCash.Size = new System.Drawing.Size(137, 39);
            this.btnCash.TabIndex = 41;
            this.btnCash.Text = "наличными";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(330, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 38);
            this.button1.TabIndex = 51;
            this.button1.Text = "все сумма";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(34, 163);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(107, 35);
            this.lblWarning.TabIndex = 45;
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblActiveSum
            // 
            this.lblActiveSum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActiveSum.Location = new System.Drawing.Point(176, 82);
            this.lblActiveSum.Name = "lblActiveSum";
            this.lblActiveSum.Size = new System.Drawing.Size(178, 30);
            this.lblActiveSum.TabIndex = 44;
            this.lblActiveSum.Text = "0";
            this.lblActiveSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Расчетная сумма:";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LightGray;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPay.Location = new System.Drawing.Point(31, 595);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(372, 54);
            this.btnPay.TabIndex = 40;
            this.btnPay.Text = "Завершить оплату";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.LightGray;
            this.btnBackspace.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(237, 313);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(100, 37);
            this.btnBackspace.TabIndex = 39;
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.White;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.Location = new System.Drawing.Point(183, 532);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(72, 41);
            this.btnZero.TabIndex = 38;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(99, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 37);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.White;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(266, 372);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 41);
            this.btn9.TabIndex = 36;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(183, 372);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 41);
            this.btn8.TabIndex = 35;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(99, 372);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 41);
            this.btn7.TabIndex = 34;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(266, 425);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 41);
            this.btn6.TabIndex = 33;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(183, 425);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 41);
            this.btn5.TabIndex = 32;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(99, 425);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 41);
            this.btn4.TabIndex = 31;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(266, 478);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 41);
            this.btn3.TabIndex = 30;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(183, 478);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 41);
            this.btn2.TabIndex = 29;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(99, 478);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 41);
            this.btn1.TabIndex = 28;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnComa
            // 
            this.btnComa.BackColor = System.Drawing.Color.White;
            this.btnComa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComa.Location = new System.Drawing.Point(266, 532);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(72, 41);
            this.btnComa.TabIndex = 27;
            this.btnComa.Text = ",";
            this.btnComa.UseVisualStyleBackColor = false;
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // btnDoubleZero
            // 
            this.btnDoubleZero.BackColor = System.Drawing.Color.White;
            this.btnDoubleZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoubleZero.Location = new System.Drawing.Point(99, 532);
            this.btnDoubleZero.Name = "btnDoubleZero";
            this.btnDoubleZero.Size = new System.Drawing.Size(72, 41);
            this.btnDoubleZero.TabIndex = 26;
            this.btnDoubleZero.Text = "00";
            this.btnDoubleZero.UseVisualStyleBackColor = false;
            this.btnDoubleZero.Click += new System.EventHandler(this.btnDoubleZero_Click);
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BorderColor = System.Drawing.Color.Turquoise;
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 5;
            this.customPanel2.BorderSize = 1;
            this.customPanel2.Controls.Add(this.quantityTb);
            this.customPanel2.Location = new System.Drawing.Point(35, 122);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(275, 38);
            this.customPanel2.TabIndex = 25;
            this.customPanel2.UnderlinedStyle = false;
            this.customPanel2.Click += new System.EventHandler(this.customPanel2_Click);
            // 
            // quantityTb
            // 
            this.quantityTb.BackColor = System.Drawing.Color.White;
            this.quantityTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTb.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quantityTb.Location = new System.Drawing.Point(3, 5);
            this.quantityTb.MaxLength = 17;
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.Size = new System.Drawing.Size(269, 29);
            this.quantityTb.TabIndex = 11;
            this.quantityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTb.TextChanged += new System.EventHandler(this.quantityTb_TextChanged);
            this.quantityTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(359, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "сум";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(359, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 63;
            this.label5.Text = "сум";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 661);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnPay;
        private Button btnBackspace;
        private Button btnZero;
        private Button btnClear;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnComa;
        private Button btnDoubleZero;
        private Components.CustomPanel customPanel2;
        private TextBox quantityTb;
        private Label lblActiveSum;
        private Label label1;
        private Button btnCard;
        private Button btnCash;
        private Label lblWarning;
        private Button button1;
        private Label lblCard;
        private Label lblCash;
        private Components.CustomPanel customPanel3;
        private Components.CustomPanel customPanel1;
        private Label label2;
        private Label label3;
        private Label totalSum;
        private Label label6;
        private Label lblRepeater;
        private Label totalDiscount;
        private Label label5;
        private Label label4;
    }
}