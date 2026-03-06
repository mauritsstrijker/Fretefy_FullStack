using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.EntityFramework.Migrations
{
    public partial class CreateRegiaoGeocoding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "Cidade",
                type: "REAL",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "Cidade",
                type: "REAL",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("979cdcaf-fc2a-4dcd-a6fa-069254083514"), null, null, "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("1187e3c1-ed55-4e70-9777-d24b2a67b92e"), null, null, "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("f4f2c24f-094d-474f-be75-9937032d49ed"), null, null, "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("da2d10a0-f623-48c6-b5be-81daa483cd6c"), null, null, "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("5185770a-f27e-4a73-9af3-2406c6c89cbd"), null, null, "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("6f95723d-586a-4061-b322-62f519adc95c"), null, null, "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("c70b0247-57f6-45ea-b76e-709cb0df62f1"), null, null, "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("250f3b8b-a595-45bd-96f7-a33ac7e5b5d9"), null, null, "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("d9273c38-3c22-4a96-a29e-ca9c25b8e733"), null, null, "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("7bef69cc-5c0f-42d8-b047-b7f1c406e033"), null, null, "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("c4e83839-a7d7-4080-bd82-8b483b429a8f"), null, null, "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("b1f6391d-6d00-432d-b542-0a9eabdb3635"), null, null, "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("0ee2b0fd-9a1b-4646-9f2c-51502e11e21e"), null, null, "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("fc04a4cc-37fc-4c45-9e18-e333c2bcdc7a"), null, null, "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("ea8e95d9-474c-4c7f-a8e5-63c1b6f2a2b4"), null, null, "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("cf651ec4-923e-44e0-8908-256498e2fc42"), null, null, "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("5ccf76fa-2138-4695-bd37-30d94161d303"), null, null, "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("52441980-5967-4b5b-9c11-37c540f4da74"), null, null, "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("0facf6cb-5a07-4885-976d-a170e73fd166"), null, null, "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("7d7d37c5-9467-4608-a6f6-6414a7b533cb"), null, null, "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("7879d093-7843-41b0-8b24-b17d6f4a8314"), null, null, "Fortaleza", "CE" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("85a94850-8e63-447a-b2d9-8c48eb30c674"), null, null, "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("54f05072-a6e7-40a8-bc4d-d039df97dacb"), null, null, "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("4cfe4a4a-aafd-4ef9-8512-f09afb40d11c"), null, null, "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("1e72bfaa-92b1-4d6d-b26b-fd0d6025bd0c"), null, null, "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("fe669440-53b2-4a3c-9c69-2b3249dfcebb"), null, null, "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "Id", "Latitude", "Longitude", "Nome", "UF" },
                values: new object[] { new Guid("cd4cdc99-27e2-43a2-9cc0-bbbdf8a8d589"), null, null, "Palmas", "TO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0ee2b0fd-9a1b-4646-9f2c-51502e11e21e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("0facf6cb-5a07-4885-976d-a170e73fd166"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1187e3c1-ed55-4e70-9777-d24b2a67b92e"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("1e72bfaa-92b1-4d6d-b26b-fd0d6025bd0c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("250f3b8b-a595-45bd-96f7-a33ac7e5b5d9"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("4cfe4a4a-aafd-4ef9-8512-f09afb40d11c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5185770a-f27e-4a73-9af3-2406c6c89cbd"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("52441980-5967-4b5b-9c11-37c540f4da74"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("54f05072-a6e7-40a8-bc4d-d039df97dacb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("5ccf76fa-2138-4695-bd37-30d94161d303"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("6f95723d-586a-4061-b322-62f519adc95c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7879d093-7843-41b0-8b24-b17d6f4a8314"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7bef69cc-5c0f-42d8-b047-b7f1c406e033"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("7d7d37c5-9467-4608-a6f6-6414a7b533cb"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("85a94850-8e63-447a-b2d9-8c48eb30c674"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("979cdcaf-fc2a-4dcd-a6fa-069254083514"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("b1f6391d-6d00-432d-b542-0a9eabdb3635"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c4e83839-a7d7-4080-bd82-8b483b429a8f"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("c70b0247-57f6-45ea-b76e-709cb0df62f1"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("cd4cdc99-27e2-43a2-9cc0-bbbdf8a8d589"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("cf651ec4-923e-44e0-8908-256498e2fc42"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("d9273c38-3c22-4a96-a29e-ca9c25b8e733"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("da2d10a0-f623-48c6-b5be-81daa483cd6c"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("ea8e95d9-474c-4c7f-a8e5-63c1b6f2a2b4"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("f4f2c24f-094d-474f-be75-9937032d49ed"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fc04a4cc-37fc-4c45-9e18-e333c2bcdc7a"));

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "Id",
                keyValue: new Guid("fe669440-53b2-4a3c-9c69-2b3249dfcebb"));

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Cidade");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Cidade");

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
        }
    }
}
