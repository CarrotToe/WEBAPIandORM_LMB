using System.ComponentModel.DataAnnotations.Schema;

namespace HW1API.Entities;



[Table("Connection")]
public class Connection
{

public int ConnectionID { get; set; }

public DateTime ConnectionDate { get; set; }

public virtual IEnumerable<Review> Reviews { get; set; }

}
