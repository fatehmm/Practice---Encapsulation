using System;
namespace TaskFateh0
{
	public class Car
	{
		public Car(int mileage)
		{
			this.Mileage = mileage;
		}

        public Car(int mileage, string brand):this(mileage)
        {
			this.Brand = brand;
        }

        public Car(int mileage, string brand, string model):this(mileage, brand)
        {
			this.Model = model;
        }

		public string Model;
		public string Brand;
		public int Mileage;
	}
}

