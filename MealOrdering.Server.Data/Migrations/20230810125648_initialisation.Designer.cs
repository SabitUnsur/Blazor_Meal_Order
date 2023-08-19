﻿// <auto-generated />
using System;
using MealOrdering.Server.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MealOrdering.Server.Data.Migrations
{
    [DbContext(typeof(MealOrderingDbContext))]
    [Migration("20230810125648_initialisation")]
    partial class initialisation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MealOrdering.Server.Data.Models.OrderItems", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("public.uuid_generate_v4()");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("createdate")
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("CreatedUserId")
                        .HasColumnName("created_user_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("character varying")
                        .HasMaxLength(1000);

                    b.Property<Guid>("OrderId")
                        .HasColumnName("order_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id")
                        .HasName("pk_orderItem_id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("OrderId");

                    b.ToTable("order_items","public");
                });

            modelBuilder.Entity("MealOrdering.Server.Data.Models.Orders", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("public.uuid_generate_v4()");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("createdate")
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("CreatedUserId")
                        .HasColumnName("created_user_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("character varying")
                        .HasMaxLength(1000);

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnName("expire_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying")
                        .HasMaxLength(100);

                    b.Property<Guid>("SupplierId")
                        .HasColumnName("supplier_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id")
                        .HasName("pk_order_id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("SupplierId");

                    b.ToTable("orders","public");
                });

            modelBuilder.Entity("MealOrdering.Server.Data.Models.Suppliers", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("public.uuid_generate_v4()");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("createdate")
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<bool>("IsActive")
                        .HasColumnName("isactive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("character varying")
                        .HasMaxLength(100);

                    b.Property<string>("WebURL")
                        .HasColumnName("web_url")
                        .HasColumnType("character varying")
                        .HasMaxLength(500);

                    b.HasKey("Id")
                        .HasName("pk_supplier_id");

                    b.ToTable("suppliers","public");
                });

            modelBuilder.Entity("MealOrdering.Server.Data.Models.Users", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid")
                        .HasDefaultValueSql("UUID_GENERATE_V4()");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("create_date")
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("NOW()");

                    b.Property<string>("EMailAddress")
                        .HasColumnName("email_address")
                        .HasColumnType("character varying")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name")
                        .HasColumnType("character varying")
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive")
                        .HasColumnName("isactive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name")
                        .HasColumnType("character varying")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("character varying")
                        .HasMaxLength(250);

                    b.HasKey("Id")
                        .HasName("pk_user_id");

                    b.ToTable("user","public");
                });

            modelBuilder.Entity("MealOrdering.Server.Data.Models.OrderItems", b =>
                {
                    b.HasOne("MealOrdering.Server.Data.Models.Users", "CreatedUser")
                        .WithMany("CreatedOrderItems")
                        .HasForeignKey("CreatedUserId")
                        .HasConstraintName("fk_orderitems_user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MealOrdering.Server.Data.Models.Orders", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("fk_orderitems_order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MealOrdering.Server.Data.Models.Orders", b =>
                {
                    b.HasOne("MealOrdering.Server.Data.Models.Users", "CreatedUser")
                        .WithMany("Orders")
                        .HasForeignKey("CreatedUserId")
                        .HasConstraintName("fk_user_order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MealOrdering.Server.Data.Models.Suppliers", "Supplier")
                        .WithMany("Orders")
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("fk_supplier_order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
