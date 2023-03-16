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
            this.backButton = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.productChildPanel = new System.Windows.Forms.Panel();
            this.store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.subtitleFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.MenuPanel.Controls.Add(this.backButton);
            this.MenuPanel.Controls.Add(this.productBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(219, 638);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(11, 593);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(194, 38);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.productBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productBtn.Image = ((System.Drawing.Image)(resources.GetObject("productBtn.Image")));
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(13, 16);
            this.productBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.productBtn.Size = new System.Drawing.Size(194, 60);
            this.productBtn.TabIndex = 0;
            this.productBtn.Text = "категория";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // productChildPanel
            // 
            this.productChildPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productChildPanel.Location = new System.Drawing.Point(219, 42);
            this.productChildPanel.Name = "productChildPanel";
            this.productChildPanel.Size = new System.Drawing.Size(861, 596);
            this.productChildPanel.TabIndex = 2;
            // 
            // store
            // 
            this.store.HeaderText = "store";
            this.store.Name = "store";
            this.store.ReadOnly = true;
            this.store.Visible = false;
            // 
            // category
            // 
            this.category.HeaderText = "category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Visible = false;
            // 
            // titleFlowPanel
            // 
            this.titleFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleFlowPanel.Location = new System.Drawing.Point(219, 18);
            this.titleFlowPanel.Name = "titleFlowPanel";
            this.titleFlowPanel.Size = new System.Drawing.Size(861, 24);
            this.titleFlowPanel.TabIndex = 3;
            this.titleFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titleFlowPanel_Paint);
            // 
            // subtitleFlowPanel
            // 
            this.subtitleFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtitleFlowPanel.Location = new System.Drawing.Point(219, 0);
            this.subtitleFlowPanel.Name = "subtitleFlowPanel";
            this.subtitleFlowPanel.Size = new System.Drawing.Size(861, 18);
            this.subtitleFlowPanel.TabIndex = 4;
            // 
            // StoreProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 638);
            this.Controls.Add(this.titleFlowPanel);
            this.Controls.Add(this.subtitleFlowPanel);
            this.Controls.Add(this.productChildPanel);
            this.Controls.Add(this.MenuPanel);
            this.MaximumSize = new System.Drawing.Size(1096, 677);
            this.MinimumSize = new System.Drawing.Size(1096, 677);
            this.Name = "StoreProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreProductsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StoreProductsForm_FormClosed);
            this.Load += new System.EventHandler(this.StoreProductsForm_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MenuPanel;
        private Button productBtn;
        private Panel productChildPanel;
        private Button backButton;
        private DataGridViewTextBoxColumn store;
        private DataGridViewTextBoxColumn category;
        private FlowLayoutPanel titleFlowPanel;
        private FlowLayoutPanel subtitleFlowPanel;
    }
}