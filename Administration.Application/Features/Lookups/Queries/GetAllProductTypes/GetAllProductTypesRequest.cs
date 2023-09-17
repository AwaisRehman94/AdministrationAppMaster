using Administration.Application.Features.Lookups.Queries.GetAllInsuranceCompanies;
using Common.Domain.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Features.Lookups.Queries.GetAllProductTypes
{
    public class GetAllProductTypesRequest : IRequest<Result<List<GetAllProductTypesResponse>>>
    {
        public string language { get;set; }
    }
}
