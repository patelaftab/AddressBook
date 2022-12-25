namespace AddressBook
{
    internal class AddressBook
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Address Book Program!\n");
        }
        public AddressBook() { }
        public static void Main(string[] args)
        {
            WelcomeMessage();
        }
    }
}