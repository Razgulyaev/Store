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
    public partial class UsersAuthorization : Form
    {
        UsersHandler handler;
        
        public UsersAuthorization()
        {
            handler = new UsersHandler();
            InitializeComponent();
            handler.ConnectionOpen();
            textBox1.Text = "Введите свой логин";
            textBox2.Text = "Введите свой пароль";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            handler = new UsersHandler();
            if (textBox1.Text == "Введите свой логин" || textBox2.Text == "Введите свой пароль") return;
            if (textBox1.Text == "" || textBox2.Text == "") return;
            var res = handler.Entrance(textBox1.Text, textBox2.Text);
            if (res.Login == null) return;
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.Ex(res);
                this.Close();
            }
            

        }
        

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Location = new System.Drawing.Point(10, 89);
            button1.Size = new System.Drawing.Size(290, 46);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new System.Drawing.Point(12, 91);
            button1.Size = new System.Drawing.Size(288, 43);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void UsersAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            handler.Deispose();
        }
    }
}
