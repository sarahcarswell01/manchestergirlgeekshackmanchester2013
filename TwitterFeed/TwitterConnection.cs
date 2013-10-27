using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Web;
using RestSharp;
namespace manchestergirlgeekshackmanchester2013.TwitterFeed
{
    /// <summary>
    /// Handles the calls to twitter
    /// </summary>
    public class TwitterConnection
    {
        /// <summary>
        /// Twitter consumer key
        /// </summary>
        private string ConsumerKey { get; set; }
        /// <summary>
        /// Tiwtter consumer secret
        /// </summary>
        private string ConsumerSecret { get; set; }
        /// <summary>
        /// 64 bit encoding for consumer string for connecting to twitter
        /// </summary>
        private string ConsumerString { get; set; }
        /// <summary>
        /// Access credentials returned from twitter
        /// </summary>
        private string AccessCredentials { get; set; }
        /// <summary>
        /// Initalise connection
        /// </summary>
        public TwitterConnection()
        {
            string Consumer;    // Consumer key
            byte[] bytes;       // Helps conversion to base 64
            RestRequest requestdetails; // Request details
            IRestResponse responsedetails;  // Response details
            BasicAuthorisationResponse token;   // Response token

            this.ConsumerKey = "7ETasdIbxqjsEeGYHqZE0A";
            this.ConsumerSecret = "qb0EjSJuQlnuWhm1Jjpj8NTL0WQwOMRMf3efJs";
            Consumer = HttpUtility.UrlEncode(ConsumerKey) + ":" + HttpUtility.UrlEncode(ConsumerSecret);
            bytes = ASCIIEncoding.ASCII.GetBytes(Consumer);
            this.ConsumerString = System.Convert.ToBase64String(bytes);

            RestClient client;   // client to return
            ///oauth2/token
            client = GetClient();

            requestdetails = GetRequestDetails("/oauth2/token", true);
            requestdetails.Method = Method.POST;
            requestdetails.AddParameter("grant_type", "client_credentials");
            responsedetails = client.Execute(requestdetails);
            token = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<BasicAuthorisationResponse>(responsedetails.Content);
            this.AccessCredentials = token.access_token;
        }
        /// <summary>
        /// Calculates the latest tweet
        /// </summary>
        /// <returns>Latest tweets  limited to 100</returns>
        public List<TwitterStatusResponse> Tweets()
        {
            RestClient client;              // client to mame request on
            RestRequest requestdetails;     // request details
            IRestResponse responsedetails;  // Response details
            TwitterStatuses tweets;         // Tweets
            //
            client = GetClient();
            requestdetails = GetRequestDetails("1.1/search/tweets.json", false);
            requestdetails.Method = Method.GET;
            requestdetails.AddParameter("q", HttpUtility.UrlEncode("#hackmanchester") + " " + HttpUtility.UrlEncode("@hackmanchester"));
            requestdetails.AddParameter("count", "100");
            responsedetails = client.Execute(requestdetails);
            tweets = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<TwitterStatuses>(responsedetails.Content);
            //
            return tweets.statuses;
        }
        /// <summary>
        /// Returns a list of favourite feets
        /// </summary>
        /// <returns></returns>
        public List<TwitterStatusResponse> Favourites()
        {
            List<TwitterStatusResponse> tweets;         // Current tweets
            List<TwitterStatusResponse> favourites;     // Current favourites
            List<TwitterStatusResponse> topstatus;      // top status to return
            StringCollection texts;                     // cache of texts used
            List<int> numbersused;                      // cache of idnexes used
            Random randomnumbers;                       // random number generator
            int index;                                  // index in tweet to read

            favourites = new List<TwitterStatusResponse>();
            topstatus = new List<TwitterStatusResponse>();
            tweets = this.Tweets();
            texts = new StringCollection();
            foreach (TwitterStatusResponse response in tweets)
            {
                if (response.retweet_count>0)
                {
                    favourites.Add(response);
                }
            }
            if (favourites.Count <= 5)
            {
                return favourites;
            }
            else
            {
                randomnumbers = new Random();
                numbersused=new List<int>();
                while (topstatus.Count < 5 && numbersused.Count!=favourites.Count)
                {
                    index = randomnumbers.Next(0, favourites.Count);
                    if (!numbersused.Contains(index))
                    {
                        if (!texts.Contains(favourites[index].text))
                        {
                            topstatus.Add(favourites[index]);
                            texts.Add(favourites[index].text);
                        }
                        numbersused.Add(index);
                    }
                }
                //
                return topstatus;
            }
        }
        /// <summary>
        /// Returns a prepared rest request object
        /// </summary>
        /// <param name="url">url to open connection for</param>
        /// <param name="basicauth">basic authentication flag (only used for accesing token details)</param>
        /// <returns>
        /// Prepare rest request object</returns>
        private RestRequest GetRequestDetails(string url,
                                              bool basicauth)
        {
            RestRequest requestdetails;     // Details to return

            requestdetails = new RestRequest(url);
            requestdetails.Method = Method.GET;
            requestdetails.AddHeader("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8");
            if (basicauth)
            {
                requestdetails.AddHeader("Authorization", "Basic " + this.ConsumerString);
            }
            else
            {
                requestdetails.AddHeader("Authorization", "Bearer " + this.AccessCredentials);
            }
            //
            return requestdetails;
            //
        }
        /// <summary>
        /// Returns a reference to the rest client
        /// </summary>
        /// <returns>Returns a reference to the rest client</returns>
        private RestClient GetClient()
        {
            RestClient client;      //Client to return
            client = new RestClient();
            client.BaseUrl = "https://api.twitter.com";
            return client;
        }
    }
}
