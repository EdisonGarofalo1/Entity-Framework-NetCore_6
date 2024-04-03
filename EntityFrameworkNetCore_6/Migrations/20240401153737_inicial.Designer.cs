﻿// <auto-generated />
using System;
using EntityFrameworkNetCore_6.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkNetCore_6.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240401153737_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Cab_Movimiento", b =>
                {
                    b.Property<int>("cab_mov_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cab_mov_id"), 1L, 1);

                    b.Property<int>("Personaper_id")
                        .HasColumnType("int");

                    b.Property<int>("Tipo_Movimientotip_mov_id")
                        .HasColumnType("int");

                    b.Property<int>("Usuariousu_id")
                        .HasColumnType("int");

                    b.Property<decimal>("cab_mov_base_imponible")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("cab_mov_estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("cab_mov_fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("cab_mov_iva")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("cab_mov_num_doc")
                        .HasColumnType("int");

                    b.Property<decimal>("cab_mov_valor_final")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("cab_movimiento")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("fecha_modificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_registro")
                        .HasColumnType("datetime2");

                    b.Property<int>("per_id")
                        .HasColumnType("int");

                    b.Property<int>("tip_mov_id")
                        .HasColumnType("int");

                    b.Property<int>("usu_id")
                        .HasColumnType("int");

                    b.HasKey("cab_mov_id");

                    b.HasIndex("Personaper_id");

                    b.HasIndex("Tipo_Movimientotip_mov_id");

                    b.HasIndex("Usuariousu_id");

                    b.ToTable("Cab_Movimiento");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Categoria", b =>
                {
                    b.Property<int>("cat_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cat_id"), 1L, 1);

                    b.Property<string>("cat_descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("cat_estado")
                        .HasColumnType("bit");

                    b.HasKey("cat_id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Det_Movimiento", b =>
                {
                    b.Property<int>("det_mov_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("det_mov_id"), 1L, 1);

                    b.Property<int>("Cab_Movimientocab_mov_id")
                        .HasColumnType("int");

                    b.Property<int>("Productopro_id")
                        .HasColumnType("int");

                    b.Property<int>("cab_mov_id")
                        .HasColumnType("int");

                    b.Property<decimal>("det_mov_base_imponible")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("det_mov_cantidad")
                        .HasColumnType("int");

                    b.Property<bool>("det_mov_estado")
                        .HasColumnType("bit");

                    b.Property<decimal>("det_mov_iva")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("det_mov_precio")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("det_mov_total")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("pro_id")
                        .HasColumnType("int");

                    b.HasKey("det_mov_id");

                    b.HasIndex("Cab_Movimientocab_mov_id");

                    b.HasIndex("Productopro_id");

                    b.ToTable("Det_Movimiento");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Persona", b =>
                {
                    b.Property<int>("per_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("per_id"), 1L, 1);

                    b.Property<int>("cp_estado_civil")
                        .HasColumnType("int");

                    b.Property<int>("cp_sexo")
                        .HasColumnType("int");

                    b.Property<string>("per_direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("per_estado")
                        .HasColumnType("bit");

                    b.Property<string>("per_identificacion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("per_nombres")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("per_telefono")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("per_id");

                    b.ToTable("Persona");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Producto", b =>
                {
                    b.Property<int>("pro_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pro_id"), 1L, 1);

                    b.Property<int>("Categoriacat_id")
                        .HasColumnType("int");

                    b.Property<int>("cat_id")
                        .HasColumnType("int");

                    b.Property<string>("pro_codigo")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("pro_descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("pro_estado")
                        .HasColumnType("bit");

                    b.Property<bool>("pro_lleva_iva")
                        .HasColumnType("bit");

                    b.Property<decimal>("pro_precio")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("pro_id");

                    b.HasIndex("Categoriacat_id");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Tipo_Movimiento", b =>
                {
                    b.Property<int>("tip_mov_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tip_mov_id"), 1L, 1);

                    b.Property<string>("tip_mov_descripcion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("tip_mov_estado")
                        .HasColumnType("bit");

                    b.HasKey("tip_mov_id");

                    b.ToTable("Tipo_Movimiento");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Usuario", b =>
                {
                    b.Property<int>("usu_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("usu_id"), 1L, 1);

                    b.Property<string>("usu_apellidos")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("usu_clave")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("usu_direccion")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("usu_email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("usu_estado")
                        .HasColumnType("bit");

                    b.Property<string>("usu_nombres")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("usu_telefono")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("usu_usuario")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("usu_id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Cab_Movimiento", b =>
                {
                    b.HasOne("EntityFrameworkNetCore_6.Models.Entity.Persona", "Persona")
                        .WithMany("Cab_Movimientos")
                        .HasForeignKey("Personaper_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkNetCore_6.Models.Entity.Tipo_Movimiento", "Tipo_Movimiento")
                        .WithMany("Cab_Movimientos")
                        .HasForeignKey("Tipo_Movimientotip_mov_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkNetCore_6.Models.Entity.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Usuariousu_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Tipo_Movimiento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Det_Movimiento", b =>
                {
                    b.HasOne("EntityFrameworkNetCore_6.Models.Entity.Cab_Movimiento", "Cab_Movimiento")
                        .WithMany("Det_Movimientos")
                        .HasForeignKey("Cab_Movimientocab_mov_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkNetCore_6.Models.Entity.Producto", "Producto")
                        .WithMany("Det_Movimientos")
                        .HasForeignKey("Productopro_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cab_Movimiento");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Producto", b =>
                {
                    b.HasOne("EntityFrameworkNetCore_6.Models.Entity.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("Categoriacat_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Cab_Movimiento", b =>
                {
                    b.Navigation("Det_Movimientos");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Persona", b =>
                {
                    b.Navigation("Cab_Movimientos");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Producto", b =>
                {
                    b.Navigation("Det_Movimientos");
                });

            modelBuilder.Entity("EntityFrameworkNetCore_6.Models.Entity.Tipo_Movimiento", b =>
                {
                    b.Navigation("Cab_Movimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
