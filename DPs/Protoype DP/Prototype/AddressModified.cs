using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_DP.Prototype
{
    internal class AddressModified : IDeepCopyable<AddressModified>
    {
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public AddressModified()
        {
            
        }
        public AddressModified(string StreetName, int HouseNumber)
        {
            this.HouseNumber = HouseNumber;
            this.StreetName = StreetName;
        }
        public override string ToString()
        {
            return $"{HouseNumber}, {StreetName}";
        }

        public void CopyTo(AddressModified target)
        {
            target.HouseNumber = this.HouseNumber;
            target.StreetName = this.StreetName;
        }
    }
}
