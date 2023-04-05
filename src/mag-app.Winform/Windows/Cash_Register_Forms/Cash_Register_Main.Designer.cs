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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.SplitterDistance = 848;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabProductFlowPanel
            // 
            this.tabProductFlowPanel.AutoScroll = true;
            this.tabProductFlowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabProductFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProductFlowPanel.Location = new System.Drawing.Point(0, 55);
            this.tabProductFlowPanel.Name = "tabProductFlowPanel";
            this.tabProductFlowPanel.Size = new System.Drawing.Size(848, 506);
            this.tabProductFlowPanel.TabIndex = 5;
            this.tabProductFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // tabFlowPanel
            // 
            this.tabFlowPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.tabFlowPanel.Name = "tabFlowPanel";
            this.tabFlowPanel.Size = new System.Drawing.Size(848, 55);
            this.tabFlowPanel.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 561);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(848, 100);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 561);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 561);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 100);
            this.panel1.TabIndex = 0;
            // 
            // Cash_Register_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 661);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cash_Register_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash_Register_Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cash_Register_Main_FormClosed);
            this.Load += new System.EventHandler(this.Cash_Register_Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private FlowLayoutPanel tabFlowPanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private FlowLayoutPanel tabProductFlowPanel;
    }
}