namespace mag_app.Winform.Windows.ProductForms
{
    partial class AddSbCategoryForm
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
            this.subCategoryNameTb = new System.Windows.Forms.TextBox();
            this.categoryAddBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subCategoryNameTb
            // 
            this.subCategoryNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subCategoryNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subCategoryNameTb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subCategoryNameTb.Location = new System.Drawing.Point(51, 37);
            this.subCategoryNameTb.MaxLength = 20;
            this.subCategoryNameTb.Name = "subCategoryNameTb";
            this.subCategoryNameTb.PlaceholderText = "Название подкатегории";
            this.subCategoryNameTb.Size = new System.Drawing.Size(314, 30);
            this.subCategoryNameTb.TabIndex = 8;
            // 
            // categoryAddBtn
            // 
            this.categoryAddBtn.BackColor = System.Drawing.Color.LightCyan;
            this.categoryAddBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryAddBtn.Location = new System.Drawing.Point(51, 90);
            this.categoryAddBtn.Name = "categoryAddBtn";
            this.categoryAddBtn.Size = new System.Drawing.Size(314, 39);
            this.categoryAddBtn.TabIndex = 10;
            this.categoryAddBtn.Text = "добавлять";
            this.categoryAddBtn.UseVisualStyleBackColor = false;
            this.categoryAddBtn.Click += new System.EventHandler(this.categoryAddBtn_Click);
            // 
            // AddSbCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 177);
            this.Controls.Add(this.categoryAddBtn);
            this.Controls.Add(this.subCategoryNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddSbCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSbCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox subCategoryNameTb;
        private Button categoryAddBtn;
    }
}