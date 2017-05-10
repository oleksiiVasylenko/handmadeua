
namespace Handmadeua.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public City City { get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public string PostIndex { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
