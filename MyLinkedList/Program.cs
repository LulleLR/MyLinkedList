// Конструктор с одним параметром (число);
/*
MyLinkedList<int> list = new(42);

Console.WriteLine(list.Head);
Console.WriteLine(list.Tail);
Console.WriteLine(list.Count);
*/

// Конструктор копирования; + Не рекурсивный метод доюавленияя нового элемента последним в список; 
/*
MyLinkedList<string> list1 = new();
list1.Add("Chloe");
list1.Add("Max");
list1.Add("Rachel");

MyLinkedList<string> list2 = new(list1);

foreach (var item in list2)
{
    Console.WriteLine(item);
}
*/

// Метод добавления нового элемента в список после элемента с заданным значением;
/*
MyLinkedList<string> list = new();
list.Add("Chloe");
list.Add("Max");
list.Add("Rachel");

list.AddAfter("Max", "Alex");

foreach (var item in list)
{
    Console.WriteLine(item);
}
*/

// Рекурсивный метод удаления n-ного по счету элемента;
/*
MyLinkedList<int> list = new();
list.Add(73);
list.Add(42);
list.Add(37);

list.RecRemoveIndex(1);

foreach (var item in list)
{
    Console.WriteLine(item);
}
*/

// Метод удаления всех элементов с отрицательными значениями;  
/*
MyLinkedList<int> list = new();
list.Add(-3);
list.Add(-9);
list.Add(15);
list.Add(-90);
list.Add(0);

MyLinkedList<int>.RemoveAllNegative(list);

foreach (var item in list)
{
    Console.WriteLine(item);
}
*/

// Рекурсивный метод печати всех целых элементов списка;
/*
MyLinkedList<double> list = new();
list.Add(15);
list.Add(37.8);
list.Add(73);
list.Add(-35);
list.Add(-15.5);
list.Add(0.5);
list.Add(18);

list.PrintIntegers();
*/

// Метод сортировки элементов списка по уменьшению числовых значений;
/*
MyLinkedList<int> list = new();
list.Add(-9);
list.Add(2);
list.Add(72);
list.Add(4);

list.SortByDescending();

foreach (var item in list)
{
    Console.WriteLine(item);
}
*/

// Индексатор с одним параметром, которыйй позволяет по значению элемента найти его порядковий номер в списке;
/*
MyLinkedList<string> list = new();

list.Add("Max");
list.Add("Chloe");
list.Add("Rachel");
list.Add("Sean");
list.Add("Alex");

Console.WriteLine(list["Max"]);
Console.WriteLine(list["Chloe"]);
Console.WriteLine(list["Alex"]);
*/

// Переопределить две любые операции 
/*
Item<int> item1 = new(5);
Item<int> item2 = new(3);

Console.WriteLine(item1 + item2);
Console.WriteLine(item1 - item2);
Console.WriteLine(item1 > item2);
Console.WriteLine(item1 < item2);
*/

// Метод поиска элемента с заданным значением (результат - ссылка на найденный элемент;
/*
MyLinkedList<int> list = new();
list.Add(4);
list.Add(5);
list.Add(73);
list.Add(42);

Item<int> item = list.FindElement(73);

Console.WriteLine(item);
*/

// Метод подсчета произведения положительных элементов в списке (если таких нет, вернуть 1).
/*
MyLinkedList<int> list = new();
list.Add(1);
list.Add(-2);
list.Add(5);
list.Add(3);
list.Add(2);
list.Add(-9);
list.Add(-15);

Console.WriteLine(list.ProductionPozitives());
*/

Console.ReadLine();