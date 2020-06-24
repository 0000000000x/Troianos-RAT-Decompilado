using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Troianos_RAT
{
	// Token: 0x0200002D RID: 45
	public sealed class GClass7
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x001D786C File Offset: 0x001D5C6C
		[DebuggerNonUserCode]
		public GClass7()
		{
		}

		// Token: 0x0600045A RID: 1114
		[DllImport("User32.dll")]
		private static extern bool GetLastInputInfo(ref GClass7.GStruct0 gstruct0_0);

		// Token: 0x0600045B RID: 1115 RVA: 0x001D7878 File Offset: 0x001D5C78
		public static uint smethod_0()
		{
			GClass7.GStruct0 gstruct = new GClass7.GStruct0
			{
				uint_0 = Convert.ToUInt32(Marshal.SizeOf(gstruct))
			};
			GClass7.GetLastInputInfo(ref gstruct);
			return Convert.ToUInt32(Environment.TickCount) - gstruct.uint_1;
		}

		// Token: 0x0200002E RID: 46
		public struct GStruct0
		{
			// Token: 0x0400027C RID: 636
			public uint uint_0;

			// Token: 0x0400027D RID: 637
			public uint uint_1;
		}
	}
}
