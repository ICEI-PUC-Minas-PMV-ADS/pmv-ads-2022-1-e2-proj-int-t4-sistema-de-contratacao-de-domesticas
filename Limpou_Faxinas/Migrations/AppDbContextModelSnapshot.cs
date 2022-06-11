﻿// <auto-generated />
using Limpou_Faxinas.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Limpou_Faxinas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Limpou_Faxinas.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServicoId"), 1L, 1);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.Property<string>("tipo_de_servico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServicoId");

                    b.ToTable("serviços");
                });

            modelBuilder.Entity("Limpou_Faxinas.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"), 1L, 1);

                    b.Property<int>("Avaliacao")
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.HasIndex("ServicoId");

                    b.ToTable("Usuários");
                });

            modelBuilder.Entity("Limpou_Faxinas.Models.Usuario", b =>
                {
                    b.HasOne("Limpou_Faxinas.Models.Servico", "Servico")
                        .WithMany("Usuarios")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("Limpou_Faxinas.Models.Servico", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
