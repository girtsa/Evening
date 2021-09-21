using System;

namespace Clases
{
    public class Product
    {
        public Product(double lenght)
        {
            Lenght = lenght;
        }
        public double Size { get; set; }
        public double Lenght { get; }
        public double Width { get; set; }
        public double Hight { get; set; }
        public double Weight { get; set; }

        public string GetGoodsForProduction()
        {
            string GoodsForProduction = "";

            return GoodsForProduction;
        }
        public string GetProductData()
        {
            string ProductData = "126";

            return ProductData;
        }

    }
}
