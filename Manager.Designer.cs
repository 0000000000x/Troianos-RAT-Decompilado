namespace Troianos_RAT
{
	// Token: 0x02000012 RID: 18
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Manager : global::System.Windows.Forms.Form
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x001E8D90 File Offset: 0x001E7190
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

		// Token: 0x060001B2 RID: 434 RVA: 0x001E8DE0 File Offset: 0x001E71E0
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.Manager));
			global::System.Windows.Forms.ListViewItem listViewItem = new global::System.Windows.Forms.ListViewItem("Gerenciador de Arquivo", "Icon_5.bmp");
			global::System.Windows.Forms.ListViewItem listViewItem2 = new global::System.Windows.Forms.ListViewItem("Gerenciador de Tarefas", "Icon_8.bmp");
			global::System.Windows.Forms.ListViewItem listViewItem3 = new global::System.Windows.Forms.ListViewItem("Conexoes", "Icon_178.bmp");
			global::System.Windows.Forms.ListViewItem listViewItem4 = new global::System.Windows.Forms.ListViewItem("Regedit", "Icon_27.bmp");
			global::System.Windows.Forms.ListViewItem listViewItem5 = new global::System.Windows.Forms.ListViewItem("Prompt de Comando", "Icon_1.bmp");
			global::System.Windows.Forms.ListViewItem listViewItem6 = new global::System.Windows.Forms.ListViewItem("Serviços", "Icon_274.bmp");
			this.StatusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.SL = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.pr = new global::System.Windows.Forms.ToolStripProgressBar();
			this.M1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.KillToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.KillDeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RestartProcessToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.vmethod_26 = new global::System.Windows.Forms.Timer(this.components);
			this.ImageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.ContextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.KillConnectionToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.crg = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.RefreshToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.NewValueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.rimg = new global::System.Windows.Forms.ImageList(this.components);
			this.crgk = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.RefreshToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CreateKeyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteSelectedToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuStrip2 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.StopToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PauseToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StartToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuStrip3 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.UPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RefreshToolStripMenuItem2 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RunToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DeleteToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.EditToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RenameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CopyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.PasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DownloadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UploadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.NewEmptyFileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.NewFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.OpenDownloadsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.RarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UnRarToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UploadFromLinkToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ContextMenuStrip4 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.RefreshToolStripMenuItem3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MG = new global::System.Windows.Forms.ImageList(this.components);
			this.ListView1 = new global::System.Windows.Forms.ListView();
			this.ColumnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.vmethod_148 = new global::System.Windows.Forms.ImageList(this.components);
			this.vmethod_108 = new global::System.Windows.Forms.ImageList(this.components);
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.FMM = new global::System.Windows.Forms.Panel();
			this.LSRV = new global::Troianos_RAT.GClass9();
			this.ColumnHeader11 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader12 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader13 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader14 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader15 = new global::System.Windows.Forms.ColumnHeader();
			this.LPR = new global::Troianos_RAT.GClass9();
			this.ColumnHeader22 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader23 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader24 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader25 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader26 = new global::System.Windows.Forms.ColumnHeader();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.L1 = new global::Troianos_RAT.GClass9();
			this.ColumnHeader6 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader7 = new global::System.Windows.Forms.ColumnHeader();
			this.p = new global::System.Windows.Forms.PictureBox();
			this.L2 = new global::Troianos_RAT.GClass9();
			this.ColumnHeader8 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader9 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader10 = new global::System.Windows.Forms.ColumnHeader();
			this.LTCP = new global::Troianos_RAT.GClass9();
			this.ColumnHeader16 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader17 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader18 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader19 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader20 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader21 = new global::System.Windows.Forms.ColumnHeader();
			this.RG = new global::System.Windows.Forms.Panel();
			this.RGLIST = new global::Troianos_RAT.GClass9();
			this.ColumnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader4 = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnHeader5 = new global::System.Windows.Forms.ColumnHeader();
			this.RGk = new global::System.Windows.Forms.TreeView();
			this.sh = new global::System.Windows.Forms.Panel();
			this.T1 = new global::System.Windows.Forms.RichTextBox();
			this.T2 = new global::System.Windows.Forms.TextBox();
			this.StatusStrip1.SuspendLayout();
			this.M1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.crg.SuspendLayout();
			this.crgk.SuspendLayout();
			this.ContextMenuStrip2.SuspendLayout();
			this.ContextMenuStrip3.SuspendLayout();
			this.ContextMenuStrip4.SuspendLayout();
			this.FMM.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.p).BeginInit();
			this.RG.SuspendLayout();
			this.sh.SuspendLayout();
			this.SuspendLayout();
			this.StatusStrip1.BackColor = global::System.Drawing.Color.Black;
			this.StatusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SL,
				this.pr
			});
			global::System.Windows.Forms.Control statusStrip = this.StatusStrip1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 323);
			statusStrip.Location = location;
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.Professional;
			global::System.Windows.Forms.Control statusStrip2 = this.StatusStrip1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(667, 22);
			statusStrip2.Size = size;
			this.StatusStrip1.TabIndex = 0;
			this.StatusStrip1.Text = "StatusStrip1";
			this.SL.IsLink = true;
			this.SL.Name = "SL";
			global::System.Windows.Forms.ToolStripItem sl = this.SL;
			size = new global::System.Drawing.Size(0, 17);
			sl.Size = size;
			this.pr.Name = "pr";
			global::System.Windows.Forms.ToolStripControlHost pr = this.pr;
			size = new global::System.Drawing.Size(100, 16);
			pr.Size = size;
			this.M1.BackColor = global::System.Drawing.Color.Black;
			this.M1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.KillToolStripMenuItem1,
				this.KillDeleteToolStripMenuItem,
				this.RestartProcessToolStripMenuItem
			});
			this.M1.Name = "M1";
			this.M1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control m = this.M1;
			size = new global::System.Drawing.Size(170, 70);
			m.Size = size;
			this.KillToolStripMenuItem1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.KillToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("KillToolStripMenuItem1.Image");
			this.KillToolStripMenuItem1.Name = "KillToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem killToolStripMenuItem = this.KillToolStripMenuItem1;
			size = new global::System.Drawing.Size(169, 22);
			killToolStripMenuItem.Size = size;
			this.KillToolStripMenuItem1.Text = "Finalizar";
			this.KillDeleteToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.KillDeleteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("KillDeleteToolStripMenuItem.Image");
			this.KillDeleteToolStripMenuItem.Name = "KillDeleteToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem killDeleteToolStripMenuItem = this.KillDeleteToolStripMenuItem;
			size = new global::System.Drawing.Size(169, 22);
			killDeleteToolStripMenuItem.Size = size;
			this.KillDeleteToolStripMenuItem.Text = "Finalizar e Deletar";
			this.RestartProcessToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RestartProcessToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RestartProcessToolStripMenuItem.Image");
			this.RestartProcessToolStripMenuItem.Name = "RestartProcessToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem restartProcessToolStripMenuItem = this.RestartProcessToolStripMenuItem;
			size = new global::System.Drawing.Size(169, 22);
			restartProcessToolStripMenuItem.Size = size;
			this.RestartProcessToolStripMenuItem.Text = "Reiniciar Processo";
			this.vmethod_26.Interval = 1000;
			this.ImageList1.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.ImageList1.Images.SetKeyName(0, "Icon_1.bmp");
			this.ImageList1.Images.SetKeyName(1, "Icon_5.bmp");
			this.ImageList1.Images.SetKeyName(2, "Icon_8.bmp");
			this.ImageList1.Images.SetKeyName(3, "Icon_27.bmp");
			this.ImageList1.Images.SetKeyName(4, "Icon_178.bmp");
			this.ImageList1.Images.SetKeyName(5, "Icon_274.bmp");
			this.ContextMenuStrip1.BackColor = global::System.Drawing.Color.Black;
			this.ContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.KillConnectionToolStripMenuItem
			});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control contextMenuStrip = this.ContextMenuStrip1;
			size = new global::System.Drawing.Size(167, 26);
			contextMenuStrip.Size = size;
			this.KillConnectionToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.KillConnectionToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("KillConnectionToolStripMenuItem.Image");
			this.KillConnectionToolStripMenuItem.Name = "KillConnectionToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem killConnectionToolStripMenuItem = this.KillConnectionToolStripMenuItem;
			size = new global::System.Drawing.Size(166, 22);
			killConnectionToolStripMenuItem.Size = size;
			this.KillConnectionToolStripMenuItem.Text = "Finalizar Conexao";
			this.crg.BackColor = global::System.Drawing.Color.Black;
			this.crg.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RefreshToolStripMenuItem,
				this.EditToolStripMenuItem,
				this.NewValueToolStripMenuItem,
				this.DeleteToolStripMenuItem
			});
			this.crg.Name = "crg";
			this.crg.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control crg = this.crg;
			size = new global::System.Drawing.Size(134, 92);
			crg.Size = size;
			this.RefreshToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RefreshToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RefreshToolStripMenuItem.Image");
			this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem refreshToolStripMenuItem = this.RefreshToolStripMenuItem;
			size = new global::System.Drawing.Size(133, 22);
			refreshToolStripMenuItem.Size = size;
			this.RefreshToolStripMenuItem.Text = "Atualiza";
			this.EditToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.EditToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EditToolStripMenuItem.Image");
			this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem editToolStripMenuItem = this.EditToolStripMenuItem;
			size = new global::System.Drawing.Size(133, 22);
			editToolStripMenuItem.Size = size;
			this.EditToolStripMenuItem.Text = "Editar";
			this.NewValueToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.NewValueToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NewValueToolStripMenuItem.Image");
			this.NewValueToolStripMenuItem.Name = "NewValueToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem newValueToolStripMenuItem = this.NewValueToolStripMenuItem;
			size = new global::System.Drawing.Size(133, 22);
			newValueToolStripMenuItem.Size = size;
			this.NewValueToolStripMenuItem.Text = "Novo Valor";
			this.DeleteToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.DeleteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DeleteToolStripMenuItem.Image");
			this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem deleteToolStripMenuItem = this.DeleteToolStripMenuItem;
			size = new global::System.Drawing.Size(133, 22);
			deleteToolStripMenuItem.Size = size;
			this.DeleteToolStripMenuItem.Text = "Deletar";
			this.rimg.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("rimg.ImageStream");
			this.rimg.TransparentColor = global::System.Drawing.Color.Transparent;
			this.rimg.Images.SetKeyName(0, "Treetog-Junior-Folder-open.ico");
			this.rimg.Images.SetKeyName(1, "8.bmp");
			this.rimg.Images.SetKeyName(2, "9.bmp");
			this.crgk.BackColor = global::System.Drawing.Color.Black;
			this.crgk.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RefreshToolStripMenuItem1,
				this.CreateKeyToolStripMenuItem,
				this.DeleteSelectedToolStripMenuItem
			});
			this.crgk.Name = "crgk";
			this.crgk.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control crgk = this.crgk;
			size = new global::System.Drawing.Size(179, 70);
			crgk.Size = size;
			this.RefreshToolStripMenuItem1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RefreshToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RefreshToolStripMenuItem1.Image");
			this.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem refreshToolStripMenuItem2 = this.RefreshToolStripMenuItem1;
			size = new global::System.Drawing.Size(178, 22);
			refreshToolStripMenuItem2.Size = size;
			this.RefreshToolStripMenuItem1.Text = "Atualizar";
			this.CreateKeyToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.CreateKeyToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CreateKeyToolStripMenuItem.Image");
			this.CreateKeyToolStripMenuItem.Name = "CreateKeyToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem createKeyToolStripMenuItem = this.CreateKeyToolStripMenuItem;
			size = new global::System.Drawing.Size(178, 22);
			createKeyToolStripMenuItem.Size = size;
			this.CreateKeyToolStripMenuItem.Text = "Criar Chave";
			this.DeleteSelectedToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.DeleteSelectedToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DeleteSelectedToolStripMenuItem.Image");
			this.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem deleteSelectedToolStripMenuItem = this.DeleteSelectedToolStripMenuItem;
			size = new global::System.Drawing.Size(178, 22);
			deleteSelectedToolStripMenuItem.Size = size;
			this.DeleteSelectedToolStripMenuItem.Text = "Deletar Selecionado";
			this.ContextMenuStrip2.BackColor = global::System.Drawing.Color.Black;
			this.ContextMenuStrip2.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.StopToolStripMenuItem,
				this.PauseToolStripMenuItem,
				this.StartToolStripMenuItem
			});
			this.ContextMenuStrip2.Name = "ContextMenuStrip2";
			this.ContextMenuStrip2.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control contextMenuStrip2 = this.ContextMenuStrip2;
			size = new global::System.Drawing.Size(110, 70);
			contextMenuStrip2.Size = size;
			this.StopToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.StopToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("StopToolStripMenuItem.Image");
			this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem stopToolStripMenuItem = this.StopToolStripMenuItem;
			size = new global::System.Drawing.Size(109, 22);
			stopToolStripMenuItem.Size = size;
			this.StopToolStripMenuItem.Text = "Parar";
			this.PauseToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.PauseToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PauseToolStripMenuItem.Image");
			this.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem pauseToolStripMenuItem = this.PauseToolStripMenuItem;
			size = new global::System.Drawing.Size(109, 22);
			pauseToolStripMenuItem.Size = size;
			this.PauseToolStripMenuItem.Text = "Pausar";
			this.StartToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.StartToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("StartToolStripMenuItem.Image");
			this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem startToolStripMenuItem = this.StartToolStripMenuItem;
			size = new global::System.Drawing.Size(109, 22);
			startToolStripMenuItem.Size = size;
			this.StartToolStripMenuItem.Text = "Iniciar";
			this.ContextMenuStrip3.BackColor = global::System.Drawing.Color.Black;
			this.ContextMenuStrip3.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.UPToolStripMenuItem,
				this.RefreshToolStripMenuItem2,
				this.RunToolStripMenuItem,
				this.DeleteToolStripMenuItem1,
				this.EditToolStripMenuItem1,
				this.RenameToolStripMenuItem,
				this.CopyToolStripMenuItem,
				this.CutToolStripMenuItem,
				this.PasteToolStripMenuItem,
				this.DownloadToolStripMenuItem,
				this.UploadToolStripMenuItem,
				this.NewEmptyFileToolStripMenuItem,
				this.NewFolderToolStripMenuItem,
				this.OpenDownloadsToolStripMenuItem,
				this.RarToolStripMenuItem,
				this.UnRarToolStripMenuItem,
				this.UploadFromLinkToolStripMenuItem
			});
			this.ContextMenuStrip3.Name = "ContextMenuStrip3";
			this.ContextMenuStrip3.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control contextMenuStrip3 = this.ContextMenuStrip3;
			size = new global::System.Drawing.Size(186, 400);
			contextMenuStrip3.Size = size;
			this.UPToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.UPToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UPToolStripMenuItem.Image");
			this.UPToolStripMenuItem.Name = "UPToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem uptoolStripMenuItem = this.UPToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			uptoolStripMenuItem.Size = size;
			this.UPToolStripMenuItem.Text = "Enviar";
			this.RefreshToolStripMenuItem2.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RefreshToolStripMenuItem2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RefreshToolStripMenuItem2.Image");
			this.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2";
			global::System.Windows.Forms.ToolStripItem refreshToolStripMenuItem3 = this.RefreshToolStripMenuItem2;
			size = new global::System.Drawing.Size(185, 22);
			refreshToolStripMenuItem3.Size = size;
			this.RefreshToolStripMenuItem2.Text = "Atualizar";
			this.RunToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RunToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RunToolStripMenuItem.Image");
			this.RunToolStripMenuItem.Name = "RunToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem runToolStripMenuItem = this.RunToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			runToolStripMenuItem.Size = size;
			this.RunToolStripMenuItem.Text = "Executar";
			this.DeleteToolStripMenuItem1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.DeleteToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DeleteToolStripMenuItem1.Image");
			this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem deleteToolStripMenuItem2 = this.DeleteToolStripMenuItem1;
			size = new global::System.Drawing.Size(185, 22);
			deleteToolStripMenuItem2.Size = size;
			this.DeleteToolStripMenuItem1.Text = "Deletar";
			this.EditToolStripMenuItem1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.EditToolStripMenuItem1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EditToolStripMenuItem1.Image");
			this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
			global::System.Windows.Forms.ToolStripItem editToolStripMenuItem2 = this.EditToolStripMenuItem1;
			size = new global::System.Drawing.Size(185, 22);
			editToolStripMenuItem2.Size = size;
			this.EditToolStripMenuItem1.Text = "Editar";
			this.RenameToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RenameToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RenameToolStripMenuItem.Image");
			this.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem renameToolStripMenuItem = this.RenameToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			renameToolStripMenuItem.Size = size;
			this.RenameToolStripMenuItem.Text = "Renomear";
			this.CopyToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.CopyToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CopyToolStripMenuItem.Image");
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem copyToolStripMenuItem = this.CopyToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			copyToolStripMenuItem.Size = size;
			this.CopyToolStripMenuItem.Text = "Copiar";
			this.CutToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.CutToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CutToolStripMenuItem.Image");
			this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem cutToolStripMenuItem = this.CutToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			cutToolStripMenuItem.Size = size;
			this.CutToolStripMenuItem.Text = "Cortar";
			this.PasteToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.PasteToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PasteToolStripMenuItem.Image");
			this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem pasteToolStripMenuItem = this.PasteToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			pasteToolStripMenuItem.Size = size;
			this.PasteToolStripMenuItem.Text = "Colar";
			this.DownloadToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.DownloadToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DownloadToolStripMenuItem.Image");
			this.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem downloadToolStripMenuItem = this.DownloadToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			downloadToolStripMenuItem.Size = size;
			this.DownloadToolStripMenuItem.Text = "Baixar";
			this.UploadToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.UploadToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UploadToolStripMenuItem.Image");
			this.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem uploadToolStripMenuItem = this.UploadToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			uploadToolStripMenuItem.Size = size;
			this.UploadToolStripMenuItem.Text = "Enviar";
			this.NewEmptyFileToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.NewEmptyFileToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NewEmptyFileToolStripMenuItem.Image");
			this.NewEmptyFileToolStripMenuItem.Name = "NewEmptyFileToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem newEmptyFileToolStripMenuItem = this.NewEmptyFileToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			newEmptyFileToolStripMenuItem.Size = size;
			this.NewEmptyFileToolStripMenuItem.Text = "Novo Arquivo Empty";
			this.NewFolderToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.NewFolderToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NewFolderToolStripMenuItem.Image");
			this.NewFolderToolStripMenuItem.Name = "NewFolderToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem newFolderToolStripMenuItem = this.NewFolderToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			newFolderToolStripMenuItem.Size = size;
			this.NewFolderToolStripMenuItem.Text = "Nova Pasta";
			this.OpenDownloadsToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.OpenDownloadsToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OpenDownloadsToolStripMenuItem.Image");
			this.OpenDownloadsToolStripMenuItem.Name = "OpenDownloadsToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem openDownloadsToolStripMenuItem = this.OpenDownloadsToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			openDownloadsToolStripMenuItem.Size = size;
			this.OpenDownloadsToolStripMenuItem.Text = "Abrir Downloads";
			this.RarToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RarToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RarToolStripMenuItem.Image");
			this.RarToolStripMenuItem.Name = "RarToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem rarToolStripMenuItem = this.RarToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			rarToolStripMenuItem.Size = size;
			this.RarToolStripMenuItem.Text = "WinRar";
			this.UnRarToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.UnRarToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UnRarToolStripMenuItem.Image");
			this.UnRarToolStripMenuItem.Name = "UnRarToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem unRarToolStripMenuItem = this.UnRarToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			unRarToolStripMenuItem.Size = size;
			this.UnRarToolStripMenuItem.Text = "UnRar";
			this.UploadFromLinkToolStripMenuItem.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.UploadFromLinkToolStripMenuItem.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("UploadFromLinkToolStripMenuItem.Image");
			this.UploadFromLinkToolStripMenuItem.Name = "UploadFromLinkToolStripMenuItem";
			global::System.Windows.Forms.ToolStripItem uploadFromLinkToolStripMenuItem = this.UploadFromLinkToolStripMenuItem;
			size = new global::System.Drawing.Size(185, 22);
			uploadFromLinkToolStripMenuItem.Size = size;
			this.UploadFromLinkToolStripMenuItem.Text = "Enviar Por Link";
			this.ContextMenuStrip4.BackColor = global::System.Drawing.Color.Black;
			this.ContextMenuStrip4.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.RefreshToolStripMenuItem3
			});
			this.ContextMenuStrip4.Name = "ContextMenuStrip4";
			this.ContextMenuStrip4.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			global::System.Windows.Forms.Control contextMenuStrip4 = this.ContextMenuStrip4;
			size = new global::System.Drawing.Size(153, 48);
			contextMenuStrip4.Size = size;
			this.RefreshToolStripMenuItem3.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RefreshToolStripMenuItem3.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("RefreshToolStripMenuItem3.Image");
			this.RefreshToolStripMenuItem3.Name = "RefreshToolStripMenuItem3";
			global::System.Windows.Forms.ToolStripItem refreshToolStripMenuItem4 = this.RefreshToolStripMenuItem3;
			size = new global::System.Drawing.Size(120, 22);
			refreshToolStripMenuItem4.Size = size;
			this.RefreshToolStripMenuItem3.Text = "Atualizar";
			this.MG.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("MG.ImageStream");
			this.MG.TransparentColor = global::System.Drawing.Color.Transparent;
			this.MG.Images.SetKeyName(0, "Treetog-Junior-Folder-open.ico");
			this.MG.Images.SetKeyName(1, "Oxygen-Icons.org-Oxygen-Devices-drive-harddisk.ico");
			this.MG.Images.SetKeyName(2, "Babasse-Bagg-And-Boxs-Lecteur-box-DVD.ico");
			this.MG.Images.SetKeyName(3, "Aha-Soft-Torrent-Download.ico");
			this.MG.Images.SetKeyName(4, "6.bmp");
			this.MG.Images.SetKeyName(5, "Oxygen-Icons.org-Oxygen-Apps-preferences-system-network-sharing.ico");
			this.ListView1.Activation = global::System.Windows.Forms.ItemActivation.OneClick;
			this.ListView1.BackColor = global::System.Drawing.Color.Black;
			this.ListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader1,
				this.ColumnHeader2
			});
			this.ListView1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.ListView1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ListView1.ForeColor = global::System.Drawing.Color.White;
			this.ListView1.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.ListView1.HotTracking = true;
			this.ListView1.HoverSelection = true;
			listViewItem.Tag = "";
			listViewItem2.Tag = "0";
			listViewItem3.Tag = "1";
			listViewItem4.Tag = "2";
			listViewItem5.Tag = "3";
			listViewItem6.Tag = "4";
			this.ListView1.Items.AddRange(new global::System.Windows.Forms.ListViewItem[]
			{
				listViewItem,
				listViewItem2,
				listViewItem3,
				listViewItem4,
				listViewItem5,
				listViewItem6
			});
			this.ListView1.LargeImageList = this.ImageList1;
			global::System.Windows.Forms.Control listView = this.ListView1;
			location = new global::System.Drawing.Point(0, 0);
			listView.Location = location;
			this.ListView1.MultiSelect = false;
			this.ListView1.Name = "ListView1";
			this.ListView1.Scrollable = false;
			global::System.Windows.Forms.Control listView2 = this.ListView1;
			size = new global::System.Drawing.Size(667, 52);
			listView2.Size = size;
			this.ListView1.SmallImageList = this.ImageList1;
			this.ListView1.TabIndex = 9;
			global::System.Windows.Forms.ListView listView3 = this.ListView1;
			size = new global::System.Drawing.Size(130, 25);
			listView3.TileSize = size;
			this.ListView1.UseCompatibleStateImageBehavior = false;
			this.ListView1.View = global::System.Windows.Forms.View.Tile;
			this.vmethod_148.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth8Bit;
			global::System.Windows.Forms.ImageList vmethod_ = this.vmethod_148;
			size = new global::System.Drawing.Size(16, 16);
			vmethod_.ImageSize = size;
			this.vmethod_148.TransparentColor = global::System.Drawing.Color.Transparent;
			this.vmethod_108.ColorDepth = global::System.Windows.Forms.ColorDepth.Depth32Bit;
			global::System.Windows.Forms.ImageList vmethod_2 = this.vmethod_108;
			size = new global::System.Drawing.Size(20, 20);
			vmethod_2.ImageSize = size;
			this.vmethod_108.TransparentColor = global::System.Drawing.Color.Transparent;
			this.FMM.Controls.Add(this.LSRV);
			this.FMM.Controls.Add(this.LPR);
			this.FMM.Controls.Add(this.TextBox1);
			this.FMM.Controls.Add(this.L1);
			this.FMM.Controls.Add(this.p);
			this.FMM.Controls.Add(this.L2);
			this.FMM.Controls.Add(this.LTCP);
			this.FMM.Controls.Add(this.RG);
			this.FMM.Controls.Add(this.sh);
			this.FMM.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control fmm = this.FMM;
			location = new global::System.Drawing.Point(0, 52);
			fmm.Location = location;
			this.FMM.Name = "FMM";
			global::System.Windows.Forms.Control fmm2 = this.FMM;
			size = new global::System.Drawing.Size(667, 271);
			fmm2.Size = size;
			this.FMM.TabIndex = 49;
			this.LSRV.BackColor = global::System.Drawing.Color.Black;
			this.LSRV.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader11,
				this.ColumnHeader12,
				this.ColumnHeader13,
				this.ColumnHeader14,
				this.ColumnHeader15
			});
			this.LSRV.ContextMenuStrip = this.ContextMenuStrip2;
			this.LSRV.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LSRV.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.LSRV.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.LSRV.FullRowSelect = true;
			this.LSRV.GridLines = true;
			global::System.Windows.Forms.Control lsrv = this.LSRV;
			location = new global::System.Drawing.Point(0, 0);
			lsrv.Location = location;
			this.LSRV.Name = "LSRV";
			this.LSRV.OwnerDraw = true;
			this.LSRV.ShowItemToolTips = true;
			global::System.Windows.Forms.Control lsrv2 = this.LSRV;
			size = new global::System.Drawing.Size(667, 271);
			lsrv2.Size = size;
			this.LSRV.TabIndex = 55;
			this.LSRV.UseCompatibleStateImageBehavior = false;
			this.LSRV.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader11.Text = "Serviço :";
			this.ColumnHeader12.Text = "Mostrar Nome :";
			this.ColumnHeader13.Text = "Dgtr :";
			this.ColumnHeader14.Text = "Status :";
			this.ColumnHeader15.Text = "Parar :";
			this.ColumnHeader15.Width = 423;
			this.LPR.BackColor = global::System.Drawing.Color.Black;
			this.LPR.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader22,
				this.ColumnHeader23,
				this.ColumnHeader24,
				this.ColumnHeader25,
				this.ColumnHeader26
			});
			this.LPR.ContextMenuStrip = this.M1;
			this.LPR.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LPR.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.LPR.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.LPR.FullRowSelect = true;
			this.LPR.GridLines = true;
			global::System.Windows.Forms.Control lpr = this.LPR;
			location = new global::System.Drawing.Point(0, 0);
			lpr.Location = location;
			this.LPR.Name = "LPR";
			this.LPR.OwnerDraw = true;
			this.LPR.ShowItemToolTips = true;
			global::System.Windows.Forms.Control lpr2 = this.LPR;
			size = new global::System.Drawing.Size(667, 271);
			lpr2.Size = size;
			this.LPR.TabIndex = 54;
			this.LPR.UseCompatibleStateImageBehavior = false;
			this.LPR.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader22.Text = "Nome :";
			this.ColumnHeader23.Text = "PID :";
			this.ColumnHeader23.Width = 49;
			this.ColumnHeader24.Text = "Diretorio :";
			this.ColumnHeader24.Width = 116;
			this.ColumnHeader25.Text = "Usuario :";
			this.ColumnHeader26.Text = "Linha de Comando :";
			this.ColumnHeader26.Width = 378;
			this.TextBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			global::System.Windows.Forms.Control textBox = this.TextBox1;
			location = new global::System.Drawing.Point(194, 0);
			textBox.Location = location;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			global::System.Windows.Forms.Control textBox2 = this.TextBox1;
			size = new global::System.Drawing.Size(473, 20);
			textBox2.Size = size;
			this.TextBox1.TabIndex = 32;
			this.L1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.L1.BackColor = global::System.Drawing.Color.Black;
			this.L1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader6,
				this.ColumnHeader7
			});
			this.L1.ContextMenuStrip = this.ContextMenuStrip4;
			this.L1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.L1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.L1.FullRowSelect = true;
			this.L1.LargeImageList = this.MG;
			global::System.Windows.Forms.Control l = this.L1;
			location = new global::System.Drawing.Point(0, 0);
			l.Location = location;
			this.L1.Name = "L1";
			this.L1.OwnerDraw = true;
			global::System.Windows.Forms.Control l2 = this.L1;
			size = new global::System.Drawing.Size(194, 283);
			l2.Size = size;
			this.L1.SmallImageList = this.MG;
			this.L1.TabIndex = 21;
			this.L1.UseCompatibleStateImageBehavior = false;
			this.L1.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader6.Text = "Nome :";
			this.ColumnHeader6.Width = 106;
			this.ColumnHeader7.Text = "Dgtr :";
			this.ColumnHeader7.Width = 84;
			this.p.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			global::System.Windows.Forms.Control p = this.p;
			location = new global::System.Drawing.Point(390, 114);
			p.Location = location;
			this.p.Name = "p";
			global::System.Windows.Forms.Control p2 = this.p;
			size = new global::System.Drawing.Size(197, 126);
			p2.Size = size;
			this.p.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.p.TabIndex = 31;
			this.p.TabStop = false;
			this.L2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.L2.BackColor = global::System.Drawing.Color.Black;
			this.L2.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader8,
				this.ColumnHeader9,
				this.ColumnHeader10
			});
			this.L2.ContextMenuStrip = this.ContextMenuStrip3;
			this.L2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold);
			this.L2.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.L2.FullRowSelect = true;
			this.L2.LargeImageList = this.vmethod_108;
			global::System.Windows.Forms.Control l3 = this.L2;
			location = new global::System.Drawing.Point(194, 21);
			l3.Location = location;
			this.L2.Name = "L2";
			this.L2.OwnerDraw = true;
			this.L2.ShowItemToolTips = true;
			global::System.Windows.Forms.Control l4 = this.L2;
			size = new global::System.Drawing.Size(473, 250);
			l4.Size = size;
			this.L2.SmallImageList = this.vmethod_108;
			this.L2.TabIndex = 23;
			global::System.Windows.Forms.ListView l5 = this.L2;
			size = new global::System.Drawing.Size(60, 40);
			l5.TileSize = size;
			this.L2.UseCompatibleStateImageBehavior = false;
			this.L2.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader8.Text = "Nome :";
			this.ColumnHeader8.Width = 165;
			this.ColumnHeader9.Text = "Tamanho :";
			this.ColumnHeader9.Width = 93;
			this.ColumnHeader10.Text = "Dgtr :";
			this.ColumnHeader10.Width = 211;
			this.LTCP.BackColor = global::System.Drawing.Color.Black;
			this.LTCP.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader16,
				this.ColumnHeader17,
				this.ColumnHeader18,
				this.ColumnHeader19,
				this.ColumnHeader20,
				this.ColumnHeader21
			});
			this.LTCP.ContextMenuStrip = this.ContextMenuStrip1;
			this.LTCP.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LTCP.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.LTCP.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.LTCP.FullRowSelect = true;
			this.LTCP.GridLines = true;
			global::System.Windows.Forms.Control ltcp = this.LTCP;
			location = new global::System.Drawing.Point(0, 0);
			ltcp.Location = location;
			this.LTCP.Name = "LTCP";
			this.LTCP.OwnerDraw = true;
			this.LTCP.ShowItemToolTips = true;
			global::System.Windows.Forms.Control ltcp2 = this.LTCP;
			size = new global::System.Drawing.Size(667, 271);
			ltcp2.Size = size;
			this.LTCP.TabIndex = 48;
			this.LTCP.UseCompatibleStateImageBehavior = false;
			this.LTCP.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader16.Text = "Local do IP :";
			this.ColumnHeader17.Text = "Local da Porta :";
			this.ColumnHeader18.Text = "IP Remoto :";
			this.ColumnHeader18.Width = 116;
			this.ColumnHeader19.Text = "Porta Remota :";
			this.ColumnHeader20.Text = "Estado :";
			this.ColumnHeader21.Text = "Processo :";
			this.ColumnHeader21.Width = 307;
			this.RG.Controls.Add(this.RGLIST);
			this.RG.Controls.Add(this.RGk);
			this.RG.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control rg = this.RG;
			location = new global::System.Drawing.Point(0, 0);
			rg.Location = location;
			this.RG.Name = "RG";
			global::System.Windows.Forms.Control rg2 = this.RG;
			size = new global::System.Drawing.Size(667, 271);
			rg2.Size = size;
			this.RG.TabIndex = 52;
			this.RGLIST.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.RGLIST.BackColor = global::System.Drawing.Color.Black;
			this.RGLIST.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnHeader3,
				this.ColumnHeader4,
				this.ColumnHeader5
			});
			this.RGLIST.ContextMenuStrip = this.crg;
			this.RGLIST.Font = new global::System.Drawing.Font("Arial", 8f, global::System.Drawing.FontStyle.Bold);
			this.RGLIST.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RGLIST.FullRowSelect = true;
			this.RGLIST.LargeImageList = this.rimg;
			global::System.Windows.Forms.Control rglist = this.RGLIST;
			location = new global::System.Drawing.Point(200, 0);
			rglist.Location = location;
			this.RGLIST.Name = "RGLIST";
			this.RGLIST.OwnerDraw = true;
			global::System.Windows.Forms.Control rglist2 = this.RGLIST;
			size = new global::System.Drawing.Size(467, 271);
			rglist2.Size = size;
			this.RGLIST.SmallImageList = this.rimg;
			this.RGLIST.TabIndex = 18;
			this.RGLIST.UseCompatibleStateImageBehavior = false;
			this.RGLIST.View = global::System.Windows.Forms.View.Details;
			this.ColumnHeader3.Text = "Nome :";
			this.ColumnHeader3.Width = 109;
			this.ColumnHeader4.Text = "Dgtr :";
			this.ColumnHeader4.Width = 109;
			this.ColumnHeader5.Text = "Valor :";
			this.ColumnHeader5.Width = 245;
			this.RGk.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.RGk.BackColor = global::System.Drawing.Color.Black;
			this.RGk.ContextMenuStrip = this.crgk;
			this.RGk.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RGk.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			this.RGk.ImageIndex = 0;
			this.RGk.ImageList = this.rimg;
			global::System.Windows.Forms.Control rgk = this.RGk;
			location = new global::System.Drawing.Point(0, 0);
			rgk.Location = location;
			this.RGk.Name = "RGk";
			this.RGk.SelectedImageIndex = 0;
			global::System.Windows.Forms.Control rgk2 = this.RGk;
			size = new global::System.Drawing.Size(200, 271);
			rgk2.Size = size;
			this.RGk.TabIndex = 14;
			this.sh.Controls.Add(this.T1);
			this.sh.Controls.Add(this.T2);
			this.sh.Dock = global::System.Windows.Forms.DockStyle.Fill;
			global::System.Windows.Forms.Control sh = this.sh;
			location = new global::System.Drawing.Point(0, 0);
			sh.Location = location;
			this.sh.Name = "sh";
			global::System.Windows.Forms.Control sh2 = this.sh;
			size = new global::System.Drawing.Size(667, 271);
			sh2.Size = size;
			this.sh.TabIndex = 53;
			this.T1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.T1.BackColor = global::System.Drawing.Color.Black;
			this.T1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.T1.Cursor = global::System.Windows.Forms.Cursors.Arrow;
			this.T1.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.T1.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			global::System.Windows.Forms.Control t = this.T1;
			location = new global::System.Drawing.Point(0, 0);
			t.Location = location;
			this.T1.Name = "T1";
			this.T1.ReadOnly = true;
			global::System.Windows.Forms.Control t2 = this.T1;
			size = new global::System.Drawing.Size(667, 251);
			t2.Size = size;
			this.T1.TabIndex = 4;
			this.T1.Text = "";
			this.T2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.T2.BackColor = global::System.Drawing.Color.Gray;
			this.T2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.T2.Font = new global::System.Drawing.Font("Arial", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.T2.ForeColor = global::System.Drawing.Color.LightSteelBlue;
			global::System.Windows.Forms.Control t3 = this.T2;
			location = new global::System.Drawing.Point(0, 251);
			t3.Location = location;
			this.T2.Name = "T2";
			this.T2.ReadOnly = true;
			global::System.Windows.Forms.Control t4 = this.T2;
			size = new global::System.Drawing.Size(667, 20);
			t4.Size = size;
			this.T2.TabIndex = 3;
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(667, 345);
			this.ClientSize = size;
			this.Controls.Add(this.FMM);
			this.Controls.Add(this.ListView1);
			this.Controls.Add(this.StatusStrip1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Manager";
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerenciador";
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.M1.ResumeLayout(false);
			this.ContextMenuStrip1.ResumeLayout(false);
			this.crg.ResumeLayout(false);
			this.crgk.ResumeLayout(false);
			this.ContextMenuStrip2.ResumeLayout(false);
			this.ContextMenuStrip3.ResumeLayout(false);
			this.ContextMenuStrip4.ResumeLayout(false);
			this.FMM.ResumeLayout(false);
			this.FMM.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.p).EndInit();
			this.RG.ResumeLayout(false);
			this.sh.ResumeLayout(false);
			this.sh.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x040000C7 RID: 199
		private global::System.ComponentModel.IContainer components;
	}
}
