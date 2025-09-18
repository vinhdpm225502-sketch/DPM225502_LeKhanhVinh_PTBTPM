using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyDream01_Prototype
{
    internal class WidgetManager
    {
        private Dictionary<string, WidgetPrototype> widgets = new Dictionary<string, WidgetPrototype>();

        public WidgetPrototype this[string key]
        {
            get { return widgets[key]; }
            set { widgets.Add(key, value); }
        }
    }
}
