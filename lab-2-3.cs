/*
 * 2-3. Напишите программу, которая выводит на экран квадрат Пифагора — таблицу умножения.
 *      Рекомендуемый вид экрана во время выполнения программы приведен ниже.
 *              1   2   3   4   5   6   7   8   9  10
 *          1   1   2   3   4   5   6   7   8   9  10
 *          2   2   4   6   8  10  12  14  16  18  20
 *          3   3   6   9  12  15  18  21  24  27  30
 *          4   4   8  12  16  20  24  28  32  36  40
 *          5   5  10  15  20  25  30  35  40  45  50
 *          6   6  12  18  24  30  36  42  48  54  60
 *          7   7  14  21  28  35  42  49  56  63  70
 *          8   8  16  24  32  40  48  56  64  72  80
 *          9   9  18  27  36  45  54  63  72  81  90
 */

using System.IO;
using System;

public class Lab3Class
{
    public static void Lab3Main()
    {        
        Console.WriteLine("---- Lab 3");
        Console.WriteLine("Pythagoras Square");
        
        writeSquare();
    }
    
    static void writeSquare() {
        writeFirstLine(10);
        writeRestLines(9, 10);
    }
    
    static void writeFirstLine(int maxNumber) {
        Console.Write("{0, 3}", " ");
        for (int i = 1; i <= maxNumber; i++) {
            Console.Write("{0, 3}", i);
        }
        Console.WriteLine("");
    }
    
    static void writeRestLines(int maxRows, int maxColumns) {
        for (int i = 1; i <= maxRows; i++) {                // each line
            Console.Write("{0, 3}", i);              // left numbers 1..9
            for (int j = 1; j <= maxColumns; j++) {
                Console.Write("{0, 3}", i * j);
            }
            Console.WriteLine("");                          // \n
        }
    }
}
