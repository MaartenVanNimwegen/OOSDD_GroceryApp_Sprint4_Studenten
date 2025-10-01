
namespace Grocery.Core.Models
{
    public partial class Client : Model
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public RoleEnum Role { get; set; }

        public enum RoleEnum 
        { 
            None = 0, 
            Admin = 1, 
        }

        public Client(int id, string name, string emailAddress, string password, RoleEnum role = RoleEnum.None) : base(id, name)
        {
            EmailAddress=emailAddress;
            Password=password;
            Role=role;
        }
    }
}
