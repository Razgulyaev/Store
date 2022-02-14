using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStore
{
    internal class Items
    {
        // автосвойства
        public int Id { get; }
        public string Name { get; }
        public string Сategory { get; }
        public DateTime Date { get; } = new DateTime();
        public string Provider { get; }
        public decimal Price { get; }
        public decimal Weight { get; }
        public byte[] Image { get; } = new byte[52428800];

        // конструктор с 1 перегрузкой
        public Items() { }

        public Items(int Id, string Category, string Name, DateTime Data, string Provider, decimal Price, decimal Weight, byte[] Image)
        {
            this.Id = Id;
            this.Сategory = Category;
            this.Name = Name;
            this.Date = Data;
            this.Provider = Provider;
            this.Price = Price;
            this.Weight = Weight;
            this.Image = Image;
        }
        
        public override string ToString()
        {
            return string.Format("Код: {0} Категория: {2} Наименование: {1} Дата производства: {3} Производитель: {4} Цена: {5} Вес: {6}", Id, Name, Сategory, Date, Provider, Price, Weight);
        }
    }
}
