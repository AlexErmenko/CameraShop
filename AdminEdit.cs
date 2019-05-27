using System;
using System.Windows.Forms;

using CameraShop.Properties;

using CameraShopLibrary;

using MaterialSkin.Controls;

namespace CameraShop
{
	/// <summary>
	///   Окно режима администратора редактирование товара
	/// </summary>
	public partial class AdminEdit : MaterialForm
	{
		/// <summary>
		///   Инициализация визуальных компонентов и нормализация стилей формы
		/// </summary>
		public AdminEdit()
		{
			InitializeComponent();
			this.InitStyle();
		}

		/// <summary>
		///   Загрузка данных на форму
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AdminEdit_Load(object sender, EventArgs e)
		{
			deviceTypesTableAdapter.Fill(dataTable: cameraMarketDataSet.DeviceTypes);
			deviceShellTableAdapter.Fill(dataTable: cameraMarketDataSet.DeviceShell);
			diveceViewFinderTableAdapter.Fill(dataTable: cameraMarketDataSet.DiveceViewFinder);
			deviceColorProfileTableAdapter.Fill(dataTable: cameraMarketDataSet.DeviceColorProfile);
			deviceSystemTableAdapter.Fill(dataTable: cameraMarketDataSet.DeviceSystem);
			deviceTableAdapter.Fill(dataTable: cameraMarketDataSet.Device);
		}

		/// <summary>
		///   Переход к окну авторизации
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LoginFormClick(object sender, EventArgs e) => this.Nav(to: new Login());

		/// <summary>
		///   Переход к окну добавления товара
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AdminForm_Click(object sender, EventArgs e) => this.Nav(to: new Admin());

		/// <summary>
		///   Вызов справки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Help_Click(object sender, EventArgs e)
		{
			//TODO: Добавить help и вставить сюда!
		}

		/// <summary>
		///   Обработка нажатия на выход
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		public void ExitClick(object _, EventArgs args) =>
				OnFormClosing(e: new
									FormClosingEventArgs(closeReason: CloseReason.ApplicationExitCall,
														cancel: true));

		/// <summary>
		///   Обработка события закрытия формы
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AdminEditFormClosing(object sender, FormClosingEventArgs e)
		{
			var reporter = new Reporter(report: new XmlReport(dataSet: cameraMarketDataSet));

			if (MessageBox.Show(text: Resources.ExitQuestion, caption: Resources.ProjectTitle,
								buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question)
				== DialogResult.Yes)
				Application.ExitThread();
			else
				e.Cancel = true;
		}

		/// <summary>
		///   Сохранение изменений
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		public void SaveChanges(object _, EventArgs args)
		{
			Validate();
			deviceBindingSource.EndEdit();
			deviceColorProfileBindingSource.EndEdit();
			deviceShellBindingSource.EndEdit();
			deviceSystemBindingSource.EndEdit();
			deviceTypesBindingSource.EndEdit();
			diveceViewFinderBindingSource.EndEdit();

			tableAdapterManager.UpdateAll(dataSet: cameraMarketDataSet);
		}

		/// <summary>
		///   Удаление выбраного товара
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveCurrentDevice(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex          != -1
				&& deviceBindingSource.Position != -1)
			{
				deviceBindingSource.RemoveCurrent();
				Validate();
				deviceBindingSource.EndEdit();
				deviceColorProfileBindingSource.EndEdit();
				deviceShellBindingSource.EndEdit();
				deviceSystemBindingSource.EndEdit();
				deviceTypesBindingSource.EndEdit();
				diveceViewFinderBindingSource.EndEdit();
				tableAdapterManager.UpdateAll(dataSet: cameraMarketDataSet);
			}
		}
	}
}
