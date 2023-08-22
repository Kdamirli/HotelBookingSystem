using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    internal class Func
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-70L43IK\\MSSQLSERVER03; database=HotelBookingSystem; integrated security = True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String message)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void setData2(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int getPrice(String query)
        {
            int price = 0;
            using (SqlConnection con = getConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    price = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return price;
        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        public Tuple<string, string> getUserInfo(String query, int a, int b)
        {
            String log = "";
            String pass = "";
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    log = sdr[a].ToString();
                    pass = sdr[b].ToString();
                }
            }

            con.Close();
            return Tuple.Create(log, pass);
        }
    }
}
