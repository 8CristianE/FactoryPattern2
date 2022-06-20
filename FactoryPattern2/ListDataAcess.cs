using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
	public class ListDataAcess :IDataAccess
	{
		public ListDataAcess()
		{
		}

        public void SaveData()
        {
            Console.WriteLine("Saving Data to new List");
        }

        public List<Product> LoadData()
        {
            return Product.products;
        }

    }
}

