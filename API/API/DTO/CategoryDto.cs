﻿using System.ComponentModel.DataAnnotations;

namespace API.DTO
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Data { get; set; } = string.Empty;
        public Boolean IsActive { get; set; }
    }
}
