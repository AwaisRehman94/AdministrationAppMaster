using Administration.Application.Common.Interfaces;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using AutoMapper;
using Common.Domain.Common.Models;
using Common.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Features.Lookups.Queries.GetAllChannels
{
    public class GetAllChannelsHandler    : IRequestHandler<GetAllChannelsRequest, Result<List<GetAllChannelsResponse>>>
    {
        private readonly IMapper _mapper;
        public GetAllChannelsHandler(INajmStatusService najmStatusService, IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<Result<List<GetAllChannelsResponse>>> Handle(GetAllChannelsRequest request, CancellationToken cancellationToken)
        {
            Result<List<GetAllChannelsResponse>> result = new Result<List<GetAllChannelsResponse>>();
            result.ErrorDescription = "Success";
            result.ErrorCode = 1;
            var channelList = new List<GetAllChannelsResponse>();
            var values = Enum.GetValues(typeof(Channel));

            foreach (Channel val in values)
            {
                channelList.Add(new GetAllChannelsResponse() { Id = Convert.ToInt32(val), Name = Enum.GetName(typeof(Channel), val) });
            }

            result.Data = channelList;
            return result;
        }
    }
}
