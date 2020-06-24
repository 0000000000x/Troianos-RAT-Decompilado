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
	// Token: 0x02000010 RID: 16
	[DesignerGenerated]
	public partial class FURL : Form
	{
		// Token: 0x06000179 RID: 377 RVA: 0x001E7670 File Offset: 0x001E5A70
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = FURL.__ENCList;
			lock (_ENCList)
			{
				bool flag = FURL.__ENCList.Count == FURL.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = FURL.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = FURL.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								FURL.__ENCList[num] = FURL.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					FURL.__ENCList.RemoveRange(num, FURL.__ENCList.Count - num);
					FURL.__ENCList.Capacity = FURL.__ENCList.Count;
				}
				FURL.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600017C RID: 380 RVA: 0x001E7CFC File Offset: 0x001E60FC
		// (set) Token: 0x0600017D RID: 381 RVA: 0x001E7D14 File Offset: 0x001E6114
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

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600017E RID: 382 RVA: 0x001E7D20 File Offset: 0x001E6120
		// (set) Token: 0x0600017F RID: 383 RVA: 0x001E7D38 File Offset: 0x001E6138
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

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000180 RID: 384 RVA: 0x001E7D44 File Offset: 0x001E6144
		// (set) Token: 0x06000181 RID: 385 RVA: 0x001E7D5C File Offset: 0x001E615C
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

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000182 RID: 386 RVA: 0x001E7D68 File Offset: 0x001E6168
		// (set) Token: 0x06000183 RID: 387 RVA: 0x001E7D80 File Offset: 0x001E6180
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

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000184 RID: 388 RVA: 0x001E7D8C File Offset: 0x001E618C
		// (set) Token: 0x06000185 RID: 389 RVA: 0x001E7DA4 File Offset: 0x001E61A4
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
				this._Button2 = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000186 RID: 390 RVA: 0x001E7DB0 File Offset: 0x001E61B0
		// (set) Token: 0x06000187 RID: 391 RVA: 0x001E7DC8 File Offset: 0x001E61C8
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
				this._Button1 = value;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x001E7DD4 File Offset: 0x001E61D4
		public FURL()
		{
			base.Load += this.FURL_Load;
			base.KeyDown += this.FURL_KeyDown;
			FURL.__ENCAddToList(this);
			this.IsOK = false;
			this.InitializeComponent();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x001E7E28 File Offset: 0x001E6228
		private void FURL_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x001E7E60 File Offset: 0x001E6260
		private void TextBox1_TextAlignChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x001E7E64 File Offset: 0x001E6264
		private void Button1_Click(object sender, EventArgs e)
		{
			bool flag = this.TextBox1.Text.Length > 0 & this.TextBox1.Text.ToLower().StartsWith("http") & this.TextBox2.TextLength > 0;
			if (flag)
			{
				this.IsOK = true;
				this.Close();
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x001E7EC4 File Offset: 0x001E62C4
		private void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x001E7ED0 File Offset: 0x001E62D0
		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.TextBox2.Text = Strings.Split(this.TextBox1.Text, ".", -1, CompareMethod.Binary)[Strings.Split(this.TextBox1.Text, ".", -1, CompareMethod.Binary).Length - 1];
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x001E7F44 File Offset: 0x001E6344
		private void FURL_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x040000B0 RID: 176
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040000B2 RID: 178
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040000B3 RID: 179
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040000B4 RID: 180
		[AccessedThroughProperty("TextBox2")]
		private TextBox _TextBox2;

		// Token: 0x040000B5 RID: 181
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		// Token: 0x040000B6 RID: 182
		[AccessedThroughProperty("Button2")]
		private Button _Button2;

		// Token: 0x040000B7 RID: 183
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040000B8 RID: 184
		public bool IsOK;
	}
}
