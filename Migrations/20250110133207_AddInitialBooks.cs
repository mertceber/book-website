using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace client.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Veritabanına kitapları eklemek
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Title", "Description", "Author", "Rate", "DateStart", "DateRead" },
                values: new object[,]
                {
                { 1, "Managing Oneself", "We live in an age of unprecedented opportunity: with ambition, drive, and talent, you can rise to the top of your chosen profession, regardless of where you started out...", "Peter Ducker", 4.9, new DateTime(2019, 01, 20), null },
                { 2, "Büyücü", "Roman türünde bir kitap", "John Fowles", 4.9, new DateTime(2019, 01, 20), null },
                { 3, "1984", "Roman türünde bir kitap", "George Orwell", 4.9, new DateTime(2019, 01, 20), null },
                { 4, "Körlük", "Roman türünde bir kitap", "José Saramago", 4.9, new DateTime(2019, 01, 20), null },
                { 5, "Açlık", "Roman türünde bir kitap", "Knut Hamsun", 4.9, new DateTime(2019, 01, 20), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Veritabanından kitapları kaldırma işlemi
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValues: new object[] { 1, 2, 3, 4, 5 });
        }
    }

}