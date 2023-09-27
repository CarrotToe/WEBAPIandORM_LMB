using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW1API.Entities;


[Table("LessonChart")]
public class Lesson
{
public int LessonId { get; set; }
[MaxLength(50)]
public string? LessonSubject { get; set; }

public virtual IEnumerable<Template> Templates { get; set; }

}
