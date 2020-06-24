namespace Troianos_RAT
{
	// Token: 0x0200000F RID: 15
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class FromLink : global::System.Windows.Forms.Form
	{
		// Token: 0x06000166 RID: 358 RVA: 0x001E6E50 File Offset: 0x001E5250
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

		// Token: 0x06000167 RID: 359 RVA: 0x001E6EA0 File Offset: 0x001E52A0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.FromLink));
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.SuspendLayout();
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(12, 99);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(292, 23);
			button2.Size = size;
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Confirmar";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button3 = this.Button2;
			location = new global::System.Drawing.Point(12, 128);
			button3.Location = location;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(292, 23);
			button4.Size = size;
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Cancelar";
			this.Button2.UseVisualStyleBackColor = false;
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			location = new global::System.Drawing.Point(12, 25);
			textBox.Location = location;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(292, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 2;
			this.TextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.TextBox2.BackColor = global::System.Drawing.Color.Black;
			this.TextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control textBox3 = this.TextBox2;
			location = new global::System.Drawing.Point(12, 64);
			textBox3.Location = location;
			this.TextBox2.Name = "TextBox2";
			global::System.Windows.Forms.Control textBox4 = this.TextBox2;
			size = new global::System.Drawing.Size(292, 20);
			textBox4.Size = size;
			this.TextBox2.TabIndex = 3;
			this.TextBox2.Text = "Arquivo.txt";
			this.TextBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label = this.Label1;
			location = new global::System.Drawing.Point(124, 48);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			size = new global::System.Drawing.Size(79, 13);
			label2.Size = size;
			this.Label1.TabIndex = 4;
			this.Label1.Text = "[ Salvar Em ]";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label3 = this.Label2;
			location = new global::System.Drawing.Point(136, 9);
			label3.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label4 = this.Label2;
			size = new global::System.Drawing.Size(46, 13);
			label4.Size = size;
			this.Label2.TabIndex = 5;
			this.Label2.Text = "[ Link ]";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(322, 165);
			this.ClientSize = size;
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.ForeColor = global::System.Drawing.Color.White;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.Name = "FromLink";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Apartir do Link";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000A8 RID: 168
		private global::System.ComponentModel.IContainer components;
	}
}
