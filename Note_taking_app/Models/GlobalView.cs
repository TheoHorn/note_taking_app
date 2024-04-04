namespace note_taking_app.Models;
public class GlobalView
{
    public List<Note> Notes { get; set; }

    //public List<Note> ArchivedNotes { get; set; }

    public GlobalView(List<Note> notes_find)
    {
        Notes = [.. notes_find];
    }

    
}
