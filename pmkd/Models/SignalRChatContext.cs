using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace pmkd.Models
{
    public partial class SignalRChatContext : DbContext
    {
        public SignalRChatContext()
        {
        }

        public SignalRChatContext(DbContextOptions<SignalRChatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<UserBranch> UserBranches { get; set; }
        public virtual DbSet<UserRight> UserRights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=SignalRChat;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.status).HasColumnName("status");

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.AddressE)
                    .HasMaxLength(255)
                    .HasColumnName("Address_E");

                entity.Property(e => e.AddressV)
                    .HasMaxLength(255)
                    .HasColumnName("Address_V");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.Icocode)
                    .HasMaxLength(50)
                    .HasColumnName("ICOCode");

                entity.Property(e => e.Mst)
                    .HasMaxLength(50)
                    .HasColumnName("MST");

                entity.Property(e => e.NameBg)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Name_BG")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameE)
                    .HasMaxLength(255)
                    .HasColumnName("Name_E");

                entity.Property(e => e.NameV)
                    .HasMaxLength(255)
                    .HasColumnName("Name_V");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.TimeStamp)
                    .IsRequired()
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TitleDocument)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ToaKinhTe).HasMaxLength(255);

                entity.Property(e => e.UnitType).HasColumnName("unit_type");

                entity.Property(e => e.WebSite).HasMaxLength(255);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");

                entity.Property(e => e.TiLe)
                    .HasColumnType("decimal(18, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Unit1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Unit");

                entity.Property(e => e.UnitSub)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserBranch>(entity =>
            {
                entity.HasKey(e => e.UserBranchId);

                entity.ToTable("UserBranch");

                entity.Property(e => e.BranchId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserRight>(entity =>
            {
                entity.HasKey(e => e.UserName1);

                entity.ToTable("UserRight");

                entity.Property(e => e.UserName1).HasMaxLength(50);

                entity.Property(e => e.AutoMaticSms).HasColumnName("AutoMaticSMS");

                entity.Property(e => e.ComputerInfor)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FullName1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PassWord1)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RememberPw).HasColumnName("RememberPW");

                entity.Property(e => e.ShowAll)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("showAll")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasComment("0: chưa active - 1: đã active");

                entity.Property(e => e.StatusUpdate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UnitCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).ValueGeneratedOnAdd();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
