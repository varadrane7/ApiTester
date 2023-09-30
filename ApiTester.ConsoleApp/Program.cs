using System;
using Spectre.Console;

class Program
{
  static void Main()
  {
    var mainMenu = new SelectionPrompt<string>()
        .Title("Api Tester Main Menu")
        .PageSize(10)
        .AddChoices(new[]
        {
                "Start a new test",
                "View previous tests",
                "Generate report",
                "Exit"
        });

    while (true)
    {
      var selectedOption = AnsiConsole.Prompt(mainMenu);
      switch (selectedOption)
      {
        case "Start a new test":
          // Call the method to start a new test
          break;
        case "View previous tests":
          // Call the method to view previous tests
          break;
        case "Generate report":
          // Call the method to generate a report
          break;
        case "Exit":
          return;
        default:
          AnsiConsole.WriteException(new Exception("Invalid choice"));
          break;
      }
    }
  }
}
