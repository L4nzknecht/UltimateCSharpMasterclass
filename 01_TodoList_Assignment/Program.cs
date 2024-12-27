var todoList = new List<string> ();

void AddTodoItem()
{
    string toDoItem;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        bool shouldAdd = true;
        toDoItem = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(toDoItem))
        {
            Console.WriteLine("The description cannot be empty.");
            continue;
        }
        foreach (var toDo in todoList)
        {
            if (toDo == toDoItem)
            {
                Console.WriteLine("The description must be unique");
                shouldAdd = false;
                continue;
            }
        }
        if (!shouldAdd)
        {
            continue;
        }
        break;
    } while (true);
    todoList.Add(toDoItem);
    Console.WriteLine($"TODO successfully added: {toDoItem}");
}

void RemoveToDoItem()
{
    do
    {
        Console.WriteLine("Select the Index of the ToDo you want to remove:");
        ShowTodoList();
        string userInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userInput))
        {
            Console.WriteLine("Selected index cannot be empty.");
            continue;
        }
        if (!int.TryParse(userInput, out int index))
        {
            Console.WriteLine("The given index is not valid.");
            continue;
        }
        if (index < 1 || index > todoList.Count)
        {
            Console.WriteLine("The given index is not valid.");
            continue;
        }
        Console.WriteLine($"TODO removed: {todoList[index - 1]}");
        todoList.RemoveAt(index - 1);
        break;
    } while (true);

}

void ShowTodoList()
{
    int counter = 0;
    if (todoList.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
        return;
    }
    foreach (var todo in todoList)
    {
        counter++;
        Console.WriteLine($"{counter}. {todo}");
    }
    return;
}

bool shallEnd = false;

Console.WriteLine("Hello!");

do
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S] ee all TODOs");
    Console.WriteLine("[A] dd a TODO");
    Console.WriteLine("[R] emove a TODO");
    Console.WriteLine("[E] xit");

    string userChoice = Console.ReadLine();

    switch(userChoice.ToUpper())
    {
        case "S":
            ShowTodoList();
            break;
        case "A":
            AddTodoItem();
            break;
        case "R":
            RemoveToDoItem();
            break;
        case "E":
            shallEnd = true;
            break;
        default:
            Console.WriteLine("Incorrect input");
            break;
    }
} while (!shallEnd);

