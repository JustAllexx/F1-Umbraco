using Microsoft.AspNetCore.Mvc;
using F1_site.Models;
using Umbraco.Cms.Web.Common.Controllers;
using Microsoft.Data.Sqlite;

namespace F1_site.Controllers
{

    [Route("api/schedule")]
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("getraces")]
        public IEnumerable<CalendarRace> getRaces()
        {
            CalendarRace australia = new ("Australia", "FORMULA 1 AUSTRALIAN GRAND PRIX 2025", "MAR", "14-16");
            CalendarRace dubai = new("China", "FORMULA 1 HEINEKEN GRAND PRIX 2025", "MAR", "21-23");
            CalendarRace japan = new("Japan", "FORMULA 1 LENOVO JAPANESE GRAND PRIX 2025", "APR", "04-06");
            return [australia, dubai, japan];
        }

        [HttpGet("standings")]
        public IEnumerable<F1Driver> GetDrivers()
        {
            List<F1Driver> driverReturn = new();
            string query = "SELECT DriverName, DriverTeam, DriverNumber, DriverPoints FROM Drivers ORDER BY DriverPoints DESC";
            string resolvedPath = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            using (var connection = new SqliteConnection($"Data Source={resolvedPath}\\Umbraco.sqlite.db"))
            {
                connection.Open();
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string driverName = reader.GetString(0);
                            string driverTeam = reader.GetString(1);
                            int driverNumber = reader.GetInt32(2);
                            int driverPoints = reader.GetInt32(3);

                            F1Driver a = new F1Driver(driverName, driverTeam, driverNumber, driverPoints);
                            driverReturn.Add(a);
                        }
                    }
                }
            }

            return driverReturn;
        }
    }
}
