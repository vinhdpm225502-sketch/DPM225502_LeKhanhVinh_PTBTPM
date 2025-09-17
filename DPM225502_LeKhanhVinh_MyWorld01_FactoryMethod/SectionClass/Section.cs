using DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.WidgetClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_MyWorld01_FactoryMethod.SectionClass
{
    abstract internal class Section
    {

        private List<Widget> _widgets = new List<Widget>();

        protected Section() { this.CreateSection(); }

        public List<Widget> Widgets { get { return this._widgets; } }

        public abstract void CreateSection();
    }
}
