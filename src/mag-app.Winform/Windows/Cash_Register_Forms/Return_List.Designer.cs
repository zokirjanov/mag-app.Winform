namespace mag_app.Winform.Windows.Cash_Register_Forms
{
    partial class Return_List
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saleDetailsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleGlobalViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleGlobalViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 79);
            this.panel1.TabIndex = 0;
            // 
            // saleDetailsViewModelBindingSource
            // 
            this.saleDetailsViewModelBindingSource.DataSource = typeof(mag_app.Service.ViewModels.Stores.SaleDetailsViewModel);
            // 
            // saleGlobalViewModelBindingSource
            // 
            this.saleGlobalViewModelBindingSource.DataSource = typeof(mag_app.Service.ViewModels.Stores.SaleGlobalViewModel);
            // 
            // Return_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 488);
            this.Controls.Add(this.panel1);
            this.Name = "Return_List";
            this.Text = "Возврат";
            ((System.ComponentModel.ISupportInitialize)(this.saleDetailsViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleGlobalViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private BindingSource saleGlobalViewModelBindingSource;
        private BindingSource saleDetailsViewModelBindingSource;
    }
}