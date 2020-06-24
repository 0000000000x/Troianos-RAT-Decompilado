using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT.My
{
	// Token: 0x02000004 RID: 4
	[HideModuleName]
	[StandardModule]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000008 RID: 8 RVA: 0x001DACF8 File Offset: 0x001D90F8
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000009 RID: 9 RVA: 0x001DAD14 File Offset: 0x001D9114
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000A RID: 10 RVA: 0x001DAD30 File Offset: 0x001D9130
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000B RID: 11 RVA: 0x001DAD4C File Offset: 0x001D914C
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x001DAD68 File Offset: 0x001D9168
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000D RID: 13 RVA: 0x001DAD84 File Offset: 0x001D9184
			// (set) Token: 0x06000021 RID: 33 RVA: 0x001DB0A4 File Offset: 0x001D94A4
			public About About
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_About = MyProject.MyForms.Create__Instance__<About>(this.m_About);
					return this.m_About;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_About;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<About>(ref this.m_About);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000E RID: 14 RVA: 0x001DADAC File Offset: 0x001D91AC
			// (set) Token: 0x06000022 RID: 34 RVA: 0x001DB0E8 File Offset: 0x001D94E8
			public Builder Builder
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Builder = MyProject.MyForms.Create__Instance__<Builder>(this.m_Builder);
					return this.m_Builder;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Builder;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Builder>(ref this.m_Builder);
					}
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600000F RID: 15 RVA: 0x001DADD4 File Offset: 0x001D91D4
			// (set) Token: 0x06000023 RID: 35 RVA: 0x001DB12C File Offset: 0x001D952C
			public Cam Cam
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Cam = MyProject.MyForms.Create__Instance__<Cam>(this.m_Cam);
					return this.m_Cam;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Cam;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Cam>(ref this.m_Cam);
					}
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000010 RID: 16 RVA: 0x001DADFC File Offset: 0x001D91FC
			// (set) Token: 0x06000024 RID: 36 RVA: 0x001DB170 File Offset: 0x001D9570
			public Chat Chat
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Chat = MyProject.MyForms.Create__Instance__<Chat>(this.m_Chat);
					return this.m_Chat;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Chat;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Chat>(ref this.m_Chat);
					}
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000011 RID: 17 RVA: 0x001DAE24 File Offset: 0x001D9224
			// (set) Token: 0x06000025 RID: 37 RVA: 0x001DB1B4 File Offset: 0x001D95B4
			public DW DW
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_DW = MyProject.MyForms.Create__Instance__<DW>(this.m_DW);
					return this.m_DW;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_DW;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DW>(ref this.m_DW);
					}
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000012 RID: 18 RVA: 0x001DAE4C File Offset: 0x001D924C
			// (set) Token: 0x06000026 RID: 38 RVA: 0x001DB1F8 File Offset: 0x001D95F8
			public Form1 Form1
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
					return this.m_Form1;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Form1;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form1>(ref this.m_Form1);
					}
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000013 RID: 19 RVA: 0x001DAE74 File Offset: 0x001D9274
			// (set) Token: 0x06000027 RID: 39 RVA: 0x001DB23C File Offset: 0x001D963C
			public FromLink FromLink
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_FromLink = MyProject.MyForms.Create__Instance__<FromLink>(this.m_FromLink);
					return this.m_FromLink;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_FromLink;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FromLink>(ref this.m_FromLink);
					}
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000014 RID: 20 RVA: 0x001DAE9C File Offset: 0x001D929C
			// (set) Token: 0x06000028 RID: 40 RVA: 0x001DB280 File Offset: 0x001D9680
			public FURL FURL
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_FURL = MyProject.MyForms.Create__Instance__<FURL>(this.m_FURL);
					return this.m_FURL;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_FURL;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FURL>(ref this.m_FURL);
					}
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000015 RID: 21 RVA: 0x001DAEC4 File Offset: 0x001D92C4
			// (set) Token: 0x06000029 RID: 41 RVA: 0x001DB2C4 File Offset: 0x001D96C4
			public kl kl
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_kl = MyProject.MyForms.Create__Instance__<kl>(this.m_kl);
					return this.m_kl;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_kl;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<kl>(ref this.m_kl);
					}
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000016 RID: 22 RVA: 0x001DAEEC File Offset: 0x001D92EC
			// (set) Token: 0x0600002A RID: 42 RVA: 0x001DB308 File Offset: 0x001D9708
			public Manager Manager
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Manager = MyProject.MyForms.Create__Instance__<Manager>(this.m_Manager);
					return this.m_Manager;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Manager;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Manager>(ref this.m_Manager);
					}
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000017 RID: 23 RVA: 0x001DAF14 File Offset: 0x001D9314
			// (set) Token: 0x0600002B RID: 43 RVA: 0x001DB34C File Offset: 0x001D974C
			public Mic Mic
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Mic = MyProject.MyForms.Create__Instance__<Mic>(this.m_Mic);
					return this.m_Mic;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Mic;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Mic>(ref this.m_Mic);
					}
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000018 RID: 24 RVA: 0x001DAF3C File Offset: 0x001D933C
			// (set) Token: 0x0600002C RID: 44 RVA: 0x001DB390 File Offset: 0x001D9790
			public Note Note
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Note = MyProject.MyForms.Create__Instance__<Note>(this.m_Note);
					return this.m_Note;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Note;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Note>(ref this.m_Note);
					}
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000019 RID: 25 RVA: 0x001DAF64 File Offset: 0x001D9364
			// (set) Token: 0x0600002D RID: 45 RVA: 0x001DB3D4 File Offset: 0x001D97D4
			public notf notf
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_notf = MyProject.MyForms.Create__Instance__<notf>(this.m_notf);
					return this.m_notf;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_notf;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<notf>(ref this.m_notf);
					}
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600001A RID: 26 RVA: 0x001DAF8C File Offset: 0x001D938C
			// (set) Token: 0x0600002E RID: 46 RVA: 0x001DB418 File Offset: 0x001D9818
			public Pass Pass
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Pass = MyProject.MyForms.Create__Instance__<Pass>(this.m_Pass);
					return this.m_Pass;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Pass;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Pass>(ref this.m_Pass);
					}
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600001B RID: 27 RVA: 0x001DAFB4 File Offset: 0x001D93B4
			// (set) Token: 0x0600002F RID: 47 RVA: 0x001DB45C File Offset: 0x001D985C
			public port port
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_port = MyProject.MyForms.Create__Instance__<port>(this.m_port);
					return this.m_port;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_port;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<port>(ref this.m_port);
					}
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x0600001C RID: 28 RVA: 0x001DAFDC File Offset: 0x001D93DC
			// (set) Token: 0x06000030 RID: 48 RVA: 0x001DB4A0 File Offset: 0x001D98A0
			public RGv RGv
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_RGv = MyProject.MyForms.Create__Instance__<RGv>(this.m_RGv);
					return this.m_RGv;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_RGv;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<RGv>(ref this.m_RGv);
					}
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x0600001D RID: 29 RVA: 0x001DB004 File Offset: 0x001D9404
			// (set) Token: 0x06000031 RID: 49 RVA: 0x001DB4E4 File Offset: 0x001D98E4
			public sc sc
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_sc = MyProject.MyForms.Create__Instance__<sc>(this.m_sc);
					return this.m_sc;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_sc;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<sc>(ref this.m_sc);
					}
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600001E RID: 30 RVA: 0x001DB02C File Offset: 0x001D942C
			// (set) Token: 0x06000032 RID: 50 RVA: 0x001DB528 File Offset: 0x001D9928
			public script script
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_script = MyProject.MyForms.Create__Instance__<script>(this.m_script);
					return this.m_script;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_script;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<script>(ref this.m_script);
					}
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600001F RID: 31 RVA: 0x001DB054 File Offset: 0x001D9454
			// (set) Token: 0x06000033 RID: 51 RVA: 0x001DB56C File Offset: 0x001D996C
			public STNG STNG
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_STNG = MyProject.MyForms.Create__Instance__<STNG>(this.m_STNG);
					return this.m_STNG;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_STNG;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<STNG>(ref this.m_STNG);
					}
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000020 RID: 32 RVA: 0x001DB07C File Offset: 0x001D947C
			// (set) Token: 0x06000034 RID: 52 RVA: 0x001DB5B0 File Offset: 0x001D99B0
			public up up
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_up = MyProject.MyForms.Create__Instance__<up>(this.m_up);
					return this.m_up;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_up;
					if (!flag)
					{
						flag = (value != null);
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<up>(ref this.m_up);
					}
				}
			}

			// Token: 0x06000035 RID: 53 RVA: 0x001DB5F4 File Offset: 0x001D99F4
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						});
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x06000036 RID: 54 RVA: 0x001DB730 File Offset: 0x001D9B30
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000037 RID: 55 RVA: 0x001DB75C File Offset: 0x001D9B5C
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x06000038 RID: 56 RVA: 0x001DB768 File Offset: 0x001D9B68
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000039 RID: 57 RVA: 0x001DB788 File Offset: 0x001D9B88
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600003A RID: 58 RVA: 0x001DB7A0 File Offset: 0x001D9BA0
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x0600003B RID: 59 RVA: 0x001DB7BC File Offset: 0x001D9BBC
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000007 RID: 7
			public About m_About;

			// Token: 0x04000008 RID: 8
			public Builder m_Builder;

			// Token: 0x04000009 RID: 9
			public Cam m_Cam;

			// Token: 0x0400000A RID: 10
			public Chat m_Chat;

			// Token: 0x0400000B RID: 11
			public DW m_DW;

			// Token: 0x0400000C RID: 12
			public Form1 m_Form1;

			// Token: 0x0400000D RID: 13
			public FromLink m_FromLink;

			// Token: 0x0400000E RID: 14
			public FURL m_FURL;

			// Token: 0x0400000F RID: 15
			public kl m_kl;

			// Token: 0x04000010 RID: 16
			public Manager m_Manager;

			// Token: 0x04000011 RID: 17
			public Mic m_Mic;

			// Token: 0x04000012 RID: 18
			public Note m_Note;

			// Token: 0x04000013 RID: 19
			public notf m_notf;

			// Token: 0x04000014 RID: 20
			public Pass m_Pass;

			// Token: 0x04000015 RID: 21
			public port m_port;

			// Token: 0x04000016 RID: 22
			public RGv m_RGv;

			// Token: 0x04000017 RID: 23
			public sc m_sc;

			// Token: 0x04000018 RID: 24
			public script m_script;

			// Token: 0x04000019 RID: 25
			public STNG m_STNG;

			// Token: 0x0400001A RID: 26
			public up m_up;

			// Token: 0x0400001B RID: 27
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x0600003C RID: 60 RVA: 0x001DB7D4 File Offset: 0x001D9BD4
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600003D RID: 61 RVA: 0x001DB7F4 File Offset: 0x001D9BF4
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600003E RID: 62 RVA: 0x001DB80C File Offset: 0x001D9C0C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600003F RID: 63 RVA: 0x001DB828 File Offset: 0x001D9C28
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x06000040 RID: 64 RVA: 0x001DB840 File Offset: 0x001D9C40
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T result;
				if (flag)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x06000041 RID: 65 RVA: 0x001DB86C File Offset: 0x001D9C6C
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000042 RID: 66 RVA: 0x001DB88C File Offset: 0x001D9C8C
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000043 RID: 67 RVA: 0x001DB898 File Offset: 0x001D9C98
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000044 RID: 68 RVA: 0x001DB8CC File Offset: 0x001D9CCC
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400001C RID: 28
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
