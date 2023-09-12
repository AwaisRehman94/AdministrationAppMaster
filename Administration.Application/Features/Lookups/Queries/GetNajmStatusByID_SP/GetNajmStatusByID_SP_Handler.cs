using Administration.Application.Common.Interfaces;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using AutoMapper;
using Common.Domain.Common.Models;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Features.Lookups.Queries.GetNajmStatusByID_SP
{
    public class GetNajmStatusByID_SP_Handler : IRequestHandler<GetNajmStatusByID_SP_Request, Result<NajmStatus>>
    {
        private readonly INajmStatusService _najmStatusService;
        private readonly IMapper _mapper;


        public GetNajmStatusByID_SP_Handler(INajmStatusService najmStatusService, IMapper mapper)
        {

            _najmStatusService = najmStatusService;
            _mapper = mapper;
        }

        public async Task<Result<NajmStatus>> Handle(GetNajmStatusByID_SP_Request request, CancellationToken cancellationToken)
        {
            Result<NajmStatus> result = new Result<NajmStatus>();
            var test = await _najmStatusService.GetNajmStatusByID_SP_TEST_usingDapper(request);
            NajmStatus najmStatuses = new NajmStatus();
            if (najmStatuses != null)
            {
                result.ErrorDescription = "Success";
                result.ErrorCode = 1;
                result.Data = najmStatuses;
            }
            else {
                result.ErrorDescription = "No Data Available";
                result.ErrorCode = 0;
                result.Data = najmStatuses;
            }

            return result;
        }

    }
}
