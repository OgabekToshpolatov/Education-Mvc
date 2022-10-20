using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc.Entities;

public class Group
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public ulong Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Student>? Students { get; set; }

    [Obsolete("this constroctor obly be used by Ef Core")]
    public Group() { }


}