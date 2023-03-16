using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneKopyalama
{
    public class ShallowCopy
    {

        // Var olan bir nesnenin, değerin, referansının kopyalanmasıdır. 
        // Shallow kopy neticesind eeldeki değerleri çoğaltmaz
        // sadece birden fazla referans ile işaretlemiş olur

        // classlar üzerinde deep copy yapmak mümkündür.!

        public ShallowCopy Clone()
        {
            return (ShallowCopy)this.MemberwiseClone(); // bir sınıf içerisinde o sınıftan üretilmiş olan
                                           // o anki nesneyi clonlamayı sağlar 
                                           // object döner return this.MemberwiseClone(); bu şekilde ve ben bunu cast etmem gerekir

        }

    }
}
