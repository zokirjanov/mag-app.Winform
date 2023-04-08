namespace mag_app.Winform.Components
{
    partial class ProductControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductControl));
            this.customPanel1 = new mag_app.Winform.Components.CustomPanel();
            this.ucTotalPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ucPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ucQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.customPanel1.BorderColor = System.Drawing.Color.ForestGreen;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.ucTotalPrice);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.Controls.Add(this.label2);
            this.customPanel1.Controls.Add(this.button1);
            this.customPanel1.Controls.Add(this.ucPrice);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.ucQuantity);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.ucTitle);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(315, 63);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.UnderlinedStyle = false;
            this.customPanel1.Click += new System.EventHandler(this.customPanel1_Click);
            // 
            // ucTotalPrice
            // 
            this.ucTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucTotalPrice.Location = new System.Drawing.Point(196, 41);
            this.ucTotalPrice.Name = "ucTotalPrice";
            this.ucTotalPrice.Size = new System.Drawing.Size(91, 18);
            this.ucTotalPrice.TabIndex = 5;
            this.ucTotalPrice.Text = "Total Price";
            this.ucTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(165, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 2);
            this.label2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(284, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucPrice
            // 
            this.ucPrice.BackColor = System.Drawing.Color.Transparent;
            this.ucPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucPrice.Location = new System.Drawing.Point(5, 41);
            this.ucPrice.Name = "ucPrice";
            this.ucPrice.Size = new System.Drawing.Size(74, 18);
            this.ucPrice.TabIndex = 6;
            this.ucPrice.Text = "Price";
            this.ucPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "цена:";
            // 
            // ucQuantity
            // 
            this.ucQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucQuantity.Location = new System.Drawing.Point(105, 41);
            this.ucQuantity.Name = "ucQuantity";
            this.ucQuantity.Size = new System.Drawing.Size(63, 18);
            this.ucQuantity.TabIndex = 4;
            this.ucQuantity.Text = "quantity";
            this.ucQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(106, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "кол-во:";
            // 
            // ucTitle
            // 
            this.ucTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucTitle.Location = new System.Drawing.Point(11, 5);
            this.ucTitle.Name = "ucTitle";
            this.ucTitle.Size = new System.Drawing.Size(160, 17);
            this.ucTitle.TabIndex = 0;
            this.ucTitle.Text = "product name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(209, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "итого:";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.customPanel1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(315, 63);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Label ucTitle;
        private Label ucQuantity;
        private Label ucPrice;
        private Label label5;
        private Label ucTotalPrice;
        private Button button1;
        private Label label6;
        private Label label4;
        private Label label2;
        public CustomPanel customPanel1;
        private Label label3;
    }
}
