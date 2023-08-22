using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem.User_Controls
{
    public partial class UCAddCheckIn : UserControl
    {
        HotelBookingSystemEntities db;
        Func func = new Func();
        checkIn checkIn = new checkIn();
        room r = new room();
        String query;
        

        public UCAddCheckIn()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            cbLodger.SelectedIndex = -1;
            cbHotel.SelectedIndex = -1;
            cbRoomNo.SelectedIndex = -1;
            dtCheckIn.Value = System.DateTime.Now;
            dtCheckOut.Value = System.DateTime.Now;
            label13.Text = "Цена: ";
        }

        public double GetDays(string date1, string date2)
        {
            DateTime start = DateTime.Parse(date1);
            DateTime end = DateTime.Parse(date2);

            return (end - start).TotalDays;
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

        private void UCAddCheckIn_Load(object sender, EventArgs e)
        {
            db = new HotelBookingSystemEntities();
            DataSet ds = func.getData("select fio 'Фио', roomNo 'Номер комнаты', title 'Отель', checkIn_date 'Дата заезда', checkOut_date 'Дата отъезда', total_cost 'Общая стоимость проживания' from checkIn join room on room_id = room.id join lodger on lodger_id = lodger.id join hotel on room.hotel_id = hotel.id ");
            guna2DataGridView1.DataSource = ds.Tables[0];
            cbLodger.Items.Clear();
            cbHotel.Items.Clear();
            cbRoomType.Items.Clear();
            setComboBox("select type_title from roomType", cbRoomType);
            setComboBox("select fio from lodger", cbLodger);
            setComboBox("select title from hotel", cbHotel);
        }

        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRoomNo.Items.Clear();
            query = "select roomNo from room where hotel_id = '"+ (cbHotel.SelectedIndex + 1) + "' and room_type_id = '"+ (cbRoomType.SelectedIndex + 1) + "' and booked = " + 0 + "";
            setComboBox(query, cbRoomNo);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if(cbHotel.Text != "" && cbRoomType.Text != "" && cbLodger.Text != "" && cbRoomNo.Text != "")
            {
                checkIn.lodger_id = cbLodger.SelectedIndex + 1;
                checkIn.hotel_id = cbHotel.SelectedIndex + 1;
                checkIn.room_id = roomId;
                checkIn.checkIn_date = Convert.ToDateTime(dtCheckIn.Text);
                checkIn.checkOut_date = Convert.ToDateTime(dtCheckOut.Text);
                int price = func.getPrice("select price_per_day from room where roomNo = " + cbRoomNo.Text + " and hotel_id = " + (cbHotel.SelectedIndex + 1) + "");
                checkIn.total_cost = (GetDays(dtCheckIn.Text, dtCheckOut.Text) * price);
                int logId = func.getPrice("select id from lodger where lodger.id = " + (cbLodger.SelectedIndex + 1) + "");
                db.checkIn.Add(checkIn);
                func.setData("update room set booked = "+ 1 +" where roomNo = '"+ cbRoomNo.Text +"'", "Посетитель заселен");
                db.SaveChanges();
                

                clearAll();
                UCAddCheckIn_Load(this, null);
                var dtstart = Convert.ToDateTime(dtCheckIn.Text).ToShortDateString();
                var dtend = Convert.ToDateTime(dtCheckOut.Text).ToShortDateString();
                var days = (Convert.ToDateTime(dtend) - Convert.ToDateTime(dtstart)).Days;
                var fullPr = days * price;
                var word = new Wordhelp("Отчет.docx");
                var items = new Dictionary<string, string>
                {
                    {"{acnumber}", rnd.Next(1000, 30000).ToString()},
                        {"{nowDate}", DateTime.Now.ToString()},
                        {"{custname}", cbLodger.Text},
                        {"{selfid}", (cbLodger.SelectedIndex+1).ToString()},
                        {"{dateIn}", dtCheckIn.Text},
                        {"{dateOut}", dtCheckOut.Text},
                        {"{roomNo}", cbRoomNo.Text},
                        {"{dayCount}", days.ToString()},
                        {"{price}",price.ToString()},
                        {"{fullPr}", fullPr.ToString()}
                };
                word.Process(items);
                MessageBox.Show("Отчет создан", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UCAddCheckIn_Enter(object sender, EventArgs e)
        {
            UCAddCheckIn_Load(this, null);
        }

        private void UCAddCheckIn_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
        int roomId;
        private void cbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Text += func.getPrice("select price_per_day from room where roomNo = '" + cbRoomNo.Text + "'").ToString();
            roomId = func.getPrice("select id from room where roomNo = '" + cbRoomNo.Text + "'");
        }

    }
}
