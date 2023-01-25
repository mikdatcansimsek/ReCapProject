using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarTest();

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.BrandName + "/" + 
                    item.Model + "/" + item.ColorName + "/" + 
                    item.DailyPrice + "/" + item.Description );
            }
        }
    }
}