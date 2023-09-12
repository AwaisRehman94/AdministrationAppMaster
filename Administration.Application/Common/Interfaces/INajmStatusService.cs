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
    public interface INajmStatusService
    {

        Task<List<GetNajmStatusResponse>> GetNajmStatusAsync(GetNajmStatusRequest request);


        Task<List<NajmStatus>> GetNajmStatus_SP(GetNajmStatus_SP_Request request);


        Task<List<NajmStatus>> GetNajmStatusByID_SP(GetNajmStatusByID_SP_Request request);


        Task<List<NajmStatus>> GetNajmStatus_SP_usingDapper(GetNajmStatus_SP_Request request);

        
        Task<NajmStatus> GetNajmStatusByID_SP_usingDapper(GetNajmStatusByID_SP_Request request);

        Task<NajmStatus> GetNajmStatusByID_SP_TEST_usingDapper(GetNajmStatusByID_SP_Request request);


    }
}
