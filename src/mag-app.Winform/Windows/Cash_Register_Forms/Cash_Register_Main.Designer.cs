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
            this.tabProductFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.primaryButton2 = new mag_app.Winform.Components.PrimaryButton();
            this.primaryButton1 = new mag_app.Winform.Components.PrimaryButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.tabProductFlowPanel);
            this.splitContainer1.Panel1.Controls.Add(this.tabFlowPanel);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1209, 661);
            this.splitContainer1.SplitterDistance = 865;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabProductFlowPanel
            // 
            this.tabProductFlowPanel.AutoScroll = true;
            this.tabProductFlowPanel.BackColor = System.Drawing.Color.White;
            this.tabProductFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProductFlowPanel.Location = new System.Drawing.Point(0, 55);
            this.tabProductFlowPanel.Name = "tabProductFlowPanel";
            this.tabProductFlowPanel.Size = new System.Drawing.Size(865, 531);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 586);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(865, 75);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 540);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 485);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 55);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(119, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Корзинка";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.primaryButton2);
            this.panel1.Controls.Add(this.primaryButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 540);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 121);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 2);
            this.label2.TabIndex = 2;
            // 
            // primaryButton2
            // 
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
            this.primaryButton2.Location = new System.Drawing.Point(178, 6);
            this.primaryButton2.Name = "primaryButton2";
            this.primaryButton2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.primaryButton2.Size = new System.Drawing.Size(150, 30);
            this.primaryButton2.TabIndex = 1;
            this.primaryButton2.Text = "очистить корзину";
            this.primaryButton2.TextColor = System.Drawing.Color.Black;
            this.primaryButton2.UseVisualStyleBackColor = false;
            // 
            // primaryButton1
            // 
            this.primaryButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.primaryButton1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.primaryButton1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.primaryButton1.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.primaryButton1.BorderRadius = 20;
            this.primaryButton1.BorderSize = 1;
            this.primaryButton1.FlatAppearance.BorderSize = 0;
            this.primaryButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primaryButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primaryButton1.ForeColor = System.Drawing.Color.Black;
            this.primaryButton1.Location = new System.Drawing.Point(53, 54);
            this.primaryButton1.Name = "primaryButton1";
            this.primaryButton1.Size = new System.Drawing.Size(238, 54);
            this.primaryButton1.TabIndex = 0;
            this.primaryButton1.Text = "Оплатить";
            this.primaryButton1.TextColor = System.Drawing.Color.Black;
            this.primaryButton1.UseVisualStyleBackColor = false;
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
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private FlowLayoutPanel tabFlowPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private FlowLayoutPanel tabProductFlowPanel;
        private Label label1;
        private Panel panel3;
        private Components.PrimaryButton primaryButton1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Components.PrimaryButton primaryButton2;
    }
}