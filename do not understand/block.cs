using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace do_not_understand
{
    public abstract class Block
    {
        private int rotate;
        // Definim metoda abstractă pentru a fi implementată în clasele derivate
        public abstract Pos[][] Tiles { get; }

        public abstract int[,] Left_Right { get; }
        
        public abstract int Id { get; }

        public abstract int R { get; }
        public abstract int G { get; }
        public abstract int B { get; }

        public abstract int[] maxrow { get; }
        public Block()
        { 
            
        }

        public int RotationState(object sender, KeyEventArgs z)
        {
          
            if (z.Key == Key.Z)
            {
                rotate++;

            }


            return rotate;
        }
    }
}
