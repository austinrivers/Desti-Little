using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteConfigurator
{

    public enum RangeClass
    {
        Unknown,
        ShortHaul,
        MediumHaul,
        LongHaul, 
        Cargo
    }

    class Plane
    {
        public RangeClass rangeClass;
        public string modelName;
        public double Price;
        public double consumption;
        public double speed;
        public double wareCoeficientPercent;
        public int range;
        public int categoryRequired;
        public int maxEconomy;
        public int maxBusiness;
        public int maxFirst;
        public int maxCargo;
    }
}
