using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CopaHAS.Migrations
{
    /// <inheritdoc />
    public partial class Solucao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_JOGADORES",
                table: "TB_JOGADORES");

            migrationBuilder.RenameTable(
                name: "TB_JOGADORES",
                newName: "TBL_JOGADORES");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_ESTADIOS",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "TB_ESTADIOS",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoId",
                table: "TBL_JOGADORES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Posicao",
                table: "TBL_JOGADORES",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TBL_JOGADORES",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TBL_JOGADORES",
                table: "TBL_JOGADORES",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TB_JOGOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_JOGOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_JOGOS_TB_ESTADIOS_EstadioId",
                        column: x => x.EstadioId,
                        principalTable: "TB_ESTADIOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_SELECOES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_SELECOES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_JOGOS_SELECOES",
                columns: table => new
                {
                    JogoId = table.Column<int>(type: "int", nullable: false),
                    SelecaoId = table.Column<int>(type: "int", nullable: false),
                    Gols = table.Column<int>(type: "int", nullable: false),
                    GolsProrrogacao = table.Column<int>(type: "int", nullable: false),
                    GolsDecisaoPenalti = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_JOGOS_SELECOES", x => new { x.JogoId, x.SelecaoId });
                    table.ForeignKey(
                        name: "FK_TB_JOGOS_SELECOES_TBL_SELECOES_SelecaoId",
                        column: x => x.SelecaoId,
                        principalTable: "TBL_SELECOES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_JOGOS_SELECOES_TB_JOGOS_JogoId",
                        column: x => x.JogoId,
                        principalTable: "TB_JOGOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_TECNICOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SelecaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TECNICOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_TECNICOS_TBL_SELECOES_SelecaoId",
                        column: x => x.SelecaoId,
                        principalTable: "TBL_SELECOES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 1,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 2,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 3,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 4,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 5,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 6,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 7,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 8,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 9,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 10,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 11,
                column: "SelecaoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TBL_JOGADORES",
                keyColumn: "Id",
                keyValue: 12,
                column: "SelecaoId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_JOGADORES_SelecaoId",
                table: "TBL_JOGADORES",
                column: "SelecaoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_JOGOS_EstadioId",
                table: "TB_JOGOS",
                column: "EstadioId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_JOGOS_SELECOES_SelecaoId",
                table: "TB_JOGOS_SELECOES",
                column: "SelecaoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TECNICOS_SelecaoId",
                table: "TB_TECNICOS",
                column: "SelecaoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_JOGADORES_TBL_SELECOES_SelecaoId",
                table: "TBL_JOGADORES",
                column: "SelecaoId",
                principalTable: "TBL_SELECOES",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.Sql(@"-- TABELA SELECAO
-- =========================
CREATE TABLE TB_SELECOES (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
    Pais VARCHAR(100) NOT NULL
);

-- =========================================
-- INSERT DAS SELEÇÕES DA COPA
-- =========================================

INSERT INTO TB_SELECOES (Nome, Pais)
VALUES
('África do Sul', 'África do Sul'),
('Alemanha', 'Alemanha'),
('Argélia', 'Argélia'),
('Argentina', 'Argentina'),
('Arábia Saudita', 'Arábia Saudita'),
('Austrália', 'Austrália'),
('Áustria', 'Áustria'),
('Bélgica', 'Bélgica'),
('Bósnia e Herzegovina', 'Bósnia e Herzegovina'),
('Brasil', 'Brasil'),
('Cabo Verde', 'Cabo Verde'),
('Canadá', 'Canadá'),
('Catar', 'Catar'),
('Colômbia', 'Colômbia'),
('Coreia do Sul', 'Coreia do Sul'),
('Costa do Marfim', 'Costa do Marfim'),
('Croácia', 'Croácia'),
('Curaçao', 'Curaçao'),
('Egito', 'Egito'),
('Equador', 'Equador'),
('Escócia', 'Escócia'),
('Espanha', 'Espanha'),
('Estados Unidos', 'Estados Unidos'),
('França', 'França'),
('Gana', 'Gana'),
('Holanda', 'Holanda'),
('Haiti', 'Haiti'),
('Inglaterra', 'Inglaterra'),
('Irã', 'Irã'),
('Iraque', 'Iraque'),
('Japão', 'Japão'),
('Jordânia', 'Jordânia'),
('Marrocos', 'Marrocos'),
('México', 'México'),
('Noruega', 'Noruega'),
('Nova Zelândia', 'Nova Zelândia'),
('Panamá', 'Panamá'),
('Paraguai', 'Paraguai'),
('Portugal', 'Portugal'),
('República Democrática do Congo', 'República Democrática do Congo'),
('Senegal', 'Senegal'),
('Suécia', 'Suécia'),
('Suíça', 'Suíça'),
('República Tcheca', 'República Tcheca'),
('Tunísia', 'Tunísia'),
('Turquia', 'Turquia'),
('Uruguai', 'Uruguai'),
('Uzbequistão', 'Uzbequistão');

GO
-- =========================================
-- ATUALIZAR JOGADORES JÁ EXISTENTES
-- PARA A SELEÇÃO BRASILEIRA
-- =========================================
UPDATE TB_JOGADORES
SET SelecaoId = (
    SELECT Id
    FROM TB_SELECOES
    WHERE Nome = 'Brasil'
);


go
-- =========================
-- TABELA TECNICO (1:1)
-- =========================
CREATE TABLE TB_TECNICOS (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
    SelecaoId INT UNIQUE, 
    CONSTRAINT FK_TB_TECNICOS_TB_SELECOES 
        FOREIGN KEY (SelecaoId) REFERENCES TB_SELECOES(Id)
);

-- =========================
-- UPDATE TABELA JOGADOR (1:N)
-- =========================
ALTER TABLE TB_JOGADORES 
    ADD CONSTRAINT FK_TB_JOGADORES_TB_SELECOES 
        FOREIGN KEY (SelecaoId) REFERENCES TB_SELECOES(Id)


-- =========================
-- TABELA JOGO
-- =========================
CREATE TABLE TB_JOGOS (
    Id INT PRIMARY KEY IDENTITY(1,1),
    DataHora DATETIME NOT NULL,
    EstadioId INT NOT NULL,
    CONSTRAINT FK_TB_JOGOS_TB_ESTADIOS
        FOREIGN KEY (Id) REFERENCES TB_ESTADIOS(Id)
);

-- =========================
-- TABELA N:N JOGO-SELECAO
-- =========================
CREATE TABLE TB_JOGOS_SELECOES (
    JogoId INT NOT NULL,
    SelecaoId INT NOT NULL,
    Gols INT DEFAULT 0,
    GolsDecisaoPenaltis INT DEFAULT 0,
    PRIMARY KEY (JogoId, SelecaoId),
    CONSTRAINT FK_TB_JOGOS_SELECOES_TB_JOGOS 
        FOREIGN KEY (JogoId) REFERENCES TB_JOGOS(Id),
    CONSTRAINT FK_TB_JOGOS_SELECOES_TB_SELECOES 
        FOREIGN KEY (SelecaoId) REFERENCES TB_SELECOES(Id)
);


");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_JOGADORES_TBL_SELECOES_SelecaoId",
                table: "TBL_JOGADORES");

            migrationBuilder.DropTable(
                name: "TB_JOGOS_SELECOES");

            migrationBuilder.DropTable(
                name: "TB_TECNICOS");

            migrationBuilder.DropTable(
                name: "TB_JOGOS");

            migrationBuilder.DropTable(
                name: "TBL_SELECOES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TBL_JOGADORES",
                table: "TBL_JOGADORES");

            migrationBuilder.DropIndex(
                name: "IX_TBL_JOGADORES_SelecaoId",
                table: "TBL_JOGADORES");

            migrationBuilder.RenameTable(
                name: "TBL_JOGADORES",
                newName: "TB_JOGADORES");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_ESTADIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "TB_ESTADIOS",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SelecaoId",
                table: "TB_JOGADORES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Posicao",
                table: "TB_JOGADORES",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "TB_JOGADORES",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_JOGADORES",
                table: "TB_JOGADORES",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 1,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 2,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 3,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 4,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 5,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 6,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 7,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 8,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 9,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 10,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 11,
                column: "SelecaoId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_JOGADORES",
                keyColumn: "Id",
                keyValue: 12,
                column: "SelecaoId",
                value: 0);
        }
    }
}
