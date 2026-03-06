using Fretefy.Test.Application.Interfaces;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fretefy.Test.Infra.Services
{
    public class ExportService : IExportService
    {
        public byte[] Export(string sheetName, string[] headers, IEnumerable<string[]> rows)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);

                for (int i = 0; i < headers.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = headers[i];
                    worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                }

                var row = 2;
                foreach (var rowData in rows)
                {
                    for (int i = 0; i < rowData.Length; i++)
                        worksheet.Cells[row, i + 1].Value = rowData[i];
                    row++;
                }

                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                return package.GetAsByteArray();
            }
        }
    }
}
