using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Tracking_Factory
{
    internal class Ref<T> where T : class
    {
        public T val;
        public Ref(T value)
        {
            val = value;
        }
    }
}
