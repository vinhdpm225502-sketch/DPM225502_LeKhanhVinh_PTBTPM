using DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Widgets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Factories
{
    internal class DarkTheme : ThemeFactory

    {
        public override ButtonWidget createButton()
        {
            return new DarkButton();
        }

        public override TextFieldWidget CreateTextField()
        {
            return new DarkTextField();
        }
    }
}
