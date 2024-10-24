// Models/User.cs
using System;
using System.ComponentModel.DataAnnotations;

public class User
{
    [Key]
    public string Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string UserName { get; set; }

    [Required]
    [MaxLength(100)]
    public string Email { get; set; }

    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}