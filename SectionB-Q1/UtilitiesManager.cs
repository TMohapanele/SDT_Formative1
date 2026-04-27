using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class  UtilitiesManager
{
    Public List<ServiceRequest> Requests - new List<ServiceRequest>();

    public void AddRequest(ServiceRequest request)
    {
        Requests.Add(request);
    }
