using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace manchestergirlgeekshackmanchester2013.GitHubFeed
{
    /// <summary>
    /// Models the commit details returned from Git hub
    /// </summary>
    /// <remarks>
    /// Internal as do not need to expose all properties to the wpf
    /// </remarks>
    internal class CommitResponseDetail
    {
        /// <summary>
        /// Contains details of the author
        /// </summary>
        /// <remarks>
        /// Contains different detail to top level author record
        /// </remarks>
        public CommitDetail Author
        {
            get;
            set;
        }
        /// <summary>
        /// Contains details of the committer
        /// </summary>
        public CommitDetail Committer
        {
            get;
            set;
        }
        /// <summary>
        /// Contains the sha value returned by the response
        /// </summary>
        /// <remarks>
        /// sha is the unique id
        /// </remarks>
        public string sha { get; set; }
        ///notes!
        //"commit": {
        //  "author": {
        //    "name": "Sarah Carswell",
        //    "email": "sarahcarswell01@hotmail.co.uk",
        //    "date": "2013-10-26T14:37:39Z"
        //  },
        //  "committer": {
        //    "name": "Sarah Carswell",
        //    "email": "sarahcarswell01@hotmail.co.uk",
        //    "date": "2013-10-26T14:37:39Z"
        //  },
        //  "message": "sarah test",
        //  "tree": {
        //    "sha": "aac76b8e276ba653cc231f1e8f89682681a7cbb7",
        //    "url": "https://api.github.com/repos/sarahcarswell01/manchestergirlgeekshackmanchester2013/git/trees/aac76b8e276ba653cc231f1e8f89682681a7cbb7"
        //  },
        //  "url": "https://api.github.com/repos/sarahcarswell01/manchestergirlgeekshackmanchester2013/git/commits/9c75f9828b36ce574e8248ccb8e1bbd3853f416e",
        //  "comment_count": 0
        //},
    }
}
