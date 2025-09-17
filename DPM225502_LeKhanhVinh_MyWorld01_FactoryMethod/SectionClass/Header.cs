using DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.WidgetClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.SectionClass
{
    internal class Header : Section
    {
        public override void CreateSection()
        {
            Widgets.Add(new Title());
            Widgets.Add(new TextFormField());
            Widgets.Add(new ButtonWidget());
            Widgets.Add(new Row());
        }
    }
}
