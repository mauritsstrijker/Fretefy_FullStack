using System.Threading.Tasks;

namespace Fretefy.Test.Application.Interfaces
{
    public interface IGeocodingService
    {
        Task<GeocodingResult> GetCoordinatesAsync(string city, string state);
    }

    public class GeocodingResult
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
