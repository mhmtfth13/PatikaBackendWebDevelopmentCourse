using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
    internal class Ogrenci : BaseKisi
    {
        private string _studentNumber;
        
        public string StudentNumber
        {
            get { return _studentNumber; }
            set { _studentNumber = value; }
        }
        public  void Info(string name, string surname, string studentNumber)
        {
            base.Info(name, surname);
            _studentNumber = studentNumber;
            Console.WriteLine($"Ogrencinin Numarasi: {_studentNumber}");
        }
        
        }
    }

