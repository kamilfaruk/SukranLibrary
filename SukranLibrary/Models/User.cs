/* Coder by KFY */
namespace SukranLibrary.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Authority { get; set; }
        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }
    }
}