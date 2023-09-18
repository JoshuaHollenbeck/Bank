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
    /// Represents a user control for displaying client overview information in a WPF application.
    /// This control is responsible for initializing the user interface and connecting it to the
    /// corresponding ViewModel (ClientOverviewVM) to facilitate data binding and interaction.
    /// </summary>

    public partial class ClientOverview : UserControl
    {
        // Constructor for the ClientOverview class.
        public ClientOverview()
        {
            // Initialize the user interface components defined in the associated XAML file.    
            InitializeComponent();
            // Set the DataContext of this UserControl to a new instance of the ClientOverviewVM class.
            // This connects the user interface elements to the data and behavior defined in ClientOverviewVM.
            DataContext = new ClientOverviewVM();
        }
    }
}
