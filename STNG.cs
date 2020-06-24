using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x0200001F RID: 31
	[DesignerGenerated]
	public partial class STNG : Form
	{
		// Token: 0x060003A7 RID: 935 RVA: 0x001FB078 File Offset: 0x001F9478
		[DebuggerNonUserCode]
		public STNG()
		{
			base.Load += this.STNG_Load;
			STNG.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x001FB0A4 File Offset: 0x001F94A4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = STNG.__ENCList;
			lock (_ENCList)
			{
				bool flag = STNG.__ENCList.Count == STNG.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = STNG.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = STNG.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								STNG.__ENCList[num] = STNG.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					STNG.__ENCList.RemoveRange(num, STNG.__ENCList.Count - num);
					STNG.__ENCList.Capacity = STNG.__ENCList.Count;
				}
				STNG.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060003AB RID: 939 RVA: 0x001FC73C File Offset: 0x001FAB3C
		// (set) Token: 0x060003AC RID: 940 RVA: 0x001FC754 File Offset: 0x001FAB54
		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox1 = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060003AD RID: 941 RVA: 0x001FC760 File Offset: 0x001FAB60
		// (set) Token: 0x060003AE RID: 942 RVA: 0x001FC778 File Offset: 0x001FAB78
		internal virtual CheckBox ShowAlert
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShowAlert;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ShowAlert = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003AF RID: 943 RVA: 0x001FC784 File Offset: 0x001FAB84
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x001FC79C File Offset: 0x001FAB9C
		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox2 = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x001FC7A8 File Offset: 0x001FABA8
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x001FC7C0 File Offset: 0x001FABC0
		internal virtual CheckBox LOGMSGS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGMSGS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGMSGS = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x001FC7CC File Offset: 0x001FABCC
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x001FC7E4 File Offset: 0x001FABE4
		internal virtual CheckBox LOGRERR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGRERR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGRERR = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x001FC7F0 File Offset: 0x001FABF0
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x001FC808 File Offset: 0x001FAC08
		internal virtual CheckBox LOGCONNECTIONS
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGCONNECTIONS;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGCONNECTIONS = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x001FC814 File Offset: 0x001FAC14
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x001FC82C File Offset: 0x001FAC2C
		internal virtual CheckBox LOGLERR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGLERR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGLERR = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x001FC838 File Offset: 0x001FAC38
		// (set) Token: 0x060003BA RID: 954 RVA: 0x001FC850 File Offset: 0x001FAC50
		internal virtual CheckBox LOGLOGIN
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LOGLOGIN;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LOGLOGIN = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003BB RID: 955 RVA: 0x001FC85C File Offset: 0x001FAC5C
		// (set) Token: 0x060003BC RID: 956 RVA: 0x001FC874 File Offset: 0x001FAC74
		internal virtual GroupBox GroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox3 = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003BD RID: 957 RVA: 0x001FC880 File Offset: 0x001FAC80
		// (set) Token: 0x060003BE RID: 958 RVA: 0x001FC898 File Offset: 0x001FAC98
		internal virtual CheckBox SCAUT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SCAUT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.SCAUT_CheckedChanged);
				bool flag = this._SCAUT != null;
				if (flag)
				{
					this._SCAUT.CheckedChanged -= value2;
				}
				this._SCAUT = value;
				flag = (this._SCAUT != null);
				if (flag)
				{
					this._SCAUT.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003BF RID: 959 RVA: 0x001FC8F8 File Offset: 0x001FACF8
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x001FC910 File Offset: 0x001FAD10
		internal virtual ComboBox SCI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SCI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SCI = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x001FC91C File Offset: 0x001FAD1C
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x001FC934 File Offset: 0x001FAD34
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x001FC940 File Offset: 0x001FAD40
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x001FC958 File Offset: 0x001FAD58
		internal virtual GroupBox GroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox4 = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x001FC964 File Offset: 0x001FAD64
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x001FC97C File Offset: 0x001FAD7C
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

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x001FC988 File Offset: 0x001FAD88
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x001FC9A0 File Offset: 0x001FADA0
		internal virtual ComboBox CAMI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CAMI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CAMI = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x001FC9AC File Offset: 0x001FADAC
		// (set) Token: 0x060003CA RID: 970 RVA: 0x001FC9C4 File Offset: 0x001FADC4
		internal virtual CheckBox CAMAUT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CAMAUT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CAMAUT_CheckedChanged);
				bool flag = this._CAMAUT != null;
				if (flag)
				{
					this._CAMAUT.CheckedChanged -= value2;
				}
				this._CAMAUT = value;
				flag = (this._CAMAUT != null);
				if (flag)
				{
					this._CAMAUT.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003CB RID: 971 RVA: 0x001FCA24 File Offset: 0x001FAE24
		// (set) Token: 0x060003CC RID: 972 RVA: 0x001FCA3C File Offset: 0x001FAE3C
		internal virtual GroupBox GroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox5 = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003CD RID: 973 RVA: 0x001FCA48 File Offset: 0x001FAE48
		// (set) Token: 0x060003CE RID: 974 RVA: 0x001FCA60 File Offset: 0x001FAE60
		internal virtual ComboBox MICI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MICI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MICI = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003CF RID: 975 RVA: 0x001FCA6C File Offset: 0x001FAE6C
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x001FCA84 File Offset: 0x001FAE84
		internal virtual CheckBox MICAUT
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MICAUT;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.MICAUT_CheckedChanged);
				bool flag = this._MICAUT != null;
				if (flag)
				{
					this._MICAUT.CheckedChanged -= value2;
				}
				this._MICAUT = value;
				flag = (this._MICAUT != null);
				if (flag)
				{
					this._MICAUT.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x001FCAE4 File Offset: 0x001FAEE4
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x001FCAFC File Offset: 0x001FAEFC
		internal virtual GroupBox GroupBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox6 = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x001FCB08 File Offset: 0x001FAF08
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x001FCB20 File Offset: 0x001FAF20
		internal virtual ComboBox scrI
		{
			[DebuggerNonUserCode]
			get
			{
				return this._scrI;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.scrI_SelectedIndexChanged);
				bool flag = this._scrI != null;
				if (flag)
				{
					this._scrI.SelectedIndexChanged -= value2;
				}
				this._scrI = value;
				flag = (this._scrI != null);
				if (flag)
				{
					this._scrI.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x001FCB80 File Offset: 0x001FAF80
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x001FCB98 File Offset: 0x001FAF98
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x001FCBF8 File Offset: 0x001FAFF8
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x001FCC10 File Offset: 0x001FB010
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

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x001FCC1C File Offset: 0x001FB01C
		// (set) Token: 0x060003DA RID: 986 RVA: 0x001FCC34 File Offset: 0x001FB034
		internal virtual GroupBox GroupBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GroupBox7 = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003DB RID: 987 RVA: 0x001FCC40 File Offset: 0x001FB040
		// (set) Token: 0x060003DC RID: 988 RVA: 0x001FCC58 File Offset: 0x001FB058
		internal virtual CheckBox CheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox2_CheckedChanged);
				bool flag = this._CheckBox2 != null;
				if (flag)
				{
					this._CheckBox2.CheckedChanged -= value2;
				}
				this._CheckBox2 = value;
				flag = (this._CheckBox2 != null);
				if (flag)
				{
					this._CheckBox2.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003DD RID: 989 RVA: 0x001FCCB8 File Offset: 0x001FB0B8
		// (set) Token: 0x060003DE RID: 990 RVA: 0x001FCCD0 File Offset: 0x001FB0D0
		internal virtual CheckBox CheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CheckBox1_CheckedChanged);
				bool flag = this._CheckBox1 != null;
				if (flag)
				{
					this._CheckBox1.CheckedChanged -= value2;
				}
				this._CheckBox1 = value;
				flag = (this._CheckBox1 != null);
				if (flag)
				{
					this._CheckBox1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x001FCD30 File Offset: 0x001FB130
		private void STNG_Load(object sender, EventArgs e)
		{
			this.SCAUT.Checked = Class7.class8_0.bool_6;
			this.SCI.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0);
			this.CAMAUT.Checked = Class7.class8_0.bool_7;
			this.CAMI.SelectedIndex = Class7.class8_0.int_0;
			this.MICAUT.Checked = Class7.class8_0.bool_8;
			this.LOGCONNECTIONS.Checked = Class7.class8_0.bool_2;
			this.LOGLERR.Checked = Class7.class8_0.bool_3;
			this.LOGRERR.Checked = Class7.class8_0.bool_4;
			this.LOGMSGS.Checked = Class7.class8_0.bool_5;
			this.LOGLOGIN.Checked = Class7.class8_0.bool_1;
			this.ShowAlert.Checked = Class7.class8_0.bool_0;
			this.MICI.SelectedIndex = Class7.class8_0.int_1;
			this.scrI.SelectedIndex = Class7.class8_0.int_2;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x001FCE64 File Offset: 0x001FB264
		private void Button1_Click(object sender, EventArgs e)
		{
			Class7.class8_0.bool_6 = this.SCAUT.Checked;
			Class7.class8_0.string_0 = Conversions.ToString(this.SCI.SelectedIndex);
			Class7.class8_0.bool_7 = this.CAMAUT.Checked;
			Class7.class8_0.int_0 = this.CAMI.SelectedIndex;
			Class7.class8_0.bool_8 = this.MICAUT.Checked;
			Class7.class8_0.bool_2 = this.LOGCONNECTIONS.Checked;
			Class7.class8_0.bool_3 = this.LOGLERR.Checked;
			Class7.class8_0.bool_4 = this.LOGRERR.Checked;
			Class7.class8_0.bool_5 = this.LOGMSGS.Checked;
			Class7.class8_0.bool_1 = this.LOGLOGIN.Checked;
			Class7.class8_0.bool_0 = this.ShowAlert.Checked;
			Class7.class8_0.int_1 = this.MICI.SelectedIndex;
			Class7.class8_0.int_2 = this.scrI.SelectedIndex;
			Class7.class8_0.method_1();
			this.Close();
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x001FCF9C File Offset: 0x001FB39C
		private void scrI_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x001FCFA0 File Offset: 0x001FB3A0
		private void SCAUT_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.SCAUT.Checked;
			if (flag)
			{
				this.SCI.Enabled = true;
			}
			else
			{
				flag = !this.SCAUT.Checked;
				if (flag)
				{
					this.SCI.Enabled = false;
				}
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x001FCFF0 File Offset: 0x001FB3F0
		private void CAMAUT_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.CAMAUT.Checked;
			if (flag)
			{
				this.CAMI.Enabled = true;
			}
			else
			{
				flag = !this.SCAUT.Checked;
				if (flag)
				{
					this.CAMI.Enabled = false;
				}
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x001FD040 File Offset: 0x001FB440
		private void MICAUT_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.MICAUT.Checked;
			if (flag)
			{
				this.MICI.Enabled = true;
			}
			else
			{
				flag = !this.MICAUT.Checked;
				if (flag)
				{
					this.MICI.Enabled = false;
				}
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x001FD090 File Offset: 0x001FB490
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				bool flag = Class7.form1_0.ColorDialog1.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					Class7.form1_0.L1.RowsDefaultCellStyle.BackColor = Class7.form1_0.ColorDialog1.Color;
					Class7.form1_0.L1.BackgroundColor = Class7.form1_0.ColorDialog1.Color;
				}
			}
			else
			{
				bool flag = !this.CheckBox1.Checked;
				if (flag)
				{
					Class7.form1_0.L1.RowsDefaultCellStyle.BackColor = Color.Black;
					Class7.form1_0.L1.BackgroundColor = Color.Black;
				}
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x001FD14C File Offset: 0x001FB54C
		private void CheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox2.Checked;
			if (@checked)
			{
				bool flag = Class7.form1_0.ColorDialog2.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					Class7.form1_0.L1.RowsDefaultCellStyle.ForeColor = Class7.form1_0.ColorDialog2.Color;
					Class7.form1_0.L1.ForeColor = Class7.form1_0.ColorDialog2.Color;
				}
			}
			else
			{
				bool flag = !this.CheckBox1.Checked;
				if (flag)
				{
					Class7.form1_0.L1.RowsDefaultCellStyle.ForeColor = Color.White;
					Class7.form1_0.L1.ForeColor = Color.White;
				}
			}
		}

		// Token: 0x040001BD RID: 445
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040001BF RID: 447
		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		// Token: 0x040001C0 RID: 448
		[AccessedThroughProperty("ShowAlert")]
		private CheckBox _ShowAlert;

		// Token: 0x040001C1 RID: 449
		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		// Token: 0x040001C2 RID: 450
		[AccessedThroughProperty("LOGMSGS")]
		private CheckBox _LOGMSGS;

		// Token: 0x040001C3 RID: 451
		[AccessedThroughProperty("LOGRERR")]
		private CheckBox _LOGRERR;

		// Token: 0x040001C4 RID: 452
		[AccessedThroughProperty("LOGCONNECTIONS")]
		private CheckBox _LOGCONNECTIONS;

		// Token: 0x040001C5 RID: 453
		[AccessedThroughProperty("LOGLERR")]
		private CheckBox _LOGLERR;

		// Token: 0x040001C6 RID: 454
		[AccessedThroughProperty("LOGLOGIN")]
		private CheckBox _LOGLOGIN;

		// Token: 0x040001C7 RID: 455
		[AccessedThroughProperty("GroupBox3")]
		private GroupBox _GroupBox3;

		// Token: 0x040001C8 RID: 456
		[AccessedThroughProperty("SCAUT")]
		private CheckBox _SCAUT;

		// Token: 0x040001C9 RID: 457
		[AccessedThroughProperty("SCI")]
		private ComboBox _SCI;

		// Token: 0x040001CA RID: 458
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040001CB RID: 459
		[AccessedThroughProperty("GroupBox4")]
		private GroupBox _GroupBox4;

		// Token: 0x040001CC RID: 460
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040001CD RID: 461
		[AccessedThroughProperty("CAMI")]
		private ComboBox _CAMI;

		// Token: 0x040001CE RID: 462
		[AccessedThroughProperty("CAMAUT")]
		private CheckBox _CAMAUT;

		// Token: 0x040001CF RID: 463
		[AccessedThroughProperty("GroupBox5")]
		private GroupBox _GroupBox5;

		// Token: 0x040001D0 RID: 464
		[AccessedThroughProperty("MICI")]
		private ComboBox _MICI;

		// Token: 0x040001D1 RID: 465
		[AccessedThroughProperty("MICAUT")]
		private CheckBox _MICAUT;

		// Token: 0x040001D2 RID: 466
		[AccessedThroughProperty("GroupBox6")]
		private GroupBox _GroupBox6;

		// Token: 0x040001D3 RID: 467
		[AccessedThroughProperty("scrI")]
		private ComboBox _scrI;

		// Token: 0x040001D4 RID: 468
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040001D5 RID: 469
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040001D6 RID: 470
		[AccessedThroughProperty("GroupBox7")]
		private GroupBox _GroupBox7;

		// Token: 0x040001D7 RID: 471
		[AccessedThroughProperty("CheckBox2")]
		private CheckBox _CheckBox2;

		// Token: 0x040001D8 RID: 472
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;
	}
}
