using MainWebAPI.DbContextConfig;
using Microsoft.AspNetCore.Mvc;

namespace MainWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private DesafioContext context;

        public WeatherForecastController()
        {
            this.context = new DesafioContext();
        }

        [HttpGet]
        public string Get()
        {
            var powers = context.Powers.Select(p => p.Power_Name);

            return powers.FirstOrDefault();
        }
    }
}