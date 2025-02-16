//Exceeding requirements:This program allows multiple users to create and manage their goals individually. Each user has their own file where goals and progress are saved. When logging in with their name, the program loads existing data or creates a new file for new users.

using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}