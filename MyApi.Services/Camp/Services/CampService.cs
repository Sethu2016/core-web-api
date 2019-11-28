using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using MyApi.Services.Camp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Services
{
    public class CampService:ICampService
    {
        private readonly Campcontext _campContext;

        public CampService(Campcontext campContext)
        {
            _campContext = campContext;
        }
        public async Task<IEnumerable<MyApi.Core.Entities.Camp>> GetAllCampsAsync()
        {
            return await _campContext.Camps.ToListAsync();
        }
    }


    
}
