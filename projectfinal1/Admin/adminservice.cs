using System;
using System.Collections.Generic;
using System.Text;

namespace projectfinal1.Admin
{
    internal class AdminService
    {
        private adminrepo _repo = new adminrepo();
        public AdminService()
        {

        }
        public List<AdminModel> GetAllData()
        {
            return _repo.GetAdminsFromFile();
        }

        public bool AddAdmin(AdminModel admin)
        {
            List<AdminModel> admins = _repo.GetAdminsFromFile();
            admins.Add(admin);
            _repo.SaveAllDataIntoFile(admins);
            return true;
        }
        public AdminModel SearchById(int admin_id)
        {
            List<AdminModel> admins = _repo.GetAdminsFromFile();
            foreach (AdminModel admin in _repo.GetAdminsFromFile())
            {
                if (admin.GetAdminId() == admin_id)
                {
                    return admin;
                }

            }
            return null;
        }

           public bool CheckAdminExists(string Username)
            {
            List<AdminModel> admins = _repo.GetAdminsFromFile();
            foreach (AdminModel admin in _repo.GetAdminsFromFile())
                {
                    if (admin.GetUsername() == Username)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    
}