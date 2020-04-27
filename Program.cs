  
using System;
using System.Collections.Generic;

namespace RandallsCarLot
{
    class Program
    {
        static void Main (string[] args)
        {
    //  vehicles  each sale    each vehicle           make      subaru
        List<Dictionary<string, Dictionary<string, String>>> vehicles = new List <Dictionary<string, Dictionary<string, String>>>();

        Dictionary<string, Dictionary<string, string>> sale1 = new Dictionary<string, Dictionary<string, string>>();

        Dictionary<string, string> vehicle = new Dictionary<string, string>();
    
        Dictionary<string, string> salesAgent = new Dictionary<string, string>();

        Dictionary<string, string> credit = new Dictionary<string, string>();

        vehicle.Add("year","2008");
        vehicle.Add("model","Damfresh");
        vehicle.Add("make","Biotraxquote");
        vehicle.Add("color","sky magenta");

        salesAgent.Add("mobile", "896 478-6975");
        salesAgent.Add("lastName", "Botsford");
        salesAgent.Add("firstName", "Shaina");

        credit.Add("creditProvider", "JP Morgan Chase");
        credit.Add("account", "601109582720302");

        sale1.Add("vehicle",vehicle);
        sale1.Add("sales_agent", salesAgent);
        sale1.Add("credit", credit);

        vehicles.Add(sale1);

        Dictionary<string, Dictionary<string, string>> sale2 = new Dictionary<string, Dictionary<string, string>>();

        Dictionary<string, string> vehicle2 = new Dictionary<string, string>();
    
        Dictionary<string, string> salesAgent2 = new Dictionary<string, string>();

        Dictionary<string, string> credit2 = new Dictionary<string, string>();

        vehicle2.Add("year","2008");
        vehicle2.Add("model","Damfresh");
        vehicle2.Add("make","Biotraxquote");
        vehicle2.Add("color","sky magenta");

        salesAgent2.Add("mobile", "896 478-6975");
        salesAgent2.Add("lastName", "Botsford");
        salesAgent2.Add("firstName", "Shaina");

        credit2.Add("creditProvider", "JP Morgan Chase");
        credit2.Add("account", "601109582720302");

        sale2.Add("vehicle",vehicle);
        sale2.Add("sales_agent", salesAgent);
        sale2.Add("credit", credit);

        vehicles.Add(sale2);


       }
    }
}
