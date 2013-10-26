using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using manchestergirlgeekshackmanchester2013.TrelloFeed;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for Trello.xaml
    /// </summary>
    public partial class Trello : Page
    {
        
        GetTrelloCards getTrelloCards = new GetTrelloCards();
        
        #region Properties
        /// <summary>
        /// Property in which we store the number of items to do
        /// </summary>
        public int ToDoItems
        {
            get
            {
                return getTrelloCards.GetNumberOfCardsInEachList().ElementAt(0).Item2;
            }
        }
        /// <summary>
        /// Property in which we store the number of items in progress
        /// </summary>
        public int DoingItems
        {
            get
            {
                return getTrelloCards.GetNumberOfCardsInEachList().ElementAt(1).Item2;
            }
        }
        /// <summary>
        /// Property in which we store the number of items done
        /// </summary>
        public int DoneItems
        {
            get
            {
                return getTrelloCards.GetNumberOfCardsInEachList().ElementAt(2).Item2;
            }
        }
        public List<Card> Cards
        {
            get
            {
                return getTrelloCards.GetListOfCards("To Do");
            }

        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Trello()
        {
            InitializeComponent();

            

            var listOfCards = getTrelloCards.GetListOfCards("To Do");

        }
        #endregion
    }
}
