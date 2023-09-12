using Administration.Application.Common.Interfaces;
using Administration.Application.Features.Lookups.Queries.GetNajmStatusByID_SP;
using AutoMapper;
using Common.Domain.Common.Models;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Features.Lookups.Queries.GetNajmStatus_SP
{
    internal class GetNajmStatus_SP_Handler : IRequestHandler<GetNajmStatus_SP_Request, Result<List<NajmStatus>>>
    {
        private readonly INajmStatusService _najmStatusService;
        private readonly IMapper _mapper;


        public GetNajmStatus_SP_Handler(INajmStatusService najmStatusService, IMapper mapper)
        {

            _najmStatusService = najmStatusService;
            _mapper = mapper;
        }

        public async Task<Result<List<NajmStatus>>> Handle(GetNajmStatus_SP_Request request, CancellationToken cancellationToken)
        {
            Result<List<NajmStatus>> result = new Result<List<NajmStatus>>();
            result.ErrorDescription = "Success";
            result.ErrorCode = 1;

            result.Data = await _najmStatusService.GetNajmStatus_SP_usingDapper(request); 
            return result;
        }



    }
}
