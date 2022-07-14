﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Data;

namespace API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220320155256_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Ativo.AtivoDAO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassificacaoAlvoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClassificacaoAtivoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Cotacao")
                        .HasColumnType("real");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassificacaoAtivoId");

                    b.ToTable("Ativo");
                });

            modelBuilder.Entity("Domain.Carteira.CarteiraDAO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Carteira");
                });

            modelBuilder.Entity("Domain.CarteiraAtivo.CarteiraAtivoDAO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AtivoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CarteiraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AtivoId");

                    b.HasIndex("CarteiraId");

                    b.ToTable("CarteiraAtivo");
                });

            modelBuilder.Entity("Domain.ClassificacaoAtivo.ClassificacaoAtivoDAO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClassificacaoAtivo");
                });

            modelBuilder.Entity("Domain.User.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Domain.Ativo.AtivoDAO", b =>
                {
                    b.HasOne("Domain.ClassificacaoAtivo.ClassificacaoAtivoDAO", "ClassificacaoAtivo")
                        .WithMany("ListaAtivo")
                        .HasForeignKey("ClassificacaoAtivoId");

                    b.Navigation("ClassificacaoAtivo");
                });

            modelBuilder.Entity("Domain.Carteira.CarteiraDAO", b =>
                {
                    b.HasOne("Domain.User.Usuario", "Usuario")
                        .WithMany("ListaCarteira")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Domain.CarteiraAtivo.CarteiraAtivoDAO", b =>
                {
                    b.HasOne("Domain.Ativo.AtivoDAO", "Ativo")
                        .WithMany()
                        .HasForeignKey("AtivoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Carteira.CarteiraDAO", "Carteira")
                        .WithMany("ListaAtivos")
                        .HasForeignKey("CarteiraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ativo");

                    b.Navigation("Carteira");
                });

            modelBuilder.Entity("Domain.Carteira.CarteiraDAO", b =>
                {
                    b.Navigation("ListaAtivos");
                });

            modelBuilder.Entity("Domain.ClassificacaoAtivo.ClassificacaoAtivoDAO", b =>
                {
                    b.Navigation("ListaAtivo");
                });

            modelBuilder.Entity("Domain.User.Usuario", b =>
                {
                    b.Navigation("ListaCarteira");
                });
#pragma warning restore 612, 618
        }
    }
}