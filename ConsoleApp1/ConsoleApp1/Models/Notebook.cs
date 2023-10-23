using System.Xml.Linq;

namespace ConsoleApp1.Models
{
    internal class Notebook : Product
    {
        private string _brand = "";
        private string _model = "";
        private int _ram;
        private int _storage;
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value >= 2)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Sayi duzgun daxil edin!!!");
                }
            }
        }
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Qiymet duz daxil edilmeyib!!!");
                }
            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (value.Length > 3 && value.Length < 30)
                {
                    _brand = value;
                }
                else
                {
                    Console.WriteLine("Ad cox qisadir!!!");
                }
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length > 0)
                {
                    _model = value;
                }
                else
                {
                    Console.WriteLine("Model duz deyil!!!");
                }
            }
        }

        public int Ram
        {
            get
            {
                return _ram;
            }
            set
            {
                if (value > 0 && value < 128)
                {
                    _ram = value;
                }
                else
                {
                    Console.WriteLine("Ram olcusu coxdur!!!");
                }
            }
        }

        public int Storage
        {
            get
            {
                return _storage;
            }
            set
            {
                if (value > 0)
                {
                    _storage = value;
                }
                else
                {
                    Console.WriteLine("Yaddas olcusu azdir!!!");
                }
            }
        }
    }
}
