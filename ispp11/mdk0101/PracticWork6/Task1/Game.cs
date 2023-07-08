using System;
using System.ComponentModel;
using System.Windows;

namespace Task1
{
    class Game : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;
                switch (columnName)
                {
                    case "SalePercent":
                        if (SalePercent >= 30 || SalePercent <= 1)
                            error = "Неверная скидка";
                        break;
                    case "Price":
                        if (Price < 0)
                            error = "Цена указана не верно";
                        break;
                    case "Name":
                        if (Name.Length < 2)
                            error = "Ошибка в имени";
                        break;
                }
                return error;
            }
        }



        public int IdGame { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category GameCategory { get; set; }
        public double Price { get; set; }
        public byte SalePercent { get; set; }

        public string Error => throw new NotImplementedException();
    }
}
