
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
namespace projectfinal1.Flight
{
    internal class flightrepo
    {

        private string file = "flights.txt";
        public void SaveInFile(FlightModel flight)
        {

            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(flight.ToString());
            }

        }
        public void SaveAllDataIntoFile(List<FlightModel> flights)
        {
            File.WriteAllText(file, "");
            foreach (var flight in flights)
            {
                SaveInFile(flight);
            }


        }
        public List<FlightModel> GetFlightsFromFile()
        {
            List<FlightModel> flightModels = new List<FlightModel>();

            if (File.Exists(file))
            {
                using (StreamReader stream = new StreamReader(file))
                {
                    string line = "";
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');



                        int flight_no = int.Parse(parts[0]);
                        string destination = parts[1];
                        float ticket_price = float.Parse(parts[2]);
                        string source = parts[3];
                        string travel_class = parts[4];

                        FlightModel flight = new FlightModel(flight_no, destination, ticket_price, source, travel_class);
                        flightModels.Add(flight);






                    }


                }
            }
            return flightModels;


        }
    }

}