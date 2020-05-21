using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoofstuk_8
{
    public class CD
    {
        private string _titel;
        private string _performer;
        private int _totalSongs;

        public CD(string titel, string performer, int totalSongs)
        {
            _titel = titel;
            _performer = performer;
            _totalSongs = totalSongs;
        }

        public string GetTitel()
        {
            return _titel;
        }

        public string GetPerformer()
        {
            return _performer;
        }

        public int GetTotalSongs()
        {
            return _totalSongs;
        }

        public string GetCdInfo()
        {
            var report = new StringBuilder();

            report.AppendLine($"{_titel} is performd by {_performer} and has {_totalSongs} songs on the cd.");
            return report.ToString();
        }
    }
}
