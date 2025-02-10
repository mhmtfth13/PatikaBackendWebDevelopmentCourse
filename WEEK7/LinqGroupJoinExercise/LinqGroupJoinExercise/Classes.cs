using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupJoinExercise
{
    public class Classes
    {
        private int _classId;
        private string _className=string.Empty;


        public int ClassId
        {
            get => _classId;
            set => _classId = value;
        }
        public string ClassName
        {
            get => _className;
            set => _className = value;
        }
    }
}
