using System;
using System.Threading;
using static System.Console;
namespace VATSIMControllinggenerator {
    internal static class Program {
        public static void Main() {
            while (true) {
                Clear();
                WriteLine("Select Operation");
                WriteLine();
                WriteLine("1. Clearance Delivery.");
                WriteLine("2. Ground Operations.");
                WriteLine("3. Tower Operations.");
                WriteLine("4. Quit");
                var choice = ReadLine();

                switch (choice) {
                    case "1":
                        Clearance();
                        break;
                    case "2":
                        Ground();
                        break;
                    case "3":
                        Tower();
                        break;

                    case "4":
                        Environment.Exit(1);
                        break;

                    default:
                        WriteLine("Invalid Argument.");
                        Thread.Sleep(2000);
                        continue;
                }

                break;
            }
        }

        private static void Clearance() {
            Clear();
            WriteLine("Enter Callsign");
            var callsign = ReadLine();
            WriteLine("Enter Airport (cleared to) (blank for VFR)");
            var airport = ReadLine();
            WriteLine("Enter Departure Name (First fix for vectors, blank for VFR)");
            var sid = ReadLine();
            WriteLine("Enter Transition (Only for SID)");
            var trans = ReadLine();
            WriteLine("Enter Initial Altitude (Leave blank for VFR)");
            var inital = ReadLine();
            WriteLine("Enter Cruise Altitude");
            var alt = ReadLine();
            WriteLine("Enter departure freq (defaults to 122.8 [UNICOM] )");
            var freq = ReadLine();
            if (freq == "") freq = "122.8";
            WriteLine("Enter Squawk");
            var squawk = ReadLine();
            WriteLine("Enter expected runway");
            var rwy = ReadLine();
            WriteLine("Enter Altimeter");
            var baro = ReadLine();
            WriteLine("Enter ATIS (blank if not up)");
            var atis = ReadLine();
            while (true) {
                Clear();
                WriteLine("Clearance Delivery");
                WriteLine();
                WriteLine("Clearances:");
                WriteLine();
                WriteLine("1. IFR Clearance w/ SID");
                WriteLine("2. IFR Clearance w/ Vectors");
                WriteLine("3. VFR Clearance w/ Flight Following");
                WriteLine("4. VFR Clearance w/o Flight Following");
                WriteLine();
                WriteLine("Readbacks:");
                WriteLine();
                WriteLine("5. Readback Correct w/o ATIS up");
                WriteLine("6. Readback Correct w/ ATIS up (not reported)");
                WriteLine("7. Readback Correct w/ ATIS up (reported)");
                WriteLine("8. Menu.");
                var choice = ReadLine();

                switch (choice) {
                    case "1":
                        WriteLine(
                            $"{callsign} You are cleared to the {airport} airport via the {sid} departure, {trans} transition. Then as filed. \n Climb via SID, maintain {inital}, expect {alt} one zero minutes after departure. \n Departure frequency {freq}. Squawk {squawk}.");
                        break;
                    case "2":
                        WriteLine(
                            $"{callsign} You are cleared to the {airport} airport. Radar vectors {sid}. Then as filed. \n Maintain {inital}, expect {alt} one zero minutes after departure. \n Departure frequency {freq}. Squawk {squawk}.");
                        break;
                    case "3":
                        WriteLine(
                            $"{callsign} Maintain VFR at or below {alt} Departure frequency {freq}, Squawk {squawk}.");
                        break;
                    case "4":
                        WriteLine($"{callsign} Maintain VFR at or below {alt}. Squawk {squawk}.");
                        break;
                    case "5":
                        WriteLine(
                            $"{callsign} Readback correct. Push and start at your discresion. Expect runway {rwy} for departure. Altimeter {baro}.");
                        break;
                    case "6":
                        WriteLine(
                            $"{callsign} Readback correct. Push and start at your discresion. Expect runway {rwy} for departure. ATIS Information {atis} current.");
                        break;
                    case "7":
                        WriteLine(
                            $"{callsign} Readback correct. Push and start at your discresion. Expect runway {rwy} for departure.");
                        break;
                    case "8":
                        Main();
                        break;
                    default:
                        WriteLine("Invalid argument.");
                        Thread.Sleep(2000);
                        Main();
                        break;
                }
                ReadLine();

            }
        }
    

    private static void Ground() {
            Clear();
            WriteLine("Enter Callsign");
            var callsign = ReadLine();
            WriteLine("Enter Runway");
            var rwy = ReadLine();
            WriteLine("Enter taxi route");
            var route = ReadLine();
            WriteLine("Enter hold point (if needed)");
            var hold = ReadLine();

        while (true) {
            Clear();
            WriteLine("Ground Operations");
            WriteLine();
            WriteLine("1. Taxi to Runway w/o holding");
            WriteLine("2. Taxi to Runway w/ holding");
            WriteLine("3. Menu");
            var choice = ReadLine();

            switch (choice) {
                case "1":
                    WriteLine($"{callsign} Runway {rwy}. Taxi via {route}");
                    break;
                case "2":
                    WriteLine(
                        $"{callsign} Runway {rwy} Taxi via {route}, Hold short of {hold} (Add hold short instructions as needed.)");
                    break;
                case "3":
                    Main();
                    break;
                default:
                    WriteLine("Invalid Argument");
                    Thread.Sleep(2000);
                    Main();
                    break;

            }
            ReadLine();
        }
    }

        private static void Tower() {
            Clear();
            WriteLine("Enter Callsign");
            var callsign = ReadLine();
            WriteLine("Enter Runway");
            var rwy = ReadLine();
            WriteLine("Enter Winds (If Needed)");
            var winds = ReadLine();
            WriteLine("Enter Heading (If Needed)");
            var heading = ReadLine();

            while (true) {
                Clear();
                WriteLine("Tower Operations.");
                WriteLine();
                WriteLine("1. Line up and Wait.");
                WriteLine("2. Clear for takeoff");
                WriteLine("3. Clear for takeoff, Fly heading.");
                WriteLine("4. Clear for landing.");

                var choice = ReadLine();

                switch (choice) {
                    case "1":
                        WriteLine($"{callsign}, Runway {rwy}, Line up and wait.");
                        break;
                    case "2":
                        WriteLine($"{callsign}, Winds {winds}, Runway {rwy}, Cleared for takeoff.");
                        break;
                    case "3":
                        WriteLine(
                            $"{callsign}, After departure fly heading {heading}, Winds {winds}, Runway {rwy}, Cleared for takeoff.");
                        break;
                    case "4":
                        WriteLine($"{callsign}, Winds {winds}, Runway {rwy}, Cleared to land.");
                        break;
                    case "5":
                        Main();
                        break;
                    default:
                        WriteLine("Invalid Argument.");
                        Thread.Sleep(2000);
                        Main();
                        break;

                }
                ReadLine();

            }



        }
    }
}