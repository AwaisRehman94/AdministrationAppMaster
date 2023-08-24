﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial interface IAutoLeasingServiceLogContextProcedures
    {
        Task<int> CompanyServicesLogFilterAsync(string companyname, string dateFrom, string dateTo, int? pageNumber, int? pageSize, int? export, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllAppNotificationLogsFromDBWithFilterResult>> GetAllAppNotificationLogsFromDBWithFilterAsync(DateTime? startDateTime, DateTime? endDateTime, string referenceId, string channel, int? isSuccess, int? isError, int? pageNumber, int? pageSize, int? export, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllSmsLogsFromDBWithFilterResult>> GetAllSmsLogsFromDBWithFilterAsync(string MobileNo, int? StatusCode, DateTime? DateFrom, DateTime? DateTo, string Method, int? PageNumber, int? PageSize, string Channel, string SMSProvider, int? export, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllSMSRenewalLogsFromDBWithFilterResult>> GetAllSMSRenewalLogsFromDBWithFilterAsync(DateTime? DateFrom, DateTime? DateTo, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> GetAVGServiceRequestResponseTimeAsync(string StartDate, string EndDate, int? SuccessCode, int? ErrorCode, int? Vehicle, int? Autolease, string InsuranceTypeId, string InsuranceCompanyId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetFromServiceLogsResult>> GetFromServiceLogsAsync(string reference, string externalId, int? companyId, string method, DateTime? startDateTime, DateTime? endDateTime, string sponsorId, int? statusCode, int? pageNumber, int? pageSize, int? export, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetInsuranceCompanyAvgResponseTimeResult>> GetInsuranceCompanyAvgResponseTimeAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetPolicyNotificationsLogResult>> GetPolicyNotificationsLogAsync(string PolicyNo, string ReferenceNo, DateTime? StartDate, DateTime? EndDate, int? PageNumber, int? PageSize, int? InsuranceCompanyId, string MethodName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetQuotationStatusResult>> GetQuotationStatusAsync(DateTime? startDateTime, DateTime? endDateTime, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> GetServiceRequestsAsync(string StartDate, string EndDate, int? SuccessCode, int? ErrorCode, string InsuranceType, int? module, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> GetServicesLogsAsync(string companyKey, string dateFrom, string dateTo, string method, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetWalaaPoliciesProcessingQueueResult>> GetWalaaPoliciesProcessingQueueAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_ServiceRequestResult>> SP_ServiceRequestAsync(string reference, string companyKey, string method, DateTime? startDateTime, DateTime? endDateTime, string nationalId, string vehicleId, string policyNo, int? statusCode, int? pageNumber, int? pageSize, int? export, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_ServiceRequest_OldResult>> SP_ServiceRequest_OldAsync(string reference, string companyKey, string method, string sratrDateString, string endDateString, string nationalId, string vehicleId, string policyNo, int? statusCode, int? pageNumber, int? pageSize, int? export, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<SP_ServiceRequestTestResult>> SP_ServiceRequestTestAsync(string reference, string companyKey, string method, DateTime? startDateTime, DateTime? endDateTime, string nationalId, string vehicleId, string policyNo, int? statusCode, int? pageNumber, int? pageSize, int? export, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<TabbyWebHookServiceRequestLogResult>> TabbyWebHookServiceRequestLogAsync(DateTime? startDateTime, DateTime? endDateTime, string nationalId, string vehicleId, string reference, int? isSuccess, int? isError, int? companyId, int? pageNumber, int? pageSize, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<V_Count_ServicesRequestResult>> V_Count_ServicesRequestAsync(string reference, string companyKey, string method, DateTime? startDateTime, DateTime? endDateTime, string nationalId, string vehicleId, string policyNo, int? statusCode, int? pageNumber, int? pageSize, int? export, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
