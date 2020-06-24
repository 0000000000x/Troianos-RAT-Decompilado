using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.My;

namespace Troianos_RAT
{
	// Token: 0x02000021 RID: 33
	internal sealed class Class6
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x001CCD4C File Offset: 0x001CB14C
		[DebuggerNonUserCode]
		public Class6()
		{
		}

		// Token: 0x060003FE RID: 1022
		[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr memcpy(IntPtr intptr_0, IntPtr intptr_1, int int_0);

		// Token: 0x060003FF RID: 1023 RVA: 0x001CCD58 File Offset: 0x001CB158
		public static string smethod_0(int int_0, int int_1)
		{
			bool flag = int_1 == 0;
			string result;
			if (flag)
			{
				result = "%00.0";
			}
			else
			{
				result = (double.Parse(Conversions.ToString(int_0)) / double.Parse(Conversions.ToString(int_1)) * 100.0 / 100.0).ToString("%00.0").Replace("100.0", "100");
			}
			return result;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x001CCDC4 File Offset: 0x001CB1C4
		public static int smethod_1(int int_0, int int_1)
		{
			bool flag = int_1 == 0;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				result = (int)Math.Round(Math.Round((double)int_0 / (double)int_1 * 100.0));
			}
			return result;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x001CCE00 File Offset: 0x001CB200
		public static Form smethod_10(string string_0)
		{
			return MyProject.Application.OpenForms[string_0];
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x001CCE24 File Offset: 0x001CB224
		public static byte[] smethod_11(ref string string_0)
		{
			return Encoding.Default.GetBytes(string_0);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x001CCE44 File Offset: 0x001CB244
		public static string smethod_12(ref byte[] byte_0)
		{
			return Encoding.Default.GetString(byte_0);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x001CCE64 File Offset: 0x001CB264
		public static string smethod_13()
		{
			return MyProject.Computer.Clock.LocalTime.ToString("[hh:mm:ss]");
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x001CCE94 File Offset: 0x001CB294
		public static string smethod_14(ref string string_0)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(string_0));
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x001CCEB8 File Offset: 0x001CB2B8
		public static int smethod_15(int int_0, int int_1, bool bool_0)
		{
			Class6.long_0 = (long)Math.Round(Math.Round((double)Class6.long_0 + 333.33));
			Random random = new Random((int)Class6.long_0);
			return random.Next(int_0, int_1 + 1);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x001CCF04 File Offset: 0x001CB304
		public static string smethod_16(string string_0)
		{
			int num = 0;
			string result;
			for (;;)
			{
				try
				{
					byte[] bytes = Convert.FromBase64String(string_0);
					result = Encoding.UTF8.GetString(bytes);
					break;
				}
				catch (Exception ex)
				{
					num++;
					bool flag = num == 3;
					if (flag)
					{
						result = null;
						break;
					}
					string_0 += "=";
				}
			}
			return result;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x001CCF90 File Offset: 0x001CB390
		public static string smethod_17(long long_1)
		{
			bool flag = long_1.ToString().Length < 4;
			string result;
			if (flag)
			{
				result = Conversions.ToString(long_1) + " Bytes";
			}
			else
			{
				string str = string.Empty;
				double num = (double)long_1 / 1024.0;
				flag = (num < 1024.0);
				if (flag)
				{
					str = "KB";
				}
				else
				{
					num /= 1024.0;
					flag = (num < 1024.0);
					if (flag)
					{
						str = "MB";
					}
					else
					{
						num /= 1024.0;
						str = "GB";
					}
				}
				result = num.ToString(".0") + " " + str;
			}
			return result;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x001CD048 File Offset: 0x001CB448
		public static string smethod_2(string string_0, string string_1)
		{
			string result;
			try
			{
				result = Conversions.ToString(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.CurrentUser.OpenSubKey("Software\\" + Class7.string_0).GetValue(string_0, string_1)));
			}
			catch (Exception ex)
			{
				result = string_1;
			}
			return result;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x001CD0C4 File Offset: 0x001CB4C4
		public static void smethod_3(string string_0, string string_1)
		{
			bool flag = string_1 == null;
			if (flag)
			{
				string_1 = string.Empty;
			}
			try
			{
				MyProject.Computer.Registry.CurrentUser.CreateSubKey("Software\\" + Class7.string_0).SetValue(string_0, string_1);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x001CD140 File Offset: 0x001CB540
		public static string smethod_4(string string_0)
		{
			return Class6.smethod_5(Class6.smethod_11(ref string_0));
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x001CD160 File Offset: 0x001CB560
		public static string smethod_5(byte[] byte_0)
		{
			byte_0 = new MD5CryptoServiceProvider().ComputeHash(byte_0);
			string text = string.Empty;
			foreach (byte b in byte_0)
			{
				text += b.ToString("x2");
			}
			return text;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x001CD1B8 File Offset: 0x001CB5B8
		public static string smethod_6(int int_0)
		{
			Random random = new Random();
			string text = string.Empty;
			string text2 = "abcdefghijklmnopqrstuvwxyz";
			for (int i = 1; i <= int_0; i++)
			{
				text += Conversions.ToString(text2[random.Next(0, text2.Length)]);
			}
			return text;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x001CD21C File Offset: 0x001CB61C
		public static TreeNode smethod_7(string string_0, TreeNodeCollection treeNodeCollection_0)
		{
			bool flag = string_0.EndsWith("\\");
			if (flag)
			{
				string_0 = string_0.Remove(string_0.Length - 1, 1);
			}
			TreeNode treeNode = null;
			foreach (string key in Strings.Split(string_0, "\\", -1, CompareMethod.Binary))
			{
				treeNode = treeNodeCollection_0[key];
				treeNodeCollection_0 = treeNode.Nodes;
			}
			return treeNode;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x001CD290 File Offset: 0x001CB690
		public static byte[] smethod_8(byte[] byte_0, ref bool bool_0)
		{
			bool flag = bool_0;
			byte[] result;
			if (flag)
			{
				MemoryStream memoryStream = new MemoryStream();
				GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress, true);
				gzipStream.Write(byte_0, 0, byte_0.Length);
				gzipStream.Dispose();
				memoryStream.Position = 0L;
				byte[] array = new byte[(int)memoryStream.Length + 1 - 1 + 1];
				memoryStream.Read(array, 0, array.Length);
				memoryStream.Dispose();
				result = array;
			}
			else
			{
				MemoryStream memoryStream2 = new MemoryStream(byte_0);
				GZipStream gzipStream2 = new GZipStream(memoryStream2, CompressionMode.Decompress);
				byte[] array2 = new byte[4];
				memoryStream2.Position = memoryStream2.Length - 5L;
				memoryStream2.Read(array2, 0, 4);
				int num = BitConverter.ToInt32(array2, 0);
				memoryStream2.Position = 0L;
				byte[] array3 = new byte[num - 1 + 1 - 1 + 1];
				gzipStream2.Read(array3, 0, num);
				gzipStream2.Dispose();
				memoryStream2.Dispose();
				result = array3;
			}
			return result;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x001CD380 File Offset: 0x001CB780
		public static Array smethod_9(byte[] byte_0, string string_0)
		{
			List<byte[]> list = new List<byte[]>();
			int num = Array.IndexOf<byte>(byte_0, (byte)Strings.Asc(string_0[0]));
			bool flag;
			for (;;)
			{
				flag = !(num > -1 & num + string_0.Length <= byte_0.Length);
				if (flag)
				{
					break;
				}
				byte[] array = new byte[string_0.Length - 1 + 1 - 1 + 1];
				int num2 = 0;
				int num3 = num + string_0.Length - 1;
				for (int i = num; i <= num3; i++)
				{
					array[num2] = byte_0[i];
					num2++;
				}
				flag = (Operators.CompareString(Class6.smethod_12(ref array), string_0, false) == 0);
				if (flag)
				{
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write(byte_0, 0, num);
					list.Add(memoryStream.ToArray());
					memoryStream.Dispose();
					memoryStream = new MemoryStream();
					memoryStream.Write(byte_0, num + string_0.Length, byte_0.Length - (num + string_0.Length));
					list.Add(memoryStream.ToArray());
					memoryStream.Dispose();
					break;
				}
				num = Array.IndexOf<byte>(byte_0, (byte)Strings.Asc(string_0[0]), num + 1);
			}
			flag = (list.Count == 0);
			if (flag)
			{
				list.Add(byte_0);
			}
			return list.ToArray();
		}

		// Token: 0x040001E9 RID: 489
		public static long long_0 = 0L;
	}
}
