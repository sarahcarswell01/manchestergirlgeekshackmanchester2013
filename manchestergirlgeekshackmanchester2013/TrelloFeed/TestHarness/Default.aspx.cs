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
            //now Call BL code to get trello feed data
            var getTrelloCards = new GetTrelloCards();
            var results = getTrelloCards.GetNumberOfCardsInEachList();

            var listOfCards = getTrelloCards.GetListOfCards("Doing");

        }
    }
}
