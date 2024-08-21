// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do");
Console.WriteLine("[S]ee all TODOS" );
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");


string userType = Console.ReadLine();
 var todos = new List<string> { "studying Context", "read on the bus", "go to work"};

do
{

    
    if (userType == "A" || userType == "a")
    {
        var newTodo = Console.ReadLine();
        todos.Add(newTodo);
        break;
    }

    if (userType == "S" || userType == "s")
    {
        for (var i=0; i<todos.Count; ++i)
        {
            Console.WriteLine(todos[i]);
            break;
        }


    }

    if (userType == "R" || userType == "r")
    {
        //remove a unique todos
        foreach (var i in todos)
        {
            todos.Remove(i);
            break;
        }

    }
} while (userType != "E" || userType != "e");

Console.ReadKey();




