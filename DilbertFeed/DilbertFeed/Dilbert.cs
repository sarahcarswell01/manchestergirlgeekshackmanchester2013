using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manchestergirlgeekshackmanchester2013.DilbertFeed
{
    public class Dilbert
    {
        string dilbertUri = "http://dilbert.com/dyn/str_strip/000000000/00000000/0000000/100000/10000/0000/200/{0}/{1}.strip.zoom.gif";

        public Dilbert()
        {
        }

        public Uri GetDilbert()
        {
            var number = RandomNumberGenerator();
            var uri = new Uri(string.Format(dilbertUri, number, number));
            return uri;
        }

        private int RandomNumberGenerator()
        {
            var random = new Random();
            return random.Next(110220, 110223);
        }
    }
}
