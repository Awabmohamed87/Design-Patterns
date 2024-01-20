using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_DP.Prototype
{
    internal static class ExtensionMethods
    {
        public static T DeepCopy<T>(this IDeepCopyable<T> item) where T: new()
        {
            return item.DeepCopy();        
        }
    }
}
