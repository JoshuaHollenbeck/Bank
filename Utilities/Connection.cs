using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bank.Utilities
{
    public class Connection
    {
        string connectionString = 
            "Data Source=DESKTOP-OV51U4G\\SQL2017;"
                + "Initial Catalog=BankDB;"
                + "Integrated Security=True;"
                + "TrustServerCertificate=True;"
                + "Min Pool Size=10;"
                + "Max Pool Size=100;"
                + "Connect Timeout=30";
            // string connectionString =
            //     "Data Source=LAPTOP-M4J440IF\\SQL2017;"
            //     + "Initial Catalog=BankDB;"
            //     + "Integrated Security=True;"
            //     + "TrustServerCertificate=True;"
            //     + "Min Pool Size=10;"
            //     + "Max Pool Size=100;"
            //     + "Connect Timeout=30";
    }
}
