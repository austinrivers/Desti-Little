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
        /// <summary>
        /// A representation of an Airplane in AirlineManager
        /// </summary>
        public RangeClass rangeClass;
        public string modelName;
        public double Price;
        public double consumption;
        public double speed;
        public double wearCoeficientPercent;
        public int range;
        public int categoryRequired;
        public int maxEconomy;
        public int maxBusiness;
        public int maxFirst;
        public int maxCargo;

        public Plane(RangeClass _rangeClass, string _modelName, double _price
                    , double _consumption, double _speed, double _wearCoeficentPercent
                    , int _range, int _categoryRequired, int _maxEconomy, int _maxBusiness
                    , int _maxFirst, int _maxCargo)
        {
            rangeClass = _rangeClass;
            modelName = _modelName;
            Price = _price;
            consumption = _consumption;
            speed = _speed;
            wearCoeficientPercent = _wearCoeficentPercent;
            range = _range;
            categoryRequired = _categoryRequired;
            maxEconomy = _maxEconomy;
            maxBusiness = _maxBusiness;
            maxFirst = _maxFirst;
            maxCargo = _maxCargo;
        }
    }
}
