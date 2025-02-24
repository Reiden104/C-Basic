string name = Console.ReadLine();
int project = int.Parse(Console.ReadLine());
int timeSpended = project * 3;
Console.WriteLine($"The architect {name} will need {timeSpended} " +
    $"hours to complete {project} project/s.");