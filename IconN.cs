using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Troianos_RAT
{
	// Token: 0x02000032 RID: 50
	public class IconN
	{
		// Token: 0x0600047B RID: 1147 RVA: 0x001D8D58 File Offset: 0x001D7158
		[DebuggerNonUserCode]
		public IconN()
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x001D8D64 File Offset: 0x001D7164
		public static void InjectIcon(string exeFileName, string iconFileName)
		{
			IconN.InjectIcon(exeFileName, iconFileName, 1U, 1U);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x001D8D74 File Offset: 0x001D7174
		public static void InjectIcon(string exeFileName, string iconFileName, uint iconGroupID, uint iconBaseID)
		{
			IconN.IconFile iconFile = IconN.IconFile.FromFile(iconFileName);
			IntPtr intPtr = IconN.NativeMethods.BeginUpdateResource(exeFileName, false);
			byte[] array = iconFile.CreateIconGroupData(iconBaseID);
			IntPtr hUpdate = intPtr;
			IntPtr intPtr2 = new IntPtr(14L);
			IntPtr type = intPtr2;
			IntPtr intPtr3 = new IntPtr((long)((ulong)iconGroupID));
			IconN.NativeMethods.UpdateResource(hUpdate, type, intPtr3, 0, array, array.Length);
			int num = 0;
			int num2 = iconFile.ImageCount - 1;
			int num3 = num;
			for (;;)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				byte[] array2 = iconFile.get_ImageData(num3);
				IntPtr hUpdate2 = intPtr;
				intPtr3 = new IntPtr(3L);
				IntPtr type2 = intPtr3;
				intPtr2 = new IntPtr((long)((ulong)iconBaseID + (ulong)((long)num3)));
				IconN.NativeMethods.UpdateResource(hUpdate2, type2, intPtr2, 0, array2, array2.Length);
				num3++;
			}
			IconN.NativeMethods.EndUpdateResource(intPtr, false);
		}

		// Token: 0x02000033 RID: 51
		[SuppressUnmanagedCodeSecurity]
		private class NativeMethods
		{
			// Token: 0x0600047E RID: 1150 RVA: 0x001D8E18 File Offset: 0x001D7218
			[DebuggerNonUserCode]
			public NativeMethods()
			{
			}

			// Token: 0x0600047F RID: 1151
			[DllImport("kernel32")]
			public static extern IntPtr BeginUpdateResource(string fileName, [MarshalAs(UnmanagedType.Bool)] bool deleteExistingResources);

			// Token: 0x06000480 RID: 1152
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool UpdateResource(IntPtr hUpdate, IntPtr type, IntPtr name, short language, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] data, int dataSize);

			// Token: 0x06000481 RID: 1153
			[DllImport("kernel32")]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool EndUpdateResource(IntPtr hUpdate, [MarshalAs(UnmanagedType.Bool)] bool discard);
		}

		// Token: 0x02000034 RID: 52
		private struct ICONDIR
		{
			// Token: 0x0400028B RID: 651
			public ushort Reserved;

			// Token: 0x0400028C RID: 652
			public ushort Type;

			// Token: 0x0400028D RID: 653
			public ushort Count;
		}

		// Token: 0x02000035 RID: 53
		private struct ICONDIRENTRY
		{
			// Token: 0x0400028E RID: 654
			public byte Width;

			// Token: 0x0400028F RID: 655
			public byte Height;

			// Token: 0x04000290 RID: 656
			public byte ColorCount;

			// Token: 0x04000291 RID: 657
			public byte Reserved;

			// Token: 0x04000292 RID: 658
			public ushort Planes;

			// Token: 0x04000293 RID: 659
			public ushort BitCount;

			// Token: 0x04000294 RID: 660
			public int BytesInRes;

			// Token: 0x04000295 RID: 661
			public int ImageOffset;
		}

		// Token: 0x02000036 RID: 54
		private struct BITMAPINFOHEADER
		{
			// Token: 0x04000296 RID: 662
			public uint Size;

			// Token: 0x04000297 RID: 663
			public int Width;

			// Token: 0x04000298 RID: 664
			public int Height;

			// Token: 0x04000299 RID: 665
			public ushort Planes;

			// Token: 0x0400029A RID: 666
			public ushort BitCount;

			// Token: 0x0400029B RID: 667
			public uint Compression;

			// Token: 0x0400029C RID: 668
			public uint SizeImage;

			// Token: 0x0400029D RID: 669
			public int XPelsPerMeter;

			// Token: 0x0400029E RID: 670
			public int YPelsPerMeter;

			// Token: 0x0400029F RID: 671
			public uint ClrUsed;

			// Token: 0x040002A0 RID: 672
			public uint ClrImportant;
		}

		// Token: 0x02000037 RID: 55
		[StructLayout(LayoutKind.Sequential, Pack = 2)]
		private struct GRPICONDIRENTRY
		{
			// Token: 0x040002A1 RID: 673
			public byte Width;

			// Token: 0x040002A2 RID: 674
			public byte Height;

			// Token: 0x040002A3 RID: 675
			public byte ColorCount;

			// Token: 0x040002A4 RID: 676
			public byte Reserved;

			// Token: 0x040002A5 RID: 677
			public ushort Planes;

			// Token: 0x040002A6 RID: 678
			public ushort BitCount;

			// Token: 0x040002A7 RID: 679
			public int BytesInRes;

			// Token: 0x040002A8 RID: 680
			public ushort ID;
		}

		// Token: 0x02000038 RID: 56
		private class IconFile
		{
			// Token: 0x1700014E RID: 334
			// (get) Token: 0x06000482 RID: 1154 RVA: 0x001D8E24 File Offset: 0x001D7224
			public int ImageCount
			{
				get
				{
					return (int)this.iconDir.Count;
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000483 RID: 1155 RVA: 0x001D8E44 File Offset: 0x001D7244
			public byte[] ImageData
			{
				get
				{
					return this.iconImage[index];
				}
			}

			// Token: 0x06000484 RID: 1156 RVA: 0x001D8E60 File Offset: 0x001D7260
			private IconFile()
			{
				this.iconDir = default(IconN.ICONDIR);
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x001D8E78 File Offset: 0x001D7278
			public static IconN.IconFile FromFile(string filename)
			{
				IconN.IconFile iconFile = new IconN.IconFile();
				byte[] array = File.ReadAllBytes(filename);
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				iconFile.iconDir = (IconN.ICONDIR)Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), typeof(IconN.ICONDIR));
				iconFile.iconEntry = new IconN.ICONDIRENTRY[(int)(iconFile.iconDir.Count - 1 + 1)];
				iconFile.iconImage = new byte[(int)(iconFile.iconDir.Count - 1 + 1)][];
				int num = Marshal.SizeOf(iconFile.iconDir);
				Type typeFromHandle = typeof(IconN.ICONDIRENTRY);
				int num2 = Marshal.SizeOf(typeFromHandle);
				int num3 = 0;
				int num4 = (int)(iconFile.iconDir.Count - 1);
				int num5 = num3;
				for (;;)
				{
					int num6 = num5;
					int num7 = num4;
					if (num6 > num7)
					{
						break;
					}
					IntPtr ptr = new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num);
					IconN.ICONDIRENTRY icondirentry = (IconN.ICONDIRENTRY)Marshal.PtrToStructure(ptr, typeFromHandle);
					iconFile.iconEntry[num5] = icondirentry;
					iconFile.iconImage[num5] = new byte[icondirentry.BytesInRes - 1 + 1];
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage[num5], 0, icondirentry.BytesInRes);
					num += num2;
					num5++;
				}
				gchandle.Free();
				return iconFile;
			}

			// Token: 0x06000486 RID: 1158 RVA: 0x001D8FD8 File Offset: 0x001D73D8
			public byte[] CreateIconGroupData(uint iconBaseID)
			{
				int num = Marshal.SizeOf(typeof(IconN.ICONDIR)) + Marshal.SizeOf(typeof(IconN.GRPICONDIRENTRY)) * this.ImageCount;
				byte[] array = new byte[num - 1 + 1];
				GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
				Marshal.StructureToPtr(this.iconDir, gchandle.AddrOfPinnedObject(), false);
				int num2 = Marshal.SizeOf(this.iconDir);
				int num3 = 0;
				int num4 = this.ImageCount - 1;
				int num5 = num3;
				for (;;)
				{
					int num6 = num5;
					int num7 = num4;
					if (num6 > num7)
					{
						break;
					}
					IconN.GRPICONDIRENTRY grpicondirentry = default(IconN.GRPICONDIRENTRY);
					IconN.BITMAPINFOHEADER bitmapinfoheader = default(IconN.BITMAPINFOHEADER);
					GCHandle gchandle2 = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned);
					Marshal.Copy(this.get_ImageData(num5), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(typeof(IconN.BITMAPINFOHEADER)));
					gchandle2.Free();
					grpicondirentry.Width = this.iconEntry[num5].Width;
					grpicondirentry.Height = this.iconEntry[num5].Height;
					grpicondirentry.ColorCount = this.iconEntry[num5].ColorCount;
					grpicondirentry.Reserved = this.iconEntry[num5].Reserved;
					grpicondirentry.Planes = bitmapinfoheader.Planes;
					grpicondirentry.BitCount = bitmapinfoheader.BitCount;
					grpicondirentry.BytesInRes = this.iconEntry[num5].BytesInRes;
					grpicondirentry.ID = (ushort)((ulong)iconBaseID + (ulong)((long)num5));
					object structure = grpicondirentry;
					IntPtr ptr = new IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + (long)num2);
					Marshal.StructureToPtr(structure, ptr, false);
					num2 += Marshal.SizeOf(typeof(IconN.GRPICONDIRENTRY));
					num5++;
				}
				gchandle.Free();
				return array;
			}

			// Token: 0x040002A9 RID: 681
			private IconN.ICONDIR iconDir;

			// Token: 0x040002AA RID: 682
			private IconN.ICONDIRENTRY[] iconEntry;

			// Token: 0x040002AB RID: 683
			private byte[][] iconImage;
		}
	}
}
