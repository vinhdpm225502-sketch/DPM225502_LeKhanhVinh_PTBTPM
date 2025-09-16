using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Builder.UI
{
    internal class TextFormFieldWidget : WidgetWebBuilder
    {
        public TextFormFieldWidget()
        {
            widgetWeb = new WidgetWeb("TextFormField");
        }

        public override void BuildBorder()
        {
            widgetWeb["border"] = "1px solid white";
        }

        public override void BuildColor()
        {
            widgetWeb["color"] = "black";
        }

        public override void BuildPadding()
        {
            widgetWeb["padding"] = "5px 10px";
        }

        public override void BuildRadius()
        {
            widgetWeb["radius"] = "50px";
        }
    }
}
