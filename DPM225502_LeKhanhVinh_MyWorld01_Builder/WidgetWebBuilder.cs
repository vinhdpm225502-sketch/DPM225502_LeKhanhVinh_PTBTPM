using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Builder
{
    abstract internal class WidgetWebBuilder
    {
        protected WidgetWeb widgetWeb;
        public WidgetWeb WidgetWeb { get { return widgetWeb; } }

        public abstract void BuildPadding();
        public abstract void BuildBorder();
        public abstract void BuildRadius();
        public abstract void BuildColor();
    }
}
