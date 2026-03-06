using Fretefy.Test.Application.Interfaces;
using Fretefy.Test.Application.Settings;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fretefy.Test.Infra.Services
{
    public class GoogleGeocodingService : IGeocodingService
    {
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public GoogleGeocodingService(HttpClient httpClient, IOptions<GoogleSettings> googleSettings)
        {
            _httpClient = httpClient;
            _apiKey = googleSettings.Value.GeocodingApiKey;
        }

        public async Task<GeocodingResult> GetCoordinatesAsync(string city, string state)
        {
            var address = Uri.EscapeDataString($"{city}, {state}, Brasil");
            var url = $"https://maps.googleapis.com/maps/api/geocode/json?address={address}&key={_apiKey}";

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var geocode = JsonSerializer.Deserialize<GoogleGeocodeResponse>(json, _jsonOptions);

            if (geocode?.Status != "OK" || geocode.Results == null || geocode.Results.Count == 0)
                return null;

            var first = geocode.Results[0];

            return new GeocodingResult
            {
                Latitude = first.Geometry.Location.Lat,
                Longitude = first.Geometry.Location.Lng,
            };
        }

        private class GoogleGeocodeResponse
        {
            public string Status { get; set; }
            public List<GoogleGeocodeResult> Results { get; set; }
        }

        private class GoogleGeocodeResult
        {
            public GoogleGeometry Geometry { get; set; }
        }

        private class GoogleGeometry
        {
            public GoogleLatLng Location { get; set; }
        }

        private class GoogleLatLng
        {
            public double Lat { get; set; }
            public double Lng { get; set; }
        }
    }
}
