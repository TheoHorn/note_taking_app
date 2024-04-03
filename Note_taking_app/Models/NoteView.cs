using Note_taking_app.Models;

public class NoteView
{
    public String Title { get; set; }
    public String Content { get; set; }


    public NoteView(Note note)
    {
        Title = note.Title;
        Content = note.Content;
    }
}
