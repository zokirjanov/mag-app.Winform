namespace mag_app.Winform.Components
{
	partial class StorePanel
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.addButtonPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.storeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButtonPanel
            // 
            this.addButtonPanel.Controls.Add(this.button2);
            this.addButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.addButtonPanel.Name = "addButtonPanel";
            this.addButtonPanel.Size = new System.Drawing.Size(424, 56);
            this.addButtonPanel.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(424, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add new store";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // storeFlowPanel
            // 
            this.storeFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.storeFlowPanel.Name = "storeFlowPanel";
            this.storeFlowPanel.Size = new System.Drawing.Size(200, 100);
            this.storeFlowPanel.TabIndex = 0;
            // 
            // StorePanel
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "StorePanel";
            this.Size = new System.Drawing.Size(433, 635);
            this.Load += new System.EventHandler(this.StorePanel_Load_1);
            this.addButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private Panel addButtonPanel;
        private Button button2;
        private FlowLayoutPanel storeFlowPanel;
    }
}
