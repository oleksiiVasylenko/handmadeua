using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Handmadeua.Data;
using Handmadeua.Core;

namespace Handmadeua.Migrations
{
    [DbContext(typeof(HandmadeContext))]
    [Migration("20170504121110_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Handmadeua.Data.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("NickName");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.JoinedEntities.MaterialProduct", b =>
                {
                    b.Property<int>("MaterialId");

                    b.Property<int>("ProductId");

                    b.HasKey("MaterialId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("MaterialProduct");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.JoinedEntities.ProductAuthor", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("AuthorId");

                    b.HasKey("ProductId", "AuthorId");

                    b.HasIndex("AuthorId");

                    b.ToTable("ProductAuthor");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comments");

                    b.Property<string>("Email");

                    b.Property<string>("Phone");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedAt");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<int>("PhotoId");

                    b.Property<decimal>("Price");

                    b.Property<string>("ShortDescription");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int?>("CityId");

                    b.Property<int?>("CountryId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("PostIndex");

                    b.Property<string>("Salt");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Author", b =>
                {
                    b.HasOne("Handmadeua.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Handmadeua.Data.Models.JoinedEntities.MaterialProduct", b =>
                {
                    b.HasOne("Handmadeua.Data.Models.Material", "Material")
                        .WithMany("MaterialProducts")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Handmadeua.Data.Models.Product", "Product")
                        .WithMany("MaterialProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Handmadeua.Data.Models.JoinedEntities.ProductAuthor", b =>
                {
                    b.HasOne("Handmadeua.Data.Models.Author", "Author")
                        .WithMany("ProductAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Handmadeua.Data.Models.Product", "Product")
                        .WithMany("ProductAuthors")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Order", b =>
                {
                    b.HasOne("Handmadeua.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Photo", b =>
                {
                    b.HasOne("Handmadeua.Data.Models.Product", "Product")
                        .WithMany("Photos")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Handmadeua.Data.Models.Product", b =>
                {
                    b.HasOne("Handmadeua.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Handmadeua.Data.Models.User", b =>
                {
                    b.HasOne("Handmadeua.Data.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Handmadeua.Data.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });
        }
    }
}
