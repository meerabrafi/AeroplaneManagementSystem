using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace projectfinal1.Flight
{
    internal class FlightModel
    {


        private int flight_no;
        private string destination;
        private string source;
        private float ticket_price;
        private string travel_class;
        public FlightModel()
        {

        }
             public FlightModel(int flight_no, string destination,
            float ticket_price, string source, string travel_class)
        {




            this.flight_no = flight_no;
            this.destination = destination;
            this.ticket_price = ticket_price;
            this.source = source;
            this.travel_class = travel_class;


        }
        public void SetFlightNumber(int flight_no)
        {
            this.flight_no = flight_no;

        }
        public int GetFlightNumber()
        {
            return this.flight_no;
        }
        


        public void SetDestination(string destination)
        {
            this.destination = destination;
        }
        public string GetDestination()
        {
            return this.destination;
        }
        public void SetTicketPrice(float ticket_price)
        {
            this.ticket_price = ticket_price;
        }
        public float GetTicketPrice()
        {
            return this.ticket_price;
        }
        public void SetSource(string source)
        {
            this.source = source;
        }
        public string GetSource()
        {
            return this.source;
        }
        public void SetTravelClass(string travel_class)
        {
            this.travel_class = travel_class;
        }
        
        public string GetTravelClass()
        {
            return this.travel_class;
        }
        public override string ToString()
        {
             
            return $"{flight_no},{destination},{ticket_price},{source},{travel_class}";
        }

    }
}
