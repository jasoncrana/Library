﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Shared.Models
{
  public class Checkout
  {
    public int Id { get; set; }

    [Required]
    [Display(Name = "Library Asset")]
    public LibraryAsset LibraryAsset { get; set; }

    [Display(Name ="Library Card")]
    public LibraryCard LibraryCard { get; set; }

    [Display(Name ="Checked out on")]
    public DateTime Since { get; set; }

    [Display(Name = "Expected return")]
    public DateTime Until { get; set; }
  }
}
