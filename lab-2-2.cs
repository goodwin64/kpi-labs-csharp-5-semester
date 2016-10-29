/*
 * 2-2. Написать программу, которая вычисляет стоимость междугородного телефонного
 *      разговора (цена одной минуты определяется расстоянием до города, в котором находится
 *      абонент). Исходными данными для программы являются код города и длительность разговора.
 *      Ниже приведены коды некоторых городов и рекомендуемый вид экрана во время работы
 *      программы (данные, введенные пользователем, выделены полужирным шрифтом).
 *      
 *      - Город -       Код     Цена минуты (руб.)
 *      Владивосток     423     2.2
 *      Москва          095     1.0
 *      Мурманск        815     1.2
 *      Самара          846     1.4
 */

using System.IO;
using System;

public class Lab2Class
{
    public static void Lab2Main()
    {
        int[] cityCodes = { 423, 095, 815, 846 };
        String[] cityNames = { "Vladivostok", "Moscow", "Murmansk", "Samara" };
        double[] minutePrices = { 2.2, 1.0, 1.2, 1.4 };
        
        Console.WriteLine("---- Lab 2");
        Console.WriteLine("Calculation the phone call cost.");
        
        do {
            Lab(cityCodes, cityNames, minutePrices);
        } while (Program.TeacherWantsIt());
    }
    
    static void Lab(int[] cityCodes, String[] cityNames, double[] minutePrices) {
        Console.Write("City code -> ");
        int cityCode,
            codeIndex;
        if (!Int32.TryParse(Console.ReadLine(), out cityCode)
            || (codeIndex = Array.IndexOf(cityCodes, cityCode)) < 0) {
            Console.WriteLine("Error! The entered city code is invalid.");
            return;
        }
        
        Console.Write("Call duration, minutes (integer) -> ");
        int callDuration;
        if (!Int32.TryParse(Console.ReadLine(), out callDuration)
            || callDuration < 0) {
            Console.WriteLine("Error! The entered hole radius is invalid.");
            return;
        }
        
        Console.WriteLine($"City: {cityNames[codeIndex]}");
        Console.WriteLine($"Minute call price: {minutePrices[codeIndex]}");
        Console.WriteLine($"Entire call price: {minutePrices[codeIndex] * callDuration}");
        
        Console.WriteLine("---- Enter any word to continue or \"exit\" to terminate:");
    }
}
