namespace ReserveYourSport.ApiService.Models.SQL
{
    public sealed class Court
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid CompanyId { get; set; }
        public Guid SportId { get; set; }
    }
}
