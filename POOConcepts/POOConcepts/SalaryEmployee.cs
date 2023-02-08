using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOConcepts
{
    public class SalaryEmployee : Employee
    {
        //atriuto
        public decimal Salary { get; set; }
        //Metodos
        public override decimal GetValueToPay()
        {
            return Salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" + 
                $"\n\t Value to Pay: {$"{GetValueToPay():C2}",18}";
        }
    }
}
