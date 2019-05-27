using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

using CameraShopLibrary;

using MaterialSkin.Controls;

using static System.Windows.Forms.Application;
using static System.Windows.Forms.DialogResult;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;
using static System.Windows.Forms.SortOrder;

using static CameraShop.CameraMarketDataSet;
using static CameraShop.Properties.Resources;

namespace CameraShop
{
	/// <summary>
	/// 
	/// </summary>
	public partial class User : MaterialForm
	{
		/// <summary>
		///   Список покупок
		/// </summary>
		private readonly List<DeviceRow> _list = new List<DeviceRow>();

		/// <summary>
		///   Инициализация визуальных компонентов и нормализация стилей формы
		/// </summary>
		public User()
		{
			InitializeComponent();
			this.InitStyle();
		}

		/// <summary>
		///   Загрузка данных на форму
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void User_Load(object sender, EventArgs e)
		{
			deviceTableAdapter.Fill(dataTable: cameraMarketDataSet.Device);
		}

		/// <summary>
		///   Переход к окну авторизации
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void BackToLoginClick(object _, EventArgs args) => this.Nav(to: new Login());

		/// <summary>
		///   Вызов справки
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void HelpClick(object _, EventArgs args) { }

		/// <summary>
		///   Обработка нажатия на кнопку выход
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void ExitClick(object _, EventArgs args) =>
				OnFormClosing(e: new
									FormClosingEventArgs(closeReason: CloseReason.ApplicationExitCall,
														cancel: true));

		/// <summary>
		///   Обработка события закрытия формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void User_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show(text: ExitQuestion, caption: ProjectTitle, buttons: YesNo,
								icon: Question)
				== Yes) ExitThread();
			else e.Cancel = true;
		}

		/// <summary>
		///   Сортировка по цене
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MaterialToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (PriceOrder == Ascending)
			{
				deviceBindingSource.Sort = "Price ASC";
				PriceOrder               = Descending;
			} else
			{
				deviceBindingSource.Sort = "Price DESC";
				PriceOrder               = Ascending;
			}
		}

		/// <summary>
		///   Сортировка по названию
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MaterialToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (NameOrder == Ascending)
			{
				deviceBindingSource.Sort = "Name ASC";
				NameOrder                = Descending;
			} else
			{
				deviceBindingSource.Sort = "Name DESC";
				NameOrder                = Ascending;
			}
		}

		/// <summary>
		///   Сортировка по мегапикселям
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MaterialToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			if (MegapixelOrder == Ascending)
			{
				deviceBindingSource.Sort = "Megapixel ASC";
				MegapixelOrder           = Descending;
			} else
			{
				deviceBindingSource.Sort = "";
				MegapixelOrder           = Ascending;
			}
		}

		/// <summary>
		///   Сортировка по хз чему
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MaterialToolStripMenuItem4_Click(object sender, EventArgs e)
		{
			if (MonitorMountOrder == Ascending)
			{
				deviceBindingSource.Sort = "MonitorMount ASC";
				MonitorMountOrder        = Descending;
			} else
			{
				deviceBindingSource.Sort = "MonitorMount DESC";
				MonitorMountOrder        = Ascending;
			}
		}

		private void ДопомогаToolStripMenuItem_Click(object sender, EventArgs e) { }

		/// <summary>
		///   Додавання девайсу до кошика
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex == -1)
				MessageBox.Show(text: ChoseDevice);
			else
			{
				var current = (DataRowView) deviceBindingSource.Current;
				var row     = (DeviceRow) current.Row;
				_list.Add(item: row);
			}
		}

		/// <summary>
		///   Перехід до кошика
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PictureBox2_Click(object sender, EventArgs e)
		{
			if (_list.Count > 0)
				this.Nav(to: new Basket(list: _list));
			else
			{
				MessageBox.Show(text: BasketEmpty, caption: ProjectTitle, buttons: OKCancel,
								icon: Information);
			}
		}

		#region Filters

		private void FilterByName(object _, EventArgs args)
		{
			//TODO : Put here text!
			var text = "";
			deviceBindingSource.Filter = $"Name LIKE '{text}'";
		}

		private void FilterByPrice(object _, EventArgs args)
		{
			//TODO : Put price filter
			var text = "";
			deviceBindingSource.Filter = $"Price = {text}";
		}

		private void FilterByVideoRecording(object _, EventArgs args)
		{
			//TODO : PUT Filter Video Record
			var chech = false;
			deviceBindingSource.Filter = $"VideoRecord = {chech}";
		}

		#endregion

		/// <summary>
		///   Порядок сортування за відповідним полем
		/// </summary>

		#region SortOrder

		private SortOrder MegapixelOrder = Ascending;

		private SortOrder MonitorMountOrder = Ascending;
		private SortOrder NameOrder         = Ascending;
		private SortOrder PriceOrder        = Ascending;

		#endregion
	}
}
