using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoinExercise
{
    public class Student
    {
        private int _studentId;
        private string _studentName=string.Empty;
        private int _classId;

        public int StudentId
        {
            get => _studentId;
            set => _studentId = value;
        }
        public string StudentName
        {
            get => _studentName;
            set => _studentName = value;
        }
        public int ClassId
        {
            get => _classId;
            set => _classId = value;

        }
    }
}
