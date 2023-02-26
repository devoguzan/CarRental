using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

BrandManager brandManager = new BrandManager(new EfBrandDal());
ColorManager colorManager = new ColorManager(new EfColorDal());
CarManager carManager = new CarManager(new EfCarDal());

//Car car1 = new Car() { Id=1,BrandId=1,ColorId=1,DailyPrice=200,ModelYear=2020,Description="Toyota"};
//Car car2 = new Car() { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 300, ModelYear = 2021, Description = "Opel" };
//Car car3 = new Car() { Id = 3, BrandId = 3, ColorId = 1, DailyPrice = 400, ModelYear = 2022, Description = "Ford" };

//Brand brand1 = new Brand() {BrandId=1,BrandName="Corolla" };
//Brand brand2 = new Brand() { BrandId = 2, BrandName = "Astra" };
//Brand brand3 = new Brand() { BrandId = 3, BrandName = "Focus" };

//Color color1 = new Color() { ColorId=1,ColorName= "Kırmızı" };
//Color color2 = new Color() { ColorId = 1, ColorName = "Yeşil" };
//Color color3 = new Color() { ColorId = 1, ColorName = "Mavi" };

//carManager.Add(car1);
//carManager.Add(car2);
//carManager.Add(car3);

//colorManager.Add(color1);
//colorManager.Add(color2);
//colorManager.Add(color3);

//brandManager.Add(brand1);
//brandManager.Add(brand2);
//brandManager.Add(brand3);



var result = carManager.GetCarDetails();

foreach(var car in result.Data)
{
    Console.WriteLine(car.CarName);
}