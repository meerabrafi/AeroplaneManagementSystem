using System;
using System.Collections.Generic;

namespace projectfinal1.Booking
{
    internal class BookingUI
    {
        private BookingService service = new BookingService();

        public void BookingDriver()
        {
            while (true)
            {
                string option = BookingMenu();

                if (option == "1")
                {
                    BookingModel booking = TakeInput();
                    service.AddBooking(booking);
                    Console.WriteLine("Booking Added Successfully...!");
                }
                else if (option == "2")
                {
                    DisplayAll();
                }
                else if (option == "3")
                {
                    SearchBooking();
                }
                else if (option == "4")
                {
                    UpdateStatus();
                }
                else if (option == "5")
                {
                    DisplayConfirmedBookings();
                }
                else if (option == "6")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option...!");
                }
            }
        }

        public void DisplayAll()
        {
            List<BookingModel> bookings = service.GetAllData();

            if (bookings.Count == 0)
            {
                Console.WriteLine("No Bookings Found!");
            }
            else
            {
                foreach (BookingModel booking in bookings)
                {
                    Console.WriteLine(booking.ToString());
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void SearchBooking()
        {
            Console.WriteLine("Enter Booking ID:");
            int booking_id = int.Parse(Console.ReadLine());

            BookingModel booking = service.SearchByBookingId(booking_id);

            if (booking != null)
            {
                Console.WriteLine(booking.ToString());
            }
            else
            {
                Console.WriteLine("Booking Not Found!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void UpdateStatus()
        {
            Console.WriteLine("Enter Booking ID:");
            int booking_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter New Booking Status:");
            string status = Console.ReadLine();

            bool updated = service.UpdateBookingStatus(booking_id, status);

            if (updated)
            {
                Console.WriteLine("Booking Status Updated Successfully..");
            }
            else
            {
                Console.WriteLine("Booking Not Found..!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void DisplayConfirmedBookings()
        {
            List<BookingModel> bookings = service.GetConfirmedBookings();

            if (bookings.Count > 0)
            {
                foreach (BookingModel booking in bookings)
                {
                    Console.WriteLine(booking.ToString());
                }
            }
            else
            {
                Console.WriteLine("No Confirmed Bookings Found!");
            }

            Console.ReadKey();
        }
        public BookingModel TakeInput()
        {
            Console.WriteLine("Enter Booking ID:");
            int booking_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Booking Status:");
            string status = Console.ReadLine();

            Console.WriteLine("Enter Booking Date:");
            string date = Console.ReadLine();

            BookingModel booking = new BookingModel(booking_id, status, date);

            return booking;
        }

        public string BookingMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("-------BOOKING MANAGEMENT-----");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1. Add New Booking");
            Console.WriteLine("2. View All Bookings");
            Console.WriteLine("3. Search Booking By ID");
            Console.WriteLine("4. Update Booking Status");
            Console.WriteLine("5. View Confirmed Bookings");
            Console.WriteLine("6. Back to Main Menu");
            Console.WriteLine("Enter Your Choice:");

            string option = Console.ReadLine();

            return option;
        }
    }
}


