using Administration.Application.Features.Lookups.Queries.GetAllInsuranceCompanies;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus_SP;
using Administration.Application.Features.Lookups.Queries.GetNajmStatusByID_SP;
using Common.Domain.Common.Models;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Common.Interfaces
{
    public interface IProductTypeService
    {
        Task<List<GetAllInsuranceCompaniesResponse>> GetAllInsuranceCompanies(string languange);

    }
}
