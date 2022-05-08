using AptitudeTestHandler.InfraStructure;
using System;
using System.Linq;

namespace AptitudeTestHandler.Implementation
{
    public class SumOfBiggestNeighborInArray : ISumOfBiggestNeighborInArray
    {
        public int Challenge(int[] input)
        {
            int max = input[0] + input[1];

            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 1)
                {
                    if (max < input[i] + input[i + 1])
                    {
                        max = input[i] + input[i + 1];
                    }
                }

            }
            Console.WriteLine("The biggest combination of neighbor element that can be found in array:" + max);

            Console.WriteLine("Display of Array After Removing Unique Elements:");
            var duplicateArrayElements = RemoveUniqueELementsFromArray(input);
            for (int i = 0; i < duplicateArrayElements.Length; i++)
            {
                Console.Write(duplicateArrayElements[i] + " ");
            }
            MaxOccurrence(input);
            return 0;
        }

        public int[] RemoveUniqueELementsFromArray(int[] array)
        {
            bool equalTO = false;
            int i = 0;
            for (i = 0; i < array.Length; i++)
            {
                equalTO = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[i].Equals(array[j])))
                    {
                        equalTO = true;
                    }
                }
                if (!equalTO && i > 0)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if ((array[i].Equals(array[k])))
                        {
                            equalTO = true;
                        }
                    }
                }

                if (!equalTO)
                {
                    array = RemoveAt(array, i);
                    i = 0;
                }
            }
            return array;
        }

        public T[] RemoveAt<T>(T[] source, int index)
        {
            T[] dest = new T[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, dest, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);

            return dest;
        }

        public  void MaxOccurrence(int[] numbers)
        {
            var groups = numbers.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            Console.WriteLine("\nThe most common number is {0} and it appears {1} times", largest.Key, largest.Count());
            Console.WriteLine("\nSo,the M is equal to {0}",largest.Count());
        }

    }
}
