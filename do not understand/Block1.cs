using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_not_understand
{
    public class Block1 : Block
    {
        private readonly Pos[][] tiles = new Pos[][]
        {

           new Pos[] { new(1, 0), new(1, 1), new(1, 2), new(1, 3),},
           new Pos[] { new(0, 1), new(1, 1), new(2, 1), new(3, 1),},
           new Pos[] { new(2, 0), new(2, 1), new(2, 2), new(2, 3),},
           new Pos[] { new(0, 2), new(1, 2), new(2, 2), new(3, 2),},


        };

       private readonly int[,] left_right =
        {

           { -3, 3, },
           { -4, 5, },
           { -3, 3, },
           { -5, 5, },


        };

        private readonly int[] mr = { 19, 16, 18, 16 };

        public override int[,] Left_Right => left_right;
        public override Pos[][] Tiles => tiles;
        public override int R => 0;
        public override int G => 0;
        public override int B => 255;

        public override int Id => 4;

        public override int[] maxrow => mr;


    }
}

