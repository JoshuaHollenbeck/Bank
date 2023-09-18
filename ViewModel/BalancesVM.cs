using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.ViewModel
{
    class BalancesVM : Utilities.ViewModelBase
    {
        public ObservableCollection<BalanceOverviewModel> BalanceOverviewCollection { get; set; }

        public BalanceOverviewModel SelectedCustOverview { get; set; }

        public BalancesVM()
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
            BalanceOverviewCollection = new ObservableCollection<BalanceOverviewModel>();

            using (SqlConnection connection = new SqlConnection(Connection.connectionString))
            {
                connection.Open();
                string cust_overview_query =
        }
    }
}
