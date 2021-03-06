﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Moto.Api.Entities;

namespace Moto.Api.Migrations
{
    [DbContext(typeof(MotocyklContext))]
    [Migration("20170711152927_Motocykle_11072017")]
    partial class Motocykle_11072017
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Moto.Api.Entities.Motocykl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Chlodzenie");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("Masa");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("PojemnoscSkokowa");

                    b.Property<double>("PojemnoscZbiornikaPaliwa");

                    b.Property<int>("PredkoscMaksymalna");

                    b.Property<string>("Typ")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Motocykle");
                });
        }
    }
}
