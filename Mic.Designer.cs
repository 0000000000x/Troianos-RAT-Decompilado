namespace Troianos_RAT
{
	// Token: 0x02000016 RID: 22
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Mic : global::System.Windows.Forms.Form
	{
		// Token: 0x0600029D RID: 669 RVA: 0x001F15CC File Offset: 0x001EF9CC
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x001F161C File Offset: 0x001EFA1C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.Mic));
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.vmethod_4 = new global::System.Windows.Forms.Timer(this.components);
			this.ComboBox2 = new global::System.Windows.Forms.ComboBox();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			this.ComboBox1.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ComboBox1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.ComboBox1.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox = this.ComboBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 12);
			comboBox.Location = location;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(224, 21);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 0;
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(12, 67);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(224, 38);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Iniciar";
			this.Button1.UseVisualStyleBackColor = false;
			this.vmethod_4.Enabled = true;
			this.vmethod_4.Interval = 50;
			this.ComboBox2.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ComboBox2.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Items.AddRange(new object[]
			{
				"4 kb 8bit",
				"6 kb 8bit",
				"8 kb 8bit",
				"8 kb 16bit",
				"12 kb 16bit",
				"16 kb 16bit",
				"20 kb 16bit",
				"24 kb 16bit"
			});
			global::System.Windows.Forms.Control comboBox3 = this.ComboBox2;
			location = new global::System.Drawing.Point(12, 39);
			comboBox3.Location = location;
			this.ComboBox2.Name = "ComboBox2";
			global::System.Windows.Forms.Control comboBox4 = this.ComboBox2;
			size = new global::System.Drawing.Size(224, 21);
			comboBox4.Size = size;
			this.ComboBox2.TabIndex = 3;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			location = new global::System.Drawing.Point(0, 117);
			progressBar.Location = location;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			size = new global::System.Drawing.Size(250, 10);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 4;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(250, 127);
			this.ClientSize = size;
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.ComboBox2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.ComboBox1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Mic";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Microfone";
			this.ResumeLayout(false);
		}

		// Token: 0x04000143 RID: 323
		private global::System.ComponentModel.IContainer components;
	}
}
