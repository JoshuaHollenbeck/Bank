using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bank.ViewModel;

namespace Bank.View
{
    /// <summary>
    /// Interaction logic for ClientOverview.xaml
    /// </summary>
    public partial class ClientOverview : UserControl
    {
        public ClientOverview()
        {
            InitializeComponent();
            DataContext = ClientOverviewVM.GetAccount();
        }
    }
}
