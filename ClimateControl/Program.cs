using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClimateControl.ClientSide;
using ClimateControl.ClimateControl;

namespace ClimateControl
{
    class Program
    {
        static readonly Application Application = new Application();

        static void Main(string[] args)
        {
            Console.WriteLine("Climate Control Application is running...");
            Console.WriteLine("Select an action:");
            Console.WriteLine("(1) Get current climate info");
            Console.WriteLine("(2) Request temperature change");
            Console.WriteLine("(3) Request brightness change");
            Console.WriteLine("(4) Request humidity change");
            Console.WriteLine("(5) Choose a preset");

            while (true)
            {
                string input = Console.ReadLine();

                try
                {
                    switch (input)
                    {
                        case "1":
                            Console.WriteLine(Application.NotifyOfClimate());
                            break;
                        case "2":
                            Console.Write("Enter new temperature: ");
                            Application.ChangeTemperature(new Temperature(int.Parse(Console.ReadLine() ?? throw new ArgumentNullException())));
                            Console.WriteLine(Application.NotifyOfClimate());
                            break;
                        case "3":
                            Console.Write("Enter new brightness: ");
                            Application.ChangeBrightness(new Brightness(int.Parse(Console.ReadLine() ?? throw new ArgumentNullException())));
                            Console.WriteLine(Application.NotifyOfClimate());
                            break;
                        case "4":
                            Console.Write("Enter new humidity: ");
                            Application.ChangeHumidity(new Humidity(int.Parse(Console.ReadLine() ?? throw new ArgumentNullException())));
                            Console.WriteLine(Application.NotifyOfClimate());
                            break;
                        case "5":
                            Console.Write("Choose a preset: ");
                            foreach (Preset p in new Database.Database().GetPresets())
                            {
                                Console.WriteLine(p);
                            }
                            Application.SelectPreset(Console.ReadLine());
                            Console.WriteLine(Application.NotifyOfClimate());
                            break;
                        default: throw new InvalidOperationException();
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success.");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"There was an exception: {e.GetType()}");
                    Console.WriteLine($"Message: \"{e.Message}\"");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}
