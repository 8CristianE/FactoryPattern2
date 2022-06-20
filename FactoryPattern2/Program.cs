using System;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database so you wanna user?");
            Console.WriteLine("List,Sql,Mongo???");
            var response = Console.ReadLine();

            var da = DataAccessFacotry.GetDataAccess(response);

            da.SaveData();

            var products = da.LoadData();
            Console.WriteLine($"Your Items:");
        }
    }
}

