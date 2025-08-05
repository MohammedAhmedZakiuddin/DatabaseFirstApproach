using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproach.Models;

[Keyless]
public partial class Ingredient
{
    public int? Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Name { get; set; }
}
