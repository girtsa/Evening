using System;

namespace Lession_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3];

            string[] texts = new string[2];
            bool[] values = new bool[4];

            nums[0] = 15;
            nums[1] = 27;

            foreach (int num in nums)
            {
                Console.WriteLine($"Inside foreach {num}");
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                Console.WriteLine($"Inside for cickle {num}");
            }

            int j = 0;
            while (j < nums.Length)
            {
                int num = nums[j];
                Console.WriteLine($"Inside while cickle {num}");
                j++;
            }
            int userNumber = GetNumberSafe();
            Console.WriteLine($"Safely got user number: {userNumber}");
        }

        static int GetNumberSafe()
        {
            int num;
            bool isValidNum;

            do
            {

                Console.WriteLine("Ievadi veselu skaitli");

                string userText = Console.ReadLine();

                isValidNum = int.TryParse(userText, out num);

            } while (!isValidNum);

            return num;

        }

    }
}
