namespace mag_app.Winform.Windows
{
	partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button1 = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginPassShow = new System.Windows.Forms.Button();
            this.loginPass = new System.Windows.Forms.TextBox();
            this.loginlogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rememberMe = new System.Windows.Forms.CheckBox();
            this.loginLoginerror = new System.Windows.Forms.Label();
            this.customPanel2 = new mag_app.Winform.Components.CustomPanel();
            this.customPanel3 = new mag_app.Winform.Components.CustomPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(51, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerBtn.Location = new System.Drawing.Point(49, 347);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(321, 44);
            this.registerBtn.TabIndex = 15;
            this.registerBtn.Text = "Login";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginPassShow
            // 
            this.loginPassShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPassShow.BackColor = System.Drawing.Color.Beige;
            this.loginPassShow.Image = ((System.Drawing.Image)(resources.GetObject("loginPassShow.Image")));
            this.loginPassShow.Location = new System.Drawing.Point(341, 240);
            this.loginPassShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPassShow.Name = "loginPassShow";
            this.loginPassShow.Size = new System.Drawing.Size(26, 22);
            this.loginPassShow.TabIndex = 14;
            this.loginPassShow.UseVisualStyleBackColor = false;
            this.loginPassShow.Click += new System.EventHandler(this.loginPassShow_Click);
            // 
            // loginPass
            // 
            this.loginPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPass.BackColor = System.Drawing.Color.Beige;
            this.loginPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPass.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginPass.Location = new System.Drawing.Point(11, 5);
            this.loginPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPass.Name = "loginPass";
            this.loginPass.PlaceholderText = "Password";
            this.loginPass.Size = new System.Drawing.Size(320, 23);
            this.loginPass.TabIndex = 13;
            this.loginPass.UseSystemPasswordChar = true;
            // 
            // loginlogin
            // 
            this.loginlogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginlogin.BackColor = System.Drawing.Color.Beige;
            this.loginlogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginlogin.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginlogin.Location = new System.Drawing.Point(11, 5);
            this.loginlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginlogin.Name = "loginlogin";
            this.loginlogin.PlaceholderText = "Login";
            this.loginlogin.Size = new System.Drawing.Size(320, 23);
            this.loginlogin.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 47);
            this.label1.TabIndex = 11;
            this.label1.Text = "Авторизация ";
            // 
            // rememberMe
            // 
            this.rememberMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rememberMe.AutoSize = true;
            this.rememberMe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rememberMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rememberMe.Location = new System.Drawing.Point(42, 285);
            this.rememberMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rememberMe.Name = "rememberMe";
            this.rememberMe.Size = new System.Drawing.Size(101, 19);
            this.rememberMe.TabIndex = 17;
            this.rememberMe.Text = "Remember me";
            this.rememberMe.UseCompatibleTextRendering = true;
            this.rememberMe.UseVisualStyleBackColor = true;
            // 
            // loginLoginerror
            // 
            this.loginLoginerror.AutoSize = true;
            this.loginLoginerror.ForeColor = System.Drawing.Color.Red;
            this.loginLoginerror.Location = new System.Drawing.Point(46, 212);
            this.loginLoginerror.Name = "loginLoginerror";
            this.loginLoginerror.Size = new System.Drawing.Size(0, 15);
            this.loginLoginerror.TabIndex = 19;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.Beige;
            this.customPanel2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel2.BorderRadius = 15;
            this.customPanel2.BorderSize = 2;
            this.customPanel2.Controls.Add(this.loginlogin);
            this.customPanel2.Location = new System.Drawing.Point(34, 175);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(342, 32);
            this.customPanel2.TabIndex = 21;
            this.customPanel2.UnderlinedStyle = false;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.Beige;
            this.customPanel3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customPanel3.BorderRadius = 15;
            this.customPanel3.BorderSize = 2;
            this.customPanel3.Controls.Add(this.textBox2);
            this.customPanel3.Controls.Add(this.loginPass);
            this.customPanel3.Location = new System.Drawing.Point(34, 234);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(342, 32);
            this.customPanel3.TabIndex = 22;
            this.customPanel3.UnderlinedStyle = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.Beige;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(81, -29);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Login";
            this.textBox2.Size = new System.Drawing.Size(328, 23);
            this.textBox2.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(416, 548);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.loginLoginerror);
            this.Controls.Add(this.rememberMe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginPassShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(432, 587);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Button button1;
		private Button registerBtn;
		private Button loginPassShow;
		private TextBox loginPass;
		private TextBox loginlogin;
		private Label label1;
		private CheckBox rememberMe;
		private Label loginLoginerror;
        private Components.CustomPanel customPanel2;
        private Components.CustomPanel customPanel3;
        private TextBox textBox2;
    }
}