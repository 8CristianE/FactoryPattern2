using System;
namespace FactoryPattern2
{
    public static class DataAccessFacotry
	{
		public static IDataAccess GetDataAccess(string dataType)
        {
            switch(dataType.ToLower())
            {
                case "list":
                    return new ListDataAcess();
                case "sql":
                    return new SQLDataACCESS();
                case "mongo":
                    return new MongoDataAcess();
                default:
                    return new ListDataAcess();

            }

            
        }
	}
}

