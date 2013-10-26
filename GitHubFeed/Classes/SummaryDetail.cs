using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;
namespace manchestergirlgeekshackmanchester2013.GitHubFeed
{
    /// <summary>
    /// Summarise the details on GitHub
    /// </summary>
    public class SummaryDetail
    {
        /// <summary>
        /// Returns the number of commits in the hack date range
        /// </summary>
        public int CommitCount
        {
            get
            {
                EnsureCommitDetails();
                return InternalCommitCount;
            }
        }
        //public int LineCount { get;
        // tbd
        //}
        /// <summary>
        /// Details the last commit
        /// </summary>
        public CommitDetail LastCommit
        {
            get
            {
                EnsureCommitDetails();
                return InternalLastCommit;
            }
        }
        /// <summary>
        /// Internal flag for querying the git hub.  Ensures data is cached
        /// </summary>
        private bool HaveCommitDetails { get; set; }
        private bool HaveLineCount { get; set; }
        private bool HaveLastCommit { get; set; }
        /// <summary>
        /// Contains a count of commits
        /// </summary>
        private int InternalCommitCount { get; set; }
        /// <summary>
        /// Contains details of the last commit
        /// </summary>
        private CommitDetail InternalLastCommit { get; set; }
        /// <summary>
        /// Reads the commit data
        /// </summary>
        private void EnsureCommitDetails()
        {
            GitConnection connection;       // Connection to git hub
            RestRequest requestdetails;     // Request to send
            IRestResponse responsedetails;  // Response from request
            IList<CommitResponse> commitresponses;  // Details of response
            List<CommitResponse> validresponses;    // Responses in date range
            DateTime startdttm;             // Start date
            DateTime enddttm;               // End date

            if (!this.HaveCommitDetails)
            {
                connection = new GitConnection();
                requestdetails = new RestRequest("/repos/sarahcarswell01/manchestergirlgeekshackmanchester2013/commits");
                requestdetails.Method = Method.GET;

                responsedetails = connection.ExecuteRequest(requestdetails);

                commitresponses = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<IList<CommitResponse>>(responsedetails.Content);
                //
                validresponses = new List<CommitResponse>();
                startdttm = new DateTime(2013, 10, 26, 14, 0, 0);
                enddttm = new DateTime(2013, 10, 27, 14, 0, 0);
                foreach (CommitResponse response in commitresponses)
                {
                    if (response.Commit.Author.Date >= startdttm && response.Commit.Author.Date <= enddttm)
                    {
                        if (InternalLastCommit == null)
                        {
                            InternalLastCommit = response.Commit.Author;
                        }
                        else if (response.Commit.Author.Date > InternalLastCommit.Date)
                        {
                            InternalLastCommit = response.Commit.Author;
                        }
                        validresponses.Add(response);
                    }
                }
                InternalCommitCount = validresponses.Count();
                //
                this.HaveCommitDetails = true;
            }
        }
        /// <summary>
        /// Clears the cached data
        /// </summary>
        public void Clear()
        {
            this.HaveCommitDetails = false;
            this.InternalCommitCount = 0;
            this.InternalLastCommit = null;
        }
    }
}
