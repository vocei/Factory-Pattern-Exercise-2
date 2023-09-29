namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool correctInput;
            

            do
            {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("Which Database would you like to use?");
                Console.WriteLine("Currently stored Case Sensitive Databases: Mongo, Sql, List");


                userInput = Console.ReadLine();


                if (userInput != "Sql" && userInput != "Mongo" && userInput != "List")
                {
                    correctInput = false;
                    Console.WriteLine("We dont have that Database avaliable");
                    Thread.Sleep(1000);
                }

            } while (!correctInput); ;
            Console.Clear ();

            IDataAccess db = DataAcessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var product in products ) 
            {
                Console.WriteLine($"\nName:{product.Name} \nPrice:{product.Price} \n");
            }
        }
    }
}
