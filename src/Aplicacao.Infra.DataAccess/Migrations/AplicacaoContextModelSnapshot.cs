﻿// <auto-generated />
using System;
using Aplicacao.Infra.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aplicacao.Infra.DataAccess.Migrations
{
    [DbContext(typeof(AplicacaoContext))]
    partial class AplicacaoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Aplicacao.Domain.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Cadastro")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("dt_cadastro")
                        .HasColumnType("datetime")
                        .HasDefaultValue(new DateTime(2020, 5, 22, 3, 32, 52, 109, DateTimeKind.Local).AddTicks(3449));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("nm_nome")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("OrientacaoSexual")
                        .IsRequired()
                        .HasColumnName("nm_sexo")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id")
                        .HasName("Identificador");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(3159),
                            Nome = "Felipe",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 2,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4186),
                            Nome = "Rafael",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 3,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4206),
                            Nome = "Denise",
                            OrientacaoSexual = "Feminino"
                        },
                        new
                        {
                            Id = 4,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4207),
                            Nome = "Carlos",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 5,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4209),
                            Nome = "Fernando",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 6,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4210),
                            Nome = "Flavia",
                            OrientacaoSexual = "Feminino"
                        },
                        new
                        {
                            Id = 7,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4211),
                            Nome = "Jose",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 8,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4212),
                            Nome = "Manuel",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 9,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4214),
                            Nome = "Carla",
                            OrientacaoSexual = "Feminino"
                        },
                        new
                        {
                            Id = 10,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4216),
                            Nome = "Joao",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 11,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4217),
                            Nome = "Hugo",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 12,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4219),
                            Nome = "Maria",
                            OrientacaoSexual = "Feminino"
                        },
                        new
                        {
                            Id = 13,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4220),
                            Nome = "Luiz",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 14,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4221),
                            Nome = "Marcio",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 15,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4222),
                            Nome = "Amanada",
                            OrientacaoSexual = "Feminino"
                        },
                        new
                        {
                            Id = 16,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4223),
                            Nome = "Vinicius",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 17,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4225),
                            Nome = "Romulo",
                            OrientacaoSexual = "Masculino"
                        },
                        new
                        {
                            Id = 18,
                            Cadastro = new DateTime(2020, 5, 22, 3, 32, 52, 115, DateTimeKind.Local).AddTicks(4226),
                            Nome = "Daniela",
                            OrientacaoSexual = "Feminino"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
