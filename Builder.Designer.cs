namespace Troianos_RAT
{
	// Token: 0x0200000A RID: 10
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Builder : global::System.Windows.Forms.Form
	{
		// Token: 0x0600006E RID: 110 RVA: 0x001DC3A8 File Offset: 0x001DA7A8
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

		// Token: 0x0600006F RID: 111 RVA: 0x001DC3F8 File Offset: 0x001DA7F8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.Builder));
			this.host = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.port = new global::System.Windows.Forms.NumericUpDown();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Idr = new global::System.Windows.Forms.CheckBox();
			this.dir = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.VN = new global::System.Windows.Forms.TextBox();
			this.bsod = new global::System.Windows.Forms.CheckBox();
			this.T1 = new global::System.Windows.Forms.TextBox();
			this.Isf = new global::System.Windows.Forms.CheckBox();
			this.Isu = new global::System.Windows.Forms.CheckBox();
			this.klen = new global::System.Windows.Forms.NumericUpDown();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.exe = new global::System.Windows.Forms.TextBox();
			this.LinkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.WaterFX1 = new global::Troianos_RAT.WaterFX();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.LinkLabel2 = new global::System.Windows.Forms.LinkLabel();
			((global::System.ComponentModel.ISupportInitialize)this.port).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.klen).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.SuspendLayout();
			this.host.BackColor = global::System.Drawing.Color.Black;
			this.host.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.host.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.host.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control host = this.host;
			global::System.Drawing.Point location = new global::System.Drawing.Point(11, 28);
			host.Location = location;
			this.host.Name = "host";
			global::System.Windows.Forms.Control host2 = this.host;
			global::System.Drawing.Size size = new global::System.Drawing.Size(203, 20);
			host2.Size = size;
			this.host.TabIndex = 0;
			this.host.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(70, 11);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(92, 14);
			label2.Size = size;
			this.Label1.TabIndex = 1;
			this.Label1.Text = "[ Servidor DNS ]";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(232, 8);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(50, 14);
			label4.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "[ Porta ]";
			this.port.BackColor = global::System.Drawing.Color.Black;
			this.port.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.port.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control port = this.port;
			location = new global::System.Drawing.Point(221, 28);
			port.Location = location;
			global::System.Windows.Forms.NumericUpDown port2 = this.port;
			decimal num = new decimal(new int[]
			{
				60000,
				0,
				0,
				0
			});
			port2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown port3 = this.port;
			num = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			port3.Minimum = num;
			this.port.Name = "port";
			global::System.Windows.Forms.Control port4 = this.port;
			size = new global::System.Drawing.Size(78, 20);
			port4.Size = size;
			this.port.TabIndex = 3;
			this.port.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown port5 = this.port;
			num = new decimal(new int[]
			{
				1177,
				0,
				0,
				0
			});
			port5.Value = num;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label5 = this.Label3;
			location = new global::System.Drawing.Point(52, 103);
			label5.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(126, 14);
			label6.Size = size;
			this.Label3.TabIndex = 4;
			this.Label3.Text = "[ Nome do Processo ]";
			this.Idr.AutoSize = true;
			this.Idr.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Idr.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.Idr.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control idr = this.Idr;
			location = new global::System.Drawing.Point(311, 73);
			idr.Location = location;
			this.Idr.Name = "Idr";
			global::System.Windows.Forms.Control idr2 = this.Idr;
			size = new global::System.Drawing.Size(134, 18);
			idr2.Size = size;
			this.Idr.TabIndex = 14;
			this.Idr.Text = "Adicionar Processo";
			this.Idr.UseVisualStyleBackColor = true;
			this.dir.BackColor = global::System.Drawing.Color.Black;
			this.dir.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dir.Enabled = false;
			this.dir.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.dir.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dir.ForeColor = global::System.Drawing.Color.White;
			this.dir.FormattingEnabled = true;
			this.dir.Items.AddRange(new object[]
			{
				"%TEMP%",
				"%AppData%",
				"%UserProfile%",
				"%AllUsersProfile%",
				"%WinDir%"
			});
			global::System.Windows.Forms.Control dir = this.dir;
			location = new global::System.Drawing.Point(11, 171);
			dir.Location = location;
			this.dir.Name = "dir";
			global::System.Windows.Forms.Control dir2 = this.dir;
			size = new global::System.Drawing.Size(205, 22);
			dir2.Size = size;
			this.dir.TabIndex = 7;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label7 = this.Label4;
			location = new global::System.Drawing.Point(78, 152);
			label7.Location = location;
			this.Label4.Name = "Label4";
			global::System.Windows.Forms.Control label8 = this.Label4;
			size = new global::System.Drawing.Size(69, 14);
			label8.Size = size;
			this.Label4.TabIndex = 6;
			this.Label4.Text = "[ Diretorio ]";
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.Font = new global::System.Drawing.Font("Arial Black", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(312, 143);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(168, 51);
			button2.Size = size;
			this.Button1.TabIndex = 6;
			this.Button1.Text = "Criar Servidor";
			this.Button1.UseVisualStyleBackColor = false;
			this.CheckBox1.AutoSize = true;
			this.CheckBox1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.CheckBox1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CheckBox1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control checkBox = this.CheckBox1;
			location = new global::System.Drawing.Point(311, 12);
			checkBox.Location = location;
			this.CheckBox1.Name = "CheckBox1";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox1;
			size = new global::System.Drawing.Size(56, 18);
			checkBox2.Size = size;
			this.CheckBox1.TabIndex = 7;
			this.CheckBox1.Text = "Icone";
			this.CheckBox1.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label9 = this.Label5;
			location = new global::System.Drawing.Point(62, 54);
			label9.Location = location;
			this.Label5.Name = "Label5";
			global::System.Windows.Forms.Control label10 = this.Label5;
			size = new global::System.Drawing.Size(107, 14);
			label10.Size = size;
			this.Label5.TabIndex = 9;
			this.Label5.Text = "[ Nome da Vitima ]";
			this.VN.BackColor = global::System.Drawing.Color.Black;
			this.VN.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.VN.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.VN.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control vn = this.VN;
			location = new global::System.Drawing.Point(11, 71);
			vn.Location = location;
			this.VN.Name = "VN";
			global::System.Windows.Forms.Control vn2 = this.VN;
			size = new global::System.Drawing.Size(205, 20);
			vn2.Size = size;
			this.VN.TabIndex = 10;
			this.VN.Text = "Lammer";
			this.VN.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.bsod.AutoSize = true;
			this.bsod.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.bsod.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.bsod.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control bsod = this.bsod;
			location = new global::System.Drawing.Point(311, 35);
			bsod.Location = location;
			this.bsod.Name = "bsod";
			global::System.Windows.Forms.Control bsod2 = this.bsod;
			size = new global::System.Drawing.Size(131, 18);
			bsod2.Size = size;
			this.bsod.TabIndex = 11;
			this.bsod.Text = "Proteger Processo";
			this.bsod.UseVisualStyleBackColor = true;
			this.T1.BackColor = global::System.Drawing.Color.Black;
			this.T1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.T1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			global::System.Windows.Forms.Control t = this.T1;
			location = new global::System.Drawing.Point(399, 324);
			t.Location = location;
			this.T1.Multiline = true;
			this.T1.Name = "T1";
			global::System.Windows.Forms.Control t2 = this.T1;
			size = new global::System.Drawing.Size(100, 20);
			t2.Size = size;
			this.T1.TabIndex = 12;
			this.T1.Visible = false;
			this.Isf.AutoSize = true;
			this.Isf.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Isf.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Isf.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control isf = this.Isf;
			location = new global::System.Drawing.Point(311, 54);
			isf.Location = location;
			this.Isf.Name = "Isf";
			global::System.Windows.Forms.Control isf2 = this.Isf;
			size = new global::System.Drawing.Size(134, 18);
			isf2.Size = size;
			this.Isf.TabIndex = 13;
			this.Isf.Text = "Iniciar com Sistema";
			this.Isf.UseVisualStyleBackColor = true;
			this.Isu.AutoSize = true;
			this.Isu.Checked = true;
			this.Isu.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.Isu.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Isu.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Isu.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control isu = this.Isu;
			location = new global::System.Drawing.Point(311, 93);
			isu.Location = location;
			this.Isu.Name = "Isu";
			global::System.Windows.Forms.Control isu2 = this.Isu;
			size = new global::System.Drawing.Size(148, 18);
			isu2.Size = size;
			this.Isu.TabIndex = 14;
			this.Isu.Text = "Registrar no Msconfig";
			this.Isu.UseVisualStyleBackColor = true;
			this.klen.BackColor = global::System.Drawing.Color.Black;
			this.klen.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.klen.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control klen = this.klen;
			location = new global::System.Drawing.Point(387, 116);
			klen.Location = location;
			global::System.Windows.Forms.NumericUpDown klen2 = this.klen;
			num = new decimal(new int[]
			{
				512,
				0,
				0,
				0
			});
			klen2.Maximum = num;
			global::System.Windows.Forms.NumericUpDown klen3 = this.klen;
			num = new decimal(new int[]
			{
				5,
				0,
				0,
				0
			});
			klen3.Minimum = num;
			this.klen.Name = "klen";
			global::System.Windows.Forms.Control klen4 = this.klen;
			size = new global::System.Drawing.Size(93, 20);
			klen4.Size = size;
			this.klen.TabIndex = 15;
			this.klen.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown klen5 = this.klen;
			num = new decimal(new int[]
			{
				20,
				0,
				0,
				0
			});
			klen5.Value = num;
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label11 = this.Label6;
			location = new global::System.Drawing.Point(310, 118);
			label11.Location = location;
			this.Label6.Name = "Label6";
			global::System.Windows.Forms.Control label12 = this.Label6;
			size = new global::System.Drawing.Size(71, 14);
			label12.Size = size;
			this.Label6.TabIndex = 16;
			this.Label6.Text = "[ Tamanho ]";
			this.exe.BackColor = global::System.Drawing.Color.Black;
			this.exe.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.exe.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.exe.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control exe = this.exe;
			location = new global::System.Drawing.Point(11, 122);
			exe.Location = location;
			this.exe.Name = "exe";
			global::System.Windows.Forms.Control exe2 = this.exe;
			size = new global::System.Drawing.Size(205, 20);
			exe2.Size = size;
			this.exe.TabIndex = 17;
			this.exe.Text = "Trojan.exe";
			this.exe.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.ForeColor = global::System.Drawing.Color.White;
			this.LinkLabel1.LinkColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control linkLabel = this.LinkLabel1;
			location = new global::System.Drawing.Point(232, 64);
			linkLabel.Location = location;
			this.LinkLabel1.Name = "LinkLabel1";
			global::System.Windows.Forms.Control linkLabel2 = this.LinkLabel1;
			size = new global::System.Drawing.Size(51, 13);
			linkLabel2.Size = size;
			this.LinkLabel1.TabIndex = 19;
			this.LinkLabel1.TabStop = true;
			this.LinkLabel1.Text = "Troianos ";
			this.WaterFX1.BackColor = global::System.Drawing.Color.Transparent;
			this.WaterFX1.ImageBitmap = (global::System.Drawing.Bitmap)componentResourceManager.GetObject("WaterFX1.ImageBitmap");
			global::System.Windows.Forms.Control waterFX = this.WaterFX1;
			location = new global::System.Drawing.Point(217, 109);
			waterFX.Location = location;
			this.WaterFX1.Name = "WaterFX1";
			this.WaterFX1.Scale = 1;
			global::System.Windows.Forms.Control waterFX2 = this.WaterFX1;
			size = new global::System.Drawing.Size(93, 82);
			waterFX2.Size = size;
			this.WaterFX1.TabIndex = 18;
			this.PictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			global::System.Windows.Forms.Control pictureBox = this.PictureBox1;
			location = new global::System.Drawing.Point(444, 8);
			pictureBox.Location = location;
			this.PictureBox1.Name = "PictureBox1";
			global::System.Windows.Forms.Control pictureBox2 = this.PictureBox1;
			size = new global::System.Drawing.Size(36, 31);
			pictureBox2.Size = size;
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 8;
			this.PictureBox1.TabStop = false;
			this.LinkLabel2.AutoSize = true;
			this.LinkLabel2.ForeColor = global::System.Drawing.Color.White;
			this.LinkLabel2.LinkColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control linkLabel3 = this.LinkLabel2;
			location = new global::System.Drawing.Point(232, 83);
			linkLabel3.Location = location;
			this.LinkLabel2.Name = "LinkLabel2";
			global::System.Windows.Forms.Control linkLabel4 = this.LinkLabel2;
			size = new global::System.Drawing.Size(50, 13);
			linkLabel4.Size = size;
			this.LinkLabel2.TabIndex = 20;
			this.LinkLabel2.TabStop = true;
			this.LinkLabel2.Text = "FeedHax";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(492, 207);
			this.ClientSize = size;
			this.Controls.Add(this.LinkLabel2);
			this.Controls.Add(this.LinkLabel1);
			this.Controls.Add(this.WaterFX1);
			this.Controls.Add(this.exe);
			this.Controls.Add(this.Idr);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.dir);
			this.Controls.Add(this.klen);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Isu);
			this.Controls.Add(this.Isf);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.T1);
			this.Controls.Add(this.bsod);
			this.Controls.Add(this.VN);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.CheckBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.port);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.host);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Builder";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Criar Servidor";
			((global::System.ComponentModel.ISupportInitialize)this.port).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.klen).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000037 RID: 55
		private global::System.ComponentModel.IContainer components;
	}
}
