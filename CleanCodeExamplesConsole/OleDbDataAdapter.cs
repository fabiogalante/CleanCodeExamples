using System.Data;

namespace CleanCodeExamplesConsole
{
    internal class OleDbDataAdapter
    {
        private string sql;
        private string connectionString;

        public OleDbDataAdapter(string sql, string connectionString)
        {
            this.sql = sql;
            this.connectionString = connectionString;
        }

        public void Fill(DataSet dataSet, string categories)
        {
            throw new System.NotImplementedException();
        }
    }
}