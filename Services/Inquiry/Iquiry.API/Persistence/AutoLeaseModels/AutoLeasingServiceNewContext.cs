using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Inquiry.API.Persistence.AutoLeaseModels;

public partial class AutoLeasingServiceNewContext : DbContext
{
    public AutoLeasingServiceNewContext()
    {
    }

    public AutoLeasingServiceNewContext(DbContextOptions<AutoLeasingServiceNewContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdditionalDriverRelationship> AdditionalDriverRelationships { get; set; }

    public virtual DbSet<AdditionalInfo> AdditionalInfos { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }

    public virtual DbSet<AtoleasingTicketType> AtoleasingTicketTypes { get; set; }

    public virtual DbSet<Attachment> Attachments { get; set; }

    public virtual DbSet<AutoleasingAgencyRepair> AutoleasingAgencyRepairs { get; set; }

    public virtual DbSet<AutoleasingAgencyRepairHistory> AutoleasingAgencyRepairHistories { get; set; }

    public virtual DbSet<AutoleasingBenefit> AutoleasingBenefits { get; set; }

    public virtual DbSet<AutoleasingDeductible> AutoleasingDeductibles { get; set; }

    public virtual DbSet<AutoleasingDepreciationSetting> AutoleasingDepreciationSettings { get; set; }

    public virtual DbSet<AutoleasingDepreciationSettingHistory> AutoleasingDepreciationSettingHistories { get; set; }

    public virtual DbSet<AutoleasingInitialQuotationCompany> AutoleasingInitialQuotationCompanies { get; set; }

    public virtual DbSet<AutoleasingMinimumPremium> AutoleasingMinimumPremia { get; set; }

    public virtual DbSet<AutoleasingMinimumPremiumHistory> AutoleasingMinimumPremiumHistories { get; set; }

    public virtual DbSet<AutoleasingQuotationForm> AutoleasingQuotationForms { get; set; }

    public virtual DbSet<AutoleasingQuotationFormOldHistory> AutoleasingQuotationFormOldHistories { get; set; }

    public virtual DbSet<AutoleasingQuotationFormOldHistoryOld> AutoleasingQuotationFormOldHistoryOlds { get; set; }

    public virtual DbSet<AutoleasingQuotationFormSetting> AutoleasingQuotationFormSettings { get; set; }

    public virtual DbSet<AutoleasingQuotationResponseCache> AutoleasingQuotationResponseCaches { get; set; }

    public virtual DbSet<AutoleasingRenewalPolicyStatistic> AutoleasingRenewalPolicyStatistics { get; set; }

    public virtual DbSet<AutoleasingSelectedBenifit> AutoleasingSelectedBenifits { get; set; }

    public virtual DbSet<AutoleasingUser> AutoleasingUsers { get; set; }

    public virtual DbSet<AutoleasingVerifyUser> AutoleasingVerifyUsers { get; set; }

    public virtual DbSet<AutoleasingWalletHistory> AutoleasingWalletHistories { get; set; }

    public virtual DbSet<AutomatedTestIntegrationTransaction> AutomatedTestIntegrationTransactions { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }

    public virtual DbSet<BankCode> BankCodes { get; set; }

    public virtual DbSet<BankInsuranceCompany> BankInsuranceCompanies { get; set; }

    public virtual DbSet<BankNin> BankNins { get; set; }

    public virtual DbSet<BcareWithdrawalWinner> BcareWithdrawalWinners { get; set; }

    public virtual DbSet<BcareWithdrawalWinnerOld> BcareWithdrawalWinnerOlds { get; set; }

    public virtual DbSet<Benefit> Benefits { get; set; }

    public virtual DbSet<BenefitService> BenefitServices { get; set; }

    public virtual DbSet<BreakingSystem> BreakingSystems { get; set; }

    public virtual DbSet<CameraType> CameraTypes { get; set; }

    public virtual DbSet<CancellationRequest> CancellationRequests { get; set; }

    public virtual DbSet<CardIdtype> CardIdtypes { get; set; }

    public virtual DbSet<Career> Careers { get; set; }

    public virtual DbSet<CheckoutAdditionalDriver> CheckoutAdditionalDrivers { get; set; }

    public virtual DbSet<CheckoutCarImage> CheckoutCarImages { get; set; }

    public virtual DbSet<CheckoutDetail> CheckoutDetails { get; set; }

    public virtual DbSet<CheckoutDriverInfo> CheckoutDriverInfos { get; set; }

    public virtual DbSet<CheckoutHyperpayPaymentReq> CheckoutHyperpayPaymentReqs { get; set; }

    public virtual DbSet<CheckoutUser> CheckoutUsers { get; set; }

    public virtual DbSet<CheckoutUsersTemp> CheckoutUsersTemps { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<CityCenter> CityCenters { get; set; }

    public virtual DbSet<Cityold> Cityolds { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<CommissionsAndFee> CommissionsAndFees { get; set; }

    public virtual DbSet<CommissionsAndFeesBackup> CommissionsAndFeesBackups { get; set; }

    public virtual DbSet<CommissionsAndFeesBackupMay2022> CommissionsAndFeesBackupMay2022s { get; set; }

    public virtual DbSet<CommissionsAndFeesTemp> CommissionsAndFeesTemps { get; set; }

    public virtual DbSet<CompanyBankAccount> CompanyBankAccounts { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<CorporateAccount> CorporateAccounts { get; set; }

    public virtual DbSet<CorporateUser> CorporateUsers { get; set; }

    public virtual DbSet<CorporateVerifyUser> CorporateVerifyUsers { get; set; }

    public virtual DbSet<CorporateWalletHistory> CorporateWalletHistories { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CustomCardInfo> CustomCardInfos { get; set; }

    public virtual DbSet<CustomCardQueue> CustomCardQueues { get; set; }

    public virtual DbSet<Deductible> Deductibles { get; set; }

    public virtual DbSet<DeservingDiscount> DeservingDiscounts { get; set; }

    public virtual DbSet<DeservingDiscountTemp> DeservingDiscountTemps { get; set; }

    public virtual DbSet<DistanceRange> DistanceRanges { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<DriverExtraLicense> DriverExtraLicenses { get; set; }

    public virtual DbSet<DriverLicense> DriverLicenses { get; set; }

    public virtual DbSet<DriverMedicalCondition> DriverMedicalConditions { get; set; }

    public virtual DbSet<DriverType> DriverTypes { get; set; }

    public virtual DbSet<DriverViolation> DriverViolations { get; set; }

    public virtual DbSet<DrivingLicenceYear> DrivingLicenceYears { get; set; }

    public virtual DbSet<EdaatCompany> EdaatCompanies { get; set; }

    public virtual DbSet<EdaatCustomer> EdaatCustomers { get; set; }

    public virtual DbSet<EdaatNotification> EdaatNotifications { get; set; }

    public virtual DbSet<EdaatProduct> EdaatProducts { get; set; }

    public virtual DbSet<EdaatRequest> EdaatRequests { get; set; }

    public virtual DbSet<EdaatResponse> EdaatResponses { get; set; }

    public virtual DbSet<EducationLevel> EducationLevels { get; set; }

    public virtual DbSet<EmailSetting> EmailSettings { get; set; }

    public virtual DbSet<Endorsment> Endorsments { get; set; }

    public virtual DbSet<EndorsmentBenefit> EndorsmentBenefits { get; set; }

    public virtual DbSet<ErrorCode> ErrorCodes { get; set; }

    public virtual DbSet<EsalCustomer> EsalCustomers { get; set; }

    public virtual DbSet<EsalLineItem> EsalLineItems { get; set; }

    public virtual DbSet<EsalProfitMargin> EsalProfitMargins { get; set; }

    public virtual DbSet<EsalRequest> EsalRequests { get; set; }

    public virtual DbSet<EsalResponse> EsalResponses { get; set; }

    public virtual DbSet<EsalSettlement> EsalSettlements { get; set; }

    public virtual DbSet<EsalSupplier> EsalSuppliers { get; set; }

    public virtual DbSet<ExpiredToken> ExpiredTokens { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<HyperPayCreateOrder> HyperPayCreateOrders { get; set; }

    public virtual DbSet<HyperPayNotification> HyperPayNotifications { get; set; }

    public virtual DbSet<HyperPayNotificationTransaction> HyperPayNotificationTransactions { get; set; }

    public virtual DbSet<HyperPayUpdateOrder> HyperPayUpdateOrders { get; set; }

    public virtual DbSet<HyperpayRequest> HyperpayRequests { get; set; }

    public virtual DbSet<HyperpayResponse> HyperpayResponses { get; set; }

    public virtual DbSet<IbanHistory> IbanHistories { get; set; }

    public virtual DbSet<InsuaranceCompanyBenefit> InsuaranceCompanyBenefits { get; set; }

    public virtual DbSet<InsuranceCompany> InsuranceCompanies { get; set; }

    public virtual DbSet<InsuranceCompanyProductTypeConfig> InsuranceCompanyProductTypeConfigs { get; set; }

    public virtual DbSet<Insured> Insureds { get; set; }

    public virtual DbSet<InsuredAddressesCount> InsuredAddressesCounts { get; set; }

    public virtual DbSet<InsuredExtraLicense> InsuredExtraLicenses { get; set; }

    public virtual DbSet<IntegrationTransactionToBeDeleted> IntegrationTransactionToBeDeleteds { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceBenefit> InvoiceBenefits { get; set; }

    public virtual DbSet<InvoiceDriver> InvoiceDrivers { get; set; }

    public virtual DbSet<InvoiceFile> InvoiceFiles { get; set; }

    public virtual DbSet<InvoiceFileTemplate> InvoiceFileTemplates { get; set; }

    public virtual DbSet<InvoiceTemp24march> InvoiceTemp24marches { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LeasingUser> LeasingUsers { get; set; }

    public virtual DbSet<LeasingUsersLocationsDeviceInfo> LeasingUsersLocationsDeviceInfos { get; set; }

    public virtual DbSet<LeasingVerifyUser> LeasingVerifyUsers { get; set; }

    public virtual DbSet<LicenseType> LicenseTypes { get; set; }

    public virtual DbSet<Logger> Loggers { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<MobileAppVersion> MobileAppVersions { get; set; }

    public virtual DbSet<Moidetail> Moidetails { get; set; }

    public virtual DbSet<MorniRequest> MorniRequests { get; set; }

    public virtual DbSet<MorniSm> MorniSms { get; set; }

    public virtual DbSet<NajmAccidentResponse> NajmAccidentResponses { get; set; }

    public virtual DbSet<NajmResponse> NajmResponses { get; set; }

    public virtual DbSet<NajmStatus> NajmStatuses { get; set; }

    public virtual DbSet<NajmStatusHistory> NajmStatusHistories { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<NcdfreeYear> NcdfreeYears { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationParameter> NotificationParameters { get; set; }

    public virtual DbSet<Occupation> Occupations { get; set; }

    public virtual DbSet<Offer> Offers { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<OrderItemBenefit> OrderItemBenefits { get; set; }

    public virtual DbSet<OrderItemDriver> OrderItemDrivers { get; set; }

    public virtual DbSet<OtpInfo> OtpInfos { get; set; }

    public virtual DbSet<OwnDamageQueue> OwnDamageQueues { get; set; }

    public virtual DbSet<ParkingPlace> ParkingPlaces { get; set; }

    public virtual DbSet<PayfortPaymentRequest> PayfortPaymentRequests { get; set; }

    public virtual DbSet<PayfortPaymentResponse> PayfortPaymentResponses { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Policy> Policies { get; set; }

    public virtual DbSet<PolicyAdditionalBenefit> PolicyAdditionalBenefits { get; set; }

    public virtual DbSet<PolicyDetail> PolicyDetails { get; set; }

    public virtual DbSet<PolicyFile> PolicyFiles { get; set; }

    public virtual DbSet<PolicyModification> PolicyModifications { get; set; }

    public virtual DbSet<PolicyProcessingQueue> PolicyProcessingQueues { get; set; }

    public virtual DbSet<PolicyRenewedByCompany> PolicyRenewedByCompanies { get; set; }

    public virtual DbSet<PolicyStatus> PolicyStatuses { get; set; }

    public virtual DbSet<PolicyUpdatePayment> PolicyUpdatePayments { get; set; }

    public virtual DbSet<PolicyUpdateRequest> PolicyUpdateRequests { get; set; }

    public virtual DbSet<PolicyUpdateRequestAttachment> PolicyUpdateRequestAttachments { get; set; }

    public virtual DbSet<PriceDetail> PriceDetails { get; set; }

    public virtual DbSet<PriceType> PriceTypes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductBenefit> ProductBenefits { get; set; }

    public virtual DbSet<ProductDriver> ProductDrivers { get; set; }

    public virtual DbSet<ProductType> ProductTypes { get; set; }

    public virtual DbSet<ProfileNotification> ProfileNotifications { get; set; }

    public virtual DbSet<PromotionProgram> PromotionPrograms { get; set; }

    public virtual DbSet<PromotionProgramCode> PromotionProgramCodes { get; set; }

    public virtual DbSet<PromotionProgramDomain> PromotionProgramDomains { get; set; }

    public virtual DbSet<PromotionProgramNin> PromotionProgramNins { get; set; }

    public virtual DbSet<PromotionProgramUser> PromotionProgramUsers { get; set; }

    public virtual DbSet<PromotionUser> PromotionUsers { get; set; }

    public virtual DbSet<PromotionUserCopy> PromotionUserCopies { get; set; }

    public virtual DbSet<QuotationBlockedNin> QuotationBlockedNins { get; set; }

    public virtual DbSet<QuotationProductBenefit> QuotationProductBenefits { get; set; }

    public virtual DbSet<QuotationRequest> QuotationRequests { get; set; }

    public virtual DbSet<QuotationRequestAdditionalDriver> QuotationRequestAdditionalDrivers { get; set; }

    public virtual DbSet<QuotationResponse> QuotationResponses { get; set; }

    public virtual DbSet<QuotationResponseCache> QuotationResponseCaches { get; set; }

    public virtual DbSet<QuotationResponseLogsGap> QuotationResponseLogsGaps { get; set; }

    public virtual DbSet<QuotationResponseNew> QuotationResponseNews { get; set; }

    public virtual DbSet<QuotationShare> QuotationShares { get; set; }

    public virtual DbSet<ReasonCode> ReasonCodes { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<RegisterTokenLog> RegisterTokenLogs { get; set; }

    public virtual DbSet<RenewalDiscount> RenewalDiscounts { get; set; }

    public virtual DbSet<RenewalPolicy> RenewalPolicies { get; set; }

    public virtual DbSet<RenwalStatiticsOld> RenwalStatiticsOlds { get; set; }

    public virtual DbSet<RiyadBankMigsRequest> RiyadBankMigsRequests { get; set; }

    public virtual DbSet<RiyadBankMigsResponse> RiyadBankMigsResponses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleType> RoleTypes { get; set; }

    public virtual DbSet<SadadNotificationMessage> SadadNotificationMessages { get; set; }

    public virtual DbSet<SadadNotificationResponse> SadadNotificationResponses { get; set; }

    public virtual DbSet<SadadRequest> SadadRequests { get; set; }

    public virtual DbSet<SadadResponse> SadadResponses { get; set; }

    public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }

    public virtual DbSet<SendNotificationLog> SendNotificationLogs { get; set; }

    public virtual DbSet<Sensor> Sensors { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    public virtual DbSet<ShoppingCartItemBenefit> ShoppingCartItemBenefits { get; set; }

    public virtual DbSet<ShoppingCartItemDriver> ShoppingCartItemDrivers { get; set; }

    public virtual DbSet<SmsCode> SmsCodes { get; set; }

    public virtual DbSet<SmsRenewalNotificationRehit> SmsRenewalNotificationRehits { get; set; }

    public virtual DbSet<SmsproviderSetting> SmsproviderSettings { get; set; }

    public virtual DbSet<SmsskippedNumber> SmsskippedNumbers { get; set; }

    public virtual DbSet<SpeedStabilizer> SpeedStabilizers { get; set; }

    public virtual DbSet<TabbyCaptureRequest> TabbyCaptureRequests { get; set; }

    public virtual DbSet<TabbyCaptureResponse> TabbyCaptureResponses { get; set; }

    public virtual DbSet<TabbyCaptureResponseDetail> TabbyCaptureResponseDetails { get; set; }

    public virtual DbSet<TabbyNotification> TabbyNotifications { get; set; }

    public virtual DbSet<TabbyNotificationDetail> TabbyNotificationDetails { get; set; }

    public virtual DbSet<TabbyRequest> TabbyRequests { get; set; }

    public virtual DbSet<TabbyRequestDetail> TabbyRequestDetails { get; set; }

    public virtual DbSet<TabbyResponse> TabbyResponses { get; set; }

    public virtual DbSet<TabbyResponseDetail> TabbyResponseDetails { get; set; }

    public virtual DbSet<TabbyWebHook> TabbyWebHooks { get; set; }

    public virtual DbSet<TabbyWebHookDetail> TabbyWebHookDetails { get; set; }

    public virtual DbSet<TawuniyaProposal> TawuniyaProposals { get; set; }

    public virtual DbSet<TawuniyaTempTable> TawuniyaTempTables { get; set; }

    public virtual DbSet<TempPriceDetail> TempPriceDetails { get; set; }

    public virtual DbSet<UserClaim> UserClaims { get; set; }

    public virtual DbSet<UserClaimFile> UserClaimFiles { get; set; }

    public virtual DbSet<UserClaimHistory> UserClaimHistories { get; set; }

    public virtual DbSet<UserClaimStatus> UserClaimStatuses { get; set; }

    public virtual DbSet<UserFireBaseRegisterationToken> UserFireBaseRegisterationTokens { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    public virtual DbSet<UserNotification> UserNotifications { get; set; }

    public virtual DbSet<UserPurchasedPromotionProgram> UserPurchasedPromotionPrograms { get; set; }

    public virtual DbSet<UserTicket> UserTickets { get; set; }

    public virtual DbSet<UserTicketAttachment> UserTicketAttachments { get; set; }

    public virtual DbSet<UserTicketHistory> UserTicketHistories { get; set; }

    public virtual DbSet<UserTicketStatus> UserTicketStatuses { get; set; }

    public virtual DbSet<UserTicketType> UserTicketTypes { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleBodyType> VehicleBodyTypes { get; set; }

    public virtual DbSet<VehicleColor> VehicleColors { get; set; }

    public virtual DbSet<VehicleDiscount> VehicleDiscounts { get; set; }

    public virtual DbSet<VehicleIdtype> VehicleIdtypes { get; set; }

    public virtual DbSet<VehicleMaker> VehicleMakers { get; set; }

    public virtual DbSet<VehicleMakerTemp> VehicleMakerTemps { get; set; }

    public virtual DbSet<VehicleModel> VehicleModels { get; set; }

    public virtual DbSet<VehicleModelTemp> VehicleModelTemps { get; set; }

    public virtual DbSet<VehiclePlateText> VehiclePlateTexts { get; set; }

    public virtual DbSet<VehiclePlateType> VehiclePlateTypes { get; set; }

    public virtual DbSet<VehicleRequest> VehicleRequests { get; set; }

    public virtual DbSet<VehicleSpecification> VehicleSpecifications { get; set; }

    public virtual DbSet<VehicleTransmissionType> VehicleTransmissionTypes { get; set; }

    public virtual DbSet<VehicleUsage> VehicleUsages { get; set; }

    public virtual DbSet<VehicleUsagePercentage> VehicleUsagePercentages { get; set; }

    public virtual DbSet<Violation> Violations { get; set; }

    public virtual DbSet<Wareef> Wareefs { get; set; }

    public virtual DbSet<WareefCategory> WareefCategories { get; set; }

    public virtual DbSet<WareefDescount> WareefDescounts { get; set; }

    public virtual DbSet<WareefDiscountBenefit> WareefDiscountBenefits { get; set; }

    public virtual DbSet<WataniyaDraftPolicy> WataniyaDraftPolicies { get; set; }

    public virtual DbSet<WataniyaMotorPolicyInfo> WataniyaMotorPolicyInfos { get; set; }

    public virtual DbSet<WataniyaNajmQueue> WataniyaNajmQueues { get; set; }

    public virtual DbSet<YakeenCityCenter> YakeenCityCenters { get; set; }

    public virtual DbSet<YakeenDriver> YakeenDrivers { get; set; }

    public virtual DbSet<YakeenVehicle> YakeenVehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.1.32\\MOTOR;Database=AutoLeasingService_New;Password=J@2Ir@h-DB03;User Id=bcareTest;TrustServerCertificate=True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdditionalDriverRelationship>(entity =>
        {
            entity.ToTable("AdditionalDriverRelationship");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<AdditionalInfo>(entity =>
        {
            entity.HasKey(e => e.ReferenceId).HasName("PK__Addition__E1A99A191B4A44D6");

            entity.ToTable("AdditionalInfo");

            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.DriverAdditionalInfo).HasMaxLength(4000);

            entity.HasOne(d => d.Reference).WithOne(p => p.AdditionalInfo)
                .HasForeignKey<AdditionalInfo>(d => d.ReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdditionalInfo_CheckoutDetails");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.ToTable("Address");

            entity.HasIndex(e => e.CityId, "IX_CityId");

            entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

            entity.HasIndex(e => e.DriverId, "IX_DriverId").HasFillFactor(100);

            entity.HasIndex(e => e.IsDeleted, "IX_IsDeleted");

            entity.HasIndex(e => e.NationalId, "IX_NationalId");

            entity.HasIndex(e => e.PostCode, "IX_PostCode");

            entity.Property(e => e.AdditionalNumber).HasMaxLength(500);
            entity.Property(e => e.Address1).HasMaxLength(500);
            entity.Property(e => e.Address2).HasMaxLength(500);
            entity.Property(e => e.AddressLoction).HasMaxLength(50);
            entity.Property(e => e.BuildingNumber).HasMaxLength(500);
            entity.Property(e => e.City).HasMaxLength(500);
            entity.Property(e => e.CityId).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsMaster).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsPrimaryAddress).HasMaxLength(500);
            entity.Property(e => e.Latitude).HasMaxLength(500);
            entity.Property(e => e.Longitude).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NationalId).HasMaxLength(255);
            entity.Property(e => e.ObjLatLng).HasMaxLength(500);
            entity.Property(e => e.PkaddressId)
                .HasMaxLength(500)
                .HasColumnName("PKAddressID");
            entity.Property(e => e.PostCode).HasMaxLength(500);
            entity.Property(e => e.RegionId).HasMaxLength(500);
            entity.Property(e => e.RegionName).HasMaxLength(500);
            entity.Property(e => e.Restriction).HasMaxLength(500);
            entity.Property(e => e.Street).HasMaxLength(500);
            entity.Property(e => e.UnitNumber).HasMaxLength(500);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.Driver).WithMany(p => p.Addresses)
                .HasForeignKey(d => d.DriverId)
                .HasConstraintName("FK_Address_Driver");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.HasIndex(e => e.PhoneNumber, "idx_Phone");

            entity.HasIndex(e => e.Email, "idx_email");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.AutoLeasingAdminId).HasMaxLength(128);
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.IsCorporateUser).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsPhoneVerifiedByYakeen).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LockedBy).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            entity.Property(e => e.Otp).HasColumnName("OTP");
            entity.Property(e => e.OtpexpirationDate)
                .HasColumnType("datetime")
                .HasColumnName("OTPExpirationDate");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasOne(d => d.Language).WithMany(p => p.AspNetUsers)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.AspNetUsers_dbo.Language_LanguageId");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetUsers)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.AspNetUsers_dbo.Role_RoleID");
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.Property(e => e.AspNetUserId)
                .HasMaxLength(128)
                .HasColumnName("AspNetUser_Id");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.AspNetUserId)
                .HasMaxLength(128)
                .HasColumnName("AspNetUser_Id");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserRole>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.RoleId }).HasName("PK_dbo.AspNetUserRoles");

            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.RoleId).HasMaxLength(128);
            entity.Property(e => e.AspNetUserId)
                .HasMaxLength(128)
                .HasColumnName("AspNetUser_Id");

            entity.HasOne(d => d.Role).WithMany(p => p.AspNetUserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AtoleasingTicketType>(entity =>
        {
            entity.Property(e => e.TicketTypeNameAr).HasMaxLength(50);
            entity.Property(e => e.TicketTypeNameEn).HasMaxLength(50);
        });

        modelBuilder.Entity<Attachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Attachme__3214EC077F8256EB");

            entity.ToTable("Attachment");

            entity.Property(e => e.AttachmentFile).HasColumnType("image");
            entity.Property(e => e.AttachmentName).HasMaxLength(100);
            entity.Property(e => e.AttachmentType).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoleasingAgencyRepair>(entity =>
        {
            entity.ToTable("AutoleasingAgencyRepair");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FifthYear).HasMaxLength(50);
            entity.Property(e => e.FirstYear).HasMaxLength(50);
            entity.Property(e => e.FourthYear).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SecondYear).HasMaxLength(50);
            entity.Property(e => e.ThirdYear).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoleasingAgencyRepairHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AutoleasingAgencyRepairHistory");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.FifthYear).HasMaxLength(50);
            entity.Property(e => e.FirstYear).HasMaxLength(50);
            entity.Property(e => e.FourthYear).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.SecondYear).HasMaxLength(50);
            entity.Property(e => e.ThirdYear).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoleasingBenefit>(entity =>
        {
            entity.ToTable("AutoleasingBenefit");

            entity.Property(e => e.ArabicDescription)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<AutoleasingDeductible>(entity =>
        {
            entity.Property(e => e.Value).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<AutoleasingDepreciationSetting>(entity =>
        {
            entity.ToTable("AutoleasingDepreciationSetting");

            entity.Property(e => e.AnnualDepreciationPercentage).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FifthYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FirstYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FourthYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.IsDynamic).HasDefaultValueSql("((0))");
            entity.Property(e => e.MakerName).HasMaxLength(50);
            entity.Property(e => e.ModelName).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SecondYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ThirdYear).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<AutoleasingDepreciationSettingHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AutoleasingDepreciationSettingHistory");

            entity.Property(e => e.AnnualDepreciationPercentage).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.FifthYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FirstYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FourthYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MakerName).HasMaxLength(255);
            entity.Property(e => e.ModelName).HasMaxLength(255);
            entity.Property(e => e.Percentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SecondYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ThirdYear).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<AutoleasingInitialQuotationCompany>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<AutoleasingMinimumPremium>(entity =>
        {
            entity.ToTable("AutoleasingMinimumPremium");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FifthYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FirstYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FourthYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.SecondYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ThirdYear).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<AutoleasingMinimumPremiumHistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AutoleasingMinimumPremiumHistory");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.FifthYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FirstYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.FourthYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.SecondYear).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ThirdYear).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<AutoleasingQuotationForm>(entity =>
        {
            entity.ToTable("AutoleasingQuotationForm");

            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.UserEmail).HasMaxLength(500);
            entity.Property(e => e.UserId).HasMaxLength(500);
        });

        modelBuilder.Entity<AutoleasingQuotationFormOldHistory>(entity =>
        {
            entity.ToTable("AutoleasingQuotationForm_OldHistory");

            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.VehicleId).HasMaxLength(30);
        });

        modelBuilder.Entity<AutoleasingQuotationFormOldHistoryOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AutoleasingQuotationForm_OldHistory_Old");

            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.VehicleId).HasMaxLength(30);
        });

        modelBuilder.Entity<AutoleasingQuotationFormSetting>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.Deductible).HasMaxLength(20);
            entity.Property(e => e.Depreciation).HasMaxLength(200);
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InsurancePercentage).HasMaxLength(20);
            entity.Property(e => e.MinimumPremium).HasMaxLength(20);
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Premium).HasMaxLength(20);
            entity.Property(e => e.Premium1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Premium2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Premium3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Premium4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Premium5).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RepairMethod).HasMaxLength(20);
            entity.Property(e => e.SelectedInsuranceCompanyName).HasMaxLength(500);
            entity.Property(e => e.Total5YearsPremium).HasMaxLength(20);
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.VehicleId).HasMaxLength(30);
        });

        modelBuilder.Entity<AutoleasingQuotationResponseCache>(entity =>
        {
            entity.ToTable("AutoleasingQuotationResponseCache");

            entity.HasIndex(e => e.InsuranceCompanyId, "IX_CompId");

            entity.HasIndex(e => e.CreateDateTime, "IX_CreatedDate");

            entity.HasIndex(e => e.ExternalId, "IX_ExternalId");

            entity.HasIndex(e => new { e.InsuranceCompanyId, e.ExternalId, e.VehicleAgencyRepair, e.DeductibleValue, e.UserId, e.CreateDateTime }, "IX_IC_ExId_AR_DV_UId_C");

            entity.HasIndex(e => new { e.InsuranceCompanyId, e.ExternalId, e.VehicleAgencyRepair, e.DeductibleValue, e.CreateDateTime }, "Ix_CompId_ExternalId_VAR_DV_CD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoleasingRenewalPolicyStatistic>(entity =>
        {
            entity.ToTable("AutoleasingRenewalPolicyStatistic");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.ExternalId).HasMaxLength(100);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ParentExternalId).HasMaxLength(100);
            entity.Property(e => e.ParentReferenceId).HasMaxLength(50);
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.SequenceNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(250);
        });

        modelBuilder.Entity<AutoleasingSelectedBenifit>(entity =>
        {
            entity.Property(e => e.ExternalId).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoleasingUser>(entity =>
        {
            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.AdminId).HasMaxLength(128);
            entity.Property(e => e.BankName).HasMaxLength(128);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(500);
            entity.Property(e => e.IsFirstLogin).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(500);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.Region).HasMaxLength(255);
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AutoleasingVerifyUser>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.MethodName).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.VerificationCode).HasMaxLength(10);
        });

        modelBuilder.Entity<AutoleasingWalletHistory>(entity =>
        {
            entity.ToTable("AutoleasingWalletHistory");

            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CompanyKey).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Method).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.RemainingBalance).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<AutomatedTestIntegrationTransaction>(entity =>
        {
            entity.ToTable("AutomatedTestIntegrationTransaction");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Message).HasMaxLength(200);
            entity.Property(e => e.Retrieved).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Bank>(entity =>
        {
            entity.ToTable("Bank");

            entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.BankKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(500);
            entity.Property(e => e.Iban)
                .HasMaxLength(500)
                .HasColumnName("IBAN");
            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
            entity.Property(e => e.NationalAddress).HasMaxLength(500);
            entity.Property(e => e.PhoneNumber).HasMaxLength(500);
        });

        modelBuilder.Entity<BankCode>(entity =>
        {
            entity.ToTable("BankCode");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<BankInsuranceCompany>(entity =>
        {
            entity.ToTable("BankInsuranceCompany");

            entity.Property(e => e.CompanyKey).HasMaxLength(50);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<BankNin>(entity =>
        {
            entity.Property(e => e.Nin)
                .HasMaxLength(50)
                .HasColumnName("NIN");
        });

        modelBuilder.Entity<BcareWithdrawalWinner>(entity =>
        {
            entity.ToTable("BcareWithdrawalWinner");

            entity.HasIndex(e => e.NationalId, "IX_NationalId");

            entity.HasIndex(e => e.SequenceNumber, "IX_SeqNo");

            entity.Property(e => e.ArabicName).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EnglishName).HasMaxLength(255);
            entity.Property(e => e.MobileNumber).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.PrizeNumber).HasDefaultValueSql("((1))");
            entity.Property(e => e.SequenceNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<BcareWithdrawalWinnerOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BcareWithdrawalWinnerOld");

            entity.Property(e => e.ArabicName).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EnglishName).HasMaxLength(255);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MobileNumber).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.SequenceNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<Benefit>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Benefit");

            entity.HasIndex(e => e.Code, "idx_Code");

            entity.Property(e => e.ArabicDescription).HasMaxLength(1000);
            entity.Property(e => e.EnglishDescription).HasMaxLength(1000);
        });

        modelBuilder.Entity<BenefitService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InsuranceCompanyBenefitServices");

            entity.Property(e => e.DescriptionAr).HasMaxLength(100);
            entity.Property(e => e.DescriptionEn).HasMaxLength(100);
            entity.Property(e => e.ServiceName).HasMaxLength(100);
        });

        modelBuilder.Entity<BreakingSystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Breaking__3214EC079D6FBC87");

            entity.ToTable("BreakingSystem");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<CameraType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CameraTy__3214EC07E69DAA55");

            entity.ToTable("CameraType");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<CancellationRequest>(entity =>
        {
            entity.ToTable("CancellationRequest");

            entity.Property(e => e.CancelDate).HasColumnType("datetime");
            entity.Property(e => e.CancellationAttachment).HasMaxLength(1000);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<CardIdtype>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CardIDType");

            entity.Property(e => e.Code).ValueGeneratedOnAdd();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<Career>(entity =>
        {
            entity.ToTable("Career");

            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CityName).HasMaxLength(255);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FullName).HasMaxLength(150);
            entity.Property(e => e.JobTitle).HasMaxLength(500);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.ServerIp).HasMaxLength(50);
            entity.Property(e => e.UserAgent).HasMaxLength(500);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<CheckoutAdditionalDriver>(entity =>
        {
            entity.HasIndex(e => e.CheckoutDetailsId, "idx_CheckoutDetailsId");

            entity.HasIndex(e => e.DriverId, "idx_DriverId");

            entity.Property(e => e.CheckoutDetailsId).HasMaxLength(50);

            entity.HasOne(d => d.CheckoutDetails).WithMany(p => p.CheckoutAdditionalDrivers)
                .HasForeignKey(d => d.CheckoutDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CheckOutAdditionalDrivers_CheckoutDetails");

            entity.HasOne(d => d.Driver).WithMany(p => p.CheckoutAdditionalDrivers)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CheckoutAdditionalDrivers_Driver");
        });

        modelBuilder.Entity<CheckoutCarImage>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ImageData).HasColumnType("image");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(1000)
                .HasColumnName("ImageURL");
        });

        modelBuilder.Entity<CheckoutDetail>(entity =>
        {
            entity.HasKey(e => e.ReferenceId);

            entity.HasIndex(e => e.Channel, "IX_Channel");

            entity.HasIndex(e => e.CreatedDateTime, "IX_CreatedDateTime");

            entity.HasIndex(e => e.Email, "IX_Email");

            entity.HasIndex(e => e.Iban, "IX_IBAN");

            entity.HasIndex(e => e.IsCancelled, "IX_IsCancelled");

            entity.HasIndex(e => e.IsEmailVerified, "IX_IsEmailVerified");

            entity.HasIndex(e => e.MerchantTransactionId, "IX_MerchantTransactionId");

            entity.HasIndex(e => e.PolicyStatusId, "IX_PolicyStatusId");

            entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

            entity.HasIndex(e => e.SelectedProductId, "IX_SelectedProductId");

            entity.HasIndex(e => e.UserId, "IX_UserId").HasFillFactor(100);

            entity.HasIndex(e => e.AdditionalDriverIdFour, "idx_AdditionalDriverIdFour");

            entity.HasIndex(e => e.AdditionalDriverIdOne, "idx_AdditionalDriverIdOne");

            entity.HasIndex(e => e.AdditionalDriverIdThree, "idx_AdditionalDriverIdThree");

            entity.HasIndex(e => e.AdditionalDriverIdTwo, "idx_AdditionalDriverIdTwo");

            entity.HasIndex(e => e.MainDriverId, "idx_MainDriverId");

            entity.HasIndex(e => e.Phone, "idx_Phone");

            entity.HasIndex(e => e.VehicleId, "idx_VehicleId");

            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.BankCodeId).HasColumnName("bankCodeId");
            entity.Property(e => e.CancelationDate).HasColumnType("date");
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DiscountCode).HasMaxLength(50);
            entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .HasColumnName("IBAN");
            entity.Property(e => e.InsuranceCompanyName).HasMaxLength(255);
            entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsEmailVerified).HasDefaultValueSql("((0))");
            entity.Property(e => e.MainPolicyReferenceId).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Odreference)
                .HasMaxLength(50)
                .HasColumnName("ODReference");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.ImageBack).WithMany(p => p.CheckoutDetailImageBacks)
                .HasForeignKey(d => d.ImageBackId)
                .HasConstraintName("FK_CheckoutDetails_CheckoutCarBackImage");

            entity.HasOne(d => d.ImageBody).WithMany(p => p.CheckoutDetailImageBodies)
                .HasForeignKey(d => d.ImageBodyId)
                .HasConstraintName("FK_CheckoutDetails_CheckoutCarBodyImage");

            entity.HasOne(d => d.ImageFront).WithMany(p => p.CheckoutDetailImageFronts)
                .HasForeignKey(d => d.ImageFrontId)
                .HasConstraintName("FK_CheckoutDetails_CheckoutCarFrontImage");

            entity.HasOne(d => d.ImageLeft).WithMany(p => p.CheckoutDetailImageLefts)
                .HasForeignKey(d => d.ImageLeftId)
                .HasConstraintName("FK_CheckoutDetails_CheckoutCarLeftImage");

            entity.HasOne(d => d.ImageRight).WithMany(p => p.CheckoutDetailImageRights)
                .HasForeignKey(d => d.ImageRightId)
                .HasConstraintName("FK_CheckoutDetails_CheckoutCarRightImage");

            entity.HasOne(d => d.InsuranceCompany).WithMany(p => p.CheckoutDetails)
                .HasForeignKey(d => d.InsuranceCompanyId)
                .HasConstraintName("FK_CheckoutDetails_InsuranceCompany");

            entity.HasOne(d => d.MainDriver).WithMany(p => p.CheckoutDetails)
                .HasForeignKey(d => d.MainDriverId)
                .HasConstraintName("FK_CheckoutDetails_MainDriver");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.CheckoutDetails)
                .HasForeignKey(d => d.PaymentMethodId)
                .HasConstraintName("FK_CheckoutDetails_PaymentMethod");

            entity.HasOne(d => d.PolicyStatus).WithMany(p => p.CheckoutDetails)
                .HasForeignKey(d => d.PolicyStatusId)
                .HasConstraintName("FK_CheckoutDetails_PolicyStatus");

            entity.HasOne(d => d.SelectedInsuranceTypeCodeNavigation).WithMany(p => p.CheckoutDetails)
                .HasForeignKey(d => d.SelectedInsuranceTypeCode)
                .HasConstraintName("FK_CheckoutDetails_ProductType");

            entity.HasOne(d => d.SelectedProduct).WithMany(p => p.CheckoutDetails)
                .HasForeignKey(d => d.SelectedProductId)
                .HasConstraintName("FK_CheckoutDetails_Product");

            entity.HasOne(d => d.User).WithMany(p => p.CheckoutDetails)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CheckoutDetails_User");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.CheckoutDetails)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CheckoutDetails_Vehicle");
        });

        modelBuilder.Entity<CheckoutDriverInfo>(entity =>
        {
            entity.ToTable("CheckoutDriverInfo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedBy).HasMaxLength(255);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .HasColumnName("IBAN");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Nin).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<CheckoutHyperpayPaymentReq>(entity =>
        {
            entity.HasKey(e => new { e.HyperpayPaymenRequestId, e.CheckoutdetailsId });

            entity.ToTable("Checkout_HyperpayPaymentReq");

            entity.Property(e => e.CheckoutdetailsId).HasMaxLength(50);
        });

        modelBuilder.Entity<CheckoutUser>(entity =>
        {
            entity.HasIndex(e => new { e.UserId, e.PhoneNumber, e.IsCodeVerified }, "idx_UserID_PhoneNumber_IsCodeVerified");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomCardNumber).HasMaxLength(50);
            entity.Property(e => e.IsCodeVerified).HasDefaultValueSql("((0))");
            entity.Property(e => e.Nin).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.SequenceNumber).HasMaxLength(50);
            entity.Property(e => e.UserEmail).HasMaxLength(50);
            entity.Property(e => e.VerificationCode).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CheckoutUsersTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CheckoutUsersTemp");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Nin).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.UserEmail).HasMaxLength(50);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("City");

            entity.Property(e => e.ArabicDescription).HasMaxLength(128);
            entity.Property(e => e.EnglishDescription).HasMaxLength(128);

            entity.HasOne(d => d.Region).WithMany(p => p.Cities)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_City_Region");
        });

        modelBuilder.Entity<CityCenter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CityCenter_1");

            entity.ToTable("CityCenter");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArabicName).HasMaxLength(100);
            entity.Property(e => e.CityId)
                .HasMaxLength(50)
                .HasColumnName("CityID");
            entity.Property(e => e.ElmCode)
                .HasMaxLength(50)
                .HasColumnName("ELM_Code");
            entity.Property(e => e.EnglishName).HasMaxLength(100);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.RegionArabicName).HasMaxLength(100);
            entity.Property(e => e.RegionEnglishName).HasMaxLength(100);
            entity.Property(e => e.RegionId)
                .HasMaxLength(50)
                .HasColumnName("RegionID");
        });

        modelBuilder.Entity<Cityold>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Cityold");

            entity.Property(e => e.ArabicDescription).HasMaxLength(128);
            entity.Property(e => e.EnglishDescription).HasMaxLength(128);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Clients");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.AllowedOrigin).HasMaxLength(100);
            entity.Property(e => e.AuthServerUrl).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.RedirectUrl).HasMaxLength(100);
        });

        modelBuilder.Entity<CommissionsAndFee>(entity =>
        {
            entity.Property(e => e.CompanyKey).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FixedFees).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.IsFixedFeesNegative).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsPercentageNegative).HasDefaultValueSql("((0))");
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<CommissionsAndFeesBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CommissionsAndFeesBackup");

            entity.Property(e => e.CompanyKey).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FixedFees).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<CommissionsAndFeesBackupMay2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CommissionsAndFeesBackupMay2022");

            entity.Property(e => e.CompanyKey).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FixedFees).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<CommissionsAndFeesTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CommissionsAndFeesTemp");

            entity.Property(e => e.CompanyKey).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FixedFees).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.ModifiedBy).HasMaxLength(500);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<CompanyBankAccount>(entity =>
        {
            entity.Property(e => e.Address1).HasMaxLength(500);
            entity.Property(e => e.Address2).HasMaxLength(500);
            entity.Property(e => e.Address3).HasMaxLength(500);
            entity.Property(e => e.Bank).HasMaxLength(255);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(255);
            entity.Property(e => e.ComapnyKey).HasMaxLength(255);
            entity.Property(e => e.CrNumber).HasMaxLength(255);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Iban)
                .HasMaxLength(255)
                .HasColumnName("IBAN");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Swiftcode)
                .HasMaxLength(50)
                .HasColumnName("SWIFTCODE");
            entity.Property(e => e.TransferedPercentage).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.ToTable("Contact");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.HomePhone).HasMaxLength(50);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Nin).HasMaxLength(50);
            entity.Property(e => e.ServerIp).HasMaxLength(50);
            entity.Property(e => e.UserAgent).HasMaxLength(500);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<CorporateAccount>(entity =>
        {
            entity.ToTable("CorporateAccount");

            entity.Property(e => e.Balance).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(256);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<CorporateUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.NotificationDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<CorporateVerifyUser>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.MethodName).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.VerificationCode).HasMaxLength(10);
        });

        modelBuilder.Entity<CorporateWalletHistory>(entity =>
        {
            entity.ToTable("CorporateWalletHistory");

            entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MethodName).HasMaxLength(100);
            entity.Property(e => e.ReferenceId).HasMaxLength(20);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Country");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.ArabicDescription).HasMaxLength(256);
            entity.Property(e => e.EnglishDescription).HasMaxLength(256);
        });

        modelBuilder.Entity<CustomCardInfo>(entity =>
        {
            entity.ToTable("CustomCardInfo");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CarOwnerName).HasMaxLength(255);
            entity.Property(e => e.CarPlateText1).HasMaxLength(50);
            entity.Property(e => e.CarPlateText2).HasMaxLength(50);
            entity.Property(e => e.CarPlateText3).HasMaxLength(50);
            entity.Property(e => e.ChassisNumber).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomCardNumber).HasMaxLength(50);
            entity.Property(e => e.MajorColor).HasMaxLength(255);
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.RegisterationPlace).HasMaxLength(255);
            entity.Property(e => e.VehicleMaker).HasMaxLength(255);
            entity.Property(e => e.VehicleModel).HasMaxLength(255);
        });

        modelBuilder.Entity<CustomCardQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CustomCardQueue__3214EC074BF80DB1");

            entity.ToTable("CustomCardQueue");

            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CustomCardNumber).HasMaxLength(50);
            entity.Property(e => e.DontProcessBeforeDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo).HasMaxLength(255);
            entity.Property(e => e.PolicyStatusId).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProcessedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .HasColumnName("ServerIP");
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<Deductible>(entity =>
        {
            entity.ToTable("Deductible");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");
            entity.Property(e => e.Name).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.InsuranceCompany).WithMany(p => p.Deductibles)
                .HasForeignKey(d => d.InsuranceCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deductible_InsuranceCompany");
        });

        modelBuilder.Entity<DeservingDiscount>(entity =>
        {
            entity.ToTable("DeservingDiscount");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.NationalId).HasMaxLength(50);
        });

        modelBuilder.Entity<DeservingDiscountTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DeservingDiscountTemp");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Mobile).HasMaxLength(20);
            entity.Property(e => e.NationalId).HasMaxLength(50);
        });

        modelBuilder.Entity<DistanceRange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Distance__3214EC07E8E2A7CF");

            entity.ToTable("DistanceRange");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.ToTable("Driver");

            entity.HasIndex(e => e.Nin, "IX_Driver_NIN");

            entity.HasIndex(e => e.MedicalConditionId, "IX_MedicalConditionId");

            entity.HasIndex(e => new { e.Nin, e.IsDeleted }, "IX_Nin_IsDeleted");

            entity.HasIndex(e => e.WorkCityId, "IX_WorkCityId");

            entity.HasIndex(e => new { e.Nin, e.MedicalConditionId }, "Nin_MCID");

            entity.Property(e => e.DriverId).ValueGeneratedNever();
            entity.Property(e => e.CityName).HasMaxLength(255);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirthG).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirthH).HasMaxLength(100);
            entity.Property(e => e.EducationName).HasMaxLength(255);
            entity.Property(e => e.IdExpiryDate).HasMaxLength(50);
            entity.Property(e => e.IdIssuePlace).HasMaxLength(50);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NcdfreeYears).HasColumnName("NCDFreeYears");
            entity.Property(e => e.Ncdreference)
                .HasMaxLength(50)
                .HasColumnName("NCDReference");
            entity.Property(e => e.Nin)
                .HasMaxLength(50)
                .HasColumnName("NIN");
            entity.Property(e => e.Noalast5Years).HasColumnName("NOALast5Years");
            entity.Property(e => e.Noclast5Years).HasColumnName("NOCLast5Years");
            entity.Property(e => e.OccupationCode).HasMaxLength(50);
            entity.Property(e => e.OccupationName).HasMaxLength(255);
            entity.Property(e => e.PostCode).HasMaxLength(255);
            entity.Property(e => e.ResidentOccupation).HasMaxLength(50);
            entity.Property(e => e.SocialStatusName).HasMaxLength(255);
            entity.Property(e => e.WorkCityName).HasMaxLength(255);

            entity.HasOne(d => d.City).WithMany(p => p.DriverCities)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Driver__CityId__11158940");

            entity.HasOne(d => d.Occupation).WithMany(p => p.Drivers)
                .HasForeignKey(d => d.OccupationId)
                .HasConstraintName("FK_Driver_Ocuupation");

            entity.HasOne(d => d.WorkCity).WithMany(p => p.DriverWorkCities)
                .HasForeignKey(d => d.WorkCityId)
                .HasConstraintName("FK__Driver__WorkCity__1209AD79");
        });

        modelBuilder.Entity<DriverExtraLicense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DriverEx__3214EC07226EB699");

            entity.ToTable("DriverExtraLicense");

            entity.HasIndex(e => e.DriverId, "idx_DriverId");

            entity.HasOne(d => d.Driver).WithMany(p => p.DriverExtraLicenses)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DriverExt__Drive__125EB334");
        });

        modelBuilder.Entity<DriverLicense>(entity =>
        {
            entity.HasKey(e => e.LicenseId);

            entity.ToTable("DriverLicense");

            entity.HasIndex(e => e.DriverId, "IX_DriverId_Includes").HasFillFactor(100);

            entity.Property(e => e.ExpiryDateH).HasMaxLength(20);
            entity.Property(e => e.IssueDateH).HasMaxLength(20);
            entity.Property(e => e.LicnsTypeDesc)
                .HasMaxLength(255)
                .HasColumnName("licnsTypeDesc");

            entity.HasOne(d => d.Driver).WithMany(p => p.DriverLicenses)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DriverLicense_Driver");

            entity.HasOne(d => d.TypeDescNavigation).WithMany(p => p.DriverLicenses)
                .HasForeignKey(d => d.TypeDesc)
                .HasConstraintName("FK_DriverLicense_LicenseType");
        });

        modelBuilder.Entity<DriverMedicalCondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DriverMe__3214EC0759BB4C83");

            entity.ToTable("DriverMedicalCondition");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<DriverType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("DriverType");

            entity.Property(e => e.Code).ValueGeneratedOnAdd();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<DriverViolation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DriverVi__3214EC07F2B7890B");

            entity.ToTable("DriverViolation");

            entity.HasIndex(e => e.DriverId, "DriverId");

            entity.HasIndex(e => e.InsuredId, "IX_InsuredId");

            entity.HasIndex(e => e.Nin, "IX_Nin");

            entity.Property(e => e.Nin)
                .HasMaxLength(50)
                .HasColumnName("NIN");

            entity.HasOne(d => d.Driver).WithMany(p => p.DriverViolations)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DriverVio__Drive__14E61A24");
        });

        modelBuilder.Entity<DrivingLicenceYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DrivingL__3214EC07F67EBDE4");

            entity.ToTable("DrivingLicenceYear");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<EdaatCompany>(entity =>
        {
            entity.ToTable("EdaatCompany");

            entity.Property(e => e.CommissionerEmail).HasMaxLength(50);
            entity.Property(e => e.CommissionerMobileNo).HasMaxLength(15);
            entity.Property(e => e.CommissionerName).HasMaxLength(100);
            entity.Property(e => e.CommissionerNationalId).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerRefNumber).HasMaxLength(15);
            entity.Property(e => e.NameAr).HasMaxLength(100);
            entity.Property(e => e.NameEn).HasMaxLength(100);
            entity.Property(e => e.RegistrationNo).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.EdaatRequest).WithMany(p => p.EdaatCompanies).HasForeignKey(d => d.EdaatRequestId);
        });

        modelBuilder.Entity<EdaatCustomer>(entity =>
        {
            entity.ToTable("EdaatCustomer");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerRefNumber).HasMaxLength(15);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirthHijri).HasMaxLength(12);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FatherNameAr).HasMaxLength(30);
            entity.Property(e => e.FatherNameEn).HasMaxLength(30);
            entity.Property(e => e.FirstNameAr).HasMaxLength(30);
            entity.Property(e => e.FirstNameEn).HasMaxLength(30);
            entity.Property(e => e.GrandFatherNameAr).HasMaxLength(30);
            entity.Property(e => e.GrandFatherNameEn).HasMaxLength(30);
            entity.Property(e => e.LastNameAr).HasMaxLength(30);
            entity.Property(e => e.LastNameEn).HasMaxLength(30);
            entity.Property(e => e.MobileNo).HasMaxLength(50);
            entity.Property(e => e.NationalId)
                .HasMaxLength(10)
                .HasColumnName("NationalID");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.EdaatRequest).WithMany(p => p.EdaatCustomers)
                .HasForeignKey(d => d.EdaatRequestId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<EdaatNotification>(entity =>
        {
            entity.ToTable("EdaatNotification");

            entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

            entity.Property(e => e.BillNo).HasMaxLength(250);
            entity.Property(e => e.Channel).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.InternalCode).HasMaxLength(250);
            entity.Property(e => e.InvoiceNo).HasMaxLength(250);
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentDate).HasMaxLength(250);
            entity.Property(e => e.ReferenceId).HasMaxLength(250);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .HasColumnName("ServerIP");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UserIp)
                .HasMaxLength(255)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<EdaatProduct>(entity =>
        {
            entity.ToTable("EdaatProduct");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.EdaatRequest).WithMany(p => p.EdaatProducts)
                .HasForeignKey(d => d.EdaatRequestId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<EdaatRequest>(entity =>
        {
            entity.ToTable("EdaatRequest");

            entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

            entity.HasIndex(e => e.NationalId, "IX_NationalID");

            entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.Conditions).HasMaxLength(300);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate)
                .HasDefaultValueSql("('0001-01-01T00:00:00.0000000')")
                .HasColumnType("datetime");
            entity.Property(e => e.FromDurationTime).HasMaxLength(5);
            entity.Property(e => e.InsuredNationalId).HasMaxLength(50);
            entity.Property(e => e.InternalCode).HasMaxLength(50);
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.NationalId)
                .HasMaxLength(10)
                .HasColumnName("NationalID");
            entity.Property(e => e.ReferenceId).HasMaxLength(15);
            entity.Property(e => e.RegistrationNo).HasMaxLength(10);
            entity.Property(e => e.SubBillerRegistrationNo).HasMaxLength(250);
            entity.Property(e => e.SubBillerShareAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SubBillerSharePercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ToDurationTime).HasMaxLength(5);
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<EdaatResponse>(entity =>
        {
            entity.ToTable("EdaatResponse");

            entity.HasIndex(e => e.Success, "IX_Success");

            entity.HasIndex(e => e.InvoiceNo, "UQ__EdaatRes__D796B227918502B8").IsUnique();

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.InternalCode).HasMaxLength(20);
            entity.Property(e => e.InvoiceNo).HasMaxLength(20);
            entity.Property(e => e.ReferenceId).HasMaxLength(150);
            entity.Property(e => e.Success).HasDefaultValueSql("((0))");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.EdaatRequest).WithMany(p => p.EdaatResponses)
                .HasForeignKey(d => d.EdaatRequestId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<EducationLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Educatio__3214EC07CF78605D");

            entity.ToTable("EducationLevel");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<EmailSetting>(entity =>
        {
            entity.Property(e => e.Credentials).HasMaxLength(255);
            entity.Property(e => e.Method).HasMaxLength(255);
            entity.Property(e => e.Module).HasMaxLength(255);
            entity.Property(e => e.SenderEmailAddress).HasMaxLength(255);
            entity.Property(e => e.SmtpDeliveryMethod).HasMaxLength(50);
            entity.Property(e => e.SmtpHost).HasMaxLength(255);
            entity.Property(e => e.SmtpTimeout).HasMaxLength(50);
        });

        modelBuilder.Entity<Endorsment>(entity =>
        {
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.QuotationReferenceId).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .HasColumnName("ServerIP");
            entity.Property(e => e.UserAgent).HasMaxLength(500);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<EndorsmentBenefit>(entity =>
        {
            entity.Property(e => e.BenefitId).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.QuotationReferenceId).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<ErrorCode>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ErrorCode");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.ArabicText).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishText).HasMaxLength(50);
        });

        modelBuilder.Entity<EsalCustomer>(entity =>
        {
            entity.ToTable("EsalCustomer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AddressArabic1).HasMaxLength(500);
            entity.Property(e => e.AddressArabic2).HasMaxLength(500);
            entity.Property(e => e.AddressEnglish1).HasMaxLength(500);
            entity.Property(e => e.AddressEnglish2).HasMaxLength(500);
            entity.Property(e => e.Branch).HasMaxLength(250);
            entity.Property(e => e.BranchArabic).HasMaxLength(250);
            entity.Property(e => e.CityArabic).HasMaxLength(250);
            entity.Property(e => e.CityEnglish).HasMaxLength(250);
            entity.Property(e => e.Code).HasMaxLength(250);
            entity.Property(e => e.ContactNo).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DivisionArabic).HasMaxLength(250);
            entity.Property(e => e.DivisionEnglish).HasMaxLength(250);
            entity.Property(e => e.Email).HasMaxLength(250);
            entity.Property(e => e.LocalityArabic).HasMaxLength(250);
            entity.Property(e => e.LocalityEnglish).HasMaxLength(250);
            entity.Property(e => e.NameArabic).HasMaxLength(250);
            entity.Property(e => e.NameEnglish).HasMaxLength(250);
            entity.Property(e => e.PlantArabic).HasMaxLength(250);
            entity.Property(e => e.PlantEnglish).HasMaxLength(250);
            entity.Property(e => e.ProdLineArabic).HasMaxLength(250);
            entity.Property(e => e.ProdLineEnglish).HasMaxLength(250);
            entity.Property(e => e.ReferenceId).HasMaxLength(250);
            entity.Property(e => e.RegionArabic).HasMaxLength(250);
            entity.Property(e => e.RegionEnglish).HasMaxLength(250);
            entity.Property(e => e.SegmentArabic).HasMaxLength(250);
            entity.Property(e => e.SegmentEnglish).HasMaxLength(250);
        });

        modelBuilder.Entity<EsalLineItem>(entity =>
        {
            entity.ToTable("EsalLineItem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountAfterDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Code).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DescriptionArabic).HasMaxLength(250);
            entity.Property(e => e.DescriptionEnglish).HasMaxLength(250);
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PriceAfterVat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReferenceId).HasMaxLength(250);
            entity.Property(e => e.TotalVat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UomArabic).HasMaxLength(50);
            entity.Property(e => e.UomEnglish).HasMaxLength(50);
            entity.Property(e => e.VatPercent).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<EsalProfitMargin>(entity =>
        {
            entity.ToTable("EsalProfitMargin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.ProcedureArabic).HasMaxLength(250);
            entity.Property(e => e.ProcedureEnglish)
                .HasMaxLength(250)
                .HasColumnName("procedureEnglish");
            entity.Property(e => e.ReferenceId).HasMaxLength(250);
        });

        modelBuilder.Entity<EsalRequest>(entity =>
        {
            entity.ToTable("EsalRequest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(50);
            entity.Property(e => e.DateOfDelivery).HasColumnType("datetime");
            entity.Property(e => e.DriverNin).HasMaxLength(250);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HasEsalInvoice).HasDefaultValueSql("((0))");
            entity.Property(e => e.InvoiceIssueDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(250);
            entity.Property(e => e.InvoiceReference).HasMaxLength(250);
            entity.Property(e => e.InvoiceType).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NarrationArabic).HasMaxLength(250);
            entity.Property(e => e.NarrationEnglish).HasMaxLength(250);
            entity.Property(e => e.OutstandingAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReferenceId).HasMaxLength(250);
            entity.Property(e => e.RemarksArabic).HasMaxLength(250);
            entity.Property(e => e.RemarksEnglish).HasMaxLength(250);
            entity.Property(e => e.RequestId)
                .HasMaxLength(250)
                .HasColumnName("RequestID");
            entity.Property(e => e.SalespersonArabic).HasMaxLength(250);
            entity.Property(e => e.SalespersonEnglish).HasMaxLength(250);
            entity.Property(e => e.SequenceNumber).HasMaxLength(250);
            entity.Property(e => e.ShipmentRefNumber).HasMaxLength(250);
            entity.Property(e => e.SupplierId).HasMaxLength(250);
            entity.Property(e => e.TotalBeforeVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalBeforeVAT");
            entity.Property(e => e.TotalVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TotalVAT");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<EsalResponse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EsalRespons");

            entity.ToTable("EsalResponse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.RequestIpaddress)
                .HasMaxLength(255)
                .HasColumnName("RequestIPAddress");
            entity.Property(e => e.ServerIp).HasColumnName("ServerIP");
        });

        modelBuilder.Entity<EsalSettlement>(entity =>
        {
            entity.ToTable("EsalSettlement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccessChannel).HasMaxLength(150);
            entity.Property(e => e.AccountIdBillerId).HasMaxLength(150);
            entity.Property(e => e.AccountIdBillingAcct).HasMaxLength(150);
            entity.Property(e => e.BankId).HasMaxLength(150);
            entity.Property(e => e.BeneficiaryIdOfficialId).HasMaxLength(150);
            entity.Property(e => e.BeneficiaryIdOfficialIdType).HasMaxLength(150);
            entity.Property(e => e.BillerReconUploadRqCollectPmtAmt).HasMaxLength(150);
            entity.Property(e => e.BillerReconUploadRqPrcDt).HasMaxLength(150);
            entity.Property(e => e.BillerReconUploadRqReconPmtAmt).HasMaxLength(150);
            entity.Property(e => e.BillerReconUploadRqTransFees).HasMaxLength(150);
            entity.Property(e => e.BillerReconUploadRqUnReconPmtAmt).HasMaxLength(150);
            entity.Property(e => e.BranchCode).HasMaxLength(150);
            entity.Property(e => e.ChkDigit).HasMaxLength(150);
            entity.Property(e => e.CustIdOfficialId).HasMaxLength(150);
            entity.Property(e => e.CustIdofficialIdType).HasMaxLength(150);
            entity.Property(e => e.DistrictCode).HasMaxLength(150);
            entity.Property(e => e.PhoneNumBeneficiaryPhoneNum).HasMaxLength(150);
            entity.Property(e => e.PmtBankRecBankId).HasMaxLength(150);
            entity.Property(e => e.PmtBankRecCurAmt).HasMaxLength(150);
            entity.Property(e => e.PmtBranchRecBranchCode).HasMaxLength(150);
            entity.Property(e => e.PmtBranchRecCurAmt).HasMaxLength(150);
            entity.Property(e => e.PmtInfoBillCycle).HasMaxLength(150);
            entity.Property(e => e.PmtInfoBillNumber).HasMaxLength(150);
            entity.Property(e => e.PmtInfoCurAmt).HasMaxLength(150);
            entity.Property(e => e.PmtInfoDueDt).HasMaxLength(150);
            entity.Property(e => e.PmtInfoPrcDt).HasMaxLength(150);
            entity.Property(e => e.PmtMethod).HasMaxLength(150);
            entity.Property(e => e.PmtRecPmtTransIdPmtId).HasMaxLength(150);
            entity.Property(e => e.PmtRecPmtTransIdPmtIdType).HasMaxLength(150);
            entity.Property(e => e.PmtRefInfo).HasMaxLength(150);
            entity.Property(e => e.PmtStatusEffDt).HasMaxLength(150);
            entity.Property(e => e.PmtStatusPmtStatusCode).HasMaxLength(150);
            entity.Property(e => e.PmtType).HasMaxLength(150);
            entity.Property(e => e.RqUid)
                .HasMaxLength(150)
                .HasColumnName("RqUID");
            entity.Property(e => e.ServiceType).HasMaxLength(150);
            entity.Property(e => e.SeverityType).HasMaxLength(150);
            entity.Property(e => e.ShortDesc).HasMaxLength(150);
            entity.Property(e => e.StatusSeverityType).HasMaxLength(150);
            entity.Property(e => e.StatusShortDesc).HasMaxLength(150);
        });

        modelBuilder.Entity<EsalSupplier>(entity =>
        {
            entity.ToTable("EsalSupplier");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BankSwiftCode).HasMaxLength(250);
            entity.Property(e => e.BranchArabic).HasMaxLength(100);
            entity.Property(e => e.BranchEnglish).HasMaxLength(250);
            entity.Property(e => e.CityArabic).HasMaxLength(250);
            entity.Property(e => e.CityEnglish).HasMaxLength(250);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Iban).HasMaxLength(250);
            entity.Property(e => e.LocalityArabic).HasMaxLength(250);
            entity.Property(e => e.LocalityEnglish).HasMaxLength(250);
            entity.Property(e => e.PlantArabic).HasMaxLength(250);
            entity.Property(e => e.PlantEnglish).HasMaxLength(250);
            entity.Property(e => e.ReferenceId).HasMaxLength(250);
            entity.Property(e => e.RegionArabic).HasMaxLength(250);
            entity.Property(e => e.RegionEnglish).HasMaxLength(250);
            entity.Property(e => e.SupplierId).HasMaxLength(250);
        });

        modelBuilder.Entity<ExpiredToken>(entity =>
        {
            entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

            entity.HasIndex(e => e.Key, "IX_KEY");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("Gender");

            entity.Property(e => e.Code).HasMaxLength(1);
            entity.Property(e => e.ArabicDescription).HasMaxLength(10);
            entity.Property(e => e.EnglishDescription).HasMaxLength(10);
        });

        modelBuilder.Entity<HyperPayCreateOrder>(entity =>
        {
            entity.ToTable("HyperPayCreateOrder");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MerchantTransactionId).HasMaxLength(256);
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.RequestConfigId).HasMaxLength(50);
            entity.Property(e => e.RequestPaymentBrand).HasMaxLength(50);
            entity.Property(e => e.TransferOption).HasMaxLength(50);
            entity.Property(e => e.UniqueId).HasMaxLength(256);
        });

        modelBuilder.Entity<HyperPayNotification>(entity =>
        {
            entity.Property(e => e.BatchId).HasMaxLength(255);
            entity.Property(e => e.BeneficiaryAccountId).HasMaxLength(255);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NotificationRefernece).HasMaxLength(255);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.ServerIp).HasMaxLength(255);
            entity.Property(e => e.UserAgent).HasMaxLength(255);
            entity.Property(e => e.UserIp).HasMaxLength(255);
        });

        modelBuilder.Entity<HyperPayNotificationTransaction>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.MerchantTransactionId).HasMaxLength(255);
            entity.Property(e => e.PayoutTransferAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UniqueId).HasMaxLength(255);
        });

        modelBuilder.Entity<HyperPayUpdateOrder>(entity =>
        {
            entity.ToTable("HyperPayUpdateOrder");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentType).HasMaxLength(50);
            entity.Property(e => e.PayoutBeneficiaryName).HasMaxLength(50);
            entity.Property(e => e.PayoutStatus).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.RequestAmount).HasMaxLength(50);
            entity.Property(e => e.RequestBeneficiaryAccountId).HasMaxLength(50);
            entity.Property(e => e.RequestConfigId).HasMaxLength(50);
            entity.Property(e => e.RequestPaymentBrand).HasMaxLength(50);
            entity.Property(e => e.RequestUniqueId).HasMaxLength(50);
            entity.Property(e => e.ResponseAmount).HasMaxLength(50);
            entity.Property(e => e.ResponseMessage).HasMaxLength(50);
            entity.Property(e => e.ResponseStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<HyperpayRequest>(entity =>
        {
            entity.ToTable("HyperpayRequest");

            entity.HasIndex(e => e.CreatedDate, "IX_CreatedDate");

            entity.HasIndex(e => e.MerchantTransactionId, "IX_MerchantTransactionId");

            entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

            entity.Property(e => e.Amount).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(3);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.PaymentType).HasMaxLength(10);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.StatusDescription).HasMaxLength(1000);
        });

        modelBuilder.Entity<HyperpayResponse>(entity =>
        {
            entity.ToTable("HyperpayResponse");

            entity.HasIndex(e => new { e.Message, e.HyperpayRequestId, e.HyperpayResponseId, e.Amount }, "IX_Message_HyperpayRequestId_HyperpayResponseId_Amount");

            entity.HasIndex(e => e.Ndc, "IX_Ndc");

            entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

            entity.Property(e => e.Amount).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.CancelationDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.HyperpayResponseId).HasMaxLength(255);
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.Ndc).HasMaxLength(255);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<IbanHistory>(entity =>
        {
            entity.ToTable("IbanHistory");

            entity.Property(e => e.Account).HasMaxLength(50);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Bank).HasMaxLength(255);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.Bic).HasMaxLength(50);
            entity.Property(e => e.Branch).HasMaxLength(255);
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.CountryIso).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .HasColumnName("IBAN");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.SepaDataB2b)
                .HasMaxLength(50)
                .HasColumnName("SepaDataB2B");
            entity.Property(e => e.SepaDataCor1)
                .HasMaxLength(50)
                .HasColumnName("SepaDataCOR1");
            entity.Property(e => e.SepaDataScc)
                .HasMaxLength(50)
                .HasColumnName("SepaDataSCC");
            entity.Property(e => e.SepaDataSct)
                .HasMaxLength(50)
                .HasColumnName("SepaDataSCT");
            entity.Property(e => e.SepaDataSdd)
                .HasMaxLength(50)
                .HasColumnName("SepaDataSDD");
            entity.Property(e => e.State).HasMaxLength(255);
            entity.Property(e => e.Www).HasMaxLength(255);
            entity.Property(e => e.Zip).HasMaxLength(50);
        });

        modelBuilder.Entity<InsuaranceCompanyBenefit>(entity =>
        {
            entity.HasKey(e => e.BenefitId);

            entity.ToTable("InsuaranceCompanyBenefit");

            entity.Property(e => e.BenefitId)
                .ValueGeneratedNever()
                .HasColumnName("BenefitID");
            entity.Property(e => e.BenefitPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.InsurnaceCompanyId).HasColumnName("InsurnaceCompanyID");

            entity.HasOne(d => d.BenefitCodeNavigation).WithMany(p => p.InsuaranceCompanyBenefits)
                .HasForeignKey(d => d.BenefitCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InsuaranceCompanyBenefit_Benefit");

            entity.HasOne(d => d.InsurnaceCompany).WithMany(p => p.InsuaranceCompanyBenefits)
                .HasForeignKey(d => d.InsurnaceCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InsuaranceCompanyBenefit_InsuaranceCompany");
        });

        modelBuilder.Entity<InsuranceCompany>(entity =>
        {
            entity.ToTable("InsuranceCompany");

            entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");
            entity.Property(e => e.ActiveTabbySanadPlus)
                .IsRequired()
                .HasDefaultValueSql("('0')");
            entity.Property(e => e.ActiveTabbyTpl).HasColumnName("ActiveTabbyTPL");
            entity.Property(e => e.ActiveTabbyWafiSmart)
                .IsRequired()
                .HasDefaultValueSql("('0')");
            entity.Property(e => e.AutoleaseReportTemplateName).HasMaxLength(255);
            entity.Property(e => e.ClassTypeName).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DescAr)
                .HasMaxLength(1000)
                .HasColumnName("DescAR");
            entity.Property(e => e.DescEn)
                .HasMaxLength(1000)
                .HasColumnName("DescEN");
            entity.Property(e => e.DiscountEndDate).HasColumnType("datetime");
            entity.Property(e => e.DiscountStartDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("('1')")
                .HasColumnName("isActive");
            entity.Property(e => e.IsActiveAutoleasing).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsActiveTpl).HasColumnName("IsActiveTPL");
            entity.Property(e => e.Key).HasMaxLength(50);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NajmGradeValidFrom).HasColumnType("datetime");
            entity.Property(e => e.NajmGradeValidTo).HasColumnType("datetime");
            entity.Property(e => e.NameAr)
                .HasMaxLength(50)
                .HasColumnName("NameAR");
            entity.Property(e => e.NameEn)
                .HasMaxLength(50)
                .HasColumnName("NameEN");
            entity.Property(e => e.NamespaceTypeName).HasMaxLength(200);
            entity.Property(e => e.ReportTemplateName).HasMaxLength(200);
            entity.Property(e => e.Temp)
                .HasMaxLength(1000)
                .HasColumnName("TEMP");
            entity.Property(e => e.TermsAndConditionsFilePath).HasMaxLength(500);
            entity.Property(e => e.TermsAndConditionsFilePathComp).HasMaxLength(255);
            entity.Property(e => e.TermsAndConditionsFilePathSanadPlus).HasMaxLength(255);
            entity.Property(e => e.UsePhoneCamera).HasDefaultValueSql("((0))");
            entity.Property(e => e.Vat)
                .HasMaxLength(50)
                .HasColumnName("VAT");

            entity.HasOne(d => d.Address).WithMany(p => p.InsuranceCompanies)
                .HasForeignKey(d => d.AddressId)
                .HasConstraintName("FK_InsuranceCompany_Address");

            entity.HasOne(d => d.Contact).WithMany(p => p.InsuranceCompanies)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("FK_InsuranceCompany_Contact");
        });

        modelBuilder.Entity<InsuranceCompanyProductTypeConfig>(entity =>
        {
            entity.HasKey(e => new { e.ProductTypeCode, e.InsuranceCompanyId });

            entity.ToTable("InsuranceCompanyProductTypeConfig");

            entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");

            entity.HasOne(d => d.ProductTypeCodeNavigation).WithMany(p => p.InsuranceCompanyProductTypeConfigs)
                .HasForeignKey(d => d.ProductTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InsuranceCompanyProductTypeConfig_ProductType");
        });

        modelBuilder.Entity<Insured>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Insured__3214EC0709618099");

            entity.ToTable("Insured");

            entity.HasIndex(e => new { e.EducationId, e.ChildrenBelow16Years, e.CityId }, "EID_CB16_CID");

            entity.HasIndex(e => e.CreatedDateTime, "idx_CreatedDateTime");

            entity.HasIndex(e => e.NationalId, "idx_NationalId");

            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.BirthDateH).HasMaxLength(10);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.FirstNameAr).HasMaxLength(500);
            entity.Property(e => e.FirstNameEn).HasMaxLength(500);
            entity.Property(e => e.LastNameAr).HasMaxLength(50);
            entity.Property(e => e.LastNameEn).HasMaxLength(50);
            entity.Property(e => e.MiddleNameAr).HasMaxLength(50);
            entity.Property(e => e.MiddleNameEn).HasMaxLength(50);
            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");
            entity.Property(e => e.NationalId).HasMaxLength(20);
            entity.Property(e => e.NationalityCode).HasMaxLength(4);
            entity.Property(e => e.OccupationCode).HasMaxLength(50);
            entity.Property(e => e.OccupationName).HasMaxLength(100);
            entity.Property(e => e.ResidentOccupation).HasMaxLength(50);

            entity.HasOne(d => d.City).WithMany(p => p.InsuredCities)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK__Insured__CityId__1A9EF37A");

            entity.HasOne(d => d.IdIssueCity).WithMany(p => p.InsuredIdIssueCities)
                .HasForeignKey(d => d.IdIssueCityId)
                .HasConstraintName("FK__Insured__IdIssue__1B9317B3");

            entity.HasOne(d => d.Occupation).WithMany(p => p.Insureds)
                .HasForeignKey(d => d.OccupationId)
                .HasConstraintName("FK_Insured_Ocuupation");

            entity.HasOne(d => d.WorkCity).WithMany(p => p.InsuredWorkCities)
                .HasForeignKey(d => d.WorkCityId)
                .HasConstraintName("FK__Insured__WorkCit__1C873BEC");
        });

        modelBuilder.Entity<InsuredAddressesCount>(entity =>
        {
            entity.ToTable("InsuredAddressesCount");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.NationalId).HasMaxLength(50);
        });

        modelBuilder.Entity<InsuredExtraLicense>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<IntegrationTransactionToBeDeleted>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_IntegrationTransaction");

            entity.ToTable("IntegrationTransaction_ToBeDeleted");

            entity.Property(e => e.Method).HasMaxLength(200);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.ToTable("Invoice");

            entity.HasIndex(e => e.InsuranceCompanyId, "IX_InsuranceCompanyId");

            entity.HasIndex(e => e.InvoiceNo, "IX_Invoice_InvoiceNo").IsUnique();

            entity.HasIndex(e => e.PolicyId, "IX_Invoice_PolicyId");

            entity.HasIndex(e => e.UserId, "IX_Invoice_UserId");

            entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId").HasFillFactor(100);

            entity.HasIndex(e => e.InvoiceDate, "ix_invoiceDate");

            entity.Property(e => e.ActualBankFees).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BasicPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CancelationDate).HasColumnType("date");
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.Discount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.DiscountPercentageValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ExtraPremiumPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Fees).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceDueDate).HasColumnType("datetime");
            entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");
            entity.Property(e => e.LoyaltyDiscountPercentage).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.LoyaltyDiscountValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.MainPolicyReferance).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Odreference)
                .HasMaxLength(50)
                .HasColumnName("ODReference");
            entity.Property(e => e.PaidAmount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ProductPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ReferenceId).HasMaxLength(200);
            entity.Property(e => e.SpecialDiscount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.SpecialDiscount2).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.SpecialDiscount2PercentageValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.SpecialDiscountPercentageValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.SubTotalPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TaxInvoiceNumber).HasMaxLength(200);
            entity.Property(e => e.TotalBcareCommission)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("TotalBCareCommission");
            entity.Property(e => e.TotalBcareDiscount)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("TotalBCareDiscount");
            entity.Property(e => e.TotalBcareFees)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("TotalBCareFees");
            entity.Property(e => e.TotalBenefitPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TotalCompanyAmount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TotalDiscount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.Vat).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.InsuranceCompany).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.InsuranceCompanyId)
                .HasConstraintName("FK_Invoice_InsuranceCompany");

            entity.HasOne(d => d.InsuranceTypeCodeNavigation).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.InsuranceTypeCode)
                .HasConstraintName("FK_Invoice_ProductType");

            entity.HasOne(d => d.Policy).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("FK_Invoice_Policy");

            entity.HasOne(d => d.User).WithMany(p => p.Invoices)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Invoice_AspNetUsers");
        });

        modelBuilder.Entity<InvoiceBenefit>(entity =>
        {
            entity.ToTable("Invoice_Benefit");

            entity.HasIndex(e => e.InvoiceId, "IX_Invoice_Benefit_InvoiceId");

            entity.Property(e => e.BenefitPrice).HasColumnType("decimal(8, 2)");

            entity.HasOne(d => d.Benefit).WithMany(p => p.InvoiceBenefits)
                .HasForeignKey(d => d.BenefitId)
                .HasConstraintName("FK_Invoice_Benefit_Benefit");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceBenefits)
                .HasForeignKey(d => d.InvoiceId)
                .HasConstraintName("FK_Invoice_Benefit_Invoice");
        });

        modelBuilder.Entity<InvoiceDriver>(entity =>
        {
            entity.ToTable("Invoice_Driver");

            entity.Property(e => e.DriverPrice).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<InvoiceFile>(entity =>
        {
            entity.ToTable("InvoiceFile");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CompanyInvoieFilePath).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.InvoiceData).HasColumnType("image");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .HasColumnName("ServerIP");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.InvoiceFile)
                .HasForeignKey<InvoiceFile>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InvoiceFile_Invoice");
        });

        modelBuilder.Entity<InvoiceFileTemplate>(entity =>
        {
            entity.Property(e => e.Active).HasDefaultValueSql("((0))");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.TemplateFilePath).HasMaxLength(500);
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InvoiceTemp24march>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Invoice_TEmp_24March");

            entity.Property(e => e.Discount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ExtraPremiumPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Fees).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceDueDate).HasColumnType("datetime");
            entity.Property(e => e.ProductPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ReferenceId).HasMaxLength(200);
            entity.Property(e => e.SubTotalPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.Vat).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.ToTable("Language");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IsDefault).HasColumnName("isDefault");
            entity.Property(e => e.NameAr)
                .HasMaxLength(50)
                .HasColumnName("NameAR");
            entity.Property(e => e.NameEn)
                .HasMaxLength(50)
                .HasColumnName("NameEN");
        });

        modelBuilder.Entity<LeasingUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LeasingUser");

            entity.Property(e => e.BankName).HasMaxLength(128);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.DriverId).HasMaxLength(128);
            entity.Property(e => e.DriverNin).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FullName).HasMaxLength(500);
            entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.UpdatedEmail).HasMaxLength(256);
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UserName).HasMaxLength(256);
            entity.Property(e => e.VehicleId).HasMaxLength(128);
            entity.Property(e => e.VehicleSequenceOrCustom).HasMaxLength(50);
        });

        modelBuilder.Entity<LeasingUsersLocationsDeviceInfo>(entity =>
        {
            entity.ToTable("LeasingUsersLocationsDeviceInfo");

            entity.Property(e => e.Client).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DeviceName).HasMaxLength(255);
            entity.Property(e => e.DeviceType).HasMaxLength(255);
            entity.Property(e => e.Os)
                .HasMaxLength(255)
                .HasColumnName("OS");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .HasColumnName("ServerIP");
            entity.Property(e => e.UserId).HasMaxLength(255);
            entity.Property(e => e.UserIp)
                .HasMaxLength(255)
                .HasColumnName("UserIP");
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<LeasingVerifyUser>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.MethodName).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.VerificationCode).HasMaxLength(10);
        });

        modelBuilder.Entity<LicenseType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("LicenseType");

            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<Logger>(entity =>
        {
            entity.ToTable("Logger");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.ExceptionDate).HasColumnType("datetime");
            entity.Property(e => e.Key).HasColumnName("key");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<MobileAppVersion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Url).HasColumnName("URL");
            entity.Property(e => e.Version).HasMaxLength(20);
        });

        modelBuilder.Entity<Moidetail>(entity =>
        {
            entity.ToTable("MOIDetail");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FileByteArray).HasColumnType("image");
            entity.Property(e => e.FileMimeType).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<MorniRequest>(entity =>
        {
            entity.ToTable("MorniRequest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Color).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomsNumber).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Make).HasMaxLength(255);
            entity.Property(e => e.Model).HasMaxLength(255);
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PlanReferenceNumber).HasMaxLength(50);
            entity.Property(e => e.PlateFirstLetterId).HasMaxLength(50);
            entity.Property(e => e.PlateNumber).HasMaxLength(255);
            entity.Property(e => e.PlateSecondLetterId).HasMaxLength(50);
            entity.Property(e => e.PlateThirdLetterId).HasMaxLength(50);
            entity.Property(e => e.PolicyEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RefrenceId).HasMaxLength(50);
            entity.Property(e => e.SequenceNumber).HasMaxLength(50);
            entity.Property(e => e.Vin)
                .HasMaxLength(255)
                .HasColumnName("VIN");
            entity.Property(e => e.Year).HasMaxLength(50);
        });

        modelBuilder.Entity<MorniSm>(entity =>
        {
            entity.ToTable("MorniSMS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsSmssent)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IsSMSSent");
            entity.Property(e => e.Lang).HasDefaultValueSql("((0))");
            entity.Property(e => e.Make).HasMaxLength(255);
            entity.Property(e => e.Model).HasMaxLength(255);
            entity.Property(e => e.OwnerFirstName).HasMaxLength(255);
            entity.Property(e => e.OwnerLastName).HasMaxLength(255);
            entity.Property(e => e.PlateInfo).HasMaxLength(255);
            entity.Property(e => e.PolicyEndDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo).HasMaxLength(255);
            entity.Property(e => e.PolicyStartDate).HasColumnType("datetime");
            entity.Property(e => e.Vin)
                .HasMaxLength(255)
                .HasColumnName("vin");
        });

        modelBuilder.Entity<NajmAccidentResponse>(entity =>
        {
            entity.ToTable("NajmAccidentResponse");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DriverNin).HasMaxLength(20);
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.MessageId)
                .HasMaxLength(10)
                .HasColumnName("MessageID");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.ReferenceNo).HasMaxLength(50);
            entity.Property(e => e.VehicleId).HasMaxLength(20);
        });

        modelBuilder.Entity<NajmResponse>(entity =>
        {
            entity.ToTable("NajmResponse");

            entity.HasIndex(e => new { e.VehicleId, e.IsDeleted, e.PolicyHolderNin, e.IsVehicleRegistered }, "VehicleId_IsDeleted_PolicyHolderNin_IsVehicleRegistered");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.NcdfreeYears).HasColumnName("NCDFreeYears");
            entity.Property(e => e.Ncdreference)
                .HasMaxLength(50)
                .HasColumnName("NCDReference");
            entity.Property(e => e.PolicyHolderNin).HasMaxLength(20);
            entity.Property(e => e.VehicleId).HasMaxLength(30);
        });

        modelBuilder.Entity<NajmStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NajmStat__3213E83FF99DD5FB");

            entity.ToTable("NajmStatus");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.NameAr).HasMaxLength(200);
            entity.Property(e => e.NameEn).HasMaxLength(200);
        });

        modelBuilder.Entity<NajmStatusHistory>(entity =>
        {
            entity.ToTable("NajmStatusHistory");

            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.StatusDescription).HasMaxLength(2000);
            entity.Property(e => e.UploadedDate).HasColumnType("datetime");
            entity.Property(e => e.UploadedReference).HasMaxLength(50);
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.ToTable("Nationality");

            entity.Property(e => e.ArabicDescription).HasMaxLength(255);
            entity.Property(e => e.EnglishDescription).HasMaxLength(255);
        });

        modelBuilder.Entity<NcdfreeYear>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("NCDFreeYear");

            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.ToTable("Notification");

            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.Group).HasMaxLength(256);
            entity.Property(e => e.GroupReferenceId).HasMaxLength(256);
        });

        modelBuilder.Entity<NotificationParameter>(entity =>
        {
            entity.ToTable("NotificationParameter");

            entity.Property(e => e.Name).HasMaxLength(256);

            entity.HasOne(d => d.Notification).WithMany(p => p.NotificationParameters)
                .HasForeignKey(d => d.NotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NotificationParameter_Notification");
        });

        modelBuilder.Entity<Occupation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Occupati__3214EC0767A1E218");

            entity.ToTable("Occupation");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.NameAr).HasMaxLength(100);
            entity.Property(e => e.NameEn).HasMaxLength(100);
        });

        modelBuilder.Entity<Offer>(entity =>
        {
            entity.ToTable("Offer");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(128);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.TextAr).HasMaxLength(500);
            entity.Property(e => e.TextEn).HasMaxLength(500);
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderIte__3214EC07AEA26B89");

            entity.ToTable("OrderItem");

            entity.HasIndex(e => e.CheckoutDetailReferenceId, "IX_OrderItem_CheckoutDetailReferenceId");

            entity.Property(e => e.CheckoutDetailReferenceId).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.CheckoutDetailReference).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.CheckoutDetailReferenceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderItem_CheckOutDetail");
        });

        modelBuilder.Entity<OrderItemBenefit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderIte__3214EC07DF47DE2C");

            entity.ToTable("OrderItemBenefit");

            entity.HasIndex(e => e.OrderItemId, "idx_OrderItemId");

            entity.Property(e => e.BenefitExternalId).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(19, 4)");

            entity.HasOne(d => d.Benefit).WithMany(p => p.OrderItemBenefits)
                .HasForeignKey(d => d.BenefitId)
                .HasConstraintName("FK_OrderItemBenefit_Benefit");

            entity.HasOne(d => d.OrderItem).WithMany(p => p.OrderItemBenefits)
                .HasForeignKey(d => d.OrderItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderItemBenefit_OrderItem");
        });

        modelBuilder.Entity<OrderItemDriver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderItemDriver");

            entity.ToTable("OrderItemDriver");

            entity.Property(e => e.DriverExternalId).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(19, 4)");
        });

        modelBuilder.Entity<OtpInfo>(entity =>
        {
            entity.ToTable("OtpInfo");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Nin).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.UserEmail).HasMaxLength(500);
        });

        modelBuilder.Entity<OwnDamageQueue>(entity =>
        {
            entity.ToTable("OwnDamageQueue");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(128);
            entity.Property(e => e.Method).HasMaxLength(50);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PolicyExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.ProcessedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .HasColumnName("ServerIP");
        });

        modelBuilder.Entity<ParkingPlace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ParkingP__3214EC078FCF4A9C");

            entity.ToTable("ParkingPlace");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<PayfortPaymentRequest>(entity =>
        {
            entity.ToTable("PayfortPaymentRequest");

            entity.HasIndex(e => e.ReferenceNumber, "IX_PayfortPaymentRequest_ReferenceNumber").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.CancelationDate).HasColumnType("date");
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");
            entity.Property(e => e.ReferenceNumber).HasMaxLength(20);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasMany(d => d.Checkoutdetails).WithMany(p => p.PayfortPaymentRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "CheckoutPayfortPaymentReq",
                    r => r.HasOne<CheckoutDetail>().WithMany()
                        .HasForeignKey("CheckoutdetailsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Checkout___Check__00DF2177"),
                    l => l.HasOne<PayfortPaymentRequest>().WithMany()
                        .HasForeignKey("PayfortPaymentRequestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Checkout___Payfo__01D345B0"),
                    j =>
                    {
                        j.HasKey("PayfortPaymentRequestId", "CheckoutdetailsId");
                        j.ToTable("Checkout_PayfortPaymentReq");
                        j.IndexerProperty<string>("CheckoutdetailsId").HasMaxLength(50);
                    });

            entity.HasMany(d => d.PolicyUpdateRequests).WithMany(p => p.PayfortPaymentRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "PolicyUpdReqPayfortPaymentReq",
                    r => r.HasOne<PolicyUpdateRequest>().WithMany()
                        .HasForeignKey("PolicyUpdateRequestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__PolicyUpd__Polic__2EA5EC27"),
                    l => l.HasOne<PayfortPaymentRequest>().WithMany()
                        .HasForeignKey("PayfortPaymentRequestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__PolicyUpd__Payfo__2DB1C7EE"),
                    j =>
                    {
                        j.HasKey("PayfortPaymentRequestId", "PolicyUpdateRequestId");
                        j.ToTable("PolicyUpdReq_PayfortPaymentReq");
                    });
        });

        modelBuilder.Entity<PayfortPaymentResponse>(entity =>
        {
            entity.ToTable("PayfortPaymentResponse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Amount).HasColumnType("decimal(10, 4)");
            entity.Property(e => e.CardExpiryDate).HasMaxLength(5);
            entity.Property(e => e.CardHolerName).HasMaxLength(50);
            entity.Property(e => e.CardNumber).HasMaxLength(20);
            entity.Property(e => e.CustomerEmail).HasMaxLength(256);
            entity.Property(e => e.CustomerIp)
                .HasMaxLength(50)
                .HasColumnName("CustomerIP");
            entity.Property(e => e.FortId).HasMaxLength(25);
            entity.Property(e => e.PaymentOption).HasMaxLength(20);
            entity.Property(e => e.ResponseMessage).HasMaxLength(200);
            entity.Property(e => e.Status).HasColumnName("status");

            entity.HasOne(d => d.Request).WithMany(p => p.PayfortPaymentResponses)
                .HasForeignKey(d => d.RequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PayfortPaymentResponse_PayfortPaymentRequests");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.BillNumber);

            entity.ToTable("Payment");

            entity.Property(e => e.Ibna)
                .HasMaxLength(25)
                .HasColumnName("IBNA");
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.ToTable("PaymentMethod");

            entity.Property(e => e.ArabicDescription).HasMaxLength(255);
            entity.Property(e => e.Brands).HasMaxLength(255);
            entity.Property(e => e.EnglishDescription).HasMaxLength(255);
            entity.Property(e => e.LogoUrl).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Policy>(entity =>
        {
            entity.ToTable("Policy");

            entity.HasIndex(e => e.NotificationNo, "IX_NotificationNo");

            entity.HasIndex(e => e.PolicyIssueDate, "IX_PolicyIssueDate");

            entity.HasIndex(e => e.CheckOutDetailsId, "IX_Policy_CheckOutDetailsId");

            entity.HasIndex(e => e.PolicyExpiryDate, "IX_Policy_PolicyExpiryDate");

            entity.HasIndex(e => e.PolicyNo, "IX_Policy_PolicyNo");

            entity.HasIndex(e => e.RenewalNotificationStatus, "IX_RenewalNotificationStatus");

            entity.Property(e => e.CancelationDate).HasColumnType("date");
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.CheckOutDetailsId).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.InsuranceCompanyId).HasColumnName("InsuranceCompanyID");
            entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NajmStatusId).HasDefaultValueSql("((1))");
            entity.Property(e => e.NotificationNo).HasDefaultValueSql("((0))");
            entity.Property(e => e.PolicyEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyIssueDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo).HasMaxLength(36);
            entity.Property(e => e.RenewalNotificationStatus).HasMaxLength(255);

            entity.HasOne(d => d.CheckOutDetails).WithMany(p => p.Policies)
                .HasForeignKey(d => d.CheckOutDetailsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Policy_CheckOutDetails");

            entity.HasOne(d => d.InsuranceCompany).WithMany(p => p.Policies)
                .HasForeignKey(d => d.InsuranceCompanyId)
                .HasConstraintName("FK_Policy_InsuranceCompany");

            entity.HasOne(d => d.NajmStatusNavigation).WithMany(p => p.Policies)
                .HasForeignKey(d => d.NajmStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Policy__NajmStat__30592A6F");

            entity.HasOne(d => d.PolicyFile).WithMany(p => p.Policies)
                .HasForeignKey(d => d.PolicyFileId)
                .HasConstraintName("FK_Policy_PolicyFile");
        });

        modelBuilder.Entity<PolicyAdditionalBenefit>(entity =>
        {
            entity.Property(e => e.BenefitDescAr).HasMaxLength(500);
            entity.Property(e => e.BenefitDescEn).HasMaxLength(500);
            entity.Property(e => e.BenefitEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.BenefitExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.BenefitId).HasMaxLength(50);
            entity.Property(e => e.BenefitNameAr).HasMaxLength(500);
            entity.Property(e => e.BenefitNameEn).HasMaxLength(500);
            entity.Property(e => e.BenefitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeductibleValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.QuotationReferenceId).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.TaxableAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vatamount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VATAmount");
        });

        modelBuilder.Entity<PolicyDetail>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.InsuredId).HasColumnName("InsuredID");
            entity.Property(e => e.Ncdamount).HasColumnName("NCDAmount");
            entity.Property(e => e.NcdfreeYears).HasColumnName("NCDFreeYears");
            entity.Property(e => e.Ncdpercentage).HasColumnName("NCDPercentage");
            entity.Property(e => e.Pacover).HasColumnName("PACover");
            entity.Property(e => e.Vatamount).HasColumnName("VATAmount");
            entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");
            entity.Property(e => e.VehicleOwnerId).HasColumnName("VehicleOwnerID");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PolicyDetail)
                .HasForeignKey<PolicyDetail>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PolicyDetails_Policy");
        });

        modelBuilder.Entity<PolicyFile>(entity =>
        {
            entity.ToTable("PolicyFile");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.PolicyFileByte).HasColumnType("image");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .HasColumnName("ServerIP");
        });

        modelBuilder.Entity<PolicyModification>(entity =>
        {
            entity.ToTable("PolicyModification");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomCard).HasMaxLength(50);
            entity.Property(e => e.CustomCardNumber).HasMaxLength(50);
            entity.Property(e => e.MethodName).HasMaxLength(50);
            entity.Property(e => e.Nin).HasMaxLength(50);
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.QuotationReferenceId).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.SequenceNumber).HasMaxLength(50);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .HasColumnName("ServerIP");
            entity.Property(e => e.TaxableAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserAgent).HasMaxLength(500);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .HasColumnName("UserIP");
            entity.Property(e => e.Vatamount)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("VATAmount");
        });

        modelBuilder.Entity<PolicyProcessingQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PolicyPr__3214EC074BF80DB1");

            entity.ToTable("PolicyProcessingQueue");

            entity.HasIndex(e => new { e.IsCancelled, e.ProcessedOn, e.CompanyName, e.ProcessingTries }, "IX_IsCancelled_Processedon_CompanyName_ProcessingTries");

            entity.HasIndex(e => new { e.ProcessingTries, e.CreatedDate, e.ProcessedOn }, "IX_PolicyProcessingQueue_ProcessingTries_CreatedDate_ProcessedOn");

            entity.HasIndex(e => e.ReferenceId, "IX_PolicyProcessingQueue_ReferenceId");

            entity.HasIndex(e => new { e.ProcessingTries, e.CreatedDate, e.ProcessedOn }, "IX_ProcessingTries_CreatedDate_ProcessedOn");

            entity.Property(e => e.CancelationDate).HasColumnType("date");
            entity.Property(e => e.CancelledBy).HasMaxLength(500);
            entity.Property(e => e.Chanel).HasMaxLength(50);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DontProcessBeforeDate).HasColumnType("datetime");
            entity.Property(e => e.DriverNin).HasMaxLength(50);
            entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.RequestId).HasColumnName("RequestID");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .HasColumnName("ServerIP");
            entity.Property(e => e.UserName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.VehicleId).HasMaxLength(50);
        });

        modelBuilder.Entity<PolicyRenewedByCompany>(entity =>
        {
            entity.ToTable("PolicyRenewedByCompany");

            entity.Property(e => e.NewPolicyNo).HasMaxLength(50);
            entity.Property(e => e.OldPolicyNo).HasMaxLength(50);
            entity.Property(e => e.PolicyAmount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PolicyRenewalCommission).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PolicyTotalAmount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PolicyVat)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PolicyVAT");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.RenewalDate).HasMaxLength(50);
            entity.Property(e => e.SequanceNo).HasMaxLength(30);
        });

        modelBuilder.Entity<PolicyStatus>(entity =>
        {
            entity.ToTable("PolicyStatus");

            entity.Property(e => e.Key).HasMaxLength(200);
            entity.Property(e => e.NameAr).HasMaxLength(200);
            entity.Property(e => e.NameEn).HasMaxLength(200);
        });

        modelBuilder.Entity<PolicyUpdatePayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PolicyUp__3214EC071332C07B");

            entity.ToTable("PolicyUpdatePayment");

            entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1000);

            entity.HasOne(d => d.PolicyUpdateRequest).WithMany(p => p.PolicyUpdatePayments)
                .HasForeignKey(d => d.PolicyUpdateRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PolicyUpd__Polic__29E1370A");
        });

        modelBuilder.Entity<PolicyUpdateRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PolicyUp__3214EC0760BBCD36");

            entity.ToTable("PolicyUpdateRequest");

            entity.Property(e => e.Guid).HasMaxLength(50);

            entity.HasOne(d => d.Policy).WithMany(p => p.PolicyUpdateRequests)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("FK__PolicyUpd__Polic__2AD55B43");
        });

        modelBuilder.Entity<PolicyUpdateRequestAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PolicyUp__3214EC07E5453B9F");

            entity.ToTable("PolicyUpdateRequestAttachment");

            entity.HasOne(d => d.Attachment).WithMany(p => p.PolicyUpdateRequestAttachments)
                .HasForeignKey(d => d.AttachmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PolicyUpdReqAttach_Attachment");

            entity.HasOne(d => d.PolicyUpdReq).WithMany(p => p.PolicyUpdateRequestAttachments)
                .HasForeignKey(d => d.PolicyUpdReqId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PolicyUpdReqAttach_PolicyUpdReq");
        });

        modelBuilder.Entity<PriceDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId);

            entity.ToTable("PriceDetail");

            entity.HasIndex(e => e.CreateDateTime, "IX_CreateDateTime");

            entity.HasIndex(e => e.IsCheckedOut, "IX_IsCheckedOut");

            entity.HasIndex(e => e.ProductId, "IX_ProductID").HasFillFactor(100);

            entity.HasIndex(e => e.PriceTypeCode, "idx_PriceTypeCode");

            entity.Property(e => e.DetailId).ValueGeneratedNever();
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.PercentageValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.PriceTypeCodeNavigation).WithMany(p => p.PriceDetails)
                .HasForeignKey(d => d.PriceTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceDetail_PriceType");

            entity.HasOne(d => d.Product).WithMany(p => p.PriceDetails)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PriceDetail_Product");
        });

        modelBuilder.Entity<PriceType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("PriceType");

            entity.Property(e => e.Code).ValueGeneratedOnAdd();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.HasIndex(e => e.CreateDateTime, "IX_CreateDateTime");

            entity.HasIndex(e => e.IsCheckedOut, "IX_IsCheckedOut");

            entity.HasIndex(e => e.ProviderId, "IX_ProviderId");

            entity.HasIndex(e => new { e.QuotationResponseId, e.ProductPrice }, "IX_QuotationResponseId_ProductPrice").HasFillFactor(100);

            entity.HasIndex(e => e.ReferenceId, "IX_ReferenceId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AnnualPremiumBfd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AnnualPremiumBFD");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeductibleType).HasMaxLength(50);
            entity.Property(e => e.ExternalProductId).HasMaxLength(100);
            entity.Property(e => e.InsurancePercentage).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Odlimit).HasColumnName("ODLimit");
            entity.Property(e => e.PolicyPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductImage)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProductPrice).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.QuotaionNo).HasMaxLength(50);
            entity.Property(e => e.QuotationDate).HasColumnType("datetime");
            entity.Property(e => e.QuotationExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(255);
            entity.Property(e => e.ShadowAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tpllimit).HasColumnName("TPLLimit");

            entity.HasOne(d => d.Provider).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProviderId)
                .HasConstraintName("FK_Product_InsuranceCompany");

            entity.HasOne(d => d.QuotationResponse).WithMany(p => p.Products)
                .HasForeignKey(d => d.QuotationResponseId)
                .HasConstraintName("FK_Product_QuotationResponse");
        });

        modelBuilder.Entity<ProductBenefit>(entity =>
        {
            entity.ToTable("Product_Benefit");

            entity.HasIndex(e => e.ProductId, "IX_ProductId").HasFillFactor(100);

            entity.Property(e => e.AveragePremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BenefitExternalId).HasMaxLength(50);
            entity.Property(e => e.BenefitNameAr).HasMaxLength(500);
            entity.Property(e => e.BenefitNameEn).HasMaxLength(500);
            entity.Property(e => e.BenefitPrice).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.CoveredCountry).HasMaxLength(50);

            entity.HasOne(d => d.Benefit).WithMany(p => p.ProductBenefits)
                .HasForeignKey(d => d.BenefitId)
                .HasConstraintName("FK_Product_Benefit_Benefit");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductBenefits)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_Product_Benefit_Product");
        });

        modelBuilder.Entity<ProductDriver>(entity =>
        {
            entity.ToTable("Product_Driver");

            entity.Property(e => e.DriverExternalId).HasMaxLength(50);
            entity.Property(e => e.DriverPrice).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<ProductType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("ProductType");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<ProfileNotification>(entity =>
        {
            entity.ToTable("ProfileNotification");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<PromotionProgram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC072DB5888E");

            entity.ToTable("PromotionProgram");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DeactivatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EnableService).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsPromoByAttachment).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsPromoByEmail)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsPromoByNin).HasDefaultValueSql("((0))");
            entity.Property(e => e.Key)
                .HasMaxLength(50)
                .HasDefaultValueSql("(N'wafier')");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PromotionProgramCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Promotion__Creat__4E1E9780");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PromotionProgramModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Promotion__Modif__4F12BBB9");
        });

        modelBuilder.Entity<PromotionProgramCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC07021D33EE");

            entity.ToTable("PromotionProgramCode");

            entity.HasIndex(e => e.InsuranceCompanyId, "IX_InsuranceCompanyId");

            entity.HasIndex(e => e.InsuranceTypeCode, "IX_InsuranceTypeCode");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CreatorId).HasMaxLength(128);
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifierId).HasMaxLength(128);

            entity.HasOne(d => d.Creator).WithMany(p => p.PromotionProgramCodeCreators)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK__Promotion__Creat__54CB950F");

            entity.HasOne(d => d.InsuranceCompany).WithMany(p => p.PromotionProgramCodes)
                .HasForeignKey(d => d.InsuranceCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Promotion__Insur__52E34C9D");

            entity.HasOne(d => d.InsuranceTypeCodeNavigation).WithMany(p => p.PromotionProgramCodes)
                .HasForeignKey(d => d.InsuranceTypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Promotion__Insur__45544755");

            entity.HasOne(d => d.Modifier).WithMany(p => p.PromotionProgramCodeModifiers)
                .HasForeignKey(d => d.ModifierId)
                .HasConstraintName("FK__Promotion__Modif__55BFB948");

            entity.HasOne(d => d.PromotionProgram).WithMany(p => p.PromotionProgramCodes)
                .HasForeignKey(d => d.PromotionProgramId)
                .HasConstraintName("FK__Promotion__Promo__51EF2864");
        });

        modelBuilder.Entity<PromotionProgramDomain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC07E19E5CB3");

            entity.ToTable("PromotionProgramDomain");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DomainNameAr).HasMaxLength(50);
            entity.Property(e => e.DomainNameEn).HasMaxLength(50);
            entity.Property(e => e.Domian).HasMaxLength(50);
            entity.Property(e => e.IsActive).HasDefaultValueSql("('1')");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PromotionProgramDomainCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Promotion__Creat__59904A2C");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PromotionProgramDomainModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Promotion__Modif__5A846E65");

            entity.HasOne(d => d.PromotionProgram).WithMany(p => p.PromotionProgramDomains)
                .HasForeignKey(d => d.PromotionProgramId)
                .HasConstraintName("FK__Promotion__Promo__589C25F3");
        });

        modelBuilder.Entity<PromotionProgramNin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC0762C4DA70");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.NationalId).HasMaxLength(50);
        });

        modelBuilder.Entity<PromotionProgramUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Promotio__3214EC07E99183CA");

            entity.ToTable("PromotionProgramUser");

            entity.HasIndex(e => e.EmailVerified, "IX_EmailVerified");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.PromotionProgramUserCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__Promotion__Creat__603D47BB");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.PromotionProgramUserModifiedByNavigations)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK__Promotion__Modif__61316BF4");

            entity.HasOne(d => d.PromotionProgram).WithMany(p => p.PromotionProgramUsers)
                .HasForeignKey(d => d.PromotionProgramId)
                .HasConstraintName("FK__Promotion__Promo__5D60DB10");

            entity.HasOne(d => d.User).WithMany(p => p.PromotionProgramUserUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Promotion__UserI__5E54FF49");
        });

        modelBuilder.Entity<PromotionUser>(entity =>
        {
            entity.ToTable("PromotionUser");

            entity.Property(e => e.AttachmentPath).HasMaxLength(500);
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.EnrolledType).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(500);
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<PromotionUserCopy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PromotionUser_copy");

            entity.Property(e => e.AttachmentPath).HasMaxLength(500);
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(128);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.EnrolledType).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(500);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedBy).HasMaxLength(128);
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<QuotationBlockedNin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_QuotationBlockedUsers");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.NationalId).HasMaxLength(50);
        });

        modelBuilder.Entity<QuotationProductBenefit>(entity =>
        {
            entity.ToTable("Quotation_Product_Benefit");

            entity.Property(e => e.AveragePremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BenefitExternalId).HasMaxLength(50);
            entity.Property(e => e.BenefitNameAr).HasMaxLength(500);
            entity.Property(e => e.BenefitNameEn).HasMaxLength(500);
            entity.Property(e => e.BenefitPrice).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.CoveredCountry).HasMaxLength(50);
        });

        modelBuilder.Entity<QuotationRequest>(entity =>
        {
            entity.ToTable("QuotationRequest");

            entity.HasIndex(e => e.AutoleasingInitialOption, "IX_AutoleasingInitialOption");

            entity.HasIndex(e => new { e.CreatedDateTime, e.RequestPolicyEffectiveDate }, "IX_CD_PED");

            entity.HasIndex(e => e.InsuredId, "IX_InsuredId").HasFillFactor(100);

            entity.HasIndex(e => e.IsConverted, "IX_IsConverted");

            entity.HasIndex(e => e.MainDriverId, "IX_MainDriverId");

            entity.HasIndex(e => e.PreviousReferenceId, "IX_PreviousReferenceId");

            entity.HasIndex(e => e.ExternalId, "IX_QuotationRequest_Index").IsUnique();

            entity.HasIndex(e => e.UserId, "IX_UserId").HasFillFactor(100);

            entity.HasIndex(e => e.VehicleId, "IX_VehicleId");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AutoleasingBulkOption).HasDefaultValueSql("((0))");
            entity.Property(e => e.AutoleasingInitialOption).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.InitialExternalId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.IsConverted).HasDefaultValueSql("((0))");
            entity.Property(e => e.NajmNcdRefrence).HasMaxLength(128);
            entity.Property(e => e.PostCode).HasMaxLength(255);
            entity.Property(e => e.PreviousReferenceId).HasMaxLength(50);
            entity.Property(e => e.RequestPolicyEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.CityCodeNavigation).WithMany(p => p.QuotationRequests)
                .HasForeignKey(d => d.CityCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationRequest_City");

            entity.HasOne(d => d.Insured).WithMany(p => p.QuotationRequests)
                .HasForeignKey(d => d.InsuredId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Quotation__Insur__3552E9B6");

            entity.HasOne(d => d.MainDriver).WithMany(p => p.QuotationRequests)
                .HasForeignKey(d => d.MainDriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationRequest_Driver");

            entity.HasOne(d => d.User).WithMany(p => p.QuotationRequests)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_QuotationRequest_AspNetUsers");

            entity.HasOne(d => d.Vehicle).WithMany(p => p.QuotationRequests)
                .HasForeignKey(d => d.VehicleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationRequest_Vehicles");
        });

        modelBuilder.Entity<QuotationRequestAdditionalDriver>(entity =>
        {
            entity.HasKey(e => new { e.QuotationRequestId, e.AdditionalDriverId });

            entity.HasOne(d => d.AdditionalDriver).WithMany(p => p.QuotationRequestAdditionalDrivers)
                .HasForeignKey(d => d.AdditionalDriverId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationRequestAdditionalDrivers_Driver");

            entity.HasOne(d => d.QuotationRequest).WithMany(p => p.QuotationRequestAdditionalDrivers)
                .HasForeignKey(d => d.QuotationRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationRequestAdditionalDrivers_QuotationRequest");
        });

        modelBuilder.Entity<QuotationResponse>(entity =>
        {
            entity.ToTable("QuotationResponse");

            entity.HasIndex(e => new { e.InsuranceCompanyId, e.InsuranceTypeCode, e.VehicleAgencyRepair, e.DeductibleValue, e.CreateDateTime }, "IX_CompanyId_insuranceCode_AgencyRepair_deductibleValue_DateTime");

            entity.HasIndex(e => e.ReferenceId, "IX_QuotationResponse_ReferenceId");

            entity.HasIndex(e => e.RequestId, "IX_QuotationResponse_RequestId");

            entity.HasIndex(e => new { e.IsCheckedOut, e.CreateDateTime }, "Ix_IsCheckedout_CreatedDate");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.IcquoteReferenceNo)
                .HasMaxLength(50)
                .HasColumnName("ICQuoteReferenceNo");
            entity.Property(e => e.PromotionProgramCode).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);

            entity.HasOne(d => d.InsuranceCompany).WithMany(p => p.QuotationResponses)
                .HasForeignKey(d => d.InsuranceCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationResponse_InsuranceCompany");

            entity.HasOne(d => d.InsuranceTypeCodeNavigation).WithMany(p => p.QuotationResponses)
                .HasForeignKey(d => d.InsuranceTypeCode)
                .HasConstraintName("FK_QuotationResponse_ProductType");

            entity.HasOne(d => d.Request).WithMany(p => p.QuotationResponses)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_QuotationResponse_QuotationRequest");
        });

        modelBuilder.Entity<QuotationResponseCache>(entity =>
        {
            entity.ToTable("QuotationResponseCache");

            entity.HasIndex(e => new { e.InsuranceCompanyId, e.InsuranceTypeCode }, "IX_CompId_ITC");

            entity.HasIndex(e => e.CreateDateTime, "IX_CreatedDate");

            entity.HasIndex(e => e.ExternalId, "IX_ExternalId");

            entity.HasIndex(e => new { e.InsuranceCompanyId, e.InsuranceTypeCode, e.ExternalId }, "IX_IC_ITC_EID");

            entity.HasIndex(e => new { e.InsuranceCompanyId, e.ExternalId, e.VehicleAgencyRepair, e.DeductibleValue, e.CreateDateTime }, "Ix_CompId_ExternalId_VAR_DV_CD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
        });

        modelBuilder.Entity<QuotationResponseLogsGap>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QuotationResponse_LogsGap");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.IcquoteReferenceNo)
                .HasMaxLength(50)
                .HasColumnName("ICQuoteReferenceNo");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PromotionProgramCode).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<QuotationResponseNew>(entity =>
        {
            entity.ToTable("QuotationResponseNew");

            entity.Property(e => e.CreateDateTime).HasColumnType("datetime");
            entity.Property(e => e.IcquoteReferenceNo)
                .HasMaxLength(50)
                .HasColumnName("ICQuoteReferenceNo");
            entity.Property(e => e.PromotionProgramCode).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);

            entity.HasOne(d => d.InsuranceCompany).WithMany(p => p.QuotationResponseNews)
                .HasForeignKey(d => d.InsuranceCompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QuotationResponse_InsuranceCompanyNew");

            entity.HasOne(d => d.InsuranceTypeCodeNavigation).WithMany(p => p.QuotationResponseNews)
                .HasForeignKey(d => d.InsuranceTypeCode)
                .HasConstraintName("FK_QuotationResponse_ProductTypeNew");

            entity.HasOne(d => d.Request).WithMany(p => p.QuotationResponseNews)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK_QuotationResponse_QuotationRequestNew");
        });

        modelBuilder.Entity<QuotationShare>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .HasColumnName("ServerIP");
            entity.Property(e => e.ShareType).HasMaxLength(100);
            entity.Property(e => e.Url).HasMaxLength(255);
            entity.Property(e => e.UserAgent).HasMaxLength(500);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.UserIp)
                .HasMaxLength(50)
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<ReasonCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReasonCode_1");

            entity.ToTable("ReasonCode");

            entity.Property(e => e.ArabicDescription).HasMaxLength(500);
            entity.Property(e => e.EnglishDescription).HasMaxLength(500);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.ToTable("Region");

            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<RegisterTokenLog>(entity =>
        {
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RenewalDiscount>(entity =>
        {
            entity.ToTable("RenewalDiscount");

            entity.Property(e => e.Amount).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Percentage).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RenewalPolicy>(entity =>
        {
            entity.HasIndex(e => e.NewReferenceId, "IX_NewReferenceId");

            entity.HasIndex(e => e.OldReferenceId, "IX_OldReferenceId");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FromNotification).HasDefaultValueSql("((0))");
            entity.Property(e => e.NewChannel).HasMaxLength(50);
            entity.Property(e => e.NewCheckoutCreatedDate).HasColumnType("datetime");
            entity.Property(e => e.NewCompanyKey).HasMaxLength(255);
            entity.Property(e => e.NewNin).HasMaxLength(50);
            entity.Property(e => e.NewPolicyEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.NewPolicyExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.NewPolicyIssueDate).HasColumnType("datetime");
            entity.Property(e => e.NewPolicyNo).HasMaxLength(50);
            entity.Property(e => e.NewReferenceId).HasMaxLength(50);
            entity.Property(e => e.NewTotalPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.OldChannel).HasMaxLength(50);
            entity.Property(e => e.OldCheckoutCreatedDate).HasColumnType("datetime");
            entity.Property(e => e.OldCompanyKey).HasMaxLength(255);
            entity.Property(e => e.OldNin).HasMaxLength(50);
            entity.Property(e => e.OldPolicyEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.OldPolicyExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.OldPolicyIssueDate).HasColumnType("datetime");
            entity.Property(e => e.OldPolicyNo).HasMaxLength(50);
            entity.Property(e => e.OldReferenceId).HasMaxLength(50);
            entity.Property(e => e.OldTotalPrice).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.VehicleId).HasMaxLength(50);
        });

        modelBuilder.Entity<RenwalStatiticsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RenwalStatitics_Old");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(100);
            entity.Property(e => e.IsDeleted)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isDeleted");
            entity.Property(e => e.ParentExternalId)
                .HasMaxLength(100)
                .HasColumnName("parentExternalId");
            entity.Property(e => e.ParentReferenceId)
                .HasMaxLength(100)
                .HasColumnName("parentReferenceId");
            entity.Property(e => e.ReferenceId).HasMaxLength(100);
            entity.Property(e => e.SequenceNumber).HasMaxLength(100);
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<RiyadBankMigsRequest>(entity =>
        {
            entity.ToTable("RiyadBankMigsRequest");

            entity.Property(e => e.AccessCode).HasMaxLength(200);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Command).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Locale).HasMaxLength(200);
            entity.Property(e => e.MerchTxnRef).HasMaxLength(200);
            entity.Property(e => e.MerchantId).HasMaxLength(200);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.OrderInfo).HasMaxLength(200);
            entity.Property(e => e.ReturnUrl).HasMaxLength(200);
            entity.Property(e => e.SecureHash).HasMaxLength(200);
            entity.Property(e => e.SecureHashType).HasMaxLength(200);
            entity.Property(e => e.Version).HasMaxLength(200);

            entity.HasMany(d => d.Checkoutdetails).WithMany(p => p.RiyadBankMigsRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "CheckoutRiyadBankMigsRequest",
                    r => r.HasOne<CheckoutDetail>().WithMany()
                        .HasForeignKey("CheckoutdetailsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Checkout___Check__178D7CA5"),
                    l => l.HasOne<RiyadBankMigsRequest>().WithMany()
                        .HasForeignKey("RiyadBankMigsRequestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Checkout___Riyad__1881A0DE"),
                    j =>
                    {
                        j.HasKey("RiyadBankMigsRequestId", "CheckoutdetailsId");
                        j.ToTable("Checkout_RiyadBankMigsRequest");
                        j.HasIndex(new[] { "CheckoutdetailsId" }, "IX_Checkout_RiyadBankMigsRequest_CheckoutdetailsId");
                        j.IndexerProperty<string>("CheckoutdetailsId").HasMaxLength(50);
                    });
        });

        modelBuilder.Entity<RiyadBankMigsResponse>(entity =>
        {
            entity.ToTable("RiyadBankMigsResponse");

            entity.HasIndex(e => e.OrderInfo, "IX_RiyadBankMigsResponse_OrderInfo");

            entity.Property(e => e.AcqAvsrespCode)
                .HasMaxLength(200)
                .HasColumnName("AcqAVSRespCode");
            entity.Property(e => e.AcqCscrespCode)
                .HasMaxLength(200)
                .HasColumnName("AcqCSCRespCode");
            entity.Property(e => e.AcqResponseCode).HasMaxLength(200);
            entity.Property(e => e.Amount).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.AuthorizeId).HasMaxLength(200);
            entity.Property(e => e.AvsresultCode)
                .HasMaxLength(200)
                .HasColumnName("AVSResultCode");
            entity.Property(e => e.BatchNo).HasMaxLength(200);
            entity.Property(e => e.CancelationDate).HasColumnType("date");
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.Card).HasMaxLength(200);
            entity.Property(e => e.CardNum).HasMaxLength(200);
            entity.Property(e => e.Command).HasMaxLength(200);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CscresultCode)
                .HasMaxLength(200)
                .HasColumnName("CSCResultCode");
            entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");
            entity.Property(e => e.Locale).HasMaxLength(200);
            entity.Property(e => e.MerchTxnRef).HasMaxLength(200);
            entity.Property(e => e.MerchantId).HasMaxLength(200);
            entity.Property(e => e.OrderInfo).HasMaxLength(200);
            entity.Property(e => e.ReceiptNo).HasMaxLength(200);
            entity.Property(e => e.SecureHash).HasMaxLength(200);
            entity.Property(e => e.SecureHashType).HasMaxLength(200);
            entity.Property(e => e.TransactionNo).HasMaxLength(200);
            entity.Property(e => e.TxnResponseCode).HasMaxLength(200);
            entity.Property(e => e.VerSecurityLevel).HasMaxLength(200);
            entity.Property(e => e.VerStatus).HasMaxLength(200);
            entity.Property(e => e.VerToken).HasMaxLength(200);
            entity.Property(e => e.VerType).HasMaxLength(200);
            entity.Property(e => e.Version).HasMaxLength(200);
            entity.Property(e => e.Vpc3Dseci)
                .HasMaxLength(200)
                .HasColumnName("Vpc3DSECI");
            entity.Property(e => e.Vpc3Dsenrolled)
                .HasMaxLength(200)
                .HasColumnName("Vpc3DSenrolled");
            entity.Property(e => e.Vpc3Dsstatus)
                .HasMaxLength(200)
                .HasColumnName("Vpc3DSstatus");
            entity.Property(e => e.Vpc3Dsxid)
                .HasMaxLength(200)
                .HasColumnName("Vpc3DSXID");

            entity.HasOne(d => d.RiyadBankMigsRequest).WithMany(p => p.RiyadBankMigsResponses)
                .HasForeignKey(d => d.RiyadBankMigsRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiyadBankMigsResponse_RiyadBankMigsRequest");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.RoleNameAr)
                .HasMaxLength(50)
                .HasColumnName("RoleNameAR");
            entity.Property(e => e.RoleNameEn)
                .HasMaxLength(50)
                .HasColumnName("RoleNameEN");
            entity.Property(e => e.RoleTypeId).HasColumnName("RoleTypeID");

            entity.HasOne(d => d.RoleType).WithMany(p => p.Roles)
                .HasForeignKey(d => d.RoleTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Role_RoleType");
        });

        modelBuilder.Entity<RoleType>(entity =>
        {
            entity.ToTable("RoleType");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.TypeNameAr)
                .HasMaxLength(50)
                .HasColumnName("TypeNameAR");
            entity.Property(e => e.TypeNameEn)
                .HasMaxLength(50)
                .HasColumnName("TypeNameEN");
        });

        modelBuilder.Entity<SadadNotificationMessage>(entity =>
        {
            entity.ToTable("SadadNotificationMessage");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BodysAccountNo).HasMaxLength(25);
            entity.Property(e => e.BodysAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BodysCustomerRefNo).HasMaxLength(25);
            entity.Property(e => e.BodysDescription).HasMaxLength(200);
            entity.Property(e => e.BodysTransType).HasMaxLength(10);
            entity.Property(e => e.CancelationDate).HasColumnType("date");
            entity.Property(e => e.CancelledBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.HeadersMessageType).HasMaxLength(10);
            entity.Property(e => e.HeadersReceiver).HasMaxLength(50);
            entity.Property(e => e.HeadersSender).HasMaxLength(50);
            entity.Property(e => e.HeadersTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.IsCancelled).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<SadadNotificationResponse>(entity =>
        {
            entity.ToTable("SadadNotificationResponse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HeadersMessageType).HasMaxLength(10);
            entity.Property(e => e.HeadersReceiver).HasMaxLength(50);
            entity.Property(e => e.HeadersSender).HasMaxLength(50);
            entity.Property(e => e.HeadersTimeStamp).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(10);

            entity.HasOne(d => d.NotificationMessage).WithMany(p => p.SadadNotificationResponses)
                .HasForeignKey(d => d.NotificationMessageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SadadNotificationResponse_SadadNotificationMessage");
        });

        modelBuilder.Entity<SadadRequest>(entity =>
        {
            entity.ToTable("SadadRequest");

            entity.Property(e => e.BillAmount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BillCloseDate).HasColumnType("datetime");
            entity.Property(e => e.BillDueDate).HasColumnType("datetime");
            entity.Property(e => e.BillExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.BillMaxAdvanceAmount).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.BillMinAdvanceAmount).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.BillMinPartialAmount).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.BillOpenDate).HasColumnType("datetime");
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.CustomerAccountName).HasMaxLength(200);
            entity.Property(e => e.CustomerAccountNumber).HasMaxLength(20);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<SadadResponse>(entity =>
        {
            entity.ToTable("SadadResponse");

            entity.Property(e => e.Status).HasMaxLength(10);

            entity.HasOne(d => d.SadadRequest).WithMany(p => p.SadadResponses)
                .HasForeignKey(d => d.SadadRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SadadResponse_SadadRequest");
        });

        modelBuilder.Entity<ScheduleTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Schedule__3214EC072932D962");

            entity.ToTable("ScheduleTask");

            entity.Property(e => e.LastEnd).HasColumnType("datetime");
            entity.Property(e => e.LastStart).HasColumnType("datetime");
            entity.Property(e => e.LastSuccess).HasColumnType("datetime");
            entity.Property(e => e.LeasedUntil).HasColumnType("datetime");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .HasColumnName("ServerIP");
        });

        modelBuilder.Entity<SendNotificationLog>(entity =>
        {
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Sensor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sensor__3214EC0720E20DAE");

            entity.ToTable("Sensor");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Settings");

            entity.ToTable("Setting");
        });

        modelBuilder.Entity<ShoppingCartItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shopping__3214EC078EF48979");

            entity.ToTable("ShoppingCartItem");

            entity.HasIndex(e => new { e.UserId, e.ReferenceId }, "IX_ShoppingCartItem_UserId_ReferenceId");

            entity.HasIndex(e => e.UserId, "IX_UserId").HasFillFactor(100);

            entity.HasIndex(e => e.CreatedOn, "idx_CreatedOn");

            entity.HasIndex(e => new { e.UserId, e.ReferenceId }, "idx_UserId_ReferenceId");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<ShoppingCartItemBenefit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Shopping__3214EC07F7A09A4A");

            entity.ToTable("ShoppingCartItemBenefit");

            entity.HasIndex(e => e.ShoppingCartItemId, "IX_ShoppingCartItemBenefit_ShoppingCartItemId");

            entity.HasOne(d => d.ProductBenefit).WithMany(p => p.ShoppingCartItemBenefits)
                .HasForeignKey(d => d.ProductBenefitId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ShoppingCartItemBenefit_ProductBenefit");
        });

        modelBuilder.Entity<ShoppingCartItemDriver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ShoppingItem_Driver");

            entity.ToTable("ShoppingCartItemDriver");
        });

        modelBuilder.Entity<SmsCode>(entity =>
        {
            entity.HasIndex(e => e.Code, "IX_SmsCodes_Code");

            entity.HasIndex(e => e.Mobile, "IX_SmsCodes_Mobile");

            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mobile).HasMaxLength(20);
        });

        modelBuilder.Entity<SmsRenewalNotificationRehit>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CarOwnerNin).HasColumnName("CarOwnerNIN");
            entity.Property(e => e.CarPlateText1).HasMaxLength(1);
            entity.Property(e => e.CarPlateText2).HasMaxLength(1);
            entity.Property(e => e.CarPlateText3).HasMaxLength(1);
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.CustomCardNumber).HasMaxLength(30);
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.InsuranceCompanyName).HasMaxLength(255);
            entity.Property(e => e.MakerDescAr).HasMaxLength(50);
            entity.Property(e => e.MakerDescEn).HasMaxLength(50);
            entity.Property(e => e.ModelDescAr).HasMaxLength(50);
            entity.Property(e => e.ModelDescEn).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(20);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PolicyEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo).HasMaxLength(36);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.SequenceNumber).HasMaxLength(30);
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.VehicleModel).HasMaxLength(30);
        });

        modelBuilder.Entity<SmsproviderSetting>(entity =>
        {
            entity.ToTable("SMSProviderSettings");

            entity.Property(e => e.Method).HasMaxLength(50);
            entity.Property(e => e.Module).HasMaxLength(50);
            entity.Property(e => e.Smsprovider)
                .HasMaxLength(50)
                .HasColumnName("SMSProvider");
        });

        modelBuilder.Entity<SmsskippedNumber>(entity =>
        {
            entity.ToTable("SMSSkippedNumbers");

            entity.Property(e => e.CreatedBy).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNo).HasMaxLength(50);
        });

        modelBuilder.Entity<SpeedStabilizer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SpeedSta__3214EC077714F22D");

            entity.ToTable("SpeedStabilizer");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<TabbyCaptureRequest>(entity =>
        {
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RefrenceId).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);

            entity.HasOne(d => d.TabbyRequest).WithMany(p => p.TabbyCaptureRequests)
                .HasForeignKey(d => d.TabbyRequestId)
                .HasConstraintName("FK__TabbyCapt__Tabby__5CC1BC92");
        });

        modelBuilder.Entity<TabbyCaptureResponse>(entity =>
        {
            entity.Property(e => e.CaptureId).HasMaxLength(50);
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.ExpiresAt).HasMaxLength(50);
            entity.Property(e => e.OrderRefrenceId).HasMaxLength(50);
            entity.Property(e => e.RefrenceId).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);

            entity.HasOne(d => d.TabbyCaptureRequest).WithMany(p => p.TabbyCaptureResponses)
                .HasForeignKey(d => d.TabbyCaptureRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TabbyCapt__Tabby__5EAA0504");
        });

        modelBuilder.Entity<TabbyCaptureResponseDetail>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Meta).HasMaxLength(200);

            entity.HasOne(d => d.TabbyCaptureResponse).WithMany(p => p.TabbyCaptureResponseDetails)
                .HasForeignKey(d => d.TabbyCaptureResponseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TabbyCapt__Tabby__18F6A22A");
        });

        modelBuilder.Entity<TabbyNotification>(entity =>
        {
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CreatedAt)
                .HasMaxLength(250)
                .HasColumnName("CreatedAT");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.ExpiresAt).HasMaxLength(250);
            entity.Property(e => e.InvoiceNo).HasMaxLength(250);
            entity.Property(e => e.Meta).HasMaxLength(250);
            entity.Property(e => e.PaymentId).HasMaxLength(250);
            entity.Property(e => e.ReferenceId)
                .HasMaxLength(50)
                .HasColumnName("ReferenceID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TabbyRequestId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.UserId).HasMaxLength(250);

            entity.HasOne(d => d.TabbyRequest).WithMany(p => p.TabbyNotifications)
                .HasForeignKey(d => d.TabbyRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TabbyNoti__Tabby__60924D76");
        });

        modelBuilder.Entity<TabbyNotificationDetail>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.TabbyNotification).WithMany(p => p.TabbyNotificationDetails)
                .HasForeignKey(d => d.TabbyNotificationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TabbyNoti__Tabby__68536ACF");
        });

        modelBuilder.Entity<TabbyRequest>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CompanyId).HasDefaultValueSql("((0))");
            entity.Property(e => e.CompanyName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.InsuranceCompanyAmount).HasDefaultValueSql("((0))");
            entity.Property(e => e.RefrenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<TabbyRequestDetail>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Lang).HasMaxLength(5);
            entity.Property(e => e.MerchantCode).HasMaxLength(10);
            entity.Property(e => e.MerchantUrl).HasColumnName("MerchantURL");
            entity.Property(e => e.TabbyRequestId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.TabbyRequest).WithMany(p => p.TabbyRequestDetails)
                .HasForeignKey(d => d.TabbyRequestId)
                .HasConstraintName("FK__TabbyRequ__Tabby__618671AF");
        });

        modelBuilder.Entity<TabbyResponse>(entity =>
        {
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.TabbyRequestId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.TabbyRequest).WithMany(p => p.TabbyResponses)
                .HasForeignKey(d => d.TabbyRequestId)
                .HasConstraintName("FK__TabbyResp__Tabby__636EBA21");
        });

        modelBuilder.Entity<TabbyResponseDetail>(entity =>
        {
            entity.Property(e => e.ApiUrl).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Flow).HasMaxLength(50);
            entity.Property(e => e.Lang).HasMaxLength(5);
            entity.Property(e => e.Merchant).HasMaxLength(255);
            entity.Property(e => e.MerchantCode).HasMaxLength(255);
            entity.Property(e => e.MerchantUrl).HasColumnName("MerchantURL");
            entity.Property(e => e.PaymentCreatedAt).HasMaxLength(100);
            entity.Property(e => e.PaymentCurrency).HasMaxLength(50);
            entity.Property(e => e.PaymentExpireAt).HasMaxLength(100);
            entity.Property(e => e.PaymentId)
                .HasMaxLength(50)
                .HasColumnName("PaymentID");
            entity.Property(e => e.PaymentStatus).HasMaxLength(100);
            entity.Property(e => e.ProductType).HasMaxLength(255);
            entity.Property(e => e.SiftSessionId).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Token).HasMaxLength(1000);

            entity.HasOne(d => d.TabbyResponse).WithMany(p => p.TabbyResponseDetails)
                .HasForeignKey(d => d.TabbyResponseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TabbyResp__Tabby__4475FD0C");
        });

        modelBuilder.Entity<TabbyWebHook>(entity =>
        {
            entity.Property(e => e.Channel).HasMaxLength(250);
            entity.Property(e => e.ClosedAt).HasMaxLength(250);
            entity.Property(e => e.CreatedAt)
                .HasMaxLength(250)
                .HasColumnName("CreatedAT");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.ExpiresAt).HasMaxLength(250);
            entity.Property(e => e.InvoiceNo).HasMaxLength(250);
            entity.Property(e => e.MerchantId).HasMaxLength(250);
            entity.Property(e => e.PaymentId).HasMaxLength(250);
            entity.Property(e => e.ProductOptionId).HasMaxLength(250);
            entity.Property(e => e.RefrenceId).HasMaxLength(250);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TabbyRequestId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.UserId).HasMaxLength(250);

            entity.HasOne(d => d.TabbyRequest).WithMany(p => p.TabbyWebHooks)
                .HasForeignKey(d => d.TabbyRequestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TabbyWebH__Tabby__65570293");
        });

        modelBuilder.Entity<TabbyWebHookDetail>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.TabbyWebHook).WithMany(p => p.TabbyWebHookDetails)
                .HasForeignKey(d => d.TabbyWebHookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TabbyWebHook__Tabby__68536ACF");
        });

        modelBuilder.Entity<TawuniyaProposal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tawuniya__3214EC076C213B0F");

            entity.ToTable("TawuniyaProposal");

            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
        });

        modelBuilder.Entity<TawuniyaTempTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tawuniya__3214EC070B9C4C83");

            entity.ToTable("TawuniyaTempTable");

            entity.Property(e => e.ReferenceId).HasMaxLength(200);
        });

        modelBuilder.Entity<TempPriceDetail>(entity =>
        {
            entity.HasKey(e => e.DetailId);

            entity.ToTable("TempPriceDetail");

            entity.Property(e => e.DetailId).ValueGeneratedNever();
            entity.Property(e => e.PercentageValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.PriceValue).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
        });

        modelBuilder.Entity<UserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Claims");

            entity.ToTable("UserClaim");

            entity.Property(e => e.AccidentReportNumber).HasMaxLength(100);
            entity.Property(e => e.ClaimStatusName).HasMaxLength(30);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExternalId).HasMaxLength(50);
            entity.Property(e => e.Iban).HasMaxLength(500);
            entity.Property(e => e.LicenseExpiryDate).HasMaxLength(20);
            entity.Property(e => e.MobileNo).HasMaxLength(100);
            entity.Property(e => e.NationalId).HasMaxLength(100);
            entity.Property(e => e.PolicyNo).HasMaxLength(100);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.UpdatedBy).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserClaimFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ClaimFiles");

            entity.ToTable("UserClaimFile");

            entity.Property(e => e.ClaimFileExtension).HasMaxLength(10);
            entity.Property(e => e.ClaimFileName).HasMaxLength(250);
            entity.Property(e => e.ClaimFilePath).HasMaxLength(250);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserClaimHistory>(entity =>
        {
            entity.ToTable("UserClaimHistory");

            entity.Property(e => e.ClaimStatusName).HasMaxLength(30);
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Notes).HasMaxLength(250);
        });

        modelBuilder.Entity<UserClaimStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ClaimStatus");

            entity.ToTable("UserClaimStatus");

            entity.Property(e => e.StatusNameAr).HasMaxLength(50);
            entity.Property(e => e.StatusNameEn).HasMaxLength(50);
        });

        modelBuilder.Entity<UserFireBaseRegisterationToken>(entity =>
        {
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ModificationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.ToTable("UserInfo");

            entity.HasIndex(e => e.DriverId, "IX_DriverId");

            entity.HasIndex(e => e.IsDriverExist, "IX_IsDriverExists");

            entity.HasIndex(e => e.NationalId, "IX_NationalId");

            entity.HasIndex(e => e.SequenceNumber, "IX_SeqNo");

            entity.HasIndex(e => e.VechileId, "IX_VechileId");

            entity.HasIndex(e => e.IsVerified, "ix_Isverified");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Hashed)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.Otp).HasColumnName("OTP");
            entity.Property(e => e.OtpcreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("OTPCreatedDate");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SequenceNumber).HasMaxLength(30);
            entity.Property(e => e.VerifiedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<UserNotification>(entity =>
        {
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<UserPurchasedPromotionProgram>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserPurchasedPrograms");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.InsuranceCompany).WithMany(p => p.UserPurchasedPromotionPrograms)
                .HasForeignKey(d => d.InsuranceCompanyId)
                .HasConstraintName("FK_UserPurchasedPrograms_InsuranceCompany");

            entity.HasOne(d => d.PromotionProgram).WithMany(p => p.UserPurchasedPromotionPrograms)
                .HasForeignKey(d => d.PromotionProgramId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPurchasedPrograms_PromotionProgram");

            entity.HasOne(d => d.User).WithMany(p => p.UserPurchasedPromotionPrograms)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserPurchasedPrograms_AspNetUsers");
        });

        modelBuilder.Entity<UserTicket>(entity =>
        {
            entity.ToTable("UserTicket");

            entity.Property(e => e.CheckedoutEmail).HasMaxLength(256);
            entity.Property(e => e.CheckedoutPhone).HasMaxLength(20);
            entity.Property(e => e.CreatedBy).HasMaxLength(256);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomCardNumber).HasMaxLength(30);
            entity.Property(e => e.DriverNin).HasMaxLength(20);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo).HasMaxLength(36);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.RepliedBy).HasMaxLength(100);
            entity.Property(e => e.SequenceNumber).HasMaxLength(30);
            entity.Property(e => e.TicketModuleId).HasDefaultValueSql("((1))");
            entity.Property(e => e.UserEmail).HasMaxLength(256);
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UserNotes).HasMaxLength(200);
            entity.Property(e => e.UserPhone).HasMaxLength(20);
        });

        modelBuilder.Entity<UserTicketAttachment>(entity =>
        {
            entity.ToTable("UserTicketAttachment");

            entity.Property(e => e.AttachmentPath).HasMaxLength(500);
        });

        modelBuilder.Entity<UserTicketHistory>(entity =>
        {
            entity.ToTable("UserTicketHistory");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RepliedBy).HasMaxLength(255);
        });

        modelBuilder.Entity<UserTicketStatus>(entity =>
        {
            entity.ToTable("UserTicketStatus");

            entity.Property(e => e.StatusNameAr).HasMaxLength(50);
            entity.Property(e => e.StatusNameEn).HasMaxLength(50);
        });

        modelBuilder.Entity<UserTicketType>(entity =>
        {
            entity.ToTable("UserTicketType");

            entity.Property(e => e.TicketTypeNameAr).HasMaxLength(50);
            entity.Property(e => e.TicketTypeNameEn).HasMaxLength(50);
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasIndex(e => new { e.CustomCardNumber, e.VehicleValue, e.ParkingLocationId, e.TransmissionTypeId, e.ModificationDetails }, "CC_VV_PL_TT_MD");

            entity.HasIndex(e => new { e.SequenceNumber, e.IsDeleted }, "IX_SequenceNumber_IsDeleted").HasFillFactor(100);

            entity.HasIndex(e => e.VehicleMakerCode, "IX_VehicleMakerCode");

            entity.HasIndex(e => e.VehicleModelCode, "IX_VehicleModelCode");

            entity.HasIndex(e => e.CustomCardNumber, "IX_Vehicles_CustomCardNumber");

            entity.HasIndex(e => e.SequenceNumber, "IX_Vehicles_SequenceNumber");

            entity.HasIndex(e => new { e.SequenceNumber, e.VehicleValue, e.ParkingLocationId, e.TransmissionTypeId, e.ModificationDetails }, "Seq_VV_PL_TT_MD");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CarOwnerNin).HasColumnName("CarOwnerNIN");
            entity.Property(e => e.CarPlateText1).HasMaxLength(1);
            entity.Property(e => e.CarPlateText2).HasMaxLength(1);
            entity.Property(e => e.CarPlateText3).HasMaxLength(1);
            entity.Property(e => e.ChassisNumber).HasMaxLength(30);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.CurrentMileageKm)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("CurrentMileageKM");
            entity.Property(e => e.CustomCardNumber).HasMaxLength(30);
            entity.Property(e => e.LicenseExpiryDate).HasMaxLength(20);
            entity.Property(e => e.MajorColor).HasMaxLength(20);
            entity.Property(e => e.ManualEntry).HasDefaultValueSql("((0))");
            entity.Property(e => e.MinorColor).HasMaxLength(20);
            entity.Property(e => e.ModificationDetails).HasMaxLength(200);
            entity.Property(e => e.RegisterationPlace).HasMaxLength(20);
            entity.Property(e => e.SequenceNumber).HasMaxLength(30);
            entity.Property(e => e.VehicleIdTypeId).HasDefaultValueSql("((1))");
            entity.Property(e => e.VehicleMaker).HasMaxLength(50);
            entity.Property(e => e.VehicleModel).HasMaxLength(30);

            entity.HasOne(d => d.PlateTypeCodeNavigation).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.PlateTypeCode)
                .HasConstraintName("FK_Vehicles_VehiclePlateType");

            entity.HasOne(d => d.VehicleBodyCodeNavigation).WithMany(p => p.Vehicles)
                .HasForeignKey(d => d.VehicleBodyCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vehicles_VehicleBody");

            entity.HasMany(d => d.VehicleSpecifications).WithMany(p => p.Vehicles)
                .UsingEntity<Dictionary<string, object>>(
                    "VehicleVehicleSpecification",
                    r => r.HasOne<VehicleSpecification>().WithMany()
                        .HasForeignKey("VehicleSpecificationId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Vehicle_V__Vehic__44952D46"),
                    l => l.HasOne<Vehicle>().WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Vehicle_V__Vehic__43A1090D"),
                    j =>
                    {
                        j.HasKey("VehicleId", "VehicleSpecificationId").HasName("VehicleS_VehicleSpec_PK");
                        j.ToTable("Vehicle_VehicleSpecification");
                    });
        });

        modelBuilder.Entity<VehicleBodyType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VehicleBodyType");

            entity.Property(e => e.Code).ValueGeneratedOnAdd();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValueSql("('FALSE')");
            entity.Property(e => e.YakeenCode).HasMaxLength(50);
        });

        modelBuilder.Entity<VehicleColor>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VehicleColor");

            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
            entity.Property(e => e.YakeenColor).HasMaxLength(500);
        });

        modelBuilder.Entity<VehicleDiscount>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomCardNumber).HasMaxLength(50);
            entity.Property(e => e.DiscountCode).HasMaxLength(50);
            entity.Property(e => e.IsUsed).HasDefaultValueSql("((0))");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Nin).HasMaxLength(50);
            entity.Property(e => e.PreviousReferenceId).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.SequenceNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<VehicleIdtype>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VehicleIDType");

            entity.Property(e => e.Code).ValueGeneratedOnAdd();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<VehicleMaker>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VehicleMaker");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<VehicleMakerTemp>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VehicleMakerTemp");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<VehicleModel>(entity =>
        {
            entity.HasKey(e => new { e.Code, e.VehicleMakerCode }).HasName("PK_VehicleModel_1");

            entity.ToTable("VehicleModel");

            entity.HasIndex(e => e.Code, "IX_Code");

            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);

            entity.HasOne(d => d.VehicleMakerCodeNavigation).WithMany(p => p.VehicleModels)
                .HasForeignKey(d => d.VehicleMakerCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VehicleModel_VehicleMaker");
        });

        modelBuilder.Entity<VehicleModelTemp>(entity =>
        {
            entity.HasKey(e => new { e.Code, e.VehicleMakerCode }).HasName("PK_VehicleModel");

            entity.ToTable("VehicleModelTemp");

            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<VehiclePlateText>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VehiclePlateText");

            entity.Property(e => e.Code).ValueGeneratedOnAdd();
            entity.Property(e => e.ArabicDescription).HasMaxLength(50);
            entity.Property(e => e.EnglishDescription).HasMaxLength(50);
        });

        modelBuilder.Entity<VehiclePlateType>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("VehiclePlateType");

            entity.Property(e => e.Code).ValueGeneratedOnAdd();
            entity.Property(e => e.ArabicDescription).HasMaxLength(200);
            entity.Property(e => e.EnglishDescription).HasMaxLength(200);
        });

        modelBuilder.Entity<VehicleRequest>(entity =>
        {
            entity.HasIndex(e => new { e.VehicleId, e.CreatedDate }, "VehicleId_CreatedDate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DriverNin).HasMaxLength(50);
            entity.Property(e => e.VehicleId).HasMaxLength(50);
        });

        modelBuilder.Entity<VehicleSpecification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleS__3214EC0728DD3E2B");

            entity.ToTable("VehicleSpecification");

            entity.Property(e => e.DescriptionAr).HasMaxLength(100);
            entity.Property(e => e.DescriptionEn).HasMaxLength(100);
        });

        modelBuilder.Entity<VehicleTransmissionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleT__3214EC070298E33A");

            entity.ToTable("VehicleTransmissionType");

            entity.Property(e => e.NameAr).HasMaxLength(500);
            entity.Property(e => e.NameEn).HasMaxLength(500);
        });

        modelBuilder.Entity<VehicleUsage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VehicleUse");

            entity.ToTable("VehicleUsage");
        });

        modelBuilder.Entity<VehicleUsagePercentage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleU__3214EC072ECA7B20");

            entity.ToTable("VehicleUsagePercentage");

            entity.Property(e => e.NameAr).HasMaxLength(50);
            entity.Property(e => e.NameEn).HasMaxLength(50);
        });

        modelBuilder.Entity<Violation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Violatio__3214EC07CD1F20F5");

            entity.ToTable("Violation");

            entity.Property(e => e.DescriptionAr).HasMaxLength(100);
            entity.Property(e => e.DescriptionEn).HasMaxLength(100);
        });

        modelBuilder.Entity<Wareef>(entity =>
        {
            entity.ToTable("Wareef");

            entity.HasIndex(e => e.WareefCategoryId, "IX_WareefCategoryId");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(150);
            entity.Property(e => e.ItemUrl)
                .HasMaxLength(255)
                .HasColumnName("ItemURl");
            entity.Property(e => e.ModifiedBy).HasMaxLength(150);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NameAr).HasMaxLength(150);
            entity.Property(e => e.NameEn).HasMaxLength(150);
            entity.Property(e => e.Wcode)
                .HasMaxLength(50)
                .HasColumnName("WCode");
        });

        modelBuilder.Entity<WareefCategory>(entity =>
        {
            entity.ToTable("WareefCategory");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Createdby).HasMaxLength(255);
            entity.Property(e => e.ModifiedBy).HasMaxLength(255);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.NameAr).HasMaxLength(255);
            entity.Property(e => e.NameEn).HasMaxLength(255);
        });

        modelBuilder.Entity<WareefDescount>(entity =>
        {
            entity.Property(e => e.DescountValue).HasMaxLength(150);
            entity.Property(e => e.WdescountCode)
                .HasMaxLength(150)
                .HasColumnName("WDescountCode");
        });

        modelBuilder.Entity<WareefDiscountBenefit>(entity =>
        {
            entity.ToTable("WareefDiscountBenefit");
        });

        modelBuilder.Entity<WataniyaDraftPolicy>(entity =>
        {
            entity.ToTable("WataniyaDraftPolicy");

            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Method).HasMaxLength(255);
            entity.Property(e => e.PolicyEffectiveDate).HasMaxLength(50);
            entity.Property(e => e.PolicyExpiryDate).HasMaxLength(50);
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.QuotationNumber).HasMaxLength(50);
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.ReferenceNumber).HasMaxLength(255);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<WataniyaMotorPolicyInfo>(entity =>
        {
            entity.ToTable("WataniyaMotorPolicyInfo");

            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.InsuranceTypeId).HasColumnName("InsuranceTypeID");
            entity.Property(e => e.Method).HasMaxLength(255);
            entity.Property(e => e.OldPolicyNo).HasMaxLength(50);
            entity.Property(e => e.PolicyEffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyReferenceNo).HasMaxLength(255);
            entity.Property(e => e.PolicyRequestReferenceNo).HasMaxLength(15);
            entity.Property(e => e.QuoteReferenceNo).HasMaxLength(255);
            entity.Property(e => e.ReferenceId).HasMaxLength(15);
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<WataniyaNajmQueue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WataniyaNajmQueue");

            entity.Property(e => e.Channel).HasMaxLength(100);
            entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            entity.Property(e => e.CompanyName).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo).HasMaxLength(100);
            entity.Property(e => e.PolicyReferenceNo).HasMaxLength(100);
            entity.Property(e => e.ProcessedOn).HasColumnType("datetime");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(100)
                .HasColumnName("ServerIP");
        });

        modelBuilder.Entity<YakeenCityCenter>(entity =>
        {
            entity.ToTable("YakeenCityCenter");

            entity.HasIndex(e => e.CityId, "IX_CityId");

            entity.HasIndex(e => e.ZipCode, "IX_ZipCode");

            entity.Property(e => e.CityId).HasColumnName("CityID");
            entity.Property(e => e.CityName).HasMaxLength(100);
            entity.Property(e => e.EnglishName).HasMaxLength(100);
            entity.Property(e => e.RegionArabicName).HasMaxLength(100);
            entity.Property(e => e.RegionEnglishName).HasMaxLength(100);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
        });

        modelBuilder.Entity<YakeenDriver>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.DriverId, "IX_DriverId");

            entity.HasIndex(e => e.CreatedDate, "idx_CreatedDate");

            entity.HasIndex(e => e.Nin, "idx_NIN");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirthG).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirthH).HasMaxLength(100);
            entity.Property(e => e.IdExpiryDate).HasMaxLength(50);
            entity.Property(e => e.IdIssuePlace).HasMaxLength(50);
            entity.Property(e => e.Nin)
                .HasMaxLength(50)
                .HasColumnName("NIN");
            entity.Property(e => e.OccupationCode).HasMaxLength(10);
            entity.Property(e => e.SocialStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<YakeenVehicle>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ChassisNumber).HasMaxLength(30);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomCardNumber).HasMaxLength(30);
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LicenseExpiryDate).HasMaxLength(20);
            entity.Property(e => e.MajorColor).HasMaxLength(20);
            entity.Property(e => e.MinorColor).HasMaxLength(20);
            entity.Property(e => e.RegisterationPlace).HasMaxLength(20);
            entity.Property(e => e.SequenceNumber).HasMaxLength(30);
            entity.Property(e => e.VehicleMaker).HasMaxLength(50);
            entity.Property(e => e.VehicleModel).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
