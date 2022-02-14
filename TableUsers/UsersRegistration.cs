using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewStore.TableUsers
{
    public partial class UsersRegistration : Form
    {
        UsersHandler handler;
        public UsersRegistration()
        {
            InitializeComponent();
            handler = new UsersHandler();
            handler.ConnectionOpen();
            textBox1.Text = "Укажите ваше Имя";
            textBox2.Text = "Укажите вашу Фамилию";
            textBox3.Text = "Придумайте логин";
            textBox4.Text = "Придумайте пароль";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(handler.CreateNewUsers(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text))
           {
                MessageBox.Show("Регистрация прошла успешно!");
                this.Close();
           }
           else MessageBox.Show("Такой пользователь уже существует!");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Size = new Size(293, 47);
            button1.Location = new Point(9, 156);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Size = new Size(289, 43);
            button1.Location = new Point(11, 158);
        }

        private void UsersRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            handler.Deispose();
        }
    }
}
