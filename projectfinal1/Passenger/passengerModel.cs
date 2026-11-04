using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace projectfinal1.Passenger
{
    internal class PassengerModel
    {
        private string name;
        private int age;
        private string gender;
        private string passportNumber;

        private string seat_preference;
        private string meal_preference;
       
       
        public PassengerModel()
        {

        }
        public PassengerModel(string name, int age, string gender,
            string passportNumber, string seat_preference,
            string meal_preference)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.passportNumber = passportNumber;
            this.seat_preference = seat_preference;
            this.meal_preference = meal_preference;
                }
            public void SetName (string name)
            {
                this.name = name;
        }
        public string GetName()
        {

            return this.name;

        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge() {
            return this.age;

    }
        public void SetGender(string gender)
        {
            this.gender = gender;
        }
        public string GetGender()
        {
            return this.gender;
        }
        public void SetPassportNumber(string  passportNumber)
        {
            this.passportNumber = passportNumber;
        }

        public string GetPassportNumber()
        {
            return this.passportNumber;
        }
        
        public void SetSeatPreference(string seat_preference) 
        {
            this.seat_preference= seat_preference;
        }
        public string GetSeatPreference ()
        {
            return this.seat_preference ;
        }


        public void SetMealPreference(string meal_preference)
        {
            this.meal_preference= meal_preference;
        }
        public string GetMealPreference()
        {
            return this.meal_preference;
        }
        
        public override string ToString()
        {
            return $"{name},{age},{gender},{passportNumber},{seat_preference},{meal_preference}";
        }
    }
}
    

