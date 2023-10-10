using System.Data;
using System.Net.NetworkInformation;
using System.Threading;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;
using System.Collections.ObjectModel;
using System.Windows;
using Microsoft.Data.SqlClient;
using Bank.Utilities;
using Bank.ViewModel;

namespace Bank.View
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public SearchWindow(string searchText)
        {
            InitializeComponent();
            DataContext = new SearchWindowVM(searchText);
        }
    }
}
