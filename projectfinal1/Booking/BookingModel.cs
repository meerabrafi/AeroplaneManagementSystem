using System;
using System.Collections.Generic;
using System.Text;

namespace projectfinal1.Booking
{
            class BookingModel
    {

        private int BookingId;      
        private string BookingStatus;
        private string BookingDate;
        public BookingModel(int BookingId, string BookingStatus, string BookingDate)
        {
            this.BookingId = BookingId;
            this.BookingStatus = BookingStatus;
            this.BookingDate = BookingDate;
        }
        public int GetBookingId()
        {

            return BookingId;

        }
        public void SetBookingId(int BookingId)
        {

            this.BookingId = BookingId;

        }

        public string GetBookingStatus()

        {

            return BookingStatus;

        }

        public void SetBookingStatus(string BookingStatus)

        {

            this.BookingStatus = BookingStatus;

        }

        public string GetBookingDate()

        {

            return BookingDate;

        }
        public void SetBookingDate(string BookingDate)
        {

            this.BookingDate = BookingDate;
        }
        public override string ToString()
        {

            return $"{BookingId},{BookingStatus},{BookingDate}";
        }

    }

}