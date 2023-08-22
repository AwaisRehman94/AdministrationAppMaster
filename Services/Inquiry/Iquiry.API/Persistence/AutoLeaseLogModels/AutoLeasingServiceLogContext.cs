using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Inquiry.API.Persistence.AutoLeaseLogModels;

public partial class AutoLeasingServiceLogContext : DbContext
{
    public AutoLeasingServiceLogContext()
    {
    }

    public AutoLeasingServiceLogContext(DbContextOptions<AutoLeasingServiceLogContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcigpolicyServiceRequestLog> AcigpolicyServiceRequestLogs { get; set; }

    public virtual DbSet<AcigquotationServiceRequestLog> AcigquotationServiceRequestLogs { get; set; }

    public virtual DbSet<AddressRequestLog> AddressRequestLogs { get; set; }

    public virtual DbSet<AdminRequestLog> AdminRequestLogs { get; set; }

    public virtual DbSet<AhliaPolicyServiceRequestLog> AhliaPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<AhliaQuotationServiceRequestLog> AhliaQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<AiccpolicyServiceRequestLog> AiccpolicyServiceRequestLogs { get; set; }

    public virtual DbSet<AiccquotationServiceRequestLog> AiccquotationServiceRequestLogs { get; set; }

    public virtual DbSet<AlRajhiPolicyServiceRequestLog> AlRajhiPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<AlRajhiQuotationServiceRequestLog> AlRajhiQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<AlalamiyaPolicyServiceRequestLog> AlalamiyaPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<AlalamiyaQuotationServiceRequestLog> AlalamiyaQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<AllianzPolicyServiceRequestLog> AllianzPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<AllianzQuotationServiceRequestLog> AllianzQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<AmanaPolicyServiceRequestLog> AmanaPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<AmanaQuotationServiceRequestLog> AmanaQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<ApplepayErrorLog> ApplepayErrorLogs { get; set; }

    public virtual DbSet<ArabianShieldPolicyServiceRequestLog> ArabianShieldPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<ArabianShieldQuotationServiceRequestLog> ArabianShieldQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<AutoleasingAdminRequestLog> AutoleasingAdminRequestLogs { get; set; }

    public virtual DbSet<AxapolicyServiceRequestLog> AxapolicyServiceRequestLogs { get; set; }

    public virtual DbSet<AxaquotationServiceRequestLog> AxaquotationServiceRequestLogs { get; set; }

    public virtual DbSet<BcarePolicyServiceRequestLog> BcarePolicyServiceRequestLogs { get; set; }

    public virtual DbSet<BcareQuotationServiceRequestLog> BcareQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<BurujPolicyServiceRequestLog> BurujPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<BurujQuotationServiceRequestLog> BurujQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<CancellationServiceRequestLog> CancellationServiceRequestLogs { get; set; }

    public virtual DbSet<CheckoutRequestLog> CheckoutRequestLogs { get; set; }

    public virtual DbSet<CompetitionRequestLog> CompetitionRequestLogs { get; set; }

    public virtual DbSet<EmailLog> EmailLogs { get; set; }

    public virtual DbSet<FirebaseNotificationLog> FirebaseNotificationLogs { get; set; }

    public virtual DbSet<ForbiddenRequestLog> ForbiddenRequestLogs { get; set; }

    public virtual DbSet<GgipolicyServiceRequestLog> GgipolicyServiceRequestLogs { get; set; }

    public virtual DbSet<GgiquotationServiceRequestLog> GgiquotationServiceRequestLogs { get; set; }

    public virtual DbSet<GulfUnionPolicyServiceRequestLog> GulfUnionPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<GulfUnionQuotationServiceRequestLog> GulfUnionQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<IdentityRequestLog> IdentityRequestLogs { get; set; }

    public virtual DbSet<InquiryRequestLog> InquiryRequestLogs { get; set; }

    public virtual DbSet<IntegrationTransaction> IntegrationTransactions { get; set; }

    public virtual DbSet<IvrservicesLog> IvrservicesLogs { get; set; }

    public virtual DbSet<LeasingAddBenefitLog> LeasingAddBenefitLogs { get; set; }

    public virtual DbSet<LeasingAddDriverLog> LeasingAddDriverLogs { get; set; }

    public virtual DbSet<LeasingPortalLog> LeasingPortalLogs { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LoginRequestsLog> LoginRequestsLogs { get; set; }

    public virtual DbSet<MalathPolicyServiceRequestLog> MalathPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<MalathQuotationServiceRequestLog> MalathQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<MedGulfPolicyServiceRequestLog> MedGulfPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<MedGulfQuotationServiceRequestLog> MedGulfQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<NajmServiceRequestLog> NajmServiceRequestLogs { get; set; }

    public virtual DbSet<NotPurchasedQuotation> NotPurchasedQuotations { get; set; }

    public virtual DbSet<NotificationLog> NotificationLogs { get; set; }

    public virtual DbSet<OwnDamageSmslog> OwnDamageSmslogs { get; set; }

    public virtual DbSet<PaymentServiceRequestLog> PaymentServiceRequestLogs { get; set; }

    public virtual DbSet<PdfGenerationLog> PdfGenerationLogs { get; set; }

    public virtual DbSet<PolicyModificationLog> PolicyModificationLogs { get; set; }

    public virtual DbSet<PolicyNotificationLog> PolicyNotificationLogs { get; set; }

    public virtual DbSet<PolicyRequestLog> PolicyRequestLogs { get; set; }

    public virtual DbSet<PowerBiservicesLog> PowerBiservicesLogs { get; set; }

    public virtual DbSet<ProfileRequestsLog> ProfileRequestsLogs { get; set; }

    public virtual DbSet<PromotionRequestLog> PromotionRequestLogs { get; set; }

    public virtual DbSet<QuotationRequestLog> QuotationRequestLogs { get; set; }

    public virtual DbSet<RegistrationRequestsLog> RegistrationRequestsLogs { get; set; }

    public virtual DbSet<SaicopolicyServiceRequestLog> SaicopolicyServiceRequestLogs { get; set; }

    public virtual DbSet<SaicoquotationServiceRequestLog> SaicoquotationServiceRequestLogs { get; set; }

    public virtual DbSet<SalamaPolicyServiceRequestLog> SalamaPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<SalamaQuotationServiceRequestLog> SalamaQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<SaqrPolicyServiceRequestLog> SaqrPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<SaqrQuotationServiceRequestLog> SaqrQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<SaudiPostServiceRequestLog> SaudiPostServiceRequestLogs { get; set; }

    public virtual DbSet<ServiceRequestLog> ServiceRequestLogs { get; set; }

    public virtual DbSet<Smslog> Smslogs { get; set; }

    public virtual DbSet<Smsnotification> Smsnotifications { get; set; }

    public virtual DbSet<SmsnotificationOld> SmsnotificationOlds { get; set; }

    public virtual DbSet<SmsnotificationTemp> SmsnotificationTemps { get; set; }

    public virtual DbSet<SolidarityPolicyServiceRequestLog> SolidarityPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<SolidarityQuotationServiceRequestLog> SolidarityQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<TawuniyaPolicyServiceRequestLog> TawuniyaPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<TawuniyaQuotationServiceRequestLog> TawuniyaQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<TokioMarinePolicyServiceRequestLog> TokioMarinePolicyServiceRequestLogs { get; set; }

    public virtual DbSet<TokioMarineQuotationServiceRequestLog> TokioMarineQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<TuicpolicyServiceRequestLog> TuicpolicyServiceRequestLogs { get; set; }

    public virtual DbSet<TuicquotationServiceRequestLog> TuicquotationServiceRequestLogs { get; set; }

    public virtual DbSet<UcapolicyServiceRequestLog> UcapolicyServiceRequestLogs { get; set; }

    public virtual DbSet<UcaquotationServiceRequestLog> UcaquotationServiceRequestLogs { get; set; }

    public virtual DbSet<UserTicketLog> UserTicketLogs { get; set; }

    public virtual DbSet<ViewCheckQuotationStatus> ViewCheckQuotationStatuses { get; set; }

    public virtual DbSet<ViewGetAllDataCount> ViewGetAllDataCounts { get; set; }

    public virtual DbSet<ViewGetAllDatum> ViewGetAllData { get; set; }

    public virtual DbSet<WafaPolicyServiceRequestLog> WafaPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<WafaQuotationServiceRequestLog> WafaQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<WalaPolicyServiceRequestLog> WalaPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<WalaQuotationServiceRequestLog> WalaQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<WalaaPolicy> WalaaPolicies { get; set; }

    public virtual DbSet<WataniyaPolicyServiceRequestLog> WataniyaPolicyServiceRequestLogs { get; set; }

    public virtual DbSet<WataniyaQuotationServiceRequestLog> WataniyaQuotationServiceRequestLogs { get; set; }

    public virtual DbSet<WhatsAppLog> WhatsAppLogs { get; set; }

    public virtual DbSet<YakeenServiceRequestLog> YakeenServiceRequestLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.1.32\\MOTOR;Database=AutoLeasingServiceLog;Password=J@2Ir@h-DB03;User Id=bcareTest;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcigpolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AcigquotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AddressRequestLog>(entity =>
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
            entity.HasKey(e => e.Id).HasName("PK_AdminsRequestLogs");

            entity.ToTable("AdminRequestLog");

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

        modelBuilder.Entity<AhliaPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AhliaQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AiccpolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AiccquotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AlRajhiPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AlRajhiQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AlalamiyaPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AlalamiyaQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AllianzPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AllianzQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AmanaPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AmanaQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<ApplepayErrorLog>(entity =>
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

        modelBuilder.Entity<ArabianShieldPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<ArabianShieldQuotationServiceRequestLog>(entity =>
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
            entity.ToTable("AutoleasingAdminRequestLog");

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

        modelBuilder.Entity<AxapolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<AxaquotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<BcarePolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<BcareQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<BurujPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<BurujQuotationServiceRequestLog>(entity =>
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
            entity.HasKey(e => e.Id).HasName("PK_CancellationServiceRequestLogs");

            entity.ToTable("CancellationServiceRequestLog");

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
            entity.ToTable("CheckoutRequestLog");

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

        modelBuilder.Entity<CompetitionRequestLog>(entity =>
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
            entity.ToTable("EmailLog");

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
            entity.ToTable("FirebaseNotificationLog");

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

        modelBuilder.Entity<ForbiddenRequestLog>(entity =>
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

        modelBuilder.Entity<GgipolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<GulfUnionPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<GulfUnionQuotationServiceRequestLog>(entity =>
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
            entity.ToTable("IdentityRequestLog");

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
            entity.ToTable("InquiryRequestLog");

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
            entity.ToTable("IntegrationTransaction");

            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Message).HasMaxLength(200);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<IvrservicesLog>(entity =>
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
            entity.ToTable("LeasingAddBenefitLog");

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
            entity.ToTable("LeasingAddDriverLog");

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
            entity.ToTable("LeasingPortalLog");

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
            entity
                .HasNoKey()
                .ToTable("Log");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Exception).HasMaxLength(2000);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Level).HasMaxLength(50);
            entity.Property(e => e.Logger).HasMaxLength(255);
            entity.Property(e => e.Message).HasMaxLength(4000);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.Thread).HasMaxLength(255);
        });

        modelBuilder.Entity<LoginRequestsLog>(entity =>
        {
            entity.ToTable("LoginRequestsLog");

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

        modelBuilder.Entity<MalathPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<MalathQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<MedGulfPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<MedGulfQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<NajmServiceRequestLog>(entity =>
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

        modelBuilder.Entity<NotPurchasedQuotation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<NotificationLog>(entity =>
        {
            entity.ToTable("NotificationLog");

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

        modelBuilder.Entity<PaymentServiceRequestLog>(entity =>
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
            entity.ToTable("PdfGenerationLog");

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
            entity.HasKey(e => e.Id).HasName("PK_AddDriverLog");

            entity.ToTable("PolicyModificationLog");

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

        modelBuilder.Entity<PolicyNotificationLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PolicyNotificationLog");

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
            entity.ToTable("PolicyRequestLog");

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
            entity.ToTable("ProfileRequestsLog");

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
            entity.HasKey(e => e.Id).HasName("PK_PromotionRequestLogs");

            entity.ToTable("PromotionRequestLog");

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
            entity.ToTable("QuotationRequestLog");

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
            entity.ToTable("RegistrationRequestsLog");

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

        modelBuilder.Entity<SaicopolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<SaicoquotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<SalamaPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<SalamaQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<SaqrPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<SaqrQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<SaudiPostServiceRequestLog>(entity =>
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
            entity.HasKey(e => e.Id).HasName("PK_ServicesRequestLogs");

            entity.ToTable("ServiceRequestLog");

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
            entity.HasKey(e => e.Id).HasName("PK_SMSLogs");

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
            entity
                .HasNoKey()
                .ToTable("SMSNotification_old");

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
            entity
                .HasNoKey()
                .ToTable("SMSNotificationTemp");

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

        modelBuilder.Entity<SolidarityPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<SolidarityQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<TawuniyaPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<TawuniyaQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<TokioMarinePolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<TokioMarineQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<TuicpolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<TuicquotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<UcapolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<UcaquotationServiceRequestLog>(entity =>
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
            entity.HasKey(e => e.Id).HasName("PK_UserTicketLogLog");

            entity.ToTable("UserTicketLog");

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
            entity
                .HasNoKey()
                .ToView("ViewCheckQuotationStatus");

            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ViewGetAllDataCount>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewGetAllDataCount");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ViewGetAllDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewGetAllData");

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

        modelBuilder.Entity<WafaPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<WafaQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<WalaPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<WalaQuotationServiceRequestLog>(entity =>
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

        modelBuilder.Entity<WalaaPolicy>(entity =>
        {
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.ProcessedOn).HasColumnType("datetime");
            entity.Property(e => e.Referenceid).HasMaxLength(50);
            entity.Property(e => e.ReportUrl).HasMaxLength(255);
        });

        modelBuilder.Entity<WataniyaPolicyServiceRequestLog>(entity =>
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

        modelBuilder.Entity<WataniyaQuotationServiceRequestLog>(entity =>
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
            entity.HasKey(e => e.Id).HasName("PK_WhatsAppLogs");

            entity.ToTable("WhatsAppLog");

            entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Method).HasMaxLength(50);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<YakeenServiceRequestLog>(entity =>
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

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
