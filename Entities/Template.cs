
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace HW1API.Entities;

[Table("Table Example")]
public class Template 
{

    [Key]
    public int TempleteID { get; set; }

    [MaxLength(50)]
    public string? Name { get; set; }

    public float  TrueValue { get; set; }

    public virtual IEnumerable<Lesson> Lessons { get; set; }
}

