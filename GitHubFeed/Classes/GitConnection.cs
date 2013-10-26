using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
using System.Configuration;
namespace manchestergirlgeekshackmanchester2013.GitHubFeed
{
    /// <summary>
    /// Manages the connection to Git Hub
    /// </summary>
    public class GitConnection
    {
        //
        // username to connection with
        private string Username { get; set; }
        //
        // password to connect with
        private string Password { get; set; }
        /// <summary>
        /// Initalise the object
        /// </summary>
        public GitConnection()
        {
            this.Username = ConfigurationManager.AppSettings["username"];
            this.Password = ConfigurationManager.AppSettings["password"];
        }
        ///
        ///<summary> 
        ///Returns the rest client with a reference to the git hub api
        ///</summary>
        ///
        private RestClient GetClient()
        {
            RestClient client;   // client to return
            //
            client = new RestClient();
            client.BaseUrl = "https://api.github.com";
            client.Authenticator = new HttpBasicAuthenticator(Username, Password);
            return client;
        }
        /// <summary>
        /// Executes the request details
        /// </summary>
        /// <param name="requestdetails">Details of request to execute</param>
        /// <returns>The response from git hub</returns>
        public IRestResponse ExecuteRequest(RestRequest requestdetails)
        {
            RestClient client; // Client to execute request on
            //
            client = this.GetClient();
            return client.Execute(requestdetails);
            //
        }
    }
}
