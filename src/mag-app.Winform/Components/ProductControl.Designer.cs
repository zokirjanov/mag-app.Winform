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
            this.customPanel1 = new mag_app.Winform.Components.CustomPanel();
            this.ucPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ucQuantity = new System.Windows.Forms.Label();
            this.customPanel3 = new mag_app.Winform.Components.CustomPanel();
            this.customPanel2 = new mag_app.Winform.Components.CustomPanel();
            this.ucTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucTitle = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.LightCyan;
            this.customPanel1.BorderColor = System.Drawing.Color.ForestGreen;
            this.customPanel1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.ucPrice);
            this.customPanel1.Controls.Add(this.label5);
            this.customPanel1.Controls.Add(this.ucQuantity);
            this.customPanel1.Controls.Add(this.customPanel3);
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.ucTitle);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(315, 63);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.UnderlinedStyle = false;
            // 
            // ucPrice
            // 
            this.ucPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucPrice.Location = new System.Drawing.Point(61, 38);
            this.ucPrice.Name = "ucPrice";
            this.ucPrice.Size = new System.Drawing.Size(76, 18);
            this.ucPrice.TabIndex = 6;
            this.ucPrice.Text = "Price";
            this.ucPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "цена:";
            // 
            // ucQuantity
            // 
            this.ucQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucQuantity.Location = new System.Drawing.Point(225, 9);
            this.ucQuantity.Name = "ucQuantity";
            this.ucQuantity.Size = new System.Drawing.Size(76, 18);
            this.ucQuantity.TabIndex = 4;
            this.ucQuantity.Text = "quantity";
            this.ucQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.LightYellow;
            this.customPanel3.BorderColor = System.Drawing.Color.Gold;
            this.customPanel3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel3.BorderRadius = 10;
            this.customPanel3.BorderSize = 1;
            this.customPanel3.Controls.Add(this.customPanel2);
            this.customPanel3.Location = new System.Drawing.Point(172, 34);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(158, 37);
            this.customPanel3.TabIndex = 3;
            this.customPanel3.UnderlinedStyle = false;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.Transparent;
            this.customPanel2.BorderColor = System.Drawing.Color.Gold;
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 10;
            this.customPanel2.BorderSize = 1;
            this.customPanel2.Controls.Add(this.ucTotalPrice);
            this.customPanel2.Controls.Add(this.label3);
            this.customPanel2.Location = new System.Drawing.Point(-15, -8);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(158, 37);
            this.customPanel2.TabIndex = 4;
            this.customPanel2.UnderlinedStyle = false;
            // 
            // ucTotalPrice
            // 
            this.ucTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucTotalPrice.Location = new System.Drawing.Point(68, 13);
            this.ucTotalPrice.Name = "ucTotalPrice";
            this.ucTotalPrice.Size = new System.Drawing.Size(76, 18);
            this.ucTotalPrice.TabIndex = 5;
            this.ucTotalPrice.Text = "Total Price";
            this.ucTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "и-го:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "к-во:";
            // 
            // ucTitle
            // 
            this.ucTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ucTitle.Location = new System.Drawing.Point(13, 9);
            this.ucTitle.Name = "ucTitle";
            this.ucTitle.Size = new System.Drawing.Size(160, 17);
            this.ucTitle.TabIndex = 0;
            this.ucTitle.Text = "product name";
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
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomPanel customPanel1;
        private Label label1;
        private Label ucTitle;
        private CustomPanel customPanel3;
        private CustomPanel customPanel2;
        private Label ucQuantity;
        private Label ucPrice;
        private Label label5;
        private Label ucTotalPrice;
        private Label label3;
    }
}
