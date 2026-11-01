using projectfinal1.Admin;
using projectfinal1.Booking;
using projectfinal1.Flight;
using projectfinal1.Passenger;

internal class aeroplane
{
    public void Start()
    {
        while (true)
        {
            string option = MainMenu();
            if (option == "1")
            {
                // Option 1 dabane par Passenger UI chalegi
                passengerUI UI = new passengerUI();
                UI.PassengerDriver();
            }
            else if (option == "2")
            {
                FlightUI UI = new FlightUI();
                UI.flightDriver();

            }
            else if (option == "3")
            {
                BookingUI Ui = new BookingUI();
                Ui.BookingDriver();
            }
            else if (option == "4")
            {
                AdminUI Ui= new AdminUI();
                Ui.AdminDriver();
            }
            else if (option == "5")
            {
                Console.Clear();
                return;
            }
        }
    }

    public string MainMenu()
    {
        Console.Clear();
        Console.WriteLine(" ------------------------------ ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" AEROPLANE  MANAGEMENT  SYSTEM  ");
        Console.ResetColor();
        Console.WriteLine(" ------------------------------ ");
        Console.WriteLine(" 1. Passenger Management ");
        Console.WriteLine(" 2. Flight Management ");
        Console.WriteLine(" 3. Ticket Booking ");
        Console.WriteLine(" 4. Admin Panel ");
        Console.WriteLine(" 5. Exit ");
        Console.Write(" Select Option: ");

        return Console.ReadLine();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        aeroplane plane = new aeroplane();
        plane.Start();
    }
}
