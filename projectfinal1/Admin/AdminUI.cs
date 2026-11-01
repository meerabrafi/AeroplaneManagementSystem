using System;
using System.Collections.Generic;
using System.Text;

namespace projectfinal1.Admin
{
    internal class AdminUI
    {
        

        
            private AdminService service = new AdminService();

        public void AdminDriver()
        {
            while (true)
            {
                string option = AdminMenu();

                if (option == "1")
                {
                    AdminModel admin = TakeInput();
                    service.AddAdmin(admin);
                    Console.WriteLine("Admin Added Successfully!...");
                }
                else if (option == "2")
                {
                    DisplayAll();
                }
                else if (option == "3")
                {
                    SearchAdmin();
                }
                else if (option == "4")
                {
                    CheckUsername();
                }
                else if (option == "5")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option!...");
                }
            }
        }
            public void DisplayAll()
            {
                List<AdminModel> admins = service.GetAllData();

                foreach (AdminModel admin in admins)
                {
                    Console.WriteLine(admin.ToString());
                }

                Console.ReadKey();
            }

        public void SearchAdmin()
        {
            Console.WriteLine("Enter admin ID:");
            int admin_id = int.Parse(Console.ReadLine());
            List<AdminModel> admins = service.GetAllData();
            bool found = false;
            foreach (AdminModel admin in admins)
            {
                if (admin.GetAdminId() == admin_id)
                {
                    Console.WriteLine(admin.ToString());
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                Console.WriteLine("Admin not Found!");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void CheckUsername()
            {
                Console.WriteLine("Enter Username:");
                string username = Console.ReadLine();

                bool exists = service.CheckAdminExists(username);

                if (exists)
                {
                    Console.WriteLine("Username already Exists..!");
                }
                else
                {
                    Console.WriteLine("Username Available....!");
                }
            }

            public AdminModel TakeInput()
            {
                Console.WriteLine("Enter Admin ID:");
                int admin_id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Username:");
                string username = Console.ReadLine();

                Console.WriteLine("Enter Password:");
                string password = Console.ReadLine();

                AdminModel admin = new AdminModel(admin_id, username, password);

                return admin;
            }

            public string AdminMenu()
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("-------ADMIN MANAGMENT-------");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1. Add New Admin");
                Console.WriteLine("2. View All Admins");
                Console.WriteLine("3. Search Admin By ID");
                Console.WriteLine("4. Check Username");
                Console.WriteLine("5. Back to Main Menu");

                Console.WriteLine("Enter Your Choice:");

                string option = Console.ReadLine();

                return option;
            }
        }
    }



