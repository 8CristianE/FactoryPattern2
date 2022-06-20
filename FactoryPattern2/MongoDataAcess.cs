using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
	public class MongoDataAcess : IDataAccess
	{
		public MongoDataAcess()
		{
		}

        public List<Product> LoadData()
        {
            return Product.products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving Data to mongo base.");
        }
    }
}

