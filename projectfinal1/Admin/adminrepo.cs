using System;
using System.Collections.Generic;
using System.IO;


namespace projectfinal1.Admin 
{
    internal class adminrepo
    {
        private string file = "admin.txt";


        public void SaveInFile(AdminModel admin)
        {
            using (StreamWriter stream = new StreamWriter(file, true))
            {
                stream.WriteLine(admin.ToString());
            }
        }
        public void SaveAllDataIntoFile(List<AdminModel> admins)
        {
            File.WriteAllText(file, "");
            foreach (AdminModel admin in admins)
            {
                SaveInFile(admin);
            }
        }
        public List<AdminModel> GetAdminsFromFile()
        {
            List<AdminModel> adminModels = new List<AdminModel>();

            if (File.Exists(file))
            {
                using (StreamReader stream = new StreamReader(file))
                {
                    string line = "";
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int AdminId = int.Parse(parts[0]);
                        string Username = parts[1];
                        string Password = parts[2];
                        AdminModel admin = new AdminModel(AdminId, Username, Password);
                        adminModels.Add(admin);
                    }
                }
            }
            return adminModels;
        }
    }
}


