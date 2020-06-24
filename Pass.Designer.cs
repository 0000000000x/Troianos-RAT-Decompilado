namespace Troianos_RAT
{
	// Token: 0x0200001A RID: 26
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Pass : global::System.Windows.Forms.Form
	{
		// Token: 0x060002CE RID: 718 RVA: 0x001F315C File Offset: 0x001F155C
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

		// Token: 0x060002CF RID: 719 RVA: 0x001F31AC File Offset: 0x001F15AC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.Pass));
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.CopyUseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyPassToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopySiteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyALLToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAllToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.AreaDeTransferenciaToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EmDiscoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FindToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.MenuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.L1 = new global::Troianos_RAT.GClass9();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.ContextMenuStrip1.SuspendLayout();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			this.ContextMenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CopyUseToolStripMenuItem,
				this.CopyPassToolStripMenuItem,
				this.CopySiteToolStripMenuItem,
				this.CopyALLToolStripMenuItem,
				this.SaveAllToolStripMenuItem,
				this.FindToolStripMenuItem
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(156, 158);
			contextMenuStrip.Size = size;
			this.CopyUseToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.CopyUseToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources.Untitled;
			this.CopyUseToolStripMenuItem.Name = "CopyUseToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyUseToolStripMenuItem = this.CopyUseToolStripMenuItem;
			size = new global::System.Drawing.Size(155, 22);
			copyUseToolStripMenuItem.Size = size;
			this.CopyUseToolStripMenuItem.Text = "Copiar Usuario ";
			this.CopyPassToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.CopyPassToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources.Untitled;
			this.CopyPassToolStripMenuItem.Name = "CopyPassToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyPassToolStripMenuItem = this.CopyPassToolStripMenuItem;
			size = new global::System.Drawing.Size(155, 22);
			copyPassToolStripMenuItem.Size = size;
			this.CopyPassToolStripMenuItem.Text = "Copiar Senha";
			this.CopySiteToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.CopySiteToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources.Untitled;
			this.CopySiteToolStripMenuItem.Name = "CopySiteToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copySiteToolStripMenuItem = this.CopySiteToolStripMenuItem;
			size = new global::System.Drawing.Size(155, 22);
			copySiteToolStripMenuItem.Size = size;
			this.CopySiteToolStripMenuItem.Text = "Copiar Site";
			this.CopyALLToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.CopyALLToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources.Untitled;
			this.CopyALLToolStripMenuItem.Name = "CopyALLToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyALLToolStripMenuItem = this.CopyALLToolStripMenuItem;
			size = new global::System.Drawing.Size(155, 22);
			copyALLToolStripMenuItem.Size = size;
			this.CopyALLToolStripMenuItem.Text = "Copiar Tudo";
			this.SaveAllToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.AreaDeTransferenciaToolStripMenuItem,
				this.EmDiscoToolStripMenuItem
			});
			this.SaveAllToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.SaveAllToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources._1332437623_Save;
			this.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem saveAllToolStripMenuItem = this.SaveAllToolStripMenuItem;
			size = new global::System.Drawing.Size(155, 22);
			saveAllToolStripMenuItem.Size = size;
			this.SaveAllToolStripMenuItem.Text = "Salvar Tudo";
			this.AreaDeTransferenciaToolStripMenuItem.BackColor = global::System.Drawing.Color.Black;
			this.AreaDeTransferenciaToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources._1332437623_Save;
			this.AreaDeTransferenciaToolStripMenuItem.ImageTransparentColor = global::System.Drawing.Color.Transparent;
			this.AreaDeTransferenciaToolStripMenuItem.Name = "AreaDeTransferenciaToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem areaDeTransferenciaToolStripMenuItem = this.AreaDeTransferenciaToolStripMenuItem;
			size = new global::System.Drawing.Size(188, 22);
			areaDeTransferenciaToolStripMenuItem.Size = size;
			this.AreaDeTransferenciaToolStripMenuItem.Text = "Area de Transferencia";
			this.EmDiscoToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources._1332437623_Save;
			this.EmDiscoToolStripMenuItem.Name = "EmDiscoToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem emDiscoToolStripMenuItem = this.EmDiscoToolStripMenuItem;
			size = new global::System.Drawing.Size(188, 22);
			emDiscoToolStripMenuItem.Size = size;
			this.EmDiscoToolStripMenuItem.Text = "Em Disco";
			this.FindToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.FindToolStripMenuItem.Image = global::Troianos_RAT.My.Resources.Resources.pesquisa1;
			this.FindToolStripMenuItem.Name = "FindToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem findToolStripMenuItem = this.FindToolStripMenuItem;
			size = new global::System.Drawing.Size(155, 22);
			findToolStripMenuItem.Size = size;
			this.FindToolStripMenuItem.Text = "Procurar";
			this.SaveFileDialog1.FileName = "Senha.txt";
			this.SaveFileDialog1.Filter = "|.txt";
			this.ImageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "1.bmp");
			this.ImageList1.Images.SetKeyName(1, "2.bmp");
			this.ImageList1.Images.SetKeyName(2, "3.bmp");
			this.ImageList1.Images.SetKeyName(3, "4.bmp");
			this.ImageList1.Images.SetKeyName(4, "5.bmp");
			this.ImageList1.Images.SetKeyName(5, "6.bmp");
			this.ImageList1.Images.SetKeyName(6, "7.bmp");
			this.ImageList1.Images.SetKeyName(7, "8.bmp");
			this.ImageList1.Images.SetKeyName(8, "9.bmp");
			this.ImageList1.Images.SetKeyName(9, "10.bmp");
			this.ImageList1.Images.SetKeyName(10, "11.bmp");
			this.ImageList1.Images.SetKeyName(11, "12.bmp");
			this.ImageList1.Images.SetKeyName(12, "13.bmp");
			this.MenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.MenuStrip1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.MenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ToolStripMenuItem1
			});
			global::System.Windows.Forms.Control menuStrip = this.MenuStrip1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 222);
			menuStrip.Location = location;
			this.MenuStrip1.Name = "MenuStrip1";
			global::System.Windows.Forms.Control menuStrip2 = this.MenuStrip1;
			size = new global::System.Drawing.Size(675, 24);
			menuStrip2.Size = size;
			this.MenuStrip1.TabIndex = 1;
			this.MenuStrip1.Text = "MenuStrip1";
			this.ToolStripMenuItem1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ToolStripMenuItem1.ForeColor = global::System.Drawing.Color.White;
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem toolStripMenuItem = this.ToolStripMenuItem1;
			size = new global::System.Drawing.Size(60, 20);
			toolStripMenuItem.Size = size;
			this.ToolStripMenuItem1.Text = "Senhas";
			this.L1.BackColor = global::System.Drawing.SystemColors.InfoText;
			this.L1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader1,
				this.ColumnHeader2,
				this.ColumnHeader3,
				this.ColumnHeader4,
				this.ColumnHeader5
			});
			this.L1.ContextMenuStrip = this.ContextMenuStrip1;
			this.L1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.L1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.L1.ForeColor = global::System.Drawing.Color.White;
			this.L1.FullRowSelect = true;
			global::System.Windows.Forms.Control l = this.L1;
			location = new global::System.Drawing.Point(0, 0);
			l.Location = location;
			this.L1.Name = "L1";
			this.L1.OwnerDraw = true;
			global::System.Windows.Forms.Control l2 = this.L1;
			size = new global::System.Drawing.Size(675, 222);
			l2.Size = size;
			this.L1.SmallImageList = this.ImageList1;
			this.L1.TabIndex = 2;
			this.L1.UseCompatibleStateImageBehavior = false;
			this.L1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader1.Text = "Usuario :";
			this.ColumnHeader1.Width = 115;
			this.ColumnHeader2.Text = "Senha :";
			this.ColumnHeader2.Width = 93;
			this.ColumnHeader3.Text = "Site :";
			this.ColumnHeader3.Width = 93;
			this.ColumnHeader4.Text = "Programa :";
			this.ColumnHeader4.Width = 95;
			this.ColumnHeader5.Text = "Nome da Vitima :";
			this.ColumnHeader5.Width = 275;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(675, 246);
			this.ClientSize = size;
			this.Controls.Add(this.L1);
			this.Controls.Add(this.MenuStrip1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Pass";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Capturar Senhas";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x0400015D RID: 349
		private global::System.ComponentModel.IContainer components;
	}
}
