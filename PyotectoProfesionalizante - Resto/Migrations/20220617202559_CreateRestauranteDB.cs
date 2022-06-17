using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PyotectoProfesionalizante___Resto.Migrations
{
    public partial class CreateRestauranteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resto",
                columns: table => new
                {
                    IdResto = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resto", x => x.IdResto);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    IdMesa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidad = table.Column<int>(nullable: false),
                    EstadoM = table.Column<int>(nullable: false),
                    RestauranteIdResto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.IdMesa);
                    table.ForeignKey(
                        name: "FK_Mesas_Resto_RestauranteIdResto",
                        column: x => x.RestauranteIdResto,
                        principalTable: "Resto",
                        principalColumn: "IdResto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroReservas",
                columns: table => new
                {
                    IdReserva = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesasReservadas = table.Column<int>(nullable: false),
                    EstadoR = table.Column<int>(nullable: false),
                    FechaReserva = table.Column<DateTime>(nullable: false),
                    RestauranteIdResto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroReservas", x => x.IdReserva);
                    table.ForeignKey(
                        name: "FK_RegistroReservas_Resto_RestauranteIdResto",
                        column: x => x.RestauranteIdResto,
                        principalTable: "Resto",
                        principalColumn: "IdResto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdComensal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(nullable: true),
                    NroCelular = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    ReservaIdReserva = table.Column<int>(nullable: true),
                    RestauranteIdResto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdComensal);
                    table.ForeignKey(
                        name: "FK_Clientes_RegistroReservas_ReservaIdReserva",
                        column: x => x.ReservaIdReserva,
                        principalTable: "RegistroReservas",
                        principalColumn: "IdReserva",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Resto_RestauranteIdResto",
                        column: x => x.RestauranteIdResto,
                        principalTable: "Resto",
                        principalColumn: "IdResto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ReservaIdReserva",
                table: "Clientes",
                column: "ReservaIdReserva");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RestauranteIdResto",
                table: "Clientes",
                column: "RestauranteIdResto");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_RestauranteIdResto",
                table: "Mesas",
                column: "RestauranteIdResto");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroReservas_RestauranteIdResto",
                table: "RegistroReservas",
                column: "RestauranteIdResto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "RegistroReservas");

            migrationBuilder.DropTable(
                name: "Resto");
        }
    }
}
