using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_AbstractFactory.Factories
{
    abstract internal class ThemeFactory
    {
        public abstract TextFieldWidget CreateTextField();
        public abstract ButtonWidget createButton();
    }
}
