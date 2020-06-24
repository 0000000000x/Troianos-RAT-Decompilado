using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x02000008 RID: 8
	public class WaterFX : Panel
	{
		// Token: 0x06000046 RID: 70 RVA: 0x001CBBF0 File Offset: 0x001C9FF0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = WaterFX.__ENCList;
			lock (_ENCList)
			{
				bool flag = WaterFX.__ENCList.Count == WaterFX.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = WaterFX.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = WaterFX.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								WaterFX.__ENCList[num] = WaterFX.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					WaterFX.__ENCList.RemoveRange(num, WaterFX.__ENCList.Count - num);
					WaterFX.__ENCList.Capacity = WaterFX.__ENCList.Count;
				}
				WaterFX.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x001CBCF4 File Offset: 0x001CA0F4
		private void InitializeComponent()
		{
			this.components = new Container();
			this.effectTimer = new Timer(this.components);
			this.tmrBalance = new Timer(this.components);
			this.effectTimer.Tick += this.effectTimer_Tick;
			this.tmrBalance.Tick += this.tmrBalance_Tick;
			this.Paint += this.WaterEffectControl_Paint;
			this.MouseMove += this.WaterEffectControl_MouseMove;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x001CBD8C File Offset: 0x001CA18C
		public WaterFX()
		{
			WaterFX.__ENCAddToList(this);
			this._activeBuffer = 0;
			this.InitializeComponent();
			this.effectTimer.Enabled = true;
			this.effectTimer.Interval = 100;
			this.tmrBalance.Interval = 1000;
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.BackColor = Color.Transparent;
			this._weHaveWaves = false;
			this._scale = 1;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x001CBE20 File Offset: 0x001CA220
		public WaterFX(Bitmap bmp) : this()
		{
			this.ImageBitmap = bmp;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x001CBE34 File Offset: 0x001CA234
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				bool flag = this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x001CBE70 File Offset: 0x001CA270
		private void effectTimer_Tick(object sender, EventArgs e)
		{
			bool weHaveWaves = this._weHaveWaves;
			if (weHaveWaves)
			{
				this.Invalidate();
				this.ProcessWaves();
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x001CBE98 File Offset: 0x001CA298
		private void tmrBalance_Tick(object sender, EventArgs e)
		{
			this.__IsBusy = !this.__IsBusy;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x001CBEAC File Offset: 0x001CA2AC
		public void WaterEffectControl_Paint(object sender, PaintEventArgs e)
		{
			int num2;
			int num17;
			object obj;
			try
			{
				IL_01:
				int num = 1;
				bool flag = Information.IsNothing(this._bmp);
				if (!flag)
				{
					goto IL_1B;
				}
				IL_15:
				goto IL_62A;
				IL_1B:
				num = 4;
				Bitmap bitmap = null;
				IL_20:
				ProjectData.ClearProjectError();
				num2 = -2;
				IL_29:
				num = 6;
				bitmap = (Bitmap)this._bmp.Clone();
				IL_3D:
				num = 7;
				flag = this._weHaveWaves;
				if (!flag)
				{
					goto IL_420;
				}
				IL_4F:
				num = 8;
				Bitmap bitmap2 = bitmap;
				Rectangle rect = new Rectangle(0, 0, this._bmpWidth, this._bmpHeight);
				BitmapData bitmapData = bitmap2.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
				IL_78:
				num = 9;
				byte[] array = new byte[this._bmpWidth * this._bmpHeight * 4 - 1 + 1];
				IL_96:
				num = 10;
				Marshal.Copy(bitmapData.Scan0, array, 0, this._bmpWidth * this._bmpHeight * 4);
				IL_B9:
				num = 11;
				int num3 = 1;
				int num4 = this._bmpWidth - 2;
				int num5 = num3;
				bool flag2;
				for (;;)
				{
					int num6 = num5;
					int num7 = num4;
					if (num6 > num7)
					{
						break;
					}
					IL_CF:
					num = 12;
					int num8 = 1;
					int num9 = this._bmpHeight - 2;
					int num10 = num8;
					for (;;)
					{
						int num11 = num10;
						num7 = num9;
						if (num11 > num7)
						{
							break;
						}
						IL_E5:
						num = 13;
						int num12 = num5 >> this._scale;
						IL_F7:
						num = 14;
						int num13 = num10 >> this._scale;
						IL_109:
						num = 15;
						flag = (num12 <= 0);
						if (flag)
						{
							IL_11B:
							num = 16;
							num12 = 1;
						}
						IL_122:
						IL_123:
						num = 18;
						flag = (num13 <= 0);
						if (flag)
						{
							IL_135:
							num = 19;
							num13 = 1;
						}
						IL_13C:
						IL_13D:
						num = 21;
						flag = (num12 >= this._waveWidth - 1);
						if (flag)
						{
							IL_156:
							num = 22;
							num12 = this._waveWidth - 2;
						}
						IL_164:
						IL_165:
						num = 24;
						flag = (num13 >= this._waveHeight - 1);
						if (flag)
						{
							IL_17E:
							num = 25;
							num13 = this._waveHeight - 2;
						}
						IL_18C:
						IL_18D:
						num = 27;
						int num14 = (int)((short)(this._waves[num12 - 1, num13, this._activeBuffer] - this._waves[num12 + 1, num13, this._activeBuffer] >> 3));
						IL_1C5:
						num = 28;
						int num15 = (int)((short)(this._waves[num12, num13 - 1, this._activeBuffer] - this._waves[num12, num13 + 1, this._activeBuffer] >> 3));
						IL_1FD:
						num = 29;
						flag = (num14 != 0 || num15 != 0);
						if (flag)
						{
							IL_216:
							num = 30;
							flag2 = (num5 + num14 >= this._bmpWidth - 1);
							if (flag2)
							{
								IL_231:
								num = 31;
								num14 = this._bmpWidth - num5 - 1;
							}
							IL_241:
							IL_242:
							num = 33;
							flag2 = (num10 + num15 >= this._bmpHeight - 1);
							if (flag2)
							{
								IL_25D:
								num = 34;
								num15 = this._bmpHeight - num10 - 1;
							}
							IL_26D:
							IL_26E:
							num = 36;
							flag2 = (num5 + num14 < 0);
							if (flag2)
							{
								IL_27F:
								num = 37;
								num14 = -num5;
							}
							IL_287:
							IL_288:
							num = 39;
							flag2 = (num10 + num15 < 0);
							if (flag2)
							{
								IL_299:
								num = 40;
								num15 = -num10;
							}
							IL_2A1:
							IL_2A2:
							num = 42;
							flag2 = (num14 <= 0);
							if (flag2)
							{
								IL_2B3:
								num = 43;
								num14 = 0;
							}
							IL_2B9:
							num = 45;
							byte b = (byte)(200 - num14);
							IL_2C6:
							num = 46;
							flag2 = (b < 0);
							if (flag2)
							{
								IL_2D4:
								num = 47;
								b = 0;
							}
							IL_2DA:
							IL_2DB:
							num = 49;
							flag2 = (b > byte.MaxValue);
							if (flag2)
							{
								IL_2ED:
								num = 50;
								b = 254;
							}
							IL_2F7:
							IL_2F8:
							num = 52;
							array[4 * (num5 + num10 * this._bmpWidth)] = this._bmpBytes[4 * (num5 + num14 + (num10 + num15) * this._bmpWidth)];
							IL_326:
							num = 53;
							array[4 * (num5 + num10 * this._bmpWidth) + 1] = this._bmpBytes[4 * (num5 + num14 + (num10 + num15) * this._bmpWidth) + 1];
							IL_358:
							num = 54;
							array[4 * (num5 + num10 * this._bmpWidth) + 2] = this._bmpBytes[4 * (num5 + num14 + (num10 + num15) * this._bmpWidth) + 2];
							IL_38A:
							num = 55;
							array[4 * (num5 + num10 * this._bmpWidth) + 3] = b;
						}
						IL_3A2:
						IL_3A3:
						num = 57;
						num10++;
					}
					IL_3BB:
					num = 58;
					flag2 = (Information.Err().Number != 0);
					if (flag2)
					{
						break;
					}
					IL_3D8:
					num = 61;
					num5++;
				}
				IL_3D6:
				IL_3F0:
				num = 62;
				Marshal.Copy(array, 0, bitmapData.Scan0, this._bmpWidth * this._bmpHeight * 4);
				IL_413:
				num = 63;
				bitmap.UnlockBits(bitmapData);
				IL_420:
				IL_421:
				num = 65;
				e.Graphics.DrawImage(bitmap, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height);
				IL_452:
				num = 66;
				flag2 = (Information.Err().Number != 0);
				if (!flag2)
				{
					goto IL_48A;
				}
				IL_46C:
				num = 67;
				Debug.WriteLine("WaterEffectControl_Paint: " + Information.Err().Description);
				IL_48A:
				num = 69;
				flag2 = !Information.IsNothing(bitmap);
				if (!flag2)
				{
					goto IL_4A8;
				}
				IL_49D:
				num = 70;
				bitmap.Dispose();
				IL_4A8:
				goto IL_62A;
				IL_4B1:
				int num16 = num17 + 1;
				num17 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num16);
				IL_5DD:
				goto IL_61F;
				IL_5DF:
				num17 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num2 > -2) ? num2 : 1);
				IL_5FB:;
			}
			catch when (endfilter(obj is Exception & num2 != 0 & num17 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_5DF;
			}
			IL_61F:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_62A:
			if (num17 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x001CC50C File Offset: 0x001CA90C
		private void ProcessWaves()
		{
			int num3;
			int num19;
			object obj;
			try
			{
				IL_01:
				int num = 1;
				int num2 = (this._activeBuffer == 0) ? 1 : 0;
				IL_12:
				num = 2;
				bool weHaveWaves = false;
				IL_17:
				num = 3;
				bool flag = num2 < 0;
				if (!flag)
				{
					goto IL_29;
				}
				IL_24:
				num = 4;
				num2 = 1;
				IL_29:
				ProjectData.ClearProjectError();
				num3 = -2;
				IL_32:
				num = 7;
				int num4 = 1;
				int num5 = this._waveWidth - 2;
				int num6 = num4;
				for (;;)
				{
					int num7 = num6;
					int num8 = num5;
					if (num7 > num8)
					{
						break;
					}
					IL_46:
					num = 8;
					int num9 = 1;
					int num10 = this._waveHeight - 2;
					int num11 = num9;
					for (;;)
					{
						int num12 = num11;
						num8 = num10;
						if (num12 > num8)
						{
							break;
						}
						IL_5A:
						num = 9;
						this._waves[num6, num11, num2] = (short)(this._waves[num6 - 1, num11 - 1, this._activeBuffer] + this._waves[num6, num11 - 1, this._activeBuffer] + this._waves[num6 + 1, num11 - 1, this._activeBuffer] + this._waves[num6 - 1, num11, this._activeBuffer] + this._waves[num6 + 1, num11, this._activeBuffer] + this._waves[num6 - 1, num11 + 1, this._activeBuffer] + this._waves[num6, num11 + 1, this._activeBuffer] + this._waves[num6 + 1, num11 + 1, this._activeBuffer] >> 2) - this._waves[num6, num11, num2];
						IL_13D:
						num = 10;
						flag = (this._waves[num6, num11, num2] != 0);
						if (flag)
						{
							IL_15B:
							num = 11;
							short[,,] waves = this._waves;
							short[,,] array = waves;
							int num13 = num6;
							int num14 = num13;
							int num15 = num11;
							int num16 = num15;
							int num17 = num2;
							array[num14, num16, num17] = waves[num13, num15, num17] - (short)(this._waves[num6, num11, num2] >> 4);
							IL_19D:
							num = 12;
							weHaveWaves = true;
						}
						IL_1A3:
						IL_1A4:
						num = 14;
						flag = (Information.Err().Number != 0);
						if (flag)
						{
							break;
						}
						IL_1C1:
						num = 17;
						num11++;
					}
					IL_1D6:
					num = 18;
					flag = (Information.Err().Number != 0);
					if (flag)
					{
						break;
					}
					IL_1F3:
					num = 21;
					num6++;
					continue;
					IL_1BF:
					goto IL_1D6;
				}
				IL_1F1:
				IL_208:
				num = 22;
				this._weHaveWaves = weHaveWaves;
				IL_213:
				num = 23;
				this._activeBuffer = num2;
				IL_21E:
				goto IL_2E4;
				IL_227:
				int num18 = num19 + 1;
				num19 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num18);
				IL_297:
				goto IL_2D9;
				IL_299:
				num19 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num3 > -2) ? num3 : 1);
				IL_2B5:;
			}
			catch when (endfilter(obj is Exception & num3 != 0 & num19 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_299;
			}
			IL_2D9:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_2E4:
			if (num19 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x001CC824 File Offset: 0x001CAC24
		private void PutDrop(int x, int y, short height)
		{
			int num3;
			int num15;
			object obj;
			try
			{
				IL_01:
				int num = 1;
				this._weHaveWaves = true;
				IL_0B:
				num = 2;
				int num2 = 20;
				IL_11:
				ProjectData.ClearProjectError();
				num3 = -2;
				IL_1A:
				num = 4;
				int num4 = -num2;
				int num5 = num2;
				int num6 = num4;
				for (;;)
				{
					int num7 = num6;
					int num8 = num5;
					if (num7 > num8)
					{
						break;
					}
					IL_28:
					num = 5;
					int num9 = -num2;
					int num10 = num2;
					int num11 = num9;
					bool flag;
					for (;;)
					{
						int num12 = num11;
						num8 = num10;
						if (num12 > num8)
						{
							break;
						}
						IL_36:
						num = 6;
						flag = (x + num6 >= 0 && x + num6 < this._waveWidth - 1 && y + num11 >= 0 && y + num11 < this._waveHeight - 1);
						if (flag)
						{
							IL_69:
							num = 7;
							double num13 = Math.Sqrt((double)(num6 * num6 + num11 * num11));
							IL_7A:
							num = 8;
							flag = (num13 < (double)num2);
							if (flag)
							{
								IL_88:
								num = 9;
								this._waves[x + num6, y + num11, this._activeBuffer] = (short)Math.Round(Math.Cos(num13 * 3.1415926535897931 / (double)num2) * (double)height);
							}
							IL_BF:;
						}
						IL_C0:
						IL_C1:
						num = 12;
						flag = (Information.Err().Number != 0);
						if (flag)
						{
							goto IL_DB;
						}
						IL_E1:
						num = 15;
						num11++;
					}
					IL_F6:
					num = 16;
					flag = (Information.Err().Number != 0);
					if (flag)
					{
						break;
					}
					IL_116:
					num = 19;
					num6++;
				}
				IL_DB:
				IL_110:
				IL_12B:
				goto IL_1E1;
				IL_134:
				int num14 = num15 + 1;
				num15 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num14);
				IL_194:
				goto IL_1D6;
				IL_196:
				num15 = num;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num3 > -2) ? num3 : 1);
				IL_1B2:;
			}
			catch when (endfilter(obj is Exception & num3 != 0 & num15 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_196;
			}
			IL_1D6:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_1E1:
			if (num15 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x001CCA38 File Offset: 0x001CAE38
		private void WaterEffectControl_MouseMove(object sender, MouseEventArgs e)
		{
			int num;
			int num4;
			object obj;
			try
			{
				IL_01:
				ProjectData.ClearProjectError();
				num = -2;
				IL_09:
				int num2 = 2;
				bool flag = !this.__IsBusy;
				if (!flag)
				{
					goto IL_A0;
				}
				IL_1E:
				num2 = 3;
				int x = (int)Math.Round((double)e.X / (double)this.ClientRectangle.Width * (double)this._waveWidth);
				IL_47:
				num2 = 4;
				int y = (int)Math.Round((double)e.Y / (double)this.ClientRectangle.Height * (double)this._waveHeight);
				IL_70:
				num2 = 5;
				flag = (Information.Err().Number != 0);
				if (!flag)
				{
					goto IL_8F;
				}
				IL_89:
				goto IL_15C;
				IL_8F:
				num2 = 8;
				this.PutDrop(x, y, 200);
				IL_A0:
				IL_A1:
				num2 = 10;
				flag = !this.tmrBalance.Enabled;
				if (!flag)
				{
					goto IL_C9;
				}
				IL_B9:
				num2 = 11;
				this.tmrBalance.Start();
				IL_C9:
				goto IL_15C;
				IL_D2:
				int num3 = num4 + 1;
				num4 = 0;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], num3);
				IL_112:
				goto IL_151;
				IL_114:
				num4 = num2;
				@switch(ICSharpCode.Decompiler.ILAst.ILLabel[], (num > -2) ? num : 1);
				IL_12E:;
			}
			catch when (endfilter(obj is Exception & num != 0 & num4 == 0))
			{
				Exception ex = (Exception)obj2;
				goto IL_114;
			}
			IL_151:
			throw ProjectData.CreateProjectError(-2146828237);
			IL_15C:
			if (num4 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000051 RID: 81 RVA: 0x001CCBC8 File Offset: 0x001CAFC8
		// (set) Token: 0x06000052 RID: 82 RVA: 0x001CCBE0 File Offset: 0x001CAFE0
		public Bitmap ImageBitmap
		{
			get
			{
				return this._bmp;
			}
			set
			{
				this._bmp = value;
				bool flag = Information.IsNothing(this._bmp);
				if (flag)
				{
					this.effectTimer.Stop();
					this.tmrBalance.Stop();
				}
				else
				{
					this.effectTimer.Start();
					this.__IsBusy = false;
					this._bmpHeight = this._bmp.Height;
					this._bmpWidth = this._bmp.Width;
					this._waveWidth = this._bmpWidth >> this._scale;
					this._waveHeight = this._bmpHeight >> this._scale;
					this._waves = new short[this._waveWidth - 1 + 1, this._waveHeight - 1 + 1, 2];
					this._bmpBytes = new byte[this._bmpWidth * this._bmpHeight * 4 - 1 + 1];
					Bitmap bmp = this._bmp;
					Rectangle rect = new Rectangle(0, 0, this._bmpWidth, this._bmpHeight);
					this._bmpBitmapData = bmp.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
					Marshal.Copy(this._bmpBitmapData.Scan0, this._bmpBytes, 0, this._bmpWidth * this._bmpHeight * 4);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000053 RID: 83 RVA: 0x001CCD1C File Offset: 0x001CB11C
		// (set) Token: 0x06000054 RID: 84 RVA: 0x001CCD34 File Offset: 0x001CB134
		public new int Scale
		{
			get
			{
				return this._scale;
			}
			set
			{
				this._scale = value;
			}
		}

		// Token: 0x0400001D RID: 29
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400001E RID: 30
		private Timer effectTimer;

		// Token: 0x0400001F RID: 31
		private Timer tmrBalance;

		// Token: 0x04000020 RID: 32
		private IContainer components;

		// Token: 0x04000021 RID: 33
		private Bitmap _bmp;

		// Token: 0x04000022 RID: 34
		private short[,,] _waves;

		// Token: 0x04000023 RID: 35
		private int _waveWidth;

		// Token: 0x04000024 RID: 36
		private int _waveHeight;

		// Token: 0x04000025 RID: 37
		private int _activeBuffer;

		// Token: 0x04000026 RID: 38
		private bool _weHaveWaves;

		// Token: 0x04000027 RID: 39
		private int _bmpHeight;

		// Token: 0x04000028 RID: 40
		private int _bmpWidth;

		// Token: 0x04000029 RID: 41
		private byte[] _bmpBytes;

		// Token: 0x0400002A RID: 42
		private BitmapData _bmpBitmapData;

		// Token: 0x0400002B RID: 43
		private int _scale;

		// Token: 0x0400002C RID: 44
		private bool __IsBusy;
	}
}
