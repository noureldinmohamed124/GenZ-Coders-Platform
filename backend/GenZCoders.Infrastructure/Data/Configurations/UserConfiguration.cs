using GenZCoders.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenZCoders.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(DatabaseConstraints.NameMaxLength)
                .IsUnicode();

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(DatabaseConstraints.NameMaxLength)
                .IsUnicode();

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(DatabaseConstraints.EmailMaxLength)
                .IsUnicode(false);

            builder.Property(x => x.PasswordHash)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            builder.Property(x => x.PhoneNumber)
                .IsRequired()
                .HasMaxLength(DatabaseConstraints.PhoneMaxLength)
                .IsUnicode(false);

            builder.Property(x => x.ProfileImage)
                .HasMaxLength(DatabaseConstraints.UrlMaxLength)
                .IsUnicode(false);

            builder.Property(x => x.Gender)
                .HasConversion<int>();

            builder.Property(x => x.Role)
                .HasConversion<int>();

            builder.Property(x => x.Status)
                .HasConversion<int>();

            builder.Property(x => x.IsActive)
                .HasDefaultValue(true);

            builder.Property(x => x.IsEmailVerified)
                .HasDefaultValue(false);

            builder.Property(x => x.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasIndex(x => x.Email)
                .IsUnique();

            builder.HasIndex(x => x.PhoneNumber)
                .IsUnique();

            builder.HasOne(x => x.Student)
                .WithOne(x => x.User)
                .HasForeignKey<Student>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Admin)
                .WithOne(x => x.User)
                .HasForeignKey<Admin>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.EngineerInstructor)
                .WithOne(x => x.User)
                .HasForeignKey<Instructor>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.RefreshTokens)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
