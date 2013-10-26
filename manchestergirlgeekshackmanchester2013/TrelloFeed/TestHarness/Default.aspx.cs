using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using manchestergirlgeekshackmanchester2013.TrelloFeed;
using TrelloNet;

namespace TestHarness
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            //redirect user to a url to get a token
            //string trelloApplicationKey = Properties.Resource1.TrelloApplicationKey;
            //ITrello trello = new Trello(trelloApplicationKey);
            //var url = trello.GetAuthorizationUrl("TrelloFeed", Scope.ReadWrite);
            
            //Uri targetUri = url;
            //System.Net.HttpWebRequest request = (System.Net.HttpWebRequest) System.Net.HttpWebRequest.Create(targetUri);
            //var response = request.GetResponse() as HttpWebResponse;
            //Response.Redirect(url.ToString(), true);

            //now pass oken to BL to pull data from trello.
            var getTrelloCards = new GetTrelloCards();
            var results = getTrelloCards.GetNumberOfCardsInEachList();


            var listOfCards = getTrelloCards.GetListOfCards("To Do");

        }
    }
}
