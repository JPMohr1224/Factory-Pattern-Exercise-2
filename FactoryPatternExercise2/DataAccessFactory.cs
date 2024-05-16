using System;
namespace FactoryPatternExercise2
{
	public class DataAccessFactory
	{
		public static IDataAccess GetDataAccessType(string databaseType)
		{
			switch (databaseType.ToLower())
			{
				case "list":
					return new ListDataClass();
				case "sql":
					return new SQLDataAccess();
				case "mongo":
					return new MongoDataAccess();
				default:
					return new ListDataClass();


            }
			
		}
	}
}

