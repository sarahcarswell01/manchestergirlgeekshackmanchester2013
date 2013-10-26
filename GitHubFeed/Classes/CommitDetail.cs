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
    }
}
