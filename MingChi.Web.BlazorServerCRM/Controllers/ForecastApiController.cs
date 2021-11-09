using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MingChi.Web.BlazorServerCRM.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MingChi.Web.BlazorServerCRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForecastApiController : ControllerBase
    {
        private readonly WeatherForecastService _weatherForecastService;

        public ForecastApiController(WeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            return await _weatherForecastService.GetForecastAsync(DateTime.Now);
        }
    }
}
