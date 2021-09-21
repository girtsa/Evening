using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.CarBrand = "Volvo";
            car.NumberPlate = 4478;
            car.Speed = 170;

            string toSignaling = car.GetToSignaling();
            Console.WriteLine(toSignaling);

            {
                Product product = new Product(126);

                product.Lenght = 126;
                product.Width = 57;
                product.Hight = 210;

            }
            string productData = product.GetProductData();
            Console.WriteLine(productData);
        }

    }
}
