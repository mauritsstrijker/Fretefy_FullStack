namespace Fretefy.Test.Application.Settings
{
    public class GoogleSettings
    {
        public string GeocodingApiKey { get; set; }

        public bool Enabled => !string.IsNullOrEmpty(GeocodingApiKey);
    }
}
