﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars= new List<Car>()
            {
                new Car() {Id=1,BrandId=1,ColorId=1,DailyPrice=300, ModelYear=2019,Description="Toyota"},
                new Car() {Id=2,BrandId=2,ColorId=1,DailyPrice=400, ModelYear=2020,Description="Audi"},
                new Car() {Id=3,BrandId=3,ColorId=2,DailyPrice=500, ModelYear=2021,Description="Bmw"},
                new Car() {Id=4,BrandId=4,ColorId=2,DailyPrice=600, ModelYear=2022,Description="Peugeot"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.Id==id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.Description=car.Description;
            carToUpdate.DailyPrice=car.DailyPrice;
        }
    }
}