namespace mag_app.Winform.Windows.Product_Forms
{
    partial class Store_Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store_Product_Form));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.quick_PassBtn = new System.Windows.Forms.Button();
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
            this.MenuPanel.Controls.Add(this.button1);
            this.MenuPanel.Controls.Add(this.quick_PassBtn);
            this.MenuPanel.Controls.Add(this.backButton);
            this.MenuPanel.Controls.Add(this.productBtn);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(219, 661);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(194, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Кассы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quick_PassBtn
            // 
            this.quick_PassBtn.BackColor = System.Drawing.Color.Turquoise;
            this.quick_PassBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quick_PassBtn.Image = ((System.Drawing.Image)(resources.GetObject("quick_PassBtn.Image")));
            this.quick_PassBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.quick_PassBtn.Location = new System.Drawing.Point(13, 80);
            this.quick_PassBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quick_PassBtn.Name = "quick_PassBtn";
            this.quick_PassBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.quick_PassBtn.Size = new System.Drawing.Size(194, 60);
            this.quick_PassBtn.TabIndex = 3;
            this.quick_PassBtn.Text = "Продукты";
            this.quick_PassBtn.UseVisualStyleBackColor = false;
            this.quick_PassBtn.Click += new System.EventHandler(this.quick_PassBtn_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backButton.Location = new System.Drawing.Point(12, 611);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(194, 38);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // productBtn
            // 
            this.productBtn.BackColor = System.Drawing.Color.Turquoise;
            this.productBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productBtn.Image = ((System.Drawing.Image)(resources.GetObject("productBtn.Image")));
            this.productBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productBtn.Location = new System.Drawing.Point(13, 16);
            this.productBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productBtn.Name = "productBtn";
            this.productBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.productBtn.Size = new System.Drawing.Size(194, 60);
            this.productBtn.TabIndex = 0;
            this.productBtn.Text = "Добавитъ товар";
            this.productBtn.UseVisualStyleBackColor = false;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // productChildPanel
            // 
            this.productChildPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productChildPanel.Location = new System.Drawing.Point(219, 46);
            this.productChildPanel.Name = "productChildPanel";
            this.productChildPanel.Size = new System.Drawing.Size(990, 615);
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
            this.titleFlowPanel.Size = new System.Drawing.Size(990, 28);
            this.titleFlowPanel.TabIndex = 3;
            this.titleFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titleFlowPanel_Paint);
            // 
            // subtitleFlowPanel
            // 
            this.subtitleFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subtitleFlowPanel.Location = new System.Drawing.Point(219, 0);
            this.subtitleFlowPanel.Name = "subtitleFlowPanel";
            this.subtitleFlowPanel.Size = new System.Drawing.Size(990, 18);
            this.subtitleFlowPanel.TabIndex = 4;
            // 
            // Store_Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 661);
            this.Controls.Add(this.titleFlowPanel);
            this.Controls.Add(this.subtitleFlowPanel);
            this.Controls.Add(this.productChildPanel);
            this.Controls.Add(this.MenuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1225, 700);
            this.MinimumSize = new System.Drawing.Size(1225, 700);
            this.Name = "Store_Product_Form";
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
        private Button quick_PassBtn;
        private Button button1;
    }
}