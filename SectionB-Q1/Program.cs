class Program
{
    static void Main(string[] args)
    {
        List<Resident> residents = new List<Resident>();
        UtilitiesManager manager = new UtilitiesManager();

        Console.Write("Enter number of residents: ");
        int numResidents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numResidents; i++)
        {
            Console.WriteLine($"\nResident {i + 1}"); //Heading

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            string acc = Console.ReadLine();

            Console.Write("Monthly Usage: ");
            double usage = double.Parse(Console.ReadLine());

            residents.Add(new Resident(name, address, acc, usage));
        }

        Console.Write("Enter number of service requests: ");
        int numRequests = int.Parse(Console.ReadLine());

        for (int i = 0; i < numRequests; i++)
        {
            Console.WriteLine($"\nService Request {i + 1}"); 

            Console.Write("Request Type: ");
            string type = Console.ReadLine();

            Console.Write("Priority (1-5): ");
            int priority = int.Parse(Console.ReadLine());

            Console.Write("Severity (1-10): ");
            int severity = int.Parse(Console.ReadLine());

            Console.Write("Estimated Hours: ");
            int hours = int.Parse(Console.ReadLine());

            manager.AddRequest(new ServiceRequest(type, priority, severity, hours, residents[0]));
        }

        manager.DisplayQue();
        manager.ProcessRequests();
    }
}