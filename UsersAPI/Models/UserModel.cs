namespace UsersAPI.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        string AreaCode { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }
    }
}
