using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the CRM connection string and connect to the CRM Organization
            CrmServiceClient crmConn = new CrmServiceClient(ConfigurationManager.ConnectionStrings["CRM"].ConnectionString);
            IOrganizationService crmService = crmConn.OrganizationServiceProxy;

            Console.WriteLine("Please input first name: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Please input Last name: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Please input ERP ID: ");
            string erpid = Console.ReadLine();

            Console.WriteLine("Please input Bio Info: ");
            string bio = Console.ReadLine();


            Entity contact = new Entity("contact");
            contact["lastname"] = lname;
            contact["firstname"] = fname;
            contact["datatel_erpid"] = erpid;
            contact["regent_biography"] = bio;
            crmService.Create(contact);

        }
    }
}
