using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace manchestergirlgeekshackmanchester2013.TwitterFeed
{
    /// <summary>
    /// Models the twitter user details
    /// </summary>
    public class TwitterUser
    {
        /// <summary>
        ///  id of user
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// Profile image
        /// </summary>
        public string profile_image_url_https { get; set; }
        /// <summary>
        /// screen name
        /// </summary>
        public string screen_name { get; set; }
        /// <summary>
        /// Initalises object
        /// </summary>
        public TwitterUser()
        {
        }
    }
}
