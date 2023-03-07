namespace mag_app.Winform.Windows.Product_Forms
{
    partial class StoreProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreProductsForm));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.productBtn = new System.Windows.Forms.Button();
            this.childPanel = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuPanel.Controls.Add(this.productBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(219, 569);
            this.MenuPanel.TabIndex = 1;
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productBtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productBtn.Image = ((System.Drawing.Image)(resources.GetObject("productBtn.Image")));
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(13, 10);
            this.productBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.productBtn.Size = new System.Drawing.Size(194, 60);
            this.productBtn.TabIndex = 0;
            this.productBtn.Text = "Products";
            this.productBtn.UseVisualStyleBackColor = false;
            // 
            // childPanel
            // 
            this.childPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childPanel.Location = new System.Drawing.Point(219, 0);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(652, 569);
            this.childPanel.TabIndex = 2;
            // 
            // StoreProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 569);
            this.Controls.Add(this.childPanel);
            this.Controls.Add(this.MenuPanel);
            this.Name = "StoreProductsForm";
            this.Text = "StoreProductsForm";
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Button productBtn;
        private Panel childPanel;
    }
}