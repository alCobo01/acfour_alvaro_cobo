using System;

namespace acfour_alvaro_cobo {

    public class AlvaroAcfour
    {
        public static void PrintArray(int[] array)
        {
            const string Message = "Your numbers are: ";

            Console.Write(Message);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void Main()
        {
            //Constants and variables
            const string FirstMessage = "Write how many numbers do you want to store? ";
            const string WriteNumbersMessage = "Write the number in the position {0}: ";
            const string ErrorMessage = "Incorrect format.";
    

            int numUser;

            //Main program
            Console.Write(FirstMessage);
            try
            {
                numUser = Convert.ToInt32(Console.ReadLine());
                int[] arrayNumbers = new int[numUser];
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    Console.Write(WriteNumbersMessage, i + 1);
                    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                PrintArray(arrayNumbers);

            }
            catch (FormatException)
            {
                Console.WriteLine(ErrorMessage);
            }
        }
    }
}
