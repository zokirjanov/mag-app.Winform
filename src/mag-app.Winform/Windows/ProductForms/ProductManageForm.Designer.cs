namespace mag_app.Winform.Windows.ProductForms
{
    partial class ProductManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.producFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productComboBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 40);
            this.panel1.TabIndex = 0;
            // 
            // productComboBox
            // 
            this.productComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.productComboBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(468, 8);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(162, 23);
            this.productComboBox.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(7, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // producFlowPanel
            // 
            this.producFlowPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.producFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.producFlowPanel.Location = new System.Drawing.Point(0, 40);
            this.producFlowPanel.Name = "producFlowPanel";
            this.producFlowPanel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.producFlowPanel.Size = new System.Drawing.Size(636, 490);
            this.producFlowPanel.TabIndex = 1;
            this.producFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.producFlowPanel_Paint);
            // 
            // ProductManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 530);
            this.Controls.Add(this.producFlowPanel);
            this.Controls.Add(this.panel1);
            this.Name = "ProductManageForm";
            this.Text = "ProductManageForm";
            this.Load += new System.EventHandler(this.ProductManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button1;
        private FlowLayoutPanel producFlowPanel;
        private ComboBox productComboBox;
    }
}