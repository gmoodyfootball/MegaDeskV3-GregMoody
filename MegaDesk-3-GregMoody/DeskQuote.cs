using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_GregMoody
{
    class DeskQuote
    {
        public Desk desk { get; set; }
        public int rushDays { get; set; }
        public string custName { get; set; }
        public DateTime quoteDate { get; set; }
        public float totalCost { get; set; }

        //Non-Default Constructor
        DeskQuote(Desk desk, int rushDays, string custName, DateTime quoteDate)
        {
            this.desk = desk;
            this.rushDays = rushDays;
            this.custName = custName;
            this.quoteDate = quoteDate;
            totalCost = 0;
        }

        //Default Constructor
        DeskQuote()
        {
            desk = new Desk();
            rushDays = 0;
            custName = "NoNameJenkins";
            quoteDate = new DateTime();
            totalCost = 0;
        }
    }
}
