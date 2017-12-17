using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApplication1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttFanName = table.Column<string>(nullable: true),
                    AttFanType = table.Column<int>(nullable: false),
                    AttFanValue = table.Column<bool>(nullable: false),
                    RatingName = table.Column<string>(nullable: true),
                    RatingType = table.Column<string>(nullable: true),
                    RatingValue = table.Column<float>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    price = table.Column<float>(nullable: false),
                    sku = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
