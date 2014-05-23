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
        private ITrello trello =null;
        Dictionary<string, List<string>> listOfCardsByTeamMember = new Dictionary<string, List<string>>();

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
                GetTrelloAuthorisation();
                Board teamBoard = GetTeamBoard();
                IEnumerable<List> allListsInTheTrelloDevBoard = trello.Lists.ForBoard(teamBoard);
                List requestedList = allListsInTheTrelloDevBoard.ToList().Find(m => m.Name == listName);

                var groups = trello.Cards.ForBoard(teamBoard).GroupBy(m => m.IdList).Where(m => m.Key == requestedList.Id);
                BuildCardToTeamMemberLookup();

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
        /// Reads the authorisation key from the resources file to access the TrelloNet API.
        /// </summary>
        /// <returns></returns>
        public List<Tuple<string, int>> GetNumberOfCardsInEachList()
        {
            GetTrelloAuthorisation();
            Board teamBoard = GetTeamBoard();

            IEnumerable<TrelloNet.Card> allCardsOnTheTrelloDevBoard = trello.Cards.ForBoard(teamBoard);
            IEnumerable<List> allListsInTheTrelloDevBoard = trello.Lists.ForBoard(teamBoard);

            var groups = trello.Cards.ForBoard(teamBoard).GroupBy(m => m.IdList);

            foreach (var group in groups)
            {
                var groupKey = group.Key;
                var list = allListsInTheTrelloDevBoard.Where(m => m.GetListId() == groupKey);
                var listName = list.FirstOrDefault().Name;
                stats.Add(Tuple.Create(listName, group.Count()));
            }

            return stats;
        }

        private void GetTrelloAuthorisation()
        {
            string trelloApplicationKey = Properties.Resource1.TrelloApplicationKey;
            trello = new Trello(trelloApplicationKey);
            trello.Authorize(Properties.Resource1.TrelloToken);
        }

        private Member GetAuthorisedUser()
        {
            var member = trello.Members.WithId(Properties.Resource1.AuthorisedUser);
            return trello.Members.Me();
        }

        private Board GetTeamBoard()
        {
            Organization organisation = trello.Organizations.WithId(Properties.Resource1.OrganisationName);
            IEnumerable<Board> allBoardsOfOrganisation = trello.Boards.ForOrganization(organisation);
            return allBoardsOfOrganisation.FirstOrDefault();
        }

        /// <summary>
        /// Create a dictionary lookup for cards and team members. Each card is held as a key with a list of all members who are assigned to the card.
        /// </summary>
        private void BuildCardToTeamMemberLookup()
        {
            //get all members of a board
            IEnumerable<Member> membersOfTrelloDevBoard = trello.Members.ForBoard(GetTeamBoard());

            foreach (var teamMember in membersOfTrelloDevBoard)
            {
                //get all cards assigned to member
                IEnumerable<TrelloNet.Card> allCardsAssignedToMe = trello.Cards.ForMember(teamMember);

                foreach (var card in allCardsAssignedToMe)
                {
                    List<string> existingMember = new List<string>();
                    List<string> members = new List<string>();

                    if (listOfCardsByTeamMember.TryGetValue(card.Id, out existingMember))
                    {
                        //if card already exists - add to list of string names
                        existingMember.Add(teamMember.FullName);
                        listOfCardsByTeamMember[card.Id] = existingMember;
                    }
                    else
                    {                        
                        members.Add(teamMember.FullName); 
                        listOfCardsByTeamMember.Add(card.Id, members);
                    }
                }
            }
        }

        /// <summary>
        /// Assigns data from TrelloNet Card object to our POCO card object
        /// Looks up which team member is assigned to a particular card
        /// </summary>
        /// </summary>
        /// <param name="trelloNetCard"></param>
        /// <returns></returns>
        private Card TrelloCardToPOCOCardObject(TrelloNet.Card trelloNetCard)
        {
            Card card = new Card();
            card.Labels = new List<string>();
            card.Members = new List<string>();
            card.Name = trelloNetCard.Name;
            card.Description = trelloNetCard.Desc;

            foreach (var label in trelloNetCard.Labels)
            {
                card.Labels.Add(label.Name);
            }

            var teamMembers = listOfCardsByTeamMember[trelloNetCard.Id];

            foreach (var member in teamMembers)
            {
                card.Members.Add(member);
            }

            return card;
        }       
    }
}
