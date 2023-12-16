using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Westry.Models;

public partial class DevDbContext : DbContext
{
    public DevDbContext()
    {
    }

    public DevDbContext(DbContextOptions<DevDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Cashier> Cashiers { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Meal> Meals { get; set; }

    public virtual DbSet<MealLog> MealLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Dev_DB;Trusted_Connection=True; encrypt=False");
                                        //YOUR CONNECTION STRING MUST EXACTLY BE LIKE THIS
                                        //WHICH MEANS YOU CREATE A NEW SQL SERVER CALLED "localhost"
                                        //AND THEN CREATE A DATABASE IN IT CALLED "Dev_DB"
                                        //AND CREATE THE SAME TABLES WITH THE SAME COLUMN NAMES
                                        //AND ASSIGN PRIMARY KEYS IN EACH ONE

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.Property(e => e.AdminId)
                .ValueGeneratedNever()
                .HasColumnName("admin_id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<Cashier>(entity =>
        {
            entity.Property(e => e.CashierId)
                .ValueGeneratedNever()
                .HasColumnName("cashier_id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("customer_id");
            entity.Property(e => e.BreakfastCounter).HasColumnName("breakfast_counter");
            entity.Property(e => e.DinnerCounter).HasColumnName("dinner_counter");
            entity.Property(e => e.LunchCounter).HasColumnName("lunch_counter");
            entity.Property(e => e.MealId).HasColumnName("meal_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone_number");
            entity.Property(e => e.SubscriptionCount).HasColumnName("subscription_count");

            entity.HasOne(d => d.Meal).WithMany(p => p.Customers)
                .HasForeignKey(d => d.MealId)
                .HasConstraintName("FK_Customers_Meals");
        });

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.Property(e => e.MealId)
                .ValueGeneratedNever()
                .HasColumnName("meal_id");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MealLog>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("MealLog");

            entity.Property(e => e.RecordId)
                .ValueGeneratedNever()
                .HasColumnName("record_id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.MealId).HasColumnName("meal_id");

            entity.HasOne(d => d.Meal).WithMany(p => p.MealLogs)
                .HasForeignKey(d => d.MealId)
                .HasConstraintName("FK_MealLog_Meals");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
