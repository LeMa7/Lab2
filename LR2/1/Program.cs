﻿using System;
using System.Text;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            ///////////////////
            //   Задание 1   //
            ///////////////////

            // a) Определите переменные всех возможных примитивных типов С# и проинициализируйте их.  

            sbyte a1 = 1;
            Console.WriteLine($"    Задание 1(a)\n sbyte: { a1}");
            short a2 = 2;
            Console.WriteLine($" short: {a2}");
            int a3 = 3;
            Console.WriteLine($" int: {a3}");
            long a4 = 4;
            Console.WriteLine($" long: {a4}");
            byte a5 = 5;
            Console.WriteLine($" byte: {a5}");
            ushort a6 = 6;
            Console.WriteLine($" ushort: {a6}");
            uint a7 = 7;
            Console.WriteLine($" uint: {a7}");
            ulong a8 = 8;
            Console.WriteLine($" ulong: {a8}");
            char a9 = '9';
            Console.WriteLine($" char: {a9}");
            bool a10 = true;
            Console.WriteLine($" bool: {a10}");
            float a11 = 11;
            Console.WriteLine($" float: {a11}");
            double a12 = 12;
            Console.WriteLine($" double: {a12}");
            string a13 = "13";
            Console.WriteLine($" string: {a13}\n");
            

            // b) Выполните операции явного и неявного приведения.

            short b1 = 1;
            int b2 = b1; //неявное приведение
            Console.WriteLine($"    Задание 1(b)\nshort b1 = {b1}, int b2 = b1, b2 = {b2} ");

            long b3 = 1000;
            int b4 = (int)b3; //явное приведение
            Console.WriteLine($"long b3 = {b3}, int b4 = (int)b3, b4 = {b4} \n\n");

            // c) Выполните упаковку и распаковку значимых типов.

            Console.WriteLine($"    Задание 1(с)\n");
            int x = 123;
            object o = x; // боксинг
            Console.WriteLine($"o = {o}");
            o = 123;
            x = (int)o;  // анбоксинг
            Console.WriteLine($"x = {x} \n\n");

            // d) Продемонстрируйте работу с неявно типизированной переменной.

            var c = "word";
            Console.WriteLine($"    Задание 1(d)\nиницализирована переменна 'c' типа стринг и равная: '{c}'\n\n");

            // e) Продемонстрируйте пример работы с Nullable переменной.

            int? c1 = null; // инициализация типа Nullable
            int c2 = 999;
            Console.WriteLine($"    Задание 1(e)\nc1 = null, c2 = 999\nc1??c2: {c1??c2}\n\n"); //вернётся левый операнд если он не равен null


            ///////////////////
            //   Задание 2   //
            ///////////////////

            // a) Объявите строковые литералы. Сравните их.

            string s1 = "stroka1", s2 = "stroka2";
            Console.WriteLine($"    Задание 2(a)\ns1 = {s1}, s2 = {s2}");
            if (s1 == s2)
                Console.WriteLine("Строки s1 и s2 равны");
            else
                Console.WriteLine("Строки s1 и s2 не равны\n\n");

            /* b)
                  Создайте три строки на основе String.Выполните: сцепление, копирование, 
                  выделение подстроки, разделение строки на слова, вставки подстроки в
                  заданнуюпозицию, удаление заданнойподстроки 
            */
            string str1 = "14325", str2 = "word2", str3 = " a b c ";
            Console.WriteLine($"    Задание 2(b)\nstr1 = '{str1}', str2 = '{str2}', str3 = '{str3}'\nstr1 + str2 = '{str1 + str2}' - сцепление");
            Console.WriteLine($"{string.Copy(str1)} - копия str1"); //копирование
            Console.WriteLine($"{str1.Substring(1)} - выделение подстроки str1 со 2 элемента"); //выделение подстроки
            Console.WriteLine($"{str1.Insert(3,"lol")} - вставка подстроки"); //вставка подстроки
            Console.WriteLine($"{str1.Remove(2,2)} - удаление заданной подстроки\n\n"); //удаление заданной подстроки

            // c) Создайте пустую и nullстроку.Продемонстрируйте что можно выполнить с такими строками

            string pusto = "";
            string Nul = null;
            Console.WriteLine($"    Задание 2(b)\nПустая строка: {pusto.Insert(0,"str")} - вставка прошла успешно");
            Console.WriteLine($"nellстрока: ошибка\n\n");

            // d) Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.

            StringBuilder sb = new StringBuilder("ABC", 50);
            Console.WriteLine($"Создаём StringBuilder на 50 символов и иницализируем строкой: {sb}");
            sb.Append(new char[] { 'D', 'E', 'F' });
            Console.WriteLine($"Добавляем три символа в конец: {sb}");
            sb.Insert(0, "Alphabet: ");
            Console.WriteLine($"Вставляем строку в начало: {sb}");
            sb.Remove(10, 2);
            Console.WriteLine($"Удаление символов {sb}\n\n");


            ///////////////////
            //   Задание 3   //
            ///////////////////

            // a) Создайте целый двумерный массив и выведите его на консоль в отформатированном виде(матрица). 

            Console.WriteLine("    Задание 3(a)\nДвумерный массив:");
            int[,] mas = new int[3, 3];
            for(int i = 0,k=1;i<3;i++)
            {
                for(int j = 0;j<3;j++)
                {
                    Console.Write($" {mas[i,j]=k}");
                    k++;
                }
                Console.WriteLine();
            }

            // b) Создайте одномерный массив строк. Выведите на консоль его  содержимое, длину массива.
            //    Поменяйте произвольный элемент (пользователь определяет позицию и значение).

            string[] A = { "ABC", "CDE", "EFG" };
            Console.WriteLine($"\n\n    Задание 3(b)\nМассив строк A: {A[0]} {A[1]} {A[2]}\nВведите позицию(от 1 до 3) и значение элемента: ");
            int f = int.Parse(Console.ReadLine());
            string g = Console.ReadLine();
            A[f-1] = g;
            Console.WriteLine($"Итоговый массив: {A[0]} {A[1]} {A[2]}\n\n");

            // c) Создайте ступечатый(не выровненный) массив вещественных чисел с 3-мя строками,
            //    в каждой из которых 2, 3 и 4 столбцов соответственно.

            int[][] B = { new int[2] { 1, 2 }, new int[3] { 3, 4, 5 }, new int[4] { 6, 7, 8, 9} };
            Console.WriteLine($"    Задание 3(c)\nСтупенчатый массив: \n");
            for(int i=0,k=2,bg=1;i<3;i++,k++)
            {
                for(int j = 0; j<k;j++)
                {
                    Console.Write($" {B[i][j]=bg}");
                    bg++;
                }
                Console.WriteLine();
            }

            // d) Создайте неявно типизированные переменные для хранения массива и строки.

            var C = new object[]{1,2,3,4,5};
            var G = "string";
            Console.WriteLine($"\n\n    Задание 3(d)\nНеявно типзированные массив: {C[0]} {C[1]} {C[2]} {C[3]} {C[4]}\nи строка: {G}\n\n");


            ///////////////////
            //   Задание 4   //
            ///////////////////

            /* a) Задайте кортеж из 5 элементов с типами int, string, char, string, ulong.
               b) Сделайте именование его элементов.
               c) Выведите кортеж на консоль целиком
             */

            (int t1, string t2, char t3, string t4, ulong t5) tuple = (1, "2", '3', "4", 5);
            Console.WriteLine($"    Задание 4(a,b,c)\nКортеж tuple: {tuple.Item1}, {tuple.t2}, {tuple.Item3}, {tuple.t4}, {tuple.Item5}, \n\n");

            // d) Выполните распаковку кортежа в переменные

            var (one, two, three, four, five) = tuple;
            Console.WriteLine($"    Задание 4(d)\nРаспаковка кортежа tuple в переменные one={one}, two={two}, three={three}, four={four}, five={five}\n\n");

            ///////////////////
            //   Задание 5   //
            ///////////////////

            /*
             Создайте локальную функцию в main и вызовите ее. Формальные параметры функции: 
             массив целых и строка. Функция должна вернуть кортеж, содержащий: максимальный
             и минимальный элементы массива, сумму элементов массива и первую букву строки
             */

            Console.WriteLine($"    Задание 5");

            (int,int,int,char) createTuple(int[] grh,string bhm)
            {
                int max = 0, min = 9999, sum = 0;
                char firstLetter=bhm[0];
                for (int i = 0; i < grh.Length; i++)
                {
                    if (grh[i] > max)
                        max = grh[i];
                    if (grh[i] < min)
                        min = grh[i];
                    sum += grh[i];
                }
                return (max, min, sum, firstLetter); 
            }
            (int, int, int, char) SomeTuple = createTuple(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, "OOP");
            Console.WriteLine($"Кортеж 'someTuple' инииализированный функцией 'createTuple': {SomeTuple}");

        }
    }
}
