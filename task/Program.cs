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
        }
    }
}
