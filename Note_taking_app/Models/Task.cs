using System.ComponentModel.DataAnnotations;
namespace note_taking_app.Models;

public class Task{

    public static int IdCounter = 1;

    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public bool IsComplete { get; set; }

    public Task()
    {
        Id = IdCounter++;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
        Title = "no-title";
        IsComplete = false;
    }

    
}