using System.ComponentModel.DataAnnotations.Schema;

namespace Section2.Domain.Entities
{
    [Table("UserRole")]
    public class UserRole:BaseEntity<long>
    {
        [ForeignKey(nameof(User))]
        public long User_Ref {  get; set; }
        public User User { get; set; }
        [ForeignKey(nameof(Role))]
        public long Role_Ref { get; set; }
        public Role Role { get; set; }  
    }
}
