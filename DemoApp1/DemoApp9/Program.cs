// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1. Const interpolated strings demo
Console.WriteLine("--- 1. Const Interpolated Strings ---");
var appName = TestInterpolatedStrings();
Console.WriteLine(appName);
Console.WriteLine();

//2. DateOnly and TimeOnly demo
Console.WriteLine("--- 2. DateOnly and TimeOnly ---");
PrintDates();
Console.WriteLine();

//3. Process Path and Id demo
Console.WriteLine("--- 3. Process Path and Id ---");
ProcessPathAndId();
Console.WriteLine();

//4. New LINQ methods
Console.WriteLine("--- 4. New LINQ methods ---");
NewLinqMethods();
Console.WriteLine();

//5. Throw If Null
Console.WriteLine("--- 5.  Throw If Null ---");
BuggyMethod(null);
Console.WriteLine();

Console.ReadLine();

string TestInterpolatedStrings()
{
    const string appName = "Simple app name";
    const string appVersion = "V1.1";
    const string fullAppName = $"About {appName} {appVersion}";

    return fullAppName;
}

void PrintDates()
{
    var myDate = new DateOnly(2021, 12, 24);
    Console.WriteLine(myDate);
    Console.WriteLine(myDate.ToLongDateString());

    var today = DateOnly.FromDateTime(DateTime.Now);
    Console.WriteLine(today);

    var oneYearFromToday = today.AddYears(1);
    Console.WriteLine(oneYearFromToday);

    var myTime = new TimeOnly(9, 0);
    Console.WriteLine(myTime);

    var startTime = new TimeOnly(10, 0);
    var endTime = new TimeOnly(10, 30, 25);

    var diffTime = endTime - startTime;
    Console.WriteLine(diffTime);
    Console.WriteLine(endTime > startTime);
}

void ProcessPathAndId()
{
    string processPath = Environment.ProcessPath;
    Console.WriteLine(processPath);

    int processId = Environment.ProcessId;
    Console.WriteLine(processId);
}

void NewLinqMethods()
{
    List<string> strings = new List<string>();
    
    strings.Add("alpha");
    strings.Add("bravo");
    strings.Add("charlie");
    strings.Add("delta");
    strings.Add("echo");
    strings.Add("foxtrot");
    strings.Add("golf");
    strings.Add("hotel");
    strings.Add("india");
    strings.Add("juliet");
    strings.Add("kilo");
    strings.Add("lima");
    strings.Add("mike");
    strings.Add("november");
    strings.Add("oscar");
    strings.Add("papa");
    strings.Add("quebec");
    strings.Add("romeo");
    strings.Add("sierra");
    strings.Add("tango");
    strings.Add("uniform");
    strings.Add("victor");
    strings.Add("wiskey");
    strings.Add("x-ray");
    strings.Add("yankee");
    strings.Add("zulu");

    int chunkNumber = 0;
    foreach (string[] chunk in strings.Chunk(3))
    { 
        chunkNumber++;
        Console.WriteLine($"--- Chunk {chunkNumber} ---");
        foreach(var item in chunk)
        {
            Console.WriteLine(item);
        }
    }

    Console.WriteLine();

    List<Employee> employees = new List<Employee>();
    employees.Add(new Employee() { FirstName = "Ivan", LastName = "Ivanov", Age = 29});
    employees.Add(new Employee() { FirstName = "Maria", LastName = "Marinova", Age = 27 });
    employees.Add(new Employee() { FirstName = "Petar", LastName = "Petrov", Age = 25 });
    employees.Add(new Employee() { FirstName = "Kalina", LastName = "Kalinova", Age = 23 });

    var oldest = employees.MaxBy(e => e.Age);
    var youngest = employees.MinBy(e => e.Age);

    Console.WriteLine($"Oldest is {oldest.FirstName} and youngest is {youngest.FirstName}");
}

void BuggyMethod(object obj)
{
    ArgumentNullException.ThrowIfNull(obj);
    Console.WriteLine("Well, I guess it's not null! :)");
}