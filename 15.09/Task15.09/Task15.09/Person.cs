using System;

namespace Task15._09_
{
    
        public class Person
        { 
            public Person(string name)
        {
                Name = name;
                }

        public string Name { get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = Math.Abs(value);
            }
        }
        public double Money { get; set; }
        public bool IsMale { get; set; }
        public char Initial { get; set; }
        public string GetGreeting()
        {
            string greeting = "Hello my name is" + Name + "and I am" + Age + " years old";

            return greeting;


            Console.WriteLine("What is telephone brand");
            string brandText = Console.ReadLine();
            int brand = int.Parse(brandText);       }

     }
}