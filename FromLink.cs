using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x0200000F RID: 15
	[DesignerGenerated]
	public partial class FromLink : Form
	{
		// Token: 0x06000164 RID: 356 RVA: 0x001E6D20 File Offset: 0x001E5120
		[DebuggerNonUserCode]
		public FromLink()
		{
			base.Load += this.FromLink_Load;
			FromLink.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000165 RID: 357 RVA: 0x001E6D4C File Offset: 0x001E514C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = FromLink.__ENCList;
			lock (_ENCList)
			{
				bool flag = FromLink.__ENCList.Count == FromLink.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = FromLink.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = FromLink.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								FromLink.__ENCList[num] = FromLink.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					FromLink.__ENCList.RemoveRange(num, FromLink.__ENCList.Count - num);
					FromLink.__ENCList.Capacity = FromLink.__ENCList.Count;
				}
				FromLink.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000168 RID: 360 RVA: 0x001E73E4 File Offset: 0x001E57E4
		// (set) Token: 0x06000169 RID: 361 RVA: 0x001E73FC File Offset: 0x001E57FC
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

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600016A RID: 362 RVA: 0x001E745C File Offset: 0x001E585C
		// (set) Token: 0x0600016B RID: 363 RVA: 0x001E7474 File Offset: 0x001E5874
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

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600016C RID: 364 RVA: 0x001E74D4 File Offset: 0x001E58D4
		// (set) Token: 0x0600016D RID: 365 RVA: 0x001E74EC File Offset: 0x001E58EC
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
				EventHandler value2 = new EventHandler(this.TextBox1_TextAlignChanged);
				bool flag = this._TextBox1 != null;
				if (flag)
				{
					this._TextBox1.TextAlignChanged -= value2;
				}
				this._TextBox1 = value;
				flag = (this._TextBox1 != null);
				if (flag)
				{
					this._TextBox1.TextAlignChanged += value2;
				}
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600016E RID: 366 RVA: 0x001E754C File Offset: 0x001E594C
		// (set) Token: 0x0600016F RID: 367 RVA: 0x001E7564 File Offset: 0x001E5964
		internal virtual TextBox TextBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TextBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._TextBox2 = value;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000170 RID: 368 RVA: 0x001E7570 File Offset: 0x001E5970
		// (set) Token: 0x06000171 RID: 369 RVA: 0x001E7588 File Offset: 0x001E5988
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

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000172 RID: 370 RVA: 0x001E7594 File Offset: 0x001E5994
		// (set) Token: 0x06000173 RID: 371 RVA: 0x001E75AC File Offset: 0x001E59AC
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

		// Token: 0x06000174 RID: 372 RVA: 0x001E75B8 File Offset: 0x001E59B8
		private void Button1_Click(object sender, EventArgs e)
		{
			this.IsOK = true;
			this.Close();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x001E75CC File Offset: 0x001E59CC
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x001E75D8 File Offset: 0x001E59D8
		private void TextBox1_TextAlignChanged(object sender, EventArgs e)
		{
			try
			{
				this.TextBox2.Text = Strings.Split(this.TextBox1.Text, "\\", -1, CompareMethod.Binary)[Strings.Split(this.TextBox1.Text, "\\", -1, CompareMethod.Binary).Length - 1];
			}
			catch (Exception ex)
			{
				this.TextBox2.Text = "Arquivo.txt";
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x001E765C File Offset: 0x001E5A5C
		private void FromLink_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x040000A7 RID: 167
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000A9 RID: 169
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000AA RID: 170
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040000AB RID: 171
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040000AC RID: 172
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x040000AD RID: 173
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000AE RID: 174
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040000AF RID: 175
		public bool IsOK;
	}
}
