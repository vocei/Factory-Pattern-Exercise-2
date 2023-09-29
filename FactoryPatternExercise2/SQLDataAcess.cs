using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAcess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
            {
                new Product (){Name="PS5", Price = 600},
                new Product (){Name="XBOX", Price = 600},
                new Product (){Name="Switch", Price = 350},
                new Product (){Name="Controller", Price = 80},
                new Product (){Name="Charger", Price = 25 },
            }; 
   
        

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from SQL Data Acess.");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data from a SQL Data Acess.");
        }
    }
}
