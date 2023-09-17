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
using Azure.Core;
using Administration.Application.Features.Lookups.Queries.GetAllInsuranceCompanies;

namespace Administration.Application.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly IMapper _mapper;
        private readonly CommonDbContext _commonDb;
        private readonly DapperContext _dapperContext;
        private readonly IRepository<InsuranceCompany> _insuranceCompanyRepository;
        public ProductTypeService(IRepository<InsuranceCompany> insuranceCompanyRepository, IMapper mapper, CommonDbContext commonDb, DapperContext dapperContext)
        {
            _insuranceCompanyRepository = insuranceCompanyRepository;
            _mapper = mapper;
            _commonDb = commonDb;
            _dapperContext = dapperContext;
        }

        public async Task<List<GetAllInsuranceCompaniesResponse>> GetAllInsuranceCompanies(string languange)
        {
            if (languange == "ar")
            {
                var _result =  _insuranceCompanyRepository.TableNoTracking
                    .Select(
                      x => new GetAllInsuranceCompaniesResponse()
                      {
                          Id = Convert.ToInt32(x.InsuranceCompanyId),
                          Name = x.NameAr
                      }
                      ).ProjectTo<GetAllInsuranceCompaniesResponse>(_mapper.ConfigurationProvider).ToList();
                return _result;

            }
            else {
                var _result = _insuranceCompanyRepository.TableNoTracking
                        .Select(
                          x => new GetAllInsuranceCompaniesResponse()
                          {
                              Id = Convert.ToInt32(x.InsuranceCompanyId),
                              Name = x.NameEn
                          }
                          ).ProjectTo<GetAllInsuranceCompaniesResponse>(_mapper.ConfigurationProvider).ToList();
                return _result;
            }
        }
    }
}
