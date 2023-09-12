using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
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
    public class GetNajmStatus_SP_Request : IRequest<Result<List<NajmStatus>>>
    {
        public string Language { get; set; } = "en";

    }
}
