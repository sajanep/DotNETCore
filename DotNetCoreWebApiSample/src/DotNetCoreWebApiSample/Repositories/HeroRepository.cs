using DotNetCoreWebApiSample.Data;
using DotNetCoreWebApiSample.Models;
using Microsoft.EntityFrameworkCore;
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
            return heroContext.Set<Hero>().ToList();
        }

        public Hero Find(int id)
        {
            return heroContext.Set<Hero>().Find(id);
        }

        public void Add(Hero item)
        {
            heroContext.Set<Hero>().Add(item);
            heroContext.SaveChanges();
        }
              
        public void Update(Hero item)
        {
            heroContext.Set<Hero>().Attach(item);
            heroContext.Entry(item).State = EntityState.Modified;
            heroContext.SaveChanges();
        }

        public Hero Remove(int id)
        {
            var heroToDelete = heroContext.Set<Hero>().Find(id);
            heroContext.Set<Hero>().Attach(heroToDelete);
            heroContext.Entry(heroToDelete).State = EntityState.Deleted;
            heroContext.SaveChanges();
            return heroToDelete;
        }
    }
}
