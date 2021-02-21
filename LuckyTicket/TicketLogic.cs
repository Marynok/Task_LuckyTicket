using System;
using LuckyTicket.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyTicket
{
    public class TicketLogic: ITicketLogic
    {
        public bool CheckNumber(int[] numb)
        {
            int sum1 = 0, sum2 = 0;
            int l = numb.Length / 2;
            for (int i = 0; i < l; i++)
            {
                sum1 += numb[i];
                sum2 += numb[l + i];
            }
            return (sum1==sum2);
        }
    }

}
