using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Text;

namespace projectfinal1.Passenger
{
    internal class PassengerService
    {
        private PassengerRepository _repo = new PassengerRepository();

        public PassengerService()
        {

        }
        public List<PassengerModel> GetAllData()
        {
            return _repo.GetPassengersFromFile();
        }
        public void SavePassenger(PassengerModel passenger)
        {
            _repo.SaveInFile(passenger);
        }

        public bool AddPassenger(PassengerModel passenger)
        {
            List<PassengerModel> passengers = _repo.GetPassengersFromFile();
            passengers.Add(passenger);
            _repo.SaveAllDataIntoFile(passengers);
            return true;
        }
        public List<PassengerModel> ViewAllPassengers()
        {
            List<PassengerModel> passengers = _repo.GetPassengersFromFile();
            return passengers;
        }
        public PassengerModel SearchByPassport(string passportNumber)
        {
            List<PassengerModel> passengers = _repo.GetPassengersFromFile();

            foreach (PassengerModel passenger in passengers)
            {
                if (passenger.GetPassportNumber() == passportNumber)
                {
                    return passenger;
                }
            }

            return null;
        }


        public bool UpdatePassenger(string passportNumber, string name)
        {
            List<PassengerModel> passengers = _repo.GetPassengersFromFile();
            bool updated = false;
            foreach (PassengerModel passenger in passengers)
            {
                if (passenger.GetPassportNumber() == passportNumber)
                {
                    passenger.SetName(name);
 
                    _repo.SaveAllDataIntoFile(passengers);
                    return true;
                }
            }
            return false;
        }
        public bool DeletePassenger(string passportNumber)
        {
            List<PassengerModel> passengers = _repo.GetPassengersFromFile();
            int count = 0;
            foreach (PassengerModel passenger in passengers)
            {
                if (passenger.GetPassportNumber() == passportNumber)
                {
                    passengers.RemoveAt(count);
                    _repo.SaveAllDataIntoFile(passengers);




                    return true;
                }
                count++;
            }
            return false;
        }
        public int ShowTotalpassengers()
        {
            List<PassengerModel> passengers = _repo.GetPassengersFromFile();

            return passengers.Count;
        }
        public void countmalefemalePassengers()
        {
            int male = 0;
            int female = 0;
            foreach (PassengerModel passenger in _repo.GetPassengersFromFile())
            {
                if (passenger.GetGender() == "Male")
                {
                    male++;

                }
                else if (passenger.GetGender() == "Female")
                {
                    female++;
                }

            }
            Console.WriteLine(" Male " + male);
            Console.WriteLine(" Female " + female);
        }

       
        public void resetDatabase()
        {
            List<PassengerModel> passengers = _repo.GetPassengersFromFile();
            passengers.Clear();


        }
        public void pages(int records, char ch, char ch2, char ch3, char ch4)
        {

            Console.WriteLine("Executed sucessfully");




        else {
               Console.WriteLine("not Executed sucessfully");
               Console.ReadKey();


           }
       }
        
        
     
        public void pagecontent (int count)
        {
            List<PassengerModel> passengers = _repo.GetPassengersFromFile();
            if (passengers.Count > 1)
            {
                Console.WriteLine(" Open the next page .");



            }
        }
        public void quickFilter( )
        {

           List<PassengerModel> passengers = _repo.GetPassengersFromFile();
            foreach (PassengerModel passenger in _repo.GetPassengersFromFile())
               if (passenger. GetSeatPreference() == " middle " && passenger.GetAge() > 20)
           {
                    Console.WriteLine("SeatPreference " + passenger.GetSeatPreference() + " Age " + passenger.GetAge());





        //    }

                    //}

        public string BacktoMainMenu()
        {
            return "0";
        }
    }
}