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

        public ICommand HomeCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand ProductsCommand { get; set; }
        public ICommand OrdersCommand { get; set; }
        public ICommand TransactionsCommand { get; set; }
        public ICommand ShipmentsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }
        
        public ICommand NewSessionCommand { get; }
        public ICommand ClearSessionCommand { get; }
        public ICommand PrintPreviewCommand { get; }
        public ICommand PrintCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand AddClientCommand { get; }
        public ICommand OrganizeClientsCommand { get; }
        public ICommand MainClientKnowledgeCommand { get; }
        public ICommand TipsAndTricksCommand { get; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Customer(object obj) => CurrentView = new CustomerVM();
        private void Product(object obj) => CurrentView = new ProductVM();
        private void Order(object obj) => CurrentView = new OrderVM();
        private void Transaction(object obj) => CurrentView = new TransactionVM();
        private void Shipment(object obj) => CurrentView = new ShipmentVM();
        private void Setting(object obj) => CurrentView = new SettingVM();

        private void NewSession(object parameter) => CurrentView = new NewSessionVM();
        private void ClearSession(object parameter) => CurrentView = new ClearSessionVM();
        private void PrintPreview(object parameter) => CurrentView = new PrintPreviewVM();
        private void Print(object parameter) => CurrentView = new PrintVM();
        private void AddClient(object parameter) => CurrentView = new AddClientVM();
        private void OrganizeClients(object parameter) => CurrentView = new OrganizeClientsVM();
        private void MainClientKnowledge(object parameter) => CurrentView = new MainClientKnowledgeVM();
        private void TipsAndTricks(object parameter) => CurrentView = new TipsAndTricksVM();
        
        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Customer);
            ProductsCommand = new RelayCommand(Product);
            OrdersCommand = new RelayCommand(Order);
            TransactionsCommand = new RelayCommand(Transaction);
            ShipmentsCommand = new RelayCommand(Shipment);
            SettingsCommand = new RelayCommand(Setting);

            NewSessionCommand = new RelayCommand(NewSession);
            ClearSessionCommand = new RelayCommand(ClearSession);
            PrintPreviewCommand = new RelayCommand(PrintPreview);
            PrintCommand = new RelayCommand(Print);
            AddClientCommand = new RelayCommand(AddClient);
            OrganizeClientsCommand = new RelayCommand(OrganizeClients);
            MainClientKnowledgeCommand = new RelayCommand(MainClientKnowledge);
            TipsAndTricksCommand = new RelayCommand(TipsAndTricks);

            // Startup Page
            CurrentView = new HomeVM();
        }
    }
}
