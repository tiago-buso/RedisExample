namespace RedisExample.Models
{
    public class Weather
    {
        public string CityName { get; set; }
        public string Country { get; set; }
        public double Day { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Night { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public int Humidity { get; set; }
    }
}
