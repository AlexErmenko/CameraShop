using static CameraShop.CameraMarketDataSet;

namespace CameraShop
{
	/// <summary>
	///   Класс для метода расширения
	/// </summary>
	public static class DeconstructExtantions
	{
		/// <summary>
		///   Метод расширения для деконструкции обьекта
		/// </summary>
		/// <param name="row"></param>
		/// <param name="name"></param>
		/// <param name="price"></param>
		public static void Deconstruct(this DeviceRow row, out string name, out decimal price)
		{
			name  = row.Name;
			price = row.Price;
		}
	}
}
