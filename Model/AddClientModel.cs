using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class IdTypeModel
    {
        public string ID_Name { get; set; }
    }

    public class StateModel
    {
        public string State_Abbr { get; set; }
        public string State_Name { get; set; }
        public string State { get; set; }
    }
    public class MonthModel
    {
        public int Month_ID { get; set; }
        public string Month_Name { get; set; }
        public string Month { get; set; }
    }

    public class CountryModel
    {
        public string Country_Name { get; set; }
        public string Country_Code { get; set; }
        public bool Can_Open { get; set; }
        public string Country { get; set; }
    }
}
