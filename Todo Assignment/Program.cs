using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;

string userInput;

List<string> todoList = new List<string>(){};

do
{
    Console.WriteLine("Hello!");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    userInput = Console.ReadLine();
    


    // if an option that is not S, A, R, is selected, the user should be told that it is an incorrect choice

    switch (userInput)
    {
        case "S":
        case "s":
            Console.WriteLine("See all Todos");
            seeAllTodos();
            break;
        case "A":
        case "a":
            Console.WriteLine("Add a Todo");
            
            addATodo();
            break;
        case "R":
        case "r":
            Console.WriteLine("Remove a Todo");
            removeATodo();
            break;
        case "E":
        case "e":
            Console.WriteLine("Exit Loop");
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
    } 
} while (userInput != "E");

//Writing a method for add a todo, it includes the userInput to the List array

void addATodo(){
    //if case A is selected, the user Input should be collected afterwards and added to list
    var newInput = Console.ReadLine();
    todoList.Add(newInput);
}

void seeAllTodos()
{
    for (int i = 0; i < todoList.Count; ++i)
    {
        Console.WriteLine($"{i + 1}: " + todoList[i] );
    }
}


/* When pressed "R"

if no todos, then say no todos have been added yet else showTodos


we will select the index we want to remove.

 If index is wrong or non existent, we will say index does not exist

Then list of all Todos shall be printed like the See all todos



when index that exist is selected, the todo should be removed instantly

then we have TODO removed:[Description] with description of the todo that has just been removed

Then the application should print again 'What do you want todo' with all available options */

void removeATodo(){
    

    if (todoList.Count == 0)
    {
        Console.WriteLine("no todos have been added yet");
    }else
    {
        seeAllTodos();
        Console.WriteLine("Select Todos to remove");
        
    }

    var indexNum = Console.ReadLine();
    bool isNumber = int.TryParse(indexNum, out int number);
    for (int i= 0; i < todoList.Count; ++i){

        // if the number is more than 0 and it matches with the number in the todolist, remove that number
        if (isNumber)
        {
            //whatever number the user type, i should add plus 1
            var newNumber = number - 1;
            
                todoList.Remove(todoList[newNumber]);
            
        }
        else
        {
            
            Console.WriteLine("That is not a right index number");

        }
          
    }
}

















