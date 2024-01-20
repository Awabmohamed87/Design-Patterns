using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_DP.Prototype
{
    internal class PersonModified : IDeepCopyable<PersonModified>
    {
        public string[] Names { get; set; }
        public AddressModified Address { get; set; }
        public PersonModified()
        {
            
        }
        public PersonModified(string[] Names, AddressModified Address)
        {
            this.Names = Names;
            this.Address = Address;
        }
        public override string ToString()
        {
            return $"Name: {string.Join(" ", Names)}, Address: {Address.ToString()}";
        }

       

        public void CopyTo(PersonModified target)
        {
            target.Address = Address.DeepCopy();
            target.Names = (string[])Names.Clone();
        }
    }
}
