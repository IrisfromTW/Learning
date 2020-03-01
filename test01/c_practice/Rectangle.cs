using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_practice
{
    class Rectangle
    {
        public int width { get; set; }
        public int height { get; set; }
        protected static int num { get; set; }
        public Rectangle()
        {
            num++;
        }

        public virtual int getArea()
        {
            num++;
            return width * height;
        }

        public static void showNum()
        {
            Console.WriteLine("已產生{0}個矩形", num);
        }
    }

    class Triangle : Rectangle
    {
        public override int getArea()
        {
            return (width * height) / 2;
        }
        public void showData()
        {
            Console.WriteLine("三角形寬=" + width+", 長="+height+", 面積="+getArea());
        }
    }
}
