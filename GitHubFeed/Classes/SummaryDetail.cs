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
        /// Returns the a list of last commits on a per user basis
        /// </summary>
        public List<CommitDetail> LastCommitDetails
        {
            get
            {
                EnsureCommitDetails();
                return InternalLastCommitDetails;
            }
        }
        /// <summary>
        /// Contains details of the number of commits
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
        
        /// <summary>
        /// Contains an internal list of all the last commits
        /// </summary>
        private List<CommitDetail> InternalLastCommitDetails { get; set; }
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
            Dictionary<int, CommitDetail> UserCommits;      // Details all the last commits for all users
            CommitDetail Author;            // Author for commit
            bool IsLastCommit;              // True if working with the details of the last commit

            if (!this.HaveCommitDetails)
            {
                connection = new GitConnection();
                requestdetails = new RestRequest("/repos/sarahcarswell01/manchestergirlgeekshackmanchester2013/commits");
                requestdetails.Method = Method.GET;

                responsedetails = connection.ExecuteRequest(requestdetails);

                commitresponses = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<IList<CommitResponse>>(responsedetails.Content);
                //
                validresponses = new List<CommitResponse>();
                UserCommits = new Dictionary<int, CommitDetail>();
                startdttm = new DateTime(2013, 10, 26, 14, 0, 0);
                enddttm = new DateTime(2013, 10, 27, 14, 0, 0);
                foreach (CommitResponse response in commitresponses)
                {
                    if (response.Commit.Author.Date >= startdttm && 
                        response.Commit.Author.Date <= enddttm && 
                        response.Parents.Count==1)
                    {
                        IsLastCommit = false;
                        if (InternalLastCommit == null)
                        {
                            InternalLastCommit = response.Commit.Author;
                            IsLastCommit = true;
                        }
                        else if (response.Commit.Author.Date > InternalLastCommit.Date)
                        {
                            InternalLastCommit = response.Commit.Author;
                            IsLastCommit = true;
                        }
                        validresponses.Add(response);
                        //
                        // get author detail
                        if (UserCommits.ContainsKey(response.Author.ID))
                        {
                            Author = UserCommits[response.Author.ID];
                            if (Author.Date < response.Commit.Author.Date)
                            {
                                Author.Date = response.Commit.Author.Date;
                            }
                        }
                        else
                        {
                            Author = MergeAuthorDetails(response.Commit.Author,response.Author);
                            UserCommits.Add(response.Author.ID, Author);
                        }
                        //
                        if (IsLastCommit && InternalLastCommit.ID!=response.Author.ID)
                        {
                            InternalLastCommit = MergeAuthorDetails(InternalLastCommit, response.Author);
                        }
                        //
                    }
                }
                //
                this.InternalLastCommitDetails=new List<CommitDetail>();
                foreach (int key in UserCommits.Keys)
                {
                    InternalLastCommitDetails.Add(UserCommits[key]);
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
            this.InternalLastCommitDetails = null;
        }
        /// <summary>
        /// Merges the author details from the top level author node and from the commit.author node
        /// </summary>
        /// <param name="CommitDetail">Contents from the commit.author node</param>
        /// <param name="Author">Contents from the top level author node   </param>
        /// <returns></returns>
        private CommitDetail MergeAuthorDetails(CommitDetail CommitDetail,
                                                CommitDetail Author)
        {
            CommitDetail ret;
            //
            ret = new CommitDetail();
            // Data on commit.author
            ret.Date=CommitDetail.Date;
            ret.Name=CommitDetail.Name;
            // data on author response value
            ret.Avatar_URL = Author.Avatar_URL;
            ret.ID = Author.ID;
            return ret;
        }
    }
}
