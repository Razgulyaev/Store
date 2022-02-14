using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStore
{
    internal interface ISkeletonNewStore<T> where T : class
    {
        DataSet DownloadDatabase();
        bool UpLoadDatabase(DataSet data);
        bool AddImage(int value);
        List<Items> ShowList();
        List<Items> SortList(Sort_Options value, ref bool status);
        void ConnectionOpen();
        void Deispose();
    }
}
