using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_Memento
{
    public class Memento
    {
        private string store = null!;
        public Memento Serialize(object o)
        {
            store = JsonSerializer.Serialize(o);
            return this;
        }
        public object Deserialize()
        {
            return JsonSerializer.Deserialize<SalesProspect>(store)!;
        }
    }
}
