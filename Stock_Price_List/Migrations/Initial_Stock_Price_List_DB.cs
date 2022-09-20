using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;
namespace Stock_Price_List.Migrations
{
    public partial class Initial_Stock_Price_List_DB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Stock_Price_Details",
              columns: table => new
              {
                  Stock_Price_ListID = table.Column<int>(type: "int", nullable: false)
                 .Annotation("SqlServer:Identity", "1, 1"),
                  Company_Code = table.Column<int>(type: "int", nullable: false),
                  Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  Stock_Price = table.Column<int>(type: "int", nullable: false),
                  Updated_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                  Updated_By = table.Column<string>(type: "nvarchar(max)", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Stock_Price_Details", x => x.Stock_Price_ListID);
              });
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
              name: "Stock_Price_Details");
        }

    }
}
