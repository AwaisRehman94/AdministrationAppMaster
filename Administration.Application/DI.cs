﻿using Administration.Application.Common.Interfaces;
using Administration.Application.Services;
using Common.Domain.DomainEntities.Entities.DomainEntities;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Administration.Application
{
    public static class DI
    {
        public static IServiceCollection AddAdminstrationApplication(this IServiceCollection services)
        {

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            services.AddTransient<INajmStatusService, NajmStatusService>();
            services.AddTransient<IInsuranceCompanyService, InsuranceCompanyService>();
            services.AddTransient<IProductTypeService, ProductTypeService>();
            return services;
        }
    }
}
