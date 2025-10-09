using System.Collections.Generic;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        
        _score = 0;
    }
    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu:(1-6): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Thank you for using the Eternal Quest Program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter 1-6!");
            }
        }

    }

    public void DisplayPlayerInfo()   //Displays the players current score.
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }
    public void ListGoalNames()     //Lists the names of each of the goals.
    {
        Console.WriteLine("\nThe goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i} {status} {goal.GetGoalName()}");
            i++;
        }
        
    }
    public void ListGoalDetails()  //Lists the details of each goal (including the checkbox of whether it is complete).
    {
        Console.WriteLine("\nThe goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i} {status} {goal.GetStringRepresentation()} {goal.GetDetailsString()}");
            
            i++;
        }
    }
    public void CreateGoal()     //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    {
        Console.WriteLine("\nSelect a choice from the menu:");
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create:(1-3): ");
        int choice = int.Parse(Console.ReadLine());
        
        Console.WriteLine("What is the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (choice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid input, please enter 1-3!");
        }

    }
    public void RecordEvent()   //Asks the user which goal they have done and then records the event
    {
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplished?");
        int number = int.Parse(Console.ReadLine());
        Goal selectedGoal = _goals[number - 1];
        selectedGoal.RecordEvent();
        _score += selectedGoal.GetPoints();        
    }
    public void SaveGoals() //Saves the list of goals to a file.
    {
        Console.WriteLine("What is the filename for the goal file?");
        string file = Console.ReadLine();
        Console.WriteLine("Saving to file......");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score); //save the score at the first line
            
            // You can use the $ and include variables just like with Console.WriteLine
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal simple)
                {
                    outputFile.WriteLine($"SimpleGoal:{simple.GetGoalName()},{simple.GetDescription()},{simple.GetPoints()},{simple.IsComplete()}");
                }
                if (goal is EternalGoal eternal)
                {
                    outputFile.WriteLine($"EternalGoal:{eternal.GetGoalName()},{eternal.GetDescription()},{eternal.GetPoints()}");
                }
                if (goal is ChecklistGoal checkList)
                {
                    outputFile.WriteLine($"ChecklistGoal:{checkList.GetGoalName()},{checkList.GetDescription()},{checkList.GetPoints()},{checkList.GetAmountCompleted()},{checkList.GetTarget()},{checkList.GetBonus()}");
                }
            }

        }
    }

    public void LoadGoals() //Loads the list of goals from a file.
    {
        Console.WriteLine("What is the filename for the goal file?");
        string file = Console.ReadLine();
        Console.WriteLine("Loading from file......");
        
        if (File.Exists(file))
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            _goals.Clear(); //clear old datas

            _score = int.Parse(lines[0]); //get score from the first line

            for(int i =1; i < lines.Length;i++)
            {
                string line = lines[i];
                string[] typeSplit = line.Split(":");
                string type = typeSplit[0];
                string[] parts = typeSplit[1].Split(",");

                if (type == "SimpleGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);

                    SimpleGoal simple = new SimpleGoal(name, description, points);
                    simple.SetIsComplete(isComplete);
                    _goals.Add(simple);
                }

                if (type == "EternalGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);

                    EternalGoal eternal = new EternalGoal(name, description, points);
                    _goals.Add(eternal);
                }

                if (type == "ChecklistGoal")
                {
                    string name = parts[0];
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int amountCompleted = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    ChecklistGoal checkList = new ChecklistGoal(name, description, points, target, bonus);
                    checkList.SetAmountCompleted(amountCompleted);
                    _goals.Add(checkList);
                }

            }
    
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

}