/*
Написать программу,которая из имеющегося массива 
строк формирует массив из строк,длина которых меньше либо равна 3 символа.
*/

namespace KTR
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine($" Введите длину массива");
            int size = Convert.ToInt32(Console.ReadLine());
            string?[] array = new string[size];
            Console.WriteLine($"заполните массив, вводите значения массива по одному, после каждого числа нажимайте ENTER. ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToString(Console.ReadLine());

            }
            Console.WriteLine();
            PrintInputArray(array);
            PrintModifiedArray(array);

        }
        public static void PrintInputArray(string?[] array)
        {
            Console.Write($"введенный масив : [ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("]");
        }

        public static void PrintModifiedArray(string?[] array)
        {
            Console.Write($"сформированный массив : [ ");

            for (int i = 0; i < array.Length; i++)
            {
                char[] newArray;
                newArray = array[i].ToCharArray();
                if (newArray.Length <= 3)
                {
                    Console.Write($"{array[i]} ");
                }

            }
            Console.WriteLine("]");
        }

    }
}
