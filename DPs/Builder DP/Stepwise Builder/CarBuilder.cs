using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_DP.Stepwise_Builder
{
    internal class CarBuilder
    {
        private class Implement : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private Car car = new Car();
            public Car Build()
            {
                return car;
            }

            public ISpecifyWheelSize WithType(CarType type)
            {
                car.CarType = type;
                return this;
            }

            public IBuildCar WithWheels(float size)
            {
                if(car.CarType == CarType.saden)
                {
                    if (size < 15 || size > 17)
                        throw new ArgumentException($"Wrong car size for {car.CarType}");
                }
                else
                {
                    if (size < 17 || size > 20)
                        throw new ArgumentException($"Wrong car size for {car.CarType}");
                }
                car.WheelSize = size;
                return this;
            }
        }

        public static ISpecifyCarType Create()
        {
            return new Implement();
        }
    }
}
