using System.ComponentModel.DataAnnotations;

namespace note_taking_app.Models;

public class Note{

    public static int IdCounter = 1;

    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public DateTime Created_at { get; set; }

    [Required]
    public DateTime Updated_at { get; set; }

    public List<File> Files { get; set; }

    public List<Task> Tasks { get; }
    public Note()
    {
        Id = IdCounter++;
        Created_at = DateTime.Now;
        Updated_at = DateTime.Now;
        Title = "no-title";
        Files = new List<File>();
        Tasks = new List<Task>();
    
    }


    public void Update(string title)
    {
        Title = title;
        Updated_at = DateTime.Now;
    }

    public void AddFile(File file)
    {
        Updated_at = DateTime.Now;
        Files.Add(file);
    }

    public void AddTask(Task task)
    {
        Updated_at = DateTime.Now;
        Tasks.Add(task);
        Tasks.Sort((x, y) => DateTime.Compare(x.Due, y.Due));
    }

    public void RemoveFile(int id)
    {
        Updated_at = DateTime.Now;
        Files.RemoveAll(f => f.Id == id);
    }

    public void RemoveTask(int id)
    {
        Updated_at = DateTime.Now;
        Tasks.RemoveAll(t => t.Id == id);
    }

    public void setTasks(List<Task> tasks)
    {
        Updated_at = DateTime.Now;
        Tasks.Clear();
        Tasks.AddRange(tasks);
        Tasks.Sort((x, y) => DateTime.Compare(x.Due, y.Due));
    }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Created_at: {Created_at}, Updated_at: {Updated_at}";
    }
}