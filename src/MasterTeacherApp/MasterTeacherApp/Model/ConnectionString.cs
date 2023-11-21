using System.Data.SqlClient;

namespace MasterTeacherApp.Model
{
    public class ConnectionString
    {
        public static string login;

        public static string password;

        public string ConnectionStr
        {
            get 
            { 
                return new SqlConnectionStringBuilder()
                {
                    DataSource = "DESKTOP-OVFICRT",
                    InitialCatalog = "Work_Head_Teacher",
                    ColumnEncryptionSetting = SqlConnectionColumnEncryptionSetting.Enabled,
                    UserID = login,
                    Password = password
                }.ConnectionString;
            }
        }
    }
}
