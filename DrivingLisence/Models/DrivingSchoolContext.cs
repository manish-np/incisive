using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DrivingLisence.Models
{
    public partial class DrivingSchoolContext : DbContext
    {
        public DrivingSchoolContext()
        {
        }

        public DrivingSchoolContext(DbContextOptions<DrivingSchoolContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BloodGroup> BloodGroup { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DistrictList> DistrictList { get; set; }
        public virtual DbSet<LocalBody> LocalBody { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<Organization> Organization { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<ResourcesAction> ResourcesAction { get; set; }
        public virtual DbSet<ResourcesActionRolesMap> ResourcesActionRolesMap { get; set; }
        public virtual DbSet<ResourcesRoles> ResourcesRoles { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.ToTable("BloodGroup", "Core");

                entity.Property(e => e.BloodGroupId)
                    .HasColumnName("BloodGroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BloodGroup1)
                    .IsRequired()
                    .HasColumnName("BloodGroup")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch", "Core");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocalBodyId).HasColumnName("LocalBodyID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country", "Core");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Alpha2Code)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Alpha3Code)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Capital).HasMaxLength(50);

                entity.Property(e => e.Flag).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NativeName).HasMaxLength(150);

                entity.Property(e => e.Region).HasMaxLength(150);

                entity.Property(e => e.Subregion).HasMaxLength(150);
            });

            modelBuilder.Entity<DistrictList>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.ToTable("DistrictList", "Core");

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            });

            modelBuilder.Entity<LocalBody>(entity =>
            {
                entity.ToTable("LocalBody", "Core");

                entity.Property(e => e.DistrictRefId).HasColumnName("DistrictRef_Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameNepali).HasMaxLength(1000);
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu", "Core");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.Icons).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.MenuUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ResourceActionId).HasColumnName("ResourceActionID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.ToTable("Module", "Core");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.ModuleDesc).HasMaxLength(250);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.RoutePath).HasMaxLength(50);
            });

            modelBuilder.Entity<Organization>(entity =>
            {
                entity.ToTable("Organization", "Core");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.ContactNo).HasMaxLength(15);

                entity.Property(e => e.ContactPerson).HasMaxLength(150);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.EstablishedDate).HasColumnType("date");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.LocalBodyId).HasColumnName("LocalBodyID");

                entity.Property(e => e.LogoUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PanNo).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.VatNo).HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.ToTable("Province", "Core");

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("ProvinceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Capital).HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Resources>(entity =>
            {
                entity.HasKey(e => e.ResourceId)
                    .HasName("PK_Resource");

                entity.ToTable("Resources", "Core");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.ResourceDesc).HasMaxLength(250);

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResourcesAction>(entity =>
            {
                entity.HasKey(e => e.ResourceActionId)
                    .HasName("PK_ResourceAction");

                entity.ToTable("ResourcesAction", "Core");

                entity.Property(e => e.ResourceActionId).HasColumnName("ResourceActionID");

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.ResourceActionCode).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            });

            modelBuilder.Entity<ResourcesActionRolesMap>(entity =>
            {
                entity.ToTable("ResourcesActionRolesMap", "Core");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ResourceActionId).HasColumnName("ResourceActionID");

                entity.Property(e => e.ResourceRoleId).HasColumnName("ResourceRoleID");
            });

            modelBuilder.Entity<ResourcesRoles>(entity =>
            {
                entity.HasKey(e => e.ResourceRoleId)
                    .HasName("PK_ResourceRole");

                entity.ToTable("ResourcesRoles", "Core");

                entity.Property(e => e.ResourceRoleId).HasColumnName("ResourceRoleID");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Roles", "Core");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.RoleDesc).HasMaxLength(250);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.ToTable("UserRoles", "Core");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrgId).HasColumnName("OrgID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "Core");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastBlockedDate).HasColumnType("datetime2(3)");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(3)");

                entity.Property(e => e.OrgId)
                    .IsRequired()
                    .HasColumnName("OrgID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SecurityStamp)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
