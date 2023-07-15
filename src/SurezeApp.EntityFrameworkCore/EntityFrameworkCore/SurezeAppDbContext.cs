using Microsoft.EntityFrameworkCore;
using SurezeApp.Patients;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace SurezeApp.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class SurezeAppDbContext :
    AbpDbContext<SurezeAppDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public SurezeAppDbContext(DbContextOptions<SurezeAppDbContext> options)
        : base(options)
    {

    }

    public DbSet<AlternateIDType> AlternateIDTypes { get; set; }
    public DbSet<PatientTitle> PatientTitles { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<PatientRace> PatientRaces { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Ethnicity> Ethnicities { get; set; }
    public DbSet<EducationLevel> EducationLevels { get; set; }
    public DbSet<Nationality> Nationalities { get; set; }
    public DbSet<Religion> Religions { get; set; }
    public DbSet<MaritalStatus> MaritalStatuses { get; set; }
    public DbSet<PatientCategory> PatientCategories { get; set; }
    public DbSet<PatientDetail> PatientDetails { get; set; }
    public DbSet<ContactDetail> ContactDetails { get; set; }
    public DbSet<SpecimenOrder> SpecimenOrders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(SurezeAppConsts.DbTablePrefix + "YourEntities", SurezeAppConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        builder.Entity<AlternateIDType>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<PatientTitle>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<Gender>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<PatientRace>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<Language>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<Ethnicity>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<EducationLevel>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<Nationality>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<Religion>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<MaritalStatus>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<PatientCategory>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.Code).IsRequired().HasMaxLength(15);
            b.Property(x => x.Name).IsRequired().HasMaxLength(128);
        });

        builder.Entity<ContactDetail>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.ContactMode).IsRequired();
            b.Property(x => x.Address1).IsRequired().HasMaxLength(250);
            b.Property(x => x.Address2).HasMaxLength(250);
            b.Property(x => x.Address2).HasMaxLength(250);
            b.Property(x => x.PostalCode).HasMaxLength(128);
            b.Property(x => x.City).HasMaxLength(128);
            b.Property(x => x.State).HasMaxLength(128);
            b.Property(x => x.Email).HasMaxLength(128);
            b.Property(x => x.PhoneNumber1).HasMaxLength(20);
            b.Property(x => x.PhoneNumber2).HasMaxLength(20);

            // ADD THE MAPPING FOR THE RELATION
            b.HasOne<PatientDetail>().WithMany().HasForeignKey(x => x.PatientId).IsRequired();
        });

        builder.Entity<SpecimenOrder>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.LocationType).IsRequired();
            b.Property(x => x.Location).IsRequired();
            b.Property(x => x.Priority).IsRequired();

            // ADD THE MAPPING FOR THE RELATION
            b.HasOne<PatientDetail>().WithMany().HasForeignKey(x => x.PatientId).IsRequired();
        });

        builder.Entity<PatientDetail>(b =>
        {
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.MRN).IsRequired().HasMaxLength(25);
            b.Property(x => x.Suffix).HasMaxLength(25);
            b.Property(x => x.FirstName).IsRequired().HasMaxLength(250);
            b.Property(x => x.LastName).HasMaxLength(250);
            b.Property(x => x.NationalIDNumber).IsRequired().HasMaxLength(20);
            b.Property(x => x.AlternateIDNumber).HasMaxLength(250);
        });
    }
}
