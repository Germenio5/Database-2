namespace StudentSched
{
	partial class FrmLogin
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
			lblUser = new Label();
			lblPass = new Label();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			btnExit = new Button();
			SuspendLayout();
			// 
			// lblUser
			// 
			lblUser.AutoSize = true;
			lblUser.Location = new Point(61, 41);
			lblUser.Name = "lblUser";
			lblUser.Size = new Size(75, 20);
			lblUser.TabIndex = 0;
			lblUser.Text = "Username";
			// 
			// lblPass
			// 
			lblPass.AutoSize = true;
			lblPass.Location = new Point(61, 93);
			lblPass.Name = "lblPass";
			lblPass.Size = new Size(70, 20);
			lblPass.TabIndex = 1;
			lblPass.Text = "Password";
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(153, 38);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(217, 27);
			txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(153, 93);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(217, 27);
			txtPassword.TabIndex = 3;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(106, 154);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(94, 29);
			btnLogin.TabIndex = 4;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(231, 154);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(94, 29);
			btnExit.TabIndex = 5;
			btnExit.Text = "Cancel";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// FrmLogin
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(445, 215);
			Controls.Add(btnExit);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(lblPass);
			Controls.Add(lblUser);
			Name = "FrmLogin";
			Text = "Login Form";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblUser;
		private Label lblPass;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnLogin;
		private Button btnExit;
	}
}