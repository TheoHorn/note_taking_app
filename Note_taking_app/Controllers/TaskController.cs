using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using note_taking_app.Data;
using note_taking_app.Models;

namespace note_taking_app.Controllers;

public class TaskController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public TaskController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Create(int id)
    {
        var note = _context.Note.Where(n => n.Id == id).FirstOrDefault();
        if (note == null)
        {
            return NotFound();
        }else
        {
            return View(new TaskView(note));
        }
    }

    public IActionResult View(int id)
    {
        var task = _context.Task.Where(t => t.Id == id).FirstOrDefault();
        if (task == null)
        {
            return NotFound();
        }
        var note = _context.Note.Where(n => n.Id == task.IdNote).FirstOrDefault();
        return View(new TaskView(task, note));
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
