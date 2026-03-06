using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class CreateRegiao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("596df90c-e617-45cb-be33-826801519e46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("784647e2-5430-459e-898b-4c915ee4b412"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7d73f17e-90d6-4230-a391-31520365ca67"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"));

            migrationBuilder.CreateTable(
                name: "Regiao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regiao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegiaoCidade",
                columns: table => new
                {
                    CidadeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RegiaoId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegiaoCidade", x => new { x.CidadeId, x.RegiaoId });
                    table.ForeignKey(
                        name: "FK_RegiaoCidade_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegiaoCidade_Regiao_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regiao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6df75419-ef0c-4e77-8b38-cb367f9f5549"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("576e0d1d-dabb-4891-858c-eb6a302fd8db"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a01e5f57-1854-451c-9a7e-522fcfce8756"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fc7bc635-d772-40cc-9fdc-30de430fa3b4"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("127bff0a-5484-495f-89fe-9d96d8c97e7c"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("40428408-104d-4788-acf7-dbe2cf8b8296"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1fb1c631-539c-4fb5-a708-98f902b22312"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7f5adeba-1ccf-45ce-9347-05b33e7544dd"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a264309d-41dd-4158-b865-fe2a208d0c13"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("737947f7-2484-49aa-82c1-070c450d602c"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3dc51a27-9d4d-4dda-8d71-20becf2dff6e"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2a06e918-e4c8-432f-874b-64fcfbb9b7b9"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("8bb0cec0-bf90-47bd-b92a-a4416632df97"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("de598fd5-c5bd-4b0d-bdde-d9da3748b1e0"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("94053ba8-e783-4c5c-84e3-6e3196fb94b3"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0e83e66a-b1fb-4e51-8e90-6d915cd49238"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("93fc5540-38a7-4fe7-8012-454961a09533"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("73c80c7e-fb99-4942-b679-a7a45812ac33"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c08bd2bf-3ead-4be9-a248-61b3b582afb6"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e515d471-cfb8-4dd0-b62e-8f400308990b"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5b5198bf-9c50-492b-8f2d-c5093b3151a2"), "Fortaleza", "CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1bab279a-87b8-433c-af2a-b2a1d2675965"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("170cd43b-4725-42f6-acba-49b79216576d"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("aee2d9d2-33d1-48ff-99f8-87bcd36ffb49"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a767aa11-6646-4851-9ca1-09de34d3cdf6"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("cfa0d81d-cabc-4fdd-a489-8a1578e58654"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e174a179-423f-444d-ad0c-09eda05550fc"), "Palmas", "TO" });

            migrationBuilder.CreateIndex(
                name: "IX_RegiaoCidade_RegiaoId",
                table: "RegiaoCidade",
                column: "RegiaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegiaoCidade");

            migrationBuilder.DropTable(
                name: "Regiao");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0e83e66a-b1fb-4e51-8e90-6d915cd49238"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("127bff0a-5484-495f-89fe-9d96d8c97e7c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("170cd43b-4725-42f6-acba-49b79216576d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1bab279a-87b8-433c-af2a-b2a1d2675965"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1fb1c631-539c-4fb5-a708-98f902b22312"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2a06e918-e4c8-432f-874b-64fcfbb9b7b9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("3dc51a27-9d4d-4dda-8d71-20becf2dff6e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("40428408-104d-4788-acf7-dbe2cf8b8296"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("576e0d1d-dabb-4891-858c-eb6a302fd8db"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5b5198bf-9c50-492b-8f2d-c5093b3151a2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6df75419-ef0c-4e77-8b38-cb367f9f5549"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("737947f7-2484-49aa-82c1-070c450d602c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("73c80c7e-fb99-4942-b679-a7a45812ac33"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7f5adeba-1ccf-45ce-9347-05b33e7544dd"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8bb0cec0-bf90-47bd-b92a-a4416632df97"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("93fc5540-38a7-4fe7-8012-454961a09533"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("94053ba8-e783-4c5c-84e3-6e3196fb94b3"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a01e5f57-1854-451c-9a7e-522fcfce8756"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a264309d-41dd-4158-b865-fe2a208d0c13"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a767aa11-6646-4851-9ca1-09de34d3cdf6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("aee2d9d2-33d1-48ff-99f8-87bcd36ffb49"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c08bd2bf-3ead-4be9-a248-61b3b582afb6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("cfa0d81d-cabc-4fdd-a489-8a1578e58654"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("de598fd5-c5bd-4b0d-bdde-d9da3748b1e0"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e174a179-423f-444d-ad0c-09eda05550fc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e515d471-cfb8-4dd0-b62e-8f400308990b"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fc7bc635-d772-40cc-9fdc-30de430fa3b4"));

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("afc12ff5-eacd-420a-835a-69e9b3b7821c"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c215fc2e-bcda-4404-8efb-4b23c4433c5b"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a71ac957-1859-49b7-aa65-cc9327f4a3ce"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c04bb270-65a7-4577-bd4c-631fa931d0e2"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0a8248d1-3b62-4fb7-afc8-955b1c8ebc61"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec209ffa-37ea-4587-8bc6-8afe7cd00042"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f8e6890f-e0d0-46ec-8f34-292de4b1f83b"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6756d8f6-3f78-4886-91dd-e4753f9e72bc"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0a8e109c-ee00-40d6-9a01-040618746f2f"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("653fcdce-73b1-47ac-9e98-a5380bec8788"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("dc5ff91b-68d1-4759-9dba-4ade4bd4740d"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("eff2ddee-6df9-4d52-80b7-1e4b1164e343"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("7d73f17e-90d6-4230-a391-31520365ca67"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e7d03670-5d06-40dd-a4d8-41c4fe49a994"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("72b8cfd2-617d-435e-8f79-6e6e46aac155"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("588c12b7-703c-4944-b5ba-0fbed191eb02"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("18e191f0-eef9-4451-bea1-de5f78d125f8"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bb824c5c-a427-4a95-a7b4-f8183f3f8e94"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("439a8192-2f0f-43a7-8a2c-ee9bbbd6c4d3"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("46698f17-4273-4e5c-a56d-dda97d426f26"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e3dcbced-4326-4007-94df-c33f8c77a204"), "Fortaleza", "CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("784647e2-5430-459e-898b-4c915ee4b412"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("596df90c-e617-45cb-be33-826801519e46"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec8390ca-f9a5-4a9e-9654-9405ccbabc7c"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a3fc3b39-3c3c-4a58-8c50-fdd19209777f"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4b4077ab-47f7-44b6-bf44-56f03ca18532"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6ab3cbd8-bcdf-4287-bee3-5885fb656d08"), "Palmas", "TO" });
        }
    }
}
