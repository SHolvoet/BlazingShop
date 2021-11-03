using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingShop.Server.Services.StatService;

namespace BlazingShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IStatService _statService;

        public StatsController(IStatService statService)
        {
            _statService = statService;
        }

        [HttpGet]
        public async Task<ActionResult<int>> GetVisits()
        {
            return await _statService.GetVisits();
        }

        [HttpPost]
        public async Task IncrementVisits()
        {
            await _statService.IncrementVisits();
        }
    }
}
