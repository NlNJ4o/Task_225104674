using Cse111Task1;

var list = new StudentList();

void Report(int step, string call)
{
    Console.Write($"Step {step} {call,-14} line: ");
    list.Print();
    string first = list.First == null ? "null" : list.First.Id.ToString();
    string last = list.Last == null ? "null" : list.Last.Id.ToString();
    Console.WriteLine($"        first={first} last={last} count={list.Count}");
}

Report(0, "start");
list.AddFront(20); Report(1, "AddFront(20)");
list.AddFront(10); Report(2, "AddFront(10)");
list.AddEnd(30); Report(3, "AddEnd(30)");
list.AddEnd(40); Report(4, "AddEnd(40)");
list.Reverse(); Report(5, "Reverse()");
list.Remove(20); Report(6, "Remove(20)");