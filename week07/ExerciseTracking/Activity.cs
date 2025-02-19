//This is the base class, this is an abstract class

//Atributes: 
// _date: string
// _LengthMinutes: int

//Methods:
//GetDistance(): double.
//GetSpeed(): double
//Getpace(): double
//GetSummary(): string

using System;

public abstract class Activity
{
    // Attributes
    protected DateTime _date;
    protected int _LengthMinutes;

    //Constructor
    public Activity(DateTime date, int durationMinutes)
    {
        _date = date;
        _LengthMinutes = durationMinutes;
    }

    //Methods
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double Getpace();
    public abstract string GetSummary();
}