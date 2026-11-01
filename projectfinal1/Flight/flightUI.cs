using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;

namespace projectfinal1.Flight
{
    internal class FlightUI
    {
        private FlightService service = new FlightService();
        public void flightDriver()
        {
            while (true)
            {
                string option = FlightMenu();
                if (option == "1")
                {
                    FlightModel flight = TakeInput();
                    service.AddFlight(flight);
                    Console.WriteLine("Flight Added Successfully.....");
                }
                else if (option == "2")
                {
                    DisplayAll();
                }

                else if (option == "3")
                {
                    SearchFlight();
                }

                else if (option == "4")
                {
                    UpdateFlights();
                }

                else if (option == "5")
                {
                    SortFlights();
                }
                else if (option == "6")
                {
                    break;
                }
            }
        }
        public void DisplayAll()
        {
            List<FlightModel> flights = service.GetAllData();
            foreach (FlightModel flight in flights)
            {
                Console.WriteLine(flight.ToString());
            }
            Console.ReadKey();
        }
        public void SearchFlight()
        {
            Console.WriteLine("Enter flight Number ");
            int flight_no = int.Parse(Console.ReadLine());
            FlightModel flight = service.SearchByFlightNo(flight_no);
            if (flight != null)
            {
                Console.WriteLine(flight.ToString());

            }
            else
            {
                Console.WriteLine("Flight not Found !");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    
    public void UpdateFlights()
        {
            Console.WriteLine("Enter Flight number:  ");
            int flight_no = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Ticket price : ");
            float price = float.Parse(Console.ReadLine());

            bool updated = service.Updateflight(flight_no, price);

            if (updated)
            {
                Console.WriteLine("Flight UpDated Successfully...! ");
            }
            else
            {
                Console.WriteLine("Flight not found...!");
            }
        }
        
    
    public void SortFlights()
        {
            service.SortFlightsByPrice();
            Console.WriteLine(" Flights sorted by Ticket Price .");
            DisplayAll();
        }

    public FlightModel TakeInput()
        {
            Console.WriteLine(" Enter Flight Number :");
            int flight_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Destination :");
            string destination = Console.ReadLine();
            Console.WriteLine("Enter ticket Price ");
            float tickt_price = float.Parse(Console.ReadLine());
            Console.WriteLine(" Enter Source ");
            string source = Console.ReadLine();
            Console.WriteLine("Enter travel claSs :");
            string travel_class = Console.ReadLine();
            FlightModel flight = new FlightModel(flight_no, destination, tickt_price, source, travel_class);
            return flight;

        }

        public string FlightMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("----Flight Management---------");
            Console.WriteLine("------------------------------");
            Console.WriteLine(" 1.Add new flights");
            Console.WriteLine("2. View All Flights");
            Console.WriteLine("3. Search Flight By Number");
            Console.WriteLine("4. Update Flight Price");
            Console.WriteLine("5. Sort Flights By Ticket Price");
            Console.WriteLine("6. Back to Main Menu");
            Console.WriteLine("Enter your choice :");
            string option = Console.ReadLine();
            return option;
        }

















    }
}



            