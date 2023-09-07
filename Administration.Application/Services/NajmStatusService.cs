using Administration.Application.Common.Interfaces;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Common.Application.Common.Interfaces.Persistence;
using Common.Application.Common.Mappings;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using Common.Domain.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application.Services
{
    public class NajmStatusService : INajmStatusService
    {
        private readonly IRepository<NajmStatus> _najmStatusRepository;
        private readonly IMapper _mapper;
        public NajmStatusService(IRepository<NajmStatus> najmStatusRepository, IMapper mapper)
        {
            _najmStatusRepository = najmStatusRepository;
            _mapper = mapper;
        }

        public async Task<List<GetNajmStatusResponse>> GetNajmStatusAsync(GetNajmStatusRequest request)
        {

            var _result = await _najmStatusRepository.TableNoTracking
                  //.Select(
                  //x => new GetNajmStatusResponse()
                  //{
                  //    Id = Convert.ToInt32(x.Id),
                  //    Code = x.Code,
                  //    NameAr = x.NameAr,
                  //    NameEn = x.NameEn
                  //}
                  //)
                  .ProjectTo<GetNajmStatusResponse>(_mapper.ConfigurationProvider).PaginatedListAsync(request.pageIndex, request.pageIndex*request.pageSize);
                  
            return _result.Items;
        }
    }
}
