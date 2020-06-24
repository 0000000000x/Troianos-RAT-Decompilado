namespace Troianos_RAT
{
	// Token: 0x02000010 RID: 16
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class FURL : global::System.Windows.Forms.Form
	{
		// Token: 0x0600017A RID: 378 RVA: 0x001E7774 File Offset: 0x001E5B74
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

		// Token: 0x0600017B RID: 379 RVA: 0x001E77C4 File Offset: 0x001E5BC4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.FURL));
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TextBox2 = new global::System.Windows.Forms.TextBox();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.SuspendLayout();
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label = this.Label2;
			global::System.Drawing.Point location = new global::System.Drawing.Point(136, 10);
			label.Location = location;
			this.Label2.Name = "Label2";
			global::System.Windows.Forms.Control label2 = this.Label2;
			global::System.Drawing.Size size = new global::System.Drawing.Size(46, 13);
			label2.Size = size;
			this.Label2.TabIndex = 11;
			this.Label2.Text = "[ Link ]";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Tahoma", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label3 = this.Label1;
			location = new global::System.Drawing.Point(116, 49);
			label3.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label4 = this.Label1;
			size = new global::System.Drawing.Size(93, 13);
			label4.Size = size;
			this.Label1.TabIndex = 10;
			this.Label1.Text = "[ Executar Em ]";
			this.TextBox2.BackColor = global::System.Drawing.Color.Black;
			this.TextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control textBox = this.TextBox2;
			location = new global::System.Drawing.Point(12, 65);
			textBox.Location = location;
			this.TextBox2.Name = "TextBox2";
			global::System.Windows.Forms.Control textBox2 = this.TextBox2;
			size = new global::System.Drawing.Size(292, 20);
			textBox2.Size = size;
			this.TextBox2.TabIndex = 9;
			this.TextBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control textBox3 = this.TextBox1;
			location = new global::System.Drawing.Point(12, 26);
			textBox3.Location = location;
			this.TextBox1.Name = "TextBox1";
			global::System.Windows.Forms.Control textBox4 = this.TextBox1;
			size = new global::System.Drawing.Size(292, 20);
			textBox4.Size = size;
			this.TextBox1.TabIndex = 8;
			this.TextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button2;
			location = new global::System.Drawing.Point(12, 129);
			button.Location = location;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button2 = this.Button2;
			size = new global::System.Drawing.Size(292, 23);
			button2.Size = size;
			this.Button2.TabIndex = 7;
			this.Button2.Text = "Cancelar";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button3 = this.Button1;
			location = new global::System.Drawing.Point(12, 100);
			button3.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button4 = this.Button1;
			size = new global::System.Drawing.Size(292, 23);
			button4.Size = size;
			this.Button1.TabIndex = 6;
			this.Button1.Text = "Confirmar";
			this.Button1.UseVisualStyleBackColor = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(317, 166);
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
			this.Name = "FURL";
			this.RightToLeftLayout = true;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Apartir do Link";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000B1 RID: 177
		private global::System.ComponentModel.IContainer components;
	}
}
