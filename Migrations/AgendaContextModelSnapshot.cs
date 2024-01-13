﻿// <auto-generated />
using AgendaApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgendaApi.Migrations
{
    [DbContext(typeof(AgendaContext))]
    partial class AgendaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("AgendaApi.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Company")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Company = "PwC",
                            Email = "jpreze@pwc.com",
                            LastName = "Perez",
                            Name = "Jaimito",
                            Number = "341457896",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Company = "Austral",
                            Email = "pramirez@austral.com",
                            LastName = "Ramirez",
                            Name = "Pepe",
                            Number = "34156978",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Company = "google",
                            Email = "mpaez@google.com",
                            LastName = "paez",
                            Name = "Maria",
                            Number = "341457896",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("AgendaApi.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<int>("State")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "karenbailapiola@gmail.com",
                            FirstName = "Karen",
                            LastName = "Lasot",
                            Password = "Pa$$w0rd",
                            Role = 0,
                            State = 0,
                            UserName = "karenbailapiola"
                        },
                        new
                        {
                            Id = 2,
                            Email = "elluismidetotoras@gmail.com",
                            FirstName = "Luis Gonzalez",
                            LastName = "Gonzales",
                            Password = "lamismadesiempre",
                            Role = 1,
                            State = 0,
                            UserName = "luisGonza"
                        });
                });

            modelBuilder.Entity("AgendaApi.Entities.Contact", b =>
                {
                    b.HasOne("AgendaApi.Entities.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AgendaApi.Entities.User", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
