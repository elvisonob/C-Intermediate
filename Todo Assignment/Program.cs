// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do");
Console.WriteLine("[S]ee all TODOS" );
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");


string userType = Console.ReadLine();
 var todos = new List<string> { "studying Context", "read on the bus", "go to work"};


    switch (userType)
    {
        case "E":
        case "e":
            Console.WriteLine("Exit");
            break;

    case "A":
    case "a":
        Console.WriteLine("Add a todo");
        if (userType == "")
        {
            Console.WriteLine("User input cannot be empty");
        }
        todos.Add(userType);
        break;

    case "S":
        case "s":
            for (var i = 0; i < todos.Count; ++i)
            {
                Console.WriteLine(todos[i]);
            }
            break;

        case "R":
        case "r":
            // when a word is typed, and the word is not in the todosList, it should 
            // trigger, BUT if it is in the todos list, it should be removed
            Console.WriteLine("Add a todo");
            for (var i = 0; i < todos.Count; ++i)
            {
                if (!userType.Contains(todos[i]))
                {
                    Console.WriteLine("We can't remove what does not exist");
                }

                todos.Remove(todos[i]);

            }
            break;

    default:
        Console.WriteLine("Invalid Choice");
        break;

    }

    
 




