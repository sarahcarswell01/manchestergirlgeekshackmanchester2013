using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace manchestergirlgeekshackmanchester2013.GitHubFeed
{
    internal class CommitResponseTree : IEnumerable<CommitResponseBranch>
    {
        public List<CommitResponseBranch> tree;
 
        public IEnumerator<CommitResponseBranch> GetEnumerator()
        {
            return tree.GetEnumerator();
        }

       IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
    internal class CommitResponseBranch
    {
        public string sha { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public string path { get; set; }
    }
}
