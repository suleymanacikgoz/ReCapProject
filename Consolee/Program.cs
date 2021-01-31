using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace Consolee
{
    class Program
    {
        

        static void Main(string[] args)
        {
            CarManager carMAnager = new CarManager(new InMemory());
            foreach (var car in carMAnager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
