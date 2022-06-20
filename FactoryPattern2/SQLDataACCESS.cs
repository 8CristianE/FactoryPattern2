using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
	public class SQLDataACCESS : IDataAccess
	{
		public SQLDataACCESS()
		{
		}

        public List<Product> LoadData()
        {
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving Data to SQL data acess");
        }
    }
}

