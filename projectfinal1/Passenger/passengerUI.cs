using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace projectfinal1.Passenger
{
    internal class passengerUI
    {
        
        public void PassengerDriver()
        {
            while (true)
            {
                string option = PassengerMenu();
                if (option == "1")
                {
                    PassengerModel passenger = TakeInput();
                    service.AddPassenger(passenger);
                }
                else if (option == "2")
                {
                    DisplayAll();

                }
                else if (option == "3")
                {
                    SearchPassenger();
                }
                else if (option == "4") {

                    UpdatePassenger();
                }
                else if (option == "5")
                {
                    DeletePassenger();
                }
                else if (option == "6")
                {
                    ShowTotalpassengers();
                }
                
                else if (option == "7")
                {
                    CountGender();
                }
                else if (option == "8")
                {
                    ResetDatabase();
                }
                else if (option == "9")
                {

                    pagesUI();


                }
                else if (option == "10")
                {
                    quickFilter();
                }
                else if ( option == "11")
                {
                    break;
                }
            }
        }
        private PassengerService service = new PassengerService();

        public void DisplayAll()
        {
            List<PassengerModel> passengers = service.ViewAllPassengers();

            foreach (PassengerModel passenger in passengers)
            {
                Console.WriteLine(passenger.ToString());
            }

            Console.ReadKey();
        }
        public void SearchPassenger()
        {
            Console.WriteLine("Enter Passport Number:");
            string passportNumber = Console.ReadLine();

            PassengerModel passenger = service.SearchByPassport(passportNumber);

            if (passenger != null)
            {
                Console.WriteLine(passenger.ToString());
            }
            else
            {
                Console.WriteLine("Passenger Not Found!");
            }

            Console.ReadKey();
        }

        
        public void UpdatePassenger()
        {
            Console.WriteLine("Enter Passport Number:");
            string passportNumber = Console.ReadLine();

            Console.WriteLine("Enter New Name:");
            string name = Console.ReadLine();

            bool updated = service.UpdatePassenger(passportNumber, name);

            if (updated == true)
            {
                Console.WriteLine("Passenger Updated Successfully!");
            }
            else
            {
                Console.WriteLine("Passenger Not Found!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void DeletePassenger()
        {
            Console.WriteLine("Enter Passport Number:");
            string passportNumber = Console.ReadLine();

            bool deleted = service.DeletePassenger(passportNumber);

            if (deleted == true)
            {
                Console.WriteLine("Passenger Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Passenger Not Found!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void ShowTotalpassengers()
        {
            int total = service.ShowTotalpassengers();

            Console.WriteLine("Total Passengers: " + total);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void CountGender()
        {
            service.countmalefemalePassengers();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void ResetDatabase()
        {
            service.resetDatabase();

            Console.WriteLine("Database Reset Successfully!");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public void pagesUI()
        {


            Console.WriteLine("  How many records to show on one page : !");
            int records = int.Parse(Console.ReadLine());
            Console.WriteLine(" Please enter N  for the next page  :");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(" Please Enter P for the previous page: ");
            char ch1 = char.Parse(Console.ReadLine());
            Console.WriteLine(" Please Enter P for the previous page: ");
            char ch2 = char.Parse(Console.ReadLine());
            Console.WriteLine(" Please Enter L for the Last page : ");
            char ch3 = char.Parse(Console.ReadLine());
            Console.WriteLine(" Enter X to exit : ");
            char ch4 = char.Parse(Console.ReadLine());
            if (service.pagecontent(int count ))
            {
                Console.WriteLine(" Total records is 12");

            }
        }
        public void quickfilter()
        {
            service.quickFilter();
            }
          
       

        public void BacktoMainMenu()
        {
            service.BacktoMainMenu();
        }
         
        public PassengerModel TakeInput()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine(" Enter Age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter gender :");
            string gender = Console.ReadLine();
            Console.WriteLine(" Enter passportNumber :");
            string passportNumber = Console.ReadLine();
            Console.WriteLine("Enter Seat Preference:");
            string seat_preference = Console.ReadLine();
            Console.WriteLine(" Enter meal_preference :");
            string meal_preference = Console.ReadLine();
            PassengerModel passenger = new PassengerModel(
       name, age, gender, passportNumber, 
        seat_preference,
       meal_preference);
            return passenger;

        }
        public string  PassengerMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("          PASSENGER MANAGEMENT          ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" 1. Add New Passenger  ");
            Console.WriteLine(" 2. View All Passengers ");
            Console.WriteLine(" 3. Search Passenger By Passport ");
            Console.WriteLine(" 4. Update Passenger");
            Console.WriteLine(" 5. Delete Passenger");
            Console.WriteLine(" 6. Show Total Passengers");
            Console.WriteLine(" 7. Count Male and Female Passengers");
            Console.WriteLine(" 8. Reset Database");
            Console.WriteLine(" 9.-------Paginated view ------- ");
            Console.WriteLine("10 quick filter  ");
            Console.WriteLine(" 11. Back to Main Menu");
            
            Console.Write("Enter your choice: ");
            Console.ForegroundColor = ConsoleColor.White;
            string option = Console.ReadLine();
            return option;



        }
    }
}
