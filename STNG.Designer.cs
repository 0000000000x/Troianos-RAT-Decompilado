namespace Troianos_RAT
{
	// Token: 0x0200001F RID: 31
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class STNG : global::System.Windows.Forms.Form
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x001FB1A8 File Offset: 0x001F95A8
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

		// Token: 0x060003AA RID: 938 RVA: 0x001FB1F8 File Offset: 0x001F95F8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.STNG));
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ShowAlert = new global::System.Windows.Forms.CheckBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.LOGLOGIN = new global::System.Windows.Forms.CheckBox();
			this.LOGCONNECTIONS = new global::System.Windows.Forms.CheckBox();
			this.LOGLERR = new global::System.Windows.Forms.CheckBox();
			this.LOGRERR = new global::System.Windows.Forms.CheckBox();
			this.LOGMSGS = new global::System.Windows.Forms.CheckBox();
			this.GroupBox3 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.SCI = new global::System.Windows.Forms.ComboBox();
			this.SCAUT = new global::System.Windows.Forms.CheckBox();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.CAMI = new global::System.Windows.Forms.ComboBox();
			this.CAMAUT = new global::System.Windows.Forms.CheckBox();
			this.GroupBox5 = new global::System.Windows.Forms.GroupBox();
			this.MICI = new global::System.Windows.Forms.ComboBox();
			this.MICAUT = new global::System.Windows.Forms.CheckBox();
			this.GroupBox6 = new global::System.Windows.Forms.GroupBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.scrI = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox7 = new global::System.Windows.Forms.GroupBox();
			this.CheckBox2 = new global::System.Windows.Forms.CheckBox();
			this.CheckBox1 = new global::System.Windows.Forms.CheckBox();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox6.SuspendLayout();
			this.GroupBox7.SuspendLayout();
			this.SuspendLayout();
			this.GroupBox1.Controls.Add(this.ShowAlert);
			this.GroupBox1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control groupBox = this.GroupBox1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(160, 108);
			groupBox.Location = location;
			this.GroupBox1.Name = "GroupBox1";
			global::System.Windows.Forms.Control groupBox2 = this.GroupBox1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(117, 34);
			groupBox2.Size = size;
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Entrada";
			this.ShowAlert.AutoSize = true;
			global::System.Windows.Forms.Control showAlert = this.ShowAlert;
			location = new global::System.Drawing.Point(8, 13);
			showAlert.Location = location;
			this.ShowAlert.Name = "ShowAlert";
			this.ShowAlert.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control showAlert2 = this.ShowAlert;
			size = new global::System.Drawing.Size(106, 17);
			showAlert2.Size = size;
			this.ShowAlert.TabIndex = 0;
			this.ShowAlert.Text = "Mostrar Bandeira";
			this.ShowAlert.UseVisualStyleBackColor = true;
			this.GroupBox2.Controls.Add(this.LOGLOGIN);
			this.GroupBox2.Controls.Add(this.LOGCONNECTIONS);
			this.GroupBox2.Controls.Add(this.LOGLERR);
			this.GroupBox2.Controls.Add(this.LOGRERR);
			this.GroupBox2.Controls.Add(this.LOGMSGS);
			this.GroupBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.GroupBox2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control groupBox3 = this.GroupBox2;
			location = new global::System.Drawing.Point(160, 3);
			groupBox3.Location = location;
			this.GroupBox2.Name = "GroupBox2";
			global::System.Windows.Forms.Control groupBox4 = this.GroupBox2;
			size = new global::System.Drawing.Size(117, 101);
			groupBox4.Size = size;
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Logs";
			this.LOGLOGIN.AutoSize = true;
			global::System.Windows.Forms.Control loglogin = this.LOGLOGIN;
			location = new global::System.Drawing.Point(8, 14);
			loglogin.Location = location;
			this.LOGLOGIN.Name = "LOGLOGIN";
			this.LOGLOGIN.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control loglogin2 = this.LOGLOGIN;
			size = new global::System.Drawing.Size(68, 17);
			loglogin2.Size = size;
			this.LOGLOGIN.TabIndex = 5;
			this.LOGLOGIN.Text = "Deslogar";
			this.LOGLOGIN.UseVisualStyleBackColor = true;
			this.LOGCONNECTIONS.AutoSize = true;
			global::System.Windows.Forms.Control logconnections = this.LOGCONNECTIONS;
			location = new global::System.Drawing.Point(8, 30);
			logconnections.Location = location;
			this.LOGCONNECTIONS.Name = "LOGCONNECTIONS";
			this.LOGCONNECTIONS.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control logconnections2 = this.LOGCONNECTIONS;
			size = new global::System.Drawing.Size(73, 17);
			logconnections2.Size = size;
			this.LOGCONNECTIONS.TabIndex = 4;
			this.LOGCONNECTIONS.Text = "Conexões";
			this.LOGCONNECTIONS.UseVisualStyleBackColor = true;
			this.LOGLERR.AutoSize = true;
			global::System.Windows.Forms.Control loglerr = this.LOGLERR;
			location = new global::System.Drawing.Point(8, 46);
			loglerr.Location = location;
			this.LOGLERR.Name = "LOGLERR";
			this.LOGLERR.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control loglerr2 = this.LOGLERR;
			size = new global::System.Drawing.Size(78, 17);
			loglerr2.Size = size;
			this.LOGLERR.TabIndex = 3;
			this.LOGLERR.Text = "Listar Erros";
			this.LOGLERR.UseVisualStyleBackColor = true;
			this.LOGRERR.AutoSize = true;
			global::System.Windows.Forms.Control logrerr = this.LOGRERR;
			location = new global::System.Drawing.Point(8, 63);
			logrerr.Location = location;
			this.LOGRERR.Name = "LOGRERR";
			this.LOGRERR.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control logrerr2 = this.LOGRERR;
			size = new global::System.Drawing.Size(95, 17);
			logrerr2.Size = size;
			this.LOGRERR.TabIndex = 2;
			this.LOGRERR.Text = "Erros Remotos";
			this.LOGRERR.UseVisualStyleBackColor = true;
			this.LOGMSGS.AutoSize = true;
			global::System.Windows.Forms.Control logmsgs = this.LOGMSGS;
			location = new global::System.Drawing.Point(8, 80);
			logmsgs.Location = location;
			this.LOGMSGS.Name = "LOGMSGS";
			this.LOGMSGS.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control logmsgs2 = this.LOGMSGS;
			size = new global::System.Drawing.Size(78, 17);
			logmsgs2.Size = size;
			this.LOGMSGS.TabIndex = 1;
			this.LOGMSGS.Text = "Mensagem";
			this.LOGMSGS.UseVisualStyleBackColor = true;
			this.GroupBox3.Controls.Add(this.Label1);
			this.GroupBox3.Controls.Add(this.SCI);
			this.GroupBox3.Controls.Add(this.SCAUT);
			this.GroupBox3.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control groupBox5 = this.GroupBox3;
			location = new global::System.Drawing.Point(5, 3);
			groupBox5.Location = location;
			this.GroupBox3.Name = "GroupBox3";
			global::System.Windows.Forms.Control groupBox6 = this.GroupBox3;
			size = new global::System.Drawing.Size(149, 64);
			groupBox6.Size = size;
			this.GroupBox3.TabIndex = 2;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "Tela Remota";
			this.Label1.AutoSize = true;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(6, 39);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(52, 13);
			label2.Size = size;
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Tamanho";
			this.SCI.BackColor = global::System.Drawing.Color.Black;
			this.SCI.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SCI.Enabled = false;
			this.SCI.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.SCI.ForeColor = global::System.Drawing.Color.White;
			this.SCI.FormattingEnabled = true;
			this.SCI.Items.AddRange(new object[]
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
			global::System.Windows.Forms.Control sci = this.SCI;
			location = new global::System.Drawing.Point(64, 35);
			sci.Location = location;
			this.SCI.Name = "SCI";
			global::System.Windows.Forms.Control sci2 = this.SCI;
			size = new global::System.Drawing.Size(71, 21);
			sci2.Size = size;
			this.SCI.TabIndex = 2;
			this.SCAUT.AutoSize = true;
			global::System.Windows.Forms.Control scaut = this.SCAUT;
			location = new global::System.Drawing.Point(9, 16);
			scaut.Location = location;
			this.SCAUT.Name = "SCAUT";
			this.SCAUT.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control scaut2 = this.SCAUT;
			size = new global::System.Drawing.Size(121, 17);
			scaut2.Size = size;
			this.SCAUT.TabIndex = 1;
			this.SCAUT.Text = "Começo Automatico";
			this.SCAUT.UseVisualStyleBackColor = true;
			this.GroupBox4.Controls.Add(this.Label2);
			this.GroupBox4.Controls.Add(this.CAMI);
			this.GroupBox4.Controls.Add(this.CAMAUT);
			this.GroupBox4.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control groupBox7 = this.GroupBox4;
			location = new global::System.Drawing.Point(5, 70);
			groupBox7.Location = location;
			this.GroupBox4.Name = "GroupBox4";
			global::System.Windows.Forms.Control groupBox8 = this.GroupBox4;
			size = new global::System.Drawing.Size(149, 64);
			groupBox8.Size = size;
			this.GroupBox4.TabIndex = 3;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "WebCam Remota";
			this.Label2.AutoSize = true;
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(6, 39);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(52, 13);
			label4.Size = size;
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Tamanho";
			this.CAMI.BackColor = global::System.Drawing.Color.Black;
			this.CAMI.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CAMI.Enabled = false;
			this.CAMI.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.CAMI.ForeColor = global::System.Drawing.Color.White;
			this.CAMI.FormattingEnabled = true;
			this.CAMI.Items.AddRange(new object[]
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
			global::System.Windows.Forms.Control cami = this.CAMI;
			location = new global::System.Drawing.Point(64, 35);
			cami.Location = location;
			this.CAMI.Name = "CAMI";
			global::System.Windows.Forms.Control cami2 = this.CAMI;
			size = new global::System.Drawing.Size(71, 21);
			cami2.Size = size;
			this.CAMI.TabIndex = 2;
			this.CAMAUT.AutoSize = true;
			global::System.Windows.Forms.Control camaut = this.CAMAUT;
			location = new global::System.Drawing.Point(9, 16);
			camaut.Location = location;
			this.CAMAUT.Name = "CAMAUT";
			this.CAMAUT.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control camaut2 = this.CAMAUT;
			size = new global::System.Drawing.Size(121, 17);
			camaut2.Size = size;
			this.CAMAUT.TabIndex = 1;
			this.CAMAUT.Text = "Começo Automatico";
			this.CAMAUT.UseVisualStyleBackColor = true;
			this.GroupBox5.Controls.Add(this.MICI);
			this.GroupBox5.Controls.Add(this.MICAUT);
			this.GroupBox5.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control groupBox9 = this.GroupBox5;
			location = new global::System.Drawing.Point(5, 139);
			groupBox9.Location = location;
			this.GroupBox5.Name = "GroupBox5";
			global::System.Windows.Forms.Control groupBox10 = this.GroupBox5;
			size = new global::System.Drawing.Size(149, 68);
			groupBox10.Size = size;
			this.GroupBox5.TabIndex = 4;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "Microfone Remoto";
			this.MICI.BackColor = global::System.Drawing.Color.Black;
			this.MICI.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.MICI.Enabled = false;
			this.MICI.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.MICI.ForeColor = global::System.Drawing.Color.White;
			this.MICI.FormattingEnabled = true;
			this.MICI.Items.AddRange(new object[]
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
			global::System.Windows.Forms.Control mici = this.MICI;
			location = new global::System.Drawing.Point(9, 37);
			mici.Location = location;
			this.MICI.Name = "MICI";
			global::System.Windows.Forms.Control mici2 = this.MICI;
			size = new global::System.Drawing.Size(126, 21);
			mici2.Size = size;
			this.MICI.TabIndex = 2;
			this.MICAUT.AutoSize = true;
			global::System.Windows.Forms.Control micaut = this.MICAUT;
			location = new global::System.Drawing.Point(9, 17);
			micaut.Location = location;
			this.MICAUT.Name = "MICAUT";
			this.MICAUT.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control micaut2 = this.MICAUT;
			size = new global::System.Drawing.Size(121, 17);
			micaut2.Size = size;
			this.MICAUT.TabIndex = 1;
			this.MICAUT.Text = "Começo Automatico";
			this.MICAUT.UseVisualStyleBackColor = true;
			this.GroupBox6.Controls.Add(this.Label3);
			this.GroupBox6.Controls.Add(this.scrI);
			this.GroupBox6.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control groupBox11 = this.GroupBox6;
			location = new global::System.Drawing.Point(160, 144);
			groupBox11.Location = location;
			this.GroupBox6.Name = "GroupBox6";
			global::System.Windows.Forms.Control groupBox12 = this.GroupBox6;
			size = new global::System.Drawing.Size(117, 63);
			groupBox12.Size = size;
			this.GroupBox6.TabIndex = 5;
			this.GroupBox6.TabStop = false;
			this.GroupBox6.Text = "Tela";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			global::System.Windows.Forms.Control label5 = this.Label3;
			location = new global::System.Drawing.Point(8, 13);
			label5.Location = location;
			this.Label3.Name = "Label3";
			global::System.Windows.Forms.Control label6 = this.Label3;
			size = new global::System.Drawing.Size(95, 14);
			label6.Size = size;
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Atualizar Rapido";
			this.scrI.BackColor = global::System.Drawing.Color.Black;
			this.scrI.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.scrI.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.scrI.ForeColor = global::System.Drawing.Color.White;
			this.scrI.FormattingEnabled = true;
			this.scrI.Items.AddRange(new object[]
			{
				"Super Rapido",
				"Rapido",
				"Normal",
				"Lento",
				"Bem Lento"
			});
			global::System.Windows.Forms.Control scrI = this.scrI;
			location = new global::System.Drawing.Point(6, 33);
			scrI.Location = location;
			this.scrI.Name = "scrI";
			this.scrI.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			global::System.Windows.Forms.Control scrI2 = this.scrI;
			size = new global::System.Drawing.Size(105, 21);
			scrI2.Size = size;
			this.scrI.TabIndex = 2;
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(5, 218);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(149, 53);
			button2.Size = size;
			this.Button1.TabIndex = 6;
			this.Button1.Text = "Salvar Configurações";
			this.Button1.UseVisualStyleBackColor = false;
			this.GroupBox7.Controls.Add(this.CheckBox2);
			this.GroupBox7.Controls.Add(this.CheckBox1);
			this.GroupBox7.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control groupBox13 = this.GroupBox7;
			location = new global::System.Drawing.Point(160, 212);
			groupBox13.Location = location;
			this.GroupBox7.Name = "GroupBox7";
			global::System.Windows.Forms.Control groupBox14 = this.GroupBox7;
			size = new global::System.Drawing.Size(117, 58);
			groupBox14.Size = size;
			this.GroupBox7.TabIndex = 7;
			this.GroupBox7.TabStop = false;
			this.GroupBox7.Text = "Cores";
			this.CheckBox2.AutoSize = true;
			global::System.Windows.Forms.Control checkBox = this.CheckBox2;
			location = new global::System.Drawing.Point(9, 34);
			checkBox.Location = location;
			this.CheckBox2.Name = "CheckBox2";
			global::System.Windows.Forms.Control checkBox2 = this.CheckBox2;
			size = new global::System.Drawing.Size(87, 17);
			checkBox2.Size = size;
			this.CheckBox2.TabIndex = 1;
			this.CheckBox2.Text = "Cor do Texto";
			this.CheckBox2.UseVisualStyleBackColor = true;
			this.CheckBox1.AutoSize = true;
			global::System.Windows.Forms.Control checkBox3 = this.CheckBox1;
			location = new global::System.Drawing.Point(9, 15);
			checkBox3.Location = location;
			this.CheckBox1.Name = "CheckBox1";
			global::System.Windows.Forms.Control checkBox4 = this.CheckBox1;
			size = new global::System.Drawing.Size(90, 17);
			checkBox4.Size = size;
			this.CheckBox1.TabIndex = 0;
			this.CheckBox1.Text = "Cor do Fundo";
			this.CheckBox1.UseVisualStyleBackColor = true;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			size = new global::System.Drawing.Size(287, 281);
			this.ClientSize = size;
			this.Controls.Add(this.GroupBox7);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.GroupBox6);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.ForeColor = global::System.Drawing.Color.White;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "STNG";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Configurações";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.GroupBox6.ResumeLayout(false);
			this.GroupBox6.PerformLayout();
			this.GroupBox7.ResumeLayout(false);
			this.GroupBox7.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x040001BE RID: 446
		private global::System.ComponentModel.IContainer components;
	}
}
