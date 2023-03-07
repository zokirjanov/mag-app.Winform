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
            this.productNameLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productEditBtn = new System.Windows.Forms.Button();
            this.productDeleteBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // productNameLb
            // 
            this.productNameLb.AutoSize = true;
            this.productNameLb.BackColor = System.Drawing.Color.AliceBlue;
            this.productNameLb.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.productNameLb.Location = new System.Drawing.Point(22, 19);
            this.productNameLb.Name = "productNameLb";
            this.productNameLb.Size = new System.Drawing.Size(112, 24);
            this.productNameLb.TabIndex = 2;
            this.productNameLb.Text = "Store name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productEditBtn);
            this.panel1.Controls.Add(this.productDeleteBtn);
            this.panel1.Location = new System.Drawing.Point(521, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 44);
            this.panel1.TabIndex = 3;
            // 
            // productEditBtn
            // 
            this.productEditBtn.Image = ((System.Drawing.Image)(resources.GetObject("productEditBtn.Image")));
            this.productEditBtn.Location = new System.Drawing.Point(12, 6);
            this.productEditBtn.Name = "productEditBtn";
            this.productEditBtn.Size = new System.Drawing.Size(34, 33);
            this.productEditBtn.TabIndex = 2;
            this.productEditBtn.UseVisualStyleBackColor = true;
            // 
            // productDeleteBtn
            // 
            this.productDeleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("productDeleteBtn.Image")));
            this.productDeleteBtn.Location = new System.Drawing.Point(52, 6);
            this.productDeleteBtn.Name = "productDeleteBtn";
            this.productDeleteBtn.Size = new System.Drawing.Size(34, 33);
            this.productDeleteBtn.TabIndex = 1;
            this.productDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productNameLb);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(628, 61);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label productNameLb;
        private Panel panel1;
        private Button productEditBtn;
        private Button productDeleteBtn;
    }
}
