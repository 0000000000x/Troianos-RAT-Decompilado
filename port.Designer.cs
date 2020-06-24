namespace Troianos_RAT
{
	// Token: 0x0200001B RID: 27
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class port : global::System.Windows.Forms.Form
	{
		// Token: 0x06000307 RID: 775 RVA: 0x001F4EA0 File Offset: 0x001F32A0
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

		// Token: 0x06000308 RID: 776 RVA: 0x001F4EF0 File Offset: 0x001F32F0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.port));
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.WaterFX1 = new global::Troianos_RAT.WaterFX();
			this.NumericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown1).BeginInit();
			this.SuspendLayout();
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control label = this.Label1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(17, 122);
			label.Location = location;
			this.Label1.Name = "Label1";
			global::System.Windows.Forms.Control label2 = this.Label1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(58, 16);
			label2.Size = size;
			this.Label1.TabIndex = 0;
			this.Label1.Text = "[ Porta ]";
			this.Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(18, 155);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(175, 26);
			button2.Size = size;
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Iniciar";
			this.Button1.UseVisualStyleBackColor = false;
			this.Button2.BackColor = global::System.Drawing.Color.Transparent;
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.Button2.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button3 = this.Button2;
			location = new global::System.Drawing.Point(18, 187);
			button3.Location = location;
			this.Button2.Name = "Button2";
			global::System.Windows.Forms.Control button4 = this.Button2;
			size = new global::System.Drawing.Size(175, 26);
			button4.Size = size;
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Fechar";
			this.Button2.UseVisualStyleBackColor = false;
			this.WaterFX1.BackColor = global::System.Drawing.Color.Transparent;
			this.WaterFX1.ImageBitmap = (global::System.Drawing.Bitmap)componentResourceManager.GetObject("WaterFX1.ImageBitmap");
			global::System.Windows.Forms.Control waterFX = this.WaterFX1;
			location = new global::System.Drawing.Point(41, 8);
			waterFX.Location = location;
			this.WaterFX1.Name = "WaterFX1";
			this.WaterFX1.Scale = 1;
			global::System.Windows.Forms.Control waterFX2 = this.WaterFX1;
			size = new global::System.Drawing.Size(135, 100);
			waterFX2.Size = size;
			this.WaterFX1.TabIndex = 4;
			this.NumericUpDown1.BackColor = global::System.Drawing.Color.Black;
			this.NumericUpDown1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.NumericUpDown1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control numericUpDown = this.NumericUpDown1;
			location = new global::System.Drawing.Point(81, 122);
			numericUpDown.Location = location;
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.NumericUpDown1;
			decimal num = new decimal(new int[]
			{
				99999999,
				0,
				0,
				0
			});
			numericUpDown2.Maximum = num;
			this.NumericUpDown1.Name = "NumericUpDown1";
			global::System.Windows.Forms.Control numericUpDown3 = this.NumericUpDown1;
			size = new global::System.Drawing.Size(112, 20);
			numericUpDown3.Size = size;
			this.NumericUpDown1.TabIndex = 0;
			this.NumericUpDown1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.NumericUpDown1;
			num = new decimal(new int[]
			{
				1177,
				0,
				0,
				0
			});
			numericUpDown4.Value = num;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaptionText;
			size = new global::System.Drawing.Size(210, 232);
			this.ClientSize = size;
			this.Controls.Add(this.NumericUpDown1);
			this.Controls.Add(this.WaterFX1);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label1);
			this.ForeColor = global::System.Drawing.Color.White;
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "port";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Porta";
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDown1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x04000173 RID: 371
		private global::System.ComponentModel.IContainer components;
	}
}
