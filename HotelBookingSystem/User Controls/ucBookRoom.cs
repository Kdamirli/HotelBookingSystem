using HotelBookingSystem.addCheckInDSTableAdapters;
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
    public partial class ucBookRoom : UserControl
    {
        Func func = new Func();
        addCheckInViewTableAdapter adapter = new addCheckInViewTableAdapter();
        SqlConnection con = new SqlConnection("data source = DESKTOP-70L43IK\\MSSQLSERVER03; database=HotelBookingSystem; integrated security = True");
        public ucBookRoom()
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

        private void ucBookRoom_Load(object sender, EventArgs e)
        {
            cbHotel.Items.Clear();
            cbLodger.Items.Clear();
            setComboBox("select title from hotel", cbHotel);
            setComboBox("select fio from lodger", cbLodger);
            guna2DataGridView1.DataSource = adapter.GetData();
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("BookRoom", con);
            command.CommandType = CommandType.StoredProcedure;

            int price = func.getPrice("select price_per_day from room where roomNo = " + cbRoom.Text + " and hotel_id = " + (cbHotel.SelectedIndex + 1) + "");
            // задаем параметры хранимой процедуры
            command.Parameters.AddWithValue("@lodger_id", cbLodger.SelectedIndex+1);
            command.Parameters.AddWithValue("@room_id", roomId);
            command.Parameters.AddWithValue("@hotel_id", cbHotel.SelectedIndex + 1);
            command.Parameters.AddWithValue("@checkIn_date", Convert.ToDateTime(dtCheckIn.Text));
            command.Parameters.AddWithValue("@checkOut_date", Convert.ToDateTime(dtCheckOut.Text));

            // задаем выходной параметр хранимой процедуры
            SqlParameter discountParameter = command.Parameters.Add("@discount", SqlDbType.Float);
            discountParameter.Direction = ParameterDirection.Output;

            // вызываем хранимую процедуру
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Room booked successfully!");
                if ((double)discountParameter.Value > 0)
                {
                    func.setData("update checkIn set total_cost = total_cost * " + 0.9 + " where lodger_id = " + (cbLodger.SelectedIndex+1) + "", "Discount applied!");
                }
                func.setData("update room set booked = " + 1 + " where roomNo = '" + cbRoom.Text + "'", "Посетитель заселен");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
            // закрываем подключение
            con.Close();
            ucBookRoom_Load(this, null);
        }
        int roomId;
        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomId = func.getPrice("select id from room where roomNo = '" + cbRoom.Text + "'");
        }

        private void cbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoom.Items.Clear();
            setComboBox("select roomNo from room where hotel_id = " + (cbHotel.SelectedIndex + 1) + " and room_type_id = " + 2 + " and booked = " + 0 + "", cbRoom);
        }
    }
}
