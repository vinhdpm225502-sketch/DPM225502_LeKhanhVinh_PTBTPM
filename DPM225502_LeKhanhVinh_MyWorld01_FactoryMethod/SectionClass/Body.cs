using DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.WidgetClass;
using Icon = DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.WidgetClass.Icon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.SectionClass
{
    internal class Body : Section
    {
        public override void CreateSection()
        {
            Widgets.Add(new Column());
            Widgets.Add(new Row());
            Widgets.Add(new Icon());
            Widgets.Add(new Row());
            Widgets.Add(new SizeBox());
            Widgets.Add(new Title());
        }
    }
}
