
using System.ComponentModel.DataAnnotations;

namespace ProjectIntake.Models
{
    public class AccountModel
    {
        private string firstName;
        private string lastName;
        private string email;
        private string organization;
        private string password;
        private int id;
        

        public AccountModel() {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
            this.email = string.Empty;
            this.organization = string.Empty;
            this.password = string.Empty;
            this.id = 0;
        }


        public AccountModel(string firstName, string lastName, string email, string organization, string password, int id) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.organization = organization;
            this.password = password;
            this.id = id;
        }

        public AccountModel(string firstName, string lastName, string email, string organization, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.organization = organization;
            this.password = password;
        }

        //for logging in
        public AccountModel(string firstName, string lastName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
        }

        public string FirstName {
            get 
            { 
                return firstName; 
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }


        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

       
        public string Organization
        {
            get
            {
                return organization;
            }
            set
            {
                organization = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        //need to learn how to add cookie here
    }
}
