using System;
using LuckyTicket.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    class BasicTicketManager
    {
        protected ITicketLogic ticketLogic;
        private string startStr = "Enter a ticket number, please!";
        public virtual string StartStr {
            get { return startStr; } 
        }
        public  BasicTicketManager(ITicketLogic ticketLogic)
        {
            this.ticketLogic = ticketLogic;
        }
       
        public virtual bool CheckTicket(String numb)
        {
            TryParseInt(numb);
            return ticketLogic.CheckNumber(StringToInt(numb));

        }
        public void TryParseInt(String numb)
        {
            Int64.Parse(numb);
        }
        protected int[] StringToInt(String numb)
        {
            int[] numbersBilet = new int[numb.Length];
            for (int i = 0; i <= numb.Length - 1; i++)
            {
                numbersBilet[i] = int.Parse(numb[i].ToString());
            }
            return numbersBilet;
        }
    }
}
