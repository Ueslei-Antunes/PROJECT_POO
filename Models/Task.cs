using System;
using System.Reflection.Emit;

namespace Models;

public class Task
{
    public Task() {}
    public Task(string title, string description, DateTime dateCreation, DateTime dateExpiration, string priority, string taskCategoryId, bool status)
    {
        Title = title;
        Description = description;
        DateCreation = dateCreation;
        DateExpiration = dateExpiration;
        Priority = priority;
        TaskCategoryId = taskCategoryId;
        Status = status;
    }

    public int? TaskId { get; set; }    
    public string Title {get; set;}
   
    public string Description { get; set; }
    
    public DateTime DateCreation { get; set; }

    public DateTime DateExpiration { get; set; }

    //Priority vai ser um enum
    public string Priority { get; set; }

    //Category tbm vai ser um enum
    public string TaskCategoryId { get; set; }

    public bool Status { get; set; }

    public override bool Equals(object? obj)
    {
        if(obj == null || obj.GetType() != GetType()){
            return false;
        }
        var other = (Task)obj;

        return base.Equals(
            TaskId.HasValue && other.TaskId.HasValue && 
                TaskId==other.TaskId
        );
    }

    public override int GetHashCode()
    {
        return TaskId.HasValue ? TaskId.GetHashCode() : 0;
    }



}
