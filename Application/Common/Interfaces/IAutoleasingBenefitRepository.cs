using GlobalCommon.Application.Interfaces.Persistence;
using GlobalCommon.Domain.Entities;
using Inquiry.Application.Features.Lookups.Queries.GetBenefits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiry.Application.Common.Interfaces
{
    public interface IAutoleasingBenefitRepository : IRepository<AutoleasingBenefit>  
    {
        Task<List<AutoleasingBenefit>> GetBenefits();
    }
}
