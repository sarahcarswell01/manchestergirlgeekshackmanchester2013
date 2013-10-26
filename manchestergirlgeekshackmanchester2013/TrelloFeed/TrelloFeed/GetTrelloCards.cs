using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using TrelloNet;
using System.Linq;

namespace manchestergirlgeekshackmanchester2013.TrelloFeed
{
    /// <summary>
    /// A Class to do the work of returning trello data to the UI.
    /// </summary>
    public class GetTrelloCards
    {
        private List<Tuple<string, int>> stats = new List<Tuple<string, int>>();

        /// <summary>
        /// Collates a list of all cards on a board in a list requested by name. 
        /// </summary>
        /// <param name="listName">name of the list</param>
        /// <returns>A list of the cards</returns>
        public List<Card> GetListOfCards(string listName)
        {
            var cards = new List<Card>();

            try
            {
                ITrello trello = GetAuthorisedUser();
                Board teamBoard = GetTeamBoard(trello);
                IEnumerable<List> allListsInTheTrelloDevBoard = trello.Lists.ForBoard(teamBoard);
                List requestedList = allListsInTheTrelloDevBoard.ToList().Find(m => m.Name == listName);

                var groups = trello.Cards.ForBoard(teamBoard).GroupBy(m => m.IdList).Where(m => m.Key == requestedList.Id);

                foreach (var group in groups)
                {
                    var groupKey = group.Key;
                    foreach (var groupedItem in group)
                    {
                        if (!groupedItem.Closed)
                        {
                            cards.Add(TrelloCardToPOCOCardObject(groupedItem));
                        }
                    }    
                }  
            }
            catch (Exception ex)
            {
            }

            return cards;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Tuple<string, int>> GetNumberOfCardsInEachList()
        {
            ITrello trello = GetAuthorisedUser();
            Board teamBoard = GetTeamBoard(trello);

            IEnumerable<TrelloNet.Card> allCardsOnTheTrelloDevBoard = trello.Cards.ForBoard(teamBoard);
            IEnumerable<List> allListsInTheTrelloDevBoard = trello.Lists.ForBoard(teamBoard);

            var groups = trello.Cards.ForBoard(teamBoard).GroupBy(m => m.IdList);

            foreach (var group in groups)
            {
                var groupKey = group.Key;
                stats.Add(Tuple.Create(groupKey, group.Count()));
            }

            return stats;
        }

        private static ITrello GetAuthorisedUser()
        {
            string trelloApplicationKey = Properties.Resource1.TrelloApplicationKey;
            ITrello trello = new Trello(trelloApplicationKey);
            trello.Authorize(Properties.Resource1.TrelloToken);

            Member trelloMember = trello.Members.WithId(Properties.Resource1.AuthorisedUser);
            return trello;
        }

        private static Board GetTeamBoard(ITrello trello)
        {
            Organization organisation = trello.Organizations.WithId(Properties.Resource1.OrganisationName);
            IEnumerable<Board> allBoardsOfOrganisation = trello.Boards.ForOrganization(organisation);
            Board teamBoard = allBoardsOfOrganisation.FirstOrDefault();
            return teamBoard;
        }

        private Card TrelloCardToPOCOCardObject(TrelloNet.Card trelloNetCard)
        {
            Card card = new Card();
            card.Name = trelloNetCard.Name;
            card.Description = trelloNetCard.Desc;

            foreach (var label in trelloNetCard.Labels)
            {
                card.Labels.Add(label.Name);
            }

            return card;
        }       
    }
}
