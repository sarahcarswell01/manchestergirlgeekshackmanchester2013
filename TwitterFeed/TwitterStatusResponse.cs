using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace manchestergirlgeekshackmanchester2013.TwitterFeed
{
    /// <summary>
    /// Models a collection of twitter statuses
    /// </summary>
    internal class TwitterStatuses : IEnumerable<TwitterStatusResponse>
    {
        // Statuses on response
        //
        public List<TwitterStatusResponse> statuses{get;set;}
        /// <summary>
        /// Initalises object
        /// </summary>
        public TwitterStatuses()
        {
            statuses = new List<TwitterStatusResponse>();

        }
        /// <summary>
        /// Enumerator interface
        /// </summary>
        /// <returns>Enumerator interface</returns>
        public IEnumerator<TwitterStatusResponse> GetEnumerator()
        {
            return statuses.GetEnumerator();
        }
        /// <summary>
        /// Enumerator interface
        /// </summary>
        /// <returns>Enumerator interface</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return statuses.GetEnumerator();
        }
    }
    /// <summary>
    /// Models the twitter response
    /// </summary>
    public class TwitterStatusResponse
    {
        /// <summary>
        ///  date response created
        /// </summary>
        public string created_at {get;set;}
        /// <summary>
        /// id of response
        /// </summary>
        public string id {get;set;}
        /// <summary>
        /// Text in response
        /// </summary>
        public string text {get;set;}
        /// <summary>
        /// initalises object
        /// </summary>
        public TwitterStatusResponse()
        {
        }
        /// <summary>
        /// Details the reply to post
        /// </summary>
        public string in_reply_to_status_id { get; set; }
        /// <summary>
        /// Details the user 
        /// </summary>
        public TwitterUser user { get; set; }
        //[{"metadata":{"result_type":"recent","iso_language_code":"en"},
          //"created_at":"Sun Oct 27 04:17:28 +0000 2013","id":394316895949570048,"id_str":"394316895949570048",
          //"text":"RT @_welf: 14 hours into coding is a good time to be looking up how an if statement works in python, right? @HackManchester #HackManchester"
          //,"source":"\u003ca href=\"http:\/\/itunes.apple.com\/us\/app\/twitter\/id409789998?mt=12\" 
          //rel=\"nofollow\"\u003eTwitter for Mac\u003c\/a\u003e","truncated":false,
        //"in_reply_to_status_id":null,"in_reply_to_status_id_str":null,"in_reply_to_user_id":null,
        //"in_reply_to_user_id_str":null,"in_reply_to_screen_name":null,"user":{"id":14993332,"id_str":"14993332","name":"Johnno Nolan","screen_name":"JohnnoNolan","location":"Manchester","description":"Non-bio actually. Bio brings me out in a rash.","url":"http:\/\/t.co\/30boOqMePl","entities":{"url":{"urls":[{"url":"http:\/\/t.co\/30boOqMePl","expanded_url":"http:\/\/johnnosnose.blogspot.com\/","display_url":"johnnosnose.blogspot.com","indices":[0,22]}]
    }
}
