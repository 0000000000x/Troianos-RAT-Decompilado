using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT.My
{
	// Token: 0x02000043 RID: 67
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[HideModuleName]
	[StandardModule]
	internal sealed class MySettingsProperty
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x001DAB00 File Offset: 0x001D8F00
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
