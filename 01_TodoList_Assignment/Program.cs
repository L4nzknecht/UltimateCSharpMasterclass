var todoList = new List<string> ();
bool shallEnd = false;

Console.WriteLine("Hello!");

do
{
    Console.WriteLine("");
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S] ee all TODOs");
    Console.WriteLine("[A] dd a TODO");
    Console.WriteLine("[R] emove a TODO");
    Console.WriteLine("[E] xit");

    string userChoice = Console.ReadLine();

    switch(userChoice)
    {
        case "s":
        case "S":
            ShowTodoList();
            break;
        case "a":
        case "A":
            AddTodoItem();
            break;
        case "r":
        case "R":
            RemoveToDoItem();
            break;
        case "e":
        case "E":
            shallEnd = true;
            break;
        default:
            Console.WriteLine("Incorrect input");
            break;
    }
} while (!shallEnd);

Console.ReadKey();

void AddTodoItem()
{
    string toDoItem;
    bool isValidDescription = false;
    do
    {
        Console.WriteLine("Enter the TODO description:");

        toDoItem = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(toDoItem))
        {
            Console.WriteLine("The description cannot be empty.");
        }
        else if (todoList.Contains(toDoItem))
        {
            Console.WriteLine("The description must be unique");
        }
        else 
        {
            todoList.Add(toDoItem);
            isValidDescription = true;
        }
    } while (!isValidDescription);

    Console.WriteLine($"TODO successfully added: {toDoItem}");
}

void ShowTodoList()
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    for (int i = 0; i < todoList.Count; i++)
    {
        string? todo = todoList[i];
        Console.WriteLine($"{i + 1}. {todo}");
    }
    return;
}

void RemoveToDoItem()
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    bool IsIndexValid = false;
    do
    {
        Console.WriteLine("Select the Index of the ToDo you want to remove:");
        ShowTodoList();
        string userInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Selected index cannot be empty.");
        }
        else if (!int.TryParse(userInput, out int index) || index < 1 || index > todoList.Count)
        {
            Console.WriteLine("The given index is not valid.");
        }
        else 
        {
            var indexOfTodo = index - 1;
            Console.WriteLine($"TODO removed: {todoList[indexOfTodo]}");
            todoList.RemoveAt(indexOfTodo);
            IsIndexValid = true;
        }
    } while (!IsIndexValid);
}
