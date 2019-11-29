using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyApi.Core.Models;
using MyApi.Data;
using MyApi.Services.Camp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Services
{
    public class CampService:ICampService
    {
        private readonly Campcontext _campContext;
        private readonly IMapper _mapper;

        public CampService(Campcontext campContext, IMapper mapper)
        {
            _campContext = campContext;
            _mapper = mapper;
        }
        public async Task<CampResource[]> GetAllCampsAsync()
        {
            var result = await _campContext.Camps.ToListAsync();
            return _mapper.Map<CampResource[]>(result);
           
        }

        public async Task<CampResource> GetCampAsync(string moniker)
        {
            var result = await _campContext.Camps.Where(x => x.Moniker.Equals(moniker)).FirstOrDefaultAsync();
           // if(result != null)
            return _mapper.Map<CampResource>(result);
        }

        //public async Task<Camp>
    }


    
}
