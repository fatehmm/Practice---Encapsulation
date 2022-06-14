using System;
namespace TaskFateh0
{
	public class Lada:Car
	{
		public Lada(bool teker, int mileage, string brand, string model):base(mileage, brand, model)
		{
			this.is2Teker = teker;
		}

		public bool is2Teker;
	}
}

