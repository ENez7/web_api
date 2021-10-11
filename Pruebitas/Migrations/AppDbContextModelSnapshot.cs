﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pruebitas.Data;

namespace Pruebitas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pruebitas.Models.Musica", b =>
                {
                    b.Property<string>("autor")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("letra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mancos")
                        .HasColumnType("int");

                    b.Property<string>("nombreCancion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("autor");

                    b.ToTable("Musica");
                });
#pragma warning restore 612, 618
        }
    }
}
