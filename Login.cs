using System;
using System.Windows.Forms;

using CameraShopLibrary;

using MaterialSkin.Controls;

using static System.Convert;

using static CameraShop.Properties.Resources;

namespace CameraShop
{
	/// <summary>
	///   Окно авторизации
	/// </summary>
	public partial class Login : MaterialForm
	{
		/// <summary>
		///   Ининциализация визуальных компонентов и нормализация формы
		/// </summary>
		public Login()
		{
			InitializeComponent();
			this.InitStyle();
			SelectAccount.SelectedIndex = 0;
		}

		/// <summary>
		///   Установка видимости поля для ввода пароля
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void SelectAccountChanged(object _, EventArgs args) =>
				PasswordField.Visible = ToBoolean(value: SelectAccount.SelectedIndex);

		/// <summary>
		///   Вход в режим администратора/пользователя
		/// </summary>
		/// <param name="_"></param>
		/// <param name="args"></param>
		private void SingInClick(object _, EventArgs args)
		{
			if (!PasswordField.Visible)
			{
				this.Nav(to: new User());

				return;
			}

			try
			{
				PasswordField.IsValid(text: PasswordEmpty)
						.IsAdmin(password: Password, text: PasswordError);

				this.Nav(to: new AdminEdit());
			} catch (TextFieldException exception)
			{
				MessageBox.Show(text: $"{exception.Message}");
				exception.Field.Select();
			}
		}

		/// <summary>
		///   Вход по нажатию Enter
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Login_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int) Keys.Enter) SignIn.PerformClick();
		}

		/// <summary>
		///   Встановлення каретки в поле вводу пароля
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PasswordField_VisibleChanged(object sender, EventArgs e) =>
				PasswordField.SelectAll();
	}
}
