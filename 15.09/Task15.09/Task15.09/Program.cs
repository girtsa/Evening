using System;

namespace Task15._09_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Artis");
            Person person2 = person;

            // person.Name = "Artis2222";
            person.Name = "Artis";
            person.Age = 15;
            person.IsMale = true;
            person.Money = 154.58;
            person.Initial = 'A';

            person2.Age = 26;

            string greeting = person.GetGreeting();

            Console.WriteLine(greeting);

        }
    }
}
