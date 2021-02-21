using System;

namespace LuckyTicket
{
    class Program
    {
        string numbers;
        string[] mess = new string[2] { "YOU WIN!!!", "You lose." };
        BasicTicketManager tManager = new TicketManager(new TicketLogic());
        static void Main(string[] args)
        {
            Program programm = new Program();
            programm.Start();
        }
        public void Start()
        {
            bool b;
            ConsoleManager.ConsoleWrite(tManager.StartStr);
            try
            {
                numbers = ConsoleManager.ConsoleRead(ConsoleColor.Yellow);
                b = tManager.CheckTicket(numbers);
                ConsoleManager.ConsoleWrite(mess[b ? 0 : 1], ConsoleColor.Green);
            }
            catch (Exception ex)
            {
                ConsoleManager.ConsoleWrite($"Error:{ex.Message}", ConsoleColor.Red);
            }
            finally
            {
                this.Start();
            }
        }
    }

}
