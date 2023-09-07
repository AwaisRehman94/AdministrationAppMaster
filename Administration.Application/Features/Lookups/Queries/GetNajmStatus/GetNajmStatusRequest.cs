using Common.Domain.Common.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Features.Lookups.Queries.GetNajmStatus
{
    public class GetNajmStatusRequest : IRequest<Result<List<GetNajmStatusResponse>>>
    {
        public int pageIndex { get; set; } = 0;
            
        public int pageSize { get; set; } = 0;

        public string sortField { get; set; } = "id";
        public bool sortOrder { get; set; } = false;
    }
}
