﻿// <auto-generated />
using AdmHelper.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AdmHelper.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20180202233159_UserModelModification")]
    partial class UserModelModification
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdmHelper.API.Models.Jednostka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataModyfikacji");

                    b.Property<bool>("IsMain");

                    b.Property<string>("Nazwa");

                    b.Property<string>("Opis");

                    b.Property<string>("Symbol");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Jednostki");
                });

            modelBuilder.Entity("AdmHelper.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataModyfikacji");

                    b.Property<DateTime>("DataUtworzenia");

                    b.Property<string>("Email");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AdmHelper.API.Models.Jednostka", b =>
                {
                    b.HasOne("AdmHelper.API.Models.User", "User")
                        .WithMany("Jednostki")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
