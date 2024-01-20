using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_DP.Prototype
{
    internal interface IPrototype<T>
    {
        T DeepCopy();
    }
}
