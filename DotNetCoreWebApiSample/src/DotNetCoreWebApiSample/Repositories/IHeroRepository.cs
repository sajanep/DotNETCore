﻿using DotNetCoreWebApiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiSample.Repositories
{
    public interface IHeroRepository
    {
        //void Add(Hero item);
        IEnumerable<Hero> GetAll();
        Hero Find(int id);
        //Hero Remove(int id);
        //void Update(Hero item);
    }
}
