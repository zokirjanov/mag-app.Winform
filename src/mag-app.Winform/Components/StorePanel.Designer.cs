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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.buttonPanel = new System.Windows.Forms.Panel();
			this.storesPanel = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.Location = new System.Drawing.Point(13, 15);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(205, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "Add Store";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button2.Location = new System.Drawing.Point(245, 15);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(205, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "Update Store";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.button3.Location = new System.Drawing.Point(485, 15);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(205, 50);
			this.button3.TabIndex = 2;
			this.button3.Text = "Delete Store";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// buttonPanel
			// 
			this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonPanel.Location = new System.Drawing.Point(0, 0);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new System.Drawing.Size(708, 82);
			this.buttonPanel.TabIndex = 3;
			// 
			// storesPanel
			// 
			this.storesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.storesPanel.Location = new System.Drawing.Point(0, 82);
			this.storesPanel.Name = "storesPanel";
			this.storesPanel.Size = new System.Drawing.Size(708, 639);
			this.storesPanel.TabIndex = 0;
			// 
			// StorePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.storesPanel);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonPanel);
			this.Name = "StorePanel";
			this.Size = new System.Drawing.Size(708, 721);
			this.Load += new System.EventHandler(this.StorePanel_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private Panel buttonPanel;
		private Panel storesPanel;
	}
}
