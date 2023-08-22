using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelBookingSystem
{
    public partial class AdminReg : Form
    {
        HotelBookingSystemEntities db = new HotelBookingSystemEntities();
        Admin admin = new Admin();
        Func func = new Func();
        public AdminReg()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            String query = "select * from Admin";
            if (tbLogin.Text != "" && tbPassword.Text != "")
            {
                if (func.getUserInfo(query, 1, 2).Item1 == tbLogin.Text)
                {
                    MessageBox.Show("Администратор с данным логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    admin.login = tbLogin.Text.Trim();
                    admin.password = tbPassword.Text.Trim();
                    db.Admin.Add(admin);
                    db.SaveChanges();
                    MessageBox.Show("Администратор зарегистрирован", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLog adminLog = new AdminLog();
            this.Hide();
            adminLog.Show();
        }
    }
}
