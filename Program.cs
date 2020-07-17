using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002A72 File Offset: 0x00000C72
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
