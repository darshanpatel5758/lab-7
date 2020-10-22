using System;
using System.Text.RegularExpressions;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid name:");
            string name = Console.ReadLine();
           
            if (Valiatenames(name))
                Console.WriteLine("Name is valid!\n");
            else
                Console.WriteLine("Sorry, name is not valid!\n");


            Console.WriteLine("Please enter a valid email:");
            string email = Console.ReadLine();

            if (Validateemail(email))
                Console.WriteLine("Email is valid!\n");
            else
                Console.WriteLine("Sorry, email is not valid!\n");

            Console.WriteLine("Please enter a valid phone number: ");
            string number = Console.ReadLine();

            if (ValidateNumber(number))
                Console.WriteLine("Phone Number is valid!\n");
            else
                Console.WriteLine("Sorry, Phone Number is not valid!\n");

            Console.WriteLine("Please enter a valid date:  ");
            string date = Console.ReadLine();

            if (ValidateDate(date))
                Console.WriteLine("Date is valid!\n");
            else
                Console.WriteLine("Sorry, date is not valid!\n");

            Console.WriteLine("Please enter a valid HTML elements:  ");
            string html = Console.ReadLine();

            if (ValidateDate(html))
                Console.WriteLine("HTML elements is valid!\n");
            else
                Console.WriteLine("Sorry, HTML elements is not valid!\n");



        }

        static bool Valiatenames(string name)
        {
            Regex userName = new Regex(@"^(?=[a-zA-Z ]{2,30}$)[A-Z][a-zA-Z]+(?:[ ]+[a-zA-Z][a-zA-Z]+)*$");            

            return userName.IsMatch(name);
        }

        static bool Validateemail(String email)
        {
            Regex userEmail = new Regex(@"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z0-9]{2,3}$");

            return userEmail.IsMatch(email);
        }

        static bool ValidateNumber(String number)
        {
            Regex userNumber = new Regex(@"\d{3}-\d{3}-\d{4}");

            return userNumber.IsMatch(number);
        }

        static bool ValidateDate(String date)
        {
            Regex userDate = new Regex(@"\d{2}/\d{2}/\d{4}");

            return userDate.IsMatch(date);
        }

        static bool ValidateHtml(String html)
        {
            Regex userHtml = new Regex(@"^<[a-zA-z0-9]{2}> <\/[a-zA-z0-9]{2}>$");

            return userHtml.IsMatch(html);

        }
    }
}
