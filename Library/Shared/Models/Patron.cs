using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Shared.Models
{
  public class Patron
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DoB { get; set; }
    //public vitrual LibraryCard Card { get; set; }
  }
}
