using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    public  abstract class BaseKisi
    {
        private string _name;
        private string _surname;
        public string Name { get { return _name; } set { _name = value; } }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public virtual void Info(string name,string surname)
        {
            _name = name;
            _surname = surname;
            
            Console.WriteLine($"Kisinin Adi: {name}\nKisinin Soyadi:{surname}");
        }
    } 
    
}
