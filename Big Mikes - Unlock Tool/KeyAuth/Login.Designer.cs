namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public partial class Login : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000023A3 File Offset: 0x000005A3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003874 File Offset: 0x00001A74
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::KeyAuth.Login));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.LoginBtn = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.LoginKey = new global::Siticone.UI.WinForms.SiticoneRoundedTextBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.pictureBox2 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(314, 1);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = global::Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(263, 1);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.siticoneTransition1.AnimationType = global::Siticone.UI.AnimatorNS.AnimationType.Rotate;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation6.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation6.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation6.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation6.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation6.SlideCoeff");
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
			this.LoginBtn.BorderColor = global::System.Drawing.Color.Yellow;
			this.LoginBtn.BorderThickness = 1;
			this.LoginBtn.CheckedState.Parent = this.LoginBtn;
			this.LoginBtn.CustomImages.Parent = this.LoginBtn;
			this.siticoneTransition1.SetDecoration(this.LoginBtn, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.LoginBtn.FillColor = global::System.Drawing.Color.Black;
			this.LoginBtn.Font = new global::System.Drawing.Font("Segoe UI", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoginBtn.ForeColor = global::System.Drawing.Color.Yellow;
			this.LoginBtn.HoveredState.BorderColor = global::System.Drawing.Color.White;
			this.LoginBtn.HoveredState.Parent = this.LoginBtn;
			this.LoginBtn.Location = new global::System.Drawing.Point(81, 175);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
			this.LoginBtn.Size = new global::System.Drawing.Size(200, 41);
			this.LoginBtn.TabIndex = 26;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.Click += new global::System.EventHandler(this.LoginBtn_Click);
			this.LoginKey.AllowDrop = true;
			this.LoginKey.BackColor = global::System.Drawing.Color.Black;
			this.LoginKey.BorderColor = global::System.Drawing.Color.White;
			this.LoginKey.BorderThickness = 0;
			this.LoginKey.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.siticoneTransition1.SetDecoration(this.LoginKey, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.LoginKey.DefaultText = "Enter Your License Key";
			this.LoginKey.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.LoginKey.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.LoginKey.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.LoginKey.DisabledState.Parent = this.LoginKey;
			this.LoginKey.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.LoginKey.FillColor = global::System.Drawing.Color.Black;
			this.LoginKey.FocusedState.BorderColor = global::System.Drawing.Color.Silver;
			this.LoginKey.FocusedState.Parent = this.LoginKey;
			this.LoginKey.ForeColor = global::System.Drawing.Color.Yellow;
			this.LoginKey.HoveredState.BorderColor = global::System.Drawing.Color.Silver;
			this.LoginKey.HoveredState.Parent = this.LoginKey;
			this.LoginKey.Location = new global::System.Drawing.Point(81, 139);
			this.LoginKey.Margin = new global::System.Windows.Forms.Padding(4);
			this.LoginKey.Name = "LoginKey";
			this.LoginKey.PasswordChar = '\0';
			this.LoginKey.PlaceholderForeColor = global::System.Drawing.Color.Silver;
			this.LoginKey.PlaceholderText = "";
			this.LoginKey.SelectedText = "";
			this.LoginKey.ShadowDecoration.Parent = this.LoginKey;
			this.LoginKey.Size = new global::System.Drawing.Size(196, 30);
			this.LoginKey.TabIndex = 32;
			this.LoginKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.LoginKey.TextChanged += new global::System.EventHandler(this.key_TextChanged);
			this.LoginKey.Enter += new global::System.EventHandler(this.key_Enter);
			this.LoginKey.Leave += new global::System.EventHandler(this.key_Leave);
			this.panel1.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.panel1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel1.Location = new global::System.Drawing.Point(151, 377);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(200, 1);
			this.panel1.TabIndex = 34;
			this.panel2.BackColor = global::System.Drawing.Color.Yellow;
			this.siticoneTransition1.SetDecoration(this.panel2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel2.Location = new global::System.Drawing.Point(81, 168);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(200, 1);
			this.panel2.TabIndex = 35;
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.siticoneTransition1.SetDecoration(this.pictureBox1, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(128, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(99, 93);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 42;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.button1.BackColor = global::System.Drawing.Color.Black;
			this.button1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.BackgroundImage");
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.siticoneTransition1.SetDecoration(this.button1, global::Siticone.UI.AnimatorNS.DecorationType.Custom);
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.SystemColors.ActiveBorder;
			this.button1.Location = new global::System.Drawing.Point(2, 284);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(38, 36);
			this.button1.TabIndex = 36;
			this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.label2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Yellow;
			this.label2.Location = new global::System.Drawing.Point(46, 294);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(109, 16);
			this.label2.TabIndex = 64;
			this.label2.Text = "Join The Discord";
			this.panel3.BackColor = global::System.Drawing.Color.Yellow;
			this.siticoneTransition1.SetDecoration(this.panel3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.panel3.Location = new global::System.Drawing.Point(2, 20);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(235, 1);
			this.panel3.TabIndex = 65;
			this.label3.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label3, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Yellow;
			this.label3.Location = new global::System.Drawing.Point(-1, 1);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(244, 16);
			this.label3.TabIndex = 66;
			this.label3.Text = "Big Mike's | MW - WZ - VG | Unlock Tool";
			this.pictureBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.pictureBox2, global::Siticone.UI.AnimatorNS.DecorationType.None);
			this.pictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new global::System.Drawing.Point(2, 1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new global::System.Drawing.Size(357, 319);
			this.pictureBox2.TabIndex = 69;
			this.pictureBox2.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.Black;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(360, 323);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.LoginKey);
			base.Controls.Add(this.LoginBtn);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			base.Controls.Add(this.pictureBox2);
			this.siticoneTransition1.SetDecoration(this, global::Siticone.UI.AnimatorNS.DecorationType.BottomMirror);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Login_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000019 RID: 25
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001A RID: 26
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400001B RID: 27
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400001C RID: 28
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400001D RID: 29
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001F RID: 31
		private global::Siticone.UI.WinForms.SiticoneRoundedButton LoginBtn;

		// Token: 0x04000020 RID: 32
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000021 RID: 33
		private global::Siticone.UI.WinForms.SiticoneRoundedTextBox LoginKey;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.PictureBox pictureBox2;
	}
}
