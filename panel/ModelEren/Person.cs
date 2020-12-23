using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panel.Models
{
    public abstract class Person
    {

        private string firstName;
        private string lastName;
        private string gender;
        private string email;
        private string password;



        private int departmentID;

        public string Name
        {
            get { return this.firstName + " " + this.lastName; }
            
        }


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public int DepartmentID { get => departmentID; set => departmentID = value; }
        



        //public string Email
        //{

        //    get
        //    {

        //        return this.email;

        //    }
        //}
        //public string Password
        //{

        //    set {

        //        if (this.password.Length <= 8)
        //        {

        //            throw new Exception("Şifre 9 karakterden az olamaz!");

        //        }

        //        this.password = value;

        //    }
        //}

        public Person()
        {
            //Console.WriteLine("Person Constructor");
        }

        public Person(string firstName, string lastName, string gender, 
            string email, string password,int departmentID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Email = email;
            this.Password = password;

            this.DepartmentID = departmentID;
        }



        //public Person(string firstName, string lastName, string gender, string email, string password, int departmentID)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.gender = gender;
        //    this.email = email;
        //    this.password = password;
        //    this.departmentID = departmentID;
        //}

        ////just signature
        //public abstract void Login(string email, string password);

        public virtual Person Login(string email, string password)
        {

            try
            {
                {

                    if (email == "Admin" && password == "123")
                    {

                        return null;

                    }

                    else
                    {
                        Console.WriteLine("Username or Password is incorrect!");
                    }

                }
                return null;
            }
            catch (Exception Ex)
            {

                throw new Exception(Ex.Message);
            }
            
        }

        public void Logout(Person P)
        {

            try
            {

                if (P is Employee) //"==" yemez burada!
                {

                    Console.WriteLine($"Thank you {P.FirstName}; you are an Employee!");

                }

                if (P is Student)
                {

                    Console.WriteLine($"Thank you {P.FirstName}; you are an Student!");

                }

            }
            catch (Exception)
            {

                throw new Exception("Error in Logout!");
            }

        }

    }

}
