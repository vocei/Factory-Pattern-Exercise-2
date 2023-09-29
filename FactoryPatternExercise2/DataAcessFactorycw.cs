using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public static class DataAcessFactory
    {

        public static IDataAccess GetDataAccessType(string databaseType)
        {
           

            switch (databaseType.ToLower())
            {
                case "mongo":
                    return new MongoDataAcess();
                case "sql":
                    return new SQLDataAcess();
                case "list":
                    return new ListDataAcess();
                default:
                    return new ListDataAcess();
              
            }

        }
    }
}
