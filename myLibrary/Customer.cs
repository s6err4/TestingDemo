
namespace myLibrary
{
    public class Customer
    {
        private string firstname;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string FullName => $"{FirstName} {LastName}";
    }
}
