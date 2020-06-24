using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Troianos_RAT.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000002 RID: 2 RVA: 0x001DAB28 File Offset: 0x001D8F28
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = MyApplication.__ENCList;
			lock (_ENCList)
			{
				bool flag = MyApplication.__ENCList.Count == MyApplication.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = MyApplication.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = MyApplication.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								MyApplication.__ENCList[num] = MyApplication.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					MyApplication.__ENCList.RemoveRange(num, MyApplication.__ENCList.Count - num);
					MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count;
				}
				MyApplication.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x001DAC2C File Offset: 0x001D902C
		[STAThread]
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x001DAC68 File Offset: 0x001D9068
		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			MyApplication.__ENCAddToList(this);
			this.IsSingleInstance = false;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x001DAC9C File Offset: 0x001D909C
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.Form1;
		}

		// Token: 0x04000001 RID: 1
		private static List<WeakReference> __ENCList = new List<WeakReference>();
	}
}
