using System;
using LuckyTicket.Interfaces;


namespace LuckyTicket
{
    class TicketManager : BasicTicketManager
    {
        const int COUNT_MAX = 8;
        const int COUNT_MIN = 4;
        private string startStr = $"Enter a ticket number, which length between {COUNT_MIN} and {COUNT_MAX}, please!";
        public override string StartStr
        {
            get { return startStr; }
        }
        public TicketManager(ITicketLogic ticketLogic) : base(ticketLogic)
        { }
       
        public override bool CheckTicket(String numb)
        {
            TryParseInt(numb);
            CheckCount(numb);
            return ticketLogic.CheckNumber(CheckTicketLenght(numb));
        }
        public int[] CheckTicketLenght(String numb)
        {
            if (numb.Length % 2 != 0)
                numb = "0" + numb;

            return StringToInt(numb);
        }
        public void CheckCount(String numb)
        {
            int count = numb.Length;
            if ((count > COUNT_MAX) || (count < COUNT_MIN))
                throw new Exception("Incorrect length");
        }
    }

}
