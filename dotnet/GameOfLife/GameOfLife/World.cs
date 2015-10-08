using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World
    {
        public int WorldHeight { get; set; }
        public int WorldWidth { get; set; }
        public Collection<Cell> Cells { get; set; }

        public World(int width = 10, int height = 10)
        {
            this.WorldWidth = width;
            this.WorldHeight = height;
        }


    }
}