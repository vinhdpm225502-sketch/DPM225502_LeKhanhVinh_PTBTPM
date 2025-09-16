using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Builder
{
    internal class UIManagement
    {
        public void Contruct(WidgetWebBuilder widgetWebBuilder)
        {
            widgetWebBuilder.BuildPadding();
            widgetWebBuilder.BuildBorder();
            widgetWebBuilder.BuildRadius();
            widgetWebBuilder.BuildColor();
        }
    }
}
