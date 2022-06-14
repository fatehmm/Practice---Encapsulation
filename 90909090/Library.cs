using System;
namespace _90909090
{
	public class Library
	{
		public Library()
		{
		}
		Product[] Products = new Product[0];

		public void AddProduct(Product product)
        {
			Array.Resize(ref Products, Products.Length + 1);
			Products[Products.Length - 1] = product;
        }

		public int GetJournalCount()
        {
			int count = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Journal)
                {
					count++;
                }
            }
			return count;
        }

        public int GetBookCount()
        {
            int count = 0;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i] is Book)
                {
                    count++;
                }
            }
            return count;
        }
        public Product[] GetProducts(bool isBook)
        {
            Product[] products = new Product[0];
            if (isBook)
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i] is Book)
                    {
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length - 1] = Products[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < Products.Length; i++)
                {
                    if (Products[i] is Journal)
                    {
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length - 1] = Products[i];
                    }
                }
            }
            return products;
        }
    }
}

