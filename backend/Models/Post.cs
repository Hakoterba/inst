using System;
using System.ComponentModel.DataAnnotations;

public class Post
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    [Required]
    public string Content { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}