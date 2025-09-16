using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Builder.UI
{
    internal class ButtonWidget : WidgetWebBuilder
    {
        public ButtonWidget()
        {
            widgetWeb = new WidgetWeb("Button");
        }
        public override void BuildBorder()
        {
            widgetWeb["border"] = "1px red solid";
        }

        public override void BuildColor()
        {
            widgetWeb["color"] = "red";
        }

        public override void BuildPadding()
        {
            widgetWeb["padding"] = "10px 30px";
        }

        public override void BuildRadius()
        {
            widgetWeb["radius"] = "5px";
        }
    }
}
