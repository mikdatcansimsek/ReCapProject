using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
                new Car() {CarId= 1, BrandId = 2, ColorId= 3, DailyPrice = 120000, Description= "Anadolu Kaplanı", ModelYear=1991 },
                new Car() {CarId= 2,BrandId = 3,ColorId= 4, DailyPrice = 300000, Description= "Gökyüzü Mavisi", ModelYear=1997},
                new Car() {CarId= 3,BrandId = 4,ColorId= 5, DailyPrice = 60000, Description = "Doğan", ModelYear = 1998},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carDelete);
        }

        public Car Gen(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int Id)
        {
            return _car.Where(p => p.CarId == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
