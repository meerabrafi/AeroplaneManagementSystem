

using System;
using System.Collections.Generic;
using System.Text;

namespace projectfinal1.Flight
{
    internal class FlightService
    {
        private flightrepo _repo = new flightrepo();
        public FlightService()
        {

        }
        public List<FlightModel> GetAllData()
        {
            return _repo.GetFlightsFromFile();
        }
        public bool AddFlight(FlightModel flight)
        {
            List<FlightModel> flights = _repo.GetFlightsFromFile();
            flights.Add(flight);
            _repo.SaveAllDataIntoFile(flights);
            return true;
        }
        public FlightModel SearchByFlightNo(int flight_no)
        {
            List<FlightModel> flights = _repo.GetFlightsFromFile();
            foreach (FlightModel flight in flights)
            {
                
                if (flight.GetFlightNumber() == flight_no)
                {
                    return flight ;
                }
            }
            return null;


        }
        public void SortFlightsByPrice()
        {
            List<FlightModel> flights = _repo.GetFlightsFromFile();
            for (int i=0; i < flights.Count - 1; i++)
            {
                for (int j = 0; j < flights.Count-1; j++)
                {
                    if (flights[j].GetTicketPrice() > flights[j + 1].GetTicketPrice())
                    {

                        FlightModel temp = flights[j];
                        flights[j] = flights[j + 1];
                        flights[j + 1] = temp;
                    }
                }
            }
            _repo.SaveAllDataIntoFile(flights);
        }
        public bool Updateflight(int flight_no,float price)
        {
            List<FlightModel> flights = _repo.GetFlightsFromFile();
            bool updated = false;
            foreach (FlightModel flight in flights)
            {
                if (flight.GetFlightNumber() == flight_no)
                {
                    flight.SetTicketPrice(price);

                    _repo.SaveAllDataIntoFile(flights);
                    return true;
                }
            }
            return false;
        }


    }
}
