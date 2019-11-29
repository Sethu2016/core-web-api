using MyApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Services.Camp.Interfaces
{
    public interface ICampService
    {
        Task<CampResource[]> GetAllCampsAsync();
        Task<CampResource> GetCampAsync(string moniker);
    }
}
