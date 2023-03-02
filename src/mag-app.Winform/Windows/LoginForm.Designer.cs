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
			this.loginPasserror = new System.Windows.Forms.Label();
			this.loginLoginerror = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(85, 573);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(319, 46);
			this.button1.TabIndex = 16;
			this.button1.Text = "Register";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// registerBtn
			// 
			this.registerBtn.BackColor = System.Drawing.Color.SpringGreen;
			this.registerBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.registerBtn.Location = new System.Drawing.Point(52, 496);
			this.registerBtn.Name = "registerBtn";
			this.registerBtn.Size = new System.Drawing.Size(376, 59);
			this.registerBtn.TabIndex = 15;
			this.registerBtn.Text = "Login";
			this.registerBtn.UseVisualStyleBackColor = false;
			this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
			// 
			// loginPassShow
			// 
			this.loginPassShow.BackColor = System.Drawing.Color.Transparent;
			this.loginPassShow.Image = ((System.Drawing.Image)(resources.GetObject("loginPassShow.Image")));
			this.loginPassShow.Location = new System.Drawing.Point(398, 353);
			this.loginPassShow.Name = "loginPassShow";
			this.loginPassShow.Size = new System.Drawing.Size(30, 29);
			this.loginPassShow.TabIndex = 14;
			this.loginPassShow.UseVisualStyleBackColor = false;
			this.loginPassShow.Click += new System.EventHandler(this.loginPassShow_Click);
			// 
			// loginPass
			// 
			this.loginPass.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginPass.Location = new System.Drawing.Point(52, 350);
			this.loginPass.Name = "loginPass";
			this.loginPass.PlaceholderText = "Password";
			this.loginPass.Size = new System.Drawing.Size(380, 36);
			this.loginPass.TabIndex = 13;
			this.loginPass.UseSystemPasswordChar = true;
			this.loginPass.TextChanged += new System.EventHandler(this.loginPass_TextChanged);
			// 
			// loginlogin
			// 
			this.loginlogin.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginlogin.Location = new System.Drawing.Point(52, 261);
			this.loginlogin.Name = "loginlogin";
			this.loginlogin.PlaceholderText = "Login";
			this.loginlogin.Size = new System.Drawing.Size(380, 36);
			this.loginlogin.TabIndex = 12;
			this.loginlogin.TextChanged += new System.EventHandler(this.loginlogin_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Sitka Text Semibold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(168, 148);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 58);
			this.label1.TabIndex = 11;
			this.label1.Text = "Login";
			// 
			// rememberMe
			// 
			this.rememberMe.AutoSize = true;
			this.rememberMe.Location = new System.Drawing.Point(52, 423);
			this.rememberMe.Name = "rememberMe";
			this.rememberMe.Size = new System.Drawing.Size(124, 24);
			this.rememberMe.TabIndex = 17;
			this.rememberMe.Text = "Remenber me";
			this.rememberMe.UseVisualStyleBackColor = true;
			// 
			// loginPasserror
			// 
			this.loginPasserror.AutoSize = true;
			this.loginPasserror.ForeColor = System.Drawing.Color.Red;
			this.loginPasserror.Location = new System.Drawing.Point(58, 390);
			this.loginPasserror.Name = "loginPasserror";
			this.loginPasserror.Size = new System.Drawing.Size(0, 20);
			this.loginPasserror.TabIndex = 18;
			// 
			// loginLoginerror
			// 
			this.loginLoginerror.AutoSize = true;
			this.loginLoginerror.ForeColor = System.Drawing.Color.Red;
			this.loginLoginerror.Location = new System.Drawing.Point(55, 302);
			this.loginLoginerror.Name = "loginLoginerror";
			this.loginLoginerror.Size = new System.Drawing.Size(0, 20);
			this.loginLoginerror.TabIndex = 19;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 731);
			this.Controls.Add(this.loginLoginerror);
			this.Controls.Add(this.loginPasserror);
			this.Controls.Add(this.rememberMe);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.registerBtn);
			this.Controls.Add(this.loginPassShow);
			this.Controls.Add(this.loginPass);
			this.Controls.Add(this.loginlogin);
			this.Controls.Add(this.label1);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LoginFomr";
			this.Load += new System.EventHandler(this.LoginForm_Load);
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
		private Label loginPasserror;
		private Label loginLoginerror;
	}
}