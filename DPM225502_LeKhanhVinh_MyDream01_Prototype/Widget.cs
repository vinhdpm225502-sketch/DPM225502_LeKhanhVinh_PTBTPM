using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DPM225502_LeKhanhVinh_MyDream01_Prototype
{
    internal class Widget : WidgetPrototype
    {
        string name;
        int width, height, padding, radius;

        public Widget(string name, int width, int height, int padding, int radius)
        {
            this.name = name;
            this.width = width;
            this.height = height;
            this.padding = padding;
            this.radius = radius;
        }

        public override WidgetPrototype Clone()
        {
            Console.WriteLine(
                "Widget: {0,5},{1,5},{2,5},{3,5},{4,5}",
                name, width, height, padding, radius);
            return this.MemberwiseClone() as WidgetPrototype;
        }
    }
}
