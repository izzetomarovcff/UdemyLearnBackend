using System;

namespace ders_400
{
    class Product
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!string.IsNullOrEmpty(value)){
                    _name = value;
                }else{
                    throw new Exception("name place is required!");
                }
            }
        }
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    _price = 0;
                }
                else
                {
                    _price = value;
                }
            }
        }
        public int IsApproved { get;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product();
            p.Name = "Samsung S9";
            p.Price = 2000;

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Price);

        }
    }
}
