using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x0200001B RID: 27
	[DesignerGenerated]
	public partial class port : Form
	{
		// Token: 0x06000306 RID: 774 RVA: 0x001F4D9C File Offset: 0x001F319C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Troianos_RAT.port.__ENCList;
			lock (_ENCList)
			{
				bool flag = Troianos_RAT.port.__ENCList.Count == Troianos_RAT.port.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Troianos_RAT.port.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Troianos_RAT.port.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Troianos_RAT.port.__ENCList[num] = Troianos_RAT.port.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Troianos_RAT.port.__ENCList.RemoveRange(num, Troianos_RAT.port.__ENCList.Count - num);
					Troianos_RAT.port.__ENCList.Capacity = Troianos_RAT.port.__ENCList.Count;
				}
				Troianos_RAT.port.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000309 RID: 777 RVA: 0x001F53F0 File Offset: 0x001F37F0
		// (set) Token: 0x0600030A RID: 778 RVA: 0x001F5408 File Offset: 0x001F3808
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600030B RID: 779 RVA: 0x001F5414 File Offset: 0x001F3814
		// (set) Token: 0x0600030C RID: 780 RVA: 0x001F542C File Offset: 0x001F382C
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

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600030D RID: 781 RVA: 0x001F548C File Offset: 0x001F388C
		// (set) Token: 0x0600030E RID: 782 RVA: 0x001F54A4 File Offset: 0x001F38A4
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
				EventHandler value2 = new EventHandler(this.Button2_Click_1);
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

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600030F RID: 783 RVA: 0x001F5504 File Offset: 0x001F3904
		// (set) Token: 0x06000310 RID: 784 RVA: 0x001F551C File Offset: 0x001F391C
		internal virtual WaterFX WaterFX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._WaterFX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._WaterFX1 = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000311 RID: 785 RVA: 0x001F5528 File Offset: 0x001F3928
		// (set) Token: 0x06000312 RID: 786 RVA: 0x001F5540 File Offset: 0x001F3940
		internal virtual NumericUpDown NumericUpDown1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericUpDown1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._NumericUpDown1 = value;
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x001F554C File Offset: 0x001F394C
		public port()
		{
			base.Load += this.port_Load;
			base.Activated += this.port_Activated;
			base.KeyDown += this.port_KeyDown;
			Troianos_RAT.port.__ENCAddToList(this);
			this.port = -1;
			this.InitializeComponent();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x001F55B4 File Offset: 0x001F39B4
		private void port_Activated(object sender, EventArgs e)
		{
			this.NumericUpDown1.Focus();
		}

		// Token: 0x06000315 RID: 789 RVA: 0x001F55C4 File Offset: 0x001F39C4
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void port_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				e.SuppressKeyPress = true;
				flag = this.Button1.Enabled;
				if (flag)
				{
					this.Button1_Click_1(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), new EventArgs());
				}
			}
			else
			{
				flag = (e.KeyCode == Keys.Escape);
				if (flag)
				{
					this.port = -1;
					ProjectData.EndApp();
				}
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x001F5634 File Offset: 0x001F3A34
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int num = Conversions.ToInteger(this.NumericUpDown1.Value);
				bool flag = Conversions.ToInteger(this.NumericUpDown1.Value) > 65534 | Conversions.ToInteger(this.NumericUpDown1.Value) < 1;
				if (flag)
				{
					this.Button1.Enabled = false;
				}
				else
				{
					this.Button1.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				this.Button1.Enabled = false;
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x001F56E0 File Offset: 0x001F3AE0
		private void Button1_Click_1(object sender, EventArgs e)
		{
			this.port = Conversions.ToInteger(this.NumericUpDown1.Value);
			this.Close();
		}

		// Token: 0x06000318 RID: 792 RVA: 0x001F5708 File Offset: 0x001F3B08
		private void Button2_Click_1(object sender, EventArgs e)
		{
			this.port = -1;
			this.Close();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x001F571C File Offset: 0x001F3B1C
		private void port_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000172 RID: 370
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000174 RID: 372
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000175 RID: 373
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000176 RID: 374
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000177 RID: 375
		[AccessedThroughProperty("WaterFX1")]
		private WaterFX _WaterFX1;

		// Token: 0x04000178 RID: 376
		[AccessedThroughProperty("NumericUpDown1")]
		private NumericUpDown _NumericUpDown1;

		// Token: 0x04000179 RID: 377
		public int port;
	}
}
