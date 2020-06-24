using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.My.Resources;

namespace Troianos_RAT
{
	// Token: 0x02000009 RID: 9
	[DesignerGenerated]
	public partial class About : Form
	{
		// Token: 0x06000056 RID: 86 RVA: 0x001DB8E8 File Offset: 0x001D9CE8
		[DebuggerNonUserCode]
		public About()
		{
			base.Load += this.About_Load;
			About.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000057 RID: 87 RVA: 0x001DB914 File Offset: 0x001D9D14
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = About.__ENCList;
			lock (_ENCList)
			{
				bool flag = About.__ENCList.Count == About.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = About.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = About.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								About.__ENCList[num] = About.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					About.__ENCList.RemoveRange(num, About.__ENCList.Count - num);
					About.__ENCList.Capacity = About.__ENCList.Count;
				}
				About.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005A RID: 90 RVA: 0x001DC068 File Offset: 0x001DA468
		// (set) Token: 0x0600005B RID: 91 RVA: 0x001DC080 File Offset: 0x001DA480
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

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005C RID: 92 RVA: 0x001DC08C File Offset: 0x001DA48C
		// (set) Token: 0x0600005D RID: 93 RVA: 0x001DC0A4 File Offset: 0x001DA4A4
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005E RID: 94 RVA: 0x001DC0B0 File Offset: 0x001DA4B0
		// (set) Token: 0x0600005F RID: 95 RVA: 0x001DC0C8 File Offset: 0x001DA4C8
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label2_Click);
				bool flag = this._Label2 != null;
				if (flag)
				{
					this._Label2.Click -= value2;
				}
				this._Label2 = value;
				flag = (this._Label2 != null);
				if (flag)
				{
					this._Label2.Click += value2;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000060 RID: 96 RVA: 0x001DC128 File Offset: 0x001DA528
		// (set) Token: 0x06000061 RID: 97 RVA: 0x001DC140 File Offset: 0x001DA540
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label3_Click);
				bool flag = this._Label3 != null;
				if (flag)
				{
					this._Label3.Click -= value2;
				}
				this._Label3 = value;
				flag = (this._Label3 != null);
				if (flag)
				{
					this._Label3.Click += value2;
				}
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000062 RID: 98 RVA: 0x001DC1A0 File Offset: 0x001DA5A0
		// (set) Token: 0x06000063 RID: 99 RVA: 0x001DC1B8 File Offset: 0x001DA5B8
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000064 RID: 100 RVA: 0x001DC1C4 File Offset: 0x001DA5C4
		// (set) Token: 0x06000065 RID: 101 RVA: 0x001DC1DC File Offset: 0x001DA5DC
		internal virtual LinkLabel LinkLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				bool flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked -= value2;
				}
				this._LinkLabel1 = value;
				flag = (this._LinkLabel1 != null);
				if (flag)
				{
					this._LinkLabel1.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000066 RID: 102 RVA: 0x001DC23C File Offset: 0x001DA63C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x001DC254 File Offset: 0x001DA654
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x001DC260 File Offset: 0x001DA660
		private void Label2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCUQwjm3KDbi28FBvT08PRvQ?sub_confirmation=1");
		}

		// Token: 0x06000069 RID: 105 RVA: 0x001DC270 File Offset: 0x001DA670
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://troianoshackings.blogspot.com");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x001DC280 File Offset: 0x001DA680
		private void Label3_Click(object sender, EventArgs e)
		{
			Process.Start("http://troianoshackings.blogspot.com");
		}

		// Token: 0x0600006B RID: 107 RVA: 0x001DC290 File Offset: 0x001DA690
		private void About_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400002D RID: 45
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400002F RID: 47
		[AccessedThroughProperty("WaterFX1")]
		private WaterFX _WaterFX1;

		// Token: 0x04000030 RID: 48
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000031 RID: 49
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000032 RID: 50
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000033 RID: 51
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000034 RID: 52
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		// Token: 0x04000035 RID: 53
		[AccessedThroughProperty("Label5")]
		private Label _Label5;
	}
}
