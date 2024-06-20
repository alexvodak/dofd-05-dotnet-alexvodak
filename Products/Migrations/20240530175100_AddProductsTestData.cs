using System.Reflection;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Migrations
{
    /// <inheritdoc />
    public partial class AddProductsTestData : Migration
    {
        private const string migrationFileName = @"Products.Migrations.Scripts.20240530175100-AddProductsTestData.sql";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            using (Stream stream = Assembly.GetAssembly(typeof(AddProductsTestData)).GetManifestResourceStream(migrationFileName))
            using (StreamReader reader = new StreamReader(stream))
            {
                var sql = reader.ReadToEnd();
                if (!string.IsNullOrEmpty(sql))
                {
                    migrationBuilder.Sql(sql);
                }
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
