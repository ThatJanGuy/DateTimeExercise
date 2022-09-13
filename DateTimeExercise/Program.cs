using DateTimeExercise;

List<Person> people = new List<Person>();

while (true)
{
    int? id = null;
    string? name = String.Empty;
    DateTime? dateOfBirth = null;
    bool exit = false;

    Console.Clear();
    LittleHelpers.MakeHeading("Let's make a person! (Enter 'exit' to abort)");
    
    Console.WriteLine("Please Enter the following data.");

    while (!id.HasValue)
    {   
        Console.Write("ID".PadRight(15) + "> ");
        id = LittleHelpers.GetInt(out exit);
        if (exit == true) break;
    }
    if (exit == true) break;

    while (string.IsNullOrEmpty(name))
    {
        Console.Write("Name".PadRight(15) + "> ");
        name = LittleHelpers.GetString(out exit);
        if (exit == true) break;
    }
    if (exit == true) break;

    while (dateOfBirth == null)
    {
        Console.Write("Date of birth".PadRight(15) + "> ");
        dateOfBirth = LittleHelpers.GetDateTime(out exit);
        if (exit == true) break;
    }
    if (exit == true) break;

    people.Add(new(id, name, dateOfBirth));
}

Console.Clear();
LittleHelpers.MakeHeading("Date of birth".PadRight(15) + "ID".PadRight(5) + "Name".PadRight(10));

List<Person> peopleOutput = people.OrderBy(person => person.DateOfBirth).ToList();

 foreach(Person p in peopleOutput)
{
    Console.WriteLine(Convert.ToDateTime(p.DateOfBirth).ToString("yyyy-MM-dd").PadRight(15) + p.Id.ToString().PadRight(5) + p.Name.ToString().PadRight(10));
}
Console.WriteLine();
Console.WriteLine("Press any key to exit");
Console.ReadKey();