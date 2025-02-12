using System.ComponentModel.DataAnnotations;

namespace Section2.Domain.Entities;

public class BaseEntity<T>
{
    [Key]
    public T Id { get; set; }
    public DateTime CreateDate { get; set; }
}
