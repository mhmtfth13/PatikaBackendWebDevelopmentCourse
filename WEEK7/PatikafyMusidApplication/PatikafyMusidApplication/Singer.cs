using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikafyMusidApplication
{
    public class Singer
    {

        private string _name;
        private string _genre;
        private DateTime _releaseDate;
        private ulong _sales;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public DateTime ReleaseDate
        {
            get { return _releaseDate; }
            set { _releaseDate = value; }
        }
        public ulong Sales
        {
            get { return _sales; }
            set { _sales = value; }
        }
    }
}
