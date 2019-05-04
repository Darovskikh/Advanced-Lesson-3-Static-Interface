﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_3_Static_Interface
{
    public partial class Practice
    {
        /// <summary>
        /// AL3-P1/3. Создать класс UniqueItem c числовым полем Id. 
        /// Каждый раз, когда создается новый экземпляр данного класса, 
        /// его идентификатор должен увеличиваться на 1 относительно последнего созданного. 
        /// Приложение должно поддерживать возможность начать идентификаторы с любого числа. 
        /// </summary>
        public static void AL3_P1_3()
        {
        }

        /// <summary>
        /// AL3-P2/3. Отредактировать консольное приложение Printer. 
        /// Заменить базовый абстрактный класс на интерфейс.
        /// </summary>
        public static void AL3_P2_3()
        {

        }


        /// <summary>
        /// AL3-P3/3. Создайте обобщенный метод GuessType<T>(T item), 
        /// который будет принимать переменную обобщенного типа и выводить на консоль, 
        /// что это за тип был передан.
        /// </summary>
        public static void AL3_P3_3()
        {
            GuessType("Привет");
            GuessType(123);
            GuessType(-123);
            GuessType(12.33223);
            GuessType(DateTime.Now);

        }

        public static void GuessType<T>(T item)
        {
            switch (item)
            {
                case string str:
                    Console.WriteLine($"Вы передали строку {str.Length} символов");
                    break;
                case int i:
                    if (i >= 0)
                    {
                        Console.WriteLine("Вы передали целое положительное число");
                    }
                    else
                    {
                        Console.WriteLine("Вы передали целое отрицательное число");
                    }
                    break;
                case double doub:
                    string[] strings = doub.ToString().Split(',');
                    Console.WriteLine($"Вы передали вещественное число с {strings[1].Length} значащими цифрами");
                    break;
                case DateTime date:
                    Console.WriteLine("Вы передали время");
                    break;
            }
        }
    }
}
