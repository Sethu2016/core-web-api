using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Services.Camp.Interfaces
{
    public interface ICampService
    {
        Task<IEnumerable<MyApi.Core.Entities.Camp>> GetAllCampsAsync();
    }
}
