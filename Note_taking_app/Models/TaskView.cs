namespace note_taking_app.Models;
public class TaskView
{
    public Task Task { get; set; }

    public Note Note { get; set; }

    public TaskView(Task task, Note note)
    {
        Task = task;
        Note = note;
    }

    public TaskView(Note note)
    {
        Note = note;
        Task = new Task();
    }
}