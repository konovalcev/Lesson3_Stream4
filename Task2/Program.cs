using System;

// Реализовать шейкерную сортировку.

// Коновальцев Александп


namespace Task2
{
    static class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = {1,3,2,5,4,7,6,9,8 };
            Array.ForEach(array, Console.WriteLine);
            CocktailSharerSort(ref array);
            Array.ForEach(array, Console.WriteLine);
        }


        private static void CocktailSharerSort(ref int[] array)
        {
            while (true)
            {
                bool flag;
                int[] start = { 1, array.Length - 1 };
                int[] end = { array.Length, 0 };
                int[] inc = { 1, -1 };

                for (int it = 0; it < 2; ++it)
                {
                    flag = true;

                    for (int i = start[it]; i != end[it]; i += inc[it])
                    {
                        if (array[i - 1] > array[i])
                        {
                            Swap(ref array[i - 1], ref array[i]);
                            flag = false;
                        }
                    }

                    if (flag) return;
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }
    }
}