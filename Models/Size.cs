﻿using System.ComponentModel.DataAnnotations;

namespace Shoppee.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }
        [StringLength(10)]
        public string? SizeName { get; set; }
    }
}
