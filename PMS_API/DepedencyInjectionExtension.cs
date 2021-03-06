using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PMS_Business;
using PMS_Models;
using PMS_Business.Implementations;
using PMS_Business.Interfaces;
using PMS_API.Services;

namespace PMS_API
{
    public static class DepedencyInjectionExtension
    {
        public static IServiceCollection RegisterAPIDependencies(this IServiceCollection services)
        {
            services.RegisterBusinessDependencies();
            services.AddTransient<IPatientBusiness,PatientBusiness>();
            services.AddTransient<IUserBusiness, UserBusiness>();
            
            return services;
        }
    }
}
