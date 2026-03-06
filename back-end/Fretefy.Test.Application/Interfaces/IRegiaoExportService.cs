using System.Threading.Tasks;

namespace Fretefy.Test.Application.Interfaces
{
    public interface IRegiaoExportService
    {
        Task<byte[]> ExportAsync();
    }
}
