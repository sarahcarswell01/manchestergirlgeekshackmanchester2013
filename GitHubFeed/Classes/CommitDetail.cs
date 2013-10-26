using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace manchestergirlgeekshackmanchester2013.GitHubFeed
{
    /// <summary>
    /// models the details of a commit
    /// </summary>
    public class CommitDetail
    {
        /// <summary>
        /// Contains the date of the commit
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Contains the name of the person doing the commit.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Link to avatar url
        /// </summary>
        public string Avatar_URL { get; set; }
        /// <summary>
        /// Git hub id for user
        /// </summary>
        public int ID { get; set; }
    }
}
