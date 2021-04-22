using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skhedule
{
    class User
    {
        //Instance
        private string usserUname;
        private string usserPass;
        private string usserEmail;
        private string usserID;

        //Properties
        public string Ussername
        {
            get { return usserUname; }
            set { usserUname = value; }
        }

        public string Password
        {
            get { return usserPass; }
            set { usserPass = value; }
        }

        public string Email
        {
            get { return usserEmail; }
            set { usserEmail = value; }
        }

        public string ID
        {
            get { return usserID; }
            set { usserID = value; }
        }

        //Cosntructor
        public User() { }
        public User(string formUssername, string formPassword)
        {
            Ussername = formUssername;
            Password = formPassword;
        }

        //Method
        public void signUp()
        {
            //usser add new ussername and password
        }

        public bool login(string formUssername, string formPassword)
        {
            //dummy login
            if (formUssername == "admin" & formPassword == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void addAct()
        {
            //add new activity (name, deadline, desc, type)
        }

        public void editAct()
        {
            //edit activity detail
        }
    }
}
