using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILLONE_DSAL01E_CPE301
{
    internal class DSAL_dbconnection
    {
        public String DSAL_connectionString = null;
        public SqlConnection DSAL_sql_connection;
        public SqlCommand DSAL_sql_command;
        public DataSet DSAL_sql_dataset;
        public SqlDataAdapter DSAL_sql_dataadapter;
        public string DSAL_sql = null;

        public void DSAL_connString()
        {
            DSAL_sql_connection = new SqlConnection();
            DSAL_connectionString = "Data Source=ALI\\SQLEXPRESS;Initial Catalog = DSAL_db;Integrated Security=True;";
            DSAL_sql_connection = new SqlConnection(DSAL_connectionString);
            DSAL_sql_connection.ConnectionString = DSAL_connectionString;
            DSAL_sql_connection.Open();
        }

public void DSAL_cmd()
        {   
            DSAL_sql_command = new SqlCommand(DSAL_sql, DSAL_sql_connection);
            DSAL_sql_command.CommandType = CommandType.Text;
        }

        public void DSAL_sqladapterSelect()
        {
            DSAL_sql_dataadapter = new SqlDataAdapter();
            DSAL_sql_dataadapter.SelectCommand = DSAL_sql_command;
            DSAL_sql_command.ExecuteNonQuery();
        }

        public void DSAL_sqladapterInsert()
        {
            DSAL_sql_dataadapter = new SqlDataAdapter();
            DSAL_sql_dataadapter.InsertCommand = DSAL_sql_command;
            DSAL_sql_command.ExecuteNonQuery();
        }

        public void DSAL_sqldataSelect()
        {
            DSAL_sql_dataset = new DataSet();
            DSAL_sql_dataadapter.Fill(DSAL_sql_dataset, "EmployeeTbl");
        }
    }
}
