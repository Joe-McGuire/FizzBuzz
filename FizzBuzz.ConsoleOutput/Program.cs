using FizzBuzz.ConsoleOutput;
using FizzBuzz.Logic;
using Microsoft.Extensions.Configuration;

(int start, int end) = GetFizzBuzzSettings();

IFizzBuzzOutput output = new FizzBuzzConsoleWriter();

FizzBuzzIterator.DoFizzBuzzRange(start, end, output);

Console.ReadLine();

static (int start, int end) GetFizzBuzzSettings()
{
    IConfiguration configuration = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                             .Build();

    IConfigurationSection fizzBuzzSettings = configuration.GetSection("FizzBuzz");

    return (fizzBuzzSettings.GetValue("Start", 0), fizzBuzzSettings.GetValue("End", 100));
}