using System.ComponentModel.DataAnnotations.Schema;

namespace Section2.Domain.Entities;
[Table("User")]
public class User:BaseEntity<long>
{
    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string NationalCode { get; set; }
    public string Password { get; set; }
}
