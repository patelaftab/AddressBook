using AddressBookPro_;

namespace AddressBook
{
    internal class AddressBook
    {
        static void Main(string[] args)
        {
            ContactList contact = new ContactList();
            contact.WelcomeMessage();
        ReEnteringApp:                         //ability to add multiple address book hence repeating the complete process using label .
            Console.WriteLine("Select any one from below options \n" +
                "Press 1 : to Create/Add a new contact\n" +
                "Press 2 : to Edit/Modify any existing contact\n" +
                "Press 3 : to view all the contacts in Address book.\n" +
                "Press 4 : to delete any existing contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddPerson();        //Adding persom
                    break;
                case 2:
                    contact.EditPerson();       //Editing existing contact
                    break;
                case 3:
                    contact.ListPeople();       //viewing all contacts.
                    break;
                case 4:
                    contact.RemovePerson();     //deleting existing contact .
                    break;
                default:
                    Console.WriteLine("Invalid Option selected , Please try again ");
                    break;
            }
            goto ReEnteringApp;     //for repeatation of same task from start point have used goto control statement .
        }
    }
}
