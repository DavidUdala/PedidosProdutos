﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PedidosProdutos.Infra.Contextos;

#nullable disable

namespace PedidosProdutos.Infra.Migrations
{
    [DbContext(typeof(PedidosProdutosContexto))]
    partial class PedidosProdutosContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PedidosProdutos.Dominio.Entidades.ItensPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPedido");

                    b.HasIndex("IdProduto");

                    b.ToTable("ItensPedido");
                });

            modelBuilder.Entity("PedidosProdutos.Dominio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime");

                    b.Property<string>("EmailCliente")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("NomeCliente")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("PedidosProdutos.Dominio.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("PedidosProdutos.Dominio.Entidades.ItensPedido", b =>
                {
                    b.HasOne("PedidosProdutos.Dominio.Entidades.Pedido", "Pedido")
                        .WithMany("ItensPedidos")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PedidosProdutos.Dominio.Entidades.Produto", "Produto")
                        .WithMany("ItensPedidos")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("PedidosProdutos.Dominio.Entidades.Pedido", b =>
                {
                    b.Navigation("ItensPedidos");
                });

            modelBuilder.Entity("PedidosProdutos.Dominio.Entidades.Produto", b =>
                {
                    b.Navigation("ItensPedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
