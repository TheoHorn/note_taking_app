namespace note_taking_app.Models;

public class NoteView
{
    public String Title { get; set; }

    public NoteView(Note note)
    {
        Title = note.Title;
    }
}
