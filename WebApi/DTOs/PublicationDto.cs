﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.DTOs
{
    public class PublicationDto
    {
        [Required]
        public string Content { get; set; }
        public string? ImageUrl { get; set; }
        public string? VideoUrl { get; set; }
    }
}
