
using Nox.Solution;

var solution = new NoxSolutionBuilder()
    .Build();

Console.WriteLine($"Solution Name: {solution.Name}");
Console.WriteLine($"Solution Description: {solution.Description}");
Console.WriteLine();
Console.WriteLine("Domain");
foreach (var entity in solution.Domain!.Entities)
{
    Console.WriteLine($"Entity: {entity.Name} ({entity.Description})");    
}
