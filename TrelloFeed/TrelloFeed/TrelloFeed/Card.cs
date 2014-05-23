using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace manchestergirlgeekshackmanchester2013.TrelloFeed
{
    /// <summary>
    /// POCO Class to represent a Card object
    /// </summary>
    public class Card
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> Members { get; set; }

        public List<string> Labels { get; set; }

    }
}
