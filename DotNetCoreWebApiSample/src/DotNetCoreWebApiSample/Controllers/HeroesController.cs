using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebApiSample.Repositories;
using DotNetCoreWebApiSample.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCoreWebApiSample.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
        private IHeroRepository heroRepo;

        public HeroesController(IHeroRepository heroRepo)
        {
            this.heroRepo = heroRepo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return heroRepo.GetAll();
        }

        // GET api/values/5
        /// <summary>
        /// Retrieves the Hero By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "GetHero")]
        public IActionResult Get(int id)
        {
            // We are creating a named route here with Name as "GetHero
            var item = heroRepo.Find(id);
            if(item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Hero hero)
        {
            if(hero == null)
            {
                return BadRequest();
            }

            heroRepo.Add(hero);
            return CreatedAtRoute("GetHero", new { id = hero.Id }, hero);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Hero hero)
        {
            if(hero == null || hero.Id != id)
            {
                return BadRequest();
            }

            // Call the repository update
            heroRepo.Update(hero);
            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var item = heroRepo.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            heroRepo.Remove(id);
            return new NoContentResult();
        }
    }
}
