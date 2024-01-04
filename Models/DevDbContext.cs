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

    public virtual DbSet<MealLog> MealLog { get; set; }

    public virtual DbSet<BreakFastOption> BreakFastOptions { get; set; }
    public virtual DbSet<LunchOption> LunchOptions { get; set; }
    public virtual DbSet<DinnerOption> DinnerOptions { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=Dev_DB;Trusted_Connection=True; encrypt=False");
                                        //YOUR CONNECTION STRING MUST EXACTLY BE LIKE THIS
                                        //WHICH MEANS YOU CREATE A NEW SQL SERVER CALLED "localhost"
                                        
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

            entity.HasKey(e => e.Password);

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_name");
        });

        modelBuilder.Entity<Cashier>().HasData(
            new Cashier { UserName = "test", Password = "123" }
            );

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.PhoneNumber);

            entity.Property(e => e.BreakfastCounter).HasColumnName("breakfast_counter");
            entity.Property(e => e.DinnerCounter).HasColumnName("dinner_counter");
            entity.Property(e => e.LunchCounter).HasColumnName("lunch_counter");
            entity.Property(e => e.MealId).HasColumnName("meal_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
			    .ValueGeneratedNever()
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
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Meal>().HasData(
            new Meal { MealId = 1, Name = "نظام الوجبه الواحده"},
            new Meal { MealId = 2, Name = "نظام الوجبتين"},
            new Meal { MealId = 3, Name = "نظام الثلاث وجبات"}
            );

        modelBuilder.Entity<MealLog>(entity =>
        {

            entity.HasKey(e => e.TimeTaken);
            entity.ToTable("MealLog");

            entity.Property(e => e.TimeTaken)
                .HasColumnName("time_taken")
                .ValueGeneratedNever();

            entity.Property(e => e.PhoneNumber)
                .ValueGeneratedNever()
                .HasColumnName("phone_number");
            entity.Property(e => e.choosen_meal).HasColumnName("choosen_meal");
            entity.Property(e => e.MealId).HasColumnName("meal_id");

        });

        modelBuilder.Entity<BreakFastOption>(entity =>
        {
            entity.HasKey(e => e.optionID);
            entity.Property(e => e.optionID)
                .ValueGeneratedNever()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("optionID");
			entity.Property(e => e.optionName).HasColumnName("optionName");
			entity.Property(e => e.MealId).HasColumnName("meal_id");
			entity.HasOne(d => d.Meal).WithMany(p => p.BreakFastOptions)
				.HasForeignKey(d => d.MealId)
				.HasConstraintName("FK_BreakFastOptions_Meals");
		});

		modelBuilder.Entity<LunchOption>(entity =>
		{
			entity.HasKey(e => e.optionID);
			entity.Property(e => e.optionID)
				.ValueGeneratedNever()
				.HasMaxLength(50)
				.IsUnicode(false)
				.HasColumnName("optionID");
			entity.Property(e => e.optionName).HasColumnName("optionName");
			entity.Property(e => e.MealId).HasColumnName("meal_id");
			entity.HasOne(d => d.Meal).WithMany(p => p.LunchOptions)
				.HasForeignKey(d => d.MealId)
				.HasConstraintName("FK_LunchOptions_Meals");
		});

		modelBuilder.Entity<DinnerOption>(entity =>
		{
			entity.HasKey(e => e.optionID);
			entity.Property(e => e.optionID)
				.ValueGeneratedNever()
				.HasMaxLength(50)
				.IsUnicode(false)
				.HasColumnName("optionID");
			entity.Property(e => e.optionName).HasColumnName("optionName");
			entity.Property(e => e.MealId).HasColumnName("meal_id");
			entity.HasOne(d => d.Meal).WithMany(p => p.DinnerOptions)
				.HasForeignKey(d => d.MealId)
				.HasConstraintName("FK_DinnerOptions_Meals");
		});

		OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
