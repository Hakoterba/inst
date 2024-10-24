// Models/Comment.cs
using System;
using System.ComponentModel.DataAnnotations;

public class Comment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Content { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Foreign key for Post
    public int PostId { get; set; }
    public Post Post { get; set; }

    // Foreign key for User
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}