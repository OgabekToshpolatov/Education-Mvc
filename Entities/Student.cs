using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc.Entities;

public class Student
{
   [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   public ulong Id { get; set; }
   public string?  FulName { get; set; }
   public string? PhoneNumber { get; set; }
   public ulong GroupId { get; set; }
   [ForeignKey(nameof(GroupId))]
   public Group? Group { get; set; }

   [Obsolete("this constroctor obly be used by Ef Core")]
   public Student() {}

   //Rampampam  Rampampam Rampampam Rampampam Rampampam Rampampam
}