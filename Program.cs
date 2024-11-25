using System;

namespace acfour_alvaro_cobo
{
    public class Program
    {
        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
            return array;
        }

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

                arrayNumbers = BubbleSort(arrayNumbers);
                PrintArray(arrayNumbers);

            }
            catch (FormatException)
            {
                Console.WriteLine(ErrorMessage);
            }
        }
    }
}