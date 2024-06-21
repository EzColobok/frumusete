using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace do_not_understand
{
    public class Block5 : Block
    {
        private readonly Pos[][] tiles = new Pos[][]
        {
           new Pos[] { new(0, 0), new(0, 1), new(1, 1), new(1, 2),},
           new Pos[] { new(0, 2), new(1, 1), new(1, 2), new(2, 1),},
           new Pos[] { new(1, 0), new(1, 1), new(2, 1), new(2, 2),},
           new Pos[] { new(0, 1), new(1, 0), new(1, 1), new(2, 0),},

        };

        private readonly int[,] left_right =
       {

           { -3, 4, },
           { -4, 4, },
           { -3, 4, },
           { -3, 5, },


        };
        private readonly int[] mr = { 18, 17, 17, 17 };
        public override int[,] Left_Right => left_right;

        public override Pos[][] Tiles => tiles;
        public override int R => 0;
        public override int G => 255;
        public override int B => 0;

        public override int Id => 5;

        public override int[] maxrow => mr;
    }
}
