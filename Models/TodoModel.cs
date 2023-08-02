using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Models;

public class TodoModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Summary { get; set; }
    public bool Done { get; set; }
    public DateTime CreatedAt { get; set; }
}
