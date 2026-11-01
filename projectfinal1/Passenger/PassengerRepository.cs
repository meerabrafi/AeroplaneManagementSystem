using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace projectfinal1.Passenger
{
    internal class PassengerRepository
    {

        private string file = "passengers.txt";
        public void SaveInFile(PassengerModel passenger)
        {

            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(passenger.ToString());
            }

        }
        public void SaveAllDataIntoFile(List<PassengerModel> passengers)
        {
            File.WriteAllText(file, "");
            foreach( PassengerModel passenger in passengers)
            {
                SaveInFile(passenger);
            }

            
        }
        public List<PassengerModel> GetPassengersFromFile()
        {
            List<PassengerModel> passengerModels = new List<PassengerModel>();

            if (File.Exists(file))
            {
                using (StreamReader stream = new StreamReader(file))
                {
                    string line = "";

                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        string name = parts[0];
                        int age = int.Parse(parts[1]);
                        string gender = parts[2];
                        string passportNumber = parts[3];
                        string seat_preference = parts[4];
                        string meal_preference = parts[5];

                        PassengerModel passenger = new PassengerModel(
                            name, age, gender, passportNumber,
                            seat_preference, meal_preference);

                        passengerModels.Add(passenger);
                    }
                }
            }

            return passengerModels;
        }

        




                }


            }
            

        