using LinkedList;

var list = new MyLinkedList<int>();
list.Add(11);
list.Add(25);
list.Add(14);
list.Add(34);
list.Add(88);
list.Add(90);

Console.Write("List: ");
foreach (var item in list) Console.Write(item.ToString() + " ");
Console.WriteLine();

list.Delete(34);
Console.Write("Delete item 34: ");
foreach (var item in list) Console.Write(item.ToString() + " ");
Console.WriteLine();

list.AppendHead(109);
Console.Write("Append Head 109: ");
foreach (var item in list) Console.Write(item.ToString() + " ");
Console.WriteLine();

list.InsertAfter(90, 4);
Console.Write("Insert After 90 4: ");
foreach (var item in list) Console.Write(item.ToString() + " ");
Console.WriteLine();

list.Clear();
Console.Write("Empty list: ");
foreach (var item in list) Console.Write(item.ToString() + " ");
Console.WriteLine();


var list1 = new MyLinkedList<int>(95);
Console.Write("List with 1 item: ");
foreach (var item in list1) Console.Write(item.ToString() + " ");
Console.WriteLine();
