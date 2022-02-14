using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewStore
{
    internal class Handler : SqlConnectionDataBase, ISkeletonNewStore<Items>
    {
        private List<Items> _list;
        SqlDataAdapter adapter;
        DataSet data;
        public Handler() : base("Store")
        {
            _list = new List<Items>();
        }

        public bool AddImage(int value)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Всё|*|PNG|*.png|JPG|*.jpg|GIF|*.gif";
            openFile.FileName = @"";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                byte[] arraychik = File.ReadAllBytes(openFile.FileName);
                string insert = $"UPDATE Products SET [Image] = (@IMAGE) WHERE {value} = Id;";
                SqlCommand command = new SqlCommand(insert, _connection);
                command.Parameters.Add("@IMAGE", System.Data.SqlDbType.Image, arraychik.Length).Value = arraychik;
                command.ExecuteNonQuery();
                return true;

            }
            return false;
        }

        public void Deispose()
        {
            _connection.Close();
        }
        public void ConnectionOpen()
        {
            _connection.Open();
        }

        // подключается к таблице с продуктами и возвращает таблицу продуктов для DataGridV
        // сработает в случае загрузки формы администратора
        public DataSet DownloadDatabase()
        {
            string select = "select * from Products;";
            using (SqlCommand command = new SqlCommand(select, _connection))
            using (adapter = new SqlDataAdapter(command))
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                data = new DataSet();
                adapter.Fill(data);
            }
            return data;
        }

        // подключается к таблице с продуктами и возвращает список продуктов без всяких сортировок
        public List<Items> ShowList()
        {
            string select = "select * from Products";
            using (SqlCommand command = new SqlCommand(select, _connection))
            using (var table = command.ExecuteReader())
            {
                while (table.Read())
                {


                    byte[] _image = new byte[52428800];
                    table.GetBytes(7, 0, _image, 0, 52428800);

                    var itm = new Items(table.GetInt32(0), table.GetString(1), table.GetString(2), table.GetDateTime(3), table.GetString(4), table.GetDecimal(5), table.GetDecimal(6), _image);
                    if (!_list.Contains(itm))
                    {
                        _list.Add(itm);
                    }

                }
            }
                
            return _list;
        }



        // Сортирует список товаров по одному из условий, имеет переменную "status" для сортировки в большую или меньшую сторону
        public List<Items> SortList(Sort_Options value, ref bool status)
        {
            if(value == Sort_Options.Date && status == false)
            {
                status = true;
                var res = from x in _list orderby x.Date select x;
                return res.ToList();
            }
            if(value == Sort_Options.Date && status == true)
            {
                status = false;
                var res = from x in _list orderby x.Date descending select x;
                return res.ToList();
            }
            if (value == Sort_Options.Alphabet && status == false)
            {
                status = true;
                var res = from x in _list orderby x.Name select x;
                return res.ToList();
            }
            if (value == Sort_Options.Alphabet && status == true)
            {
                status = false;
                var res = from x in _list orderby x.Name descending select x;
                return res.ToList();
            }
            if (value == Sort_Options.Weight && status == false)
            {
                status = true;
                var res = from x in _list orderby x.Weight select x;
                return res.ToList();
            }
            if (value == Sort_Options.Weight && status == true)
            {
                status = false;
                var res = from x in _list orderby x.Weight descending select x;
                return res.ToList();
            }
            if (value == Sort_Options.Price && status == false)
            {
                status = true;
                var res = from x in _list orderby x.Price select x;
                return res.ToList();
            }
            if (value == Sort_Options.Price && status == true)
            {
                status = false;
                var res = from x in _list orderby x.Price descending select x;
                return res.ToList();
            }
            else
            {
                var res = from x in _list select x;
                return res.ToList();
            }
        }

        // Search поиск товаров по определенным критериям, возвращает список товаров подходящих по критериям или не измененный список
        public List<Items> Search(decimal PriceX, decimal PriceY, string Category, string Provider)
        {
            if (PriceX >= 1 && PriceX <= PriceY && PriceY != 1 && Category == "Все" && Provider == "Все")
            {
                var res = from x in _list where x.Price >= PriceX && x.Price <= PriceY select x;
                return res.ToList();
            }
            if (PriceX == 1 && PriceY == 1 && Category == "Все" && Provider != "Все")
            {
                var res = from x in _list where x.Provider == Provider select x;
                return res.ToList();
            }
            if (PriceX == 1 && PriceY == 1 && Category != "Все" && Provider == "Все")
            {
                var res = from x in _list where x.Сategory == Category select x;
                return res.ToList();
            }
            if (PriceX == 1 && PriceY == 1 && Category != "Все" && Provider != "Все")
            {
                var res = from x in _list where x.Сategory == Category && x.Provider == Provider select x;
                return res.ToList();
            }
            if (PriceX >= 1 && PriceX <= PriceY && PriceY != 1 && Category != "Все" && Provider != "Все")
            {
                var res = from x in _list where x.Сategory == Category && x.Provider == Provider && x.Price >= PriceX && x.Price <= PriceY select x;
                return res.ToList();
            }
            if (PriceX >= 1 && PriceX <= PriceY && PriceY != 1 && Category != "Все" && Provider == "Все")
            {
                var res = from x in _list where x.Сategory == Category && x.Price >= PriceX && x.Price <= PriceY select x;
                return res.ToList();
            }
            if (PriceX >= 1 && PriceX <= PriceY && PriceY != 1 && Category == "Все" && Provider != "Все")
            {
                var res = from x in _list where x.Provider == Provider && x.Price >= PriceX && x.Price <= PriceY select x;
                return res.ToList();
            }
            var result = from x in _list select x;
                return result.ToList();
        }


        public bool UpLoadDatabase(DataSet data)
        {
            string select = $"select * from Products;";
            using(SqlCommand command = new SqlCommand(select, _connection))
            using(adapter = new SqlDataAdapter(command))
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int value = 0;
                adapter.Fill(data);
                value = adapter.Update(data);
                if (value > 0) return true;
                return false;
            }
                
        }
    }
}

enum Sort_Options
{
    Date, Alphabet, Weight, Price
}
