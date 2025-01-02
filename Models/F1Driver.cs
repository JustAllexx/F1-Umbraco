namespace F1_site.Models
{
    public class F1Driver(string DriverName, string DriverTeam, int DriverNumber, int DriverPoints)
    {
        public string DriverName { get; set; } = DriverName;
        public string DriverTeam { get; set; } = DriverTeam;
        public int DriverNumber { get; set; } = DriverNumber;
        public int DriverPoints { get; set; } = DriverPoints;
    }
}
