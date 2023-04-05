namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    partial class Edit_Cash_Register
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.cashNameTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.updateBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.Location = new System.Drawing.Point(71, 92);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(258, 39);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Редактировать";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cashNameTb
            // 
            this.cashNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashNameTb.Location = new System.Drawing.Point(34, 26);
            this.cashNameTb.MaxLength = 30;
            this.cashNameTb.Name = "cashNameTb";
            this.cashNameTb.Size = new System.Drawing.Size(327, 29);
            this.cashNameTb.TabIndex = 3;
            // 
            // Edit_Cash_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 157);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.cashNameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit_Cash_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update_Cash_Register";
            this.Load += new System.EventHandler(this.Update_Cash_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button updateBtn;
        private TextBox cashNameTb;
    }
}