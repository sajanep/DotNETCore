using DotNetCoreWebApiSample.Data;
using DotNetCoreWebApiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiSample.Repositories
{
    public class HeroRepository: IHeroRepository
    {
        private HeroContext heroContext;

        public HeroRepository(HeroContext heroContext)
        {
            this.heroContext = heroContext;
        }

        public IEnumerable<Hero> GetAll()
        {
            return heroContext.Heroes.ToList();
        }

        public Hero Find(int id)
        {
            return heroContext.Heroes.Find(id);
        }
    }
}
