using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreOwnedEntitiesError.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Foos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FooStatistics_Percentile25En75_Low = table.Column<double>(type: "float", nullable: false),
                    FooStatistics_Percentile25En75_High = table.Column<double>(type: "float", nullable: false),
                    FooStatistics_Percentile10En90_Low = table.Column<double>(type: "float", nullable: false),
                    FooStatistics_Percentile10En90_High = table.Column<double>(type: "float", nullable: false),
                    FooStatistics_Median = table.Column<double>(type: "float", nullable: false),
                    BarStatistics_Percentile25En75_Low = table.Column<double>(type: "float", nullable: false),
                    BarStatistics_Percentile25En75_High = table.Column<double>(type: "float", nullable: false),
                    BarStatistics_Percentile10En90_Low = table.Column<double>(type: "float", nullable: false),
                    BarStatistics_Percentile10En90_High = table.Column<double>(type: "float", nullable: false),
                    BarStatistics_Median = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Foos");
        }
    }
}
