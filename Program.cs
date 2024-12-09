using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 20;
            int[] array = new int[size];
            Random random = new Random();

            Console.WriteLine("Array original:");
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 21);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int[] even = new int[size];
            int[] uneven = new int[size];
            int evenIndex = 0, unevenIndex = 0;

            for (int i = 0; i < size; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even[evenIndex] = array[i];
                    evenIndex++;
                }
                else
                {
                    uneven[unevenIndex] = array[i];
                    unevenIndex++;
                }
            }

            for (int i = 0; i < evenIndex - 1; i++)
            {
                for (int j = 0; j < evenIndex - 1 - i; j++)
                {
                    if (even[j] < even[j + 1])
                    {
                        int temp = even[j];
                        even[j] = even[j + 1];
                        even[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < unevenIndex - 1; i++)
            {
                for (int j = 0; j < unevenIndex - 1 - i; j++)
                {
                    if (uneven[j] > uneven[j + 1])
                    {
                        int temp = uneven[j];
                        uneven[j] = uneven[j + 1];
                        uneven[j + 1] = temp;
                    }
                }
            }

            int[] sortedArray = new int[size];
            int sortedIndex = 0;

            for (int i = 0; i < evenIndex; i++)
            {
                sortedArray[sortedIndex] = even[i];
                sortedIndex++;
            }

            for (int i = 0; i < unevenIndex; i++)
            {
                sortedArray[sortedIndex] = uneven[i];
                sortedIndex++;
            }

            Console.WriteLine("Array Organiced:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
