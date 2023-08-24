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
using Microsoft.Data.SqlClient;
using Bank.Utilities;

namespace Bank.ViewModel
{
    class AccountOverviewVM : Utilities.ViewModelBase
    {
        public ObservableCollection<AcctOverviewModel> AcctOverviewCollection { get; set; }

        public AcctOverviewModel SelectedAcctOverview { get; set; }

        public AccountOverviewVM()
        {
            LoadTypes();
        }

        private T? GetNullableValue<T>(
            SqlDataReader reader,
            string columnName,
            Func<int, T> getValueFunc
        )
            where T : struct
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? (T?)null : getValueFunc(ordinal);
        }

        public string GetStringOrNull(SqlDataReader reader, String columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);

            if (!reader.IsDBNull(ordinal))
            {
                if (reader.GetFieldType(ordinal) == typeof(string))
                {
                    return reader.GetString(ordinal);
                }
                else if (reader.GetFieldType(ordinal) == typeof(int))
                {
                    return reader.GetInt32(ordinal).ToString();
                }
            }
            return null;
        }
        
        
        public void LoadTypes()
        {
            AcctOverviewCollection = new ObservableCollection<AcctOverviewModel>();
            
            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                string acct_overview_query =
                    @"
                    SELECT acct_num,
                    inital_contact_method,
                    acct_type,
                    registration_name,
                    acct_objective,
                    acct_funding,
                    acct_purpose,
                    acct_activity,
                    established_date,
                    acct_status,
                    acct_jurisdiction_country,
                    acct_jurisdiction_state,
                    acct_pass,
                    atm_limit,
                    ach_limit,
                    wire_limit,
                    online,
                    mobile,
                    two_factor,
                    biometrics,
                    a.cust_id, 
                    first_name,
                    middle_name,
                    last_name,
                    suffix,
                    email,
                    address,
                    address_2,
                    city,
                    state,
                    zip_code,
                    encrypted_tax_a,
                    tax_b
                    FROM acct_info a
                    JOIN acct_jurisdiction b ON a.acct_id = b.acct_id
                    JOIN acct_pass c ON a.acct_id = c.acct_id
                    JOIN acct_limit d ON a.acct_id = d.acct_id
                    JOIN acct_mobile e ON a.acct_id = e.acct_id
                    JOIN cust_info f ON a.cust_id = f.cust_id
                    JOIN cust_contact g ON a.cust_id = g.cust_id
                    JOIN cust_id h ON a.cust_id = h.cust_id
                    JOIN cust_tax i ON a.cust_id = i.cust_id
                    WHERE a.acct_num = 74465735;
                ";
                using (SqlCommand command = new SqlCommand(acct_overview_query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SelectedAcctOverview = new AcctOverviewModel
                        {
                            InitialContactMethod = GetNullableValue(reader, "intital_contact_method", reader.GetInt32),
                            AccountType = GetNullableValue(reader, "acct_type", reader.GetInt32),
                            RegistrationName = GetStringOrNull(reader, "registration_name"),
                            ClientFirstName = GetStringOrNull(reader, "first_name"),
                            ClientMiddleName = GetStringOrNull(reader, "middle_name"),
                            ClientLastName = GetStringOrNull(reader, "last_name"),
                            ClientSuffix = GetStringOrNull(reader, "suffix"),
                            ClientAddress = GetStringOrNull(reader, "address"),
                            ClientAddress2 =  GetStringOrNull(reader, "address_2"),
                            ClientCity = GetStringOrNull(reader, "city"),
                            ClientState = GetStringOrNull(reader, "state"),
                            ClientZip = GetStringOrNull(reader, "zip_code"),
                            ClientCountry = GetStringOrNull(reader, "country"),
                            PrimaryContactName = GetStringOrNull(reader, "contact_name"),
                            PrimaryContactAddress = GetStringOrNull(reader, "contact_address"),
                            PrimaryContactAddress2 = GetStringOrNull(reader, "contact_address_2"),
                            PrimaryContactCity = GetStringOrNull(reader, "contact_city"),
                            PrimaryContactState = GetStringOrNull(reader, "contact_states"),
                            PrimaryContactZip = GetStringOrNull(reader, "contact_zip"),
                            RepID = GetStringOrNull(reader, "rep_id"),
                            EstablishedDate = GetStringOrNull(reader, "established_date"),
                            AccountStatus = GetStringOrNull(reader, "acct_status"),
                            AccountCountryJurisdiction = GetStringOrNull(reader, "acct_jurisdiction_country"),
                            AccountStateJurisdiction = GetStringOrNull(reader, "acct_jurisdiction_state"),
                            AccountPassword = GetStringOrNull(reader, "acct_pass"),
                            BranchLocation = GetStringOrNull(reader, "city"),
                            TaxA = GetStringOrNull(reader, "encrypted_tax_a"),
                            TaxB = GetStringOrNull(reader, "tax_b"),
                            AtmLimit = GetStringOrNull(reader, "atm_limit"),
                            AchLimit = GetStringOrNull(reader, "ach_limit"),
                            WireLimit = GetStringOrNull(reader, "wire_limit"),
                            EmailAddress = GetStringOrNull(reader, "email" ),
                            OnlineBanking = GetNullableValue(reader, "online_banking", reader.GetBoolean),
                            MobileBanking = GetNullableValue(reader, "mobile_banking", reader.GetBoolean),
                            TwoFactor = GetNullableValue(reader, "two_factor", reader.GetBoolean),
                            Biometrics = GetNullableValue(reader, "biometrics", reader.GetBoolean),
                            AcctObjective = GetNullableValue(reader, "acct_objective", reader.GetInt32),
                            AcctFunding = GetNullableValue(reader, "acct_funding", reader.GetInt32),
                            AcctPurpose = GetNullableValue(reader, "acct_purpose", reader.GetInt32),
                            AcctActivity = GetNullableValue(reader, "acct_activity", reader.GetInt32)
                        };
                    }
                }
                connection.Close();
            }
        }
    }
}
