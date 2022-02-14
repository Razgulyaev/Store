using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewStore.TableUsers;

namespace NewStore
{
    public partial class Form1 : Form
    {
        Handler handler;
        List<Items> listItems;
        ItemUsers users;
        public Form1()
        {
            InitializeComponent();
            listItems = new List<Items>();
            handler = new Handler();
            users = new ItemUsers();
            handler.ConnectionOpen();
            Button_Admin_Entry.Visible = false;
            button10.Visible = false;
            label_hi.Visible = false;
            comboBox1.Items.Add("Все");
            comboBox2.Items.Add("Все");
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            foreach (var item in handler.ShowList())
            {
                listBox1.Items.Add(item.ToString());
                listItems.Add(item);
                if (!comboBox1.Items.Contains(item.Provider))
                    comboBox1.Items.Add(item.Provider);
                if (!comboBox2.Items.Contains(item.Сategory))
                    comboBox2.Items.Add(item.Сategory);
            }
            
        }
        public void Help()
        {
            users = new ItemUsers();
        }

        private void Button_Admin_Entry_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in listItems)
            {

                if (listItems.IndexOf(item) == listBox1.SelectedIndex)
                {
                    using (var ms = new MemoryStream(item.Image))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        bool status = false;
        private void Button_Sort_All_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listItems = handler.SortList(0, ref status);
            comboBox1.Items.Add("Все");
            comboBox2.Items.Add("Все");
            foreach (var item in listItems)
            {
                listBox1.Items.Add(item.ToString());
                if (!comboBox1.Items.Contains(item.Provider))
                    comboBox1.Items.Add(item.Provider);
                if (!comboBox2.Items.Contains(item.Сategory))
                    comboBox2.Items.Add(item.Сategory);
            }
        }
        private void Button_Sort_Data_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            listItems = handler.SortList(Sort_Options.Date,ref status);
            foreach (var item in listItems)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void Button_Sort_Alphabet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listItems = handler.SortList(Sort_Options.Alphabet, ref status);
            foreach (var item in listItems)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void Button_Sort_Weight_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listItems = handler.SortList(Sort_Options.Weight, ref status);
            foreach (var item in listItems)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void Button_Sort_Price_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listItems = handler.SortList(Sort_Options.Price, ref status);
            foreach (var item in listItems)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > numericUpDown2.Value) return;
            listBox1.Items.Clear();
            listItems = handler.Search(numericUpDown1.Value,numericUpDown2.Value,comboBox2.Text,comboBox1.Text);
            foreach (var item in listItems)
            {
                listBox1.Items.Add(item.ToString());
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            UsersAuthorization usersAuthorization = new UsersAuthorization();
            usersAuthorization.Owner = this;
            usersAuthorization.ShowDialog();

            
        }
        public void Ex(object obj)
        {
            users = (ItemUsers)obj;
            button8.Visible = false;
            button9.Visible = false;
            label_hi.Text = $"Здравствуйте: {users.FirstName} {users.LastName}!";
            button10.Visible = true;
            label_hi.Visible = true;
            if (users.AdminStatusCheck() == true) Button_Admin_Entry.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            UsersRegistration usersRegistration = new UsersRegistration();
            usersRegistration.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            handler.Deispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = false;
            label_hi.Visible = false;
            if (users.AdminStatusCheck() == true) Button_Admin_Entry.Visible = false;
            users = null;
        }
    }
}
