using System;
using System.Collections.Generic;
using System.IO;

namespace projectfinal1.Booking
{
    internal class BookingService
    {
        public BookingRepo _repo = new BookingRepo();

        public BookingService()
        {

        }

        public List<BookingModel> GetAllData()
        {
            return _repo.GetBookingsFromFile();
        }

        public bool AddBooking(BookingModel booking)
        {
            List<BookingModel> bookings = _repo.GetBookingsFromFile();

            bookings.Add(booking);

            _repo.SaveAllDataIntoFile(bookings);

            return true;
        }

        public BookingModel SearchByBookingId(int BookingId)
        {
            List<BookingModel> bookings = _repo.GetBookingsFromFile();

            foreach (BookingModel booking in bookings)
            {
                if (booking.GetBookingId() == BookingId)
                {
                    return booking;
                }
            }

            return null;
        }

        public bool UpdateBookingStatus(int BookingId, string status)
        {
            List<BookingModel> bookings = _repo.GetBookingsFromFile();

            foreach (BookingModel booking in bookings)
            {
                if (booking.GetBookingId() == BookingId)
                {
                    booking.SetBookingStatus(status);

                    _repo.SaveAllDataIntoFile(bookings);

                    return true;
                }
            }

            return false;
        }
        public List<BookingModel> GetConfirmedBookings()
        {
            List<BookingModel> bookings = _repo.GetBookingsFromFile();
            List<BookingModel> confirmedBookings = new List<BookingModel>();

            foreach (BookingModel booking in bookings)
            {
                if (booking.GetBookingStatus() == "Confirmed")
                {
                    confirmedBookings.Add(booking);
                }
            }

            return confirmedBookings;
        }

    }
}
