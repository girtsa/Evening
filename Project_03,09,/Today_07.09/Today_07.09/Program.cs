using System;

namespace Today_07._09
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 15; // vesels skaitlis
            char myFavoriteLetter = 'A'; // simbols
            bool isCar = true; // loģiskais true/false
            double myConstant = 4.58; // decimālskaitlis
            float myChangingNum = 2.46f; // mazāks decimālskaitlis
            string name = "Artis dsfdsg sgdfsg nsfkj"; // teksts



            Console.WriteLine(myNumber);
            Console.WriteLine(myFavoriteLetter);
            Console.WriteLine(isCar);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangingNum);
            Console.WriteLine(name);
            myChangingNum = 1.1f + myChangingNum;
            Console.WriteLine(myConstant + myChangingNum);


            // -------------------------------------------------------------

            int myNumber1 = 4;
            int myNumber2 = 6;

            int sum1 = myNumber1 + myNumber2;

            Console.WriteLine(sum1);

            string name1 = "Helli";
            string name2 = "from code";

            string namesTogether = name1 + "" + name2;

            Console.WriteLine(namesTogether);

            int withPluses = 4;
            withPluses++;

            Console.WriteLine(withPluses);

            int divisionReminder1 = 49;
            int divisionReminder2 = 10;

            int divisionremindResult = divisionReminder1 % divisionReminder2;

            Console.WriteLine(divisionremindResult);



            // -----------------------------------------------------

            int mynumber5 = 14;
            int mynumber6 = 17;

            bool isequalNumber = mynumber5 == mynumber6;

            Console.WriteLine(isequalNumber);

            string myText4 = "ABC";
            string myText5 = "ABC";

            bool isEqualText = myText4 != myText5;

            Console.WriteLine(isEqualText);

            int myNumber7 = 15;
            int myNumber8 = 17;

            bool isEqualNumber2 = myNumber7 > myNumber8;

            Console.WriteLine(isEqualNumber2);


            // ------------------------------------

            bool iAmTrue = true;
            bool iAmFalse = false;

            bool both = iAmTrue && iAmFalse;
            bool or = iAmTrue || iAmFalse;
            bool bothReversed = !both;

            Console.WriteLine(both);
            Console.WriteLine(or);
            Console.WriteLine(bothReversed);

            // ---------------------------------------------

            int myNumber9 = 14;

            myNumber9 += 10;
            Console.WriteLine(myNumber9);

            // -----------------------------------------------


            // Console.WriteLine("kāds ir tavs vārds");

            // string userName = Console.ReadLine();

            // Console.WriteLine("Sveiks," + userName);





            // Console.WriteLine("kāds ir tavs vecums");

            // string ageText = Console.ReadLine();

            // int age = int.Parse(ageText);
            // int previosYearAge = age - 1;

            // Console.WriteLine("Sveiks tev iepriekšējā gadā bija," + previosYearAge);

            // ------------------------------------------------------------------

            int maxnumber1 = 4;
            int maxnumber2 = 6;

            int maxResult = Math.Max(maxnumber1, maxnumber2);

            Console.WriteLine(maxResult);


            int absWithMinus = -45;
            int absAfter = Math.Abs(absWithMinus);

            Console.WriteLine(absAfter);


            double numberToRound = 14.258;
            double rounded = Math.Round(numberToRound, 2);

            Console.WriteLine(rounded);

            // --------------------------------------------------------

        }

    }
}
