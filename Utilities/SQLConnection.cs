using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank.Utilities
{
    public class Connection
    {
        /*
        
        
        
        
        Change Data Source to your server




        */
        /*
            Trust Server Certificate is to tell the application not to care about trusting the server's certficate
            Not safe for production environments
        */

        // public static readonly string connectionString =
        // "Data Source=DESKTOP-OV51U4G\\SQL2017;"
        //     + "Initial Catalog=BankDB;"
        //     + "Integrated Security=True;"
        //     + "TrustServerCertificate=True;"
        //     + "Min Pool Size=10;"
        //     + "Max Pool Size=100;"
        //     + "Connect Timeout=30";
        public static readonly string connectionString =
            "Data Source=COMPUTER;"
            + "Initial Catalog=BankDB;"
            + "Integrated Security=True;"
            + "TrustServerCertificate=True;"
            + "Min Pool Size=10;"
            + "Max Pool Size=100;"
            + "Connect Timeout=30";
    }
}
