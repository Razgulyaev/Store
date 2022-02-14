using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStore.TableUsers
{
    internal class ItemUsers
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Login { get; }

        private int _adminStatus;
        public ItemUsers()
        {

        }
        public ItemUsers(int Id, string FirstName, string LastName, string Login, int adm)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Login = Login;
            this._adminStatus = adm;
        }
        public bool AdminStatusCheck()
        {
            if(this._adminStatus == 0) return false;
            else return true;
        }
    }
}
