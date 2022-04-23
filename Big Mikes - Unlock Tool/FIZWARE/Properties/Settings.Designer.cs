using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FIZWARE.Properties
{
	// Token: 0x02000003 RID: 3
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000218D File Offset: 0x0000038D
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002194 File Offset: 0x00000394
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000021A6 File Offset: 0x000003A6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string UserName
		{
			get
			{
				return (string)this["UserName"];
			}
			set
			{
				this["UserName"] = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021B4 File Offset: 0x000003B4
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000021C6 File Offset: 0x000003C6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Password
		{
			get
			{
				return (string)this["Password"];
			}
			set
			{
				this["Password"] = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000021D4 File Offset: 0x000003D4
		// (set) Token: 0x06000015 RID: 21 RVA: 0x000021E6 File Offset: 0x000003E6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string loginRemember
		{
			get
			{
				return (string)this["loginRemember"];
			}
			set
			{
				this["loginRemember"] = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000021F4 File Offset: 0x000003F4
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002206 File Offset: 0x00000406
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Key
		{
			get
			{
				return (string)this["Key"];
			}
			set
			{
				this["Key"] = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
