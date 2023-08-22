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
    public partial class UCCheckIn : UserControl
    {
        Func func = new Func();
        addCheckInViewTableAdapter addCheckInViewTableAdapter = new addCheckInViewTableAdapter();
        public UCCheckIn()
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

        private void UCCheckIn_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = addCheckInViewTableAdapter.GetData();
            setComboBox("select title from hotel", cbQuery);
        }

        private void cbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = func.getData("select fio 'Фио', roomNo 'Номер комнаты', title 'Отель', checkIn_date 'Дата заезда', checkOut_date 'Дата отъезда', total_cost 'Общая стоимость проживания' from checkIn join room on room.id = checkIn.room_id join lodger on lodger.id = lodger_id join hotel on room.hotel_id = hotel.id where checkIn.hotel_id = "+(cbQuery.SelectedIndex+1)+"");
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
