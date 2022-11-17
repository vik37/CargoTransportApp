using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CargoTransportApp.Services.CompanyAPI.Migrations
{
    public partial class DbForCompanyInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyRegisterKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyRole = table.Column<int>(type: "int", nullable: false),
                    CraetedOn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShippmentServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Parcel = table.Column<int>(type: "int", nullable: false),
                    MinimumDefaultDimension = table.Column<int>(type: "int", nullable: true),
                    MaximumDefaultDimension = table.Column<int>(type: "int", nullable: true),
                    MinimumDefaultWeight = table.Column<int>(type: "int", nullable: true),
                    MaximumDefaultWeight = table.Column<int>(type: "int", nullable: true),
                    InitialDimensionPrice = table.Column<double>(type: "float", nullable: false),
                    InitialWeightPrice = table.Column<double>(type: "float", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippmentServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippmentServices_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryByDimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceIncrease = table.Column<double>(type: "float", nullable: true),
                    Less = table.Column<int>(type: "int", nullable: true),
                    Bigger = table.Column<int>(type: "int", nullable: true),
                    ShippmentServiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryByDimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryByDimensions_ShippmentServices_ShippmentServiceId",
                        column: x => x.ShippmentServiceId,
                        principalTable: "ShippmentServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryByWeights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PriceIncrease = table.Column<double>(type: "float", nullable: true),
                    Less = table.Column<int>(type: "int", nullable: true),
                    Bigger = table.Column<int>(type: "int", nullable: true),
                    ShippmentServiceId = table.Column<int>(type: "int", nullable: false),
                    ForEvery = table.Column<bool>(type: "bit", nullable: false),
                    ForEveryPrice = table.Column<double>(type: "float", nullable: false),
                    ForEveryKg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryByWeights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryByWeights_ShippmentServices_ShippmentServiceId",
                        column: x => x.ShippmentServiceId,
                        principalTable: "ShippmentServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "City", "CompanyRegisterKey", "CompanyRole", "Country", "CraetedOn", "DeletedOn", "Link", "Name", "PostCode" },
                values: new object[] { 1, "Green Street 12A", "London", "9ffa2d7e-9d46-4a70-a810-f1838aefa876", 0, "United Kingdom", "", "", "foryou.com", "Cargo for you", 3698 });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "City", "CompanyRegisterKey", "CompanyRole", "Country", "CraetedOn", "DeletedOn", "Link", "Name", "PostCode" },
                values: new object[] { 2, "bul. ASNOM 23", "Skopje", "ff3f4d99-4948-41b7-bbbe-2e9912967f77", 1, "Macedonia", "28/02/2016", "", "shipfaster.com.mk", "Ship faster", 1000 });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "City", "CompanyRegisterKey", "CompanyRole", "Country", "CraetedOn", "DeletedOn", "Link", "Name", "PostCode" },
                values: new object[] { 3, "Lascaris Wharf 239A", "La Valleta", "9cb254cb-2c83-41bc-a75b-f73733060946", 1, "Malta", "04/19/2005", "", "https://www.visitmalta.com/en/info/valletta-malta/", "Malta ship", 1118 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "CompanyId", "Email", "Firstname", "Lastname", "WorkPosition" },
                values: new object[] { "d7475312-f64d-42ee-8a1e-96d989a77bae", 1, "adam@gmail.com", "Adam", "Stalone", "Manager" });

            migrationBuilder.InsertData(
                table: "ShippmentServices",
                columns: new[] { "Id", "CompanyId", "InitialDimensionPrice", "InitialWeightPrice", "MaximumDefaultDimension", "MaximumDefaultWeight", "MinimumDefaultDimension", "MinimumDefaultWeight", "Parcel" },
                values: new object[,]
                {
                    { 1, 1, 10.0, 15.0, 2000, 20, null, null, 36 },
                    { 2, 2, 11.99, 16.5, 1700, 30, null, 10, 18 },
                    { 3, 3, 9.5, 16.989999999999998, null, null, 500, 10, 26 }
                });

            migrationBuilder.InsertData(
                table: "DeliveryByDimensions",
                columns: new[] { "Id", "Bigger", "Less", "PriceIncrease", "ShippmentServiceId" },
                values: new object[,]
                {
                    { 1, null, 1000, null, 1 },
                    { 2, 1000, 2000, 10.0, 1 },
                    { 3, null, 1000, null, 2 },
                    { 4, 1000, 1700, 10.0, 2 },
                    { 5, null, 1000, null, 3 },
                    { 6, 1000, 2000, 10.0, 3 },
                    { 7, 2000, 5000, 29.0, 3 }
                });

            migrationBuilder.InsertData(
                table: "DeliveryByWeights",
                columns: new[] { "Id", "Bigger", "ForEvery", "ForEveryKg", "ForEveryPrice", "Less", "PriceIncrease", "ShippmentServiceId" },
                values: new object[,]
                {
                    { 1, null, false, 0, 0.0, 2, null, 1 },
                    { 2, 2, false, 0, 0.0, 15, 3.0, 1 },
                    { 3, 15, false, 0, 0.0, 20, 17.0, 1 },
                    { 4, 10, false, 0, 0.0, 15, null, 2 },
                    { 5, 15, false, 0, 0.0, 25, 20.0, 2 },
                    { 6, 25, true, 1, 0.41699999999999998, null, 3.5, 2 },
                    { 7, 10, false, 0, 0.0, 20, null, 3 },
                    { 8, 20, false, 0, 0.0, 30, 17.0, 3 },
                    { 9, 30, true, 1, 0.40999999999999998, null, 10.0, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryByDimensions_ShippmentServiceId",
                table: "DeliveryByDimensions",
                column: "ShippmentServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryByWeights_ShippmentServiceId",
                table: "DeliveryByWeights",
                column: "ShippmentServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyId",
                table: "Employee",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippmentServices_CompanyId",
                table: "ShippmentServices",
                column: "CompanyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryByDimensions");

            migrationBuilder.DropTable(
                name: "DeliveryByWeights");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "ShippmentServices");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
