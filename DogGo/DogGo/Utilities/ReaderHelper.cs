using Microsoft.Data.SqlClient;


namespace DogGo.Utils
{
    public class ReaderHelpers
    {
        public static string GetNullableString(SqlDataReader reader, string columnName)
        {
            int ordinal = reader.GetOrdinal(columnName);

            if (reader.IsDBNull(ordinal))
            {
                return null;
            }

            return reader.GetString(ordinal);
        }
    }
}