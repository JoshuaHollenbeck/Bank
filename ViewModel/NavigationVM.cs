using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Bank.Utilities;
using System.Windows.Input;
using Microsoft.Data.SqlClient;
using Bank.View;
using Bank.Services;

namespace Bank.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private IDialogService _dialogService;
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        // Startup
        public ICommand HomeCommand { get; }

        private void Home(object obj) => CurrentView = new HomeVM();

        // File
        public ICommand NewSessionCommand { get; }
        public ICommand ClearSessionCommand { get; }
        public ICommand PrintPreviewCommand { get; }
        public ICommand PrintCommand { get; }
        public ICommand ExitCommand { get; }

        private void NewSession(object obj) => CurrentView = new NewSessionVM();

        private void ClearSession(object obj) => CurrentView = new ClearSessionVM();

        private void PrintPreview(object obj) => CurrentView = new PrintPreviewVM();

        private void Print(object obj) => CurrentView = new PrintVM();

        // Clients
        public ICommand AddClientCommand { get; }

        private void AddClient(object obj) => CurrentView = new AddClientVM();

        // Help
        public ICommand MainClientKnowledgeCommand { get; }
        public ICommand TipsAndTricksCommand { get; }

        private void MainClientKnowledge(object obj) => CurrentView = new MainClientKnowledgeVM();

        private void TipsAndTricks(object obj) => CurrentView = new TipsAndTricksVM();

        // Search
        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged("SearchText");
                }
            }
        }
        public ICommand SearchCommand { get; }

         private void Search(object obj)
        {
            SearchWindow searchWindow = new SearchWindow(_searchText);
            searchWindow.Show();
        }

        // Advanced Search
        public ICommand AdvancedSearchCommand { get; private set; }
        
        private void AdvancedSearch(object obj)
        {
            _dialogService.OpenDialog<AdvancedSearch>();
        }

        // Client & Accounts
        public ICommand ClientOverviewCommand { get; }
        public ICommand AccountOverviewCommand { get; }
        public ICommand BalancesCommand { get; }
        public ICommand PositionsCommand { get; }
        public ICommand TransactionsCommand { get; }
        public ICommand AccessHistoryCommand { get; }

        private void ClientOverview(object obj) => CurrentView = new ClientOverviewVM();

        private void AccountOverview(object obj) => CurrentView = new AccountOverviewVM();

        private void Balances(object obj) => CurrentView = new BalancesVM();

        private void Positions(object obj) => CurrentView = new PositionsVM();

        private void Transactions(object obj) => CurrentView = new TransactionsVM();

        // Notes
        public ICommand ViewNotesCommand { get; }
        public ICommand AddNotesCommand { get; }

        private void ViewNotes(object obj) => CurrentView = new ViewNotesVM();

        private void AddNotes(object obj) => CurrentView = new AddNotesVM();

        // Cashiering
        public ICommand ActivityCommand { get; }
        public ICommand HistoryCommand { get; }
        public ICommand SingleDepositCommand { get; }
        public ICommand MultiDepositCommand { get; }
        public ICommand SplitDepositCommand { get; }
        public ICommand MoneylinkCommand { get; }

        private void Activity(object obj) => CurrentView = new ActivityVM();

        private void History(object obj) => CurrentView = new HistoryVM();

        private void SingleDeposit(object obj) => CurrentView = new SingleDepositVM();

        private void MultiDeposit(object obj) => CurrentView = new MultiDepositVM();

        private void SplitDeposit(object obj) => CurrentView = new SplitDepositVM();

        private void Moneylink(object obj) => CurrentView = new MoneylinkVM();

        // Trading
        public ICommand OrderEntryCommand { get; }
        public ICommand OrderStatusCommand { get; }

        private void OrderEntry(object obj) => CurrentView = new OrderEntryVM();

        private void OrderStatus(object obj) => CurrentView = new OrderStatusVM();

        // Settings
        public ICommand SettingsCommand { get; }

        private void Setting(object obj) => CurrentView = new SettingsVM();

        public NavigationVM(IDialogService dialogService)
        {
            _dialogService = dialogService ?? throw new ArgumentNullException(nameof(dialogService));
            AddClientCommand = new RelayCommand(AddClient);
            AdvancedSearchCommand = new RelayCommand(AdvancedSearch);

            // Startup Page
            CurrentView = new HomeVM();
            // File
            NewSessionCommand = new RelayCommand(NewSession);
            ClearSessionCommand = new RelayCommand(ClearSession);
            PrintPreviewCommand = new RelayCommand(PrintPreview);
            PrintCommand = new RelayCommand(Print);
            
            MainClientKnowledgeCommand = new RelayCommand(MainClientKnowledge);
            TipsAndTricksCommand = new RelayCommand(TipsAndTricks);
            // Search
            SearchCommand = new RelayCommand(Search);
            // Client & Accounts
            HomeCommand = new RelayCommand(Home);
            ClientOverviewCommand = new RelayCommand(ClientOverview);
            AccountOverviewCommand = new RelayCommand(AccountOverview);
            BalancesCommand = new RelayCommand(Balances);
            PositionsCommand = new RelayCommand(Positions);
            TransactionsCommand = new RelayCommand(Transactions);
            // Notes
            ViewNotesCommand = new RelayCommand(ViewNotes);
            AddNotesCommand = new RelayCommand(AddNotes);
            // Cashiering
            ActivityCommand = new RelayCommand(Activity);
            HistoryCommand = new RelayCommand(History);
            SingleDepositCommand = new RelayCommand(SingleDeposit);
            MultiDepositCommand = new RelayCommand(MultiDeposit);
            SplitDepositCommand = new RelayCommand(SplitDeposit);
            MoneylinkCommand = new RelayCommand(Moneylink);
            // Trading
            OrderEntryCommand = new RelayCommand(OrderEntry);
            OrderStatusCommand = new RelayCommand(OrderStatus);
            // Settings
            SettingsCommand = new RelayCommand(Setting);
        }

        public NavigationVM()
        {
        }
    }
}
