using System;
using System.Collections.Generic;
using DatabaseFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproach.Data;

public partial class MenuBlazorDataContext : DbContext
{
    public MenuBlazorDataContext()
    {
    }

    public MenuBlazorDataContext(DbContextOptions<MenuBlazorDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<DishIngredient> DishIngredients { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DELLXPS-15\\SQLEXPRESS;Initial Catalog=MenuBlazor_Data;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
