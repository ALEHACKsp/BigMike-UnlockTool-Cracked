using System;
using System.Windows.Forms;

namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x06000042 RID: 66 RVA: 0x000023C2 File Offset: 0x000005C2
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
