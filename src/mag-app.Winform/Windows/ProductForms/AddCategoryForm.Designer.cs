namespace mag_app.Winform.Windows.ProductForms
{
    partial class AddCategoryForm
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
            this.categoryNameTb = new System.Windows.Forms.TextBox();
            this.categoryAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryNameTb
            // 
            this.categoryNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.categoryNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryNameTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryNameTb.Location = new System.Drawing.Point(51, 43);
            this.categoryNameTb.MaxLength = 50;
            this.categoryNameTb.Name = "categoryNameTb";
            this.categoryNameTb.PlaceholderText = "Название категории";
            this.categoryNameTb.Size = new System.Drawing.Size(314, 30);
            this.categoryNameTb.TabIndex = 7;
            // 
            // categoryAddBtn
            // 
            this.categoryAddBtn.BackColor = System.Drawing.Color.LightCyan;
            this.categoryAddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryAddBtn.Location = new System.Drawing.Point(51, 97);
            this.categoryAddBtn.Name = "categoryAddBtn";
            this.categoryAddBtn.Size = new System.Drawing.Size(314, 39);
            this.categoryAddBtn.TabIndex = 9;
            this.categoryAddBtn.Text = "добавлять";
            this.categoryAddBtn.UseVisualStyleBackColor = false;
            this.categoryAddBtn.Click += new System.EventHandler(this.categoryAddBtn_Click);
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 177);
            this.Controls.Add(this.categoryAddBtn);
            this.Controls.Add(this.categoryNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox categoryNameTb;
        private Button categoryAddBtn;
    }
}