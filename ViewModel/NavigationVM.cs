using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bank.Utilities;
using System.Windows.Input;

namespace Bank.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        // Startup
        public ICommand HomeCommand { get; set; }
        private void Home(object obj) => CurrentView = new HomeVM();
        
        // File
        public ICommand NewSessionCommand { get; }
        public ICommand ClearSessionCommand { get; }
        public ICommand PrintPreviewCommand { get; }
        public ICommand PrintCommand { get; }
        public ICommand ExitCommand { get; }
        private void NewSession(object parameter) => CurrentView = new NewSessionVM();
        private void ClearSession(object parameter) => CurrentView = new ClearSessionVM();
        private void PrintPreview(object parameter) => CurrentView = new PrintPreviewVM();
        private void Print(object parameter) => CurrentView = new PrintVM();

        // Clients
        public ICommand AddClientCommand { get; }
        public ICommand OrganizeClientsCommand { get; }
        private void AddClient(object parameter) => CurrentView = new AddClientVM();
        private void OrganizeClients(object parameter) => CurrentView = new OrganizeClientsVM();
        
        // Help
        public ICommand MainClientKnowledgeCommand { get; }
        public ICommand TipsAndTricksCommand { get; }
        private void MainClientKnowledge(object parameter) => CurrentView = new MainClientKnowledgeVM();
        private void TipsAndTricks(object parameter) => CurrentView = new TipsAndTricksVM();

        // Client & Accounts
        public ICommand ClientOverviewCommand { get; set; }
        public ICommand AccountOverviewCommand { get; set; }
        public ICommand BalancesCommand { get; set; }
        public ICommand PositionsCommand { get; set; }
        public ICommand TransactionsCommand { get; set; }
        public ICommand AccessHistoryCommand { get; set; }
        private void ClientOverview(object obj) => CurrentView = new ClientOverviewVM();
        private void AccountOverview(object obj) => CurrentView = new AccountOverviewVM();
        private void Balances(object obj) => CurrentView = new BalancesVM();
        private void Positions(object obj) => CurrentView = new PositionsVM();
        private void Transactions(object obj) => CurrentView = new TransactionsVM();
        private void AccessHistory(object obj) => CurrentView = new AccessHistoryVM();
        
        // Notes
        public ICommand ViewNotesCommand { get; set; }
        public ICommand AddNotesCommand { get; set; }
        private void ViewNotes(object obj) => CurrentView = new ViewNotesVM();
        private void AddNotes(object obj) => CurrentView = new AddNotesVM();

        // Cashiering
        public ICommand ActivityCommand { get; set; }
        public ICommand HistoryCommand { get; set; }
        public ICommand SingleDepositCommand { get; set; }
        public ICommand MultipleDepositCommand { get; set; }
        public ICommand SplitDepositCommand { get; set; }
        public ICommand MoneylinkCommand { get; set; }
        private void Activity(object obj) => CurrentView = new ActivityVM();
        private void History(object obj) => CurrentView = new HistoryVM();
        private void SingleDeposit(object obj) => CurrentView = new SingleDepositVM();
        private void MultiDeposit(object obj) => CurrentView = new MultiDepositVM();
        private void SplitDeposit(object obj) => CurrentView = new SplitDepositVM();
        private void Moneylink(object obj) => CurrentView = new MoneylinkVM();


        // Trading
        public ICommand OrderEntryCommand { get; set; }
        public ICommand OrderStatusCommand { get; set; }
        private void OrderEntry(object obj) => CurrentView = new OrderEntryVM();
        private void OrderStatus(object obj) => CurrentView = new OrderStatusVM();

        // Settings
        public ICommand SettingsCommand { get; set; }
        private void Setting(object obj) => CurrentView = new SettingsVM();
        
        public NavigationVM()
        {
            // Startup Page
            CurrentView = new HomeVM();

            // File
            NewSessionCommand = new RelayCommand(NewSession);
            ClearSessionCommand = new RelayCommand(ClearSession);
            PrintPreviewCommand = new RelayCommand(PrintPreview);
            PrintCommand = new RelayCommand(Print);
            AddClientCommand = new RelayCommand(AddClient);
            OrganizeClientsCommand = new RelayCommand(OrganizeClients);
            MainClientKnowledgeCommand = new RelayCommand(MainClientKnowledge);
            TipsAndTricksCommand = new RelayCommand(TipsAndTricks);

            // Client & Accounts
            HomeCommand = new RelayCommand(Home);
            ClientOverviewCommand = new RelayCommand(ClientOverview);
            AccountOverviewCommand = new RelayCommand(AccountOverview);
            BalancesCommand = new RelayCommand(Balances);
            PositionsCommand = new RelayCommand(Positions);
            TransactionsCommand = new RelayCommand(Transactions);
            AccessHistoryCommand = new RelayCommand(AccessHistory);
            
            // Notes
            ViewNotesCommand = new RelayCommand(ViewNotes);
            AddNotesCommand = new RelayCommand(AddNotes);

            // Cashiering
            ActivityCommand = new RelayCommand(Activity);
            HistoryCommand = new RelayCommand(History);
            SingleDepositCommand = new RelayCommand(SingleDeposit);
            MultipleDepositCommand = new RelayCommand(MultiDeposit);
            SplitDepositCommand = new RelayCommand(SplitDeposit);
            MoneylinkCommand = new RelayCommand(Moneylink);

            // Trading
            OrderEntryCommand = new RelayCommand(OrderEntry);
            OrderStatusCommand = new RelayCommand(OrderStatus);

            // Settings
            SettingsCommand = new RelayCommand(Setting);
        }
    }
}
