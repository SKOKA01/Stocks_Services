using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Stock_Price_List.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_Price_List.Migrations
{
    [DbContext(typeof(StockPriceDBContext))]
    partial class StockPriceDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
        .HasAnnotation("Relational:MaxIdentifierLength", 128)
        .HasAnnotation("ProductVersion", "5.0.15")
        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity("Stock_Price_List.Models.Stock_Price_List", b =>
            {
                b.Property<int>("Stock_Price_ListID")
                  .ValueGeneratedOnAdd()
                  .HasColumnType("int")
                  .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
                b.Property<int>("Company_Code")
                  .HasColumnType("int");
                b.Property<string>("Company_Name")
                  .HasColumnType("nvarchar(max)");
                b.Property<int>("Stock_Price")
                  .HasColumnType("int");
                b.Property<string>("Updated_By")
                  .HasColumnType("nvarchar(max)");
                b.Property<DateTime>("Updated_On")
                  .HasColumnType("datetime2");
                b.HasKey("Stock_Price_ListID");
                b.ToTable("Stock_Price_Details");
            });
#pragma warning restore 612, 618
        }
    }


}
