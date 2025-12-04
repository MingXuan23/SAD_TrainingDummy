using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1.models;

public partial class ProductDatabaseContext : DbContext
{
    public ProductDatabaseContext()
    {
    }

    public ProductDatabaseContext(DbContextOptions<ProductDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductIngredient> ProductIngredients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=CHUAHMX\\MSSQLSERVER2022;Initial Catalog=ProductDatabase;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6EDA441EAEA");

            entity.HasIndex(e => e.Sku, "UQ__Products__CA1ECF0DDFF8F308").IsUnique();

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.AllergenInfo).HasMaxLength(200);
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ModifiedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.ProductionCost).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.RetailPrice).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.ServingSize).HasMaxLength(50);
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("SKU");
        });

        modelBuilder.Entity<ProductIngredient>(entity =>
        {
            entity.HasKey(e => e.IngredientId).HasName("PK__ProductI__BEAEB27A79C0A6BA");

            entity.Property(e => e.IngredientId).HasColumnName("IngredientID");
            entity.Property(e => e.CostPerUnit).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.IngredientName).HasMaxLength(200);
            entity.Property(e => e.Notes).HasMaxLength(200);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.QuantityRequired).HasColumnType("decimal(10, 3)");
            entity.Property(e => e.SupplierName).HasMaxLength(100);
            entity.Property(e => e.UnitOfMeasure).HasMaxLength(20);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductIngredients)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK_ProductIngredients_Products");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
