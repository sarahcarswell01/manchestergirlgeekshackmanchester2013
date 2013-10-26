using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace manchestergirlgeekshackmanchester2013.GitHubFeed
{
    internal class CommitResponseParent
    {
        /// <summary>
        /// Contains the sha value returned by the response
        /// </summary>
        /// <remarks>
        /// sha is the unique id
        /// </remarks>
        public string sha { get; set; }

        //"parents": [
        //  {
        //    "sha": "51c427aef6eeadca4a4f7c570119277583ab42ba",
        //    "url": "https://api.github.com/repos/sarahcarswell01/manchestergirlgeekshackmanchester2013/commits/51c427aef6eeadca4a4f7c570119277583ab42ba",
        //    "html_url": "https://github.com/sarahcarswell01/manchestergirlgeekshackmanchester2013/commit/51c427aef6eeadca4a4f7c570119277583ab42ba"
        //  }
        //]
    }
}
