using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoBaloo.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomUtilisateur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailUtilisateur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotPasse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarqueVehicule = table.Column<int>(type: "int", nullable: false),
                    StatutVehicule = table.Column<int>(type: "int", nullable: false),
                    TypeCarbu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrixVehicule = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DescriptionVehicule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateConstruct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OptionVehicule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CouleurVehicule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duree = table.Column<int>(type: "int", nullable: false),
                    MontantReservation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateFin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeReservation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdVehicule = table.Column<int>(type: "int", nullable: false),
                    IdUtilisateur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Utilisateurs_IdUtilisateur",
                        column: x => x.IdUtilisateur,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Vehicules_IdVehicule",
                        column: x => x.IdVehicule,
                        principalTable: "Vehicules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateStock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QteStock = table.Column<int>(type: "int", nullable: false),
                    IdVehicule = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Vehicules_IdVehicule",
                        column: x => x.IdVehicule,
                        principalTable: "Vehicules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paiements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MoyenPaiement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MontantPaiement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePaiement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdReservation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paiements_Reservations_IdReservation",
                        column: x => x.IdReservation,
                        principalTable: "Reservations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paiements_IdReservation",
                table: "Paiements",
                column: "IdReservation");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_IdUtilisateur",
                table: "Reservations",
                column: "IdUtilisateur");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_IdVehicule",
                table: "Reservations",
                column: "IdVehicule");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_IdVehicule",
                table: "Stocks",
                column: "IdVehicule");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paiements");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropTable(
                name: "Vehicules");
        }
    }
}
