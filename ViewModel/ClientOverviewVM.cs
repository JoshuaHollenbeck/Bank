using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.ViewModel
{
    class ClientOverviewVM : Utilities.ViewModelBase
    {
        public bool DoNotCall { get; set; }

        public static ClientOverviewVM GetAccount()
        {
            var account = new ClientOverviewVM() { DoNotCall = true, };
            return account;
        }
    }
}
