using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

namespace Troianos_RAT
{
	// Token: 0x02000028 RID: 40
	[SuppressUnmanagedCodeSecurity]
	public sealed class GClass2
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x001D46FC File Offset: 0x001D2AFC
		[DebuggerNonUserCode]
		public GClass2()
		{
		}

		// Token: 0x0600042F RID: 1071
		[DllImport("kernel32")]
		public static extern IntPtr BeginUpdateResource(string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		// Token: 0x06000430 RID: 1072
		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndUpdateResource(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		// Token: 0x06000431 RID: 1073
		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateResource(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, short short_0, [MarshalAs(UnmanagedType.LPArray, SizeConst = 0, SizeParamIndex = 5)] byte[] byte_0, int int_0);
	}
}
