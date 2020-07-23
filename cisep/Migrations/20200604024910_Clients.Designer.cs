﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cisep.Models;

namespace cisep.Migrations
{
    [DbContext(typeof(cisepDBContext))]
    [Migration("20200604024910_Clients")]
    partial class Clients
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cisep.Models.Carrier", b =>
                {
                    b.Property<string>("international_format")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("carrier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country_prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("line_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("local_format")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("valid")
                        .HasColumnType("bit");

                    b.HasKey("international_format");

                    b.ToTable("Carrier");
                });

            modelBuilder.Entity("cisep.Models.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnName("address")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("city")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Mi")
                        .HasColumnName("mi")
                        .HasColumnType("varchar(1)")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("phone")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnName("state")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Suffix")
                        .HasColumnName("suffix")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnName("username")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnName("zip")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("cisep.Models.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("varchar(2000)")
                        .HasMaxLength(2000)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Photo")
                        .HasColumnName("photo")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<int>("Type_Services")
                        .HasColumnName("type_services")
                        .HasColumnType("int")
                        .IsUnicode(false);

                    b.Property<string>("Url")
                        .HasColumnName("url")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("UrlName")
                        .HasColumnName("urlName")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("services");
                });

            modelBuilder.Entity("cisep.Models.services_detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Services")
                        .HasColumnName("id_services")
                        .HasColumnType("int")
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("ServicesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServicesId");

                    b.ToTable("services_detail");
                });

            modelBuilder.Entity("cisep.Models.services_detail", b =>
                {
                    b.HasOne("cisep.Models.Services", "Services")
                        .WithMany("Services_Details")
                        .HasForeignKey("ServicesId");
                });
#pragma warning restore 612, 618
        }
    }
}
