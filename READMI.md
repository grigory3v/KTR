#### __https://github.com/grigory3v/KTR.git__

# Описание решения задачи. 

*Написать программу,которая из имеющегося массива 
строк формирует массив из строк,длина которых меньше либо равна 3 символа.*

### С чего начианал? 

Для начала написал программу которая принимает массив от пользователя.

     Console.WriteLine($" Введите длину массива");
            int size = Convert.ToInt32(Console.ReadLine());
            string?[] array = new string[size];
            Console.WriteLine($"заполните массив, вводите значения массива по одному, после каждого числа нажимайте ENTER. ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToString(Console.ReadLine());

            }

*Запрашиватся длина массива у пользователя, и создается массив в который пользователь вводит строковые значения любой длины.*

### После того как массив был получен и записан в память вывели его на экран для удобства


    Console.Write($"введенный масив : [ ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("]");
        
*тут как и в предыдущей функции используем цикл for для перебора значений массива только в данном случае для вывода на экран*

Решил разделить ввод массива  и печать, для дальнейшего удобства использования программы и для структурирования.

### Когда массив был получен и выведен на экран написал функцию которая решает задачу


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

*в данной функции так же использовал цикл for для перебора каждого массива, так же создал массив(чар), для получения индексов строкового значения и оперций над ними.Если колличество символов > 3, то брался следующий индекс, если <=3 то выводился на экран в качестве нового массива.*

