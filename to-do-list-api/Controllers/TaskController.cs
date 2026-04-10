using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<ToDoTask>> Get()
    {
        var tasks = TaskService.GetAll();

        if(!tasks.Any())
            return NotFound();

        return tasks; 
    }

    [HttpGet("{id}")]
    public ActionResult<ToDoTask> Get(int id)
    {
        var task = TaskService.GetById(id);
        
        if(task == null)
            return NotFound();
        
        return task;
    }

    [HttpPost]
    public IActionResult Create (ToDoTask task)
    {
        if(TaskService.Add(task)) return Created();
        return BadRequest();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete (int id)
    {
        if(TaskService.Delete(id)) return Ok();
        return BadRequest();
    }

    [HttpPut("{id}")]
    public IActionResult Update (int id, ToDoTask task)
    {
        if(id != task.Id) return BadRequest();

        if(TaskService.Update(id, task)) return Ok();
        
        return NoContent();
    }
}


