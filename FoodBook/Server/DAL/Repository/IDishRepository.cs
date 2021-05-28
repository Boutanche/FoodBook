﻿using BO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IDishRepository : IGenericRepository<Dish>

    {
        Task<Dish> GetAsyncByName(string name);
    }
}
