using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentSched
{
	public class MainDash : Form
	{
		private Label lblWelcome;

		private void InitializeComponent()
		{
			SuspendLayout();
			// 
			// MainDash
			// 
			ClientSize = new Size(782, 431);
			Name = "MainDash";
			ResumeLayout(false);

		}

		public MainDash(string username)
		{
			Text = "Main Dashboard";
			StartPosition = FormStartPosition.CenterScreen;
			Size = new Size(800, 600);

			lblWelcome = new Label
			{
				AutoSize = true,
				Text = $"Welcome, {username}",
				Location = new Point(20, 20),
				Font = new Font("Segoe UI", 12, FontStyle.Regular)
			};

			Controls.Add(lblWelcome);
		}
	}
}