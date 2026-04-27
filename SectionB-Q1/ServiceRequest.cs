public class ServiceRequest
{
    public string RequestType { get; set; }
    public int Priority { get; set; }
    public int Severity { get; set; }
    public int EstimatedHours { get; set; }

    public Resident Resident { get; set; } //Refers to Resident.cs 

    public ServiceRequest(string type, int priority, int severity, int estimatedHours, Resident resident)
    {
        RequestType = type;
        Priority = priority;
        Severity = severity;
        EstimatedHours = estimatedHours;
        Resident = resident;
    }

    public int CalculateUrgency()
    {
        return Priority * Severity;
    }
}