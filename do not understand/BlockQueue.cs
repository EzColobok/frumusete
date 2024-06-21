using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace do_not_understand
{
    public class BlockQueue
    {
        public int Id { get; private set; }


        private int randId()
        {
            Random random = new Random();
            int id = random.Next(1, 8);
            return id;
        }

        public BlockQueue()
        {
            Id = 7;
        
        }

        public void GenerateNewId()
        {
            Id = randId();
        }
    }
}
