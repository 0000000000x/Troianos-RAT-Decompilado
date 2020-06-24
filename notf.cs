using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.My;

namespace Troianos_RAT
{
	// Token: 0x02000018 RID: 24
	[DesignerGenerated]
	public partial class notf : Form
	{
		// Token: 0x060002BE RID: 702 RVA: 0x001F26A8 File Offset: 0x001F0AA8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = notf.__ENCList;
			lock (_ENCList)
			{
				bool flag = notf.__ENCList.Count == notf.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = notf.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = notf.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								notf.__ENCList[num] = notf.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					notf.__ENCList.RemoveRange(num, notf.__ENCList.Count - num);
					notf.__ENCList.Capacity = notf.__ENCList.Count;
				}
				notf.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x001F297C File Offset: 0x001F0D7C
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x001F2994 File Offset: 0x001F0D94
		internal virtual PictureBox p
		{
			[DebuggerNonUserCode]
			get
			{
				return this._p;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.p_Click);
				bool flag = this._p != null;
				if (flag)
				{
					this._p.Click -= value2;
				}
				this._p = value;
				flag = (this._p != null);
				if (flag)
				{
					this._p.Click += value2;
				}
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x001F29F4 File Offset: 0x001F0DF4
		public notf()
		{
			base.Load += this.notf_Load;
			notf.__ENCAddToList(this);
			base.Load += this.notf_Load;
			this.bool_0 = true;
			this.Items = new List<notf.GClass15>();
			this.InitializeComponent();
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x001F2A54 File Offset: 0x001F0E54
		public void AddItem(Bitmap img, string Text)
		{
			List<notf.GClass15> items = this.Items;
			List<notf.GClass15> obj = items;
			lock (obj)
			{
				bool flag = this.Items.Count > 50;
				if (flag)
				{
					this.Items.RemoveAt(0);
				}
				notf.GClass15 item = new notf.GClass15
				{
					bitmap_0 = (Bitmap)img.Clone(),
					string_0 = Text
				};
				this.Items.Add(item);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x001F2AE0 File Offset: 0x001F0EE0
		public void back()
		{
			this.bool_0 = true;
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			this.Left = workingArea.Width - this.Width - 5;
			this.Top = workingArea.Height - this.Height - 5;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x001F2B30 File Offset: 0x001F0F30
		public void go()
		{
			this.bool_0 = false;
			Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
			this.Left = workingArea.Width;
			this.Top = workingArea.Height;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x001F2B70 File Offset: 0x001F0F70
		private void p_Click(object sender, EventArgs e)
		{
			List<notf.GClass15> items = this.Items;
			List<notf.GClass15> obj = items;
			lock (obj)
			{
				this.Items.Clear();
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x001F2BB8 File Offset: 0x001F0FB8
		private void notf_Load(object sender, EventArgs e)
		{
			this.p.BackColor = Color.Pink;
			this.TransparencyKey = Color.Pink;
			this.back();
			Control.CheckForIllegalCrossThreadCalls = false;
			Thread thread = new Thread(new ThreadStart(this.wrk));
			thread.Start();
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x001F2C0C File Offset: 0x001F100C
		public void wrk()
		{
			for (;;)
			{
				Thread.Sleep(50);
				bool flag = this.Items.Count == 0;
				if (flag)
				{
					this.go();
				}
				else
				{
					try
					{
						Bitmap bitmap = new Bitmap(this.p.Width, this.p.Height);
						Graphics graphics = Graphics.FromImage(bitmap);
						graphics.Clear(this.p.BackColor);
						List<notf.GClass15> items = this.Items;
						List<notf.GClass15> obj = items;
						lock (obj)
						{
							try
							{
								foreach (notf.GClass15 gclass in this.Items)
								{
									flag = (gclass.int_0 <= 2);
									if (flag)
									{
										gclass.int_0 = 2;
										notf.GClass15 gclass2 = gclass;
										notf.GClass15 gclass3 = gclass2;
										gclass3.int_1++;
									}
									else
									{
										int count = this.Items.Count;
										flag = (count > 30);
										if (flag)
										{
											gclass.int_0 = 2;
										}
										else
										{
											flag = (count > 20);
											if (flag)
											{
												notf.GClass15 gclass2 = gclass;
												gclass2.int_0 += -20;
											}
											else
											{
												flag = (count > 10);
												if (flag)
												{
													notf.GClass15 gclass2 = gclass;
													gclass2.int_0 += -10;
												}
												else
												{
													notf.GClass15 gclass2 = gclass;
													gclass2.int_0 += -2;
												}
											}
										}
										flag = (gclass.int_0 < 2);
										if (flag)
										{
											gclass.int_0 = 2;
										}
									}
									Size size = TextRenderer.MeasureText(gclass.string_0, this.Font);
									size.Width = bitmap.Width;
									size.Height += 5;
									Rectangle rectangle = new Rectangle(0, gclass.int_0 - 2, this.Width, size.Height);
									graphics.FillRectangle(Brushes.Black, rectangle);
									rectangle = new Rectangle(0, gclass.int_0 - 2, this.Width, size.Height);
									ControlPaint.DrawLockedFrame(graphics, rectangle, false);
									object[] array = new object[2];
									array[0] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(gclass.bitmap_0.Clone())));
									Point point = new Point(5, gclass.int_0 - 2);
									array[1] = point;
									NewLateBinding.LateCall(graphics, null, "DrawImage", array, null, null, null, true);
									graphics.DrawString(gclass.string_0, this.Font, Brushes.LightSteelBlue, 5f, (float)gclass.int_0);
									flag = (gclass.int_0 > this.Height - 50);
									if (flag)
									{
										break;
									}
								}
							}
							finally
							{
								List<notf.GClass15>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							for (;;)
							{
								IL_29E:
								try
								{
									foreach (notf.GClass15 gclass4 in this.Items)
									{
										flag = (gclass4.int_1 == 40);
										if (flag)
										{
											this.Items.Remove(gclass4);
											goto IL_29E;
										}
									}
								}
								finally
								{
									List<notf.GClass15>.Enumerator enumerator2;
									((IDisposable)enumerator2).Dispose();
								}
								break;
							}
							flag = (this.Items.Count == 0 & this.bool_0);
							if (flag)
							{
								this.go();
							}
							flag = (this.Items.Count > 0 & !this.bool_0);
							if (flag)
							{
								this.back();
							}
						}
						graphics.Flush(FlushIntention.Sync);
						graphics.Dispose();
						this.p.Image = bitmap;
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x001F301C File Offset: 0x001F141C
		private void WaterFX1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x04000153 RID: 339
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000155 RID: 341
		[AccessedThroughProperty("p")]
		private PictureBox _p;

		// Token: 0x04000156 RID: 342
		private bool bool_0;

		// Token: 0x04000157 RID: 343
		public List<notf.GClass15> Items;

		// Token: 0x02000019 RID: 25
		public sealed class GClass15
		{
			// Token: 0x060002CB RID: 715 RVA: 0x001F3020 File Offset: 0x001F1420
			public GClass15()
			{
				this.int_0 = MyProject.Forms.notf.Height;
				this.int_1 = 0;
			}

			// Token: 0x04000158 RID: 344
			public Bitmap bitmap_0;

			// Token: 0x04000159 RID: 345
			public int int_0;

			// Token: 0x0400015A RID: 346
			public int int_1;

			// Token: 0x0400015B RID: 347
			public string string_0;
		}
	}
}
