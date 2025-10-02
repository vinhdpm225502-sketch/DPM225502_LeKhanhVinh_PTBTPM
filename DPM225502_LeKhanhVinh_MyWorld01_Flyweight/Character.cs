using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Flyweight
{
    public class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        public void Display(int pointSize) =>
        Console.   WriteLine($"{symbol} (pointsize {pointSize})");
    }

}
