using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class CreateRefreshToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Token = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    Username = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExpiraEm = table.Column<DateTime>(type: "TEXT", nullable: false),
                    RevogadoEm = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("8449c8cc-742e-47d8-8097-4ace1eb69ddb"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5881d00f-43c4-46ca-9c7c-c46c689149db"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2626969a-49e5-46a7-909b-6c9b0225acf1"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5a27a894-ee82-4243-80c1-1118204f5910"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b609dbc8-f4c2-4f0b-98e0-5b00992a7c77"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2f568ed4-fbb6-4a24-84d8-eece0f9efcdd"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("42b897b7-1346-48f1-95f8-77cdd57e3bc6"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f8384e51-f991-4f9a-b9ad-f442e905e274"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6e896dbc-090f-42d6-89d8-eb8e1e9c1268"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("cc318597-8bbb-4919-8bd6-23cff9ad4cf2"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e3da873e-43a4-46e6-8067-d09630d0edbb"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("13bd12e2-2e68-45dc-9de0-7b8cb0c2b068"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c1eee4b7-7be6-4716-a6ce-24d694b65a9a"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fbd68cb1-77b4-40b5-b0f2-15fb6fcdb4d9"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6e04e361-ea6a-47fc-852a-dce7403e9077"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5a1ab72b-d344-4a10-b839-ff9c64e4ad48"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4793f304-b460-4f52-962f-ece14bb188d2"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c162bc4a-8d9d-4a08-91e0-18e9b3690b22"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("cf0cca1c-a944-41c8-9057-6ce8ca04079a"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f54a6c1c-b4f1-4846-833c-433f99e42c46"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("beb40bf2-da14-485e-aaef-3c0ee00c676d"), "Fortaleza", "CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a5cd4a71-a3b3-46bb-80bd-fd1f82728909"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f2ad37b2-9320-4e1f-8284-e36dfe3b14c1"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e445c720-8635-4318-869f-fa058fad4cbc"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("467de7a6-39f6-4fe1-87fc-47abbd682124"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a17ed0c8-f8c9-45dc-981f-d81ef03423a1"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("234535ca-403a-4092-8b99-f1d0670f8274"), "Palmas", "TO" });

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_Token",
                table: "RefreshToken",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_Username",
                table: "RefreshToken",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("13bd12e2-2e68-45dc-9de0-7b8cb0c2b068"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("234535ca-403a-4092-8b99-f1d0670f8274"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2626969a-49e5-46a7-909b-6c9b0225acf1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("2f568ed4-fbb6-4a24-84d8-eece0f9efcdd"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("42b897b7-1346-48f1-95f8-77cdd57e3bc6"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("467de7a6-39f6-4fe1-87fc-47abbd682124"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4793f304-b460-4f52-962f-ece14bb188d2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5881d00f-43c4-46ca-9c7c-c46c689149db"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5a1ab72b-d344-4a10-b839-ff9c64e4ad48"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5a27a894-ee82-4243-80c1-1118204f5910"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6e04e361-ea6a-47fc-852a-dce7403e9077"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6e896dbc-090f-42d6-89d8-eb8e1e9c1268"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("8449c8cc-742e-47d8-8097-4ace1eb69ddb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a17ed0c8-f8c9-45dc-981f-d81ef03423a1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("a5cd4a71-a3b3-46bb-80bd-fd1f82728909"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b609dbc8-f4c2-4f0b-98e0-5b00992a7c77"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("beb40bf2-da14-485e-aaef-3c0ee00c676d"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c162bc4a-8d9d-4a08-91e0-18e9b3690b22"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c1eee4b7-7be6-4716-a6ce-24d694b65a9a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("cc318597-8bbb-4919-8bd6-23cff9ad4cf2"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("cf0cca1c-a944-41c8-9057-6ce8ca04079a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e3da873e-43a4-46e6-8067-d09630d0edbb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("e445c720-8635-4318-869f-fa058fad4cbc"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f2ad37b2-9320-4e1f-8284-e36dfe3b14c1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f54a6c1c-b4f1-4846-833c-433f99e42c46"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f8384e51-f991-4f9a-b9ad-f442e905e274"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fbd68cb1-77b4-40b5-b0f2-15fb6fcdb4d9"));

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
        }
    }
}
