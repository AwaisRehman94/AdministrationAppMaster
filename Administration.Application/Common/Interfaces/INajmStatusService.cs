using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Common.Interfaces
{
    public interface INajmStatusService
    {
        public Task<List<GetNajmStatusResponse>> GetNajmStatusAsync(GetNajmStatusRequest request);

    }
}
