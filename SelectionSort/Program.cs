using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 5, 2, 3, 4 };

            ShowNumbers(numbers);
            ShowNumbers(SelectionSort(numbers));
            Console.ReadKey();
        }

        public static int[] SelectionSort(int[] numbers)
        {
            int indexMin, temp;

            for (int i = 0; i < numbers.Length-1; i++)
            {
                indexMin = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[indexMin])
                    {
                        indexMin = j;
                    }
                }

                if(indexMin!=i)
                {
                    temp = numbers[i];
                    numbers[i] = numbers[indexMin];
                    numbers[indexMin] = temp;
                }


            }

            return numbers;
        }



        public static void ShowNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
