namespace Troianos_RAT
{
	// Token: 0x0200000C RID: 12
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Chat : global::System.Windows.Forms.Form
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x001DFA30 File Offset: 0x001DDE30
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

		// Token: 0x060000C8 RID: 200 RVA: 0x001DFA80 File Offset: 0x001DDE80
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Troianos_RAT.Chat));
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.T2 = new global::System.Windows.Forms.TextBox();
			this.T1 = new global::System.Windows.Forms.RichTextBox();
			this.vmethod_8 = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.T2);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			global::System.Windows.Forms.Control panel = this.Panel1;
			global::System.Drawing.Point location = new global::System.Drawing.Point(0, 152);
			panel.Location = location;
			this.Panel1.Name = "Panel1";
			global::System.Windows.Forms.Control panel2 = this.Panel1;
			global::System.Drawing.Size size = new global::System.Drawing.Size(405, 29);
			panel2.Size = size;
			this.Panel1.TabIndex = 0;
			this.Button1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = global::System.Drawing.Color.White;
			global::System.Windows.Forms.Control button = this.Button1;
			location = new global::System.Drawing.Point(324, 0);
			button.Location = location;
			this.Button1.Name = "Button1";
			global::System.Windows.Forms.Control button2 = this.Button1;
			size = new global::System.Drawing.Size(81, 29);
			button2.Size = size;
			this.Button1.TabIndex = 1;
			this.Button1.Text = "Enviar";
			this.Button1.UseVisualStyleBackColor = true;
			this.T2.BackColor = global::System.Drawing.Color.Black;
			this.T2.ForeColor = global::System.Drawing.Color.Lime;
			global::System.Windows.Forms.Control t = this.T2;
			location = new global::System.Drawing.Point(0, 0);
			t.Location = location;
			this.T2.Multiline = true;
			this.T2.Name = "T2";
			global::System.Windows.Forms.Control t2 = this.T2;
			size = new global::System.Drawing.Size(324, 29);
			t2.Size = size;
			this.T2.TabIndex = 0;
			this.T1.BackColor = global::System.Drawing.Color.Black;
			this.T1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.T1.ForeColor = global::System.Drawing.Color.Lime;
			global::System.Windows.Forms.Control t3 = this.T1;
			location = new global::System.Drawing.Point(0, 0);
			t3.Location = location;
			this.T1.Name = "T1";
			global::System.Windows.Forms.Control t4 = this.T1;
			size = new global::System.Drawing.Size(405, 152);
			t4.Size = size;
			this.T1.TabIndex = 1;
			this.T1.Text = "";
			global::System.Drawing.SizeF autoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			size = new global::System.Drawing.Size(405, 181);
			this.ClientSize = size;
			this.Controls.Add(this.T1);
			this.Controls.Add(this.Panel1);
			this.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.Name = "Chat";
			this.ShowInTaskbar = false;
			this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chat";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.ResumeLayout(false);
		}

		// Token: 0x04000063 RID: 99
		private global::System.ComponentModel.IContainer components;
	}
}
