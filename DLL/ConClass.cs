using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DLL
{
   public class ConClass
    {
        SqlConnection con;
        SqlCommand cmd;
        public ConClass()
        {
            con = new SqlConnection(@"server=RAZORCREST\SQLEXPRESS;database=PROJECTECOMMERCE;Integrated Security=True");
        }
        public int fn_NonQUerrys(string Query)//insert/delete/update
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(Query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public string fn_ScalarQUerrys(string Query)//scalar functions
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(Query, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }
        public SqlDataReader fn_Reader(string Query)//select
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(Query, con);
            con.Open();
            SqlDataReader dt = cmd.ExecuteReader();

            return dt;
        }
        public DataSet fn_Dataset(string Query)//DATASET, MIRROR COPY OF DB_TABLE
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter dt = new SqlDataAdapter(Query, con);
            DataSet ds = new DataSet();
            dt.Fill(ds);
            return ds;
        }
        public DataTable fn_DataTable(string Query)//TABLE DB INCLUDING IDS
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter dt = new SqlDataAdapter(Query, con);
            DataTable ds = new DataTable();
            dt.Fill(ds);
            return ds;
        }

    }
}
