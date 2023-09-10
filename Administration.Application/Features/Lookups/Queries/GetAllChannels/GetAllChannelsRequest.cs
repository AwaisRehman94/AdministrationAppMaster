using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using Common.Domain.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Features.Lookups.Queries.GetAllChannels
{
    public class GetAllChannelsRequest : IRequest<Result<List<GetAllChannelsResponse>>>
    {
        public string language { get; set; } = "en";
    }
}
