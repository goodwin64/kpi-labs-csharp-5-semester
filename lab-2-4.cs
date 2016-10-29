/*
 * 2-4. Написать программу, которая вычисляет среднее арифметическое ненулевых
 *      элементов введенного с клавиатуры массива целых чисел. Ниже приведен рекомендуемый вид
 *      экрана во время работы программы (данные, введенные пользователем, выделены полужирным
 *      шрифтом).
 *      Введите элементы массива (10 целых чисел) в одной строке и нажмите <Enter>.
 *      -> 23 0 45 -5 12 0 -2 30 0 64
 *      Сумма элементов массива: 184 (167, фактически)
 *      Количество ненулевых элементов: 7
 *      Среднее арифметическое ненулевых элементов: 23.86
 */

using System.IO;
using System;
using System.Linq;

public class Lab4Class
{
    public static void Lab4Main()
    {
        Console.WriteLine("---- Lab 4");
        Console.WriteLine("Array not-null average");

        do {
            Lab();
        } while (Program.TeacherWantsIt());
    }

    static void Lab() {
        string[] fromConsole = Console.ReadLine().Split(' ');      // like in task
        /*string[] fromConsole =
        { "23", "0", "45", "-5", "12", "0", "-2", "30", "0", "64" };  // in case you wanna save time
        foreach (var item in fromConsole) {
            Console.Write(item.ToString() + " ");
        }
        Console.WriteLine();*/

        int[] filteredArr = Array
                                .ConvertAll(fromConsole, int.Parse)
                                .Where(item => item != 0)
                                .ToArray();

        int sum = Enumerable.Sum(filteredArr);
        int length = filteredArr.Length;

        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Average: {0}", (double)sum / length);

        Console.WriteLine("---- Enter any word to continue or \"exit\" to terminate:");
    }
}
