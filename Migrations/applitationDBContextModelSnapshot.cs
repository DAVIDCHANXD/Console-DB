﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using david.Funciones;

#nullable disable

namespace david.Migrations
{
    [DbContext(typeof(applitationDBContext))]
    partial class applitationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("david.Entidades.Ciudad", b =>
                {
                    b.Property<int>("Pkciudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Pkciudad");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("david.Entidades.Persona", b =>
                {
                    b.Property<int>("Pkpersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("Fkciudad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Pkpersona");

                    b.HasIndex("Fkciudad");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("david.Entidades.Persona", b =>
                {
                    b.HasOne("david.Entidades.Ciudad", "Ciudades")
                        .WithMany()
                        .HasForeignKey("Fkciudad")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudades");
                });
#pragma warning restore 612, 618
        }
    }
}
