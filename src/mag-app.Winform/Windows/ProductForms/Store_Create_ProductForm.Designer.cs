namespace mag_app.Winform.Windows.ProductForms
{
    partial class Store_Create_ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.create_ProductFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(327, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "список продукты:";
            // 
            // create_ProductFlowPanel
            // 
            this.create_ProductFlowPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.create_ProductFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.create_ProductFlowPanel.Location = new System.Drawing.Point(0, 32);
            this.create_ProductFlowPanel.Name = "create_ProductFlowPanel";
            this.create_ProductFlowPanel.Size = new System.Drawing.Size(845, 567);
            this.create_ProductFlowPanel.TabIndex = 1;
            // 
            // Store_Create_ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 599);
            this.Controls.Add(this.create_ProductFlowPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Store_Create_ProductForm";
            this.Text = "Store_Create_ProductForm";
            this.Load += new System.EventHandler(this.Store_Create_ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel create_ProductFlowPanel;
        private Label label1;
    }
}