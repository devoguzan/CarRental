using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new EfCarDal());

var result = carManager.GetCarDetails();

foreach(var car in result.Data)
{
    Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName);
}