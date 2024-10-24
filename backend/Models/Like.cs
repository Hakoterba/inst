using System;
using System.ComponentModel.DataAnnotations;

public class Like
{
    [Key]
    public int Id { get; set; }

    public bool IsLike { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    // Foreign key for Post
    public int PostId { get; set; }
    public Post Post { get; set; }

    // Foreign key for User
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}