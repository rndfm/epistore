using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EpiStore.Core.Entities;
using EpiStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EpiStore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly EpiStoreDbContext _dbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, EpiStoreDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _dbContext.Database.EnsureCreated();

            Cart cart = new Cart();
            cart.Created = DateTime.Now;
            cart.Modified = DateTime.Now;
            cart.LastAccessed = DateTime.Now;
            
            _dbContext.Carts.Add(cart);
            _dbContext.SaveChanges();

            var id = cart.Id;

            var inter = new EpiStore.Services.Inter();
            var i = id;
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = i,
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
