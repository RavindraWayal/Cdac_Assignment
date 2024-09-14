using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TwoDshape
    {
        double pri_width;
        double pri_height;    // Properties for width and height. 
        public double Width
        {
            get { return pri_width; }
            set { pri_width = value; }
        }
        public double Height
        {
            get { return pri_height; }
            set { pri_height = value; }
        }
        public void showDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }

    }
}
