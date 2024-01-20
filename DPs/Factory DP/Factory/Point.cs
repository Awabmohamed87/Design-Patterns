using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP.Factory
{
    internal class Point
    {
        public double X, Y;
        private Point(double X, double Y) { this.X = X; this.Y = Y; }


        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }
        //Inner Class
        internal class Factory
        {
            public static Point NewCartesianPoint(double X, double Y) { return new Point(X, Y); }
            public static Point NewPolarPoint(double rho, double theta) { return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta)); }
        }
    }
}
