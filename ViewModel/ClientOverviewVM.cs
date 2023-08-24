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
    class ClientOverviewVM : Utilities.ViewModelBase
    {
        public ObservableCollection<CustOverviewModel> CustOverviewCollection { get; set; }

        public CustOverviewModel SelectedCustOverview { get; set; }

        public ClientOverviewVM()
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
                // ... You can add more type checks if necessary ...
            }
            return null;
        }

        public void LoadTypes()
        {
            CustOverviewCollection = new ObservableCollection<CustOverviewModel>();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                string cust_overview_query =
                    @"
                    SELECT acct_num,
                    a.cust_id,
                    voice_auth,
                    first_name,
                    middle_name,
                    last_name,
                    suffix,
                    do_not_call,
                    share_affiliates,
                    date_of_birth,
                    mothers_maiden,
                    client_since,
                    id_type,
                    id_state,
                    id_num,
                    id_exp,
                    phone_home,
                    phone_business,
                    email,
                    address,
                    address_2,
                    city,
                    state,
                    zip_code,
                    city,
                    state,
                    employment_status,
                    employer_name,
                    occupation,
                    acct_num,
                    acct_nickname, 
                    acct_pass,
                    acct_type,
                    registration_name,
                    acct_bal
                    FROM acct_info a
                    JOIN cust_emp b ON a.cust_id = b.cust_id
                    JOIN cust_privacy c ON a.cust_id = c.cust_id
                    JOIN cust_contact d ON a.cust_id = d.cust_id
                    JOIN cust_info e ON a.cust_id = e.cust_id
                    JOIN acct_pass f ON a.acct_id = f.acct_id
                    JOIN cust_id g ON a.cust_id = g.cust_id
                    JOIN acct_bal h ON a.acct_id = h.acct_id
                    WHERE a.acct_num = 74465735;
                ";
                using (SqlCommand command = new SqlCommand(cust_overview_query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SelectedCustOverview = new CustOverviewModel
                        {
                            CustID = GetNullableValue(reader, "cust_id", reader.GetInt32),
                            VoiceAuth = GetNullableValue(reader, "voice_auth", reader.GetBoolean),
                            FirstName = GetStringOrNull(reader, "first_name"),
                            MiddleName = GetStringOrNull(reader, "middle_name"),
                            LastName = GetStringOrNull(reader, "last_name"),
                            Suffix = GetStringOrNull(reader, "suffix"),
                            DoNotCall = GetNullableValue(reader, "do_not_call", reader.GetBoolean),
                            ShareWithAffiliates = GetNullableValue(
                                reader,
                                "share_affiliates",
                                reader.GetBoolean
                            ),
                            DateOfBirth = GetNullableValue(
                                reader,
                                "date_of_birth",
                                reader.GetDateTime
                            ),
                            MothersMaiden = GetStringOrNull(reader, "mothers_maiden"),
                            ClientSince = GetNullableValue(
                                reader,
                                "client_since",
                                reader.GetDateTime
                            ),
                            IDType = GetNullableValue(reader, "id_type", reader.GetInt32),
                            IDState = GetStringOrNull(reader, "id_state"),
                            IDNum = GetStringOrNull(reader, "id_num"),
                            ExpDate = GetStringOrNull(reader, "id_exp"),
                            HomePhone = GetStringOrNull(reader, "phone_home"),
                            WorkPhone = GetStringOrNull(reader, "phone_business"),
                            EmailAddress = GetStringOrNull(reader, "email"),
                            Address = GetStringOrNull(reader, "address"),
                            AddressLine2 = GetStringOrNull(reader, "address_2"),
                            City = GetStringOrNull(reader, "city"),
                            State = GetStringOrNull(reader, "state"),
                            Zip = GetStringOrNull(reader, "zip_code"),
                            DomicleBranchCity = GetStringOrNull(reader, "city"),
                            DomicleBranchState = GetStringOrNull(reader, "state"),
                            EmploymentStatus = GetNullableValue(
                                reader,
                                "employment_status",
                                reader.GetBoolean
                            ),
                            EmployerName = GetStringOrNull(reader, "employer_name"),
                            Occupation = GetStringOrNull(reader, "occupation"),
                            AcctNum = GetNullableValue(reader, "acct_num", reader.GetInt32),
                            AcctNickname = GetStringOrNull(reader, "acct_nickname"),
                            AcctBalance = GetNullableValue(reader, "acct_bal", reader.GetDecimal),
                            AcctPass = GetStringOrNull(reader, "acct_pass"),
                            AcctType = GetNullableValue(reader, "acct_type", reader.GetInt32),
                            AcctRegistration = GetStringOrNull(reader, "registration_name")
                        };
                    }
                }
                connection.Close();
            }
        }
    }
}
