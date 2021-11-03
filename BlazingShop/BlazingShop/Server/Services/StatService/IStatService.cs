using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.StatService
{
    public interface IStatService
    {
        Task<int> GetVisits();
        Task IncrementVisits();
    }
}
