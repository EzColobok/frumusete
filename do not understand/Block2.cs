using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace do_not_understand
{
    public class Block2 : Block
    {
        private readonly Pos[][] tiles = new Pos[][] {
            new Pos[] {new (0,1), new(0, 2), new (1,1), new (1,2),},
            
        };

        private readonly int[,] left_right =
       {

           { -4, 4, },
           { -4, 4, },
           { -4, 4, },
           { -4, 4, },


        };
        private readonly int[] mr = { 18, 18, 18, 18 };
        public override int[,] Left_Right => left_right;
        public override Pos[][] Tiles => tiles;
        public override int R => 255;
        public override int G => 255;
        public override int B => 0;
        
        public override int Id => 2;

        public override int[] maxrow => mr;
    }
}
