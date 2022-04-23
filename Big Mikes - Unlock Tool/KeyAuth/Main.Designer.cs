namespace KeyAuth
{
	// Token: 0x02000004 RID: 4
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000022F3 File Offset: 0x000004F3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002508 File Offset: 0x00000708
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.siticoneGradientButton1 = new global::Siticone.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientButton2 = new global::Siticone.UI.WinForms.SiticoneGradientButton();
			this.siticoneGradientButton3 = new global::Siticone.UI.WinForms.SiticoneGradientButton();
			this.expiry = new global::System.Windows.Forms.Label();
			this.numUsers = new global::System.Windows.Forms.Label();
			this.sidebar = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneCustomGradientPanel3 = new global::Siticone.UI.WinForms.SiticoneCustomGradientPanel();
			this.siticoneCustomGradientPanel1 = new global::Siticone.UI.WinForms.SiticoneCustomGradientPanel();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.siticoneCustomGradientPanel2 = new global::Siticone.UI.WinForms.SiticoneCustomGradientPanel();
			this.siticoneCustomGradientPanel5 = new global::Siticone.UI.WinForms.SiticoneCustomGradientPanel();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.sidebar.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(552, 0);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(500, 0);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation9.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation9.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation9.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation9.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation9.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.siticoneGradientButton1.BackColor = global::System.Drawing.Color.Black;
			this.siticoneGradientButton1.BorderColor = global::System.Drawing.Color.White;
			this.siticoneGradientButton1.BorderRadius = 5;
			this.siticoneGradientButton1.CheckedState.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.CustomImages.Parent = this.siticoneGradientButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneGradientButton1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneGradientButton1.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton1.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneGradientButton1.ForeColor = global::System.Drawing.Color.Yellow;
			this.siticoneGradientButton1.HoveredState.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.Location = new global::System.Drawing.Point(0, 128);
			this.siticoneGradientButton1.Name = "siticoneGradientButton1";
			this.siticoneGradientButton1.ShadowDecoration.Parent = this.siticoneGradientButton1;
			this.siticoneGradientButton1.Size = new global::System.Drawing.Size(175, 40);
			this.siticoneGradientButton1.TabIndex = 29;
			this.siticoneGradientButton1.Text = "Inject Tool";
			this.siticoneGradientButton1.Click += new global::System.EventHandler(this.siticoneGradientButton1_Click);
			this.siticoneGradientButton2.BackColor = global::System.Drawing.Color.Black;
			this.siticoneGradientButton2.BorderColor = global::System.Drawing.Color.White;
			this.siticoneGradientButton2.BorderRadius = 5;
			this.siticoneGradientButton2.CheckedState.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.CustomImages.Parent = this.siticoneGradientButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneGradientButton2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneGradientButton2.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton2.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton2.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneGradientButton2.ForeColor = global::System.Drawing.Color.Yellow;
			this.siticoneGradientButton2.HoveredState.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.Location = new global::System.Drawing.Point(0, 209);
			this.siticoneGradientButton2.Name = "siticoneGradientButton2";
			this.siticoneGradientButton2.ShadowDecoration.Parent = this.siticoneGradientButton2;
			this.siticoneGradientButton2.Size = new global::System.Drawing.Size(167, 40);
			this.siticoneGradientButton2.TabIndex = 54;
			this.siticoneGradientButton2.Text = "Support Panel";
			this.siticoneGradientButton2.Click += new global::System.EventHandler(this.siticoneGradientButton2_Click);
			this.siticoneGradientButton3.BackColor = global::System.Drawing.Color.Black;
			this.siticoneGradientButton3.BorderColor = global::System.Drawing.Color.White;
			this.siticoneGradientButton3.BorderRadius = 5;
			this.siticoneGradientButton3.CheckedState.Parent = this.siticoneGradientButton3;
			this.siticoneGradientButton3.CustomImages.Parent = this.siticoneGradientButton3;
			this.siticoneTransition1.SetDecoration(this.siticoneGradientButton3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneGradientButton3.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton3.FillColor2 = global::System.Drawing.Color.Transparent;
			this.siticoneGradientButton3.Font = new global::System.Drawing.Font("Trebuchet MS", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneGradientButton3.ForeColor = global::System.Drawing.Color.Yellow;
			this.siticoneGradientButton3.HoveredState.Parent = this.siticoneGradientButton3;
			this.siticoneGradientButton3.Location = new global::System.Drawing.Point(0, 170);
			this.siticoneGradientButton3.Name = "siticoneGradientButton3";
			this.siticoneGradientButton3.ShadowDecoration.Parent = this.siticoneGradientButton3;
			this.siticoneGradientButton3.Size = new global::System.Drawing.Size(175, 40);
			this.siticoneGradientButton3.TabIndex = 57;
			this.siticoneGradientButton3.Text = "HWID Cleaner";
			this.siticoneGradientButton3.Click += new global::System.EventHandler(this.siticoneGradientButton3_Click);
			this.expiry.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.expiry, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.expiry.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.Color.Yellow;
			this.expiry.Location = new global::System.Drawing.Point(175, 104);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(91, 17);
			this.expiry.TabIndex = 58;
			this.expiry.Text = "";
			this.expiry.Click += new global::System.EventHandler(this.expiry_Click);
			this.numUsers.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.numUsers, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.numUsers.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.numUsers.ForeColor = global::System.Drawing.Color.Yellow;
			this.numUsers.Location = new global::System.Drawing.Point(169, 24);
			this.numUsers.Name = "Full cracked by Cabbo";
			this.numUsers.Size = new global::System.Drawing.Size(120, 17);
			this.numUsers.TabIndex = 59;
			this.numUsers.Text = "Full cracked by Cabbo";
			this.numUsers.Click += new global::System.EventHandler(this.numUsers_Click);
			this.sidebar.BackColor = global::System.Drawing.Color.Black;
			this.sidebar.Controls.Add(this.pictureBox1);
			this.sidebar.Controls.Add(this.siticoneCustomGradientPanel3);
			this.sidebar.Controls.Add(this.siticoneCustomGradientPanel1);
			this.sidebar.Controls.Add(this.siticoneGradientButton1);
			this.sidebar.Controls.Add(this.siticoneGradientButton3);
			this.sidebar.Controls.Add(this.siticoneGradientButton2);
			this.siticoneTransition1.SetDecoration(this.sidebar, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.sidebar.Location = new global::System.Drawing.Point(2, 0);
			this.sidebar.Name = "sidebar";
			this.sidebar.Size = new global::System.Drawing.Size(167, 566);
			this.sidebar.TabIndex = 63;
			this.sidebar.Paint += new global::System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(-181, -40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(531, 169);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 75;
			this.pictureBox1.TabStop = false;
			this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneCustomGradientPanel3.FillColor = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel3.FillColor2 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel3.FillColor3 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel3.FillColor4 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel3.Location = new global::System.Drawing.Point(0, 170);
			this.siticoneCustomGradientPanel3.Name = "siticoneCustomGradientPanel3";
			this.siticoneCustomGradientPanel3.ShadowDecoration.Parent = this.siticoneCustomGradientPanel3;
			this.siticoneCustomGradientPanel3.Size = new global::System.Drawing.Size(200, 1);
			this.siticoneCustomGradientPanel3.TabIndex = 71;
			this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneCustomGradientPanel1.FillColor = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel1.FillColor2 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel1.FillColor3 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel1.FillColor4 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel1.Location = new global::System.Drawing.Point(0, 209);
			this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
			this.siticoneCustomGradientPanel1.ShadowDecoration.Parent = this.siticoneCustomGradientPanel1;
			this.siticoneCustomGradientPanel1.Size = new global::System.Drawing.Size(200, 1);
			this.siticoneCustomGradientPanel1.TabIndex = 69;
			this.listBox1.BackColor = global::System.Drawing.Color.DimGray;
			this.listBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.siticoneTransition1.SetDecoration(this.listBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.listBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.listBox1.ForeColor = global::System.Drawing.Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Items.AddRange(new object[]
			{
				"BEFORE INJECTING THE TOOL...",
				"",
				"(+) Make Sure The Following Are Disabled...",
				"",
				"(+) Real Time Protection",
				"(+) Windows Defender - Firewall",
				"(+) Smart Screen",
				"(+) Riot Vanguard",
				"",
				"(+) How To Inject",
				"",
				"(+) Click Inject Tool ",
				"(+) Wait Till Prompted",
				"(+) Start The Game.",
				"",
				"(+)How To Clean Traces",
				"",
				"(+) Run The HWID Cleaner",
				"(+) Press 1 And Click Enter",
				"(+) Find Your Modern Warfare Folder And Click On It",
				"(+) Then The Same For Black Ops Cold War.",
				"(+) Let The CMD Run.",
				"(+) Done",
				"",
				""
			});
			this.listBox1.Location = new global::System.Drawing.Point(172, 124);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(425, 132);
			this.listBox1.TabIndex = 3;
			this.label7.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label7, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.Yellow;
			this.label7.Location = new global::System.Drawing.Point(168, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(321, 20);
			this.label7.TabIndex = 68;
			this.label7.Text = "Big Mike's (MW - WZ - VG) Unlock Tool";
			this.label7.Click += new global::System.EventHandler(this.label7_Click);
			this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneCustomGradientPanel2.FillColor = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel2.FillColor2 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel2.FillColor3 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel2.FillColor4 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel2.Location = new global::System.Drawing.Point(2, 251);
			this.siticoneCustomGradientPanel2.Name = "siticoneCustomGradientPanel2";
			this.siticoneCustomGradientPanel2.ShadowDecoration.Parent = this.siticoneCustomGradientPanel2;
			this.siticoneCustomGradientPanel2.Size = new global::System.Drawing.Size(167, 1);
			this.siticoneCustomGradientPanel2.TabIndex = 70;
			this.siticoneTransition1.SetDecoration(this.siticoneCustomGradientPanel5, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneCustomGradientPanel5.FillColor = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel5.FillColor2 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel5.FillColor3 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel5.FillColor4 = global::System.Drawing.Color.Yellow;
			this.siticoneCustomGradientPanel5.Location = new global::System.Drawing.Point(2, 128);
			this.siticoneCustomGradientPanel5.Name = "siticoneCustomGradientPanel5";
			this.siticoneCustomGradientPanel5.ShadowDecoration.Parent = this.siticoneCustomGradientPanel5;
			this.siticoneCustomGradientPanel5.Size = new global::System.Drawing.Size(167, 1);
			this.siticoneCustomGradientPanel5.TabIndex = 72;
			this.siticoneTransition1.SetDecoration(this.pictureBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(2, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(595, 249);
			this.pictureBox2.TabIndex = 73;
			this.pictureBox2.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(599, 254);
			base.Controls.Add(this.siticoneCustomGradientPanel5);
			base.Controls.Add(this.siticoneCustomGradientPanel2);
			base.Controls.Add(this.listBox1);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.numUsers);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.sidebar);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox2);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			this.sidebar.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000004 RID: 4
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000005 RID: 5
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x04000006 RID: 6
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x04000007 RID: 7
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x04000008 RID: 8
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400000A RID: 10
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x0400000B RID: 11
		private global::Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton1;

		// Token: 0x0400000C RID: 12
		private global::Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton2;

		// Token: 0x0400000D RID: 13
		private global::Siticone.UI.WinForms.SiticoneGradientButton siticoneGradientButton3;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label expiry;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label numUsers;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Panel sidebar;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.PictureBox pictureBox2;

		// Token: 0x04000015 RID: 21
		private global::Siticone.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel2;

		// Token: 0x04000016 RID: 22
		private global::Siticone.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel3;

		// Token: 0x04000017 RID: 23
		private global::Siticone.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;

		// Token: 0x04000018 RID: 24
		private global::Siticone.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel5;
	}
}
