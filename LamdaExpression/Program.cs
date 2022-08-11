using LamdaExpression;

namespace LambdaExpression
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listOfPerson = new List<Person>();
            AddRecords(listOfPerson);
            AgeSixtyPlus_TwoRecord(listOfPerson);
        }

        private static void AddRecords(List<Person> listOfPerson)
        {
            listOfPerson.Add(new Person("9874563212", "Bruce","25 Square street,Newyork",25));
            listOfPerson.Add(new Person("9874565478", "John", "34 South Avenue,Manhattan",30));
            listOfPerson.Add(new Person("8954657412", "Wick", "956 Baker Street,London",35));
            listOfPerson.Add(new Person("7894561234", "Watson","34 Baker Square,Paris",34));
            listOfPerson.Add(new Person("4785965444", "Tony", "Newyork Tower, Newyork",36));
            listOfPerson.Add(new Person("1456234785", "Smith","Bridge road,Los Angeles",60));
            listOfPerson.Add(new Person("5478963215", "Fury", "21 City Park,California",62));
        }
        private static void AgeSixtyPlus_TwoRecord(List<Person> listOfPerson)
        {
            foreach (Person person in listOfPerson.FindAll(e=>(e.Age>=60)).Take(2))
            {
                Console.WriteLine("Name:" +person.Name+ "Age:" + person.Age);
            }
        }

    }
}