using System.ComponentModel.DataAnnotations.Schema;

namespace Section2.Domain.Entities;
[Table("Role")]
public class Role:BaseEntity<long>
{
    public string Name { get; set; }
}
