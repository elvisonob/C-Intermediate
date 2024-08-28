// See https://aka.ms/new-console-template for more information

bool shallExit = false;
var todos = new List<string>();

while (!shallExit)
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do");
    Console.WriteLine("[S]ee all TODOS");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");


    string userType = Console.ReadLine();
  

    switch (userType)
    {
        case "E":
        case "e":
            Console.WriteLine("Exit");
            shallExit = true;
            break;

        case "A":
        case "a":
            bool isDescriptionValid = false;
            while (!isDescriptionValid)
            {
                Console.WriteLine("Add a todo");
                var description = Console.ReadLine();
                if (description == "")
                {
                    Console.WriteLine("User input cannot be empty");
                }
                else if (todos.Contains(description))
                {
                    Console.WriteLine("description must be unique");
                }
                else
                {
                    isDescriptionValid = true;
                    todos.Add(description);
                }
            }
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

            var remove = Console.ReadLine();
            for (var i = 0; i < todos.Count; ++i)
            {
                remove = todos[i];
                if (!todos.Contains(remove))
                {
                    Console.WriteLine("We can't remove what does not exist");
                }
                else
                {
                    todos.Remove(remove);
                }
            }
            break;

        default:
            Console.WriteLine("Invalid Choice");
            break;

    }
}

Console.ReadKey();




    
 




