using HotelBookingSystem.addRoomDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelBookingSystem.User_Controls
{
    public partial class UCupdate_room_prices : UserControl
    {
        Func func = new Func();
        addRoomViewTableAdapter adapter = new addRoomViewTableAdapter();
        SqlConnection con = new SqlConnection("data source = DESKTOP-70L43IK\\MSSQLSERVER03; database=HotelBookingSystem; integrated security = True");
        public UCupdate_room_prices()
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

        private void UCupdate_room_prices_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = adapter.GetData();
            cbHotel.Items.Clear();
            setComboBox("select title from hotel", cbHotel);
        }

        private void cbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(func.getPrice("select COUNT(*) FROM [room] WHERE [booked] = 1 and hotel_id = " + (cbHotel.SelectedIndex+1) + "") == func.getPrice("SELECT COUNT(*) FROM [room]"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update_room_prices", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hotel", SqlDbType.Float).Value = cbHotel.SelectedIndex+1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Стоимость повышена на 5%!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                UCupdate_room_prices_Load(this, null);
            }
            else
            {
                MessageBox.Show("В выбранном отеле есть свободные номера! Увеличение стоимости невозможно");
            }
        }
    }
}
