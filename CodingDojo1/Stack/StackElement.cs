using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1.Stack
{
    class StackElement<T> // T=Placeholder for generic Type
    {
        //Wert
        public T Value { get; set; }

        //VorgängerWert
        public StackElement<T> Predecessor { get; set; }
        

    }
}
