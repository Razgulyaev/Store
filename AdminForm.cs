using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewStore.TableUsers;

namespace NewStore
{
    public partial class AdminForm : Form
    {
        Handler _handler;
        UsersHandler usersHandler;
        DataSet _datausers;
        DataSet _data;
        public AdminForm()
        {
            InitializeComponent();
            usersHandler = new UsersHandler();
            _datausers = new DataSet();
            _handler = new Handler();
            _data = new DataSet();
            _data = _handler.DownloadDatabase();
            _datausers = usersHandler.DownloadDatabase();
            dataGridView1.DataSource = _data.Tables[0];
            dataGridView2.DataSource = _datausers.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _handler.Deispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _handler.UpLoadDatabase(_datausers);
            usersHandler.UpLoadDatabase(_datausers);
            _datausers = usersHandler.DownloadDatabase();
            dataGridView1.DataSource = _datausers.Tables[0];
            _datausers.Dispose();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            _handler.AddImage(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            _handler.ConnectionOpen();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _handler.Deispose();
        }
    }
}
