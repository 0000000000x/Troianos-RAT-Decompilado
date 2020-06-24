using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x0200002F RID: 47
	public sealed class GClass8 : PictureBox
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x001D78D8 File Offset: 0x001D5CD8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = GClass8.__ENCList;
			lock (_ENCList)
			{
				bool flag = GClass8.__ENCList.Count == GClass8.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = GClass8.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = GClass8.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								GClass8.__ENCList[num] = GClass8.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					GClass8.__ENCList.RemoveRange(num, GClass8.__ENCList.Count - num);
					GClass8.__ENCList.Capacity = GClass8.__ENCList.Count;
				}
				GClass8.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x001D79DC File Offset: 0x001D5DDC
		public GClass8()
		{
			GClass8.__ENCAddToList(this);
			this.fonty = new Font("arial", 8f, FontStyle.Bold);
			this.Lines = new List<object[]>();
			Timer t = new Timer
			{
				Interval = 50,
				Enabled = false
			};
			this.T = t;
			this.SizeMode = PictureBoxSizeMode.Normal;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x001D7A44 File Offset: 0x001D5E44
		[DebuggerStepThrough]
		[CompilerGenerated]
		private void lam__4(object a0, EventArgs a1)
		{
			try
			{
				this.wrk();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x001D7A80 File Offset: 0x001D5E80
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
					int height = TextRenderer.MeasureText("test", this.Font).Height;
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
									Size size = TextRenderer.MeasureText(text, this.Font);
									this.G.DrawString(text, this.Font, new Pen(color).Brush, (float)num2, (float)num);
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

		// Token: 0x06000461 RID: 1121 RVA: 0x001D7D5C File Offset: 0x001D615C
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

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x001D7DC4 File Offset: 0x001D61C4
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x001D7DDC File Offset: 0x001D61DC
		public Timer T
		{
			get
			{
				return this._T;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.lam__4);
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

		// Token: 0x0400027E RID: 638
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400027F RID: 639
		private Timer _T;

		// Token: 0x04000280 RID: 640
		public Font fonty;

		// Token: 0x04000281 RID: 641
		public Graphics G;

		// Token: 0x04000282 RID: 642
		public List<object[]> Lines;
	}
}
