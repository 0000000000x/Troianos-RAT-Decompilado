using System;
using System.Diagnostics;

namespace Troianos_RAT
{
	// Token: 0x0200002C RID: 44
	public sealed class GClass6
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x001D7798 File Offset: 0x001D5B98
		[DebuggerNonUserCode]
		public GClass6()
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x001D77A4 File Offset: 0x001D5BA4
		public double method_0(GClass6 gclass6_0)
		{
			double num = this.double_0;
			double num2 = this.double_1;
			double num3 = gclass6_0.double_0;
			double num4 = gclass6_0.double_1;
			num *= GClass6.double_4;
			num3 *= GClass6.double_4;
			double num5 = num3 - num;
			double num6 = (num4 - num2) * GClass6.double_4;
			double num7 = Math.Pow(Math.Sin(num5 / 2.0), 2.0) + Math.Cos(num) * Math.Cos(num3) * Math.Pow(Math.Sin(num6 / 2.0), 2.0);
			return GClass6.double_2 * Math.Atan2(Math.Sqrt(num7), Math.Sqrt(1.0 - num7));
		}

		// Token: 0x0400026E RID: 622
		public double double_0;

		// Token: 0x0400026F RID: 623
		public double double_1;

		// Token: 0x04000270 RID: 624
		private static double double_2 = 12756.4;

		// Token: 0x04000271 RID: 625
		private static double double_3 = 3.14159265;

		// Token: 0x04000272 RID: 626
		private static double double_4 = GClass6.double_3 / 180.0;

		// Token: 0x04000273 RID: 627
		public int int_0;

		// Token: 0x04000274 RID: 628
		public int int_1;

		// Token: 0x04000275 RID: 629
		public int int_2;

		// Token: 0x04000276 RID: 630
		public string string_0;

		// Token: 0x04000277 RID: 631
		public string string_1;

		// Token: 0x04000278 RID: 632
		public string string_2;

		// Token: 0x04000279 RID: 633
		public string string_3;

		// Token: 0x0400027A RID: 634
		public string string_4;

		// Token: 0x0400027B RID: 635
		public string string_5;
	}
}
