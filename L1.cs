using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Troianos_RAT
{
	// Token: 0x02000039 RID: 57
	public sealed class L1 : DataGridView
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x001D91C0 File Offset: 0x001D75C0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = L1.__ENCList;
			lock (_ENCList)
			{
				bool flag = L1.__ENCList.Count == L1.__ENCList.Capacity;
				if (flag)
				{
					int num = 0;
					int num2 = 0;
					int num3 = L1.__ENCList.Count - 1;
					int num4 = num2;
					for (;;)
					{
						int num5 = num4;
						int num6 = num3;
						if (num5 > num6)
						{
							break;
						}
						WeakReference weakReference = L1.__ENCList[num4];
						flag = weakReference.IsAlive;
						if (flag)
						{
							bool flag2 = num4 != num;
							if (flag2)
							{
								L1.__ENCList[num] = L1.__ENCList[num4];
							}
							num++;
						}
						num4++;
					}
					L1.__ENCList.RemoveRange(num, L1.__ENCList.Count - num);
					L1.__ENCList.Capacity = L1.__ENCList.Count;
				}
				L1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x001D92C4 File Offset: 0x001D76C4
		public L1()
		{
			L1.__ENCAddToList(this);
			this.collection_0 = new Collection();
			this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
			this.RowHeadersVisible = false;
			this.DoubleBuffered = true;
			this.ShowCellErrors = true;
			this.ShowEditingIcon = true;
			this.ShowRowErrors = true;
			this.Font = new Font("arial", 8f, FontStyle.Bold);
			this.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
			this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.EnableNotifyMessage | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x001D9358 File Offset: 0x001D7758
		public DataGridViewRow method_0(int int_0)
		{
			return (DataGridViewRow)this.collection_0[int_0 + 1];
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x001D9380 File Offset: 0x001D7780
		public DataGridViewRow method_1(string string_0)
		{
			return (DataGridViewRow)this.collection_0[string_0];
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x001D93A4 File Offset: 0x001D77A4
		public void method_10(int int_0)
		{
			bool invokeRequired = this.InvokeRequired;
			if (invokeRequired)
			{
				Collection collection = this.collection_0;
				Collection obj = collection;
				lock (obj)
				{
					this.Invoke(new L1.Delegate4(this.method_10), new object[]
					{
						int_0
					});
					return;
				}
			}
			this.Rows.RemoveAt(int_0);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x001D9424 File Offset: 0x001D7824
		public void method_11(string string_0, L1.GEnum0 genum0_0, DataGridViewAutoSizeColumnMode dataGridViewAutoSizeColumnMode_0)
		{
			Collection collection = this.collection_0;
			Collection obj = collection;
			lock (obj)
			{
				DataGridViewColumn dataGridViewColumn = null;
				switch (genum0_0)
				{
				case L1.GEnum0.Text:
					dataGridViewColumn = new DataGridViewTextBoxColumn();
					break;
				case L1.GEnum0.Link:
					dataGridViewColumn = new DataGridViewLinkColumn();
					break;
				case L1.GEnum0.Image:
				{
					DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn
					{
						ImageLayout = DataGridViewImageCellLayout.Zoom
					};
					dataGridViewColumn = dataGridViewImageColumn;
					break;
				}
				case L1.GEnum0.StretchImage:
				{
					DataGridViewImageColumn dataGridViewImageColumn = new DataGridViewImageColumn
					{
						ImageLayout = DataGridViewImageCellLayout.Stretch
					};
					dataGridViewColumn = dataGridViewImageColumn;
					break;
				}
				}
				dataGridViewColumn.AutoSizeMode = dataGridViewAutoSizeColumnMode_0;
				dataGridViewColumn.Tag = genum0_0;
				dataGridViewColumn.HeaderText = string_0;
				this.Columns.Add(dataGridViewColumn);
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x001D94F8 File Offset: 0x001D78F8
		public bool method_2(string string_0)
		{
			return this.collection_0.Contains(string_0);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x001D9518 File Offset: 0x001D7918
		public DataGridViewRow[] method_3()
		{
			List<DataGridViewRow> list = new List<DataGridViewRow>();
			bool flag = this.RowCount == 0;
			DataGridViewRow[] result;
			if (flag)
			{
				result = list.ToArray();
			}
			else
			{
				try
				{
					int num = this.FirstDisplayedScrollingRowIndex + this.DisplayedRowCount(false);
					for (int i = this.FirstDisplayedScrollingRowIndex; i <= num; i++)
					{
						flag = (i > this.RowCount - 1);
						if (flag)
						{
							break;
						}
						try
						{
							list.Add(this.Rows[i]);
						}
						catch (Exception ex)
						{
							break;
						}
					}
				}
				catch (Exception ex2)
				{
				}
				result = list.ToArray();
			}
			return result;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x001D9610 File Offset: 0x001D7A10
		public void method_4()
		{
			Collection collection = this.collection_0;
			Collection obj = collection;
			lock (obj)
			{
				this.Rows.Clear();
				this.collection_0.Clear();
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x001D9664 File Offset: 0x001D7A64
		public DataGridViewRow method_5(object[] object_0)
		{
			bool invokeRequired = this.InvokeRequired;
			if (invokeRequired)
			{
				Collection collection = this.collection_0;
				Collection obj = collection;
				lock (obj)
				{
					return (DataGridViewRow)this.Invoke(new L1.Delegate1(this.method_5), object_0);
				}
			}
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			int num = this.ColumnCount - 1;
			for (int i = 0; i <= num; i++)
			{
				switch (Conversions.ToInteger(RuntimeHelpers.GetObjectValue(this.Columns[i].Tag)))
				{
				case 0:
				{
					DataGridViewTextBoxCell dataGridViewCell = new DataGridViewTextBoxCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])))
					};
					dataGridViewRow.Cells.Add(dataGridViewCell);
					break;
				}
				case 1:
				{
					DataGridViewLinkCell dataGridViewCell2 = new DataGridViewLinkCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])))
					};
					dataGridViewRow.Cells.Add(dataGridViewCell2);
					break;
				}
				case 2:
				{
					DataGridViewImageCell dataGridViewCell3 = new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))),
						ImageLayout = DataGridViewImageCellLayout.Normal
					};
					dataGridViewRow.Cells.Add(dataGridViewCell3);
					break;
				}
				case 3:
				{
					DataGridViewImageCell dataGridViewCell3 = new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))),
						ImageLayout = DataGridViewImageCellLayout.Stretch
					};
					dataGridViewRow.Cells.Add(dataGridViewCell3);
					break;
				}
				}
			}
			dataGridViewRow.Resizable = DataGridViewTriState.False;
			this.collection_0.Add(dataGridViewRow, null, null, null);
			this.Rows.Add(dataGridViewRow);
			return dataGridViewRow;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x001D9860 File Offset: 0x001D7C60
		public int method_6()
		{
			return this.RowTemplate.Height;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x001D9880 File Offset: 0x001D7C80
		public void method_7(int int_0)
		{
			this.RowTemplate.Height = int_0;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x001D9894 File Offset: 0x001D7C94
		public DataGridViewRow method_8(string string_0, object[] object_0)
		{
			bool invokeRequired = this.InvokeRequired;
			if (invokeRequired)
			{
				Collection collection = this.collection_0;
				Collection obj = collection;
				lock (obj)
				{
					return (DataGridViewRow)this.Invoke(new L1.Delegate2(this.method_8), new object[]
					{
						string_0,
						object_0
					});
				}
			}
			DataGridViewRow dataGridViewRow = new DataGridViewRow
			{
				Height = this.method_6()
			};
			int num = this.ColumnCount - 1;
			for (int i = 0; i <= num; i++)
			{
				switch (Conversions.ToInteger(RuntimeHelpers.GetObjectValue(this.Columns[i].Tag)))
				{
				case 0:
				{
					DataGridViewTextBoxCell dataGridViewCell = new DataGridViewTextBoxCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])))
					};
					dataGridViewRow.Cells.Add(dataGridViewCell);
					break;
				}
				case 1:
				{
					DataGridViewLinkCell dataGridViewCell2 = new DataGridViewLinkCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i])))
					};
					dataGridViewRow.Cells.Add(dataGridViewCell2);
					break;
				}
				case 2:
				{
					DataGridViewImageCell dataGridViewCell3 = new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))),
						ImageLayout = DataGridViewImageCellLayout.Zoom
					};
					dataGridViewRow.Cells.Add(dataGridViewCell3);
					break;
				}
				case 3:
				{
					DataGridViewImageCell dataGridViewCell3 = new DataGridViewImageCell
					{
						Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0[i]))),
						ImageLayout = DataGridViewImageCellLayout.Stretch
					};
					dataGridViewRow.Cells.Add(dataGridViewCell3);
					break;
				}
				}
			}
			dataGridViewRow.Resizable = DataGridViewTriState.False;
			this.collection_0.Add(dataGridViewRow, string_0, null, null);
			this.Rows.Add(dataGridViewRow);
			return dataGridViewRow;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x001D9AB8 File Offset: 0x001D7EB8
		public void method_9(DataGridViewRow dataGridViewRow_0)
		{
			bool invokeRequired = this.InvokeRequired;
			if (invokeRequired)
			{
				Collection collection = this.collection_0;
				Collection obj = collection;
				lock (obj)
				{
					this.Invoke(new L1.Delegate3(this.method_9), new object[]
					{
						dataGridViewRow_0
					});
					return;
				}
			}
			this.Rows.Remove(dataGridViewRow_0);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x001D9B30 File Offset: 0x001D7F30
		protected override void OnMouseUp(MouseEventArgs mouseEventArgs_0)
		{
			bool flag = mouseEventArgs_0.Button == MouseButtons.Right;
			if (flag)
			{
				try
				{
					DataGridView.HitTestInfo hitTestInfo = this.HitTest(mouseEventArgs_0.X, mouseEventArgs_0.Y);
					flag = (hitTestInfo.RowIndex != -1);
					if (flag)
					{
						DataGridViewRow dataGridViewRow = this.Rows[hitTestInfo.RowIndex];
						flag = !dataGridViewRow.Selected;
						if (flag)
						{
							this.ClearSelection();
							dataGridViewRow.Selected = true;
						}
					}
				}
				catch (Exception ex)
				{
				}
			}
			base.OnMouseUp(mouseEventArgs_0);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x001D9BDC File Offset: 0x001D7FDC
		protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
		{
			base.OnMouseWheel(mouseEventArgs_0);
			try
			{
				int delta = mouseEventArgs_0.Delta;
				bool flag = delta == 120;
				if (flag)
				{
					this.FirstDisplayedScrollingRowIndex = Math.Max(0, this.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines);
				}
				else
				{
					flag = (delta == -120);
					if (flag)
					{
						this.FirstDisplayedScrollingRowIndex += SystemInformation.MouseWheelScrollLines;
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x001D9C74 File Offset: 0x001D8074
		protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs dataGridViewRowPostPaintEventArgs_0)
		{
			try
			{
				DataGridViewRow dataGridViewRow = this.Rows[dataGridViewRowPostPaintEventArgs_0.RowIndex];
				bool flag = dataGridViewRow.Height != this.method_6();
				if (flag)
				{
					dataGridViewRow.Height = this.method_6();
				}
			}
			catch (Exception ex)
			{
			}
			base.OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0);
		}

		// Token: 0x040002AC RID: 684
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002AD RID: 685
		private Collection collection_0;

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x0600049C RID: 1180
		private delegate DataGridViewRow Delegate1(object[] object_0);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060004A0 RID: 1184
		private delegate DataGridViewRow Delegate2(string string_0, object[] object_0);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060004A4 RID: 1188
		private delegate void Delegate3(DataGridViewRow dataGridViewRow_0);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060004A8 RID: 1192
		private delegate void Delegate4(int int_0);

		// Token: 0x0200003E RID: 62
		public enum GEnum0
		{
			// Token: 0x040002AF RID: 687
			Image = 2,
			// Token: 0x040002B0 RID: 688
			Link = 1,
			// Token: 0x040002B1 RID: 689
			StretchImage = 3,
			// Token: 0x040002B2 RID: 690
			Text = 0
		}
	}
}
