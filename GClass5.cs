using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x0200002B RID: 43
	public sealed class GClass5
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x001D75F8 File Offset: 0x001D59F8
		public GClass5(string string_1)
		{
			this.string_0 = string_1;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x001D760C File Offset: 0x001D5A0C
		public int method_0()
		{
			bool flag = this.string_0 == null | Operators.CompareString(this.string_0, string.Empty, false) == 0;
			int result;
			if (flag)
			{
				result = GClass5.int_0;
			}
			else
			{
				result = Convert.ToInt32(this.string_0.Substring(4, 3)) - 105;
			}
			return result;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x001D7660 File Offset: 0x001D5A60
		public bool method_1()
		{
			return this.string_0.IndexOf("FREE") < 0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x001D7688 File Offset: 0x001D5A88
		public DateTime method_2()
		{
			int num = this.string_0.Length - 10;
			for (int i = 0; i <= num; i++)
			{
				bool flag = char.IsWhiteSpace(this.string_0[i]);
				if (flag)
				{
					string s = this.string_0.Substring(i + 1, 8);
					try
					{
						return DateTime.ParseExact(s, "yyyyMMdd", null);
					}
					catch (Exception ex)
					{
						Exception ex2 = ex;
						Console.Write(ex2.Message);
						break;
					}
				}
			}
			return DateTime.Now;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x001D774C File Offset: 0x001D5B4C
		public string method_3()
		{
			return this.string_0;
		}

		// Token: 0x04000259 RID: 601
		public static int int_0 = 1;

		// Token: 0x0400025A RID: 602
		public static int int_1 = 7;

		// Token: 0x0400025B RID: 603
		public static int int_10 = 11;

		// Token: 0x0400025C RID: 604
		public static int int_11 = 12;

		// Token: 0x0400025D RID: 605
		public static int int_12 = 21;

		// Token: 0x0400025E RID: 606
		public static int int_13 = 22;

		// Token: 0x0400025F RID: 607
		public static int int_14 = 23;

		// Token: 0x04000260 RID: 608
		public static int int_15 = 24;

		// Token: 0x04000261 RID: 609
		public static int int_16 = 30;

		// Token: 0x04000262 RID: 610
		public static int int_17 = 31;

		// Token: 0x04000263 RID: 611
		public static int int_18 = 32;

		// Token: 0x04000264 RID: 612
		public static int int_19 = 33;

		// Token: 0x04000265 RID: 613
		public static int int_2 = 3;

		// Token: 0x04000266 RID: 614
		public static int int_3 = 6;

		// Token: 0x04000267 RID: 615
		public static int int_4 = 2;

		// Token: 0x04000268 RID: 616
		public static int int_5 = 5;

		// Token: 0x04000269 RID: 617
		public static int int_6 = 4;

		// Token: 0x0400026A RID: 618
		public static int int_7 = 8;

		// Token: 0x0400026B RID: 619
		public static int int_8 = 9;

		// Token: 0x0400026C RID: 620
		public static int int_9 = 10;

		// Token: 0x0400026D RID: 621
		private string string_0;
	}
}
