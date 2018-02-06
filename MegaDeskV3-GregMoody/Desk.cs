using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskV3_GregMoody
{
    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public Surface surfaceMaterial { get; set; }

        public enum Surface
        {
            Pine, //0
            Laminate, //1
            Oak, //2
            Veneer, //3
            Rosewood //4
        }

        //Default constructor
        public Desk()
        {
            width = 0;
            depth = 0;
            numDrawers = 0;
            surfaceMaterial = Desk.Surface.Pine;
        }

        //Parameter'd input
        public Desk(int width, int depth, int numDrawers, Surface surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.surfaceMaterial = surfaceMaterial;
        }
    }
}
