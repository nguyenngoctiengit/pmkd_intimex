using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Models.Trading_system
{
    public partial class ecommerceContext : tradingsystemContext
    {
        public virtual DbSet<UserRight> UserRight { get; set; }

        public ecommerceContext(DbContextOptions<tradingsystemContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                
            /*modelBuilder.Entity<ecommerceContext>().OwnsOne(x => x.UserRight);*/
        }
    }
}

