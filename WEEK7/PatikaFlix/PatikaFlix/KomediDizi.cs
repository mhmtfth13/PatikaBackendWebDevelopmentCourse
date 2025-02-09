using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFlix
{
    public  class KomediDizi
    {
        private string? _seriesName;
        private string? _genre;
        private string? _directorName;


        public string SeriesName
        {
            get { return _seriesName; }
            set
            {
                _seriesName = value;
            }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public string DirectorName
        {
            get { return _directorName; }
            set
            {
                _directorName = value;
            }
        }

    }
}
