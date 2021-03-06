﻿﻿using System;
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
using System.Windows.Threading;
using System.ComponentModel;
using manchestergirlgeekshackmanchester2013.TrelloFeed;

namespace ManchesterGirlGeeks2013.Views
{
    /// <summary>
    /// Interaction logic for Trello.xaml
    /// </summary>
    public partial class Trello : Page
    {
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        GetTrelloCards getTrelloCards = new GetTrelloCards();
        
        #region Properties
        public event PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string name)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }
      
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
            set
            {
                
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
            //set
            //{
            //    //this.DoneItems = value;
            //    this.RaisePropertyChanged("DoneItems");
            //}
        }
        public List<Card> Cards
        {
            get
            {
                return getTrelloCards.GetListOfCards("Doing");
            }
            set { ;}

        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Trello()
        {
            InitializeComponent();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0,0, 0, 10);
            dispatcherTimer.Start();
        }
        #endregion

        #region Event Handlers
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Cards = getTrelloCards.GetListOfCards("Doing");
           // this.DoneItems = 20;
            //stckDone.ref
        }

        #endregion
    }
}
