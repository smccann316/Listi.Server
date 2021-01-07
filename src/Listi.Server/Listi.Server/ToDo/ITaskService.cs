using Listi.Server.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Listi.Server.Services
{
    public interface ITaskService
    {
        ToDo AddUser(AddToDoParams p);
        List<ToDo> Get(); //TODO need to except a filter
        ToDo UpdateToDo(ToDo t);
        ToDo CompleteToDo(CompleteTodoParams p);

    }
}
