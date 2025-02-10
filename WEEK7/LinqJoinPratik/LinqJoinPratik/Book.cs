using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoinPratik
{
    public class Book
    {
        private int _bookId;
        private string _tittle =string.Empty;
        private int _authorId;


        public int BookId
        {
            get => _bookId;
            set => _bookId = value;
        }
        public string Tittle
        {
            get => _tittle;
            set => _tittle = value;
        }
        public int AuthorId
        {
            get => _authorId;
            set => _authorId = value;
        }
    }
}
