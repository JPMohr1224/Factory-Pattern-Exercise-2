using System;
namespace FactoryPatternExercise2
{
	public class ListDataClass : IDataAccess
	{
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading from a List database");
            return new List<Product>();
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List Database.");
        }
    }
}

