﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeddProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@$"insert into Products(Name,Description,Price,Stock,Image,CategoryId)
                                    Values('Caderno espiral', 'Caderno espiral 100 folhas', 7.45, 50, 'caderno1.jpg', 1)");

            migrationBuilder.Sql(@$"insert into Products(Name,Description,Price,Stock,Image,CategoryId)
                                    Values('Estojo escolar', 'Estojo escolar cinza', 5.65, 70, 'estojo1.jpg', 1)");

            migrationBuilder.Sql(@$"insert into Products(Name,Description,Price,Stock,Image,CategoryId)
                                    Values('Borracha escolar', 'Borracha branca pequena', 3.25, 80, 'borracha1.jpg', 1)");

            migrationBuilder.Sql(@$"insert into Products(Name,Description,Price,Stock,Image,CategoryId)
                                    Values('Calculadora escolar', 'Calculadora simples', 15.39, 20, 'calculadora1.jpg', 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Products");
        }
    }
}
