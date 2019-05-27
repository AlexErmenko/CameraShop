using System;

using CameraShopLibrary;

using MaterialSkin.Controls;

namespace CameraShop
{
	/// <summary>
	///   Стартовое окно с информацией о теме курсового и ее разработчике
	/// </summary>
	public partial class Start : MaterialForm
	{
		/// <summary>
		///   Инициализация визуальных компонентов
		/// </summary>
		public Start() => InitializeComponent();

		/// <summary>
		///   Переход на окно авторизации
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void ToLoginClick(object _, EventArgs args) => this.Nav(to: new Login());
	}
}
