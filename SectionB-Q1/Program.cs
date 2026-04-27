public class Resident
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string AccNumber { get; set; }
    double MonthlyUseage { get; set; }
    public Resident(string name, string address, string accNumber, double monthlyUsage)
    {
        Name = name;
        Address = address;
        AccNumber = accNumber;
        MonthlyUseage = monthlyUsage;
        
    }
}