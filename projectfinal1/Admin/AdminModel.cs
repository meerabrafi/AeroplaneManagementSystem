using System;
using System.Collections.Generic;
using System.Text;

namespace projectfinal1.Admin {
    internal class AdminModel
    {
        private int AdminId;  
        private string Username;
        private string Password;
        public AdminModel(int AdminId,
        string Username,
        string Password)
        {
            this.AdminId = AdminId;
            this.Username = Username;
            this.Password = Password;
        }

        public int GetAdminId()
        {
            return AdminId;

        }
        public void SetAdminId(int AdminId)
        {
            this.AdminId = AdminId;
        }
        public string GetUsername()
        {
            return Username;
        }
        public void SetUsername(string Username)
        {
            this.Username = Username;
        }
        public string GetPassword()
        {
            return Password;
        }
        public void SetPassword(string Password)
        {
            this.Password = Password;
        }
        public override string ToString()
        {
            return $"{AdminId},{Username},{Password}";
        }
    }
}
\