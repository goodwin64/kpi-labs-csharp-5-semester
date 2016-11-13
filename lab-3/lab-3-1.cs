/*
 * 2-1. Написать программу вычисления площади кольца. Программа должна проверять
 *      правильность исходных данных. Нижеприведен рекомендуемый вид экрана во время выполнения
 *      программы (данные, введенные пользователем, выделены полужирным шрифтом).
 *      Вычисление площади кольца. Введите исходные данные:
 *      Радиус кольца (см) -> 3.5
 *      Радиус отверстия (см) -> 7
 *      Ошибка! Радиус отверстия не может быть больше радиуса кольца.
 *
 *      В коде не используются символы кириллицы, т.к. отсутствует их поддержка в консоли.
 */

using System.IO;
using System;

public class Lab1Class
{
    public static void Lab1Main()
    {
        Console.WriteLine("---- Lab 1");
        Console.WriteLine("Calculation the circle area.");
        
        do {
            Lab();
        } while (Program.TeacherWantsIt());
    }
    
    static void Lab() {
        Console.Write("Circle radius (sm) -> ");
        double radiusCircle;
        if (!double.TryParse(Console.ReadLine(), out radiusCircle)
            || radiusCircle <= 0) {
            Console.WriteLine("Error! The entered circle radius is invalid.");
            return;
        }
        
        Console.Write("Hole radius (sm) -> ");
        double radiusHole;
        if (!double.TryParse(Console.ReadLine(), out radiusHole)
            || radiusHole <= 0) {
            Console.WriteLine("Error! The entered hole radius is invalid.");
            return;
        }
        
        if (radiusHole > radiusCircle) {
            Console.WriteLine("Error! The hole radius can not be larger than the circle radius.");
            return;
        } else {
            double areaEntire = Math.PI * Math.Pow(radiusCircle, 2);
            double areaHole = Math.PI * Math.Pow(radiusHole, 2);
            
            Console.WriteLine($"Circle area: {areaEntire - areaHole} sm2");
        }
        
        Console.WriteLine("---- Enter any word to continue or \"exit\" to terminate:");
    }
}
