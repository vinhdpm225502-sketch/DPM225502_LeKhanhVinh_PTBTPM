using DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Factories
{
    internal class LightTheme : ThemeFactory
    {
        public override ButtonWidget createButton()
        {
            return new LightButton();
        }

        public override TextFieldWidget CreateTextField()
        {
            return new LightTextField();
        }
    }
}
