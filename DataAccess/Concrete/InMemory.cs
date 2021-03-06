﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemory : ICarDal
    {

        List<Car> _cars;

        public InMemory()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=3,ColorId=2,DailyPrice=80000,Description="Dosta gider",ModelYear=2008},
                new Car{Id=2,BrandId=2,ColorId=3,DailyPrice=140000,Description="Doktordan satılık",ModelYear=2010},
                new Car{Id=3,BrandId=1,ColorId=1,DailyPrice=35000,Description="Yakıt cimrisi",ModelYear=2015}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
