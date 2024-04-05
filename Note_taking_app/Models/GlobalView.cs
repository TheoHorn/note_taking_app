namespace note_taking_app.Models;
public class GlobalView
{
    public List<Note> Notes { get; set; }

    public List<Task> Tasks { get; set; }

    //public List<Note> ArchivedNotes { get; set; }

    public GlobalView(List<Note> notes_find)
    {
        Notes = [.. notes_find];
        Tasks = getTasks();
    }

    public List<Task> getTasks()
    {
        List<Task> tasks = new List<Task>();
        foreach (var note in Notes)
        {
            tasks.AddRange(note.Tasks);
        }
        tasks.Sort((x, y) => DateTime.Compare(x.Due, y.Due));
        return tasks;
    }
    
}
