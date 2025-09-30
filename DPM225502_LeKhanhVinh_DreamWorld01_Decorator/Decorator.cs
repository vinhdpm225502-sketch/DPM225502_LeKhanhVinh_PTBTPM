using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_DreamWorld01_Decorator
{
    public abstract class Decorator<T>(LibraryItem<T> libraryItem) : LibraryItem<T>
    {
        public override void Display() => libraryItem.Display();
    }
}
