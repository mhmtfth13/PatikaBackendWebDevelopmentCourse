using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    internal class Ogretmen : BaseKisi
    {
        private decimal _salary;

        public decimal Salary {  get { return _salary; } set { _salary = value; } }
        
        public  void  Info(string name, string surname, decimal salary)
        {
            
            base.Info(name, surname);
            _salary = salary;
            Console.WriteLine($"Ogretmenin Maasi: {_salary}");

        }
    }
}
