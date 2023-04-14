namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    partial class Cash_Register_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cash_Register_Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabProductFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.customPanel1 = new mag_app.Winform.Components.CustomPanel();
            this.quantityTb = new System.Windows.Forms.TextBox();
            this.primaryButton3 = new mag_app.Winform.Components.PrimaryButton();
            this.barcodeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customPanel2 = new mag_app.Winform.Components.CustomPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteButton = new mag_app.Winform.Components.PrimaryButton();
            this.label2 = new System.Windows.Forms.Label();
            this.primaryButton2 = new mag_app.Winform.Components.PrimaryButton();
            this.btnPayment = new mag_app.Winform.Components.PrimaryButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.tabProductFlowPanel);
            this.splitContainer1.Panel1.Controls.Add(this.tabFlowPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1209, 661);
            this.splitContainer1.SplitterDistance = 865;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 590);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(865, 71);
            this.panel4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Скидка";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabProductFlowPanel
            // 
            this.tabProductFlowPanel.AutoScroll = true;
            this.tabProductFlowPanel.BackColor = System.Drawing.Color.White;
            this.tabProductFlowPanel.Location = new System.Drawing.Point(0, 55);
            this.tabProductFlowPanel.Name = "tabProductFlowPanel";
            this.tabProductFlowPanel.Size = new System.Drawing.Size(865, 535);
            this.tabProductFlowPanel.TabIndex = 5;
            // 
            // tabFlowPanel
            // 
            this.tabFlowPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.tabFlowPanel.Name = "tabFlowPanel";
            this.tabFlowPanel.Size = new System.Drawing.Size(865, 55);
            this.tabFlowPanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 551);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 485);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.customPanel1);
            this.panel3.Controls.Add(this.primaryButton3);
            this.panel3.Controls.Add(this.barcodeTb);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.customPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 66);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel1.BorderColor = System.Drawing.Color.Turquoise;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 5;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.quantityTb);
            this.customPanel1.Location = new System.Drawing.Point(184, 35);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(67, 25);
            this.customPanel1.TabIndex = 4;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // quantityTb
            // 
            this.quantityTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.quantityTb.BackColor = System.Drawing.Color.AliceBlue;
            this.quantityTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quantityTb.Location = new System.Drawing.Point(3, 5);
            this.quantityTb.MaxLength = 13;
            this.quantityTb.Name = "quantityTb";
            this.quantityTb.PlaceholderText = "кол-во";
            this.quantityTb.Size = new System.Drawing.Size(61, 16);
            this.quantityTb.TabIndex = 2;
            this.quantityTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // primaryButton3
            // 
            this.primaryButton3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.primaryButton3.BackColor = System.Drawing.Color.AliceBlue;
            this.primaryButton3.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.primaryButton3.BorderColor = System.Drawing.Color.Turquoise;
            this.primaryButton3.BorderRadius = 5;
            this.primaryButton3.BorderSize = 1;
            this.primaryButton3.FlatAppearance.BorderSize = 0;
            this.primaryButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primaryButton3.ForeColor = System.Drawing.Color.Black;
            this.primaryButton3.Location = new System.Drawing.Point(261, 35);
            this.primaryButton3.Name = "primaryButton3";
            this.primaryButton3.Size = new System.Drawing.Size(69, 24);
            this.primaryButton3.TabIndex = 3;
            this.primaryButton3.Text = "добавить";
            this.primaryButton3.TextColor = System.Drawing.Color.Black;
            this.primaryButton3.UseVisualStyleBackColor = false;
            this.primaryButton3.Click += new System.EventHandler(this.primaryButton3_Click);
            // 
            // barcodeTb
            // 
            this.barcodeTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.barcodeTb.BackColor = System.Drawing.Color.AliceBlue;
            this.barcodeTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barcodeTb.Location = new System.Drawing.Point(7, 40);
            this.barcodeTb.MaxLength = 13;
            this.barcodeTb.Name = "barcodeTb";
            this.barcodeTb.PlaceholderText = "штрих-код";
            this.barcodeTb.Size = new System.Drawing.Size(171, 16);
            this.barcodeTb.TabIndex = 1;
            this.barcodeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.barcodeTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.barcodeTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Корзинка";
            // 
            // customPanel2
            // 
            this.customPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.customPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.customPanel2.BorderColor = System.Drawing.Color.Turquoise;
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 5;
            this.customPanel2.BorderSize = 1;
            this.customPanel2.Controls.Add(this.textBox3);
            this.customPanel2.Location = new System.Drawing.Point(3, 35);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(178, 25);
            this.customPanel2.TabIndex = 5;
            this.customPanel2.UnderlinedStyle = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(-19, -33);
            this.textBox3.MaxLength = 13;
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "кол-во";
            this.textBox3.Size = new System.Drawing.Size(61, 16);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.primaryButton2);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 551);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 110);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.deleteButton.BackColor = System.Drawing.Color.MistyRose;
            this.deleteButton.BackgroundColor = System.Drawing.Color.MistyRose;
            this.deleteButton.BorderColor = System.Drawing.Color.Tomato;
            this.deleteButton.BorderRadius = 10;
            this.deleteButton.BorderSize = 1;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.Location = new System.Drawing.Point(119, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.deleteButton.Size = new System.Drawing.Size(100, 30);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "удалить ";
            this.deleteButton.TextColor = System.Drawing.Color.Black;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.primaryButton4_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(18, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 2);
            this.label2.TabIndex = 2;
            // 
            // primaryButton2
            // 
            this.primaryButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.primaryButton2.BackColor = System.Drawing.Color.MistyRose;
            this.primaryButton2.BackgroundColor = System.Drawing.Color.MistyRose;
            this.primaryButton2.BorderColor = System.Drawing.Color.Tomato;
            this.primaryButton2.BorderRadius = 10;
            this.primaryButton2.BorderSize = 1;
            this.primaryButton2.FlatAppearance.BorderSize = 0;
            this.primaryButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primaryButton2.ForeColor = System.Drawing.Color.Black;
            this.primaryButton2.Image = ((System.Drawing.Image)(resources.GetObject("primaryButton2.Image")));
            this.primaryButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.primaryButton2.Location = new System.Drawing.Point(229, 4);
            this.primaryButton2.Name = "primaryButton2";
            this.primaryButton2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.primaryButton2.Size = new System.Drawing.Size(100, 30);
            this.primaryButton2.TabIndex = 1;
            this.primaryButton2.Text = "очистить ";
            this.primaryButton2.TextColor = System.Drawing.Color.Black;
            this.primaryButton2.UseVisualStyleBackColor = false;
            this.primaryButton2.Click += new System.EventHandler(this.primaryButton2_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.BackColor = System.Drawing.Color.Turquoise;
            this.btnPayment.BackgroundColor = System.Drawing.Color.Turquoise;
            this.btnPayment.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnPayment.BorderRadius = 20;
            this.btnPayment.BorderSize = 1;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.ForeColor = System.Drawing.Color.Black;
            this.btnPayment.Location = new System.Drawing.Point(18, 49);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(300, 54);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Оплатить";
            this.btnPayment.TextColor = System.Drawing.Color.Black;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // Cash_Register_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 661);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cash_Register_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cash_Register_Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cash_Register_Main_FormClosed);
            this.Load += new System.EventHandler(this.Cash_Register_Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private FlowLayoutPanel tabFlowPanel;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Components.PrimaryButton btnPayment;
        private Label label2;
        private Components.PrimaryButton primaryButton2;
        private TextBox quantityTb;
        private TextBox barcodeTb;
        private Components.PrimaryButton primaryButton3;
        private Components.CustomPanel customPanel1;
        private Components.CustomPanel customPanel2;
        private TextBox textBox3;
        private Components.PrimaryButton deleteButton;
        public FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private Button button1;
        public FlowLayoutPanel tabProductFlowPanel;
    }
}