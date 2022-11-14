using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library.Shared.Models
{
  public class LibraryCard
  {
    public int Id { get; set; }

    [Display(Name = "Overdue Fees")]
    [Precision(4,2)]
    public decimal Fees { get; set; }

    [Display(Name = "Card Issued Date")]
    public DateTime Created { get; set; }

    [Display(Name = "Materials on Loan")]
    public virtual IEnumerable<Checkout> Checkouts { get; set; }

  }
}
