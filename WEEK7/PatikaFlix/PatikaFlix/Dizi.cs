using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaFlix
{
    public class Dizi
    {
        private string _seriesName = string.Empty;
        private DateTime _productionDate = DateTime.MinValue;
        private string _genre = string.Empty;
        private DateTime _startingTime = DateTime.MinValue;
        private string _directorName = string.Empty;
        private string _channelName = string.Empty;

        public string SeriesName
        {
            get { return _seriesName; }
            set { _seriesName = value; }
        }
        public DateTime ProductionDate
        {
            get { return _productionDate; }
            set { _productionDate = new DateTime(value.Year, 1, 1); }
        }
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public DateTime StartingTime
        {
            get { return _startingTime; }
            set { _startingTime = new DateTime(value.Year, 1, 1); }
        }
        public string DirectorName
        {
            get { return _directorName; }
            set { _directorName = value; }
        }
        public string ChannelName
        {
            get { return _channelName; }
            set { _channelName = value; }
        }
    }
}
