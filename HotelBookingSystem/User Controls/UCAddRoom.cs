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
    public partial class UCAddRoom : UserControl
    {
        Func func = new Func();
        String query;
        HotelBookingSystemEntities db;
        room room = new room();
        public UCAddRoom()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            cbHotel.SelectedIndex = -1;
            cbRoomType.SelectedIndex = -1;
            tbRoomNo.Clear();
            tbPrice.Clear();
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
            if(cbHotel.Text != "" && tbRoomNo.Text != "" && cbRoomType.Text != "" && tbPrice.Text != "")
            {
                room.roomNo = tbRoomNo.Text.Trim();
                room.hotel_id = cbHotel.SelectedIndex + 1;
                room.room_type_id = cbRoomType.SelectedIndex + 1;
                room.price_per_day = Convert.ToDouble(tbPrice.Text.Trim());
                db.room.Add(room);
                db.SaveChanges();
                MessageBox.Show("Комната добавлена!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UCAddRoom_Load(this, null);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCAddRoom_Load(object sender, EventArgs e)
        {
            db = new HotelBookingSystemEntities();
            this.addRoomViewTableAdapter.Fill(this.addRoomDS.addRoomView);
            cbHotel.Items.Clear();
            cbRoomType.Items.Clear();
            query = "select title from hotel";
            setComboBox(query, cbHotel);
            setComboBox("select type_title from roomType", cbRoomType);
        }

        private void UCAddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UCAddRoom_Enter(object sender, EventArgs e)
        {
            UCAddRoom_Load(this, null);
        }
    }
}
