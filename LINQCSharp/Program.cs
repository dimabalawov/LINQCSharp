int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


var linq1 = from i in arr
            select i;
Console.WriteLine("LINQ1:");
foreach (var item in linq1)
    Console.WriteLine(item);


var ext1 = arr.Select(i => i);
Console.WriteLine("EXT1:");
foreach (var item in ext1)
    Console.WriteLine(item);


var linq2 = from i in arr
            where i % 2 == 0
            select i;
Console.WriteLine("LINQ2:");
foreach (var item in linq2)
    Console.WriteLine(item);

var ext2 = arr.Where(i => i % 2 == 0);
Console.WriteLine("EXT2:");
foreach (var item in ext2)
    Console.WriteLine(item);


var linq3 = from i in arr
            where i % 2 == 1
            select i;
Console.WriteLine("LINQ3:");
foreach (var item in linq3)
    Console.WriteLine(item);


var ext3 = arr.Where(i => i % 2 == 1);
Console.WriteLine("EXT3:");
foreach (var item in ext3)
    Console.WriteLine(item);

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());


var linq4 = from i in arr
            where i > num
            select i;
Console.WriteLine("LINQ4:");
foreach (var item in linq4)
    Console.WriteLine(item);


var ext4 = arr.Where(i => i > num);
Console.WriteLine("EXT4:");
foreach (var item in ext4)
    Console.WriteLine(item);

Console.WriteLine("Enter the start: ");
int start = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the finish: ");
int end = int.Parse(Console.ReadLine());


var linq5 = from i in arr
            where i > start && i < end
            select i;
Console.WriteLine("LINQ5:");
foreach (var item in linq5)
    Console.WriteLine(item);


var ext5 = arr.Where(i => i > start && i < end);
Console.WriteLine("EXT5:");
foreach (var item in ext5)
    Console.WriteLine(item);


var linq6 = from i in arr
            where i % 7 == 0
            orderby i ascending
            select i;
Console.WriteLine("LINQ6:");
foreach (var item in linq6)
    Console.WriteLine(item);

var ext6 = arr.Where(i => i % 7 == 0).OrderBy(i => i);
Console.WriteLine("EXT6:");
foreach (var item in ext6)
    Console.WriteLine(item);

var linq7 = from i in arr
            where i % 7 == 0
            orderby i descending
            select i;
Console.WriteLine("LINQ7:");
foreach (var item in linq7)
    Console.WriteLine(item);

var ext7 = arr.Where(i => i % 7 == 0).OrderByDescending(i => i);
Console.WriteLine("EXT7:");
foreach (var item in ext7)
    Console.WriteLine(item);