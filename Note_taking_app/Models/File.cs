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
    [Required]
    public DateTime Created_at { get; set; }

    [Required]
    public DateTime Updated_at { get; set; }

    [Required]
    public int IdNote { get; set; }

    public File()
    {
        Id = IdCounter++;
        Created_at = DateTime.Now;
        Updated_at = DateTime.Now;
        Title = "no-title";
        Content = "ctn";
    }

    public File(string title, string content)
    {
        Id = IdCounter++;
        Title = title;
        Content = content;
        Created_at = DateTime.Now;
        Updated_at = DateTime.Now;
    }

    public void Update(string title, string content)
    {
        Title = title;
        Content = content;
        Updated_at = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Content: {Content}, Created_at: {Created_at}, Updated_at: {Updated_at}";
    }

}