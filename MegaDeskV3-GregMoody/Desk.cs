using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDeskV3_GregMoody
{
    public struct Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public Surface SurfaceMaterial { get; set; }

        public enum Surface
        {
            Pine, //0
            Laminate, //1
            Oak, //2
            Veneer, //3
            Rosewood //4
        }

        //Default constructor - no longer needed
        /*
        public Desk()
        {
            Width = 0;
            Depth = 0;
            NumDrawers = 0;
            SurfaceMaterial = Desk.Surface.Pine;
        }

        //Parameter'd input
        public Desk(int width, int depth, int numDrawers, Surface surfaceMaterial)
        {
            this.Width = width;
            this.Depth = depth;
            this.NumDrawers = numDrawers;
            this.SurfaceMaterial = surfaceMaterial;
        }
        */
    }
}
