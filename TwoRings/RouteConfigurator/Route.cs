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
        public string callsign;
        public string airportName;
        public int distance;
        public int categoryMax;
        public int taxPerTakeoff;
        public int price;
        public int demandEconomy;
        public int demandBusiness;
        public int demandFirst;
        public int demandCargo;


        public Route(string _callSign, string _airportName, int _distance, int _categoryMax
                    ,int  _taxPerTakeoff, int _price, int _demandEconomy, int _demandBusiness
                    ,int _demandFirst, int _demandCargo)
        {
            callsign = _callSign;
            airportName = _airportName;
            distance = _distance;
            categoryMax = _categoryMax;
            taxPerTakeoff = _taxPerTakeoff;
            price = _price;
            demandEconomy = _demandEconomy;
            demandBusiness = _demandBusiness;
            demandFirst = _demandFirst;
            demandCargo = _demandCargo;
        }
    }
}
