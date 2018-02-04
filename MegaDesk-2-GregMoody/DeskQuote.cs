using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_2_GregMoody
{
    public class DeskQuote
    {
        public Desk desk { get; set; }
        public int rushDays { get; set; }
        public string custName { get; set; }
        public DateTime quoteDate { get; set; }
        public int totalCost { get; set; }
        
        //Non-Default Constructor
        public DeskQuote(Desk desk, int rushDays, string custName, DateTime quoteDate)
        {
            this.desk = desk;
            this.rushDays = rushDays;
            this.custName = custName;
            this.quoteDate = quoteDate;
            totalCost = (getQuote());
        }

        //Default Constructor
        public DeskQuote()
        {
            desk = new Desk();
            rushDays = 0;
            custName = "NoNameJenkins";
            quoteDate = DateTime.Now;
            totalCost = 0;
        }

        public int getQuote()
        {
            int totalCost = 0;
            int basePrice = 200;
            int area = desk.width * desk.depth;

            int extraAreaCost = 0;
            //If area over 1000, do something about it!
            if (area > 1000)
            {
                int extraInches = area - 1000;
                extraAreaCost = extraInches * 1; //The cost per square inch
                //I know this is redundant, but it's show why it's times 1
            }

            //Find out extra pricing for rush options
            int rushDaysCost = 0;
            if (rushDays == 3)
            {
                if (area < 1000)
                {
                    rushDaysCost = 60;
                } else if (area >= 1000 && area <= 2000)
                {
                    rushDaysCost = 70;
                } else //The area is > 2000
                {
                    rushDaysCost = 80;
                }
            } else if (rushDays == 5)
            {
                if (area < 1000)
                {
                    rushDaysCost = 40;
                }
                else if (area >= 1000 && area <= 2000)
                {
                    rushDaysCost = 50;
                }
                else //The area is > 2000
                {
                    rushDaysCost = 60;
                }
            } else if (rushDays == 7)
            {
                if (area < 1000)
                {
                    rushDaysCost = 30;
                }
                else if (area >= 1000 && area <= 2000)
                {
                    rushDaysCost = 35;
                }
                else //The area is > 2000
                {
                    rushDaysCost = 40;
                }
            } else //standard shipping
            {
                rushDaysCost = 0; //This line really isn't needed
            }

            //Find out how much the surface material costs
            int surfaceMaterialCost;
            switch (desk.surfaceMaterial)
            {
                case Desk.Surface.Oak:
                    surfaceMaterialCost = 200;
                    break;
                case Desk.Surface.Laminate:
                    surfaceMaterialCost = 100;
                    break;
                case Desk.Surface.Pine:
                    surfaceMaterialCost = 50;
                    break;
                case Desk.Surface.Rosewood:
                    surfaceMaterialCost = 300;
                    break;
                case Desk.Surface.Veneer:
                    surfaceMaterialCost = 125;
                    break;
                default:
                    surfaceMaterialCost = 0;
                    break;
            }

            //Number of Drawers
            int numDrawersCost = desk.numDrawers * 50; //$50 per drawer.

            //UPDATE THIS WITH ADDITIONAL COST VARIABLES IF NEEDED
            totalCost = basePrice + surfaceMaterialCost + extraAreaCost + rushDaysCost + numDrawersCost;
            this.totalCost = totalCost;
            return totalCost;
        }
    }
}
