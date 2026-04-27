using System;
using System.Collections.Generic;


public class UtilitiesManager
{
    public List<ServiceRequest> Requests = new List<ServiceRequest>(); //0Creates a list to hold service requests

    //Add Request
    public void AddRequest(ServiceRequest request)
    {
        Requests.Add(request);
    }

    public void DisplayQue()
    {
        Console.WriteLine("\n=== SERVICE REQUEST QUEUE ===");
        foreach (var request in Requests)
        {
            Console.WriteLine($"{request.RequestType} | Urgency: {request.CalculateUrgency()}");
        }
    }

    public void ProcessRequests()
    {
        foreach (var request in Requests)
        {
            Console.WriteLine("\nProcessing Request...");
            Console.WriteLine($"Resident: {request.Resident.Name}");
            Console.WriteLine($"Request Type: {request.RequestType}");
            Console.WriteLine($"Urgency Score: {request.CalculateUrgency()}");
        }
    }
}
