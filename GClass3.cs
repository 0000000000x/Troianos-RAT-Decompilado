using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x02000029 RID: 41
	public sealed class GClass3
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x001D5EE4 File Offset: 0x001D42E4
		public GClass3(string string_3) : this(string_3, GClass3.int_20)
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x001D5EF8 File Offset: 0x001D42F8
		public GClass3(string string_3, int int_26)
		{
			this.fileStream_0 = null;
			this.gclass5_0 = null;
			this.object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(new object())));
			this.byte_0 = Convert.ToByte(GClass5.int_0);
			this.int_3 = 0;
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					this.fileStream_0 = new FileStream(string_3, FileMode.Open, FileAccess.Read);
				}
				this.int_2 = int_26;
				this.method_0();
			}
			catch (SystemException ex)
			{
				Console.Write("cannot open file " + string_3 + "\n");
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x001D5FF4 File Offset: 0x001D43F4
		private void method_0()
		{
			byte[] array = new byte[3];
			byte[] array2 = new byte[GClass3.int_9 - 1 + 1 - 1 + 1];
			this.byte_0 = (byte)GClass5.int_0;
			this.int_1 = GClass3.int_10;
			object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
			ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
			object obj = objectValue;
			ObjectFlowControl.CheckForSyncLockOnValueType(obj);
			lock (obj)
			{
				this.fileStream_0.Seek(-3L, SeekOrigin.End);
				int num = GClass3.int_6 - 1;
				bool flag;
				for (int i = 0; i <= num; i++)
				{
					this.fileStream_0.Read(array, 0, 3);
					flag = (array[0] == byte.MaxValue && array[1] == byte.MaxValue && array[2] == byte.MaxValue);
					if (flag)
					{
						this.byte_0 = Convert.ToByte(this.fileStream_0.ReadByte());
						flag = (this.byte_0 >= 106);
						if (flag)
						{
							this.byte_0 -= 105;
						}
						flag = ((int)this.byte_0 == GClass5.int_1);
						if (flag)
						{
							this.int_0 = new int[]
							{
								GClass3.int_15
							};
							this.int_1 = GClass3.int_10;
						}
						else
						{
							flag = ((int)this.byte_0 == GClass5.int_2);
							if (flag)
							{
								this.int_0 = new int[]
								{
									GClass3.int_16
								};
								this.int_1 = GClass3.int_10;
							}
							else
							{
								bool flag2;
								if ((int)this.byte_0 != GClass5.int_3 && (int)this.byte_0 != GClass5.int_4)
								{
									if ((int)this.byte_0 != GClass5.int_5 && (int)this.byte_0 != GClass5.int_14)
									{
										if ((int)this.byte_0 != GClass5.int_6 && (int)this.byte_0 != GClass5.int_13)
										{
											if ((int)this.byte_0 != GClass5.int_8 && (int)this.byte_0 != GClass5.int_12)
											{
												if ((int)this.byte_0 != GClass5.int_18 && (int)this.byte_0 != GClass5.int_19)
												{
													if ((int)this.byte_0 != GClass5.int_17 && (int)this.byte_0 != GClass5.int_16)
													{
														flag2 = false;
														goto IL_215;
													}
												}
											}
										}
									}
								}
								flag2 = true;
								IL_215:
								flag = flag2;
								if (flag)
								{
									this.int_0 = new int[]
									{
										0
									};
									bool flag3;
									if ((int)this.byte_0 != GClass5.int_3 && (int)this.byte_0 != GClass5.int_4)
									{
										if ((int)this.byte_0 != GClass5.int_12 && (int)this.byte_0 != GClass5.int_18)
										{
											if ((int)this.byte_0 != GClass5.int_19 && (int)this.byte_0 != GClass5.int_17)
											{
												if ((int)this.byte_0 != GClass5.int_16 && (int)this.byte_0 != GClass5.int_8)
												{
													flag3 = false;
													goto IL_2A5;
												}
											}
										}
									}
									flag3 = true;
									IL_2A5:
									flag = flag3;
									if (flag)
									{
										this.int_1 = GClass3.int_10;
									}
									else
									{
										this.int_1 = GClass3.int_11;
									}
									this.fileStream_0.Read(array2, 0, GClass3.int_9);
									int num2 = GClass3.int_9 - 1;
									for (int j = 0; j <= num2; j++)
									{
										int num3 = 0;
										this.int_0[num3] = this.int_0[num3] + (GClass3.smethod_2(array2[j]) << j * 8);
									}
								}
							}
						}
						break;
					}
					this.fileStream_0.Seek(-4L, SeekOrigin.Current);
				}
				bool flag4;
				if ((int)this.byte_0 != GClass5.int_0 && (int)this.byte_0 != GClass5.int_11)
				{
					if ((int)this.byte_0 != GClass5.int_7 && (int)this.byte_0 != GClass5.int_9)
					{
						flag4 = false;
						goto IL_388;
					}
				}
				flag4 = true;
				IL_388:
				flag = flag4;
				if (flag)
				{
					this.int_0 = new int[]
					{
						GClass3.int_4
					};
					this.int_1 = GClass3.int_10;
				}
				flag = ((this.int_2 & GClass3.int_21) == 1);
				if (flag)
				{
					int num4 = (int)this.fileStream_0.Length;
					this.byte_1 = new byte[num4 - 1 + 1 - 1 + 1];
					this.fileStream_0.Seek(0L, SeekOrigin.Begin);
					this.fileStream_0.Read(this.byte_1, 0, num4);
				}
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x001D643C File Offset: 0x001D483C
		public void method_1()
		{
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
				object obj = objectValue;
				ObjectFlowControl.CheckForSyncLockOnValueType(obj);
				lock (obj)
				{
					this.fileStream_0.Close();
				}
				this.fileStream_0 = null;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x001D64D4 File Offset: 0x001D48D4
		public GClass5 method_10()
		{
			bool flag = this.gclass5_0 != null;
			GClass5 result;
			if (flag)
			{
				result = this.gclass5_0;
			}
			else
			{
				try
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						bool flag2 = false;
						byte[] array = new byte[3];
						this.fileStream_0.Seek(-3L, SeekOrigin.End);
						int num = GClass3.int_6 - 1;
						for (int i = 0; i <= num; i++)
						{
							this.fileStream_0.Read(array, 0, 3);
							flag = (array[0] == byte.MaxValue && array[1] == byte.MaxValue && array[2] == byte.MaxValue);
							if (flag)
							{
								flag2 = true;
								break;
							}
							this.fileStream_0.Seek(-4L, SeekOrigin.Current);
						}
						flag = flag2;
						if (flag)
						{
							this.fileStream_0.Seek(-6L, SeekOrigin.Current);
						}
						else
						{
							this.fileStream_0.Seek(-3L, SeekOrigin.End);
						}
						int num2 = GClass3.int_7 - 1;
						for (int j = 0; j <= num2; j++)
						{
							this.fileStream_0.Read(array, 0, 3);
							flag = (array[0] == 0 && array[1] == 0 && array[2] == 0);
							if (flag)
							{
								byte[] array2 = new byte[j - 1 + 1 - 1 + 1];
								char[] array3 = new char[j - 1 + 1 - 1 + 1];
								this.fileStream_0.Read(array2, 0, j);
								int num3 = j - 1;
								for (int k = 0; k <= num3; k++)
								{
									array3[k] = Convert.ToChar(array2[k]);
								}
								this.gclass5_0 = new GClass5(new string(array3));
								return this.gclass5_0;
							}
							this.fileStream_0.Seek(-4L, SeekOrigin.Current);
						}
					}
				}
				catch (Exception ex)
				{
					Exception ex2 = ex;
					Console.Write(ex2.Message);
				}
				result = new GClass5(string.Empty);
			}
			return result;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x001D6748 File Offset: 0x001D4B48
		public GClass6 method_11(IPAddress ipaddress_0)
		{
			return this.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress_0.GetAddressBytes())));
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x001D6770 File Offset: 0x001D4B70
		public GClass6 method_12(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return null;
			}
			return this.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress.GetAddressBytes())));
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x001D67E8 File Offset: 0x001D4BE8
		public string method_13(IPAddress ipaddress_0)
		{
			return this.method_17(GClass3.smethod_1(ipaddress_0.GetAddressBytes()));
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x001D680C File Offset: 0x001D4C0C
		public string method_14(string string_3)
		{
			IPAddress ipaddress_;
			try
			{
				ipaddress_ = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return null;
			}
			return this.method_16(ipaddress_);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x001D6874 File Offset: 0x001D4C74
		public string method_15(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return null;
			}
			return this.method_17(GClass3.smethod_1(ipaddress.GetAddressBytes()));
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x001D68E8 File Offset: 0x001D4CE8
		[MethodImpl(MethodImplOptions.Synchronized)]
		public string method_16(IPAddress ipaddress_0)
		{
			int num = 0;
			byte[] array = new byte[GClass3.int_13 - 1 + 1 - 1 + 1];
			char[] array2 = new char[GClass3.int_13 - 1 + 1 - 1 + 1];
			string result;
			try
			{
				int num2 = this.method_18(ipaddress_0);
				bool flag = num2 == this.int_0[0];
				if (flag)
				{
					return null;
				}
				int num3 = num2 + (2 * this.int_1 - 1) * this.int_0[0];
				flag = ((this.int_2 & GClass3.int_21) == 1);
				if (flag)
				{
					Array.Copy(this.byte_1, num3, array, 0, Math.Min(this.byte_1.Length - num3, GClass3.int_13));
				}
				else
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						this.fileStream_0.Seek((long)num3, SeekOrigin.Begin);
						this.fileStream_0.Read(array, 0, GClass3.int_13);
					}
				}
				while (array[num] != 0)
				{
					array2[num] = Convert.ToChar(array[num]);
					num++;
				}
				array2[num] = '\0';
				result = new string(array2, 0, num);
			}
			catch (IOException ex)
			{
				Console.Write("IO Exception");
				result = null;
			}
			return result;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x001D6A94 File Offset: 0x001D4E94
		[MethodImpl(MethodImplOptions.Synchronized)]
		public string method_17(long long_0)
		{
			int num = 0;
			byte[] array = new byte[GClass3.int_13 - 1 + 1 - 1 + 1];
			char[] array2 = new char[GClass3.int_13 - 1 + 1 - 1 + 1];
			string result;
			try
			{
				int num2 = this.method_19(long_0);
				bool flag = num2 == this.int_0[0];
				if (flag)
				{
					return null;
				}
				int num3 = num2 + (2 * this.int_1 - 1) * this.int_0[0];
				flag = ((this.int_2 & GClass3.int_21) == 1);
				if (flag)
				{
					Array.Copy(this.byte_1, num3, array, 0, Math.Min(this.byte_1.Length - num3, GClass3.int_13));
				}
				else
				{
					object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						this.fileStream_0.Seek((long)num3, SeekOrigin.Begin);
						this.fileStream_0.Read(array, 0, GClass3.int_13);
					}
				}
				while (array[num] != 0)
				{
					array2[num] = Convert.ToChar(array[num]);
					num++;
				}
				array2[num] = '\0';
				result = new string(array2, 0, num);
			}
			catch (IOException ex)
			{
				Console.Write("IO Exception");
				result = null;
			}
			return result;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x001D6C40 File Offset: 0x001D5040
		[MethodImpl(MethodImplOptions.Synchronized)]
		private int method_18(IPAddress ipaddress_0)
		{
			byte[] addressBytes = ipaddress_0.GetAddressBytes();
			byte[] array = new byte[2 * GClass3.int_12 - 1 + 1 - 1 + 1];
			int[] array2 = new int[2];
			int num = 0;
			int num2 = 127;
			for (;;)
			{
				bool flag;
				try
				{
					flag = ((this.int_2 & GClass3.int_21) == 1);
					if (flag)
					{
						int num3 = 2 * GClass3.int_12 - 1;
						for (int i = 0; i <= num3; i++)
						{
							array[i] = this.byte_1[i + 2 * this.int_1 * num];
						}
					}
					else
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
						object obj = objectValue;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						lock (obj)
						{
							this.fileStream_0.Seek((long)(2 * this.int_1 * num), SeekOrigin.Begin);
							this.fileStream_0.Read(array, 0, 2 * GClass3.int_12);
						}
					}
				}
				catch (IOException ex)
				{
					Console.Write("IO Exception");
				}
				int num4 = 0;
				do
				{
					array2[num4] = 0;
					int num5 = this.int_1 - 1;
					for (int j = 0; j <= num5; j++)
					{
						int num6 = (int)array[num4 * this.int_1 + j];
						flag = (num6 < 0);
						if (flag)
						{
							num6 += 256;
						}
						int num7 = num4;
						array2[num7] += num6 << j * 8;
					}
					num4++;
				}
				while (num4 <= 1);
				int num8 = 127 - num2;
				int num9 = num8 >> 3;
				int num10 = 1 << ((num8 & 7) ^ 7);
				flag = (((int)addressBytes[num9] & num10) > 0);
				if (flag)
				{
					bool flag2 = array2[1] >= this.int_0[0];
					if (flag2)
					{
						break;
					}
					num = array2[1];
				}
				else
				{
					bool flag2 = array2[0] >= this.int_0[0];
					if (flag2)
					{
						goto Block_7;
					}
					num = array2[0];
				}
				num2 += -1;
				if (num2 < 0)
				{
					goto Block_8;
				}
			}
			return array2[1];
			Block_7:
			return array2[0];
			Block_8:
			Console.Write("Error Seeking country while Seeking " + Convert.ToString(ipaddress_0));
			return 0;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x001D6EB0 File Offset: 0x001D52B0
		[MethodImpl(MethodImplOptions.Synchronized)]
		private int method_19(long long_0)
		{
			byte[] array = new byte[2 * GClass3.int_12 - 1 + 1 - 1 + 1];
			int[] array2 = new int[2];
			int num = 0;
			int num2 = 31;
			for (;;)
			{
				bool flag;
				try
				{
					flag = ((this.int_2 & GClass3.int_21) == 1);
					if (flag)
					{
						int num3 = 2 * GClass3.int_12 - 1;
						for (int i = 0; i <= num3; i++)
						{
							array[i] = this.byte_1[i + 2 * this.int_1 * num];
						}
					}
					else
					{
						object objectValue = RuntimeHelpers.GetObjectValue(this.object_0);
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue));
						object obj = objectValue;
						ObjectFlowControl.CheckForSyncLockOnValueType(obj);
						lock (obj)
						{
							this.fileStream_0.Seek((long)(2 * this.int_1 * num), SeekOrigin.Begin);
							this.fileStream_0.Read(array, 0, 2 * GClass3.int_12);
						}
					}
				}
				catch (IOException ex)
				{
					Console.Write("IO Exception");
				}
				int num4 = 0;
				do
				{
					array2[num4] = 0;
					int num5 = this.int_1 - 1;
					for (int j = 0; j <= num5; j++)
					{
						int num6 = (int)array[num4 * this.int_1 + j];
						flag = (num6 < 0);
						if (flag)
						{
							num6 += 256;
						}
						int num7 = num4;
						array2[num7] += num6 << j * 8;
					}
					num4++;
				}
				while (num4 <= 1);
				flag = ((long_0 & 1L << (num2 & 31)) > 0L);
				if (flag)
				{
					bool flag2 = array2[1] >= this.int_0[0];
					if (flag2)
					{
						break;
					}
					num = array2[1];
				}
				else
				{
					bool flag2 = array2[0] >= this.int_0[0];
					if (flag2)
					{
						goto Block_7;
					}
					num = array2[0];
				}
				num2 += -1;
				if (num2 < 0)
				{
					goto Block_8;
				}
			}
			return array2[1];
			Block_7:
			return array2[0];
			Block_8:
			Console.Write("Error Seeking country while Seeking " + Conversions.ToString(long_0));
			return 0;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x001D7100 File Offset: 0x001D5500
		public GClass4 method_2(IPAddress ipaddress_0)
		{
			return this.method_6(GClass3.smethod_1(ipaddress_0.GetAddressBytes()));
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x001D7124 File Offset: 0x001D5524
		public GClass4 method_3(string string_3)
		{
			IPAddress ipaddress_;
			try
			{
				ipaddress_ = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return GClass3.gclass4_0;
			}
			return this.method_5(ipaddress_);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x001D7194 File Offset: 0x001D5594
		public GClass4 method_4(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return GClass3.gclass4_0;
			}
			return this.method_6(GClass3.smethod_1(ipaddress.GetAddressBytes()));
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x001D7210 File Offset: 0x001D5610
		public GClass4 method_5(IPAddress ipaddress_0)
		{
			bool flag = this.fileStream_0 == null;
			if (flag)
			{
				throw new Exception("Database has been closed.");
			}
			flag = ((int)this.byte_0 == GClass5.int_4 | (int)this.byte_0 == GClass5.int_3);
			GClass4 result;
			if (flag)
			{
				GClass6 gclass = this.method_11(ipaddress_0);
				flag = (gclass == null);
				if (flag)
				{
					result = GClass3.gclass4_0;
				}
				else
				{
					result = new GClass4(gclass.string_0, gclass.string_1);
				}
			}
			else
			{
				int num = this.method_18(ipaddress_0) - GClass3.int_4;
				flag = (num == 0);
				if (flag)
				{
					result = GClass3.gclass4_0;
				}
				else
				{
					result = new GClass4(GClass3.string_1[num], GClass3.string_2[num]);
				}
			}
			return result;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x001D72BC File Offset: 0x001D56BC
		public GClass4 method_6(long long_0)
		{
			bool flag = this.fileStream_0 == null;
			if (flag)
			{
				throw new Exception("Database has been closed.");
			}
			flag = ((int)this.byte_0 == GClass5.int_4 | (int)this.byte_0 == GClass5.int_3);
			GClass4 result;
			if (flag)
			{
				GClass6 gclass = this.method_12(Conversions.ToString(long_0));
				flag = (gclass == null);
				if (flag)
				{
					result = GClass3.gclass4_0;
				}
				else
				{
					result = new GClass4(gclass.string_0, gclass.string_1);
				}
			}
			else
			{
				int num = this.method_19(long_0) - GClass3.int_4;
				flag = (num == 0);
				if (flag)
				{
					result = GClass3.gclass4_0;
				}
				else
				{
					result = new GClass4(GClass3.string_1[num], GClass3.string_2[num]);
				}
			}
			return result;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x001D736C File Offset: 0x001D576C
		public int method_7(string string_3)
		{
			IPAddress ipaddress;
			try
			{
				ipaddress = IPAddress.Parse(string_3);
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				Console.Write(ex2.Message);
				return 0;
			}
			return this.method_9(GClass3.smethod_1(ipaddress.GetAddressBytes()));
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x001D73E0 File Offset: 0x001D57E0
		public int method_8(IPAddress ipaddress_0)
		{
			return this.method_9(GClass3.smethod_1(ipaddress_0.GetAddressBytes()));
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x001D7404 File Offset: 0x001D5804
		public int method_9(long long_0)
		{
			bool flag = this.fileStream_0 == null;
			if (flag)
			{
				throw new Exception("Database has been closed.");
			}
			return this.method_19(long_0) - this.int_0[0];
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x001D7440 File Offset: 0x001D5840
		private static long smethod_0(long long_0)
		{
			return (long_0 >> 0 & 255L) << 24 | (long_0 >> 8 & 255L) << 16 | (long_0 >> 16 & 255L) << 8 | (long_0 >> 24 & 255L) << 0;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x001D748C File Offset: 0x001D588C
		private static long smethod_1(byte[] byte_2)
		{
			long num = 0L;
			int num2 = 0;
			do
			{
				long num3 = (long)((ulong)byte_2[num2]);
				bool flag = num3 < 0L;
				if (flag)
				{
					num3 += 256L;
				}
				num += num3 << (3 - num2) * 8;
				num2++;
			}
			while (num2 <= 3);
			return num;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x001D74E0 File Offset: 0x001D58E0
		private static int smethod_2(byte byte_2)
		{
			return (int)(byte_2 & byte.MaxValue);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x001D74FC File Offset: 0x001D58FC
		private static T smethod_3<T>(ref T gparam_0, T gparam_1)
		{
			gparam_0 = gparam_1;
			return gparam_1;
		}

		// Token: 0x04000234 RID: 564
		private byte byte_0;

		// Token: 0x04000235 RID: 565
		private byte[] byte_1;

		// Token: 0x04000236 RID: 566
		private FileStream fileStream_0;

		// Token: 0x04000237 RID: 567
		private static GClass4 gclass4_0 = new GClass4("--", "N/A");

		// Token: 0x04000238 RID: 568
		private GClass5 gclass5_0;

		// Token: 0x04000239 RID: 569
		private int[] int_0;

		// Token: 0x0400023A RID: 570
		private int int_1;

		// Token: 0x0400023B RID: 571
		private static int int_10 = 3;

		// Token: 0x0400023C RID: 572
		private static int int_11 = 4;

		// Token: 0x0400023D RID: 573
		private static int int_12 = 4;

		// Token: 0x0400023E RID: 574
		private static int int_13 = 1000;

		// Token: 0x0400023F RID: 575
		private static int int_14 = 360;

		// Token: 0x04000240 RID: 576
		private static int int_15 = 16700000;

		// Token: 0x04000241 RID: 577
		private static int int_16 = 16000000;

		// Token: 0x04000242 RID: 578
		private static int int_17 = 1;

		// Token: 0x04000243 RID: 579
		private static int int_18 = 677;

		// Token: 0x04000244 RID: 580
		private static int int_19 = 1353;

		// Token: 0x04000245 RID: 581
		private int int_2;

		// Token: 0x04000246 RID: 582
		public static int int_20 = 0;

		// Token: 0x04000247 RID: 583
		public static int int_21 = 1;

		// Token: 0x04000248 RID: 584
		public static int int_22 = 0;

		// Token: 0x04000249 RID: 585
		public static int int_23 = 1;

		// Token: 0x0400024A RID: 586
		public static int int_24 = 2;

		// Token: 0x0400024B RID: 587
		public static int int_25 = 3;

		// Token: 0x0400024C RID: 588
		private int int_3;

		// Token: 0x0400024D RID: 589
		private static int int_4 = 16776960;

		// Token: 0x0400024E RID: 590
		private static int int_5 = 16700000;

		// Token: 0x0400024F RID: 591
		private static int int_6 = 20;

		// Token: 0x04000250 RID: 592
		private static int int_7 = 100;

		// Token: 0x04000251 RID: 593
		private static int int_8 = 100;

		// Token: 0x04000252 RID: 594
		private static int int_9 = 3;

		// Token: 0x04000253 RID: 595
		private object object_0;

		// Token: 0x04000254 RID: 596
		private string string_0;

		// Token: 0x04000255 RID: 597
		public static string[] string_1 = new string[]
		{
			"--",
			"AP",
			"EU",
			"AD",
			"AE",
			"AF",
			"AG",
			"AI",
			"AL",
			"AM",
			"CW",
			"AO",
			"AQ",
			"AR",
			"AS",
			"AT",
			"AU",
			"AW",
			"AZ",
			"BA",
			"BB",
			"BD",
			"BE",
			"BF",
			"BG",
			"BH",
			"BI",
			"BJ",
			"BM",
			"BN",
			"BO",
			"BR",
			"BS",
			"BT",
			"BV",
			"BW",
			"BY",
			"BZ",
			"CA",
			"CC",
			"CD",
			"CF",
			"CG",
			"CH",
			"CI",
			"CK",
			"CL",
			"CM",
			"CN",
			"CO",
			"CR",
			"CU",
			"CV",
			"CX",
			"CY",
			"CZ",
			"DE",
			"DJ",
			"DK",
			"DM",
			"DO",
			"DZ",
			"EC",
			"EE",
			"EG",
			"EH",
			"ER",
			"ES",
			"ET",
			"FI",
			"FJ",
			"FK",
			"FM",
			"FO",
			"FR",
			"SX",
			"GA",
			"GB",
			"GD",
			"GE",
			"GF",
			"GH",
			"GI",
			"GL",
			"GM",
			"GN",
			"GP",
			"GQ",
			"GR",
			"GS",
			"GT",
			"GU",
			"GW",
			"GY",
			"HK",
			"HM",
			"HN",
			"HR",
			"HT",
			"HU",
			"ID",
			"IE",
			"IL",
			"IN",
			"IO",
			"IQ",
			"IR",
			"IS",
			"IT",
			"JM",
			"JO",
			"JP",
			"KE",
			"KG",
			"KH",
			"KI",
			"KM",
			"KN",
			"KP",
			"KR",
			"KW",
			"KY",
			"KZ",
			"LA",
			"LB",
			"LC",
			"LI",
			"LK",
			"LR",
			"LS",
			"LT",
			"LU",
			"LV",
			"LY",
			"MA",
			"MC",
			"MD",
			"MG",
			"MH",
			"MK",
			"ML",
			"MM",
			"MN",
			"MO",
			"MP",
			"MQ",
			"MR",
			"MS",
			"MT",
			"MU",
			"MV",
			"MW",
			"MX",
			"MY",
			"MZ",
			"NA",
			"NC",
			"NE",
			"NF",
			"NG",
			"NI",
			"NL",
			"NO",
			"NP",
			"NR",
			"NU",
			"NZ",
			"OM",
			"PA",
			"PE",
			"PF",
			"PG",
			"PH",
			"PK",
			"PL",
			"PM",
			"PN",
			"PR",
			"PS",
			"PT",
			"PW",
			"PY",
			"QA",
			"RE",
			"RO",
			"RU",
			"RW",
			"SA",
			"SB",
			"SC",
			"SD",
			"SE",
			"SG",
			"SH",
			"SI",
			"SJ",
			"SK",
			"SL",
			"SM",
			"SN",
			"SO",
			"SR",
			"ST",
			"SV",
			"SY",
			"SZ",
			"TC",
			"TD",
			"TF",
			"TG",
			"TH",
			"TJ",
			"TK",
			"TM",
			"TN",
			"TO",
			"TL",
			"TR",
			"TT",
			"TV",
			"TW",
			"TZ",
			"UA",
			"UG",
			"UM",
			"US",
			"UY",
			"UZ",
			"VA",
			"VC",
			"VE",
			"VG",
			"VI",
			"VN",
			"VU",
			"WF",
			"WS",
			"YE",
			"YT",
			"RS",
			"ZA",
			"ZM",
			"ME",
			"ZW",
			"A1",
			"A2",
			"O1",
			"AX",
			"GG",
			"IM",
			"JE",
			"BL",
			"MF",
			"BQ",
			"SS",
			"O1"
		};

		// Token: 0x04000256 RID: 598
		private static string[] string_2 = new string[]
		{
			"N/A",
			"Asia/Pacific Region",
			"Europe",
			"Andorra",
			"United Arab Emirates",
			"Afghanistan",
			"Antigua and Barbuda",
			"Anguilla",
			"Albania",
			"Armenia",
			"Curacao",
			"Angola",
			"Antarctica",
			"Argentina",
			"American Samoa",
			"Austria",
			"Australia",
			"Aruba",
			"Azerbaijan",
			"Bosnia and Herzegovina",
			"Barbados",
			"Bangladesh",
			"Belgium",
			"Burkina Faso",
			"Bulgaria",
			"Bahrain",
			"Burundi",
			"Benin",
			"Bermuda",
			"Brunei Darussalam",
			"Bolivia",
			"Brazil",
			"Bahamas",
			"Bhutan",
			"Bouvet Island",
			"Botswana",
			"Belarus",
			"Belize",
			"Canada",
			"Cocos (Keeling) Islands",
			"Congo, The Democratic Republic of the",
			"Central African Republic",
			"Congo",
			"Switzerland",
			"Cote D'Ivoire",
			"Cook Islands",
			"Chile",
			"Cameroon",
			"China",
			"Colombia",
			"Costa Rica",
			"Cuba",
			"Cape Verde",
			"Christmas Island",
			"Cyprus",
			"Czech Republic",
			"Germany",
			"Djibouti",
			"Denmark",
			"Dominica",
			"Dominican Republic",
			"Algeria",
			"Ecuador",
			"Estonia",
			"Egypt",
			"Western Sahara",
			"Eritrea",
			"Spain",
			"Ethiopia",
			"Finland",
			"Fiji",
			"Falkland Islands (Malvinas)",
			"Micronesia, Federated States of",
			"Faroe Islands",
			"France",
			"Sint Maarten (Dutch part)",
			"Gabon",
			"United Kingdom",
			"Grenada",
			"Georgia",
			"French Guiana",
			"Ghana",
			"Gibraltar",
			"Greenland",
			"Gambia",
			"Guinea",
			"Guadeloupe",
			"Equatorial Guinea",
			"Greece",
			"South Georgia and the South Sandwich Islands",
			"Guatemala",
			"Guam",
			"Guinea-Bissau",
			"Guyana",
			"Hong Kong",
			"Heard Island and McDonald Islands",
			"Honduras",
			"Croatia",
			"Haiti",
			"Hungary",
			"Indonesia",
			"Ireland",
			"Israel",
			"India",
			"British Indian Ocean Territory",
			"Iraq",
			"Iran, Islamic Republic of",
			"Iceland",
			"Italy",
			"Jamaica",
			"Jordan",
			"Japan",
			"Kenya",
			"Kyrgyzstan",
			"Cambodia",
			"Kiribati",
			"Comoros",
			"Saint Kitts and Nevis",
			"Korea, Democratic People's Republic of",
			"Korea, Republic of",
			"Kuwait",
			"Cayman Islands",
			"Kazakhstan",
			"Lao People's Democratic Republic",
			"Lebanon",
			"Saint Lucia",
			"Liechtenstein",
			"Sri Lanka",
			"Liberia",
			"Lesotho",
			"Lithuania",
			"Luxembourg",
			"Latvia",
			"Libya",
			"Morocco",
			"Monaco",
			"Moldova, Republic of",
			"Madagascar",
			"Marshall Islands",
			"Macedonia",
			"Mali",
			"Myanmar",
			"Mongolia",
			"Macau",
			"Northern Mariana Islands",
			"Martinique",
			"Mauritania",
			"Montserrat",
			"Malta",
			"Mauritius",
			"Maldives",
			"Malawi",
			"Mexico",
			"Malaysia",
			"Mozambique",
			"Namibia",
			"New Caledonia",
			"Niger",
			"Norfolk Island",
			"Nigeria",
			"Nicaragua",
			"Netherlands",
			"Norway",
			"Nepal",
			"Nauru",
			"Niue",
			"New Zealand",
			"Oman",
			"Panama",
			"Peru",
			"French Polynesia",
			"Papua New Guinea",
			"Philippines",
			"Pakistan",
			"Poland",
			"Saint Pierre and Miquelon",
			"Pitcairn Islands",
			"Puerto Rico",
			"Palestinian Territory",
			"Portugal",
			"Palau",
			"Paraguay",
			"Qatar",
			"Reunion",
			"Romania",
			"Russian Federation",
			"Rwanda",
			"Saudi Arabia",
			"Solomon Islands",
			"Seychelles",
			"Sudan",
			"Sweden",
			"Singapore",
			"Saint Helena",
			"Slovenia",
			"Svalbard and Jan Mayen",
			"Slovakia",
			"Sierra Leone",
			"San Marino",
			"Senegal",
			"Somalia",
			"Suriname",
			"Sao Tome and Principe",
			"El Salvador",
			"Syrian Arab Republic",
			"Swaziland",
			"Turks and Caicos Islands",
			"Chad",
			"French Southern Territories",
			"Togo",
			"Thailand",
			"Tajikistan",
			"Tokelau",
			"Turkmenistan",
			"Tunisia",
			"Tonga",
			"Timor-Leste",
			"Turkey",
			"Trinidad and Tobago",
			"Tuvalu",
			"Taiwan",
			"Tanzania, United Republic of",
			"Ukraine",
			"Uganda",
			"United States Minor Outlying Islands",
			"United States",
			"Uruguay",
			"Uzbekistan",
			"Holy See (Vatican City State)",
			"Saint Vincent and the Grenadines",
			"Venezuela",
			"Virgin Islands, British",
			"Virgin Islands, U.S.",
			"Vietnam",
			"Vanuatu",
			"Wallis and Futuna",
			"Samoa",
			"Yemen",
			"Mayotte",
			"Serbia",
			"South Africa",
			"Zambia",
			"Montenegro",
			"Zimbabwe",
			"Anonymous Proxy",
			"Satellite Provider",
			"Other",
			"Aland Islands",
			"Guernsey",
			"Isle of Man",
			"Jersey",
			"Saint Barthelemy",
			"Saint Martin",
			"Bonaire, Saint Eustatius and Saba",
			"South Sudan",
			"Other"
		};
	}
}
