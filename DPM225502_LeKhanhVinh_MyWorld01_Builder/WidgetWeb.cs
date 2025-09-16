using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Builder
{
    internal class WidgetWeb
    {
        private string _widgetType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public WidgetWeb(string widgetType) {
            this._widgetType = widgetType; 
        }

        public string this[string key] {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Widget Type: {0}", _widgetType);
            Console.WriteLine(" Padding : {0}", _parts["padding"]);
            Console.WriteLine(" Border : {0}", _parts["border"]);
            Console.WriteLine(" Radius: {0}", _parts["radius"]);
            Console.WriteLine(" Color : {0}", _parts["color"]);
        }
    }
}
