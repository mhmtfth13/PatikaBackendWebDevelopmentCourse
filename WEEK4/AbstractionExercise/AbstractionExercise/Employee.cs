using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    public abstract class Employee
    {

        private string _name;
        private string _surname;
        private string _department;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        public abstract void Gorev(string name, string surname, string department);
        
    }
    public class SoftwareDeveloper : Employee
    {
        public override void Gorev(string name, string surname, string department)
        {
            Name= name;
            Surname= surname;
            Department= department;
            Console.WriteLine($"{name} {surname} : working as a Software Developer");
        }
    }
    public class ProjectLead : Employee
    {
        public override void Gorev(string name, string surname, string department)
        {
            Name= name;
            Surname= surname;
            Department = department;
            Console.WriteLine($"{name} {surname} : working as a Project Leader");
        }
    }
    public class SalesRepresentative : Employee
    {
        public override void Gorev(string name, string surname, string department)
        {
            Name= name;
            Surname = surname;
            Department= department;
            Console.WriteLine($"{Name} {Surname} : working as a Sales Representative");
        }
    }
}
