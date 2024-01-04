List<string> list = new List<string>();
list.Add("Hallo");
list.Add("Welt");
list.Add("!");

Console.WriteLine(list[1]);
list.RemoveAt(1);
list.Clear();

List<object> list2 = new List<object>();
list2.Add("Hallo Welt!");
list2.Add(1);
list2.Add(new Exception());