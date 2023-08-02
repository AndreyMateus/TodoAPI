using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyApi.Data;
using MyApi.Models;

namespace MyApi.Controllers;

[ApiController]
public class HomeController : ControllerBase
{

    [HttpGet("/")]
    public IActionResult Get([FromServices] AppDBContext appDBContext)
    => Ok(appDBContext.Todos.ToList());
    
    [HttpGet("/{id:int}")]
    public IActionResult GetById([FromServices] AppDBContext appDBContext,[FromRoute]int id)
    {
        var todoReturned = appDBContext.Todos.FirstOrDefault(x => x.Id == id);
        
        if(todoReturned is null)
            return NoContent();
        
        return Ok(todoReturned);
    }
    
    [HttpPost("/")]
    public IActionResult Post([FromServices] AppDBContext appDBContext, [FromBody] TodoModel todo)
    {
        appDBContext.Todos.Add(todo);
        appDBContext.SaveChanges();

        return Created($"/{todo.Id}",todo);
    }

    [HttpPut("/{id:int}")]
    public IActionResult Put([FromServices] AppDBContext appDBContext, [FromBody] TodoModel todo,[FromRoute]int id)
    {
        var todoReturned = appDBContext.Todos.FirstOrDefault(x => x.Id == id);

        if (todoReturned is null)
            return NotFound();

        todoReturned.Title = todo.Title;
        todoReturned.Summary = todo.Summary;
        todoReturned.Done = todo.Done;

        appDBContext.Update(todoReturned);
        appDBContext.SaveChanges();

        return Ok(todoReturned);
    }

    [HttpDelete("/{id:int}")]
    public IActionResult Delete([FromServices] AppDBContext appDBContext, int id)
    {
        var todoReturned = appDBContext.Todos.SingleOrDefault(x => x.Id == id);

        if(todoReturned is null)
        return NotFound();

        appDBContext.Todos.Remove(todoReturned);
        appDBContext.SaveChanges();

        return Ok(todoReturned);
    }

}
