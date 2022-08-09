class Program
{

    public class Company
    {
        public Company()
        {

        }

        public string name;
        public string address;
        public string phoneNum;
        public string faxNum;
        public string webURL;

        public class Manager
        {
            public Manager()
            {

            }

            public string firstName;
            public string lastName;
            public string phoneNum;
        }

        Manager manager = new Manager();

        public void getCompanyInfo()
        {
            Console.WriteLine("Company Name:");
            name = Console.ReadLine();
            Console.WriteLine("Company Address:");
            address = Console.ReadLine();
            Console.WriteLine("Company Phone Number");
            phoneNum = Console.ReadLine();
            Console.WriteLine("Company Fax Number");
            faxNum = Console.ReadLine();
            Console.WriteLine("Website URL:");
            webURL = Console.ReadLine();
            Console.WriteLine("Manager First Name:");
            manager.firstName = Console.ReadLine();
            Console.WriteLine("Manager Surename:");
            manager.lastName = Console.ReadLine();
            Console.WriteLine("Manager Phone Number:");
            manager.phoneNum = Console.ReadLine();

        }

        public void printCompanyInfo()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("     Company Info      ");  
            Console.WriteLine("=======================");
            Console.WriteLine("Company name: " + name);
            Console.WriteLine("Company address: " + address);
            Console.WriteLine("Company phone: " + phoneNum);
            Console.WriteLine("Company fax: " + faxNum);
            Console.WriteLine("Company URL: " + webURL);
            Console.WriteLine("Manager First Name: " + manager.firstName);
            Console.WriteLine("Manager Last Name: " + manager.lastName);
            Console.WriteLine("Manager phone: " + manager.phoneNum);
        }

    }
    static void Main()
    {
        Company company = new Company();
        company.getCompanyInfo();
        company.printCompanyInfo();
    }


}