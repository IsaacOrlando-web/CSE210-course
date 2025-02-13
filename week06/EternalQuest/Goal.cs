//The base class of Goal that defines the common responsibilities, behaviors, and attributes.

//Atributes: 
//_ShortName: String
//_description: string
//_points: String

//Constructor:
//Goal(name, description, points)

//Methods or behaviors:
//RecordEvent(): void
//IsCOmplete(): bool
//GetDetailsString(): string
//GetStringRpresentation(): string.

using System.Net.Http.Headers;

public class Goal
{
    // Attributes
    protected string _shortName;
    protected string _description;
    protected int _points;

    //Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Getters
    public string GetShortName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int Getpoint()
    {
        return _points;
    }

    //Class Behaviors
    public virtual void RecordEvent() //mark that is has been accomplished another time
    {
        Console.WriteLine($"You have earned {_points} points");
        //This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    }

    //This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    public virtual bool IsComplete()
    {
        return true; //true, is complete. False, Not completed
    }

    //return the details of a goal that could be shown in a list.
    //It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    public virtual string GetDetailsString()
    {
        string checklist = "";
        if(IsComplete() == true)
        {
            checklist = "X"; //Mark the checkList with an x if is completed
        }
        else{
            checklist = " ";//Empty if is not completed
        }

        return $"[{checklist}] {_shortName} : {_description}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}:{_description}";
    }
}