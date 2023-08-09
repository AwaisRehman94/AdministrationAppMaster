using GlobalCommon.Application.Interfaces.Persistence;
using GlobalCommon.Domain.Entities;
using GlobalCommon.Infrastructure.Persistence;
using GlobalCommon.Infrastructure.Repositories;
using Inquiry.Application.Common.Interfaces;
using Inquiry.Application.Features.Lookups.Queries.GetBenefits;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiry.Infrastructure.Repositories
{
    public class BenefitRepository : RepositoryBase<AutoleasingBenefit>, IAutoleasingBenefitRepository
    {
        public BenefitRepository(CommonDbContext commonDbContext) : base(commonDbContext)
        {

        }

        public async Task<List<AutoleasingBenefit>> GetBenefits()
        {
            var result = await _commonDbContext.AutoleasingBenefit.ToListAsync();
            return result;
        }
    }
}