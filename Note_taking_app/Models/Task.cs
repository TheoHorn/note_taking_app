using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
namespace note_taking_app.Models;

public class Task{

    public static int IdCounter = 1;

    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public DateTime Created_at { get; set; }

    [Required]
    public DateTime Updated_at { get; set; }

    [Required]
    public DateTime Due { get; set; }

    [Required]
    public bool IsCompleted { get; set; }

    [Required]
    public int IdNote { get; set; }

    [NotMapped]
    public String NoteTitle { get; set; }

    public Task()
    {
        Id = IdCounter++;
        Created_at = DateTime.Now;
        Updated_at = DateTime.Now;
        Title = "no-title";
        IsCompleted = false;
        Due = DateTime.Now;
        NoteTitle = "no-note";
    }
    
    public string getDueString()
    {
        return Due.ToString("yyyy-MM-dd");
    }
}