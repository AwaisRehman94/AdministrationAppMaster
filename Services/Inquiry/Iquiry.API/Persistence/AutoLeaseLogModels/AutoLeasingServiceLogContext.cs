using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Inquiry.API.Persistence.AutoLeaseLogModels.Persistence.AutoLeaseLogModels
{
    public partial class AutoLeasingServiceLogContext : DbContext
    {
        public virtual DbSet<AcigpolicyServiceRequestLogs> AcigpolicyServiceRequestLogs { get; set; }
        public virtual DbSet<AcigquotationServiceRequestLogs> AcigquotationServiceRequestLogs { get; set; }
        public virtual DbSet<AddressRequestLogs> AddressRequestLogs { get; set; }
        public virtual DbSet<AdminRequestLog> AdminRequestLog { get; set; }
        public virtual DbSet<AhliaPolicyServiceRequestLogs> AhliaPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<AhliaQuotationServiceRequestLogs> AhliaQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<AiccpolicyServiceRequestLogs> AiccpolicyServiceRequestLogs { get; set; }
        public virtual DbSet<AiccquotationServiceRequestLogs> AiccquotationServiceRequestLogs { get; set; }
        public virtual DbSet<AlRajhiPolicyServiceRequestLogs> AlRajhiPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<AlRajhiQuotationServiceRequestLogs> AlRajhiQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<AlalamiyaPolicyServiceRequestLogs> AlalamiyaPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<AlalamiyaQuotationServiceRequestLogs> AlalamiyaQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<AllianzPolicyServiceRequestLogs> AllianzPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<AllianzQuotationServiceRequestLogs> AllianzQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<AmanaPolicyServiceRequestLogs> AmanaPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<AmanaQuotationServiceRequestLogs> AmanaQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<ApplepayErrorLogs> ApplepayErrorLogs { get; set; }
        public virtual DbSet<ArabianShieldPolicyServiceRequestLogs> ArabianShieldPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<ArabianShieldQuotationServiceRequestLogs> ArabianShieldQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<AutoleasingAdminRequestLog> AutoleasingAdminRequestLog { get; set; }
        public virtual DbSet<AxapolicyServiceRequestLogs> AxapolicyServiceRequestLogs { get; set; }
        public virtual DbSet<AxaquotationServiceRequestLogs> AxaquotationServiceRequestLogs { get; set; }
        public virtual DbSet<BcarePolicyServiceRequestLogs> BcarePolicyServiceRequestLogs { get; set; }
        public virtual DbSet<BcareQuotationServiceRequestLogs> BcareQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<BurujPolicyServiceRequestLogs> BurujPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<BurujQuotationServiceRequestLogs> BurujQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<CancellationServiceRequestLog> CancellationServiceRequestLog { get; set; }
        public virtual DbSet<CheckoutRequestLog> CheckoutRequestLog { get; set; }
        public virtual DbSet<CompetitionRequestLogs> CompetitionRequestLogs { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<FirebaseNotificationLog> FirebaseNotificationLog { get; set; }
        public virtual DbSet<ForbiddenRequestLogs> ForbiddenRequestLogs { get; set; }
        public virtual DbSet<GgipolicyServiceRequestLogs> GgipolicyServiceRequestLogs { get; set; }
        public virtual DbSet<GgiquotationServiceRequestLog> GgiquotationServiceRequestLog { get; set; }
        public virtual DbSet<GulfUnionPolicyServiceRequestLogs> GulfUnionPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<GulfUnionQuotationServiceRequestLogs> GulfUnionQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<IdentityRequestLog> IdentityRequestLog { get; set; }
        public virtual DbSet<InquiryRequestLog> InquiryRequestLog { get; set; }
        public virtual DbSet<IntegrationTransaction> IntegrationTransaction { get; set; }
        public virtual DbSet<IvrservicesLogs> IvrservicesLogs { get; set; }
        public virtual DbSet<LeasingAddBenefitLog> LeasingAddBenefitLog { get; set; }
        public virtual DbSet<LeasingAddDriverLog> LeasingAddDriverLog { get; set; }
        public virtual DbSet<LeasingPortalLog> LeasingPortalLog { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LoginRequestsLog> LoginRequestsLog { get; set; }
        public virtual DbSet<MalathPolicyServiceRequestLogs> MalathPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<MalathQuotationServiceRequestLogs> MalathQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<MedGulfPolicyServiceRequestLogs> MedGulfPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<MedGulfQuotationServiceRequestLogs> MedGulfQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<NajmServiceRequestLogs> NajmServiceRequestLogs { get; set; }
        public virtual DbSet<NotPurchasedQuotations> NotPurchasedQuotations { get; set; }
        public virtual DbSet<NotificationLog> NotificationLog { get; set; }
        public virtual DbSet<OwnDamageSmslog> OwnDamageSmslog { get; set; }
        public virtual DbSet<PaymentServiceRequestLogs> PaymentServiceRequestLogs { get; set; }
        public virtual DbSet<PdfGenerationLog> PdfGenerationLog { get; set; }
        public virtual DbSet<PolicyModificationLog> PolicyModificationLog { get; set; }
        public virtual DbSet<PolicyNotificationLogs> PolicyNotificationLogs { get; set; }
        public virtual DbSet<PolicyRequestLog> PolicyRequestLog { get; set; }
        public virtual DbSet<PowerBiservicesLog> PowerBiservicesLog { get; set; }
        public virtual DbSet<ProfileRequestsLog> ProfileRequestsLog { get; set; }
        public virtual DbSet<PromotionRequestLog> PromotionRequestLog { get; set; }
        public virtual DbSet<QuotationRequestLog> QuotationRequestLog { get; set; }
        public virtual DbSet<RegistrationRequestsLog> RegistrationRequestsLog { get; set; }
        public virtual DbSet<SaicopolicyServiceRequestLogs> SaicopolicyServiceRequestLogs { get; set; }
        public virtual DbSet<SaicoquotationServiceRequestLogs> SaicoquotationServiceRequestLogs { get; set; }
        public virtual DbSet<SalamaPolicyServiceRequestLogs> SalamaPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<SalamaQuotationServiceRequestLogs> SalamaQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<SaqrPolicyServiceRequestLogs> SaqrPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<SaqrQuotationServiceRequestLogs> SaqrQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<SaudiPostServiceRequestLogs> SaudiPostServiceRequestLogs { get; set; }
        public virtual DbSet<ServiceRequestLog> ServiceRequestLog { get; set; }
        public virtual DbSet<Smslog> Smslog { get; set; }
        public virtual DbSet<Smsnotification> Smsnotification { get; set; }
        public virtual DbSet<SmsnotificationOld> SmsnotificationOld { get; set; }
        public virtual DbSet<SmsnotificationTemp> SmsnotificationTemp { get; set; }
        public virtual DbSet<SolidarityPolicyServiceRequestLogs> SolidarityPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<SolidarityQuotationServiceRequestLogs> SolidarityQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<TawuniyaPolicyServiceRequestLogs> TawuniyaPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<TawuniyaQuotationServiceRequestLogs> TawuniyaQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<TokioMarinePolicyServiceRequestLogs> TokioMarinePolicyServiceRequestLogs { get; set; }
        public virtual DbSet<TokioMarineQuotationServiceRequestLogs> TokioMarineQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<TuicpolicyServiceRequestLogs> TuicpolicyServiceRequestLogs { get; set; }
        public virtual DbSet<TuicquotationServiceRequestLogs> TuicquotationServiceRequestLogs { get; set; }
        public virtual DbSet<UcapolicyServiceRequestLogs> UcapolicyServiceRequestLogs { get; set; }
        public virtual DbSet<UcaquotationServiceRequestLogs> UcaquotationServiceRequestLogs { get; set; }
        public virtual DbSet<UserTicketLog> UserTicketLog { get; set; }
        public virtual DbSet<ViewCheckQuotationStatus> ViewCheckQuotationStatus { get; set; }
        public virtual DbSet<ViewGetAllData> ViewGetAllData { get; set; }
        public virtual DbSet<ViewGetAllDataCount> ViewGetAllDataCount { get; set; }
        public virtual DbSet<WafaPolicyServiceRequestLogs> WafaPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<WafaQuotationServiceRequestLogs> WafaQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<WalaPolicyServiceRequestLogs> WalaPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<WalaQuotationServiceRequestLogs> WalaQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<WalaaPolicies> WalaaPolicies { get; set; }
        public virtual DbSet<WataniyaPolicyServiceRequestLogs> WataniyaPolicyServiceRequestLogs { get; set; }
        public virtual DbSet<WataniyaQuotationServiceRequestLogs> WataniyaQuotationServiceRequestLogs { get; set; }
        public virtual DbSet<WhatsAppLog> WhatsAppLog { get; set; }
        public virtual DbSet<YakeenServiceRequestLogs> YakeenServiceRequestLogs { get; set; }

        public AutoLeasingServiceLogContext()
        {
        }

        public AutoLeasingServiceLogContext(DbContextOptions<AutoLeasingServiceLogContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcigpolicyServiceRequestLogs>(entity =>
            {
                entity.ToTable("ACIGPolicyServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AcigquotationServiceRequestLogs>(entity =>
            {
                entity.ToTable("ACIGQuotationServiceRequestLogs");

                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AddressRequestLogs>(entity =>
            {
                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalId).HasMaxLength(50);

                entity.Property(e => e.NationalId).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.RequesterUrl).HasMaxLength(255);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<AdminRequestLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ApiURL");

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.MethodName).HasMaxLength(255);

                entity.Property(e => e.PageName).HasMaxLength(255);

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL");

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.RequesterUrl).HasMaxLength(500);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AhliaPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AhliaQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AiccpolicyServiceRequestLogs>(entity =>
            {
                entity.ToTable("AICCPolicyServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AiccquotationServiceRequestLogs>(entity =>
            {
                entity.ToTable("AICCQuotationServiceRequestLogs");

                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AlRajhiPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AlRajhiQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AlalamiyaPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AlalamiyaQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AllianzPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AllianzQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AmanaPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AmanaQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ApplepayErrorLogs>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.RequesterUrl).HasMaxLength(500);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(500);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(255)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<ArabianShieldPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<ArabianShieldQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AutoleasingAdminRequestLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ApiURL");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(255);

                entity.Property(e => e.PageName).HasMaxLength(255);

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<AxapolicyServiceRequestLogs>(entity =>
            {
                entity.ToTable("AXAPolicyServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<AxaquotationServiceRequestLogs>(entity =>
            {
                entity.ToTable("AXAQuotationServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<BcarePolicyServiceRequestLogs>(entity =>
            {
                entity.ToTable("BCarePolicyServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<BcareQuotationServiceRequestLogs>(entity =>
            {
                entity.ToTable("BCareQuotationServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<BurujPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<BurujQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<CancellationServiceRequestLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<CheckoutRequestLog>(entity =>
            {
                entity.HasIndex(e => e.CreatedDate, "idx_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "idx_DriverNin");

                entity.HasIndex(e => e.MethodName, "idx_MethodName");

                entity.HasIndex(e => e.ReferenceId, "idx_ReferenceId");

                entity.HasIndex(e => e.UserId, "idx_UserId");

                entity.HasIndex(e => e.VehicleId, "idx_VehicleId");

                entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.MethodName).HasMaxLength(50);

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.RequesterUrl).HasMaxLength(500);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(225);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<CompetitionRequestLogs>(entity =>
            {
                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.Nin).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailLog>(entity =>
            {
                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.SenderEmail).HasMaxLength(255);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(500);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<FirebaseNotificationLog>(entity =>
            {
                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.MethodName, "IX_MethodName");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(250);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<ForbiddenRequestLogs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Referer).HasMaxLength(500);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(250)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(250)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(500);
            });

            modelBuilder.Entity<GgipolicyServiceRequestLogs>(entity =>
            {
                entity.ToTable("GGIPolicyServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<GgiquotationServiceRequestLog>(entity =>
            {
                entity.ToTable("GGIQuotationServiceRequestLog");

                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<GulfUnionPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<GulfUnionQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<IdentityRequestLog>(entity =>
            {
                entity.Property(e => e.Channel).HasMaxLength(15);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ClientId).HasMaxLength(250);

                entity.Property(e => e.ClientSecret).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(15)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<InquiryRequestLog>(entity =>
            {
                entity.HasIndex(e => e.CreatedDate, "idx_InquiryRequestLog_CreatedDate");

                entity.HasIndex(e => e.ExternalId, "idx_InquiryRequestLog_ExternalId");

                entity.HasIndex(e => e.MethodName, "idx_InquiryRequestLog_MethodName");

                entity.HasIndex(e => e.Nin, "idx_InquiryRequestLog_NIN");

                entity.HasIndex(e => e.VehicleId, "idx_InquiryRequestLog_VehicleId");

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.MethodName).HasMaxLength(50);

                entity.Property(e => e.MobileVersion).HasMaxLength(255);

                entity.Property(e => e.NajmNcdRefrence).HasMaxLength(255);

                entity.Property(e => e.Nin)
                    .HasMaxLength(255)
                    .HasColumnName("NIN");

                entity.Property(e => e.PolicyEffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(225);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(255);
            });

            modelBuilder.Entity<IntegrationTransaction>(entity =>
            {
                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(200);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);
            });

            modelBuilder.Entity<IvrservicesLogs>(entity =>
            {
                entity.ToTable("IVRServicesLogs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.ModuleName).HasMaxLength(50);

                entity.Property(e => e.RequesterUrl).HasMaxLength(1000);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(100)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceResponseTimeInSeconds).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.UserAgent).HasMaxLength(1000);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(100)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<LeasingAddBenefitLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ApiURL");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(255);

                entity.Property(e => e.PageName).HasMaxLength(255);

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<LeasingAddDriverLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ApiURL");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(255);

                entity.Property(e => e.PageName).HasMaxLength(255);

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<LeasingPortalLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApiUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ApiURL");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(255);

                entity.Property(e => e.PageName).HasMaxLength(255);

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(255)
                    .HasColumnName("PageURL");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception).HasMaxLength(2000);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<LoginRequestsLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(250);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(250)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(250);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(250)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<MalathPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<MalathQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<MedGulfPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<MedGulfQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<NajmServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => new { e.Method, e.ErrorCode, e.CreatedDate }, "IX_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.ReferenceId, "IX_NajmServiceRequestLogs_ReferenceId");

                entity.HasIndex(e => new { e.ReferenceId, e.Method, e.ErrorCode, e.CreatedDate }, "IX_ReferenceId_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<NotPurchasedQuotations>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreateDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReferenceId)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NotificationLog>(entity =>
            {
                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ErrorCode, "IX_errorcode");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Message).HasMaxLength(500);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OwnDamageSmslog>(entity =>
            {
                entity.ToTable("OwnDamageSMSLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExternalId).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.PolicyExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.Smsmessage).HasColumnName("SMSMessage");
            });

            modelBuilder.Entity<PaymentServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<PdfGenerationLog>(entity =>
            {
                entity.HasIndex(e => e.ReferenceId, "IX_PdfGenerationLog_ReferenceId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.RetrievingMethod).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<PolicyModificationLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(50);

                entity.Property(e => e.Nin)
                    .HasMaxLength(50)
                    .HasColumnName("NIN");

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.RefrenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(225);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(225);
            });

            modelBuilder.Entity<PolicyNotificationLogs>(entity =>
            {
                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.Requester).HasMaxLength(255);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedReference).HasMaxLength(50);

                entity.Property(e => e.UserAgent).HasMaxLength(500);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(255)
                    .HasColumnName("UserIP");

                entity.Property(e => e.VehicleId).HasMaxLength(255);
            });

            modelBuilder.Entity<PolicyRequestLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InsuredAddress).HasMaxLength(500);

                entity.Property(e => e.InsuredBankCode).HasMaxLength(50);

                entity.Property(e => e.InsuredBankName).HasMaxLength(255);

                entity.Property(e => e.InsuredCity).HasMaxLength(255);

                entity.Property(e => e.InsuredEmail).HasMaxLength(255);

                entity.Property(e => e.InsuredIban)
                    .HasMaxLength(255)
                    .HasColumnName("InsuredIBAN");

                entity.Property(e => e.InsuredId)
                    .HasMaxLength(50)
                    .HasColumnName("InsuredID");

                entity.Property(e => e.InsuredMobileNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentBillNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentMethod).HasMaxLength(50);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.QuotationNo).HasMaxLength(255);

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<PowerBiservicesLog>(entity =>
            {
                entity.ToTable("PowerBIServicesLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyKey).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(100)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceResponseTimeInSeconds).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserAgent).HasMaxLength(1000);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(100)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<ProfileRequestsLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(500);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<PromotionRequestLog>(entity =>
            {
                entity.Property(e => e.ApiUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ApiURL");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MethodName).HasMaxLength(255);

                entity.Property(e => e.RequesterUrl).HasMaxLength(255);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<QuotationRequestLog>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "idx_CompanyId");

                entity.HasIndex(e => e.CompanyName, "idx_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "idx_CreatedDate");

                entity.HasIndex(e => e.ExtrnlId, "idx_ExtrnlId");

                entity.HasIndex(e => e.Nin, "idx_Nin");

                entity.HasIndex(e => e.RefrenceId, "idx_RefrenceId");

                entity.HasIndex(e => e.VehicleId, "idx_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExtrnlId).HasMaxLength(50);

                entity.Property(e => e.Nin)
                    .HasMaxLength(50)
                    .HasColumnName("NIN");

                entity.Property(e => e.RefrenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(225);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<RegistrationRequestsLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Nin).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<SaicopolicyServiceRequestLogs>(entity =>
            {
                entity.ToTable("SAICOPolicyServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<SaicoquotationServiceRequestLogs>(entity =>
            {
                entity.ToTable("SAICOQuotationServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SalamaPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<SalamaQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SaqrPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => new { e.Method, e.ErrorCode, e.CreatedDate }, "IX_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => new { e.ReferenceId, e.Method, e.ErrorCode, e.CreatedDate }, "IX_ReferenceId_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.ReferenceId, "IX_SaqrPolicyServiceRequestLogs_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<SaqrQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => new { e.Method, e.ErrorCode, e.CreatedDate }, "IX_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => new { e.ReferenceId, e.Method, e.ErrorCode, e.CreatedDate }, "IX_ReferenceId_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.ReferenceId, "IX_SaqrQuotationServiceRequestLogs_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<SaudiPostServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => new { e.Method, e.ErrorCode, e.CreatedDate }, "IX_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => new { e.ReferenceId, e.Method, e.ErrorCode, e.CreatedDate }, "IX_ReferenceId_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.ReferenceId, "IX_SaudiPostServiceRequestLogs_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ServiceRequestLog>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => new { e.Method, e.ErrorCode, e.CreatedDate }, "IX_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => new { e.ReferenceId, e.Method, e.ErrorCode, e.CreatedDate }, "IX_ReferenceId_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.ReferenceId, "IX_ServiceRequestLog_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<Smslog>(entity =>
            {
                entity.ToTable("SMSLog");

                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.Smsprovider, "IX_SMSProvider");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.Smsmessage).HasColumnName("SMSMessage");

                entity.Property(e => e.Smsprovider)
                    .HasMaxLength(50)
                    .HasColumnName("SMSProvider");

                entity.Property(e => e.UserAgent).HasMaxLength(500);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<Smsnotification>(entity =>
            {
                entity.ToTable("SMSNotification");

                entity.HasIndex(e => new { e.MobileNumber, e.SequenceNumber, e.CustomCard, e.NotificationNo, e.ReferenceId, e.ErrorCode }, "IX_SearchKeys");

                entity.HasIndex(e => new { e.MobileNumber, e.SequenceNumber, e.NotificationNo, e.ReferenceId, e.ErrorCode }, "NonClusteredIndex-20210323-135447");

                entity.HasIndex(e => e.MobileNumber, "ix_mobile");

                entity.HasIndex(e => e.ReferenceId, "ix_referenceid");

                entity.HasIndex(e => e.SequenceNumber, "ix_seqNo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCard).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.PolicyExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.SequenceNumber).HasMaxLength(50);

                entity.Property(e => e.Smsmessage)
                    .HasMaxLength(500)
                    .HasColumnName("SMSMessage");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TaskName).HasMaxLength(50);
            });

            modelBuilder.Entity<SmsnotificationOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSNotification_old");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.SequenceNumber).HasMaxLength(50);

                entity.Property(e => e.Smsmessage)
                    .HasMaxLength(500)
                    .HasColumnName("SMSMessage");
            });

            modelBuilder.Entity<SmsnotificationTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSNotificationTemp");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.PolicyExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.SequenceNumber).HasMaxLength(50);

                entity.Property(e => e.Smsmessage)
                    .HasMaxLength(500)
                    .HasColumnName("SMSMessage");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SolidarityPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<SolidarityQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TawuniyaPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<TawuniyaQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TokioMarinePolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<TokioMarineQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<TuicpolicyServiceRequestLogs>(entity =>
            {
                entity.ToTable("TUICPolicyServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<TuicquotationServiceRequestLogs>(entity =>
            {
                entity.ToTable("TUICQuotationServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<UcapolicyServiceRequestLogs>(entity =>
            {
                entity.ToTable("UCAPolicyServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<UcaquotationServiceRequestLogs>(entity =>
            {
                entity.ToTable("UCAQuotationServiceRequestLogs");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<UserTicketLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.MethodName).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.UserAgent).HasMaxLength(225);

                entity.Property(e => e.UserId).HasMaxLength(50);

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");
            });

            modelBuilder.Entity<ViewCheckQuotationStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewCheckQuotationStatus");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ViewGetAllData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGetAllData");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewGetAllDataCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewGetAllDataCount");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<WafaPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => new { e.Method, e.ErrorCode, e.CreatedDate }, "IX_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => new { e.ReferenceId, e.Method, e.ErrorCode, e.CreatedDate }, "IX_ReferenceId_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.HasIndex(e => e.ReferenceId, "IX_WafaPolicyServiceRequestLogs_ReferenceId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<WafaQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => new { e.Method, e.ErrorCode, e.CreatedDate }, "IX_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => new { e.ReferenceId, e.Method, e.ErrorCode, e.CreatedDate }, "IX_ReferenceId_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.HasIndex(e => e.ReferenceId, "IX_WafaQuotationServiceRequestLogs_ReferenceId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<WalaPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<WalaQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<WalaaPolicies>(entity =>
            {
                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.Referenceid).HasMaxLength(50);

                entity.Property(e => e.ReportUrl).HasMaxLength(255);
            });

            modelBuilder.Entity<WataniyaPolicyServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => new { e.Method, e.DriverNin }, "IX_Method_Driver_Nin");

                entity.HasIndex(e => new { e.Method, e.ErrorCode, e.CreatedDate }, "IX_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => new { e.ReferenceId, e.Method, e.ErrorCode, e.CreatedDate }, "IX_ReferenceId_Method_ErrorCode_CreatedDate");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.HasIndex(e => e.ReferenceId, "IX_WataniyaPolicyServiceRequestLogs_ReferenceId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);
            });

            modelBuilder.Entity<WataniyaQuotationServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.Channel, "IX_Channel");

                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.CreatedOn, "IX_CreatedOn");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("date");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(100);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(100);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

            modelBuilder.Entity<WhatsAppLog>(entity =>
            {
                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Method).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasMaxLength(50);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);
            });

            modelBuilder.Entity<YakeenServiceRequestLogs>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_CompanyID");

                entity.HasIndex(e => e.CompanyName, "IX_CompanyName");

                entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

                entity.HasIndex(e => e.DriverNin, "IX_DriverNin");

                entity.HasIndex(e => e.ErrorCode, "IX_ErrorCode");

                entity.HasIndex(e => e.Method, "IX_Method");

                entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

                entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Channel).HasMaxLength(255);

                entity.Property(e => e.ChassisNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DriverNin).HasMaxLength(50);

                entity.Property(e => e.ExternalId).HasMaxLength(255);

                entity.Property(e => e.Method).HasMaxLength(255);

                entity.Property(e => e.PolicyNo).HasMaxLength(150);

                entity.Property(e => e.ReferenceId).HasMaxLength(50);

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(50)
                    .HasColumnName("ServerIP");

                entity.Property(e => e.ServiceErrorCode).HasMaxLength(500);

                entity.Property(e => e.ServiceUrl)
                    .HasMaxLength(255)
                    .HasColumnName("ServiceURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VehicleId).HasMaxLength(50);

                entity.Property(e => e.VehicleMaker).HasMaxLength(50);

                entity.Property(e => e.VehicleMakerCode).HasMaxLength(50);

                entity.Property(e => e.VehicleModel).HasMaxLength(50);

                entity.Property(e => e.VehicleModelCode).HasMaxLength(50);
            });

        OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
