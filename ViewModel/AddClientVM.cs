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
    class AddClientVM : Utilities.ViewModelBase
    {
        public ObservableCollection<IdTypeModel> IdTypeCollection { get; set; }
        public ObservableCollection<MonthModel> MonthCollection { get; set; }
        public ObservableCollection<StateModel> StateCollection { get; set; }
        public ObservableCollection<CountryModel> CountryCollection { get; set; }
        public ObservableCollection<SuffixModel> SuffixCollection { get; set; }

        public AddClientVM()
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            /*
            Change Data Source to your server
            Trust Server Certificate is to tell the application not to care about trusting the server's certficate
            Not safe for production environments
            */

            IdTypeCollection = new ObservableCollection<IdTypeModel>();
            MonthCollection = new ObservableCollection<MonthModel>();
            StateCollection = new ObservableCollection<StateModel>();
            CountryCollection = new ObservableCollection<CountryModel>();
            SuffixCollection = new ObservableCollection<SuffixModel>();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                string id_query = "SELECT id_type FROM LU_id_type";
                using (SqlCommand command = new SqlCommand(id_query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        IdTypeCollection.Add(new IdTypeModel { ID_Name = reader.GetString(0) });
                    }
                }

                string state_query = "SELECT state_abbr, state_name from LU_state";
                using (SqlCommand command = new SqlCommand(state_query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StateCollection.Add(
                            new StateModel
                            {
                                State_Abbr = reader.GetString(0),
                                State_Name = reader.GetString(1),
                                State = $"{reader.GetString(0)} - {reader.GetString(1)}"
                            }
                        );
                    }
                }

                string month_query = "SELECT month_id, month_name from LU_month";
                using (SqlCommand command = new SqlCommand(month_query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MonthCollection.Add(
                            new MonthModel
                            {
                                Month_ID = reader.GetInt32(0),
                                Month_Name = reader.GetString(1),
                                Month = $"{reader.GetInt32(0)} - {reader.GetString(1)}"
                            }
                        );
                    }
                }

                string country_query = "SELECT country_name from LU_country where can_open = 1";
                using (SqlCommand command = new SqlCommand(country_query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CountryCollection.Add(
                            new CountryModel { Country_Name = reader.GetString(0), }
                        );
                    }
                }

                string suffix_query = "SELECT suffix_name from LU_suffix";
                using (SqlCommand command = new SqlCommand(suffix_query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SuffixCollection.Add(
                            new SuffixModel { Suffix_Name = reader.GetString(0), }
                        );
                    }
                }
            }
        }
    }
}
