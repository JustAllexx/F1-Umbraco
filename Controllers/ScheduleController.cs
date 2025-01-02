using Microsoft.AspNetCore.Mvc;
using F1_site.Models;
using Umbraco.Cms.Web.Common.Controllers;

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
    }
}
