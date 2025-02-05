using Domain.Entities;
using Domain.Helpers;
using System;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ILookupRepository
    {
        Task<Vaccin> GetVaccinByIdQuery(Guid? id);
        Task<Vaccin> DeleteVaccinByIdCommand(Vaccin vaccin);
        Task<Vaccin> UpdateVaccinByIdCommand(Vaccin vaccin);
        Task<Vaccin> CreateNewVaccinCommand(Vaccin vaccin);
        Task<PagedList<Vaccin>> GetAllVaccinsQuery(QueryStringParameters queryString);
    }
}
