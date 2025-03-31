using MCSA_API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCSA_API.Data;

public class MCSAContext : DbContext
{
    public DbSet<DalUser> User { get; set; }
    public DbSet<DalMissingPerson> MissingPerson { get; set; }
    public DbSet<DalMissingPersonModerationQueue> MissingPersonModerationQueue { get; set; }

    public MCSAContext(DbContextOptions<MCSAContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //DalMissingPerson
        ConfigureTemporal<DalMissingPerson>(modelBuilder, "MissingPerson");

        modelBuilder.Entity<DalMissingPerson>(entity =>
        {
            entity.HasKey(x => x.Id)
                  .HasName("PK_MissingPerson_Id")
                  .IsClustered();

            entity.HasOne(d => d.LastEditedByUser)
                  .WithMany()
                  .HasForeignKey(d => d.LastEditedByUserId)
                  .HasConstraintName("FK_MissingPerson_LastEditedByUserId")
                  .OnDelete(DeleteBehavior.Restrict);
        });

        //DalMissingPersonModerationQueue
        ConfigureTemporal<DalMissingPersonModerationQueue>(modelBuilder, "MissingPersonModerationQueue");

        modelBuilder.Entity<DalMissingPersonModerationQueue>(entity =>
        {
            entity.HasKey(x => x.Id)
                  .HasName("PK_MissingPersonModerationQueue_Id")
                  .IsClustered();

            entity.HasOne(d => d.ModeratedByUser)
                  .WithMany()
                  .HasForeignKey(d => d.ModeratedByUserId)
                  .HasConstraintName("FK_MissingPersonModerationQueue_ModeratedByUserId")
                  .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(d => d.MissingPerson)
                  .WithMany()
                  .HasForeignKey(d => d.MissingPersonId)
                  .HasConstraintName("FK_MissingPersonModerationQueue_MissingPersonId")
                  .OnDelete(DeleteBehavior.Restrict);
        });

        //DalUser
        modelBuilder.Entity<DalUser>()
            .HasIndex(u => u.Username, "UQ_User_Username")
            .IsUnique();

        base.OnModelCreating(modelBuilder);
    }

    private void ConfigureTemporal<TEntity>(ModelBuilder modelBuilder, string tableName) where TEntity : class
    {
        modelBuilder.Entity<TEntity>()
            .ToTable(tableName, b => b.IsTemporal(
                b =>
                {
                    b.HasPeriodStart("SysStartTime");
                    b.HasPeriodEnd("SysEndTime");
                }));
    }
}