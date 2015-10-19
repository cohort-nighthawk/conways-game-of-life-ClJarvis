using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        public bool IsAlive { get; set; }
        public World World { get; set; }

        public Cell()
        {
            var rand = new Random();
            var num = rand.Next(1, 10);

            IsAlive = (num % 2 == 0);

        }

        public int NumberOfNeighbors()
        {
            var rand = new Random();
            var neighbors = rand.Next(1, 4);

            return NumberOfNeighbors();

            if (neighbors == 2 || neighbors == 3)
            {
              IsAlive = true;
                         
            }
            else if (neighbors == 3)
            {
               var rebirth = new Cell();
            }
            else if (neighbors < 2 || neighbors > 3)
            {
                IsAlive = false;
            }
            IsAlive = false;
        }
       
    }
}
