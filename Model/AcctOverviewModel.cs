using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    public class AcctOverviewModel
    {
        public int? InitialContactMethod { get; set; }
        public int? AccountType { get; set; }
        public string RegistrationName { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientMiddleName { get; set; }
        public string ClientLastName { get; set; }
        public string ClientSuffix { get; set; }
        public string ClientAddress { get; set; }
        public string ClientAddress2 { get; set; }
        public string ClientCity { get; set; }
        public string ClientState { get; set; }
        public string ClientZip { get; set; }
        public string ClientCountry { get; set; }
        public string PrimaryContactName { get; set; }
        public string PrimaryContactAddress { get; set; }
        public string PrimaryContactAddress2 { get; set; }
        public string PrimaryContactCity { get; set; }
        public string PrimaryContactState { get; set; }
        public string PrimaryContactZip { get; set; }
        public string RepID { get; set; }
        public DateTime? EstablishedDate { get; set; }
        public bool? AccountStatus { get; set; }
        public string JurisdictionCountry { get; set; }
        public string JurisdictionState { get; set; }
        public string AccountPassword { get; set; }
        public string BranchLocation { get; set; }
        public string TaxA { get; set; }
        public string TaxB { get; set; }
        public string AtmLimit { get; set; }
        public string AchLimit { get; set; }
        public string WireLimit { get; set; }
        public string EmailAddress { get; set; }
        public bool? OnlineBanking { get; set; }
        public bool? MobileBanking { get; set; }
        public bool? TwoFactor { get; set; }
        public bool? Biometrics { get; set; }
        public int? AcctObjective { get; set; }
        public int? AcctFunding { get; set; }
        public int? AcctPurpose { get; set; }
        public int? AcctActivity { get; set; }
    }
}
