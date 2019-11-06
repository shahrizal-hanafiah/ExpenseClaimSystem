﻿// <auto-generated />
using System;
using Claim.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Claim.Migrations
{
    [DbContext(typeof(ClaimContext))]
    [Migration("20191106002951_AddUserIdInClaimTbl")]
    partial class AddUserIdInClaimTbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Claim.Models.ClaimDetails", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<Guid>("ClaimId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CostCentreCode")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateTransaction")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<decimal>("ExchangeRate")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Glcode")
                        .HasColumnName("GLCode")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("SerialNo")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("ClaimDetails");
                });

            modelBuilder.Entity("Claim.Models.Claims", b =>
                {
                    b.Property<Guid>("ClaimId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountHolderName")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("BankAccount")
                        .IsRequired()
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("BankCode")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("BranchCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ClaimNo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("DateApply")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)")
                        .HasDefaultValueSql("('NEW')")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ClaimId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("Claim.Models.CostCentre", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CostCentreCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CostCentreDescription")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("CostCentreName")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .HasName("IX_CostCentre");

                    b.ToTable("CostCentre");
                });

            modelBuilder.Entity("Claim.Models.GeneralLedgers", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Glcode")
                        .IsRequired()
                        .HasColumnName("GLCode")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Gldescription")
                        .HasColumnName("GLDescription")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Glname")
                        .IsRequired()
                        .HasColumnName("GLName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("GeneralLedgers");
                });

            modelBuilder.Entity("Claim.Models.Taxes", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TaxCode")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("TaxName")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.ToTable("Taxes");
                });

            modelBuilder.Entity("Claim.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("Address2")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("BankAccountName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("BankAccountNo")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("BankCode")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("BranchCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Country")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}