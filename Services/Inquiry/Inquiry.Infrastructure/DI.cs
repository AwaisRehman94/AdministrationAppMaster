
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


 using Inquiry.Application.Common.Interfaces;
using Inquiry.Application.Services;

namespace Inquiry.Infrastructure
{
    public static class DI
    {

        public static void AddInquiryPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IBenefitsService, BenefitsService>();
            services.AddTransient<IDeductibleService, DeductibleService>();
        }
    }
}