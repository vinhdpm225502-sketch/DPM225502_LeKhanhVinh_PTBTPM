using DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Widgets
{
    internal class DarkTextField : TextFieldWidget
    {
        public override void statusChange(ButtonWidget x)
        {
            Console.WriteLine(GetType().Name +
                          " renders with " + x.GetType().Name);
        }
    }
}
