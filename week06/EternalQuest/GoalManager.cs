namespace EternalQuest
{
    public class GoalManager 
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;
        private string _username;
        private string _filename;
        
        public GoalManager()
        {
        }

        //Methods

        public void Start()
        {
            Console.Write("Enter your name: ");
            _username = Console.ReadLine();
            _filename = $"{_username}.txt"; // El archivo será el nombre del usuario

            if (File.Exists(_filename))
            {
                Console.WriteLine($"Welcome again!!{_username} We have the register of all your goals!!");
                LoadGoals(); // Si existe, cargamos las metas
            }
            else
            {
                Console.WriteLine("Welcome! No saved goals found, starting fresh.");
            }

            int option = 0;
            do
            {
                DisplayPLayInfo();
                Console.WriteLine("     1. Create New Goal");
                Console.WriteLine("     2. List Goals");
                Console.WriteLine("     3. Save Goals");
                Console.WriteLine("     4. Load Goals");
                Console.WriteLine("     5. Record Event");
                Console.WriteLine("     6. Quit");
                Console.Write("Select a choice from the menu: ");
                option = Convert.ToInt32(Console.ReadLine());
                
                switch(option)
                {
                    case 1:
                        CreateNewGoal();
                        break;
                    case 2:
                        ListGoalNames();
                        break;
                    case 3:
                        SaveGoals();
                        break;
                    case 4:
                        LoadGoals();
                        break;
                    case 5:
                        RecordEvent();
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Enter a valid number");
                        break;
                }

            }while(option != 6);

            Console.WriteLine("Bye, see you soon");
        }

        //Display the player current score
        public void DisplayPLayInfo()
        {
            Console.WriteLine($"You have {_score} points\n");
        }

        //Create A new Goal
        public void CreateNewGoal()
        {
            Console.WriteLine("1. simple goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. CheckList Goal");
            Console.Write("Enter the type of goal: ");
            string choice = Console.ReadLine();
            
            Console.Write("Enter the name of the goal: ");
            string name = Console.ReadLine();

            Console.Write("Enter the description of the goal: ");
            string description = Console.ReadLine();

            Console.Write("Enter the points for that goal: ");
            int points = Convert.ToInt32(Console.ReadLine());

            Goal goal = null;

            switch(choice)
            {
                case "1":
                    goal = new SimpleGoal(name, description, points);
                    break;
                case "2":
                    goal = new EternalGoals(name, description, points);
                    break;
                case "3":
                    Console.Write("Enter the target: ");
                    int target = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the bonus you're gonna get whtn you complete this goal: ");
                    int bonus = Convert.ToInt32(Console.ReadLine());
                    goal = new ChecklistGoal(name, description, points, target, bonus);
                    break;
            }
            _goals.Add(goal);
            Console.WriteLine($"({goal.GetShortName()}) has been added succesfully");
        }

        public void ListGoalNames()
        {
            foreach(var g in _goals)
            {
                Console.WriteLine(g.GetDetailsString());
            }
        }

        public void RecordEvent()
        {
            //Show the goals by number
            int i = 1;
            foreach(var g in _goals)
            {
                Console.WriteLine($"    {i}-{g.GetShortName()}");
                i++;
            }
            //Ask the user the number of the goal
            Console.Write("Which Goal did you accomplished?: ");
            int goal_number = Convert.ToInt32(Console.ReadLine());
            //look fot that number on the list, number - 1.
            //Record the event.
            _goals[goal_number - 1].RecordEvent();
            _score += _goals[goal_number - 1].Getpoint();
        }

        //Save Goals
        public void SaveGoals()//saved in (bin/Debug/net.8.0)
        {

            using (StreamWriter writer = new StreamWriter(_filename))
            {
                writer.WriteLine(_score);
                foreach(var goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine($"Goals saved succesfully to {_filename}");
        } 

        public void LoadGoals()
        {
            if (!File.Exists(_filename))
            {
                Console.WriteLine("File not found!");
                return;
            }

            _goals.Clear(); // Clear existing goals before loading

            using (StreamReader reader = new StreamReader(_filename))
            {
                // Read the score first
                _score = int.Parse(reader.ReadLine());

                // Read each goal line by line
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Goal goal = Deserialize(line);
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }

        // Deserialize a line into a Goal object
        private Goal Deserialize(string line)
        {
            string[] parts = line.Split(',');

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    simpleGoal.SetIsCompleted(bool.Parse(parts[4]));
                    return simpleGoal;

                case "EternalGoals":
                    return new EternalGoals(name, description, points);

                case "CheckListGoal":
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[4]);
                    int amount = int.Parse(parts[6]);
                    ChecklistGoal newgoal = new ChecklistGoal(name, description, points, target, bonus);
                    newgoal.SetAmount(amount);
                    return newgoal;

                default:
                    Console.WriteLine("Unknown goal type: " + type);
                    return null;
            }
        }
        
    }
}