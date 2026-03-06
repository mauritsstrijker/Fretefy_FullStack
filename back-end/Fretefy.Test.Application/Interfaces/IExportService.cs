using System.Collections.Generic;

namespace Fretefy.Test.Application.Interfaces
{
    public interface IExportService
    {
        byte[] Export(string sheetName, string[] headers, IEnumerable<string[]> rows);
    }
}
