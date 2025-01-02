namespace F1_site.Models
{
    public class CalendarRace
    {

        public CalendarRace(string v1, string v2, string v3, string v4)
        {
            place = v1;
            name = v2;
            month = v3;
            days = v4;
        }

        public string place { get; set; }
        public string name { get; set; }
        public string month { get; set; }
        public string days { get; set; }
    }
}
