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

		modelBuilder.Entity<Admin>().HasData(
			new Admin { AdminId = 1, UserName ="admin", Password="123"}
			);

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

            entity.Property(e => e.ordersServied)
                .HasColumnName("orders_servied");

            entity.Property(e => e.loggedInTime)
                .HasColumnName("loggedIn_time");
			entity.Property(e => e.loggedOutTime)
				.HasColumnName("LoggedOut_time");
		});

		modelBuilder.Entity<Cashier>().HasData(
            new Cashier { UserName = "test", Password = "123",ordersServied = 0 }
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
            entity.Property(e => e.createdBy).HasColumnName("created_by");

            entity.HasOne(d => d.Meal).WithMany(p => p.Customers)
                .HasForeignKey(d => d.MealId)
                .HasConstraintName("FK_Customers_Meals");
        });

        modelBuilder.Entity<Meal>(entity =>
        {
            entity.Property(e => e.MealId)
                .HasColumnName("meal_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true)
                .HasColumnName("name");

            entity.Property(e => e.hasBreakfast)
                .HasColumnName("hasBreakfast");

			entity.Property(e => e.hasLunch)
				.HasColumnName("hasLunch");

			entity.Property(e => e.hasDinner)
				.HasColumnName("hasDinner");
		});

        modelBuilder.Entity<Meal>().HasData(
            new Meal { MealId = 1, Name = "نظام الوجبه الواحده", hasBreakfast = false, hasLunch = true, hasDinner = false },
            new Meal { MealId = 2, Name = "نظام الوجبتين", hasBreakfast = true, hasLunch = true, hasDinner = false },
            new Meal { MealId = 3, Name = "نظام الثلاث وجبات", hasBreakfast = true, hasLunch = true, hasDinner = true }
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
            entity.Property(e => e.CashierName).HasColumnName("Cashier");
            entity.Property(e => e.isBuffet).HasColumnName("is_buffet");
            entity.Property(e => e.isKitchen).HasColumnName("is_kitchen");

        });

        modelBuilder.Entity<BreakFastOption>(entity =>
        {
            entity.HasKey(e => e.optionID);
            entity.Property(e => e.optionID)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("optionID");
			entity.Property(e => e.optionName).HasColumnName("optionName");
			entity.Property(e => e.MealId).HasColumnName("meal_id");
			entity.HasOne(d => d.Meal).WithMany(p => p.BreakFastOptions)
				.HasForeignKey(d => d.MealId)
				.HasConstraintName("FK_BreakFastOptions_Meals");
		});

		modelBuilder.Entity<BreakFastOption>().HasData(
			new BreakFastOption { optionID = 1, optionName = "عصير -برش مربه- برشن عسل -نوع جبنه - بيضه مسلوقه -معيش الطازج", MealId = 2 },
			new BreakFastOption { optionID = 2, optionName = "اختيار اي 3 سندوتشات من فيل الفينو", MealId = 2 },
			new BreakFastOption { optionID = 3, optionName = "قطعتين من الباتيه او الكرواسون مع الشاي او النسكافيه", MealId = 2 },
			new BreakFastOption { optionID = 4, optionName = "عصير -برش مربه- برشن عسل -نوع جبنه - بيضه مسلوقه -معيش الطازج", MealId = 3 },
			new BreakFastOption { optionID = 5, optionName = "اختيار اي 3 سندوتشات من فيل الفينو", MealId = 3 },
			new BreakFastOption { optionID = 6, optionName = "قطعتين من الباتيه او الكرواسون مع الشاي او النسكافيه", MealId = 3 }
			);

		modelBuilder.Entity<LunchOption>(entity =>
		{
			entity.HasKey(e => e.optionID);
			entity.Property(e => e.optionID)
				.HasMaxLength(50)
				.IsUnicode(false)
				.HasColumnName("optionID");
			entity.Property(e => e.optionName).HasColumnName("optionName");
			entity.Property(e => e.MealId).HasColumnName("meal_id");
			entity.HasOne(d => d.Meal).WithMany(p => p.LunchOptions)
				.HasForeignKey(d => d.MealId)
				.HasConstraintName("FK_LunchOptions_Meals");
		});

		modelBuilder.Entity<LunchOption>().HasData(
			new LunchOption { optionID = 1, optionName = "وجبة البوفتيك والأرز والبوم فريت", MealId = 1 },
			new LunchOption { optionID = 2, optionName = "وجبة الاستربس مع الأرز والبوم فريت", MealId = 1 },
			new LunchOption { optionID = 3, optionName = "وجبة الكفته والأرز والبوم الفريت", MealId = 1 },
			new LunchOption { optionID = 4, optionName = "وجبة الفراخ المشوية مع الأرز والبوم فريت", MealId = 1 },

			new LunchOption { optionID = 5, optionName = "وجبة البوفتيك والأرز والبوم فريت", MealId = 2 },
			new LunchOption { optionID = 6, optionName = "وجبة الاستربس مع الأرز والبوم فريت", MealId = 2 },
			new LunchOption { optionID = 7, optionName = "وجبة الكفته والأرز والبوم الفريت", MealId = 2 },
			new LunchOption { optionID = 8, optionName = "وجبة الفراخ المشوية مع الأرز والبوم فريت", MealId = 2 },

			new LunchOption { optionID = 9, optionName = "وجبة البوفتيك والأرز والبوم فريت", MealId = 3 },
			new LunchOption { optionID = 10, optionName = "وجبة الاستربس مع الأرز والبوم فريت", MealId = 3 },
			new LunchOption { optionID = 11, optionName = "وجبة الكفته والأرز والبوم الفريت", MealId = 3 },
			new LunchOption { optionID = 12, optionName = "وجبة الفراخ المشوية مع الأرز والبوم فريت", MealId = 3 }
			);

		modelBuilder.Entity<DinnerOption>(entity =>
		{
			entity.HasKey(e => e.optionID);
			entity.Property(e => e.optionID)
				.HasMaxLength(50)
				.IsUnicode(false)
				.HasColumnName("optionID");
			entity.Property(e => e.optionName).HasColumnName("optionName");
			entity.Property(e => e.MealId).HasColumnName("meal_id");
			entity.HasOne(d => d.Meal).WithMany(p => p.DinnerOptions)
				.HasForeignKey(d => d.MealId)
				.HasConstraintName("FK_DinnerOptions_Meals");
		});

		modelBuilder.Entity<DinnerOption>().HasData(
			new DinnerOption { optionID = 1, optionName = "( البيتزا): مرجريتا -- او بيتزا الخضار -- او بيتزا الهوت دوج", MealId = 3 },
			new DinnerOption { optionID = 2, optionName = "البرجر مع الكلوسلو سلاط والبوم فريت", MealId = 3 },
			new DinnerOption { optionID = 3, optionName = "4 سندوتشات من فيل افينو", MealId = 3 },
			new DinnerOption { optionID = 4, optionName = "قطع 3من دجاج الاستربس مع البوم فريت", MealId = 3 }
			);

		OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
