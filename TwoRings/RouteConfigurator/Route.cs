using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteConfigurator
{
    public class Route
    {
        /// <summary>
        /// A representation of what a route is in AirlineManager
        /// </summary>
        public int RouteID;
        public Hub Hub;
        public string CallSign;
        public string AirportName;
        public bool Active;
        public bool AuditOnly;
        public DateTime AuditDate;
        public int MaxCategory;
        public int Distance;
        public int TaxPerFlight;
        public int DemandEconomy;
        public int DemandBusiness;
        public int DemandFirst;
        public int DemandCargo;


        public Route(int routeID)
        {
            RouteID = routeID;
        }
    }
}
