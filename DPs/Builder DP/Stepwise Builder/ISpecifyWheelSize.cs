using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Stepwise_Builder
{
    internal interface ISpecifyWheelSize
    {
        public IBuildCar WithWheels(float size);
    }
}
