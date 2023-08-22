using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class TurAgentReg : Form
    {
        Func func = new Func();
        HotelBookingSystemEntities db = new HotelBookingSystemEntities();
        UsersAc users = new UsersAc();
        public TurAgentReg()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            String query = "select * from UsersAc";
            if (tbLogin.Text != "" && tbPassword.Text != "")
            {
                if (func.getUserInfo(query, 1, 2).Item1 == tbLogin.Text)
                {
                    MessageBox.Show("Администратор с данным логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    users.userLogin = tbLogin.Text.Trim();
                    users.userPassword = tbPassword.Text.Trim();
                    db.UsersAc.Add(users);
                    db.SaveChanges();
                    MessageBox.Show("Руководитель зарегистрирован", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TurAgentForm form1 = new TurAgentForm();
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
            TurAgentLog log = new TurAgentLog();
            this.Hide();
            log.Show();
        }
    }
}
