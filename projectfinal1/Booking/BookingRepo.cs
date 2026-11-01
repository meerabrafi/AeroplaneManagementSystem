using System;

using System.Collections.Generic;

using System.IO;

namespace projectfinal1.Booking

{

    internal class BookingRepo

    {

        private string file = "bookings.txt";

        public void SaveInFile(BookingModel booking)

        {

            using (StreamWriter stream = new StreamWriter(file, true))

            {

                stream.WriteLine(booking.ToString());

            }

        }

        public void SaveAllDataIntoFile(List<BookingModel> bookings)

        {

            File.WriteAllText(file, "");

            foreach (BookingModel booking in bookings)

{

                SaveInFile(booking);

            }

        }

        public List<BookingModel> GetBookingsFromFile()

        {

            List<BookingModel> bookingModels = new List<BookingModel>();

            if (File.Exists(file))

            {

                using (StreamReader stream = new StreamReader(file))

                {

                    string line = "";

                    while ((line = stream.ReadLine()) !=null)
                    
{

                        string[] parts = line.Split(',');

                        int BookingId = int.Parse(parts[0]);

                        string BookingStatus = parts[1];

                        string BookingDate = parts[2];

                        BookingModel booking = new BookingModel(

                        BookingId, BookingStatus, BookingDate);

                        bookingModels.Add(booking);

                    }

                }

            }

            return bookingModels;

        }

    }

}