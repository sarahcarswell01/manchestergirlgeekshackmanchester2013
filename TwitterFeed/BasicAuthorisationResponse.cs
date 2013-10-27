using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace manchestergirlgeekshackmanchester2013.TwitterFeed
{
    /// <summary>
    /// Models twitter json response to authorisation token request
    /// </summary>
    internal class BasicAuthorisationResponse
    {
        /// <summary>
        /// Access token returned
        /// </summary>
        public string access_token { get; set; }
    }
}
