namespace Troianos_RAT
{
	// Token: 0x0200001D RID: 29
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class sc : global::System.Windows.Forms.Form
	{
		// Token: 0x06000332 RID: 818 RVA: 0x001F6370 File Offset: 0x001F4770
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

		// Token: 0x06000333 RID: 819 RVA: 0x001F63C0 File Offset: 0x001F47C0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.sc));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox2 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox3 = new global::System.Windows.Forms.CheckBox();
			this.vmethod_16 = new global::System.Windows.Forms.Timer(this.components);
			this.vmethod_12 = new global::System.Windows.Forms.Timer(this.components);
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.p = new global::System.Windows.Forms.PictureBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.p).BeginInit();
			this.SuspendLayout();
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.ComboBox1);
			this.Panel1.Controls.Add(this.CheckBox1);
			this.Panel1.Controls.Add(this.CheckBox2);
			this.Panel1.Controls.Add(this.CheckBox3);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			global::System.Windows.Forms.Control panel = this.Panel1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(440, 27);
			panel2.Size = size;
			this.Panel1.TabIndex = 0;
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(2, 1);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(75, 22);
			button2.Size = size;
			this.Button1.TabIndex = 5;
			this.Button1.Text = "Iniciar";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(82, 5);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(67, 14);
			label2.Size = size;
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Qualidade :";
			this.ComboBox1.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.ComboBox1.ForeColor = global::System.Drawing.Color.White;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[]
			{
				"%100",
				"%95",
				"%90",
				"%85",
				"%80",
				"%75",
				"%70",
				"%65",
				"%60",
				"%55",
				"%50"
			});
			global::System.Windows.Forms.Control comboBox = this.ComboBox1;
			location = new global::System.Drawing.Point(149, 1);
			comboBox.Location = location;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.Control comboBox2 = this.ComboBox1;
			size = new global::System.Drawing.Size(78, 21);
			comboBox2.Size = size;
			this.ComboBox1.TabIndex = 3;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CheckBox1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control checkBox = this.CheckBox1;
			location = new global::System.Drawing.Point(238, 5);
			checkBox.Location = location;
			this.CheckBox1.Name = "CheckBox1";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			size = new global::System.Drawing.Size(55, 17);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 2;
			this.CheckBox1.Text = "Mouse";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.CheckBox2.AutoSize = true;
			this.CheckBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CheckBox2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control checkBox3 = this.CheckBox2;
			location = new global::System.Drawing.Point(296, 5);
			checkBox3.Location = location;
			this.CheckBox2.Name = "CheckBox2";
			global::System.Windows.Forms.Control checkBox4 = this.CheckBox2;
			size = new global::System.Drawing.Size(62, 17);
			checkBox4.Size = size;
			this.CheckBox2.TabIndex = 1;
			this.CheckBox2.Text = "Teclado";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CheckBox3.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control checkBox5 = this.CheckBox3;
			location = new global::System.Drawing.Point(370, 5);
			checkBox5.Location = location;
			this.CheckBox3.Name = "CheckBox3";
			global::System.Windows.Forms.Control checkBox6 = this.CheckBox3;
			size = new global::System.Drawing.Size(55, 17);
			checkBox6.Size = size;
			this.CheckBox3.TabIndex = 0;
			this.CheckBox3.Text = "Gravar";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.vmethod_16.Enabled = true;
			this.vmethod_16.Interval = 10;
			this.vmethod_12.Enabled = true;
			this.vmethod_12.Interval = 1000;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			location = new global::System.Drawing.Point(0, 246);
			progressBar.Location = location;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			size = new global::System.Drawing.Size(440, 9);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 1;
			this.p.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control p = this.p;
			location = new global::System.Drawing.Point(0, 27);
			p.Location = location;
			this.p.Name = "p";
			global::System.Windows.Forms.Control p2 = this.p;
			size = new global::System.Drawing.Size(440, 228);
			p2.Size = size;
			this.p.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.p.TabIndex = 2;
			this.p.TabStop = false;
			this.Button2.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.Button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			global::System.Windows.Forms.Control button3 = this.Button2;
			location = new global::System.Drawing.Point(209, 27);
			button3.Location = location;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(10, 12);
			button4.Size = size;
			this.Button2.TabIndex = 3;
			this.Button2.UseVisualStyleBackColor = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(440, 255);
			this.ClientSize = size;
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.p);
			this.Controls.Add(this.Panel1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "sc";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tela Remota";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.p).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000186 RID: 390
		private global::System.ComponentModel.IContainer components;
	}
}
