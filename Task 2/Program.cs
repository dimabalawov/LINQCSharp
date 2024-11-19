List<string> cities = new List<string>() { "Berlin", "Andorra", "Kyiv", "Prague", "London", "Teram", "Nelok", "Nezhin" };

var linq1 = from c in cities
            select c;
Console.WriteLine("LINQ1:");
foreach (var city in linq1)
    Console.WriteLine(city);

var ext1 = cities.Select(c => c);
Console.WriteLine("EXT1:");
foreach (var city in ext1)
    Console.WriteLine(city);

var linq2 = from c in cities
            where c.Length == 6
            select c;
Console.WriteLine("LINQ2:");
foreach (var city in linq2)
    Console.WriteLine(city);

var ext2 = cities.Where(c => c.Length == 6);
Console.WriteLine("EXT2:");
foreach (var city in ext2)
    Console.WriteLine(city);

var linq3 = from c in cities
            where c[0] == 'A'
            select c;
Console.WriteLine("LINQ3:");
foreach (var city in linq3)
    Console.WriteLine(city);
var ext3 = cities.Where(c => c[0] == 'A');
Console.WriteLine("EXT3:");
foreach (var city in ext3)
    Console.WriteLine(city);

var linq4 = from c in cities
            where c[c.Length - 1] == 'm'
            select c;
Console.WriteLine("LINQ4:");
foreach (var city in linq4)
    Console.WriteLine(city);

var ext4 = cities.Where(c => c[c.Length - 1] == 'm');
Console.WriteLine("EXT4:");
foreach (var city in ext4)
    Console.WriteLine(city);

var linq5 = from c in cities
            where c[0] == 'N'
            where c[c.Length - 1] == 'k'
            select c;
Console.WriteLine("LINQ5:");
foreach (var city in linq5)
    Console.WriteLine(city);

var ext5 = cities.Where(c => c[0] == 'N' && c[c.Length - 1] == 'k');
Console.WriteLine("EXT5:");
foreach (var city in ext5)
    Console.WriteLine(city);

var linq6 = from c in cities
            where c[0] == 'N'
            where c[1] == 'e'
            orderby c descending
            select c;
Console.WriteLine("LINQ6:");
foreach (var city in linq6)
    Console.WriteLine(city);

var ext6 = cities.Where(c => c[0] == 'N' && c[1] == 'e').OrderByDescending(c => c);
Console.WriteLine("EXT6:");
foreach (var city in ext6)
    Console.WriteLine(city);