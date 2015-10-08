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
        public World  World { get; set; }

        public Cell()
        {
            var rand = new Random();
            var num = rand.Next(1,10);

            IsAlive = (num % 2 == 0);
           
        }
    }
   
}
