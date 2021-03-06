// <auto-generated />
using CampProj;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CampProj.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211018133041_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CampProj.TablePlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Booked")
                        .HasColumnType("bit");

                    b.Property<string>("BookerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Fullday")
                        .HasColumnType("bit");

                    b.Property<bool>("Halfday")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TablePlaces");
                });
#pragma warning restore 612, 618
        }
    }
}
