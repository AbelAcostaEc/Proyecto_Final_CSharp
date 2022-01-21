using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModeloDB.Migrations
{
    public partial class DbIncial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Capacitaciones",
                columns: table => new
                {
                    CapacitacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tema = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Capacitaciones", x => x.CapacitacionId);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cedula = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadoId);
                });

            migrationBuilder.CreateTable(
                name: "Biometricos",
                columns: table => new
                {
                    BiometricoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Entrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biometricos", x => x.BiometricoId);
                    table.ForeignKey(
                        name: "FK_Biometricos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CapacitacionAsistencias",
                columns: table => new
                {
                    CapacitacionId = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapacitacionAsistencias", x => new { x.CapacitacionId, x.EmpleadoId });
                    table.ForeignKey(
                        name: "FK_CapacitacionAsistencias_Capacitaciones_CapacitacionId",
                        column: x => x.CapacitacionId,
                        principalTable: "Capacitaciones",
                        principalColumn: "CapacitacionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CapacitacionAsistencias_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Evaluaciones",
                columns: table => new
                {
                    EvaluacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evaluaciones", x => x.EvaluacionId);
                    table.ForeignKey(
                        name: "FK_Evaluaciones_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Implementos",
                columns: table => new
                {
                    ImplementoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Implementos", x => x.ImplementoId);
                    table.ForeignKey(
                        name: "FK_Implementos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    PermisoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.PermisoId);
                    table.ForeignKey(
                        name: "FK_Permisos_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biometricos_EmpleadoId",
                table: "Biometricos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CapacitacionAsistencias_EmpleadoId",
                table: "CapacitacionAsistencias",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Evaluaciones_EmpleadoId",
                table: "Evaluaciones",
                column: "EmpleadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Implementos_EmpleadoId",
                table: "Implementos",
                column: "EmpleadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permisos_EmpleadoId",
                table: "Permisos",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EmpleadoId",
                table: "Ventas",
                column: "EmpleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biometricos");

            migrationBuilder.DropTable(
                name: "CapacitacionAsistencias");

            migrationBuilder.DropTable(
                name: "Evaluaciones");

            migrationBuilder.DropTable(
                name: "Implementos");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Capacitaciones");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
