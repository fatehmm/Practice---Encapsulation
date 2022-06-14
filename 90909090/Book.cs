using System;
namespace _90909090
{
	public class Book:Product
	{
		public Book()
		{
		}
		public string Genre;
		public string Author;
        public override void GetInfo()
        {
            Console.WriteLine("Bu kitabdir......");
        }

    }
}

