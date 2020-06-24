namespace Troianos_RAT
{
	// Token: 0x02000018 RID: 24
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class notf : global::System.Windows.Forms.Form
	{
		// Token: 0x060002BF RID: 703 RVA: 0x001F27AC File Offset: 0x001F0BAC
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

		// Token: 0x060002C0 RID: 704 RVA: 0x001F27FC File Offset: 0x001F0BFC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.p = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.p).BeginInit();
			this.SuspendLayout();
			this.p.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.p.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control p = this.p;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			p.Location = location;
			this.p.Name = "p";
			global::System.Windows.Forms.Control p2 = this.p;
			global::System.Drawing.Size size = new global::System.Drawing.Size(268, 130);
			p2.Size = size;
			this.p.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.p.TabIndex = 0;
			this.p.TabStop = false;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(268, 130);
			this.ClientSize = size;
			this.Controls.Add(this.p);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.Name = "notf";
			this.Opacity = 0.8;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "notf";
			this.TopMost = true;
			this.TransparencyKey = global::System.Drawing.Color.Transparent;
			((global::System.ComponentModel.ISupportInitialize)this.p).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x04000154 RID: 340
		private global::System.ComponentModel.IContainer components;
	}
}
