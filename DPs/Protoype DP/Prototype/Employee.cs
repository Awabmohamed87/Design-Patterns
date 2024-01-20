using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype_DP.Prototype
{
    internal class Employee : PersonModified, IDeepCopyable<Employee>
    {
        public int Salary { get; set; }
        public Employee()
        {
            
        }
        public Employee(string[] Names, AddressModified Addres, int Salary): base(Names, Addres)
        {
            this.Salary = Salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
        }

        public void CopyTo(Employee target)
        {
            base.CopyTo(target);
            target.Salary = this.Salary;
        }
    }
}
