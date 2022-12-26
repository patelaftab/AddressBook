using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPro_
{
    public class ContactList
    {
        Person person = new Person();
        List<Person> people = new List<Person>();
        public void WelcomeMessage()    //Welcome Message
        {
            Console.WriteLine("Welcome to Address Book Program!\n");
        }
        public void AddPerson()     //Adding Person .
        {
            person = new Person();
            Console.WriteLine("Enter your First Name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter your Phone Number");
            person.phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your email id");
            person.emailId = Console.ReadLine();
            people.Add(person);
        }
        public void ListPeople()        //List of all Contacts/People's.
        {
            if (people.Count == 0)
            {
                Console.WriteLine("Your Address book is empty. Press any key to continue");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Here are the current people found in your address book :");
            foreach (var person in people)
            {
                Console.WriteLine($"\n First Name : {person.firstName}\n Last Name : {person.lastName}\n Address : {person.address}\n Phone Number : {person.phoneNo}\n Email ID : {person.emailId}");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
