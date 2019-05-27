using System;
using System.Windows.Forms;

using CameraShop.Properties;

using CameraShopLibrary;

using MaterialSkin.Controls;

namespace CameraShop
{
	/// <summary>
	///   Окно добавления товара , режим администратора
	/// </summary>
	public partial class Admin : MaterialForm
	{
		/// <summary>
		///   Инициализация визуальных компонентов и нормализация стиля формы
		/// </summary>
		public Admin()
		{
			InitializeComponent();
			this.InitStyle();
		}

		/// <summary>
		///   Загрузка данных на форму
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Admin_Load(object sender, EventArgs e)
		{
			deviceShellTableAdapter.Fill(dataTable: cameraMarketDataSet.DeviceShell);

			diveceViewFinderTableAdapter.Fill(dataTable: cameraMarketDataSet.DiveceViewFinder);

			deviceColorProfileTableAdapter.Fill(dataTable: cameraMarketDataSet.DeviceColorProfile);

			deviceSystemTableAdapter.Fill(dataTable: cameraMarketDataSet.DeviceSystem);

			deviceTableAdapter.Fill(dataTable: cameraMarketDataSet.Device);

			deviceTypesTableAdapter.Fill(dataTable: cameraMarketDataSet.DeviceTypes);
			deviceBindingSource.AddNew();
		}

		/// <summary>
		///   Обработка нажатия на выход в меню
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void ExitClick(object _, EventArgs args) =>
				OnFormClosing(e: new
									FormClosingEventArgs(closeReason: CloseReason.ApplicationExitCall,
														cancel: true));

		/// <summary>
		///   Переход к окну авторизациии
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void LoginClick(object _, EventArgs args) => this.Nav(to: new Login());

		/// <summary>
		///   Точно хотите выйти?
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AdminFormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show(text: Resources.ExitQuestion, caption: Resources.ProjectTitle,
								buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question)
				== DialogResult.Yes)
				Application.ExitThread();
			else
				e.Cancel = true;
		}

		/// <summary>
		///   Переход к окну редактирования
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EditClick(object sender, EventArgs e) => this.Nav(to: new AdminEdit());

		/// <summary>
		///   Вызов справки
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HelpClick(object sender, EventArgs e) { }

		/// <summary>
		///   Сохранение добавленого товара
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Append_Click(object sender, EventArgs e)
		{
			try
			{
				this.ValidateAll();
			} catch (Exception exception)
			{
				MessageBox.Show(text: $"{exception.Message}");

				return;
			}

			Validate();
			deviceBindingSource.EndEdit();
			deviceColorProfileBindingSource.EndEdit();
			deviceShellBindingSource.EndEdit();
			deviceTypesBindingSource.EndEdit();
			deviceSystemBindingSource.EndEdit();
			tableAdapterManager.UpdateAll(dataSet: cameraMarketDataSet);
			deviceBindingSource.AddNew();
		}
	}
}
