using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    public class ConsoleManager
    {
        public static void ConsoleWrite(String taskStr)
        {
            Console.WriteLine(taskStr + "\n");
        }
        public static string  ConsoleRead()
        {
            return Console.ReadLine();
        }
        public static void ConsoleWrite(String taskStr, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            ConsoleWrite(taskStr);
            Console.ResetColor();
        }
        public static string ConsoleRead(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            String str = ConsoleRead();
            Console.ResetColor();
            return str;
        }
    }

}
