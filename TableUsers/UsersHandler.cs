using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStore.TableUsers
{
    internal class UsersHandler : SqlConnectionDataBase
    {
        private ItemUsers obj_User;
        SqlDataAdapter adapter;
        DataSet data;
        public UsersHandler() : base("Store") // подключение к бд через обстрактный класс
        {
            
        }

        // метод обновления списка пользователей
        public bool UpLoadDatabase(DataSet data)
        {
            string select = $"select * from UsersTable;";
            using (SqlCommand command = new SqlCommand(select, _connection))
            using (adapter = new SqlDataAdapter(command))
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                int value = 0;
                adapter.Fill(data);
                value = adapter.Update(data);
                if (value > 0) return true;
                return false;
            }
        }

        // метод загрузки всех зарегестрированных пользователей в таблицу
        public DataSet DownloadDatabase()
        {
            string select = "select * from UsersTable;";
            using (SqlCommand command = new SqlCommand(select, _connection))
            using (adapter = new SqlDataAdapter(command))
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                data = new DataSet();
                adapter.Fill(data);
            }
            return data;
        }

        // метод создания нового пользователя
        public bool CreateNewUsers(string FirstName, string Lastname, string login, string password)
        {
            // данный запрос осуществляет проверку на наличие уникального логина в базе, если пользователь найден, возвращает лож
            string querycheck = $"select * from [UsersTable] where [Login] = '{login}'";
            using (SqlCommand command = new SqlCommand(querycheck, _connection))
            {
                using (var res = command.ExecuteReader())
                {
                    while (res.Read())
                    {
                        return false;
                    }
                }
            }

            // если проверка не обноружила совпадения по логину, регестрирует нового пользователя возвращая правду, в противном случае возвращает лож
            string query = $"insert into [UsersTable] values ('{FirstName}','{Lastname}','{login}','{password}',0);";
            if (login.Length < 4 && password.Length < 6) return false;
            using (SqlCommand sqlCommand = new SqlCommand(query, _connection))
            {
                if (sqlCommand.ExecuteNonQuery() == 1) return true;
                else return false;
            }

        }

        // метод входа пользователя в свой акк, если логин и пароль совпадут, вернет объект пользователя
        public ItemUsers Entrance(string login, string password)
        {
            _connection.Open();
            obj_User = new ItemUsers();
            string query = $"select * from [UsersTable] where [Login] = '{login}' and [Password] = '{password}';";
            using (SqlCommand sqlCommand = new SqlCommand(query, _connection))
            {
                var read = sqlCommand.ExecuteReader();
                while (read.Read())
                {
                    obj_User = new ItemUsers(read.GetInt32(0), read.GetString(1), read.GetString(2), read.GetString(3),read.GetInt32(5));
                    
                }
            }
            return obj_User;
        }

        public void Deispose()
        {
            // отключение от бд
            _connection.Close();
        }
        public void ConnectionOpen()
        {
            // подключение к бд
            _connection.Open();
        }
    }
}
