namespace Troianos_RAT
{
	// Token: 0x02000011 RID: 17
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class kl : global::System.Windows.Forms.Form
	{
		// Token: 0x06000191 RID: 401 RVA: 0x001E805C File Offset: 0x001E645C
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

		// Token: 0x06000192 RID: 402 RVA: 0x001E80AC File Offset: 0x001E64AC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.kl));
			this.ProgressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.TFind = new global::System.Windows.Forms.ToolStripTextBox();
			this.T1 = new global::System.Windows.Forms.RichTextBox();
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SelectAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.ProgressBar1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control progressBar = this.ProgressBar1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 322);
			progressBar.Location = location;
			this.ProgressBar1.Name = "ProgressBar1";
			global::System.Windows.Forms.Control progressBar2 = this.ProgressBar1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(641, 10);
			progressBar2.Size = size;
			this.ProgressBar1.TabIndex = 0;
			this.MenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem1,
				this.ToolStripMenuItem2,
				this.TFind
			});
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
			location = new global::System.Drawing.Point(0, 0);
			menuStrip.Location = location;
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			size = new global::System.Drawing.Size(641, 27);
			menuStrip2.Size = size;
			this.MenuStrip1.TabIndex = 1;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ToolStripMenuItem1.BackColor = global::System.Drawing.Color.Black;
			this.ToolStripMenuItem1.ForeColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem = this.ToolStripMenuItem1;
			size = new global::System.Drawing.Size(65, 23);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem1.Text = "Atualizar";
			this.ToolStripMenuItem2.ForeColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem2 = this.ToolStripMenuItem2;
			size = new global::System.Drawing.Size(70, 23);
			toolStripMenuItem2.Size = size;
			this.ToolStripMenuItem2.Text = "Encontrar";
			this.TFind.BackColor = global::System.Drawing.Color.Black;
			this.TFind.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TFind.ForeColor = global::System.Drawing.Color.White;
			this.TFind.Name = "TFind";
			global::System.Windows.Forms.ToolStripControlHost tfind = this.TFind;
			size = new global::System.Drawing.Size(150, 23);
			tfind.Size = size;
			this.TFind.Text = "...";
			this.T1.BackColor = global::System.Drawing.Color.Black;
			this.T1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.T1.ContextMenuStrip = this.ContextMenuStrip1;
			this.T1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.T1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control t = this.T1;
			location = new global::System.Drawing.Point(0, 27);
			t.Location = location;
			this.T1.Name = "T1";
			global::System.Windows.Forms.Control t2 = this.T1;
			size = new global::System.Drawing.Size(641, 295);
			t2.Size = size;
			this.T1.TabIndex = 2;
			this.T1.Text = "";
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CopyToolStripMenuItem,
				this.SelectAllToolStripMenuItem
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(160, 70);
			contextMenuStrip.Size = size;
			this.CopyToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources.Untitled;
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyToolStripMenuItem = this.CopyToolStripMenuItem;
			size = new global::System.Drawing.Size(159, 22);
			copyToolStripMenuItem.Size = size;
			this.CopyToolStripMenuItem.Text = "Copiar";
			this.SelectAllToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources.chk;
			this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem selectAllToolStripMenuItem = this.SelectAllToolStripMenuItem;
			size = new global::System.Drawing.Size(159, 22);
			selectAllToolStripMenuItem.Size = size;
			this.SelectAllToolStripMenuItem.Text = "Selecionar Tudo";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			size = new global::System.Drawing.Size(641, 332);
			this.ClientSize = size;
			this.Controls.Add(this.T1);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "kl";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Capturar Digitos";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000BA RID: 186
		private global::System.ComponentModel.IContainer components;
	}
}
