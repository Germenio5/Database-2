namespace StudentSched
{
	partial class RegisterForm
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
			txtConfirm = new TextBox();
			lblConfirm = new Label();
			txtFullName = new TextBox();
			lblName = new Label();
			txtEmail = new TextBox();
			lblEmail = new Label();
			btnRegister = new Button();
			btnCancel = new Button();
			SuspendLayout();
			// 
			// lblUser
			// 
			lblUser.AutoSize = true;
			lblUser.Location = new Point(53, 57);
			lblUser.Name = "lblUser";
			lblUser.Size = new Size(75, 20);
			lblUser.TabIndex = 0;
			lblUser.Text = "Username";
			// 
			// lblPass
			// 
			lblPass.AutoSize = true;
			lblPass.Location = new Point(53, 106);
			lblPass.Name = "lblPass";
			lblPass.Size = new Size(70, 20);
			lblPass.TabIndex = 1;
			lblPass.Text = "Password";
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(190, 54);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(238, 27);
			txtUsername.TabIndex = 2;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(190, 103);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(238, 27);
			txtPassword.TabIndex = 3;
			// 
			// txtConfirm
			// 
			txtConfirm.Location = new Point(190, 157);
			txtConfirm.Name = "txtConfirm";
			txtConfirm.Size = new Size(238, 27);
			txtConfirm.TabIndex = 5;
			// 
			// lblConfirm
			// 
			lblConfirm.AutoSize = true;
			lblConfirm.Location = new Point(53, 160);
			lblConfirm.Name = "lblConfirm";
			lblConfirm.Size = new Size(127, 20);
			lblConfirm.TabIndex = 4;
			lblConfirm.Text = "Confirm Password";
			// 
			// txtFullName
			// 
			txtFullName.Location = new Point(190, 212);
			txtFullName.Name = "txtFullName";
			txtFullName.Size = new Size(238, 27);
			txtFullName.TabIndex = 7;
			// 
			// lblName
			// 
			lblName.AutoSize = true;
			lblName.Location = new Point(53, 215);
			lblName.Name = "lblName";
			lblName.Size = new Size(76, 20);
			lblName.TabIndex = 6;
			lblName.Text = "Full Name";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(190, 266);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(238, 27);
			txtEmail.TabIndex = 9;
			// 
			// lblEmail
			// 
			lblEmail.AutoSize = true;
			lblEmail.Location = new Point(53, 269);
			lblEmail.Name = "lblEmail";
			lblEmail.Size = new Size(46, 20);
			lblEmail.TabIndex = 8;
			lblEmail.Text = "Email";
			// 
			// btnRegister
			// 
			btnRegister.Location = new Point(132, 330);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(94, 29);
			btnRegister.TabIndex = 10;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(264, 330);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(94, 29);
			btnCancel.TabIndex = 11;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// RegisterForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(508, 403);
			Controls.Add(btnCancel);
			Controls.Add(btnRegister);
			Controls.Add(txtEmail);
			Controls.Add(lblEmail);
			Controls.Add(txtFullName);
			Controls.Add(lblName);
			Controls.Add(txtConfirm);
			Controls.Add(lblConfirm);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(lblPass);
			Controls.Add(lblUser);
			Name = "RegisterForm";
			Text = "Registeration Form";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblUser;
		private Label lblPass;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private TextBox txtConfirm;
		private Label lblConfirm;
		private TextBox txtFullName;
		private Label lblName;
		private TextBox txtEmail;
		private Label lblEmail;
		private Button btnRegister;
		private Button btnCancel;
	}
}