using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x0200003F RID: 63
	public sealed class Pp1 : PictureBox
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x001D9D00 File Offset: 0x001D8100
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Pp1.__ENCList;
			lock (_ENCList)
			{
				bool flag = Pp1.__ENCList.Count == Pp1.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = Pp1.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = Pp1.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								Pp1.__ENCList[num] = Pp1.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					Pp1.__ENCList.RemoveRange(num, Pp1.__ENCList.Count - num);
					Pp1.__ENCList.Capacity = Pp1.__ENCList.Count;
				}
				Pp1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x001D9E04 File Offset: 0x001D8204
		public Pp1()
		{
			Pp1.__ENCAddToList(this);
			this.font = new Font("arial", 8f, FontStyle.Bold);
			this.Lines = new List<object[]>();
			Timer t = new Timer
			{
				Interval = 50,
				Enabled = false
			};
			this.T = t;
			this.SizeMode = PictureBoxSizeMode.Normal;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x001D9E6C File Offset: 0x001D826C
		[DebuggerStepThrough]
		[CompilerGenerated]
		private void ksh__4(object a0, EventArgs a1)
		{
			try
			{
				this.wrk();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x001D9EA8 File Offset: 0x001D82A8
		public void wrk()
		{
			try
			{
				this.T.Enabled = false;
				lock (this)
				{
					Bitmap image = new Bitmap(this.Width, this.Height);
					this.G = Graphics.FromImage(image);
					this.G.Clear(Color.Black);
					int num = 3;
					int height = TextRenderer.MeasureText("test", this.font).Height;
					Color color = Color.White;
					for (int i = this.Lines.Count - 1; i >= 0; i += -1)
					{
						int num2 = 3;
						object[] array = this.Lines[i];
						int num3 = array.Length - 1;
						for (int j = 0; j <= num3; j++)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[j])))))));
							string left = objectValue.GetType().ToString();
							bool flag = Operators.CompareString(left, typeof(Bitmap).ToString(), false) == 0;
							if (flag)
							{
								Bitmap bitmap = (Bitmap)objectValue;
								flag = (bitmap.Height > height);
								if (flag)
								{
									IntPtr callbackData;
									bitmap = (Bitmap)bitmap.GetThumbnailImage(height, height, null, callbackData);
								}
								this.G.DrawImage(bitmap, num2, num);
								num2 += bitmap.Width + 3;
							}
							else
							{
								flag = (Operators.CompareString(left, typeof(string).ToString(), false) == 0);
								if (flag)
								{
									string text = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))));
									Size size = TextRenderer.MeasureText(text, this.font);
									this.G.DrawString(text, this.font, new Pen(color).Brush, (float)num2, (float)num);
									flag = (size.Height - height > 0);
									if (flag)
									{
										num += size.Height - height;
										num2 = 3;
									}
									else
									{
										num2 += size.Width + 3;
									}
								}
								else
								{
									flag = (Operators.CompareString(left, typeof(Color).ToString(), false) == 0);
									if (flag)
									{
										color = (Color)objectValue;
									}
								}
							}
						}
						num += height;
					}
					this.G.Dispose();
					this.Image = image;
				}
				this.T.Enabled = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x001DA184 File Offset: 0x001D8584
		public void WRT(params object[] A)
		{
			lock (this)
			{
				this.Lines.Add(A);
				bool flag = this.Lines.Count == 100;
				if (flag)
				{
					this.Lines.RemoveAt(0);
				}
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x001DA1EC File Offset: 0x001D85EC
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x001DA204 File Offset: 0x001D8604
		public Timer T
		{
			get
			{
				return this._T;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ksh__4);
				bool flag = this._T != null;
				if (flag)
				{
					this._T.Tick -= value2;
				}
				this._T = value;
				flag = (this._T != null);
				if (flag)
				{
					this._T.Tick += value2;
				}
			}
		}

		// Token: 0x040002B3 RID: 691
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002B4 RID: 692
		private Timer _T;

		// Token: 0x040002B5 RID: 693
		public Font font;

		// Token: 0x040002B6 RID: 694
		public Graphics G;

		// Token: 0x040002B7 RID: 695
		public List<object[]> Lines;
	}
}
