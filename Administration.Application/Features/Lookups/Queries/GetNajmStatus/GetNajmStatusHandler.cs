using MediatR;
using AutoMapper;
using MediatR;

using Common.Domain.Common.Models;
using Administration.Application.Common.Interfaces;

namespace Administration.Application.Features.Lookups.Queries.GetNajmStatus
{
    public class GetNajmStatusHandler : IRequestHandler<GetNajmStatusRequest, Result<List<GetNajmStatusResponse>>>
    {
        private readonly INajmStatusService _najmStatusService;
        private readonly IMapper _mapper;
        public GetNajmStatusHandler(INajmStatusService najmStatusService, IMapper mapper)
        {

            _najmStatusService = najmStatusService;
            _mapper = mapper;
        }

        public async Task<Result<List<GetNajmStatusResponse>>> Handle(GetNajmStatusRequest request, CancellationToken cancellationToken)
        {
            Result<List<GetNajmStatusResponse>> result = new Result<List<GetNajmStatusResponse>>();
            result.ErrorDescription = "Success";
            result.ErrorCode = 1;

            result.Data = await _najmStatusService.GetNajmStatusAsync(request);
            return result;
        }
    }
}
