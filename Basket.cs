using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CameraShopLibrary;

using MaterialSkin.Controls;

using static System.Windows.Forms.Application;
using static System.Windows.Forms.DialogResult;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

using static CameraShop.CameraMarketDataSet;
using static CameraShop.Properties.Resources;

namespace CameraShop
{
	public partial class Basket : MaterialForm
	{
		public Basket(List<DeviceRow> list)
		{
			InitializeComponent();
			this.InitStyle();
			List = list;
		}

		public List<DeviceRow> List { get; set; }

		private void GenerateReport(object _, EventArgs args) => basketDataGridView.ToExcel();

		private void Basket_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (basketDataGridView.RowCount != 0) return;

			if (MessageBox.Show(text: BakToMarket, caption: ProjectTitle, buttons: YesNo,
								icon: Question)
				== Yes)
			{
				e.Cancel = true;
				this.Nav(to: new User());
			} else
			{
				e.Cancel = false;
				new Reporter(report: new XmlReport(dataSet: cameraMarketDataSet));
				ExitThread();
			}
		}

		private void Basket_Load(object sender, EventArgs e)
		{
			basketBindingSource.DataSource = List;

			for (var i = 0; i < basketDataGridView.RowCount; i++)
			{
				object value = basketDataGridView[columnIndex: 2, rowIndex: i].Value;

				if (value == null) basketDataGridView[columnIndex: 2, rowIndex: i].Value = "1";
			}

			basketDataGridView.Refresh();
		}
	}
}
