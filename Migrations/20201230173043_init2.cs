﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool.WebAPI.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisciplinaId",
                table: "Disciplinas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "SobreNome", "Telefone" },
                values: new object[] { 1, "Marta", "Kent", "33225555" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "SobreNome", "Telefone" },
                values: new object[] { 2, "Paula", "Isabela", "3354288" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "SobreNome", "Telefone" },
                values: new object[] { 3, "Laura", "Antonia", "55668899" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "SobreNome", "Telefone" },
                values: new object[] { 4, "Luiza", "Maria", "6565659" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "SobreNome", "Telefone" },
                values: new object[] { 5, "Lucas", "Machado", "565685415" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "SobreNome", "Telefone" },
                values: new object[] { 6, "Pedro", "Alvares", "456454545" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "Nome", "SobreNome", "Telefone" },
                values: new object[] { 7, "Paulo", "José", "9874512" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Lauro" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Roberto" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Ronaldo" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "Rodrigo" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 5, "Alexandre" });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 1, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 7, 5, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 7, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 7, 3, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 7, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 7, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 6, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 6, 3, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 6, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 6, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 5, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 5, 5, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 4, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 4, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 3, 3, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 3, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 3, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 2, 5, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 2, 2, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 2, 1, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 1, 5, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 1, 4, null });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "AlunoDisciplinaId", "DisciplinaId" },
                values: new object[] { 4, 5, null });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "DisciplinaId", "Nome", "ProfessorId" },
                values: new object[] { 4, 0, "Inglês", 4 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "DisciplinaId", "Nome", "ProfessorId" },
                values: new object[] { 1, 0, "Matemática", 1 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "DisciplinaId", "Nome", "ProfessorId" },
                values: new object[] { 2, 0, "Física", 2 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "DisciplinaId", "Nome", "ProfessorId" },
                values: new object[] { 3, 0, "Português", 3 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "DisciplinaId", "Nome", "ProfessorId" },
                values: new object[] { 5, 0, "Programação", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 7, 4 });

            migrationBuilder.DeleteData(
                table: "AlunosDisciplinas",
                keyColumns: new[] { "AlunoId", "AlunoDisciplinaId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Disciplinas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Alunos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Professores",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "DisciplinaId",
                table: "Disciplinas");
        }
    }
}
