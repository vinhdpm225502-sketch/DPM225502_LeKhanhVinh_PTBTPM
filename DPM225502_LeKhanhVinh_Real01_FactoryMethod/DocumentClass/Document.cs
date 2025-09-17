using DPM225502_LeKhanhVinh_Real01_FactoryMethod.PageClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_Real01_FactoryMethod.DocumentClass
{
    abstract internal class Document
    {

        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages { get { return this._pages; } }

        public abstract void CreatePages();
    }
}
