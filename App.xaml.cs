using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Bank.ViewModel;
using Bank.Services;

namespace Bank
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            // Initialize the DialogService
            IDialogService dialogService = new DialogService();

            // Initialize the NavigationViewModel with the DialogService
            NavigationVM navigationVM = new NavigationVM(dialogService);

            // Create MainWindow and set its DataContext
            MainWindow mainWindow = new MainWindow
            {
                DataContext = navigationVM
            };

            mainWindow.Show();
        }
    }
}