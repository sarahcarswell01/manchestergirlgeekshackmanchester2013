using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace manchestergirlgeekshackmanchester2013.GitHubFeed
{
    /// <summary>
    /// Contains the details of the commit response
    /// </summary>
    /// <remarks>
    /// Internal as do not need to expose all properties to the wpf
    /// </remarks>
    internal class CommitResponse
    {
        /// <summary>
        /// Contains the sha value returned by the response
        /// </summary>
        /// <remarks>
        /// sha is the unique id
        /// </remarks>
        public string sha { get; set; }
        /// <summary>
        /// Models the comit data returned by the json
        /// </summary>
        public CommitResponseDetail Commit { get; set; }
        /// <summary>
        /// List of parent commits
        /// </summary>
        public IList<CommitResponseParent> Parents { get; set; }
        /// <summary>
        /// Author of committ
        /// </summary>
        /// <remarks>
        /// Contains different data to commit.author
        /// </remarks>
        public CommitDetail Author { get; set; }
    }
    ///Notes !!
    //    "sha": "9c75f9828b36ce574e8248ccb8e1bbd3853f416e",
   
    //"url": "https://api.github.com/repos/sarahcarswell01/manchestergirlgeekshackmanchester2013/commits/9c75f9828b36ce574e8248ccb8e1bbd3853f416e",
    //"html_url": "https://github.com/sarahcarswell01/manchestergirlgeekshackmanchester2013/commit/9c75f9828b36ce574e8248ccb8e1bbd3853f416e",
    //"comments_url": "https://api.github.com/repos/sarahcarswell01/manchestergirlgeekshackmanchester2013/commits/9c75f9828b36ce574e8248ccb8e1bbd3853f416e/comments",
    //"author": {
    //  "login": "sarahcarswell01",
    //  "id": 2658195,
    //  "avatar_url": "https://2.gravatar.com/avatar/89a0077d239f31ea6f08cda5ef4e7f17?d=https%3A%2F%2Fidenticons.github.com%2F9dc5adda7af46ab76707de8d8ec920b4.png&r=x",
    //  "gravatar_id": "89a0077d239f31ea6f08cda5ef4e7f17",
    //  "url": "https://api.github.com/users/sarahcarswell01",
    //  "html_url": "https://github.com/sarahcarswell01",
    //  "followers_url": "https://api.github.com/users/sarahcarswell01/followers",
    //  "following_url": "https://api.github.com/users/sarahcarswell01/following{/other_user}",
    //  "gists_url": "https://api.github.com/users/sarahcarswell01/gists{/gist_id}",
    //  "starred_url": "https://api.github.com/users/sarahcarswell01/starred{/owner}{/repo}",
    //  "subscriptions_url": "https://api.github.com/users/sarahcarswell01/subscriptions",
    //  "organizations_url": "https://api.github.com/users/sarahcarswell01/orgs",
    //  "repos_url": "https://api.github.com/users/sarahcarswell01/repos",
    //  "events_url": "https://api.github.com/users/sarahcarswell01/events{/privacy}",
    //  "received_events_url": "https://api.github.com/users/sarahcarswell01/received_events",
    //  "type": "User",
    //  "site_admin": false
    //},
    //"committer": {
    //  "login": "sarahcarswell01",
    //  "id": 2658195,
    //  "avatar_url": "https://2.gravatar.com/avatar/89a0077d239f31ea6f08cda5ef4e7f17?d=https%3A%2F%2Fidenticons.github.com%2F9dc5adda7af46ab76707de8d8ec920b4.png&r=x",
    //  "gravatar_id": "89a0077d239f31ea6f08cda5ef4e7f17",
    //  "url": "https://api.github.com/users/sarahcarswell01",
    //  "html_url": "https://github.com/sarahcarswell01",
    //  "followers_url": "https://api.github.com/users/sarahcarswell01/followers",
    //  "following_url": "https://api.github.com/users/sarahcarswell01/following{/other_user}",
    //  "gists_url": "https://api.github.com/users/sarahcarswell01/gists{/gist_id}",
    //  "starred_url": "https://api.github.com/users/sarahcarswell01/starred{/owner}{/repo}",
    //  "subscriptions_url": "https://api.github.com/users/sarahcarswell01/subscriptions",
    //  "organizations_url": "https://api.github.com/users/sarahcarswell01/orgs",
    //  "repos_url": "https://api.github.com/users/sarahcarswell01/repos",
    //  "events_url": "https://api.github.com/users/sarahcarswell01/events{/privacy}",
    //  "received_events_url": "https://api.github.com/users/sarahcarswell01/received_events",
    //  "type": "User",
    //  "site_admin": false
    //},

    //}
}
