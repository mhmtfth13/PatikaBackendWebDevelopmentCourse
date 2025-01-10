using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTOR_Exercise
{
    internal class Bebek
    {

        public Bebek()
        {
            Console.WriteLine("Ingaaaa");
            _birthDate = DateTime.Now.ToString();
        }

        public Bebek(string name,string lastname)
        {
            _name = name;
            _lastname = lastname;
            Console.WriteLine("Ingaaaa");
            _birthDate = DateTime.Now.ToString();
        }
        public string _birthDate;
        public string _name;
        public string _lastname;


        

    }
}
