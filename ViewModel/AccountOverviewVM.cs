using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.ViewModel
{
    class AccountOverviewVM : Utilities.ViewModelBase
    {
        public string InitialContactMethod { get; set; }
        public string AccountType { get; set; }
        public string RegistrationName { get; set; }
        public string ClientName { get; set; }
        public string ClientAddress { get; set; }
        public string ClientCity { get; set; }
        public string ClientState { get; set; }
        public string ClientZip { get; set; }
        public string ClientCountry { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactAddress { get; set; }
        public string PrimaryContactCity { get; set; }
        public string PrimaryContactState { get; set; }
        public string PrimaryContactZip { get; set; }
        public string RepID { get; set; }
        public string EstablishedDate { get; set; }
        public string AccountStatus { get; set; }
        public string AccountCountryJurisdiction { get; set; }
        public string AccountStateJurisdiction { get; set; }
        public string AccountPassword { get; set; }
        public string TaxWitholdingCode { get; set; }
        public string TaxpayerID { get; set; }
        public int AccountFunding { get; set; }
        public int AccountPurpose { get; set; }
        public int InvestmentObjectives { get; set; }
        public int AnticipatedActivity { get; set; }

        public static AccountOverviewVM GetAccount()
        {
            var account = new AccountOverviewVM()
            { 
                InitialContactMethod = "Mail",
                AccountType = "Brokerage",
                RegistrationName = "Johnny Storm Brokerage",
                ClientName = "Johnny Storm",
                ClientAddress = "458 S. 9th St",
                ClientCity = "Borington",
                ClientState = "IA",
                ClientZip = "52601",
                ClientCountry = "United States",
                PrimaryContactName = "Johnny Storm",
                PrimaryContactAddress = "458 S. 9th St",
                PrimaryContactCity = "Borington",
                PrimaryContactState = "IA",
                PrimaryContactZip = "52601",
                RepID = "456de",
                EstablishedDate = "08/15/2021",
                AccountStatus = "Open",
                AccountCountryJurisdiction = "",
                AccountStateJurisdiction = "",
                AccountPassword = "",
                TaxpayerID = "",
                AccountFunding = 4,
                AccountPurpose = 3,
                InvestmentObjectives = 3,
                AnticipatedActivity = 0,
            }; 
            return account;
        }
    }
}
