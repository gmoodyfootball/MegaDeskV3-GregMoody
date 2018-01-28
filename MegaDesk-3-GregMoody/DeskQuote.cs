using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_GregMoody
{
    public class DeskQuote
    {
        public Desk desk { get; set; }
        public int rushDays { get; set; }
        public string custName { get; set; }
        public DateTime quoteDate { get; set; }
        public float totalCost { get; set; }
        
        //Non-Default Constructor
        public DeskQuote(Desk desk, int rushDays, string custName, DateTime quoteDate)
        {
            this.desk = desk;
            this.rushDays = rushDays;
            this.custName = custName;
            this.quoteDate = quoteDate;
            totalCost = 0;
        }

        //Default Constructor
        public DeskQuote()
        {
            desk = new Desk();
            rushDays = 0;
            custName = "NoNameJenkins";
            quoteDate = new DateTime();
            totalCost = 0;
        }

        public int getQuote()
        {
            int totalCost = 0;
            int basePrice = 200;
            int area = desk.width * desk.depth;

            int extraAreaCost = 0;
            //If area over 1000, do something about it!

            int rushDaysCost = 0;
            //find out how much their rushDays option will cost them

            int surfaceMaterialCost;
            //Find out how much the surface material costs
            switch (desk.surfaceMaterial)
            {
                case "Oak" :
                    surfaceMaterialCost = 200;
                    break;
                case "Laminate":
                    surfaceMaterialCost = 100;
                    break;
                case "Pine":
                    surfaceMaterialCost = 50;
                    break;
                case "Rosewood":
                    surfaceMaterialCost = 300;
                    break;
                case "Veneer":
                    surfaceMaterialCost = 125;
                    break;
                default:
                    surfaceMaterialCost = 0;
                    break;
            }


            //UPDATE THIS WITH ADDITIONAL COST VARIABLES
            totalCost = basePrice + surfaceMaterialCost + extraAreaCost + rushDaysCost;

            return totalCost;
        }
    }
}
