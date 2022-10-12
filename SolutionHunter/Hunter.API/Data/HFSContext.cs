using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hunter.API.Data
{
    public partial class HFSContext : IdentityDbContext<ApiUser>
    {
        public HFSContext()
        {
        }

        public HFSContext(DbContextOptions<HFSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Bio).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Image).HasMaxLength(50);

                entity.Property(e => e.Isbn)
                    .HasMaxLength(50)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Summary).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.AuthorId)
                    .HasConstraintName("FK_Books_Books");
            });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = "1d97e3bb-98d2-427a-86b6-e66ba2c693ba"
                },
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    Id = "0d58b9f5-6791-4ad7-bd56-df2fd72a6eb2"
                }
            );

            var hasher = new PasswordHasher<ApiUser>();

            modelBuilder.Entity<ApiUser>().HasData(
                new ApiUser
                {
                    Id = "b9554fd5-af94-4d11-bc4e-4ba1b7cd1377",
                    FirstName = "System",
                    LastName = "Administrator",
                    KnownAs = "Admin",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "Testtest$0")
                },
                 new ApiUser
                 {
                     Id = "dfc49bbb-fa45-414d-aa35-e737ffa56e9a",
                     FirstName = "Patch",
                     LastName = "Duncan",
                     KnownAs = "Patch",
                     UserName = "Patch",
                     NormalizedUserName = "PATCH",
                     PasswordHash = hasher.HashPassword(null, "Testtest$0")
                 }
             );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "0d58b9f5-6791-4ad7-bd56-df2fd72a6eb2",    // Admin role
                    UserId = "b9554fd5-af94-4d11-bc4e-4ba1b7cd1377"     // Admin user
                },
                new IdentityUserRole<string>
                {
                    RoleId = "1d97e3bb-98d2-427a-86b6-e66ba2c693ba",    // User role
                    UserId = "dfc49bbb-fa45-414d-aa35-e737ffa56e9a"     // Patch user
                }
             );

            // OnModelCreatingPartial(modelBuilder);
        }

        //       private partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
