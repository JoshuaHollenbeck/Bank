using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class IdTypeModel
    {
        public string IDName { get; set; }
    }

    public class StateModel
    {
        public string StateAbbr { get; set; }
        public string StateName { get; set; }
        public string State { get; set; }
    }

    public class MonthModel
    {
        public int MonthID { get; set; }
        public string MonthName { get; set; }
        public string Month { get; set; }
    }

    public class CountryModel
    {
        public string CountryName { get; set; }
    }

    public class SuffixModel
    {
        public string SuffixName { get; set; }
    }
}
