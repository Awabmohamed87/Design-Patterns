using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Stepwise_Builder
{
    public enum CarType
    {
        saden,
        Croosover
    }
    internal class Car
    {
        public CarType CarType;
        public float WheelSize;
        public override string ToString()
        {
            return $"{nameof(CarType)} : {CarType}, {nameof(WheelSize)} : {WheelSize}";
        }
    }
}
