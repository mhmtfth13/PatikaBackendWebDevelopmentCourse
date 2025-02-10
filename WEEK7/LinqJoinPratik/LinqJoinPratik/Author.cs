using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoinPratik
{
    public class Author
    {
        private int _authorId;
        private string _name =string.Empty;

        public int AuthorId
        {
         get => _authorId;
         set => _authorId = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }

    }
}
