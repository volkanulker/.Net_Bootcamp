﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(int id);

        List<Car> GetAll();

        void Add(Car car);

        void Update(int carId, Car updatedCar);

        void Delete(int carId);

    }
}
