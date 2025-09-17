using DPM225502_LeKhanhVinh_Pattern01_FactoryMethod.ProductClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225502_LeKhanhVinh_Pattern01_FactoryMethod.CreatorClass
{
    abstract internal class Creator
    {
        public abstract Product FactoryMethod();
    }
}
