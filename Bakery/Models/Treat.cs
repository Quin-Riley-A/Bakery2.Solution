using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "Please enter a value, this field cannot be left empty.")]
    public string TreatName { get; set; }
    public string TreatDescription { get; set; }
    public List<TreatFlavor> JoinEntities { get; }
    public ApplicationUser User { get; set; }
  }
}