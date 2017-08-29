using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteConfigurator
{
    /// <summary>
    /// The classification of the airplane
    /// </summary>
    public enum PlaneType
    {
        Unknown,
        ShortHaul,
        MediumHaul,
        LongHaul,
        Cargo
    }

    class Plane
    {
        /// <summary>
        /// A representation of an Airplane in AirlineManager
        /// </summary>
        public string ModelName;
        public string Manufacturer;
        public int Range;
        public int CategoryNeeded;
        public double Price;
        public double ConsumptionRate;
        public double Speed;
        public double WearCoeficientPercent;
        public int MaxEconomy;
        public int MaxBusiness;
        public int MaxFirst;
        public int MaxCargo;
        public int CargoWithMaxEcon;
        public int CargoWithMaxBusiness;
        public int CargoWithMaxFirst;
        public PlaneType PlaneType = PlaneType.Unknown;

        public bool ExistsInSQL;
        public bool NeedsUpdateToSQL;


        public Plane(string modelName)
        {
            ModelName = modelName;
        }

        public void NewPlaneInsert()
        {

        }
    }
}
