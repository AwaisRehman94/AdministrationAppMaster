using Administration.Application.Common.Interfaces;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus_SP;
using Administration.Application.Features.Lookups.Queries.GetNajmStatusByID_SP;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Common.Application.Common.Interfaces.Persistence;
using Common.Application.Common.Mappings;
using Common.Domain.Common.Models;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using Common.Domain.Models;
using Common.Infrastructure.Persistence;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Dapper;
using IdentityModel.Client;
using System.Reflection.PortableExecutable;

namespace Administration.Application.Services
{
    public class NajmStatusService : INajmStatusService
    {
        private readonly IRepository<NajmStatus> _najmStatusRepository;
        private readonly IMapper _mapper;
        private readonly CommonDbContext _commonDb;
        private readonly DapperContext _dapperContext;
        public NajmStatusService(IRepository<NajmStatus> najmStatusRepository, IMapper mapper, CommonDbContext commonDb, DapperContext dapperContext)
        {
            _najmStatusRepository = najmStatusRepository;
            _mapper = mapper;
            _commonDb = commonDb;
            _dapperContext = dapperContext;
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


        public async Task<List<NajmStatus>> GetNajmStatus_SP(GetNajmStatus_SP_Request    request) {

            var najm = _commonDb.NajmStatus.FromSql($"GetNajmStatus").ToList();
            return najm;
        }

        public async Task<List<NajmStatus>> GetNajmStatusByID_SP(GetNajmStatusByID_SP_Request request)
        {
            int Id = request.Id;
            var obj = _commonDb.NajmStatus.FromSqlInterpolated($"GetNajmStatusByID {Id}").ToList();
            return obj;
        }


        public async Task<List<NajmStatus>> GetNajmStatus_SP_usingDapper(GetNajmStatus_SP_Request request)
        {
            
            using (var connection = _dapperContext.CreateConnection())
            {
                var restult = await connection.QueryAsync<NajmStatus>("GetNajmStatus", commandType: System.Data.CommandType.StoredProcedure); 
                return restult.ToList();
            }
        }


        public async Task<NajmStatus> GetNajmStatusByID_SP_usingDapper(GetNajmStatusByID_SP_Request request)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var restult = await connection.QueryAsync<NajmStatus>("GetNajmStatusByID", new { Id = request.Id},commandType: System.Data.CommandType.StoredProcedure);
                return restult.FirstOrDefault();
            }
        }


        public async Task<NajmStatus> GetNajmStatusByID_SP_TEST_usingDapper(GetNajmStatusByID_SP_Request request)
        {
            using (var connection = _dapperContext.CreateConnection())
            {
                var reader = await connection.QueryMultipleAsync("GetNajmStatusByID_TEST",  commandType: System.Data.CommandType.StoredProcedure);
                var najmStatusResult = await reader.ReadAsync<NajmStatus>(); //reader.Read<NajmStatus>().ToList();
                var addressResult = await reader.ReadAsync();// reader.Read<Address>().ToList();
                
                return new NajmStatus();
            }
        }

    }
}
