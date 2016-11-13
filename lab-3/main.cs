using System.IO;
using System;

public class Program
{
    static void Main()
    {
        int labIndex = 0;
        
        while (true) {
            Console.Write("Select lab number (1..4) or \"exit\" word to terminate: ");
            String userInput = Console.ReadLine();
            
            if (String.Compare(userInput, "exit", true) == 0) {
                break;
            }
        
            if (!Int32.TryParse(userInput, out labIndex)
                || labIndex <= 0
                || labIndex >= 5) {
                Console.WriteLine("Wrong lab number!");
            } else {
                RunLab(labIndex);
            }
        }
        
        Console.WriteLine("Thanks for using my program! Have a nice day! ;)");
    }
    
    static void RunLab(int labIndex) {
        switch (labIndex) {
            case 1:
                Lab1Class.Lab1Main();
                break;
            case 2:
                Lab2Class.Lab2Main();
                break;
            case 3:
                Lab3Class.Lab3Main();
                break;
            case 4:
                Lab4Class.Lab4Main();
                break;
            default:
                Console.WriteLine("Wrong lab number!");
                break;
        }
    }

    public static bool TeacherWantsIt() {
        return String.Compare(Console.ReadLine(), "exit", true) != 0;
    }
}
