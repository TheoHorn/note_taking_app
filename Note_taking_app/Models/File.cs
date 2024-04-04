using System.ComponentModel.DataAnnotations;
namespace note_taking_app.Models;


public class File
{
    public static int IdCounter = 1;

    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public File()
    {
        Id = IdCounter++;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
        Title = "no-title";
        Content = "ctn";
    }

    public File(string title, string content)
    {
        Id = IdCounter++;
        Title = title;
        Content = content;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public void Update(string title, string content)
    {
        Title = title;
        Content = content;
        UpdatedAt = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Content: {Content}, CreatedAt: {CreatedAt}, UpdatedAt: {UpdatedAt}";
    }

}