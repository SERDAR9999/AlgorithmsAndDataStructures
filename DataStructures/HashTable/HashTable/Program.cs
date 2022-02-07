//Класс Hashtable предназначен для создания коллекции, в которой для хранения ее элементов служит хеш-таблица.
//Информация сохраняется в хеш-таблице с помощью механизма, называемого хешированием.
//При хешировании для определения уникального значения, называемого хеш-кодом, используется информационное содержимое
//специального ключа. Полученный в итоге хеш-код служит в качестве индекса, по которому в таблице хранятся искомые данные,
//соответствующие заданному ключу. Преобразование ключа в хеш-код выполняется автоматически,
//и поэтому сам хеш-код вообще недоступен пользователю. Преимущество хеширования заключается в том, что оно обеспечивает
//постоянство времени выполнения операций поиска, извлечения и установки значений независимо от величины массивов данных.


//Хеш-таблица (hash table) — это специальная структура данных для хранения пар ключей и их значений.
//По сути это ассоциативный массив, в котором ключ представлен в виде хеш-функции.

//Пожалуй, главное свойство hash-таблиц — все три операции:
//вставка, поиск и удаление — в среднем выполняются за время O(1),
//среднее время поиска по ней также равно O(1) и O(n) в худшем случае.


using HashTable;

var badHashTable = new BadHashTable<int>(100);
badHashTable.Add(5);
badHashTable.Add(18);
badHashTable.Add(777);

Console.WriteLine(badHashTable.Search(6));
Console.WriteLine(badHashTable.Search(18));


Console.WriteLine();
var hashTable = new HashTable<int, string>(100);
hashTable.Add(5, "Привет");
hashTable.Add(18, "Мир");
hashTable.Add(777, "Здравствуй");
hashTable.Add(7, "Программист");

Console.WriteLine(hashTable.Search(6, "Вася"));
Console.WriteLine(hashTable.Search(18, "Мир"));
Console.WriteLine(hashTable.Search(777, "Здравствуй"));


Console.WriteLine();
var superHashTable = new SuperHashTable<Person>(100);
superHashTable.Add(new Person("Вася", 25, 0));
superHashTable.Add(new Person("Петя", 35, 0));
superHashTable.Add(new Person("Андрей", 15, 0));
superHashTable.Add(new Person("Катя", 18, 1));
var person = new Person("Вася", 25, 0);
superHashTable.Add(person);

Console.WriteLine(superHashTable.Search(new Person("Вася", 25, 0)));
Console.WriteLine(superHashTable.Search(person));


Console.WriteLine();
var hashTable2 = new HashTable<int, Person>(100);
var person1 = new Person("Вася", 25, 0) { Id = 1};
var person2 = new Person("Вася", 25, 0) { Id = 2};
var person3 = new Person("Вася", 25, 0) { Id = 2};
hashTable2.Add(person1.Id, person1);
hashTable2.Add(person2.Id, person2);
hashTable2.Add(person3.Id, person3);

Console.WriteLine(hashTable2.Search(person1.Id, person1));
Console.WriteLine(hashTable2.Search(25, person1));
Console.WriteLine(hashTable2.Search(15, person1));


Console.ReadLine();
