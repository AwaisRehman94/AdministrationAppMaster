
using Microsoft.EntityFrameworkCore;

using Common.Domain.Entities;
using Common.Domain.DomainEntities.Entities.DomainEntities;




namespace Common.Infrastructure.Persistence
{
    public partial class CommonDbContext : DbContext
    {
    
        public CommonDbContext(DbContextOptions<CommonDbContext> options) : base(options)
        {

        }
        
        public virtual DbSet<AutoleasingBenefit> AutoleasingBenefit { get; set; }

        public virtual DbSet<AutoleasingDeductibles> AutoleasingDeductibles { get; set; }

        public virtual DbSet<NajmStatus> NajmStatus { get; set; }


        //public virtual DbSet<InsuranceCompany> InsuranceCompany { get; set; }

        //public virtual DbSet<Contact> Contact { get; set; }

        //public virtual DbSet<CheckoutDetails> CheckoutDetails { get; set; }

        //public virtual DbSet<Deductible> Deductible { get; set; }

        //public virtual DbSet<InsuaranceCompanyBenefit> InsuaranceCompanyBenefit { get; set; }

        //public virtual DbSet<Invoice> Invoice { get; set; }

        //public virtual DbSet<Policy> Policy { get; set; }

        //public virtual DbSet<Product> Product { get; set; }

        //public virtual DbSet<PromotionProgramCode> PromotionProgramCode { get; set; }

        //public virtual DbSet<QuotationResponse> QuotationResponse { get; set; }

        //public virtual DbSet<QuotationResponseNew> QuotationResponseNew { get; set; }

        //public virtual DbSet<UserPurchasedPromotionPrograms> UserPurchasedPromotionPrograms { get; set; }

        //public virtual DbSet<ProductType> ProductType { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Deductible>()
            //  .Property(e => e.Name)
            //  .HasPrecision(8, 2);

            //modelBuilder.Entity<InsuranceCompany>()
            // .HasMany(e => e.Deductible)
            // .WithRequired(e => e.InsuranceCompany)
            // .WillCascadeOnDelete(false);
            //modelBuilder.Entity<InsuranceCompany>()
            //    .HasMany(e => e.InsuaranceCompanyBenefit)
            //    .WithRequired(e => e.InsuranceCompany)
            //    .HasForeignKey(e => e.InsurnaceCompanyID)
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<InsuranceCompany>()
            //    .HasMany(e => e.PromotionProgramCode)
            //    .WithRequired(e => e.InsuranceCompany)
            //    .WillCascadeOnDelete(false);
            //modelBuilder.Entity<InsuranceCompany>()
            //    .HasMany(e => e.Product)
            //    .WithOptional(e => e.InsuranceCompany)
            //    .HasForeignKey(e => e.ProviderId);
            //modelBuilder.Entity<InsuranceCompany>()
            //    .HasMany(e => e.QuotationResponse)
            //    .WithRequired(e => e.InsuranceCompany)
            //    .WillCascadeOnDelete(false);
        }
    }
}