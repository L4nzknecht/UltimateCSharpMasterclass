using System;

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
        case "a":
        case "A":
            AddTodoItem();
            break;
        case "e":
        case "E":
            shallEnd = true;
            break;
        case "r":
        case "R":
            RemoveToDoItem();
            break;
        case "s":
        case "S":
            ShowTodoList();
            break;
        default:
            Console.WriteLine("Incorrect input");
            break;
    }
} while (!shallEnd);

void AddTodoItem()
{
    string toDoItem;
    do
    {
        Console.WriteLine("Enter the TODO description:");
        toDoItem = Console.ReadLine();
    } while (IsDescriptionValid(toDoItem));

    todoList.Add(toDoItem);
    Console.WriteLine($"TODO successfully added: {toDoItem}");
}

void RemoveToDoItem()
{
    if (todoList.Count == 0)
    {
        ShowNoToDoMessages();
        return;
    }
    int index;
    do
    {
        Console.WriteLine("Select the Index of the ToDo you want to remove:");
        ShowTodoList();
    } while (!TryReadIndex(out index));

    RemoveToDoAtIndex(index - 1);
}

void ShowTodoList()
{
    if (todoList.Count == 0)
    {
        ShowNoToDoMessages();
        return;
    }
    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todoList[i]}");
    }
    return;
}

bool IsDescriptionValid(string description)
{
    if (string.IsNullOrWhiteSpace(description))
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
    if (todoList.Contains(description))
    {
        Console.WriteLine("The description must be unique");
        return false;
    }
    return true;
}

void RemoveToDoAtIndex(int index)
{
    todoList.RemoveAt(index);
    Console.WriteLine($"TODO removed: {todoList[index]}");
}

void ShowNoToDoMessages()
{
    Console.WriteLine("No TODOs have been added yet.");
}

bool TryReadIndex(out int index)
{
    string userInput = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(userInput))
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty.");
        return false;
    }
    else if (!int.TryParse(userInput, out index) || index < 1 || index > todoList.Count)
    {
        Console.WriteLine("The given index is not valid.");
        return false;
    }
    else
    {
        return true;
    }
}