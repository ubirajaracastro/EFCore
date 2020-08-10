﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Switch.Infra.Data.Context;

namespace Switch.Infra.Data.Migrations
{
    [DbContext(typeof(SwitchContext))]
    partial class SwitchContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Switch.Domain.Entities.Amigo", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioAmigoId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "UsuarioAmigoId");

                    b.HasIndex("UsuarioAmigoId");

                    b.ToTable("Amigos");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("varchar(600) CHARACTER SET utf8mb4")
                        .HasMaxLength(600);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<string>("UrlFoto")
                        .IsRequired()
                        .HasColumnType("varchar(200) CHARACTER SET utf8mb4")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Identificacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasColumnType("varchar(18) CHARACTER SET utf8mb4")
                        .HasMaxLength(18);

                    b.Property<int>("TipoDocumento")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Identificao");
                });

            modelBuilder.Entity("Switch.Domain.Entities.InstituicaoEnsino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("AnoFormacao")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EstudandoAtualmente")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("InstituicaoEnsino");
                });

            modelBuilder.Entity("Switch.Domain.Entities.LocalTrabalho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataSaida")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("EmpresaAtual")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("LocalTrabalho");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Postagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("varchar(400) CHARACTER SET utf8mb4")
                        .HasMaxLength(400);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("Switch.Domain.Entities.ProcurandoPor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("ProcurandoPor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "NaoEspecificado"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Namoro"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Amizade"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Relacionamento Sério"
                        });
                });

            modelBuilder.Entity("Switch.Domain.Entities.StatusRelacionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("StatusRelacionamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "NaoEspecificado"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Solteiro"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Casado"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Em Relacionamento Sério"
                        });
                });

            modelBuilder.Entity("Switch.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<int?>("ProcurandoPorId")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("SobreNome")
                        .IsRequired()
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<int?>("StatusRelacionamentoId")
                        .HasColumnType("int");

                    b.Property<string>("UrlFoto")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.HasKey("Id");

                    b.HasIndex("ProcurandoPorId");

                    b.HasIndex("StatusRelacionamentoId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Switch.Domain.Entities.UsuarioGrupo", b =>
                {
                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<int>("GrupoId")
                        .HasColumnType("int");

                    b.Property<bool>("Admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.HasKey("UsuarioId", "GrupoId");

                    b.HasIndex("GrupoId");

                    b.ToTable("UsuarioGrupos");
                });

            modelBuilder.Entity("Switch.Domain.Entities.Amigo", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "UsuarioAmigo")
                        .WithMany()
                        .HasForeignKey("UsuarioAmigoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Amigos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Switch.Domain.Entities.Comentario", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Comentarios")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Switch.Domain.Entities.Identificacao", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithOne("Identificacao")
                        .HasForeignKey("Switch.Domain.Entities.Identificacao", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Switch.Domain.Entities.InstituicaoEnsino", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("InstituicoesEnsino")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Switch.Domain.Entities.LocalTrabalho", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("LocaisTrabalho")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Switch.Domain.Entities.Postagem", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Grupo", "Grupo")
                        .WithMany("Postagens")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("Postagens")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Switch.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("Switch.Domain.Entities.ProcurandoPor", "ProcurandoPor")
                        .WithMany()
                        .HasForeignKey("ProcurandoPorId");

                    b.HasOne("Switch.Domain.Entities.StatusRelacionamento", "StatusRelacionamento")
                        .WithMany()
                        .HasForeignKey("StatusRelacionamentoId");
                });

            modelBuilder.Entity("Switch.Domain.Entities.UsuarioGrupo", b =>
                {
                    b.HasOne("Switch.Domain.Entities.Grupo", "Grupo")
                        .WithMany("UsuarioGrupo")
                        .HasForeignKey("GrupoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Switch.Domain.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioGrupos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
