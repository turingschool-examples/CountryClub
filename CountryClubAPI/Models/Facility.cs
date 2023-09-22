namespace CountryClubAPI.Models
{
    public class Facility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MemberCost { get; set; }
        public double GuestCost { get; set; }
        public double InitialOutlay { get; set; }
        public double MonthlyMaintenance { get; set; }
    }
}
