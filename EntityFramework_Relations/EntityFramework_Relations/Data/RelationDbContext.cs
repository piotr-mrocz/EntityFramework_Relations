﻿using EntityFramework_Relations.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_Relations.Data;

public class RelationDbContext : DbContext
{
    public RelationDbContext(DbContextOptions options) : base(options)
    {
    }

    #region DbSets
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<WorkItem> WorkItems { get; set; }
    #endregion DbSets

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>()
            .HasOne(u => u.Address) // because User is in relation with Address (1 to 1)
            .WithOne(a => a.User) // because Address is in relation with User (1 to 1)
            .HasForeignKey<Address>(a => a.UserId); // foreign key is in Address class and it's name is UserId

        // we don't have to write this relation in second way (Coment => WorkItem). This is enough
        builder.Entity<WorkItem>()
            .HasMany(w => w.Comments) // one WorkItem has many comments
            .WithOne(c => c.WorkItem) // one Comment has only one WorkItem
            .HasForeignKey(x => x.WorkItemId);

        base.OnModelCreating(builder);
    }
}
