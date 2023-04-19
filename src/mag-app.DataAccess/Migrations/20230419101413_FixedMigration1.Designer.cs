﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mag_app.DataAccess.DbContexts;

#nullable disable

namespace mag_app.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230419101413_FixedMigration1")]
    partial class FixedMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.12");

            modelBuilder.Entity("mag_app.Domain.Entities.Categories.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Products.AllProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<long>("CategoryId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(5);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(6);

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(12);

                    b.Property<long>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(9);

                    b.Property<string>("ProdutName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(10);

                    b.Property<decimal>("PurchasedPrice")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(11);

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(13);

                    b.Property<long?>("StoreId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(3);

                    b.Property<string>("StoreName")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(4);

                    b.Property<long?>("SubCategoryId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(7);

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(8);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("AllProducts");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Products.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .HasColumnType("TEXT");

                    b.Property<long>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProdutName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PurchasedPrice")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<long>("SubCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Products.ReturnProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(6);

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(8);

                    b.Property<decimal>("ReturnedPrice")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(7);

                    b.Property<long>("SaleGlobalId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(4);

                    b.Property<string>("SgName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(5);

                    b.Property<string>("SubCategory")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.HasKey("Id");

                    b.HasIndex("SaleGlobalId");

                    b.ToTable("ReturnProducts");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.Cash", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<string>("CashName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.Property<long>("StoreId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Cashes");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.SaleDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<decimal?>("CardAmount")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(7);

                    b.Property<decimal?>("CashAmount")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(6);

                    b.Property<long>("CashId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(3);

                    b.Property<string>("CashName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(4);

                    b.Property<string>("CheckNumber")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<decimal?>("DiscountPrice")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(10);

                    b.Property<string>("PaymentType")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(5);

                    b.Property<long>("StoreId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(12);

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(13);

                    b.Property<decimal>("TotalSalePrice")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(8);

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(11);

                    b.Property<decimal>("change")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(9);

                    b.HasKey("Id");

                    b.HasIndex("CashId");

                    b.HasIndex("PaymentType");

                    b.HasIndex("StoreId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.SaleGlobal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(1);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.Property<decimal?>("DiscountPrice")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(10);

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(9);

                    b.Property<long>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(5);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(6);

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(8);

                    b.Property<long>("SaleId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(7);

                    b.Property<string>("SubCategory")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(4);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleGlobal");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.Store", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.TabController", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TabName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tabs");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.TabProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(0);

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(2);

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(8);

                    b.Property<long>("ProductId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(4);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(5);

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT")
                        .HasColumnOrder(9);

                    b.Property<string>("Subcategory")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(3);

                    b.Property<long>("TabControllerId")
                        .HasColumnType("INTEGER")
                        .HasColumnOrder(6);

                    b.Property<string>("TabControllerName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnOrder(7);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TabControllerId");

                    b.ToTable("Tabproducts");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Products.AllProduct", b =>
                {
                    b.HasOne("mag_app.Domain.Entities.Categories.Category", "Category")
                        .WithMany("AllProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mag_app.Domain.Entities.Products.Product", "Product")
                        .WithMany("AllProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mag_app.Domain.Entities.Stores.Store", "Store")
                        .WithMany("AllProducts")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("mag_app.Domain.Entities.SubCategories.SubCategory", "SubCategory")
                        .WithMany("AllProducts")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Category");

                    b.Navigation("Product");

                    b.Navigation("Store");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("mag_app.Domain.Entities.Categories.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mag_app.Domain.Entities.SubCategories.SubCategory", "SubCategory")
                        .WithMany("Products")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Products.ReturnProduct", b =>
                {
                    b.HasOne("mag_app.Domain.Entities.Stores.SaleGlobal", "SaleGlobal")
                        .WithMany("ReturnProducts")
                        .HasForeignKey("SaleGlobalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SaleGlobal");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.Cash", b =>
                {
                    b.HasOne("mag_app.Domain.Entities.Stores.Store", "Store")
                        .WithMany("Cashes")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.SaleDetail", b =>
                {
                    b.HasOne("mag_app.Domain.Entities.Stores.Cash", "Cash")
                        .WithMany("SalesGlobals")
                        .HasForeignKey("CashId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mag_app.Domain.Entities.Stores.Store", "Store")
                        .WithMany("SalesGlobal")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired();

                    b.Navigation("Cash");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.SaleGlobal", b =>
                {
                    b.HasOne("mag_app.Domain.Entities.Products.AllProduct", "AllProduct")
                        .WithMany("SaleDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("mag_app.Domain.Entities.Stores.SaleDetail", "SalesGlobal")
                        .WithMany("SaleDetails")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllProduct");

                    b.Navigation("SalesGlobal");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.TabProduct", b =>
                {
                    b.HasOne("mag_app.Domain.Entities.Products.AllProduct", "AllProduct")
                        .WithMany("TabProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mag_app.Domain.Entities.Stores.TabController", "TabController")
                        .WithMany("TabProducts")
                        .HasForeignKey("TabControllerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllProduct");

                    b.Navigation("TabController");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.HasOne("mag_app.Domain.Entities.Categories.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Categories.Category", b =>
                {
                    b.Navigation("AllProducts");

                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Products.AllProduct", b =>
                {
                    b.Navigation("SaleDetails");

                    b.Navigation("TabProducts");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Products.Product", b =>
                {
                    b.Navigation("AllProducts");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.Cash", b =>
                {
                    b.Navigation("SalesGlobals");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.SaleDetail", b =>
                {
                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.SaleGlobal", b =>
                {
                    b.Navigation("ReturnProducts");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.Store", b =>
                {
                    b.Navigation("AllProducts");

                    b.Navigation("Cashes");

                    b.Navigation("SalesGlobal");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.Stores.TabController", b =>
                {
                    b.Navigation("TabProducts");
                });

            modelBuilder.Entity("mag_app.Domain.Entities.SubCategories.SubCategory", b =>
                {
                    b.Navigation("AllProducts");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
