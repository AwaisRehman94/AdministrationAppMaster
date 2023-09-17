
using System.Reflection;
using Administration.Application.Features.Lookups.Queries.GetAllInsuranceCompanies;
using Administration.Application.Features.Lookups.Queries.GetNajmStatus;
using AutoMapper;
using Common.Domain.DomainEntities.Entities.DomainEntities;


namespace Administration.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<NajmStatus, GetNajmStatusResponse>();
            CreateMap<InsuranceCompany, GetAllInsuranceCompaniesResponse>();
            // CreateMap<GetNajmStatusResponse, GetNajmStatusResponse>();

            ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
            
        }

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            var mapFromType = typeof(IMapFrom<>);

            var mappingMethodName = nameof(IMapFrom<object>.Mapping);

            bool HasInterface(Type t) => t.IsGenericType && t.GetGenericTypeDefinition() == mapFromType;

            var types = assembly.GetExportedTypes().Where(t => t.GetInterfaces().Any(HasInterface)).ToList();

            var argumentTypes = new Type[] { typeof(Profile) };

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);

                var methodInfo = type.GetMethod(mappingMethodName);

                if (methodInfo != null)
                {
                    methodInfo.Invoke(instance, new object[] { this });
                }
                else
                {
                    var interfaces = type.GetInterfaces().Where(HasInterface).ToList();

                    if (interfaces.Count > 0)
                    {
                        foreach (var @interface in interfaces)
                        {
                            var interfaceMethodInfo = @interface.GetMethod(mappingMethodName, argumentTypes);

                            interfaceMethodInfo?.Invoke(instance, new object[] { this });
                        }
                    }
                }
            }
        }
    }
}
