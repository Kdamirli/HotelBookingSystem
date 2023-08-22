using Guna.UI2.HtmlRenderer.Adapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem.User_Controls
{
    public partial class UCGetAvailableRooms : UserControl
    {
        Func func = new Func();
        SqlConnection con = new SqlConnection("data source = DESKTOP-70L43IK\\MSSQLSERVER03; database=HotelBookingSystem; integrated security = True");
        public UCGetAvailableRooms()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = func.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(cbHotel.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetAvailableRooms", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hotelId", SqlDbType.Int).Value = cbHotel.SelectedIndex+1;
                cmd.Parameters.AddWithValue("@checkInDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dtCheckIn.Text);
                cmd.Parameters.AddWithValue("@checkOutDate", SqlDbType.DateTime).Value = Convert.ToDateTime(dtCheckOut.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                guna2DataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                MessageBox.Show("Выберите отель!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCGetAvailableRooms_Load(object sender, EventArgs e)
        {
            cbHotel.Items.Clear();
            setComboBox("select title from hotel", cbHotel);
        }
    }
}
