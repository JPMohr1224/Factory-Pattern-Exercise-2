namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What type of database would you like to use? List, SQL, or Mongo?");
            var userInput = Console.ReadLine();

            DataAccessFactory.GetDataAccessType(userInput);

            IDataAccess dataset = DataAccessFactory.GetDataAccessType(userInput);

            dataset.LoadData();
            dataset.SaveData();
        }
    }
}
